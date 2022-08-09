using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using UnityEngine;

namespace RisingLava.Prefabs.Tools
{
    public class LavaMonitor : Equipable
    {
        public LavaMonitor() : base("LavaMonitor", "Lava Monitor", "A handheld device that shows information related to rising lava levels. Contains a sensor that detects abnormal temperature fluctuations with extreme precision.")
        {
        }

        public override EquipmentType EquipmentType => EquipmentType.Hand;

        public override float CraftingTime => 4f;

        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;

        public override bool UnlockedAtStart => true;

        public override TechCategory CategoryForPDA => TechCategory.Equipment;

        public override TechGroup GroupForPDA => TechGroup.Personal;

        public override string[] StepsToFabricatorTab => new string[] { "Personal", "Equipment" };

        protected override Atlas.Sprite GetItemSprite()
        {
            return new Atlas.Sprite(Main.assetBundle.LoadAsset<Sprite>("LavaTablet_Icon"));
        }

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData(new Ingredient(TechType.WiringKit, 1), new Ingredient(TechType.CopperWire, 1)) { craftAmount = 1};
        }

        public override GameObject GetGameObject()
        {
            var prefab = Object.Instantiate(Main.assetBundle.LoadAsset<GameObject>("LavaTablet_Prefab"));
            prefab.SetActive(false);
            prefab.EnsureComponent<PrefabIdentifier>().ClassId = ClassID;
            prefab.EnsureComponent<TechTag>().type = TechType;
            prefab.EnsureComponent<LargeWorldEntity>().cellLevel = LargeWorldEntity.CellLevel.Near;
            prefab.EnsureComponent<Pickupable>();
            prefab.EnsureComponent<SkyApplier>().renderers = prefab.GetAllComponentsInChildren<Renderer>();
            var rb = prefab.EnsureComponent<Rigidbody>();
            rb.useGravity = false;
            rb.mass = 10f;
            prefab.EnsureComponent<WorldForces>();
            var fpModel = prefab.EnsureComponent<FPModel>();
            fpModel.propModel = prefab.transform.Find("WorldModel").gameObject;
            fpModel.viewModel = prefab.transform.Find("ViewModel").gameObject;

            Helpers.ApplySNShaders(prefab);

            var vfxFabricating = prefab.transform.Find("CraftModel").gameObject.AddComponent<VFXFabricating>();
            vfxFabricating.scaleFactor = 0.1f;
            vfxFabricating.localMinY = -0.03f;
            vfxFabricating.localMaxY = 0.03f;

            var monitor = prefab.AddComponent<Mono.Equipment.LavaMonitor>();
            monitor.mainCollider = prefab.GetComponent<Collider>();
            monitor.drawSound = Helpers.GetFMODAsset("event:/player/key terminal_close");

            prefab.transform.Find("ViewModel").Find("UI").gameObject.AddComponent<Mono.Equipment.LavaMonitorUI>();

            return prefab;
        }
    }
}
