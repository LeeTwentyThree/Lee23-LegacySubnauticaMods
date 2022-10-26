using FMOD;
using UnityEngine;
using SMLHelper.V2.Utility;
using SMLHelper.V2.Handlers;

namespace TimTheEnchanter
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

        public static void PatchAudio()
        {

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
    }
}
