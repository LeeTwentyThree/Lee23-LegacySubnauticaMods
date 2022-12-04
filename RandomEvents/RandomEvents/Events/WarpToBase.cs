using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEvents.Events
{
    class WarpToBase : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "You have been teleported back to your base! Does nothing if you are inside a vehicle or base.";

        public override void StartRandomEvent()
        {
			if (Utils.PlayerInSubOrVehicle())
			{
				return;
			}
			SubRoot currentSub = Player.main.GetCurrentSub();
			if (currentSub != null)
			{
				RespawnPoint componentInChildren = currentSub.gameObject.GetComponentInChildren<RespawnPoint>();
				Player.main.SetPosition(componentInChildren.GetSpawnPosition());
				return;
			}
			if (Player.main.lastValidSub != null)
			{
				RespawnPoint componentInChildren2 = Player.main.lastValidSub.gameObject.GetComponentInChildren<RespawnPoint>();
				Player.main.SetPosition(componentInChildren2.GetSpawnPosition());
				Player.main.SetCurrentSub(Player.main.lastValidSub);
				return;
			}
			if (Player.main.lastEscapePod)
			{
				Player.main.lastEscapePod.RespawnPlayer();
				return;
			}
			EscapePod.main.RespawnPlayer();
		}
    }
}
