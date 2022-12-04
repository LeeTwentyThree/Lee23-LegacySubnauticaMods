using UnityEngine;
using System.Collections;

namespace RandomEvents.Events
{
    class WarpRandom : RandomEventBase
    {
        public override float GetDestroyTime => 6f;

        public override string GetEventStartMessage => "Teleporting you to a random position in 3 seconds... (You're immune if you're inside a vehicle or base!)";

        public override void StartRandomEvent()
        {
            StartCoroutine(Lifetime());
        }

        IEnumerator Lifetime()
        {
            yield return new WaitForSeconds(3f);
            if (!Utils.PlayerInSubOrVehicle())
            {
                Player.main.SetPosition(GetRandomPos());
                Player.main.OnPlayerPositionCheat();
            }
        }

        Vector3 GetRandomPos()
        {
            return new Vector3(Random.Range(-1500f, 1500f), Random.Range(-100f, 100f), Random.Range(-1500f, 1500f));
        }
    }
}
