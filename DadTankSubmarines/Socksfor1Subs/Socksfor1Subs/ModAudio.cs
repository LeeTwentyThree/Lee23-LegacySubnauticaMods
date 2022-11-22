using FMOD;
using UnityEngine;
using SMLHelper.V2.FMod;
using SMLHelper.V2.Utility;
using SMLHelper.V2.Handlers;

namespace Socksfor1Subs
{
    public static class ModAudio
    {
        /// <summary>
        /// 3D sounds
        /// </summary>
        public const MODE k3DSoundModes = MODE.DEFAULT | MODE._3D | MODE.ACCURATETIME | MODE._3D_LINEARSQUAREROLLOFF;
        /// <summary>
        /// 2D sounds
        /// </summary>
        public const MODE k2DSoundModes = MODE.DEFAULT | MODE._2D | MODE.ACCURATETIME;
        /// <summary>
        /// For music, PDA and any 2D sounds that cant have more than one instance playing at a time.
        /// </summary>
        public const MODE kStreamSoundModes = k2DSoundModes | MODE.CREATESTREAM;

        public const string kMusicSFXBus = "bus:/master/nofilter/music";
        public const string kSFXBus = "bus:/master/all/SFX";
        public const string kPDABus = "bus:/master/all/all voice/AI voice";
        public const string kCyclopsBus = "bus:/master/all/all voice/cyclops voice";

        public static FMODAsset SharedButtonClick = Helpers.GetFmodAsset("SocksSubClick");
        public static FMODAsset BatteryPowerUpSound = Helpers.GetFmodAsset("event:/tools/battery_insert");
        public static FMODAsset BatteryPowerDownSound = Helpers.GetFmodAsset("event:/tools/battery_die");

