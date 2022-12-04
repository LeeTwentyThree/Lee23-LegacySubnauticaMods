using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECCLibrary;
using UnityEngine;
using RandomEvents.Mono;

namespace RandomEvents.Creatures
{
    public class BananaDuck : CreatureAsset
    {
        public BananaDuck(string classId, string friendlyName, string description, GameObject model, Texture2D spriteTexture) : base(classId, friendlyName, description, model, spriteTexture)
        {
        }

        public override BehaviourType BehaviourType => BehaviourType.MediumFish;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.Medium;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(20f, 0f, 20f), 3f, 0.5f, 0.1f);

        public override float Mass => 15f;

        public override EcoTargetType EcoTargetType => EcoTargetType.MediumFish;

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            components.worldForces.underwaterGravity = -15f;
            components.worldForces.aboveWaterGravity = 15f;
            components.worldForces.waterDepth = -1f;
            var model = prefab.transform.GetChild(0);
            model.localScale = Vector3.one * 0.8f;
            prefab.AddComponent<QuackRandom>();
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 1000f;
        }

        public override AnimationCurve SizeDistribution => new AnimationCurve(new Keyframe(0f, 0.3f), new Keyframe(1f, 1f));
    }
}
