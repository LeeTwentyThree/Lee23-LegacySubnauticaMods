using UnityEngine;
using System.Collections.Generic;

namespace CreatureMorphs
{
    internal class MorphController : MonoBehaviour
    {
        public MorphType morph;
        public Creature creature;
        public SwimBehaviour swimBehaviour;

        private bool _done;

        private float _swimSpeed;

        public static MorphController ControlCreature(GameObject creatureGameObject, MorphType morphType)
        {
            var component = creatureGameObject.AddComponent<MorphController>();
            component.morph = morphType;
            component.creature = creatureGameObject.GetComponent<Creature>();
            component.swimBehaviour = creatureGameObject.GetComponent<SwimBehaviour>();
            component._swimSpeed = creatureGameObject.GetComponent<SwimRandom>().swimVelocity;
            var newCreatureAction = creatureGameObject.AddComponent<UnderControlCreatureAction>();
            component.creature.actions.Insert(0, newCreatureAction);
            return component;
        }

        private void Start()
        {
            morph.SetupController(this);
        }

        public void GainControl()
        {
            _done = true;
        }

        public bool BeingControlled
        {
            get
            {
                return _done;
            }
        }

        private void Update()
        {
            if (!BeingControlled) return;
            var moveInput = GameInput.GetMoveDirection();
            swimBehaviour.SwimTo(transform.position + moveInput * _swimSpeed, _swimSpeed);
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

        private void OnDestroy()
        {
            PlayerMorphController.main.BecomeHuman();
        }
    }
}
