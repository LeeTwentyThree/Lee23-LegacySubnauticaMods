namespace NoAutoPickup
{
    public static class Logic
    {
        public static CraftTree.Type GetCraftTreeForGhostCrafter(GhostCrafter ghostCrafter)
        {
            return ghostCrafter.craftTree;
        }

        public static bool CraftTreeIsModded(CraftTree.Type type)
        {
            var integer = (int)type;
            return integer < 0 || integer > 10;
        }

        public static bool ShouldDisableAutoPickupForCraftTree(CraftTree.Type type)
        {
            if (CraftTreeIsModded(type))
            {
                return Mod.Config.NoAutoPickup_Modded;
            }
            switch (type)
            {
                case CraftTree.Type.Fabricator:
                    return Mod.Config.NoAutoPickup_Fabricator;
                case CraftTree.Type.Workbench:
                    return Mod.Config.NoAutoPickup_ModificationStation;
                default:
                    return Mod.Config.NoAutoPickup_Other;
            }
        }
    }
}
