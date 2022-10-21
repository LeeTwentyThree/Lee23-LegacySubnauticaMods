using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;
using Socksfor1Subs.Mono;
using Socksfor1Subs.Mono.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UWE;

namespace Socksfor1Subs.Prefabs
{
    public class DadSub : Craftable
    {
        private GameObject prefab;

        public DadSub() : base("DadSub", "D.A.D. Submersible", "The Deepsea Aquatic Defense Submersible is a large vehicle designed for hosting stealth-based attacks in dangerous environments. Powered by the solar energy, but thermal plants can be built on top.")
        {
        }

        public override GameObject GetGameObject()
        {
            if (prefab != null)
            {
                return prefab;
            }

            // Load reference prefabs to grab fields
            GameObject rocketPlatformReference = CraftData.GetPrefabForTechType(TechType.RocketBase);
            GameObject exosuitReference = CraftData.GetPrefabForTechType(TechType.Exosuit);

            prefab = Object.Instantiate(Mod.assetBundle.LoadAsset<GameObject>("DadSub_Prefab"));
            prefab.SetActive(false);
            prefab.tag = "Submarine";

            prefab.AddComponent<PrefabIdentifier>().ClassId = ClassID;
            prefab.AddComponent<TechTag>().type = TechType;
            prefab.AddComponent<LargeWorldEntity>().cellLevel = LargeWorldEntity.CellLevel.Global;

            var modelRoot = Helpers.FindChild(prefab, "Model");
            var interiorModel = Helpers.FindChild(prefab, "InteriorModel");
            var exteriorModel = Helpers.FindChild(prefab, "ExteriorModel");
            var glassModel = Helpers.FindChild(prefab, "GlassModel");

            // Materials

            Helpers.ApplySNShaders(prefab, 6f, 1f, 2f, GetGlassMaterial());
            var exteriorGlass = Helpers.FindChild(exteriorModel, "Cube.003").GetComponent<Renderer>().materials[0];
            exteriorGlass.SetColor("_SpecColor", new Color(1f, 1f, 0.85f));
            exteriorGlass.SetFloat("_SpecInt", 4f);
            exteriorGlass.SetFloat("_Shininess", 7f);
            exteriorGlass.SetFloat("_Fresnel", 0.50f);
            var interiorGlass = glassModel.GetComponentInChildren<Renderer>().materials[0];
            interiorGlass.SetColor("_Color", new Color(1f, 1f, 1f, 0.25f));
            interiorGlass.SetColor("_SpecColor", new Color(2f, 1f, 0f, 1f));
            interiorGlass.SetFloat("_SpecInt", 2f);
            interiorGlass.SetFloat("_Shininess", 6f);
            interiorGlass.SetFloat("_Fresnel", 0.64f);

            var exteriorSa = exteriorModel.AddComponent<SkyApplier>();
            exteriorSa.anchorSky = Skies.Custom;
            exteriorSa.renderers = exteriorModel.GetComponentsInChildren<Renderer>();
            var exteriorSky = CopySky(rocketPlatformReference.transform.GetChild(2).gameObject).gameObject;
            var exteriorSkyComponent = exteriorSky.GetComponent<mset.Sky>();
            exteriorSkyComponent.MasterIntensity = 3f;
            exteriorSa.customSkyPrefab = exteriorSky;
            exteriorSa.emissiveFromPower = false;

            var interiorSa = interiorModel.AddComponent<SkyApplier>();
            var interiorRenderersList = new List<Renderer>(interiorModel.GetComponentsInChildren<Renderer>());
            interiorRenderersList.Add(Helpers.FindChild(prefab, "SteeringWheel").GetComponent<Renderer>());
            interiorSa.renderers = interiorRenderersList.ToArray();
            interiorSa.anchorSky = Skies.BaseInterior;
            interiorSa.SetSky(Skies.BaseInterior);
            var interiorSky = CopySky(rocketPlatformReference.transform.GetChild(1).gameObject).gameObject;
            var interiorSkyComponent = interiorSky.GetComponent<mset.Sky>();
            interiorSkyComponent.MasterIntensity = 5f;
            interiorSkyComponent.camExposure = 1f;
            interiorSa.customSkyPrefab = interiorSky;
            interiorSa.emissiveFromPower = true;

            var glassSa = glassModel.AddComponent<SkyApplier>();
            glassSa.renderers = glassModel.GetComponentsInChildren<Renderer>();
            glassSa.anchorSky = Skies.BaseGlass;
            glassSa.SetSky(Skies.BaseGlass);
            var glassSky = CopySky(rocketPlatformReference.transform.GetChild(0).gameObject).gameObject;
            var glassSkyComponent = glassSky.GetComponent<mset.Sky>();
            glassSa.customSkyPrefab = glassSky;
            glassSa.emissiveFromPower = false;

            // Physics

            var rb = prefab.AddComponent<Rigidbody>();
            rb.mass = 12000f;
            rb.useGravity = false;
            rb.angularDrag = 2f;
            rb.isKinematic = true;
            var wf = prefab.AddComponent<WorldForces>();
            wf.aboveWaterGravity = 9.8f;
            wf.underwaterGravity = 0f;
            wf.underwaterDrag = 0.5f;
            SetWaterDepth.SetWaterDepthOfPrefab(prefab, -12f);

            // Damage on impact

            var damageOnImpact = prefab.AddComponent<DealDamageOnImpact>();
            damageOnImpact.damageTerrain = true;
            damageOnImpact.speedMinimumForSelfDamage = 1.6f;
            damageOnImpact.speedMinimumForDamage = 6f;
            damageOnImpact.minimumMassForDamage = 200f;
            damageOnImpact.mirroredSelfDamage = true;
            damageOnImpact.mirroredSelfDamageFraction = 0.2f;
            damageOnImpact.capMirrorDamage = 20f;

            // Determines the places the little build bots point their laser beams at.

            var buildBots = prefab.AddComponent<BuildBotBeamPoints>();

            Transform beamPointsParent = Helpers.FindChild(prefab, "BuildBotPoints").transform;

            // These are arbitrarily placed.
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
            var rocketPlatformVfx = rocketPlatformReference.GetComponentInChildren<VFXConstructing>();
            vfxConstructing.ghostMaterial = rocketPlatformVfx.ghostMaterial;
            vfxConstructing.surfaceSplashSound = rocketPlatformVfx.surfaceSplashSound;
            vfxConstructing.surfaceSplashFX = rocketPlatformVfx.surfaceSplashFX;
            vfxConstructing.Regenerate();

            // Don't want it tipping over...
            var stabilizier = prefab.AddComponent<Stabilizer>();
            stabilizier.uprightAccelerationStiffness = 100f;

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
            lmData.maxHealth = Balance.DadMaxHealth;
            liveMixin.data = lmData;

            // Fix collision issues
            //prefab.AddComponent<FreezeRigidbodyWhenFar>();

            // I don't know if this does anything at all as ships float above the surface, but I'm keeping it.
            var oxygenManager = prefab.AddComponent<OxygenManager>();

            // I don't understand why I'm doing this, but I will anyway. The power cell is nowhere to be seen.
            var energyMixin = prefab.AddComponent<EnergyMixin>();
            energyMixin.compatibleBatteries = new List<TechType>() { TechType.PowerCell, TechType.PrecursorIonPowerCell };
            energyMixin.defaultBattery = TechType.PowerCell;
            energyMixin.storageRoot = Helpers.FindChild(prefab, "PowerStorageRoot").AddComponent<ChildObjectIdentifier>();
            energyMixin.maxEnergy = 1200f;

            // Allows power to connect to here.
            var powerRelay = prefab.AddComponent<PowerRelay>();

            // Solar panel or something

            var solarChargerRoot = Helpers.FindChild(prefab, "SolarCharger");
            var solarCharger = solarChargerRoot.AddComponent<SolarCharger>();
            solarCharger.relay = powerRelay;

            // Power cells

            var powerCellRoot = Helpers.FindChild(prefab, "PowerCells").transform;
            int powerCellNum = 1;
            foreach (Transform powerCell in powerCellRoot)
            {
                AddBatterySlot(string.Format("DadPowerCell{0}", powerCellNum), powerCell.gameObject, exosuitReference);
                powerCellNum++;
            }

            // Necessary for SubRoot class Update behaviour so it doesn't return an error every frame.

            var lod = prefab.AddComponent<BehaviourLOD>();
            lod.veryCloseThreshold = 70f;
            lod.closeThreshold = 140f;
            lod.farThreshold = 220f;

            // Add VFXSurfaces to adjust footstep sounds. This is technically not necessary for the interior colliders, however.
            foreach (Collider col in prefab.GetComponentsInChildren<Collider>())
            {
                var vfxSurface = col.gameObject.AddComponent<VFXSurface>();
                vfxSurface.surfaceType = VFXSurfaceTypes.metal;
            }

            // The SubRoot component needs a lighting controller. Works nice too.

            var lights = prefab.AddComponent<LightingController>();
            lights.lights = new MultiStatesLight[0];
            var lightsParent = Helpers.FindChild(prefab, "Lighting");
            foreach (Transform child in lightsParent.transform)
            {
                var newLight = new MultiStatesLight();
                newLight.light = child.GetComponent<Light>();
                newLight.intensities = new[] { 1.5f, 0.5f, 0f }; // Full power: intensity 1.5. Emergency : intensity 0.5. No power: intensity 0.
                lights.RegisterLight(newLight);
            }
            lights.skies = new LightingController.MultiStatesSky[] { new LightingController.MultiStatesSky()
                {
                    sky = interiorSa.customSkyPrefab.GetComponent<mset.Sky>(),
                } 
            };
            lights.emissiveController.intensities = new float[] { 1f, 0.7f, 0f };

            // Spawn a seamoth for reference.
            var seamothRef = CraftData.GetPrefabForTechType(TechType.Seamoth);
            // Get the seamoth's water clip proxy component. This is what displaces the water.
            var seamothProxy = seamothRef.GetComponentInChildren<WaterClipProxy>();
            // Find the parent of all the ship's clip proxys.
            Transform proxyParent = Helpers.FindChild(prefab, "ClipProxys").transform;
            // Loop through them all
            foreach (Transform child in proxyParent)
            {
                var waterClip = child.gameObject.AddComponent<WaterClipProxy>();
                waterClip.shape = WaterClipProxy.Shape.Box;
                //Apply the seamoth's clip material. No idea what shader it uses or what settings it actually has, so this is an easier option. Reuse the game's assets.
                waterClip.clipMaterial = seamothProxy.clipMaterial;
                //You need to do this. By default the layer is 0. This makes it displace everything in the default rendering layer. We only want to displace water.
                waterClip.gameObject.layer = seamothProxy.gameObject.layer;
            }

            var subBehaviour = prefab.AddComponent<DadSubBehaviour>();
            subBehaviour.interiorSky = interiorSky.GetComponent<mset.Sky>();
            subBehaviour.constructing = vfxConstructing;
            subBehaviour.subAxis = Helpers.FindChild(prefab, "SubAxis").transform;
            subBehaviour.solarCharger = solarCharger;

            var ecoTarget = prefab.AddComponent<EcoTarget>();
            ecoTarget.type = EcoTargetType.Shark;
            subBehaviour.ecoTarget = ecoTarget;

            // Exterior lights

            var exteriorLightsController = prefab.AddComponent<ExteriorLightsController>();
            exteriorLightsController.sub = subBehaviour;
            exteriorLightsController.lights = Helpers.FindChild(prefab, "FrontLights").GetComponentsInChildren<Light>();

            // Sub sounds

            subBehaviour.hitSoundHard = hitSoundHard;
            subBehaviour.hitSoundMedium = hitSoundMedium;
            subBehaviour.hitSoundSoft = hitSoundSoft;
            subBehaviour.insideSoundsRoot = Helpers.FindChild(prefab, "InsideSounds");
            var subAmbience = Helpers.FindChild(subBehaviour.insideSoundsRoot, "SubAmbience").AddComponent<FMOD_CustomLoopingEmitter>();
            subAmbience.asset = subAmbienceLoop;
            subAmbience.playOnAwake = false;
            subAmbience.followParent = true;
            var dockAmbience = Helpers.FindChild(subBehaviour.insideSoundsRoot, "DockAmbience").AddComponent<SubAmbientSound>();
            dockAmbience.sub = subBehaviour;
            dockAmbience.soundAsset = dockAmbienceLoop;
            dockAmbience.radius = 17.5f;

            // A ping so you can see it from far away

            var ping = prefab.AddComponent<PingInstance>();
            ping.pingType = Mod.dadSubPingType;
            ping.origin = Helpers.FindChild(prefab, "PingOrigin").transform;

            // Add a respawn point

            var respawnPoint = Helpers.FindChild(prefab, "RespawnPoint").AddComponent<RespawnPoint>();

            // Add a bed

            var bedPrefab = CraftData.GetPrefabForTechType(TechType.Bed1);
            var bed = GameObject.Instantiate(bedPrefab);
            bed.transform.parent = prefab.transform;
            bed.transform.localPosition = new Vector3(7, 7, 2.33f);
            foreach (var renderer in bed.GetComponentsInChildren<Renderer>())
            {
                renderer.enabled = false;
            }
            Helpers.CleanupPrefabComponents(bed);
            bed.EnsureComponent<TechTag>().type = Mod.dadSubBedTechType;

            // Interior doors

            AddInteriorDoor(Helpers.FindChild(interiorModel, "Hatch1"), new Vector3(-90, 0, -150), new Vector3(-90, 0, 0));
            AddInteriorDoor(Helpers.FindChild(interiorModel, "Hatch2"), new Vector3(-90, 0, -125), new Vector3(-90, 0, 0));
            AddInteriorDoor(Helpers.FindChild(interiorModel, "Cylinder.021"), new Vector3(-90, 0, -80), new Vector3(-90, 0, 90));

            // Exterior doors

            subBehaviour.exteriorDoors = new AnimatedDoor[2];
            subBehaviour.exteriorDoors[0] = AddExteriorDoor(Helpers.FindChild(exteriorModel, "DoorL"), new Vector3(-215, 0, 0), new Vector3(-90, 0, 0));
            subBehaviour.exteriorDoors[1] = AddExteriorDoor(Helpers.FindChild(exteriorModel, "DoorR"), new Vector3(35, 0, 2.5f), new Vector3(-90, 0, 0));

            var exteriorDoorController = prefab.AddComponent<ExteriorDoorsController>();
            exteriorDoorController.sub = subBehaviour;
            exteriorDoorController.doorTriggerCenter = Helpers.FindChild(prefab, "DoorTriggerCenter").transform;

            // Dock water

            var waterPlane = AddMoonPoolWaterPlane();
            waterPlane.transform.localPosition = new Vector3(0f, -3.2f, 9.5f);
            waterPlane.transform.localEulerAngles = Vector3.zero;
            waterPlane.transform.localScale = new Vector3(0.8f, 1f, 1.9f);
            var waterPlaneMaterial = waterPlane.GetComponent<Renderer>().material;
            waterPlaneMaterial.SetColor("_Color", new Color(0.43f, 0.75f, 0.72f, 0.62f));
            waterPlaneMaterial.SetFloat("_SelfIllumination", 0.1f);

            // Dock

            var dockRoot = Helpers.FindChild(prefab, "DockSystem");
            var dock = dockRoot.AddComponent<DadSubDock>();
            dock.sub = subBehaviour;
            dock.dockTransformSmallVehicles = Helpers.FindChild(dockRoot, "DockTransform-SmallVehicle").transform;
            dock.dockTransformTank = Helpers.FindChild(dockRoot, "DockTransform-Tank").transform;
            subBehaviour.dock = dock;

            var dockTrigger = Helpers.FindChild(dockRoot, "DockTrigger").AddComponent<DockTrigger>();
            dockTrigger.dock = dock;

            var dockTriggerTank = Helpers.FindChild(dockRoot, "DockTriggerTank").AddComponent<DockTrigger>();
            dockTriggerTank.dock = dock;
            dockTriggerTank.tankOnly = true;

            // Entrance

            var waterTransitionParent = Helpers.FindChild(prefab, "WaterTransition");
            var waterTransition = waterTransitionParent.AddComponent<WaterTransition>();
            waterTransition.airTriggers = new[] { Helpers.FindChild(waterTransitionParent, "AirTrigger").GetComponent<BoxCollider>(), Helpers.FindChild(waterTransitionParent, "AirTrigger2").GetComponent<BoxCollider>() };
            waterTransition.waterTriggers = new[] { Helpers.FindChild(waterTransitionParent, "WaterTrigger").GetComponent<BoxCollider>(), Helpers.FindChild(waterTransitionParent, "WaterTrigger2").GetComponent<BoxCollider>() };
            waterTransition.sub = subBehaviour;
            waterTransition.waterPlane = waterPlane.GetComponent<Renderer>();

            // Ladder

            var mainLadderRoot = Helpers.FindChild(prefab, "MainLadder");

            var mainLadderUp = Helpers.FindChild(mainLadderRoot, "UpTrigger").AddComponent<Ladder>();
            mainLadderUp.interactText = "Ascend";

            var mainLadderUpCinematic = Helpers.FindChild(mainLadderRoot, "ClimbUp").AddComponent<SubCinematic>();
            mainLadderUpCinematic.Initialize("cyclops_ladder_long_up", "cinematic", 1.9f, climbUpLongSound, mainLadderUpCinematic.transform.GetChild(0));

            mainLadderUp.cinematic = mainLadderUpCinematic;

            var mainLadderDown = Helpers.FindChild(mainLadderRoot, "DownTrigger").AddComponent<Ladder>();
            mainLadderDown.interactText = "Descend";

            var mainLadderDownCinematic = Helpers.FindChild(mainLadderRoot, "ClimbDown").AddComponent<SubCinematic>();
            mainLadderDownCinematic.Initialize("rockethsip_cockpitLadderDown", "cinematic", 5f, slideDownSound, mainLadderDownCinematic.transform.GetChild(0));

            mainLadderDown.cinematic = mainLadderDownCinematic;

            // Keep the player in

            prefab.AddComponent<ShipWalkableAreaBounds>().ship = subBehaviour;

            // Piloting

            var engineRoot = Helpers.FindChild(prefab, "EngineRoot");
            var engine = engineRoot.AddComponent<DadSubEngine>();
            engine.glassRimTransform = Helpers.FindChild(interiorModel, "Cube.021").transform;

            var enginePassiveEmitter = Helpers.FindChild(engine.gameObject, "EngineIdleSound").AddComponent<FMOD_CustomLoopingEmitter>();
            enginePassiveEmitter.followParent = true;
            enginePassiveEmitter.asset = enginePassiveLoop;
            engine.enginePassiveEmitter = enginePassiveEmitter;

            var engineStartupEmitter = Helpers.FindChild(engine.gameObject, "EngineStartupSound").AddComponent<FMOD_CustomEmitter>();
            engineStartupEmitter.followParent = true;
            engineStartupEmitter.asset = engineStartSound;
            engineStartupEmitter.restartOnPlay = true;
            engine.engineStartupEmitter = engineStartupEmitter;

            var physics = prefab.AddComponent<DadSubPhysics>();
            physics.sub = subBehaviour;
            var pilotingRoot = Helpers.FindChild(prefab, "Piloting");
            var pilotingChair = Helpers.FindChild(pilotingRoot, "PilotingTrigger").AddComponent<PilotingChair>();
            var pilotCinematicRoot = Helpers.FindChild(pilotingRoot, "PilotingCinematic");

            var pilotStartCin = pilotingRoot.AddComponent<PlayerCinematicController>();
            pilotStartCin.animator = pilotCinematicRoot.GetComponent<Animator>();
            pilotStartCin.animatedTransform = Helpers.FindChild(pilotCinematicRoot, "AttachBone").transform;
            pilotStartCin.animParamReceivers = new GameObject[0];
            pilotStartCin.animParam = "pilot";
            pilotStartCin.informGameObject = pilotingChair.gameObject;
            pilotStartCin.interpolationTime = 0f;
            var pilotStartEnder = SetCinematicDuration(pilotStartCin, 1f);

            var pilotReleaseCin = pilotingRoot.AddComponent<PlayerCinematicController>();
            pilotReleaseCin.animator = pilotCinematicRoot.GetComponent<Animator>();
            pilotReleaseCin.animatedTransform = Helpers.FindChild(pilotCinematicRoot, "AttachBone").transform;
            pilotReleaseCin.animParamReceivers = new GameObject[0];
            pilotReleaseCin.animParam = "release";
            pilotReleaseCin.informGameObject = pilotingChair.gameObject;
            var pilotReleaseEnder = SetCinematicDuration(pilotReleaseCin, 1f);

            pilotingChair.cinematicController = pilotStartCin;
            pilotingChair.animator = pilotCinematicRoot.GetComponent<Animator>();
            pilotingChair.subRoot = subBehaviour;
            pilotingChair.sittingPosition = Helpers.FindChild(pilotCinematicRoot, "SittingPosition").transform;
            pilotingChair.releaseCinematicController = pilotReleaseCin;
            pilotingChair.leftHandPlug = Helpers.FindChild(pilotCinematicRoot, "LeftHandPlug").transform;
            pilotingChair.rightHandPlug = Helpers.FindChild(pilotCinematicRoot, "RightHandPlug").transform;
            pilotingChair.onCinematicEnd = new CinematicModeEvent();

            var engineSFXRoot = Helpers.FindChild(prefab, "EngineActiveSound");

            var engineRPMManager = prefab.AddComponent<EngineRpmSFXManager>();
            engineRPMManager.engineRpmSFX = engineSFXRoot.AddComponent<FMOD_CustomLoopingEmitter>();
            engineRPMManager.engineRpmSFX.asset = Helpers.GetFmodAsset("event:/sub/cyclops/cyclops_loop_rpm");
            engineRPMManager.engineRpmSFX.followParent = true;
            engineRPMManager.engineRevUp = prefab.AddComponent<FMOD_CustomEmitter>();

            var motorMode = prefab.AddComponent<CyclopsMotorMode>();
            motorMode.subRoot = subBehaviour;
            motorMode.motorModeNoiseValues = new float[] { 0.1f, 0.5f, 1f };
            motorMode.motorModeSpeeds = new float[] { 0.2f, 0.4f, 1f };
            motorMode.motorModePowerConsumption = new float[] { 0.2f, 0.5f, 1f };

            var subControl = prefab.AddComponent<SubControl>();
            motorMode.subController = subControl;
            subControl.modeChangedEvent = new Event<SubControl.Mode>();
            subControl.cyclopsMotorMode = motorMode;
            subControl.engineStartSound = Helpers.GetFmodAsset("event:/sub/cyclops/start");
            subControl.engineRPMManager = engineRPMManager;
            subControl.LOD = lod;
            subControl.turnScale = 0.1f;
            subControl.accelScale = 0.1f;
            subBehaviour.subControl = subControl;

            var steeringWheelAnimate = pilotingRoot.AddComponent<SteeringWheelAnimate>();
            steeringWheelAnimate.animatedTransform = Helpers.FindChild(pilotingRoot, "HandRoot").transform;
            steeringWheelAnimate.subControl = subControl;

            // Voice lines

            var voice = prefab.AddComponent<DadSubVoice>();
            subBehaviour.voice = voice;

            var energyWarning = prefab.AddComponent<DadNoPowerNotification>();

            // Stealth

            var stealth = prefab.AddComponent<SubStealthManager>();
            stealth.cloakMaterial = new Material(GetStasisFieldMaterial());
            stealth.cloakMaterial.SetColor(ShaderPropertyID._Color, new Color(0.52f, 0.62f, 0.76f, 1.00f));
            stealth.stealthRenderers = new List<Renderer>(modelRoot.GetComponentsInChildren<Renderer>());
            stealth.waterPlane = waterPlane;
            stealth.sub = subBehaviour;
            subBehaviour.stealthManager = stealth;

            // HUD

            var pilotHUD = AddPilotHUD(Helpers.FindChild(prefab, "PilotHUD"), subBehaviour);
            subBehaviour.pilotHUD = pilotHUD;

            var miniHud = Helpers.FindChild(prefab, "MiniHUD").AddComponent<MiniHUDController>();
            miniHud.sub = subBehaviour;
            miniHud.canvasTransform = Helpers.FindChild(miniHud.gameObject, "MiniHUDCanvas").GetComponent<RectTransform>();
            miniHud.anchorRootTransform = Helpers.FindChild(miniHud.gameObject, "MiniHUDAnchors").transform;
            miniHud.statusText = Helpers.FindChild(miniHud.gameObject, "Status").GetComponent<Text>();
            miniHud.healthText = Helpers.FindChild(miniHud.gameObject, "Health").GetComponent<Text>();
            miniHud.powerText = Helpers.FindChild(miniHud.gameObject, "Power").GetComponent<Text>();
            miniHud.solarPanelText = Helpers.FindChild(miniHud.gameObject, "SolarPanelEfficiency").GetComponent<Text>();
            miniHud.stealthText = Helpers.FindChild(miniHud.gameObject, "StealthPercent").GetComponent<Text>();
            var miniStealthModeButton = HUDButton<DadSubBehaviour>.Create<StealthModeButton>(subBehaviour, Helpers.FindChild(miniHud.gameObject, "StealthButtonMini"), "Enable Stealth Mode", Mod.assetBundle.LoadAsset<Sprite>("Stealth 1"), Mod.assetBundle.LoadAsset<Sprite>("Stealth 2"), Mod.assetBundle.LoadAsset<Sprite>("Stealth 3"));

            // Abilities

            var scanForLeviathans = Helpers.FindChild(prefab, "LeviathansScanner").AddComponent<ScanForLeviathans>();
            scanForLeviathans.sub = subBehaviour;
            subBehaviour.scanForLeviathans = scanForLeviathans;
            
            var deterCreatures = Helpers.FindChild(prefab, "DeterCreatures").AddComponent<DeterCreatures>();
            subBehaviour.deterCreatures = deterCreatures;
            deterCreatures.sub = subBehaviour;

            var holographicDecoyManager = Helpers.FindChild(prefab, "HolographicDecoyManager").AddComponent<HolographicDecoyManager>();
            subBehaviour.holographicDecoyManager = holographicDecoyManager;
            holographicDecoyManager.sub = subBehaviour;

            // Damage handler

            var damageHandler = prefab.AddComponent<DadDamageHandler>();
            damageHandler.sub = subBehaviour;
            subBehaviour.dadDamageHandler = damageHandler;
            damageHandler.emergencyMusicEmitter = prefab.AddComponent<FMOD_CustomLoopingEmitter>();
            damageHandler.emergencyMusicEmitter.SetAsset(emergencyMusic);
            damageHandler.emergencyMusicEmitter.followParent = true;
            damageHandler.impactDamage = damageOnImpact;

            // Cameras

            var cameraManager = prefab.AddComponent<CameraManager>();
            cameraManager.sub = subBehaviour;
            cameraManager.sittingPosition = Helpers.FindChild(prefab, "SittingPosition").transform;
            cameraManager.mainViewParent = Helpers.FindChild(prefab, "MainView").transform;

            cameraManager.topCamera = Helpers.FindChild(prefab, "TopCamera").AddComponent<DadSubCamera>();
            cameraManager.topCamera.cameraManager = cameraManager;
            cameraManager.bottomCamera = Helpers.FindChild(prefab, "BottomCamera").AddComponent<DadSubCamera>();
            cameraManager.bottomCamera.cameraManager = cameraManager;

            subBehaviour.cameraManager = cameraManager;

            // Finalize

            prefab.SetActive(true);

            return prefab;
        }

