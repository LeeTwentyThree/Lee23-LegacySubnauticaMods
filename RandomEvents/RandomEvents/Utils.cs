using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SMLHelper.V2.Handlers;
using UWE;

namespace RandomEvents
{
    public static class Utils
    {
        public static int GetOutsideLayerMask()
        {
            return LayerMask.GetMask("Default", "Useable", "NotUseable", "TerrainCollider");
        }

        public static TechType GetRandomTechType(bool mustBePickupable)
        {
            for (int tries = 0; tries < 200; tries++)
            {
                TechType tt = (TechType)Random.Range(0, 12000);
                if (TechTypeValid(tt))
                {
                    if (mustBePickupable)
                    {
                        if (!TechTypePickupable(tt))
                        {
                            continue;
                        }
                    }
                    return tt;
                }
            }
            return TechType.Titanium;
        }

        public static bool InCutscene()
        {
            return IntroVignette.isIntroActive;
        }

        public static bool TechTypeValid(TechType tt)
        {
            if (!CraftData.techMapping.ContainsKey(tt))
            {
                return false;
            }
            GameObject prefab = CraftData.GetPrefabForTechType(tt);
            if (prefab == null)
            {
                return false;
            }
            return true;
        }

        public static bool TechTypePickupable(TechType tt)
        {
            GameObject prefab = CraftData.GetPrefabForTechType(tt);
            if (prefab == null)
            {
                return false;
            }
            if (prefab.GetComponent<Pickupable>() == null)
            {
                return false;
            }
            return true;
        }

        public static Vector3 GetRainPosition(float radius, bool inSphere = true)
        {
            Vector3 rainBase = Player.main.transform.position + new Vector3(0f, 30f, 0f);
            Vector3 randomBase;
            if (inSphere == true)
            {
                randomBase = Random.insideUnitSphere;
            }
            else
            {
                randomBase = Random.onUnitSphere;
            }
            Vector3 random = randomBase * radius;
            return rainBase + new Vector3(random.x, 0f, random.z);
        }

        public static void AddSkyApplier(GameObject obj)
        {
            obj.AddComponent<SkyApplier>();
        }

        public static bool PlayerInSubOrVehicle()
        {
            if (Player.main.IsInSub() || Player.main.GetVehicle() != null)
            {
                return true;
            }
            if (Player.main.IsInsideWalkable())
            {
                return true;
            }
            return false;
        }

        public static TechType GetRandomUsefulItem()
        {
            if(Random.value < 0.5f)
            {
                return usefulItems[Random.Range(0, usefulItems.Count)];
            }
            else
            {
                if(Random.value < 0.5f)
                {
                    return TechType.Titanium;
                }
                else
                {
                    return TechType.Copper;
                }
            }
        }

        public static TechType GetRandomBlueprint()
        {
            return blueprints[Random.Range(0, blueprints.Count)];
        }

        public static TechType GetRandomTool()
        {
            return tools[Random.Range(0, tools.Count)];
        }

        public static TechType GetRandomRotAItem()
        {
            CreateRotAItems();
            if (rotaItems != null && rotaItems.Count > 0)
            {
                return rotaItems[Random.Range(0, rotaItems.Count)];
            }
            return TechType.Titanium;
        }

        public static TechType GetRandomUpgradeModule()
        {
            return upgradeModules[Random.Range(0, upgradeModules.Count)];
        }

        public static TechType GetRandomRainTechType()
        {
            return rainItems[Random.Range(0, rainItems.Count)];
        }

        public static TechType GetSupplyDropTechType()
        {
            if(Random.value < 0.4f)
            {
                return GetRandomTechType(true);
            }
            else
            {
                return GetRandomUsefulItem();
            }
        }

        public static TechType GetRandomLockedBlueprint()
        {
            for(int i = 0; i < 200; i++)
            {
                var tech = blueprints[Random.Range(0, blueprints.Count)];
                if (!KnownTech.Contains(tech))
                {
                    return tech;
                }
            }
            return blueprints[Random.Range(0, blueprints.Count)];
        }

        public static List<TechType> usefulItems = new List<TechType>() { TechType.Titanium, TechType.Titanium, TechType.TitaniumIngot, TechType.Kyanite, TechType.PrecursorIonPowerCell, TechType.ComputerChip, TechType.Lead, TechType.Sulphur, TechType.Copper, TechType.Nickel, TechType.Aerogel, TechType.Lithium, TechType.EnameledGlass, TechType.CyclopsShieldModule, TechType.Glass, TechType.AdvancedWiringKit, TechType.Diamond, TechType.Gold, TechType.Silver, TechType.PowerCell, TechType.Constructor, TechType.Quartz };

