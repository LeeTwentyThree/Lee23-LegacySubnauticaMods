using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class ExteriorDoorsController : MonoBehaviour
    {
        public DadSubBehaviour sub;
        public Transform doorTriggerCenter;

        public float playerTriggerDistanceOutside = 20f;
        public float playerTriggerDistanceInside = 5f;
        public float vehicleTriggerDistance = 30f;

        private void Update()
        {
            var shouldOpen = AutomaticallyOpen();
            foreach (var exteriorDoor in sub.exteriorDoors)
            {
                exteriorDoor.SetState(shouldOpen ? AnimatedDoor.State.Open : AnimatedDoor.State.Close);
            }
        }

        private bool AutomaticallyOpen()
        {
            if (!sub.constructing.IsConstructed())
            {
                return false;
            }
            var distanceToPlayer = Vector3.Distance(doorTriggerCenter.position, Player.main.transform.position);
            if (Player.main.IsSwimming())
            {
                return distanceToPlayer < playerTriggerDistanceOutside;
            }
            else if (Player.main.GetCurrentSub() == sub)
            {
                return distanceToPlayer < playerTriggerDistanceInside;
            }
            var vehicle = Player.main.GetVehicle();
            if (vehicle != null)
            {
                if (!vehicle.docked && distanceToPlayer < vehicleTriggerDistance)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