        private PilotHUD AddPilotHUD(GameObject hudRoot, DadSubBehaviour subBehaviour)
        {
            var pilotHUD = hudRoot.AddComponent<PilotHUD>();
            pilotHUD.hudCanvas = pilotHUD.transform.GetChild(0).gameObject;
            pilotHUD.mainStatusText = Helpers.FindChild(pilotHUD.gameObject, "MainStatus").GetComponent<Text>();
            pilotHUD.positionStatusText = Helpers.FindChild(pilotHUD.gameObject, "PositionStatus").GetComponent<Text>();
            pilotHUD.solarStatusText = Helpers.FindChild(pilotHUD.gameObject, "SolarPowerStatus").GetComponent<Text>();
            pilotHUD.healthStatusText = Helpers.FindChild(pilotHUD.gameObject, "HealthPercentage").GetComponent<Text>();
            pilotHUD.powerStatusText = Helpers.FindChild(pilotHUD.gameObject, "PowerPercentage").GetComponent<Text>();
            pilotHUD.sub = subBehaviour;

            var stealthModeButton = HUDButton<DadSubBehaviour>.Create<StealthModeButton>(subBehaviour, Helpers.FindChild(pilotHUD.gameObject, "StealthButton"), "Enable Stealth Mode", Mod.assetBundle.LoadAsset<Sprite>("Stealth 1"), Mod.assetBundle.LoadAsset<Sprite>("Stealth 2"), Mod.assetBundle.LoadAsset<Sprite>("Stealth 3"));
            var deterrenceButton = HUDButton<DadSubBehaviour>.Create<DeterrenceButton>(subBehaviour, Helpers.FindChild(pilotHUD.gameObject, "DeterrenceButton"), "Enable Deterrence System", Mod.assetBundle.LoadAsset<Sprite>("Hypersonic 1"), Mod.assetBundle.LoadAsset<Sprite>("Hypersonic 2"), Mod.assetBundle.LoadAsset<Sprite>("Hypersonic 3"));
            var holographicDecoyButton = HUDButton<DadSubBehaviour>.Create<HolographicDecoyButton>(subBehaviour, Helpers.FindChild(pilotHUD.gameObject, "DecoyButton"), "Enable Holographic Decoy", Mod.assetBundle.LoadAsset<Sprite>("Holographic 1"), Mod.assetBundle.LoadAsset<Sprite>("Holographic 2"), Mod.assetBundle.LoadAsset<Sprite>("Holographic 3"));
            var cameraTopButton = HUDButton<DadSubBehaviour>.Create<CameraButton>(subBehaviour, Helpers.FindChild(pilotHUD.gameObject, "UpperCameraButton"), "View camera", Mod.assetBundle.LoadAsset<Sprite>("CameraUpper"), null, null);
            cameraTopButton.upper = true;
            var cameraBottomButton = HUDButton<DadSubBehaviour>.Create<CameraButton>(subBehaviour, Helpers.FindChild(pilotHUD.gameObject, "LowerCameraButton"), "View camera", Mod.assetBundle.LoadAsset<Sprite>("CameraLower"), null, null);
            cameraBottomButton.upper = false;

            pilotHUD.deterrenceBar = Helpers.FindChild(pilotHUD.gameObject, "HypersonicBar").GetComponent<Image>();
            pilotHUD.stealthBar = Helpers.FindChild(pilotHUD.gameObject, "StealthBar").GetComponent<Image>();

            var warningSymbol = Helpers.FindChild(pilotHUD.gameObject, "LeviathanWarning").AddComponent<WarningSymbol>();
            warningSymbol.warningImage = warningSymbol.GetComponent<Image>();
            warningSymbol.warningText = warningSymbol.GetComponentInChildren<Text>();
            warningSymbol.sub = subBehaviour;
            var warningEmitter = warningSymbol.gameObject.AddComponent<FMOD_CustomLoopingEmitter>();
            warningEmitter.asset = leviathanWarningSound;
            warningEmitter.followParent = true;
            warningSymbol.emitter = warningEmitter;

            pilotHUD.leviathanWarning = warningSymbol;

            return pilotHUD;
        }