        public static List<TechType> rainItems = new List<TechType>() { TechType.Titanium, TechType.TitaniumIngot, TechType.Kyanite, TechType.PrecursorIonPowerCell, TechType.ComputerChip, TechType.Lead, TechType.Sulphur, TechType.Copper, TechType.Nickel, TechType.Lithium, TechType.Diamond, TechType.Gold, TechType.Silver, TechType.PowerCell, TechType.SmallLocker, TechType.SmallLocker, TechType.Workbench, TechType.Welder, TechType.Fabricator, TechType.FarmingTray, TechType.Floater, TechType.FireExtinguisher, TechType.CutefishEgg, TechType.Cutefish, TechType.LabCounter, TechType.Locker, TechType.SmallLocker, TechType.Trashcans, TechType.ToyCar, TechType.NutrientBlock, TechType.PrecursorDroid, TechType.MedicalCabinet, TechType.Bed1, TechType.HatchingEnzymes };


        public static List<TechType> blueprints = new List<TechType>() { TechType.PrecursorIonEnergyBlueprint, TechType.Bleach, TechType.Seamoth, TechType.Exosuit, TechType.Workbench, TechType.BaseRoom, TechType.Seaglide, TechType.BaseMoonpool, TechType.BaseBioReactor, TechType.ExosuitDrillArmModule, TechType.CyclopsShieldModule, TechType.Cyclops, TechType.RocketBase, TechType.Trashcans };

        public static List<TechType> tools = new List<TechType>() { TechType.HeatBlade, TechType.Builder, TechType.Seaglide, TechType.LaserCutter, TechType.Welder, TechType.StasisRifle };

        static void CreateRotAItems()
        {
            if (rotaItems != null)
            {
                return;
            }
            rotaItems = new List<TechType>();

            if (TechTypeHandler.TryGetModdedTechType("WarpCannon", out TechType t1))
            {
                rotaItems.Add(t1);
            }
            if (TechTypeHandler.TryGetModdedTechType("IonBuilder", out TechType t2))
            {
                rotaItems.Add(t2);
            }
            if (TechTypeHandler.TryGetModdedTechType("IonKnife", out TechType t3))
            {
                rotaItems.Add(t3);
            }
            if (TechTypeHandler.TryGetModdedTechType("ExosuitDashModule", out TechType t4))
            {
                rotaItems.Add(t4);
            }
            if (TechTypeHandler.TryGetModdedTechType("CyclopsDecoyMk2", out TechType t5))
            {
                rotaItems.Add(t5);
            }
            if (TechTypeHandler.TryGetModdedTechType("GargantuanAdultToy", out TechType t6))
            {
                rotaItems.Add(t6);
            }
        }
        public static List<TechType> rotaItems;

        public static List<TechType> upgradeModules = new List<TechType>() { TechType.VehicleHullModule3, TechType.CyclopsHullModule3, TechType.ExoHullModule2, TechType.CyclopsShieldModule, TechType.SeamothElectricalDefense, TechType.ExosuitDrillArmModule, TechType.ExosuitGrapplingArmModule };

        public static float overrideWaterLevel = 0f;

        public static void ForceGive(TechType techType, int amount = 1)
        {
            for (int i = 0; i < amount; i++)
            {
                var prefab = CraftData.GetPrefabForTechType(techType);
                var spawned = GameObject.Instantiate(prefab);
                Inventory.main.ForcePickup(spawned.GetComponent<Pickupable>());
            }
        }

        public static void ChangeWaterLevel(float level)
        {
            if(TryFindObject(out Ocean ocean))
            {
                ocean.transform.position = new Vector3(0f, level, 0f);
            }

            if (TryFindObject(out WaterSurface waterSurface))
            {
                waterSurface.transform.position = new Vector3(0f, level, 0f);
            }
            overrideWaterLevel = level;
        }

        static bool TryFindObject<T>(out T outObject) where T : Object
        {
            outObject = Object.FindObjectOfType<T>();
            if(outObject != null)
            {
                return true;
            }
            return false;
        }

        public static void ChangeFloatingLockerText(GameObject locker, string text)
        {
            var label = locker.GetComponentInChildren<ColoredLabel>(true);
            if(label != null)
            {
                label.text = text;
                label.OnProtoDeserialize(null);
            }
        }

