using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using Socksfor1Subs.Mono;
using Socksfor1Subs.Mono.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UWE;

namespace Socksfor1Subs.Prefabs
{
    public class TankPrefab : Craftable
    {
        private GameObject prefab;

        public TankPrefab() : base("SockTank", "S.O.C.K. Tank", "Subaquatic Operations and Combat Kit Tank. Small, heavily armored vehicle designed to conquer dangerous underwater environments. Equipped with various utilities for both offensive and defensive capabilities.")
        {
        }

        public override GameObject GetGameObject()
        {
            if (prefab != null)
            {
                return prefab;
            }

            // Load the Seamoth prefab for reference
            GameObject seamothReference = CraftData.GetPrefabForTechType(TechType.Seamoth);
            var seamothComponent = seamothReference.GetComponent<SeaMoth>();
            GameObject exosuitReference = CraftData.GetPrefabForTechType(TechType.Exosuit);
            var exosuitComponent = exosuitReference.GetComponent<Exosuit>();

            prefab = Object.Instantiate(Mod.assetBundle.LoadAsset<GameObject>("SockTank_Prefab"));
            prefab.SetActive(false);

            prefab.AddComponent<PrefabIdentifier>().ClassId = ClassID;
            prefab.AddComponent<TechTag>().type = TechType;
            prefab.AddComponent<LargeWorldEntity>().cellLevel = LargeWorldEntity.CellLevel.Global;

            var model = Helpers.FindChild(prefab, "Model");
            var barrelRoot = Helpers.FindChild(model, "BarrelRoot");
            var barrelPivot = Helpers.FindChild(barrelRoot, "BarrelPivot");
            var barrelModel = Helpers.FindChild(barrelPivot, "BarrelModel");

            Helpers.ApplySNShaders(prefab, 6f, 1f, 2f, GetGlassMaterial());
            var exteriorGlassGo = Helpers.FindChild(model, "exteriorglass");
            var exteriorGlass = exteriorGlassGo.GetComponent<Renderer>().materials[0];
            exteriorGlass.SetColor("_SpecColor", new Color(1f, 1f, 0.85f));
            exteriorGlass.SetFloat("_SpecInt", 4f);
            exteriorGlass.SetFloat("_Shininess", 7f);
            exteriorGlass.SetFloat("_Fresnel", 0.50f);
            var interiorGlass = Helpers.FindChild(model, "InteriorGlass").GetComponent<Renderer>().materials[0];
            interiorGlass.SetColor("_Color", new Color(1f, 1f, 1f, 0.1f));
            interiorGlass.SetColor("_SpecColor", new Color(1f, 1f, 1f, 1f));
            interiorGlass.SetFloat("_SpecInt", 2f);
            interiorGlass.SetFloat("_Shininess", 6f);
            interiorGlass.SetFloat("_Fresnel", 0.64f);

            var exteriorSa = model.AddComponent<SkyApplier>();
            //exteriorSa.anchorSky = Skies.Custom;
            exteriorSa.renderers = model.GetComponentsInChildren<Renderer>();
            //var exteriorSky = CopySky(rocketPlatformReference.transform.GetChild(2).gameObject).gameObject;
            //var exteriorSkyComponent = exteriorSky.GetComponent<mset.Sky>();
            //exteriorSkyComponent.MasterIntensity = 3f;
            //exteriorSa.customSkyPrefab = exteriorSky;

            // Physics

            var rb = prefab.AddComponent<Rigidbody>();
            rb.mass = 2000f;
            rb.useGravity = false;
            rb.angularDrag = 2f;
            rb.isKinematic = true;
            rb.constraints = 0;
            var wf = prefab.AddComponent<WorldForces>();
            wf.aboveWaterGravity = 9.8f;
            wf.underwaterGravity = 1f;
            wf.underwaterDrag = 0.5f;
            SetWaterDepth.SetWaterDepthOfPrefab(prefab, -3f);

            // Add VFXSurfaces for damage FX.

            foreach (Collider col in prefab.GetComponentsInChildren<Collider>())
            {
                var vfxSurface = col.gameObject.AddComponent<VFXSurface>();
                vfxSurface.surfaceType = VFXSurfaceTypes.electronic;
            }

            // I <3 BehaviourLODs

            var lod = prefab.AddComponent<BehaviourLOD>();
            lod.veryCloseThreshold = 30f;
            lod.closeThreshold = 90f;
            lod.farThreshold = 160f;

            // Get the seamoth's water clip proxy component. This is what displaces the water.
            var seamothProxy = seamothReference.GetComponentInChildren<WaterClipProxy>();
            // Find the parent of all the ship's clip proxys.
            Transform proxyParent = Helpers.FindChild(prefab, "ClipProxys").transform;
            // Iterate through them all
            foreach (Transform child in proxyParent)
            {
                var waterClip = child.gameObject.AddComponent<WaterClipProxy>();
                waterClip.shape = WaterClipProxy.Shape.Box;
                //Apply the seamoth's clip material. No idea what shader it uses or what settings it actually has, so this is an easier option. Reuse the game's assets.
                waterClip.clipMaterial = seamothProxy.clipMaterial;
                //You need to do this. By default the layer is 0. This makes it displace everything in the default rendering layer. We only want to displace water.
                waterClip.gameObject.layer = seamothProxy.gameObject.layer;
            }

            // Determines the places the little build bots point their laser beams at.

            var buildBots = prefab.AddComponent<BuildBotBeamPoints>();

            Transform beamPointsParent = Helpers.FindChild(prefab, "BuildBotPoints").transform;

            // These are arbitrarily placed. Don't overthink it. I won't go into details about what it does, it should be self explanatory.

            buildBots.beamPoints = new Transform[beamPointsParent.childCount];
            for (int i = 0; i < beamPointsParent.childCount; i++)
            {
                buildBots.beamPoints[i] = beamPointsParent.GetChild(i);
            }

            // The path the build bots take to get to the ship to construct it.
            Transform pathsParent = Helpers.FindChild(prefab, "BuildBotPaths").transform;

            // 4 paths, one for each build bot to take.
            CreateBuildBotPath(prefab, pathsParent.GetChild(0));
            CreateBuildBotPath(prefab, pathsParent.GetChild(1));
            CreateBuildBotPath(prefab, pathsParent.GetChild(2));
            CreateBuildBotPath(prefab, pathsParent.GetChild(3));

            // The effects for the constructor.
            var vfxConstructing = prefab.AddComponent<VFXConstructing>();
            var seamothVfxConstructing = seamothReference.GetComponentInChildren<VFXConstructing>();
            vfxConstructing.ghostMaterial = seamothVfxConstructing.ghostMaterial;
            vfxConstructing.surfaceSplashSound = seamothVfxConstructing.surfaceSplashSound;
            vfxConstructing.surfaceSplashFX = seamothVfxConstructing.surfaceSplashFX;
            vfxConstructing.Regenerate();

            // The vehicle should always be upright as possible

            var stabilizer = prefab.AddComponent<Stabilizer>();
            stabilizer.uprightAccelerationStiffness = 300f;

            // Some components might need this

            var liveMixin = prefab.AddComponent<LiveMixin>();
            var lmData = ScriptableObject.CreateInstance<LiveMixinData>();
            lmData.canResurrect = false;
            lmData.broadcastKillOnDeath = true;
            lmData.destroyOnDeath = false;
            lmData.explodeOnDestroy = false;
            lmData.invincibleInCreative = false;
            lmData.weldable = true;
            lmData.minDamageForSound = 20f;
            lmData.maxHealth = Balance.TankMaxHealth;
            liveMixin.data = lmData;

            // A ping so you can see it from far away

            var ping = prefab.AddComponent<PingInstance>();
            ping.pingType = Mod.tankPingType;
            ping.origin = Helpers.FindChild(prefab, "PingOrigin").transform;

            // Deal damage on impact

            var impactDamage = prefab.AddComponent<DealDamageOnImpact>();
            impactDamage.damageTerrain = true; 
            impactDamage.speedMinimumForSelfDamage = 4; 
            impactDamage.speedMinimumForDamage = 2; 
            impactDamage.affectsEcosystem = true; 
            impactDamage.minimumMassForDamage = 20; 
            impactDamage.mirroredSelfDamage = false; 
            impactDamage.mirroredSelfDamageFraction = 0.5f; 
            impactDamage.capMirrorDamage = 100; 

            // Voice

            var voice = prefab.AddComponent<TankVoice>();

            // Eco target for creature detection

            var ecoTarget = prefab.AddComponent<EcoTarget>();
            ecoTarget.type = EcoTargetType.Shark;

            // Energy

            var batteryL = AddBatterySlot("BatterySlot1", Helpers.FindChild(prefab, "PowerModelL").transform, Helpers.FindChild(prefab, "BatteryInputL"), exosuitReference);
            var batteryR = AddBatterySlot("BatterySlot2", Helpers.FindChild(prefab, "PowerModelR").transform, Helpers.FindChild(prefab, "BatteryInputR"), exosuitReference);

            var energyInterface = prefab.AddComponent<EnergyInterface>();
            energyInterface.sources = new EnergyMixin[] { batteryL, batteryR, };

            // Modules

            var modulesRoot = Helpers.FindChild(prefab, "ModulesRoot");
            var modulesChildIdentifier = modulesRoot.AddComponent<ChildObjectIdentifier>();
            modulesChildIdentifier.ClassId = "TankModulesRoot";

            // Vehicle essentials

            var subName = prefab.AddComponent<SubName>();
            subName.pingInstance = ping;
            subName.rendererInfo = new SubName.ColorData[0];

            var seamothUpgradesInput = seamothComponent.upgradesInput;
            var upgradesInput = Helpers.FindChild(prefab, "UpgradeConsole").AddComponent<VehicleUpgradeConsoleInput>();
            upgradesInput.gameObject.layer = Mod.handTargetLayer;
            upgradesInput.openSound = seamothUpgradesInput.openSound;
            upgradesInput.closeSound = seamothUpgradesInput.closeSound;
            upgradesInput.flap = Helpers.FindChild(model, "UpgradeConsoleFlap").transform;
            upgradesInput.anglesClosed = new Vector3(-90, 0, 0);
            upgradesInput.anglesOpened = new Vector3(-54, 0, 0);
            upgradesInput.collider = upgradesInput.GetComponent<Collider>();
            var vehicleUpgradeSlotModel = Helpers.FindChild(exosuitReference, "engine_console_key_03");
            upgradesInput.slots = new VehicleUpgradeConsoleInput.Slot[] {
                AddUpgradeSlotModel(Tank.slotIDArray[0], Helpers.FindChild(model, "UpgradeModel1").transform, vehicleUpgradeSlotModel),
                AddUpgradeSlotModel(Tank.slotIDArray[1], Helpers.FindChild(model, "UpgradeModel2").transform, vehicleUpgradeSlotModel),
                AddUpgradeSlotModel(Tank.slotIDArray[2], Helpers.FindChild(model, "UpgradeModel3").transform, vehicleUpgradeSlotModel),
                AddUpgradeSlotModel(Tank.slotIDArray[3], Helpers.FindChild(model, "UpgradeModel4").transform, vehicleUpgradeSlotModel),
            };

            // tank component -_-

            var tank = prefab.AddComponent<Tank>();
            tank.torpedoTypes = new TorpedoType[] { new TorpedoType() { techType = TechType.WhirlpoolTorpedo }, new TorpedoType() { techType = TechType.GasTorpedo } };
            tank.mainAnimator = prefab.GetComponentInChildren<Animator>();
            tank.destructionEffect = seamothComponent.destructionEffect;
            tank.stabilizeRoll = false;
            tank.controlSheme = Mod.tankControlScheme;
            tank.playerSits = true;
            tank.handLabel = "Pilot Tank";
            tank.collisionModel = Helpers.FindChild(prefab, "Collision");
            tank.upgradesInput = upgradesInput;
            tank.playerPosition = Helpers.FindChild(prefab, "PlayerPosition");
            tank.collisionModel = Helpers.FindChild(prefab, "Collision");
            var chargingEmitter = prefab.AddComponent<FMOD_CustomLoopingEmitter>();
            chargingEmitter.asset = chargingSound;
            chargingEmitter.followParent = true;
            tank.chargingSound = chargingEmitter;
            tank.splashSound = splashSound;
            tank.worldForces = wf;
            tank.useRigidbody = rb;
            tank.energyInterface = energyInterface;
            tank.liveMixin = liveMixin;
            tank.modulesRoot = modulesChildIdentifier;
            tank.moveOnLand = true;

            // values

            tank.forwardForce = 6f;
            tank.verticalForce = 8f;
            tank.backwardForce = 6f;

            // filling up more fields

            tank.voice = voice;

            tank.exteriorGlass = exteriorGlassGo;

            var crushDamage = prefab.AddComponent<CrushDamage>();
            crushDamage.liveMixin = liveMixin;
            crushDamage.vehicle = tank;
            crushDamage.kBaseCrushDepth = 1500f;
            tank.crushDamage = crushDamage;

            var engineRpmSfx = Helpers.FindChild(prefab, "EngineRpmSFX").AddComponent<EngineRpmSFXManager>();
            var rpmEmitter = engineRpmSfx.gameObject.AddComponent<FMOD_CustomLoopingEmitter>();
            rpmEmitter.asset = driveSound;
            rpmEmitter.followParent = true;
            engineRpmSfx.engineRpmSFX = rpmEmitter;
            engineRpmSfx.rampUpSpeed = 1f;
            engineRpmSfx.rampDownSpeed = 0.5f;
            tank.engineRpmSFX = engineRpmSfx;

            var tankPhysics = prefab.AddComponent<TankPhysics>();
            tankPhysics.tank = tank;

            var damageHandler = prefab.AddComponent<TankDamageHandler>();
            damageHandler.tank = tank;

            tank.volumetricLights = new VFXVolumetricLight[] { AddVolumetricLight(Helpers.FindChild(prefab, "FrontLight_Left"), seamothComponent), AddVolumetricLight(Helpers.FindChild(prefab, "FrontLight_Right"), seamothComponent), AddVolumetricLight(Helpers.FindChild(prefab, "BarrelLight"), seamothComponent) };

            // Movement

            var tankAim = prefab.AddComponent<TankAim>();
            tankAim.vehicleRoot = prefab.transform;
            tankAim.barrelPivotDummy = Helpers.FindChild(barrelRoot, "BarrelPivotDummy").transform;
            tankAim.barrelPivot = Helpers.FindChild(barrelRoot, "BarrelPivot").transform;
            tankAim.barrelRoot = barrelRoot.transform;
            tankAim.upperXRotLimit = 320; // -40
            tankAim.lowerXRotLimit = 10;
            tankAim.aimDegreesPerSecond = 100f; 
            tankAim.aimDegreesPerSecondWhileLocked = 20f;
            tankAim.rotateEmitter = prefab.AddComponent<FMOD_CustomLoopingEmitter>();
            tankAim.rotateEmitter.followParent = true;
            tankAim.rotateEmitter.asset = rotateSound;
            tankAim.tank = tank;
            tank.aim = tankAim;

            // HUD

            var tankHUDRoot = Helpers.FindChild(prefab, "TankHUD");
            var tankHUD = tankHUDRoot.AddComponent<TankHUD>();
            tankHUD.tank = tank;
            tankHUD.canvasRoot = Helpers.FindChild(tankHUDRoot, "Canvas");
            tankHUD.harpoonButton = HUDButton<Tank>.Create<HarpoonButton>(tank, Helpers.FindChild(tankHUDRoot, "HarpoonButton"), "Enable Harpoon", Mod.assetBundle.LoadAsset<Sprite>("Harpoon 1"), Mod.assetBundle.LoadAsset<Sprite>("Harpoon 2"), null);
            tankHUD.torpedoButton = HUDButton<Tank>.Create<TorpedoButton>(tank, Helpers.FindChild(tankHUDRoot, "TorpedoButton"), "Toggle Torpedoes", Mod.assetBundle.LoadAsset<Sprite>("Torpedo 1"), Mod.assetBundle.LoadAsset<Sprite>("Torpedo 2"), null);
            tankHUD.healthText = Helpers.FindChild(tankHUDRoot, "HealthPercentage").GetComponent<Text>();
            tankHUD.powerText = Helpers.FindChild(tankHUDRoot, "PowerPercentage").GetComponent<Text>();
            tankHUD.statusText = Helpers.FindChild(tankHUDRoot, "StatusText").GetComponent<Text>();
            tankHUD.torpedoCounter = Helpers.FindChild(tankHUDRoot, "TorpedoesLoaded").AddComponent<TorpedoCounter>();

            tank.hud = tankHUD;

            // Weapons

            var weapons = prefab.AddComponent<TankWeapons>();
            tank.weapons = weapons;
            weapons.tank = tank;
            weapons.barrelEnd = Helpers.FindChild(barrelPivot, "BarrelEnd").transform;
            var reelEmitter = prefab.AddComponent<FMOD_CustomLoopingEmitter>();
            reelEmitter.asset = reelSound;
            reelEmitter.followParent = true;
            weapons.reelEmitter = reelEmitter;

            // Viewpoints

            var mainView = Helpers.FindChild(prefab, "MainView").AddComponent<TankViewMain>();
            mainView.tank = tank;

            var bottomView = Helpers.FindChild(prefab, "BottomView").AddComponent<TankViewBottom>();
            bottomView.tank = tank;

            tank.mainView = mainView;
            tank.bottomView = bottomView;

            // Finalize

            prefab.SetActive(true);

            return prefab;
        }

