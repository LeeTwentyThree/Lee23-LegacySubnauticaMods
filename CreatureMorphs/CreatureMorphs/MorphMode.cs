using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureMorphs
{
    public enum MorphModeType
    {
        Prey,
        Herbivore,
        Shark,
        Leviathan,
        Garg
    }

    public static class MorphModeData
    {
        public static void Setup()
        {
            database = new Dictionary<MorphModeType, MorphMode>()
            {
                {MorphModeType.Prey, new MorphMode(0.1f, ModAudio.MorphPreySound) },
                {MorphModeType.Herbivore, new MorphMode(0.1f, ModAudio.MorphHerbivoreSound) },
                {MorphModeType.Shark, new MorphMode(0.1f, ModAudio.MorphSharkSound) },
                {MorphModeType.Leviathan, new MorphMode(5f, ModAudio.MorphLeviathanSound) },
                {MorphModeType.Garg, new MorphMode(10f, ModAudio.MorphGargSound) }
            };
        }
        private static Dictionary<MorphModeType, MorphMode> database;
        public static MorphMode GetData(MorphModeType type)
        {
            return database[type];
        }
    }
    public class MorphMode
    {
        public float transformationDuration;
        public FMODAsset soundAsset;

        public MorphMode(float transformationDuration, FMODAsset soundAsset)
        {
            this.transformationDuration = transformationDuration;
            this.soundAsset = soundAsset;
        }
    }
}
