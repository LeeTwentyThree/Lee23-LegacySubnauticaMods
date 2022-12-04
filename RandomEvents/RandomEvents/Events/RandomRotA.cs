using UnityEngine;
using SMLHelper.V2.Handlers;

namespace RandomEvents.Events
{
    class RandomRotA : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "Giving you random items from the Return of the Ancients mod!";

        static bool givenWarpCannonYet = false;

        public override void StartRandomEvent()
        {
            TechType tt;
            if (givenWarpCannonYet == false)
            {
                givenWarpCannonYet = true;
                TechTypeHandler.TryGetModdedTechType("WarpCannon", out tt);
            }
            else
            {
                tt = Utils.GetRandomRotAItem();
            }
            CraftData.AddToInventory(tt, 1, true, true);
            if (TechTypeHandler.TryGetModdedTechType("PrecursorIngot", out TechType ingot))
            {
                CraftData.AddToInventory(ingot, 2, true, true);
            }
        }
    }
}