        private EnergyMixin AddBatterySlot(string name, Transform modelParent, GameObject batteryInput, GameObject exosuitReference)
        {
            var batterySlot = new GameObject(name);
            batterySlot.SetActive(false);
            var identifier = batterySlot.AddComponent<ChildObjectIdentifier>();
            identifier.ClassId = name;
            batterySlot.transform.parent = prefab.transform;

            var powerCellModel = Object.Instantiate(Helpers.FindChild(exosuitReference, "engine_power_cell_L"), modelParent.transform);
            powerCellModel.transform.localPosition = Vector3.zero;
            powerCellModel.transform.localEulerAngles = Vector3.zero;
            powerCellModel.transform.localScale = Vector3.one;
            var ionPowerCellModel = Object.Instantiate(Helpers.FindChild(exosuitReference, "engine_power_cell_ion_L"), modelParent.transform);
            ionPowerCellModel.transform.localPosition = Vector3.zero;
            ionPowerCellModel.transform.localEulerAngles = Vector3.zero;
            ionPowerCellModel.transform.localScale = Vector3.one;

            var energyMixin = batterySlot.AddComponent<EnergyMixin>();
            energyMixin.storageRoot = identifier;
            energyMixin.defaultBattery = TechType.PowerCell;
            energyMixin.defaultBatteryCharge = 1f;
            energyMixin.compatibleBatteries = new List<TechType>() { TechType.PowerCell, TechType.PrecursorIonPowerCell };
            energyMixin.soundPowerUp = ModAudio.BatteryPowerUpSound;
            energyMixin.soundPowerDown = ModAudio.BatteryPowerDownSound;
            energyMixin.batteryModels = new EnergyMixin.BatteryModels[] { new EnergyMixin.BatteryModels() { model = powerCellModel.gameObject, techType = TechType.PowerCell }, new EnergyMixin.BatteryModels() { model = ionPowerCellModel.gameObject, techType = TechType.PrecursorIonPowerCell } };

            var handTarget = batteryInput.AddComponent<EnergyMixinTarget>();
            handTarget.energyMixin = energyMixin;
            handTarget.gameObject.layer = Mod.handTargetLayer;

            batterySlot.SetActive(true);

            return energyMixin;
        }

