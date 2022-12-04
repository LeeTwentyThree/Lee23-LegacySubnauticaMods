using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomEvents.Mono;

namespace RandomEvents.Events
{
    class SetCreatureSize : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "Creature sizes have been randomized!";

        private const float kDuration = 60f;

        private const bool kReturnToDefaultSize = false;

        public override void StartRandomEvent()
        {
            Creature[] creatures = Object.FindObjectsOfType<Creature>();
            foreach (var creature in creatures)
            {
                if (creature != null)
                {
                    float oldScale = creature.transform.localScale.x;
                    creature.transform.localScale = Vector3.one * Random.Range(0.06f, 6f);
                    if (kReturnToDefaultSize && creature.gameObject.GetComponent<ReturnToDefaultScale>() == null)
                    {
                        creature.gameObject.AddComponent<ReturnToDefaultScale>().StartCountdown(oldScale, kDuration);
                    }
                }
            }
            Utils.PlaySound("event:/creature/cute_fish/death");
        }
    }
}
