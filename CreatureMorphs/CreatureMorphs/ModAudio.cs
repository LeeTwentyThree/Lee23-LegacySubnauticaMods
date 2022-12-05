using FMOD;
using UnityEngine;
using SMLHelper.V2.FMod;
using SMLHelper.V2.Utility;
using SMLHelper.V2.Handlers;

namespace CreatureMorphs
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

        public static FMODAsset MorphPreySound;
        public static FMODAsset MorphHerbivoreSound;
        public static FMODAsset MorphSharkSound;
        public static FMODAsset MorphLeviathanSound;
        public static FMODAsset MorphGargSound;

        public static void PatchAudio()
        {
            MorphPreySound = AddWorldSoundEffect(Main.bundle.LoadAsset<AudioClip>("PreySting"), "MorphPrey");
            MorphHerbivoreSound = AddWorldSoundEffect(Main.bundle.LoadAsset<AudioClip>("MediumSting"), "MorphHerbivore");
            MorphSharkSound = AddWorldSoundEffect(Main.bundle.LoadAsset<AudioClip>("SharkSting"), "MorphShark");
            MorphLeviathanSound = AddWorldSoundEffect(Main.bundle.LoadAsset<AudioClip>("LeviathanTransformation"), "MorphLeviathan");
            MorphGargSound = AddWorldSoundEffect(Main.bundle.LoadAsset<AudioClip>("GargTransformation"), "MorphGarg");
        }

        private static FMODAsset AddWorldSoundEffect(AudioClip clip, string soundPath, float minDistance = 1f, float maxDistance = 100f, string overrideBus = null)
        {
            var sound = AudioUtils.CreateSound(clip, k3DSoundModes);
            if (maxDistance > 0f)
            {
                sound.set3DMinMaxDistance(minDistance, maxDistance);
            }
            CustomSoundHandler.RegisterCustomSound(soundPath, sound, string.IsNullOrEmpty(overrideBus) ? kSFXBus : overrideBus);
            return Helpers.GetFmodAsset(soundPath);
        }
    }
}