        private VFXVolumetricLight AddVolumetricLight(GameObject lightObject, SeaMoth seamothComponent)
        {
            var vfxComponent = lightObject.AddComponent<VFXVolumetricLight>();
            vfxComponent.angle = 50;
            vfxComponent.range = 100;
            vfxComponent.intensity = 0.4f;
            vfxComponent.intensity = 0.4f;
            vfxComponent.lightType = LightType.Spot;
            vfxComponent.lightIntensity = 1.7f;
            var seamothVolumetricLight = seamothComponent.volumeticLights[0];
            var mesh = Object.Instantiate(seamothVolumetricLight.volumGO, vfxComponent.transform);
            mesh.transform.localPosition = Vector3.zero;
            mesh.transform.localEulerAngles = Vector3.zero;
            mesh.transform.localScale = new Vector3(140, 140, 100);
            vfxComponent.volumGO = mesh;
            vfxComponent.coneMat = seamothVolumetricLight.coneMat;
            vfxComponent.sphereMat = seamothVolumetricLight.sphereMat;
            vfxComponent.volumMesh = seamothVolumetricLight.volumMesh;

            return vfxComponent;
        }

        private VehicleUpgradeConsoleInput.Slot AddUpgradeSlotModel(string slotId, Transform modelParent, GameObject originalModel)
        {
            var model = Object.Instantiate(originalModel, modelParent);
            model.transform.localPosition = Vector3.zero;
            model.transform.localEulerAngles = Vector3.zero;
            model.transform.localScale = Vector3.one;
            return new VehicleUpgradeConsoleInput.Slot() { id = slotId, model = model };
        }

