using UnityEngine;
using ECCLibrary;

namespace ArcticMigration.Creatures
{
    internal class ReaperPort : CreaturePortBase
    {
        public ReaperPort(string classId, GameObject model) : base(classId, "Reaper Leviathan", "Aggressive leviathan class predator.", model, null)
        {
        }

        public override BehaviourType BehaviourType => BehaviourType.Leviathan;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.VeryFar;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(22, 4, 22), 15, 2, 0.2f);

        public override EcoTargetType EcoTargetType => EcoTargetType.Leviathan;

        public override StayAtLeashData StayAtLeashSettings => new StayAtLeashData(0.8f, 60);

        public override float Mass => 85;

        public override float MaxVelocityForSpeedParameter => 4;

        public override AttackLastTargetSettings AttackSettings => new AttackLastTargetSettings(0.9f, 25f, 3, 10, 20, 5);

        public override BehaviourLODLevelsStruct BehaviourLODSettings => new BehaviourLODLevelsStruct(20, 100, 500);

        public override AvoidObstaclesData AvoidObstaclesSettings => new AvoidObstaclesData(0.9f, true, 30f);

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            var leash = prefab.GetComponent<StayAtLeashPosition>();
            leash.swimVelocity = 25;

            components.locomotion.maxVelocity = 15;
            components.locomotion.maxAcceleration = 12;
            components.locomotion.driftFactor = 0.8f;

            var attackLastTarget = prefab.GetComponent<AttackLastTarget>();
            attackLastTarget.aggressionThreshold = 0.5f;

            MakeAggressiveTo(75, 3, EcoTargetType.Shark, 0.1f, 2);
            MakeAggressiveTo(120, 3, EcoTargetType.Leviathan, 0f, 2);

            var trailRoot = prefab.SearchChild("spine1_phys");
            var trailBones = new Transform[] {
                trailRoot.SearchChild("spine1p5_phys").transform,
                trailRoot.SearchChild("spline2_phys").transform,
                trailRoot.SearchChild("spline3_phys").transform,
                trailRoot.SearchChild("tail_midBase_phys").transform,
                trailRoot.SearchChild("tail_midMid_phys").transform,
                trailRoot.SearchChild("tail_midEnd_phys").transform
            };
            var trail = CreateTrail(trailRoot, trailBones, components, 1);
            var multiplierCurve = new AnimationCurve(new Keyframe(0, 1), new Keyframe(1, 1));
            trail.pitchMultiplier = multiplierCurve;
            trail.yawMultiplier = multiplierCurve;
            trail.rollMultiplier = multiplierCurve;
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 5000;
        }
    }
}
