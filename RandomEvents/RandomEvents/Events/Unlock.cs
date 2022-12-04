using System;
using UnityEngine;

namespace RandomEvents.Events
{
    class Unlock : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "Giving you a random blueprint!";

        public override void StartRandomEvent()
        {
            KnownTech.Add(Utils.GetRandomLockedBlueprint());
        }
    }
}
