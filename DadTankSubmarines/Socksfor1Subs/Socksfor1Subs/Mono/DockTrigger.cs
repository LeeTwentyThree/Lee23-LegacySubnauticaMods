using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class DockTrigger : MonoBehaviour
    {
        public DadSubDock dock;

        public bool tankOnly;

        private void OnTriggerEnter(Collider other)
        {
            var vehicle = other.gameObject.GetComponentInParent<Vehicle>();
            if (vehicle != null)
            {
                if (tankOnly)
                {
                    if (!(vehicle is Tank))
                    {
                        return;
                    }
                }
                dock.DockVehicle(vehicle);
            }
        }
    }
}