        private BatterySource AddBatterySlot(string name, GameObject root, GameObject exosuitReference)
        {
            var modelRoot = Helpers.FindChild(root, "PowerModel").transform;
            var batterySlot = new GameObject(name);
            batterySlot.SetActive(false);
            var identifier = batterySlot.AddComponent<ChildObjectIdentifier>();
            identifier.ClassId = name;
            batterySlot.transform.parent = prefab.transform;

            var powerCellModel = Object.Instantiate(Helpers.FindChild(exosuitReference, "engine_power_cell_L"), modelRoot);
            powerCellModel.transform.localPosition = Vector3.zero;
            powerCellModel.transform.localEulerAngles = Vector3.zero;
            powerCellModel.transform.localScale = Vector3.one;
            var ionPowerCellModel = Object.Instantiate(Helpers.FindChild(exosuitReference, "engine_power_cell_ion_L"), modelRoot);
            ionPowerCellModel.transform.localPosition = Vector3.zero;
            ionPowerCellModel.transform.localEulerAngles = Vector3.zero;
            ionPowerCellModel.transform.localScale = Vector3.one;

            var energyMixin = batterySlot.AddComponent<BatterySource>();
            energyMixin.storageRoot = identifier;
            energyMixin.defaultBattery = TechType.PowerCell;
            energyMixin.defaultBatteryCharge = 1f;
            energyMixin.compatibleBatteries = new List<TechType>() { TechType.PowerCell, TechType.PrecursorIonPowerCell };
            energyMixin.batteryModels = new EnergyMixin.BatteryModels[] { new EnergyMixin.BatteryModels() { model = powerCellModel.gameObject, techType = TechType.PowerCell }, new EnergyMixin.BatteryModels() { model = ionPowerCellModel.gameObject, techType = TechType.PrecursorIonPowerCell } };

            var handTarget = Helpers.FindChild(root, "BatteryInput").AddComponent<EnergyMixinTarget>();
            handTarget.energyMixin = energyMixin;
            handTarget.gameObject.layer = Mod.handTargetLayer;

            batterySlot.SetActive(true);

            return energyMixin;
        }