        public static void PatchAudio()
        {
            // DAD - VO

            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_HolographicDecoy"), "DadHolographicDecoy", "Holographic decoy activated.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_HostileLifeform"), "DadHostileLifeform", "Warning: Hostile lifeform detected.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_HullDamage"), "DadHullDamage", "External hull damage detected!");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_PassingSafeDepth"), "DadPassingSafeDepth", "Attention: Passing safe depth.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_StealthDisabled"), "DadStealthDisabled", "Cloaking apparatus overheating! Stealth mode disengaged.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_StealthEnabled"), "DadStealthEnabled", "Stealth mode engaged.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_StealthReady"), "DadStealthReady", "Stealth mode ready for operation.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_WelcomeAboard"), "DadWelcomeAboard", "Welcome aboard captain. D.A.D. Submersible online and ready for operation.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_EmergencyPower"), "DadEmergencyPower", "Emergency power only. Oxygen production offline.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_EngineOn"), "DadEngineOn", "Engine powering up...");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_HullDamage"), "DadHullDamage", "External hull damage detected.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_HullFailureImminent"), "DadHullFailureImminent", "Warning: Hull failure imminent.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_WelcomeNegative"), "DadWelcomeNegative", "Welcome aboard captain. Some systems need attention.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Dad_WelcomeSecret"), "DadWelcomeSecret", "You aren't the worst captain on the planet. I'm not even salty.");

            // DAD - SFX

            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_StealthEnable"), "DadStealthEnable");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_StealthDisable"), "DadStealthDisable");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_Alert"), "DadAlert");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_Dock"), "DadDock");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_Undock"), "DadUndock");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_HolographicDecoyFX"), "DadHolographicDecoyFX", 5f, 500f);
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_DockAmbience"), "DadDockAmbience", 4f, 30f, "bus:/master/all/indoorsounds");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_EngineOnFX"), "DadEngineOnFX");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_ExplosionExterior"), "DadExplosionExterior", 5f, 500f);
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Dad_ExplosionInterior"), "DadExplosionInterior", 30f, 200f);

            // SHARED

            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("ButtonClick"), "SocksSubClick");

            // TANK - VO

            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_HullDamage"), "TankHullDamage", "Caution: Major hull damage sustained.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_HullIntegrityCritical"), "TankHullIntegrityCritical", "Warning: Hull integrity critical!");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_NoPower"), "TankNoPower", "Emergency power only. All primary systems offline.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Welcome"), "TankWelcome", "Welcome aboard captain. S.O.C.K. Submersible Tank ready for deployment.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_NoTorpedoes"), "TankNoTorpedoes", "Torpedo reserve depleted.");

            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill1"), "TankKill1", "Target eliminated.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill2"), "TankKill2", "Hostile down.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill3"), "TankKill3", "Bullseye.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill4"), "TankKill4", "Target destroyed.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill5"), "TankKill5", "Target annihilated.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill6"), "TankKill6", "Specimen destroyed.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill7"), "TankKill7", "It's not personal, just business.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill8"), "TankKill8", "I'm sorry, did you want that fish?");

            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_KillLeviathan1"), "TankKillLeviathan1", "Target no longer a threat.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_KillLeviathan2"), "TankKillLeviathan2", "Threat level neutralized.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_KillLeviathan3"), "TankKillLeviathan3", "Threat neutralized.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Kill7"), "TankKillLeviathan4", "It's not personal, just business.");

            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_FriendlyFire1"), "TankFriendlyFire1", "Please excercise caution when firing torpedoes.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_FriendlyFire2"), "TankFriendlyFire2", "I can't believe you just did that.");
            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_FriendlyFire3"), "TankFriendlyFire3", "User error detected.");

            AddSubVoiceLine(Mod.assetBundle.LoadAsset<AudioClip>("Tank_FriendlyFire3"), "TankUserError", "User error detected.");

            // TANK - SFX

            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Boost"), "TankBoost");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Death"), "TankDeath");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_DriveLoop"), "TankDriveLoop");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_EngineLoop"), "TankEngineLoop");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_ExplosionClose"), "TankTorpedoExplosionClose", 10f, 400f);
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_ExplosionFar"), "TankTorpedoExplosionFar", 5f, 6000f);
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_ReloadTorpedo"), "TankReloadHarpoon");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_ShootHarpoon"), "TankShootHarpoon");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Startup"), "TankStartup");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_ReloadTorpedo"), "TankReloadTorpedo");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_HarpoonLoop"), "TankHarpoonLoop");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_Rotate"), "TankRotate");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_CancelReelIn"), "TankCancelReelIn");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_ReelLoop"), "TankReelLoop", 1f, 100f, "bus:/master/all/SFX/reverbsend/tech");
            AddWorldSoundEffect(Mod.assetBundle.LoadAsset<AudioClip>("Tank_ReelLoop2"), "TankReelLoop2", 1f, 100f, "bus:/master/all/SFX/reverbsend/tech");
        }

        private static void AddSubVoiceLine(AudioClip clip, string soundPath, string subtitles)
        {
            var sound = AudioUtils.CreateSound(clip, kStreamSoundModes);
            CustomSoundHandler.RegisterCustomSound(soundPath, sound, kCyclopsBus);
            if (!string.IsNullOrEmpty(subtitles))
            {
                LanguageHandler.SetLanguageLine(soundPath, subtitles);
            }
        }

        private static void AddWorldSoundEffect(AudioClip clip, string soundPath, float minDistance = 1f, float maxDistance = 100f, string overrideBus = null)
        {
            var sound = AudioUtils.CreateSound(clip, k3DSoundModes);
            if (maxDistance > 0f)
            {
                sound.set3DMinMaxDistance(minDistance, maxDistance);
            }
            CustomSoundHandler.RegisterCustomSound(soundPath, sound, string.IsNullOrEmpty(overrideBus) ? kSFXBus : overrideBus);
        }

        private static void AddInterfaceSoundEffect(AudioClip clip, string soundPath)
        {
            var sound = AudioUtils.CreateSound(clip, k2DSoundModes);
            CustomSoundHandler.RegisterCustomSound(soundPath, sound, kSFXBus);
        }
    }
}
