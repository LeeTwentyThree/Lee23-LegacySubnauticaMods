using System;
using UnityEngine;

namespace RandomEvents.Events
{
    class CraftAnything : RandomEventBase
    {
        public override float GetDestroyTime => 30f;

        public override string GetEventStartMessage => "You can craft anything you want for free for the next 30 seconds. Don't waste your chance!";

        public override void StartRandomEvent()
        {
            GameModeUtils.ActivateCheat(GameModeOption.NoCost);
        }

        void OnDestroy()
        {
            GameModeUtils.DeactivateCheat(GameModeOption.NoCost);
        }
    }
}
