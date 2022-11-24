using UnityEngine;
using ArcticMigration.Mono;

namespace ArcticMigration.Creatures
{
    internal class CrimsonRayPort : CreaturePortBase
    {
        public CrimsonRayPort(string classId, string name, GameObject model) : base(classId, name, "Large ray.", model, null)
        {
        }

        public override BehaviourType BehaviourType => BehaviourType.MediumFish;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.Medium;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(10, 2, 10), 5, 5, 0.2f);

        public override EcoTargetType EcoTargetType => EcoTargetType.MediumFish;

        public override StayAtLeashData StayAtLeashSettings => new StayAtLeashData(0.4f, 25);

        public override RespawnData RespawnSettings => new RespawnData(true, 600);

        public override float Mass => 65;

        public override float MaxVelocityForSpeedParameter => 6;

        public override AnimateByVelocityData AnimateByVelocitySettings => new AnimateByVelocityData(false, 30, 45, 0.5f);

        public override BehaviourLODLevelsStruct BehaviourLODSettings => new BehaviourLODLevelsStruct(50, 150, 500);

        public override float TurnSpeedHorizontal => 0.1f;

        public override AvoidObstaclesData AvoidObstaclesSettings => new AvoidObstaclesData(0.6f, false, 5);

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            components.locomotion.maxVelocity = 5;
            components.locomotion.maxAcceleration = 3;
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 100;
        }
    }
}
