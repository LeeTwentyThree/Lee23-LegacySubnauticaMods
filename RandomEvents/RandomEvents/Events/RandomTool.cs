using UnityEngine;

namespace RandomEvents.Events
{
    class RandomTool : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "Giving you a random tool!";

        public override void StartRandomEvent()
        {
            TechType tt = Utils.GetRandomTool();
            CraftData.AddToInventory(tt, 1, true, true);
        }
    }
}
