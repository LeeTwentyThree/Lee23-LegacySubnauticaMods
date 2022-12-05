using CreatureMorphs.Morphs;
using System.Collections.Generic;
using QModManager.API;

namespace CreatureMorphs
{
    public static class MorphDatabase
    {
        internal static void Setup()
        {
            AddBuiltInEntries();
        }

        private static List<Entry> entries = new List<Entry>();

        private static void AddBuiltInEntries()
        {
            AddMorphType(new PeeperMorph(GetClassIdForTechType(TechType.Peeper)), TechType.Peeper);
            AddMorphType(new HoverfishMorph(GetClassIdForTechType(TechType.Hoverfish)), TechType.Hoverfish);
            AddMorphType(new BoomerangMorph(GetClassIdForTechType(TechType.Boomerang)), TechType.Boomerang);

            if (ModExists("ProjectAncients"))
            {
                // gargantuan leviathan...
            }
        }

        private static string GetClassIdForTechType(TechType techType) => CraftData.GetClassIdForTechType(techType);

        private static bool ModExists(string id) => QModServices.Main.ModPresent(id);

        public static void AddMorphType(MorphType morph, params TechType[] creatureTechTypes)
        {
            entries.Add(new Entry(morph, creatureTechTypes));
        }

        public static MorphType GetMorphType(TechType creatureTechType)
        {
            foreach (var entry in entries)
                foreach (var tt in entry.creatureTechTypes)
                    if (tt == creatureTechType) return entry.morph;
            return null;
        }

        private struct Entry
        {
            public TechType[] creatureTechTypes;
            public MorphType morph;

            public Entry(MorphType morph, params TechType[] creatureTechTypes)
            {
                this.creatureTechTypes = creatureTechTypes;
                this.morph = morph;
            }

            public TechType MainTechType => creatureTechTypes[0];
        }
    }
}
