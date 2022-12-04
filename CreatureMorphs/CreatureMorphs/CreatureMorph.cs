using UnityEngine;
using System.Collections.Generic;

namespace CreatureMorphs
{
    internal class CreatureMorph : MonoBehaviour
    {
        public CreatureMorph(string morphClassId)
        {
            _morphClassId = morphClassId;
        }

        private string _morphClassId;

        protected float cameraFollowDistance = 3f;

        private List<MorphAbility> abilities = new List<MorphAbility>();

        public MorphAbility AddAbility(MorphAbility ability, KeyCode input)
        {
            abilities.Add(ability);
            if (input != KeyCode.None) ability.SetInput(() => Input.GetKeyDown(input));
            return ability;
        }

        public MorphAbility AddAbility(MorphAbility ability, GameInput.Button input)
        {
            abilities.Add(ability);
            ability.SetInput(() => GameInput.GetButtonDown(input));
            return ability;
        }

        public MorphAbility AddAbility(MorphAbility ability, System.Func<bool> input)
        {
            abilities.Add(ability);
            ability.SetInput(input);
            return ability;
        }

        protected virtual void Setup() { }

        private void Update()
        {
            foreach (var ability in abilities)
            {
                ability.OnUpdate();
            }
        }
    }
}
