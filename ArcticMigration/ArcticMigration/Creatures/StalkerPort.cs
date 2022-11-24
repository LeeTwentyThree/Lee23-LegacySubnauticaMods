using UnityEngine;

namespace ArcticMigration.Creatures
{
    internal class StalkerPort : CreaturePortBase
    {
        public StalkerPort(string classId, GameObject model) : base(classId, "Stalker", "Common baracuda-like predator, raised in containment.", model, null)
        {
        }

        public override Vector2int SizeInInventory => new Vector2int(3, 3);

        public override BehaviourType BehaviourType => BehaviourType.Shark;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.Medium;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(30, 2, 30), 3, 5, 0.2f);

        public override EcoTargetType EcoTargetType => EcoTargetType.Shark;

        public override StayAtLeashData StayAtLeashSettings => new StayAtLeashData(0.4f, 15f);

        public override float Mass => 85;

        public override float MaxVelocityForSpeedParameter => 4;

        public override AttackLastTargetSettings AttackSettings => new AttackLastTargetSettings(0.5f, 8f, 3, 7, 20, 5);

        public override BehaviourLODLevelsStruct BehaviourLODSettings => new BehaviourLODLevelsStruct(10, 60, 500);

        public override AvoidObstaclesData AvoidObstaclesSettings => new AvoidObstaclesData(0.45f, false, 5f);

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            var attackLastTarget = prefab.GetComponent<AttackLastTarget>();
            attackLastTarget.aggressionThreshold = 0.75f;
            MakeAggressiveTo(20, 1, EcoTargetType.Shark, 0, 1);
            MakeAggressiveTo(15, 1, EcoTargetType.MediumFish, 0.8f, 1);
            MakeAggressiveTo(15, 1, EcoTargetType.SmallFish, 0.95f, 1);

            var trailRoot = prefab.FindChild("spine1_phys");
            var trailBones = new Transform[] { trailRoot.FindChild("spine2_phys").transform, trailRoot.FindChild("spine3_phys").transform, trailRoot.FindChild("tail_base_phys").transform };
            var trail = CreateTrail(trailRoot, trailBones, components, 1);
            var multiplierCurve = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 1));
            trail.pitchMultiplier = multiplierCurve;
            trail.yawMultiplier = multiplierCurve;
            trail.rollMultiplier = multiplierCurve;
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 300;
        }
    }
}
