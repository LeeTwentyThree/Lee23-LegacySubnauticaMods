using CreatureMorphs.Morphs;
using System.Collections.Generic;
using QModManager.API;

namespace CreatureMorphs
{
    internal static class MorphDatabase
    {
        private static List<Entry> entries;

        private static void InitializeList()
        {
            entries = new List<Entry>();
            Add(new PeeperMorph(GetClassIdForTechType(TechType.Peeper)), TechType.Peeper);

            if (ModExists("ProjectAncients"))
            {
                // gargantuan leviathan...
            }
        }

        private static string GetClassIdForTechType(TechType techType) => CraftData.GetClassIdForTechType(techType);

        private static bool ModExists(string id) => QModServices.Main.ModPresent(id);

        private static void Add(MorphType morph, params TechType[] creatureTechTypes)
        {
            entries.Add(new Entry(morph, creatureTechTypes));
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
        }
    }
}