        private CinematicModeEnder SetCinematicDuration(PlayerCinematicController cinematic, float duration)
        {
            var ender = cinematic.gameObject.AddComponent<CinematicModeEnder>();
            ender.associatedCinematic = cinematic;
            ender.cinematicDuration = duration;
            return ender;
        }

        private void AddInteriorDoor(GameObject model, Vector3 openEulers, Vector3 closeEulers)
        {
            var animated = model.AddComponent<AnimatedDoor>();
            animated.Setup(openEulers, closeEulers, AnimatedDoor.State.Open, 1f, 2f);
            animated.openSound = _openInteriorDoorAsset;
            animated.closeSound = _closeInteriorDoorAsset;

            var interactive = model.AddComponent<InteractiveDoor>();
            interactive.idleText = "Hatch";
            interactive.openText = "Open";
            interactive.closeText = "Close";
            interactive.animations = animated;
        }

        private AnimatedDoor AddExteriorDoor(GameObject model, Vector3 openEulers, Vector3 closeEulers)
        {
            var animated = model.AddComponent<AnimatedDoor>();
            animated.Setup(openEulers, closeEulers, AnimatedDoor.State.Close, 2f, 0.7f);
            animated.openSound = _openExteriorDoorAsset;
            animated.closeSound = _closeExteriorDoorAsset;
            return animated;
        }

