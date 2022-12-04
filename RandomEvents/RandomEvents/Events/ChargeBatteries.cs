using System;
using UnityEngine;

namespace RandomEvents.Events
{
    class ChargeBatteries : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "A mysterious impulse of energy has recharged your batteries";

        public override void StartRandomEvent()
        {
            var inventoryRoot = Player.main.gameObject;
            var energyMixin = inventoryRoot.GetComponentsInChildren<Battery>(true);
            for (int i = 0; i < energyMixin.Length; i++)
            {
                energyMixin[i].charge = energyMixin[i].capacity;
            }
            Utils.PlaySound("event:/creature/shocker/shock");
        }
    }
}
