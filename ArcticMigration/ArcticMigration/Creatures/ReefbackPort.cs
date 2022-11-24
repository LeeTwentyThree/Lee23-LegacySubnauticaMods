using UnityEngine;
using ArcticMigration.Mono;

namespace ArcticMigration.Creatures
{
    internal class ReefbackPort : CreaturePortBase
    {
        public ReefbackPort(string classId, GameObject model) : base(classId, "Reefback", "Large herbivorous lifeform, raised in containment.", model, null)
        {
        }

        public override Vector2int SizeInInventory => new Vector2int(4, 4);

        public override BehaviourType BehaviourType => BehaviourType.Whale;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.VeryFar;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(100, 2, 100), 1, 5, 0.2f);

        public override EcoTargetType EcoTargetType => EcoTargetType.Whale;

        public override StayAtLeashData StayAtLeashSettings => new StayAtLeashData(0.4f, 100);

        public override RespawnData RespawnSettings => new RespawnData(false);

        public override float Mass => 10800;

        public override float MaxVelocityForSpeedParameter => 1;

        public override AnimateByVelocityData AnimateByVelocitySettings => new AnimateByVelocityData(false, 30, 30, 6);

        public override BehaviourLODLevelsStruct BehaviourLODSettings => new BehaviourLODLevelsStruct(50, 150, 500);

        public override AvoidObstaclesData AvoidObstaclesSettings => new AvoidObstaclesData(0.45f, true, 50);

        public override float TurnSpeedHorizontal => 0.02f;

        public override float TurnSpeedVertical => 3f;

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            components.swimRandom.swimForward = 1;
            components.locomotion.forwardRotationSpeed = 0.02f;
            components.locomotion.freezeHorizontalRotation = true;
            components.locomotion.driftFactor = 0.5f;
            components.locomotion.maxVelocity = 1f;
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 10000;
        }
    }
}