        private mset.Sky CopySky(GameObject skyGameObject)
        {
            var cloned = GameObject.Instantiate(skyGameObject);
            cloned.transform.parent = prefab.transform;
            return cloned.GetComponent<mset.Sky>();
        }

        private GameObject AddMoonPoolWaterPlane()
        {
            Base.Initialize();
            var moonpoolPiece = Base.pieces[(int)Base.Piece.Moonpool];
            var moonpoolPrefab = moonpoolPiece.prefab.gameObject;
            var waterPlane = Helpers.FindChild(moonpoolPrefab, "x_BaseWaterPlane");
            return Object.Instantiate(waterPlane, prefab.transform);
        }

        private static FMODAsset _openInteriorDoorAsset = Helpers.GetFmodAsset("event:/sub/cyclops/cyclops_door_open");
        private static FMODAsset _closeInteriorDoorAsset = Helpers.GetFmodAsset("event:/sub/cyclops/cyclops_helm door_close");

        private static FMODAsset _openExteriorDoorAsset = Helpers.GetFmodAsset("event:/sub/cyclops/docking_doors_open");
        private static FMODAsset _closeExteriorDoorAsset = Helpers.GetFmodAsset("event:/sub/cyclops/docking_doors_close");

        private static FMODAsset climbUpLongSound = Helpers.GetFmodAsset("event:/sub/cyclops/climb_front_up");
        private static FMODAsset climbUpShortSound = Helpers.GetFmodAsset("event:/sub/cyclops/climb_back_up");
        private static FMODAsset slideDownSound = Helpers.GetFmodAsset("event:/sub/rocket/ladders/innerRocketShip_ladder_down");

