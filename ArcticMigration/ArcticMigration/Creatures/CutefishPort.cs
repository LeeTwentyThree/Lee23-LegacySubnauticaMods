using UnityEngine;

namespace ArcticMigration.Creatures
{
    internal class CutefishPort : CreaturePortBase
    {
        public CutefishPort(string classId, GameObject model) : base(classId, "Cuddlefish", "A curious species, hatched from an egg in alien containment. No wild specimens.", model, null)
        {
        }

        public override Vector2int SizeInInventory => new Vector2int(2, 2);

        public override BehaviourType BehaviourType => BehaviourType.MediumFish;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.Global;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(10, 2, 10), 3, 5, 0.2f);

        public override EcoTargetType EcoTargetType => EcoTargetType.MediumFish;

        public override StayAtLeashData StayAtLeashSettings => new StayAtLeashData(0.7f, 5);

        public override RespawnData RespawnSettings => new RespawnData(false);

        public override float Mass => 1;

        public override float MaxVelocityForSpeedParameter => 6;

        public override BehaviourLODLevelsStruct BehaviourLODSettings => new BehaviourLODLevelsStruct(10, 50, 500);

        public override AvoidObstaclesData AvoidObstaclesSettings => new AvoidObstaclesData(0.75f, false, 5);

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            components.swimRandom.swimForward = 2;
            var leash = prefab.GetComponent<StayAtLeashPosition>();
            leash.swimVelocity = 10;
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 10000;
        }
    }
}
