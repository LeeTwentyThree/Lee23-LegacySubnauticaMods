using UnityEngine;

namespace RandomEvents.Events
{
    class WaterLevelChange : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "The water level has changed!";

        public override void StartRandomEvent()
        {
            Utils.ChangeWaterLevel(Random.Range(-8f, 15f));
        }
    }
}