        public static System.Type GetRandomEvent(string lastEventName)
        {
            if (testingMode)
            {
                return eventTypesTesting[Random.Range(0, eventTypesTesting.Count)];
            }
            if (Player.main.precursorOutOfWater)
            {
                return GetRandomEventPrecursor(lastEventName);
            }
            if(Player.main.transform.position.y <= -1000f)
            {
                return GetRandomEventDeep(lastEventName);
            }
            else if (Player.main.transform.position.y < -55f)
            {
                return GetRandomEventUnderwater(lastEventName);
            }
            else
            {
                return GetRandomEventSurface(lastEventName);
            }
        }

        public static System.Type GetRandomEventSurface(string lastEventName)
        {
            System.Type type;
            for (int i = 0; i < 1000; i++)
            {
                type = eventTypesSurfaceOnly[Random.Range(0, eventTypesSurfaceOnly.Count)];
                if (lastEventName != type.ToString())
                {
                    return type;
                }
            }
            return eventTypesSurfaceOnly[Random.Range(0, eventTypesSurfaceOnly.Count)];
        }

        public static System.Type GetRandomEventUnderwater(string lastEventName)
        {
            System.Type type;
            for (int i = 0; i < 1000; i++)
            {
                type = eventTypesUnderwaterOnly[Random.Range(0, eventTypesUnderwaterOnly.Count)];
                if (lastEventName != type.ToString())
                {
                    return type;
                }
            }
            return eventTypesUnderwaterOnly[Random.Range(0, eventTypesUnderwaterOnly.Count)];
        }


        public static System.Type GetRandomEventDeep(string lastEventName)
        {
            System.Type type;
            for (int i = 0; i < 1000; i++)
            {
                type = eventTypesDeepOnly[Random.Range(0, eventTypesDeepOnly.Count)];
                if (lastEventName != type.ToString())
                {
                    return type;
                }
            }
            return eventTypesDeepOnly[Random.Range(0, eventTypesDeepOnly.Count)];
        }

        public static System.Type GetRandomEventPrecursor(string lastEventName)
        {
            System.Type type;
            for (int i = 0; i < 1000; i++)
            {
                type = eventTypesPrecursorBase[Random.Range(0, eventTypesPrecursorBase.Count)];
                if (lastEventName != type.ToString())
                {
                    return type;
                }
            }
            return eventTypesPrecursorBase[Random.Range(0, eventTypesPrecursorBase.Count)];
        }

        public static float PointOnScreenDot(Vector3 point)
        {
            var player = Player.main.viewModelCamera.transform;
            Vector3 direction = (point - player.position).normalized;
            return Vector3.Dot(direction, player.forward);
        }

        public static void SetBlurState(bool enabled)
        {
            var cam = Player.main.viewModelCamera;
            var blur = cam.GetComponent<RadialBlurScreenFXController>();
            blur.SetAmount(enabled ? 1f : 0f);
        }

        public static void IncreaseFarplane()
        {
            Player.main.viewModelCamera.farClipPlane = 4000;
        }

        public static void LookAtPlayerUpright(Transform viewer)
        {
            viewer.LookAt(Player.main.viewModelCamera.transform);
            viewer.localEulerAngles = new Vector3(0f, viewer.localEulerAngles.y, 0f);
        }

        public static void LookAtPlayerUprightGlobal(Transform viewer)
        {
            viewer.LookAt(Player.main.viewModelCamera.transform);
            viewer.eulerAngles = new Vector3(0f, viewer.eulerAngles.y, 0f);
        }

        public static void PlaySound(string fmodEventPath, Vector3 pos = default)
        {
            if (pos == default)
            {
                pos = Player.main.transform.position;
            }
            FMODAsset a = ScriptableObject.CreateInstance<FMODAsset>();
            a.path = fmodEventPath;
            global::Utils.PlayFMODAsset(a, pos);
        }

        public static void GiveDepthModuleForVehicle(VehicleType vehicleType)
        {
            TechType tt;
            switch (vehicleType)
            {
                default:
                    return;
                case VehicleType.Seamoth:
                    tt = TechType.VehicleHullModule3;
                    break;
                case VehicleType.Exosuit:
                    tt = TechType.ExoHullModule2;
                    break;
                case VehicleType.Cyclops:
                    tt = TechType.CyclopsHullModule3;
                    break;
            }
            if (tt != TechType.None)
            {
                CraftData.AddToInventory(tt, 1, true, true);
            }
        }

        public static bool testingMode = false; // ALWAYS SET THIS TO FALSE IN RELEASE BUILDS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        public static List<System.Type> eventTypesTesting = new List<System.Type>()
        {
            typeof(Events.SpawnGargantuan),
        };

