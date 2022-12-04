using UnityEngine;

namespace RandomEvents.Events
{
    class RandomUpgrade : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "Giving you a random upgrade module!";

        public override void StartRandomEvent()
        {
            TechType tt = Utils.GetRandomUpgradeModule();
            CraftData.AddToInventory(tt, 1, true, true);
        }
    }
}
