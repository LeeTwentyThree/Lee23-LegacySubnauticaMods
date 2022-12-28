using UnityEngine;
using ECCLibrary;
using ECCLibrary.Internal;
using System.Collections;

namespace Socksfor1Monsters.Mono
{
    public class BloopMeleeAttack : MeleeAttack
    {
        private AudioSource vehicleSwallowSource;
        private ECCAudio.AudioClipPool biteClipPool;
        private GameObject throat;

        void Start()
        {
            vehicleSwallowSource = gameObject.AddComponent<AudioSource>();
            vehicleSwallowSource.minDistance = 10f;
            vehicleSwallowSource.maxDistance = 40f;
            vehicleSwallowSource.spatialBlend = 1f;
            vehicleSwallowSource.volume = ECCHelpers.GetECCVolume();
            biteClipPool = ECCAudio.CreateClipPool("BlazaBite");
            gameObject.SearchChild("Mouth").GetComponent<OnTouch>().onTouch = new OnTouch.OnTouchEvent();
            gameObject.SearchChild("Mouth").GetComponent<OnTouch>().onTouch.AddListener(OnTouch);
            throat = gameObject.SearchChild("Throat");
        }
        public override void OnTouch(Collider collider)
        {
            if (frozen)
            {
                return;
            }
            if (liveMixin.IsAlive() && Time.time > timeLastBite + biteInterval)
            {
                Creature component = GetComponent<Creature>();
                if (component.Aggression.Value >= 0.1f)
                {
                    GameObject target = GetTarget(collider);
                    Player player = target.GetComponent<Player>();
                    if (player != null)
                    {
                        if (!player.CanBeAttacked() || !player.liveMixin.IsAlive() || player.cinematicModeActive)
                        {
                            return;
                        }
                        else
                        {
                            player.liveMixin.TakeDamage(500f, transform.position, DamageType.Normal, gameObject);
                            creature.GetAnimator().SetTrigger("bite");
                        }
                    }
                    LiveMixin liveMixin = target.GetComponent<LiveMixin>();
                    if (liveMixin == null) return;
                    if (!liveMixin.IsAlive())
                    {
                        return;
                    }
                    if (!CanAttackTargetFromPosition(target))
                    {
                        return;
                    }
                    if (target.GetComponent<Vehicle>())
                    {
                        BloopVehicleCinematic cinematic = target.GetComponent<BloopVehicleCinematic>();
                        if(!cinematic)
                        {
                            target.AddComponent<BloopVehicleCinematic>().throat = throat;
                            creature.GetAnimator().SetTrigger("bite");
                            component.Aggression.Value = 0f;
                            timeLastBite = Time.time;
                        }
                    }
                    else if (CanSwallow(liveMixin))
                    {
                        liveMixin.Kill(DamageType.Normal);
                        var suck = liveMixin.gameObject.AddComponent<BeingSuckedInWhole>();
                        suck.animationLength = 2f;
                        suck.target = throat.transform;
                        Destroy(liveMixin.gameObject, 2f);
                        if(liveMixin.maxHealth >= 400f)
                        {
                            animator.SetTrigger("bite");
                        }
                    }
                    else if (target.GetComponent<SubRoot>())
                    {
                        liveMixin.TakeDamage(200f, mouth.transform.position, DamageType.Normal, gameObject);
                        creature.GetAnimator().SetTrigger("bite_cyclops");
                        component.Aggression.Value = Mathf.Clamp01(component.Aggression.Value - 0.5f);
                        timeLastBite = Time.time;
                    }
                    component.Aggression.Value = Mathf.Clamp01(component.Aggression.Value - 0.2f);
                    component.Hunger.Value = Mathf.Clamp01(component.Hunger.Value - 0.1f);
                }
            }
        }
        private bool CanAttackTargetFromPosition(GameObject target)
        {
            Vector3 direction = target.transform.position - transform.position;
            float magnitude = direction.magnitude;
            int num = UWE.Utils.RaycastIntoSharedBuffer(transform.position, direction, magnitude, -5, QueryTriggerInteraction.Ignore);
            for (int i = 0; i < num; i++)
            {
                Collider collider = UWE.Utils.sharedHitBuffer[i].collider;
                GameObject gameObject = (collider.attachedRigidbody != null) ? collider.attachedRigidbody.gameObject : collider.gameObject;
                if (!(gameObject == target) && !(gameObject == base.gameObject) && !(gameObject.GetComponent<Creature>() != null))
                {
                    return false;
                }
            }
            return true;
        }
        private float GetBiteDamage(GameObject target)
        {
            if (target.GetComponent<SubControl>() != null)
            {
                return 300f; //cyclops damage
            }
            if (target.GetComponent<Creature>() != null)
            {
                return 300f;
            }
            return biteDamage; //base damage
        }
        public void OnVehicleReleased()
        {
            timeLastBite = Time.time;
        }
        private bool CanSwallow(LiveMixin lm)
        {
            if (lm.maxHealth > 1000f)
            {
                return false;
            }
            if (lm.invincible)
            {
                return false;
            }
            if (lm.gameObject.GetComponentInChildren<Vehicle>())
            {
                return false;
            }
            if (lm.gameObject.GetComponentInChildren<Player>())
            {
                return false;
            }
            return true;
        }
    }
}
