using UnityEngine;
using System.Collections.Generic;

namespace CreatureMorphs
{
    internal class MorphController : MonoBehaviour
    {
        public MorphType morph;
        public Creature creature;

        public static MorphController ControlCreature(GameObject creatureGameObject, MorphType morphType)
        {
            var component = creatureGameObject.AddComponent<MorphController>();
            component.morph = morphType;
            component.creature = creatureGameObject.GetComponent<Creature>();
            var newCreatureAction = creatureGameObject.AddComponent<UnderControlCreatureAction>();
            component.creature.actions.Insert(0, newCreatureAction);
            return component;
        }

        private void Awake()
        {
            morph.SetupController(this);
        }

        private void Update()
        {
            foreach (var ability in abilities)
            {
                ability.OnUpdate();
            }
        }

        private List<MorphAbility> abilities = new List<MorphAbility>();

        public MorphAbility AddAbility(MorphAbility ability, KeyCode input)
        {
            abilities.Add(ability);
            if (input != KeyCode.None) ability.SetInput(() => Input.GetKeyDown(input));
            ability.morphController = this;
            return ability;
        }

        public MorphAbility AddAbility(MorphAbility ability, GameInput.Button input)
        {
            abilities.Add(ability);
            ability.SetInput(() => GameInput.GetButtonDown(input));
            ability.morphController = this;
            return ability;
        }

        public MorphAbility AddAbility(MorphAbility ability, System.Func<bool> input)
        {
            abilities.Add(ability);
            ability.SetInput(input);
            ability.morphController = this;
            return ability;
        }

    }
}
