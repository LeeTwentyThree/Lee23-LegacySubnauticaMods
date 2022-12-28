using ECCLibrary;
using Socksfor1Monsters.Mono;
using UnityEngine;

namespace Socksfor1Monsters.Prefabs
{
    public class Blaza : CreatureAsset
    {
        public Blaza(string classId, string friendlyName, string description, GameObject model, Texture2D spriteTexture) : base(classId, friendlyName, description, model, spriteTexture)
        {
        }

        public override TechType CreatureTraitsReference => TechType.GhostLeviathanJuvenile;

        public override BehaviourType BehaviourType => BehaviourType.Leviathan;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.VeryFar;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(45f, 3f, 45f), 30f, 2f, 0.1f);

        public override StayAtLeashData StayAtLeashSettings => new StayAtLeashData(0.2f, 60f);

        public override bool EnableAggression => true;

        public override SmallVehicleAggressivenessSettings AggressivenessToSmallVehicles => new SmallVehicleAggressivenessSettings(0.5f, 25f);

        public override AttackLastTargetSettings AttackSettings => new AttackLastTargetSettings(0.3f, 45f, 6f, 10f, 10f, 12f);

        public override AvoidObstaclesData AvoidObstaclesSettings => new AvoidObstaclesData(0.4f, true, 5f);

        public override float Mass => 3000f;

        public override RoarAbilityData RoarAbilitySettings => new RoarAbilityData(true, 5f, 50f, "BlazaIdle", "roar", 0.15f, 15f, 25f);

        public override BehaviourLODLevelsStruct BehaviourLODSettings => new BehaviourLODLevelsStruct(50f, 300f, 1000f);

        public override EcoTargetType EcoTargetType => EcoTargetType.Leviathan;

        public override float MaxVelocityForSpeedParameter => 12f;

        public override bool CanBeInfected => false;

        public override bool AcidImmune => true;

        public override ScannableItemData ScannableSettings => new ScannableItemData(true, 6f, "Lifeforms/Fauna/Leviathans", null, null);

        public override string GetEncyDesc => "The Blaza Leviathan is a large snake-like predator found in the deep ocean. Spanning up to 200 meters, this lieform is designated a leviathan-class predator.\n\nJaws:\nThe Blaza Leviathan features a large jaw structure with many teeth that have visibly been worn out.\n\nLifecycle:\nThis species lays several eggs in its lifetime that hatch into small, harmless, eel-like cretures. Many are eaten by other predators. Given enough time, a Blaza Leviathan Larva will develop a very long and tough exoskeleton.\n\nHunting:\nThis creature has been observed coiling around its prey and inflicting large amounts of damage even onto the toughest of creatures for an easy meal.\n\nAssessment: Extreme threat, avoid.";

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            CreateTrail(prefab.SearchChild("Spine_NoPhys"), components, 5f);
            MakeAggressiveTo(35f, 2, EcoTargetType.Shark, 0f, 1.2f);

            BlazaBehaviour gulperBehaviour = prefab.AddComponent<BlazaBehaviour>();
            gulperBehaviour.creature = components.creature;

            GameObject mouth = prefab.SearchChild("Mouth");
            BlazaMeleeAttack meleeAttack = prefab.AddComponent<BlazaMeleeAttack>();
            meleeAttack.mouth = mouth;
            meleeAttack.canBeFed = false;
            meleeAttack.biteInterval = 2f;
            meleeAttack.biteDamage = 75f;
            meleeAttack.eatHungerDecrement = 0.05f;
            meleeAttack.eatHappyIncrement = 0.1f;
            meleeAttack.biteAggressionDecrement = 0.02f;
            meleeAttack.biteAggressionThreshold = 0.1f;
            meleeAttack.lastTarget = components.lastTarget;
            meleeAttack.creature = components.creature;
            meleeAttack.liveMixin = components.liveMixin;
            meleeAttack.animator = components.creature.GetAnimator();

            mouth.AddComponent<OnTouch>();
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 5000f;
        }
    }
}
