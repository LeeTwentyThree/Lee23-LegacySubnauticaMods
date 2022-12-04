using CreatureMorphs.Morphs;
using System.Collections.Generic;
using QModManager.API;

namespace CreatureMorphs
{
    internal static class MorphDatabase
    {
        private static List<CreatureMorph> morphs;

        private static void InitializeList()
        {
            morphs = new List<CreatureMorph>();
            morphs.Add(new PeeperMorph("Peeper"));

            if (ModExists("ProjectAncients"))
            {
                // gargantuan leviathan...
            }
        }

        private static string GetClassIdForTechType(TechType techType) => CraftData.GetClassIdForTechType(techType);

        private static bool ModExists(string id) => QModServices.Main.ModPresent(id);
    }
}
