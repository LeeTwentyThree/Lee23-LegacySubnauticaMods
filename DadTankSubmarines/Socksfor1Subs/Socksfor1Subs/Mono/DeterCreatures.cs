using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class DeterCreatures : MonoBehaviour
    {
        public DadSubBehaviour sub;

        public static float smallFishDeterRadius = 100f;
        public static float aggressiveFishDeterRadius = 150f;
        public static float maxDeterRadius = 150f;

        private static FMODAsset deterSound1 = Helpers.GetFmodAsset("event:/sub/seamoth/pulse");
        private static FMODAsset deterSound2 = Helpers.GetFmodAsset("event:/sub/seamoth/torpedo_fire");

        public float timeDeterAgain;
        public float deterrenceCooldown = 6f;

        private static readonly List<EcoTargetType> _aggressiveTargetTypes = new List<EcoTargetType>()
        {
            EcoTargetType.Biter,
            EcoTargetType.Shark,
            EcoTargetType.Leviathan,
            EcoTargetType.LavaLarva,
            EcoTargetType.Whale // not aggressive but whatever
        };

        private static readonly List<EcoTargetType> _dontDeterTargetTypes = new List<EcoTargetType>()
        {
            EcoTargetType.SubDecoy,
            EcoTargetType.CuteFish,
            EcoTargetType.Cure,
            EcoTargetType.CuredWarp
        };

        public bool CanDeter
        {
            get
            {
                return CooldownCompletionPercentage >= 0.999f;
            }
        }

        public float CooldownCompletionPercentage
        {
            get
            {
                return Mathf.Clamp01(((Time.time - timeDeterAgain + deterrenceCooldown) / deterrenceCooldown));
            }
        }

        public void DeterInRange()
        {
            if (sub.InfinitePower || (sub.powerRelay.GetPower() >= Balance.DeterrencePowerUsage && sub.powerRelay.ConsumeEnergy(Balance.DeterrencePowerUsage, out var _)))
            {
                timeDeterAgain = Time.time + deterrenceCooldown;

                var playSoundPos = MainCamera.camera.transform;
                Utils.PlayFMODAsset(deterSound1, playSoundPos);
                Utils.PlayFMODAsset(deterSound2, playSoundPos);
                MainCameraControl.main.ShakeCamera(2f, 2f, MainCameraControl.ShakeMode.Quadratic, 1f);

                // non-allocated OverlapSphere generates less garbage than Physics.OverlapSphere
                var hitColliders = UWE.Utils.OverlapSphereIntoSharedBuffer(transform.position, maxDeterRadius);
                for (var i = 0; i < hitColliders; i++)
                {
                    var collider = UWE.Utils.sharedColliderBuffer[i];
                    var obj = UWE.Utils.GetEntityRoot(collider.gameObject);
                    if (obj == null)
                    {
                        obj = collider.gameObject;
                    }

                    var creature = obj.GetComponent<Creature>();

                    if (creature != null)
                        DeterCreature(transform.position, creature);
                }
            }
        }

        public void DeterCreature(Vector3 center, Creature creature)
        {
            var targetType = EcoTargetType.SmallFish;
            var ecoTarget = creature.GetComponent<EcoTarget>();
            if (ecoTarget != null)
                targetType = ecoTarget.type;

            if (TryGetDeterDistance(targetType, out var deterDistance))
            {
                if (Vector3.Distance(creature.transform.position, center) > deterDistance)
                {
                    return;
                }

                var position = center; // apparently this looks way more efficient according to Rider.
                var directionToSwim = (creature.transform.position - position).normalized;
                var targetPosition = position + (directionToSwim * deterDistance);
                var targetLeashPosition = position + (directionToSwim * (deterDistance + 10f));
                creature.Scared.Add(1f);
                creature.leashPosition = targetLeashPosition;
                var swimBehaviour = creature.GetComponent<SwimBehaviour>();
                if (swimBehaviour != null)
                {
                    float swimVelocity = 6f;
                    var fleeOnDamage = creature.GetComponent<FleeOnDamage>();
                    if (fleeOnDamage != null)
                    {
                        swimVelocity = fleeOnDamage.swimVelocity;
                    }
                    swimBehaviour.SwimTo(targetPosition, swimVelocity);
                }
            }

        }

        public bool TryGetDeterDistance(EcoTargetType creature, out float deterDistance)
        {
            if (_dontDeterTargetTypes.Contains(creature))
            {
                deterDistance = 0f;
                return false;
            }
            if (_aggressiveTargetTypes.Contains(creature))
            {
                deterDistance = aggressiveFishDeterRadius;
                return true;
            }

            deterDistance = smallFishDeterRadius;
            return true;
        }
    }
}
