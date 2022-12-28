using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECCLibrary;
using Socksfor1Monsters.Mono;
using UnityEngine;

namespace Socksfor1Monsters.Prefabs
{
    public class Bloop : CreatureAsset
    {
        public static GameObject vortexVfx;

        public Bloop(string classId, string friendlyName, string description, GameObject model, Texture2D spriteTexture) : base(classId, friendlyName, description, model, spriteTexture)
        {
        }

        public override TechType CreatureTraitsReference => TechType.SeaDragon;

        public override BehaviourType BehaviourType => BehaviourType.Leviathan;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.VeryFar;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(40f, 10f, 40f), 10f, 3f, 0.1f);

        public override float MaxVelocityForSpeedParameter => 3f;

        public override EcoTargetType EcoTargetType => EcoTargetType.Leviathan;

        public override bool EnableAggression => true;

        public override SmallVehicleAggressivenessSettings AggressivenessToSmallVehicles => new SmallVehicleAggressivenessSettings(0.4f, 17f);

        public override AttackLastTargetSettings AttackSettings => new AttackLastTargetSettings(0.3f, 13f, 13f, 18f, 40f, 20f);

        public override float Mass => 1500f;

        public override ScannableItemData ScannableSettings => new ScannableItemData(true, 6f, "Lifeforms/Fauna/Leviathans", Mod.assetBundle.LoadAsset<Sprite>("Fatfish_Popup"), Mod.assetBundle.LoadAsset<Texture2D>("Fatfish_Ency"));

        public override string GetEncyDesc => "A massive fish often found in shallow waters.\n\n1. Body:\nThe Bloop has a very extensive body plan, representing an elongated sphere. Two large ventral fins on either side of the body act to apply large amounts of force and maintain balance.\nTwo pairs of eyes are present on the face, although they appear underdeveloped, suggesting a unique form of hunting.\n\n2. Mouth:\nThe mouth of the bloop is larger than that of any creature discovered on Planet 4546B. It is observed to be wide open most of the time, with unfortunate fish often being consumed. A second jaw, located approx. 7 meters deep in the face, may help in consumption of larger than usual prey.\n\n3. Vortex attack:\nBeyond filter feeding, this leviathan portrays a very interesting hunting technique. It has the ability to pump large masses of water from its throat into a dedicated vacuum-sealed chamber. This massive displacement of water creates a pressure difference, pulling any nearby objects into its mouth.\n\nAssesment: Avoid being in the path of the mouth. Be wary of the Vortex attack.";

        public override StayAtLeashData StayAtLeashSettings => new StayAtLeashData(0.2f, 60f);

        public override BehaviourLODLevelsStruct BehaviourLODSettings => new BehaviourLODLevelsStruct(50f, 300f, 1000f);

        public override float TurnSpeed => 0.05f;

        public override RoarAbilityData RoarAbilitySettings => new RoarAbilityData(true, 20f, 100f, "BloopRoar", "roar", 20f, 40f);

        public override bool CanBeInfected => false;

        public override UBERMaterialProperties MaterialSettings => new UBERMaterialProperties(12f, 5f, 2f);

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            ValidateVortexVFX();

            MakeAggressiveTo(70f, 2, EcoTargetType.Shark, 0.2f, 1.5f);
            components.creature.Hunger = new CreatureTrait(0f, -0.05f);
            components.locomotion.driftFactor = 0.9f;
            prefab.AddComponent<Mono.SwimAmbience>();

            CreateTrail(prefab.SearchChild("Spine2"), new Transform[] { prefab.SearchChild("Spine3").transform, prefab.SearchChild("Spine4").transform, prefab.SearchChild("Spine5").transform, prefab.SearchChild("Spine6").transform, prefab.SearchChild("Tail1").transform }, components, 4f);

            BloopBehavior behavior = prefab.AddComponent<BloopBehavior>();
            prefab.AddComponent<BloopVortexAttack>();

            GameObject mouth = prefab.SearchChild("Mouth");
            BloopMeleeAttack meleeAttack = prefab.AddComponent<BloopMeleeAttack>();
            meleeAttack.mouth = mouth;
            meleeAttack.canBeFed = false;
            meleeAttack.biteInterval = 3f;
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

            AttackCyclops actionAtkCyclops = prefab.AddComponent<AttackCyclops>();
            actionAtkCyclops.swimVelocity = 15f;
            actionAtkCyclops.aggressiveToNoise = new CreatureTrait(0f, 0.01f);
            actionAtkCyclops.evaluatePriority = 0.6f;
            actionAtkCyclops.priorityMultiplier = ECCHelpers.Curve_Flat();
            actionAtkCyclops.maxDistToLeash = 70f;
            actionAtkCyclops.attackAggressionThreshold = 0.4f;

        }

        private void ValidateVortexVFX()
        {
            if(vortexVfx == null)
            {
                SeaMoth seamoth = CraftData.GetPrefabForTechType(TechType.Seamoth).GetComponent<SeaMoth>();
                vortexVfx = seamoth.torpedoTypes[0].prefab.GetComponent<SeamothTorpedo>().explosionPrefab.GetComponent<PrefabSpawn>().prefab;
                GameObject.Destroy(vortexVfx.GetComponent<VFXDestroyAfterSeconds>());
            }
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 5000f;
        }
    }
}