        private static FMODAsset hitSoundHard = Helpers.GetFmodAsset("event:/sub/cyclops/impact_solid_hard");
        private static FMODAsset hitSoundMedium = Helpers.GetFmodAsset("event:/sub/cyclops/impact_solid_medium");
        private static FMODAsset hitSoundSoft = Helpers.GetFmodAsset("event:/sub/cyclops/impact_solid_soft");

        private static FMODAsset subAmbienceLoop = Helpers.GetFmodAsset("event:/sub/cyclops/sub_ambieance");
        private static FMODAsset dockAmbienceLoop = Helpers.GetFmodAsset("DadDockAmbience");

        private static FMODAsset enginePassiveLoop = Helpers.GetFmodAsset("event:/sub/seamoth/torpedo_explode_loop");
        private static FMODAsset engineStartSound = Helpers.GetFmodAsset("event:/env/incubator_powerup");

        private static FMODAsset leviathanWarningSound = Helpers.GetFmodAsset("event:/sub/cyclops/siren");

        private static FMODAsset emergencyMusic = Helpers.GetFmodAsset("event:/env/music/firefighting_music");

        public override TechCategory CategoryForPDA => TechCategory.Constructor;
        public override TechGroup GroupForPDA => TechGroup.Constructor;
        public override string[] StepsToFabricatorTab => new[] { "Vehicles" };
        public override CraftTree.Type FabricatorType => CraftTree.Type.Constructor;
        public override float CraftingTime => 25f;
        public override TechType RequiredForUnlock => TechType.Constructor;

        protected override Atlas.Sprite GetItemSprite()
        {
            return new Atlas.Sprite(Mod.assetBundle.LoadAsset<Sprite>("DadSubIcon"));
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

        private Material GetForcefieldMaterial()
        {
            if (PrefabDatabase.TryGetPrefab("2d72ad6c-d30d-41be-baa7-0c1dba757b7c", out var reference))
            {
                return reference.transform.GetChild(0).GetChild(1).GetComponent<Renderer>().material;
            }
            return null;
        }

        private Material GetStasisFieldMaterial()
        {
            var stasisRifle = CraftData.GetPrefabForTechType(TechType.StasisRifle);
            return stasisRifle.GetComponent<StasisRifle>().effectSpherePrefab.GetComponent<Renderer>().materials[0];
        }

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData(new Ingredient(TechType.TitaniumIngot, 4), new Ingredient(TechType.Magnetite, 2), new Ingredient(TechType.ComputerChip, 2), new Ingredient(TechType.Aerogel, 2), new Ingredient(TechType.EnameledGlass, 1));
        }
    }
}
