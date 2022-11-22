using System.Collections.Generic;
using System.Reflection;
using QModManager.API.ModLoading;
using UnityEngine;
using Socksfor1Subs.Prefabs;
using Socksfor1Subs.Mono;
using SMLHelper.V2.Handlers;
using HarmonyLib;

namespace Socksfor1Subs
{
    [QModCore()]
    public static class Mod
    {
        public static AssetBundle assetBundle;

        public static DadSub dadSub;
        public static TankPrefab sockTank;

        public static PingType dadSubPingType;
        public static PingType tankPingType;
        public static TechType dadSubBedTechType;

        public static int handTargetLayer = 13;
        public static Vehicle.ControlSheme tankControlScheme = (Vehicle.ControlSheme)42069;

        public static Config config = OptionsPanelHandler.Main.RegisterModOptions<Config>();

        [QModPatch()]
        public static void Entry()
        {
            assetBundle = Helpers.LoadAssetBundleFromAssetsFolder(Assembly.GetExecutingAssembly(), "socksfor1subs");

            dadSub = new DadSub();
            dadSub.Patch();

            var dadSubPingSprite = new Atlas.Sprite(assetBundle.LoadAsset<Sprite>("Dad_Signal"));
            dadSubPingType = PingHandler.RegisterNewPingType("D.A.D. SUBMERSIBLE", dadSubPingSprite);

            sockTank = new TankPrefab();
            sockTank.Patch();

            var tankPingSprite = new Atlas.Sprite(assetBundle.LoadAsset<Sprite>("Tank_Signal"));
            tankPingType = PingHandler.RegisterNewPingType("S.O.C.K. TANK", tankPingSprite);

            dadSubBedTechType = TechTypeHandler.AddTechType("DadSubBed", "Cozy Bed", "Sleepy time.");

            var harmony = new Harmony("Lee23.Socksfor1Subs");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            AddSlotMapping(Tank.slotIDArray[0]);
            AddSlotMapping(Tank.slotIDArray[1]);
            AddSlotMapping(Tank.slotIDArray[2]);
            AddSlotMapping(Tank.slotIDArray[3]);

            AddAcidImmune(dadSub.TechType);
            AddAcidImmune(sockTank.TechType);

            ModAudio.PatchAudio();

            LanguageHandler.SetLanguageLine("TankTorpedoControl", "Fire torpedo ({0})");
            LanguageHandler.SetLanguageLine("TankHarpoonControlFire", "Launch harpoon ({0})");
            LanguageHandler.SetLanguageLine("TankHarpoonControlCancelReel", "Lock harpoon ({0})");
            LanguageHandler.SetLanguageLine("TankHarpoonControlReel", "Reel in harpoon (Release {0})");
            LanguageHandler.SetLanguageLine("TankControlGeneric", "Use weapon ({0})");
            LanguageHandler.SetLanguageLine("TankControlDisplay2", "Activate boost ({0})");
            LanguageHandler.SetLanguageLine("TankControlDisplay3", "Switch weapon ({0})");
            LanguageHandler.SetLanguageLine("TankControlDisplay4", "Switch view ({0})");
        }

        private static void AddAcidImmune(TechType techType)
        {
            DamageSystem.acidImmune = DamageSystem.acidImmune.AddToArray(techType);
        }

        private static void AddSlotMapping(string id)
        {
            var type = EquipmentHandler.Main.AddEquipmentType(id);
            Equipment.slotMapping.Add(id, type);
        }
    }
}