        private static FMODAsset chargingSound = Helpers.GetFmodAsset("event:/tools/gravsphere/loop");
        private static FMODAsset splashSound = Helpers.GetFmodAsset("event:/sub/common/splash_in_and_out");
        private static FMODAsset rotateSound = Helpers.GetFmodAsset("event:/sub/rocket/call_lift_loop_2");
        private static FMODAsset driveSound = Helpers.GetFmodAsset("event:/sub/cyclops/cyclops_loop_rpm");
        private static FMODAsset reelSound = Helpers.GetFmodAsset("TankReelLoop2");

        public override TechCategory CategoryForPDA => TechCategory.Constructor;
        public override TechGroup GroupForPDA => TechGroup.Constructor;
        public override string[] StepsToFabricatorTab => new[] { "Vehicles" };
        public override CraftTree.Type FabricatorType => CraftTree.Type.Constructor;
        public override float CraftingTime => 10f;
        public override TechType RequiredForUnlock => TechType.Constructor;

        protected override Atlas.Sprite GetItemSprite()
        {
            return new Atlas.Sprite(Mod.assetBundle.LoadAsset<Sprite>("SockTank_Icon"));
        }

        private BuildBotPath CreateBuildBotPath(GameObject gameobjectWithComponent, Transform parent)
        {
            var comp = gameobjectWithComponent.AddComponent<BuildBotPath>();
            comp.points = new Transform[parent.childCount];
            for (int i = 0; i < parent.childCount; i++)
            {
                comp.points[i] = parent.GetChild(i);
            }
            return comp;
        }

        private Material GetGlassMaterial()
        {
            var reference = CraftData.GetPrefabForTechType(TechType.Aquarium);

            Renderer[] renderers = reference.GetComponentsInChildren<Renderer>(true);

            foreach (Renderer renderer in renderers)
            {
                foreach (Material material in renderer.materials)
                {
                    if (material.name.ToLower().Contains("glass"))
                    {
                        return material;
                    }
                }
            }
            return null;
        }

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData(new Ingredient(TechType.PlasteelIngot, 2), new Ingredient(TechType.Aerogel, 1), new Ingredient(TechType.AdvancedWiringKit, 1), new Ingredient(TechType.SeamothTorpedoModule, 1), new Ingredient(TechType.ReactorRod, 1));
        }
    }
}
