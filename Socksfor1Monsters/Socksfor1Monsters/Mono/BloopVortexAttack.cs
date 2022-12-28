using ECCLibrary;
using ECCLibrary.Internal;
using Socksfor1Monsters.Prefabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Socksfor1Monsters.Mono
{
    public class BloopVortexAttack : CreatureAction
    {
        private GameObject mouth;
        private float timeLastPerformed = 0f;
        private const float vortexMinInterval = 10f;
        private AudioSource vortexAttackSource;
        private bool sucking;
        private float timeStopSucking;
        private const float suckLength = 5f;
        private LastTarget lastTarget;
        private GameObject myVfx;
        const float currentInterval = 0.2f;
        private float timeLastCurrent;
        
        public override void Awake()
        {
            base.Awake();
            lastTarget = gameObject.GetComponent<LastTarget>();
            mouth = gameObject.SearchChild("Mouth");
            vortexAttackSource = gameObject.AddComponent<AudioSource>();
            vortexAttackSource.clip = ECCAudio.LoadAudioClip("BloopVortexAttack");
            vortexAttackSource.spatialBlend = 1f;
            vortexAttackSource.minDistance = 5f;
            vortexAttackSource.maxDistance = 30f;
            vortexAttackSource.volume = ECCHelpers.GetECCVolume();
            myVfx = GameObject.Instantiate(Bloop.vortexVfx, transform, false);
            myVfx.transform.localScale *= 2f;
            myVfx.transform.localPosition = new Vector3(0f, 0f, 10f);
            myVfx.SetActive(false);
        }

        public override float Evaluate(Creature creature)
        {
            if(sucking && Time.time < timeStopSucking)
            {
                return 1f;
            }
            if(Time.time < timeLastPerformed + vortexMinInterval)
            {
                return 0f;
            }
            if(creature.Aggression.Value >= 0.9f)
            {
                return 1f;
            }
            return 0f;
        }

        public override void StartPerform(Creature creature)
        {
            sucking = true;
            timeStopSucking = Time.time + suckLength;
            timeLastPerformed = Time.time;
            vortexAttackSource.Play();
            creature.Aggression.Value = Mathf.Clamp01(creature.Aggression.Value - 0.5f);
            Vector3 lookDirection = transform.forward;
            if (lastTarget.target != null)
            {
                lookDirection = (transform.position - lastTarget.transform.position).normalized;
                swimBehaviour.LookAt(lastTarget.target.transform);
            }
            WorldForces.AddCurrent(mouth.transform.position, DayNightCycle.main.timePassed, 10f, -lookDirection, 100f, 3f);
            creature.GetAnimator().SetBool("vortex", true);
            myVfx.SetActive(true);
        }

        public override void Perform(Creature creature, float deltaTime)
        {
            if(Time.time > timeLastCurrent + currentInterval)
            {
                WorldForces.AddCurrent(mouth.transform.position, DayNightCycle.main.timePassed, 20f, -transform.forward, 100f, 3f);
                timeLastCurrent = Time.time;
            }
        }
        public override void StopPerform(Creature creature)
        {
            sucking = false;
            swimBehaviour.LookAt(null);
            creature.GetAnimator().SetBool("vortex", false);
            myVfx.SetActive(false);
        }
    }
}