        public static List<System.Type> eventTypesUnderwaterOnly = new List<System.Type>()
        {
            typeof(Events.LeviathanAttack),
            typeof(Events.FishAttack),
            typeof(Events.FillInventory),
            typeof(Events.FillInventory),
            typeof(Events.FillInventory),
            typeof(Events.SpawnBloop),
            typeof(Events.SpawnBlaza),
            typeof(Events.WarpRandom),
            typeof(Events.Rain),
            typeof(Events.Rain),
            typeof(Events.SetCreatureSize),
            typeof(Events.RainUseful),
            typeof(Events.FillInventoryVaried),
            typeof(Events.Unlock),
            typeof(Events.RainTimeCapsule),
            typeof(Events.CraftAnything),
            typeof(Events.RainWater),
            typeof(Events.RandomTool),
            typeof(Events.RandomUpgrade),
            typeof(Events.RandomUpgrade),
            typeof(Events.SpawnGargantuan),
            typeof(Events.FishAttackBad),
            typeof(Events.FishAttackBad),
            typeof(Events.SpawnAmongUs),
            typeof(Events.Suspense),
            typeof(Events.Herobrine),
            typeof(Events.NewSwimSpeed),
            typeof(Events.ErrorSwarm),
            typeof(Events.ChargeBatteries),
            typeof(Events.DuplicateLifepod),
            typeof(Events.RandomRotA),
        };

        public static List<System.Type> eventTypesSurfaceOnly = new List<System.Type>()
        {
            typeof(Events.LeviathanAttack),
            typeof(Events.FishAttack),
            typeof(Events.FillInventory),
            typeof(Events.FillInventory),
            typeof(Events.SpawnBloop),
            typeof(Events.SpawnBlaza),
            typeof(Events.WarpRandom),
            typeof(Events.Rain),
            typeof(Events.Rain),
            typeof(Events.SetCreatureSize),
            typeof(Events.RainUseful),
            typeof(Events.FillInventoryVaried),
            typeof(Events.Unlock),
            typeof(Events.RainTimeCapsule),
            typeof(Events.CraftAnything),
            typeof(Events.RainWater),
            typeof(Events.RandomTool),
            typeof(Events.RandomUpgrade),
            typeof(Events.RandomUpgrade),
            typeof(Events.FishAttackBad),
            typeof(Events.SpawnReefback),
            typeof(Events.SpawnAmongUs),
            typeof(Events.Suspense),
            typeof(Events.ShrekCult),
            typeof(Events.Herobrine),
            typeof(Events.NewSwimSpeed),
            typeof(Events.SpawnPlane),
            typeof(Events.ChargeBatteries),
            typeof(Events.RandomRotA),
            typeof(Events.SpawnGargantuan),
        };

        public static List<System.Type> eventTypesDeepOnly = new List<System.Type>()
        {
            typeof(Events.LeviathanAttack),
            typeof(Events.LeviathanAttack),
            typeof(Events.FishAttack),
            typeof(Events.FillInventory),
            typeof(Events.FillInventory),
            typeof(Events.FillInventory),
            typeof(Events.SpawnBloop),
            typeof(Events.SpawnBlaza),
            typeof(Events.SpawnBlaza),
            typeof(Events.Rain),
            typeof(Events.SetCreatureSize),
            typeof(Events.RainUseful),
            typeof(Events.Unlock),
            typeof(Events.CraftAnything),
            typeof(Events.RainWater),
            typeof(Events.RandomTool),
            typeof(Events.RandomUpgrade),
            typeof(Events.RandomUpgrade),
            typeof(Events.SpawnGargantuan),
            typeof(Events.FishAttackBad),
            typeof(Events.FishAttackBad),
            typeof(Events.FishAttackBad),
            typeof(Events.SpawnAmongUs),
            typeof(Events.Suspense),
            typeof(Events.Herobrine),
            typeof(Events.Herobrine),
            typeof(Events.Herobrine),
            typeof(Events.NewSwimSpeed),
            typeof(Events.ErrorSwarm),
            typeof(Events.ChargeBatteries),
            typeof(Events.DuplicateLifepod),
            typeof(Events.RandomRotA),
        };


        public static List<System.Type> eventTypesPrecursorBase = new List<System.Type>()
        {
            typeof(Events.AlienRobotAttack),
            typeof(Events.FillInventory),
            typeof(Events.Unlock),
            typeof(Events.RandomUpgrade),
            typeof(Events.Herobrine),
        };
    }
}
