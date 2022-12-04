using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RandomEvents.Events
{
    class SpawnVehicle : SpawnStuff
    {
        public override float GetSpawnDistance => 10f;

        public override bool InsideSphere => true;

        public override List<TechType> GetSpawnList => new List<TechType>() { TechType.Seamoth, TechType.Exosuit };

        public override int MinSpawns => 1;

        public override int MaxSpawns => 1;

        public override float CreatureDespawnDelay => 45f;

        public override string GetEventStartMessage => "A vehicle has been given to you for free!";

        protected override void OnSpawned(GameObject spawnedObj, TechType tt)
        {
            CrafterLogic.NotifyCraftEnd(spawnedObj, tt);
            spawnedObj.SendMessage("StartConstruction", SendMessageOptions.DontRequireReceiver);
            VehicleType vehicleType = VehicleType.Seamoth;
            if (tt == TechType.Exosuit)
            {
                vehicleType = VehicleType.Exosuit;
            }
            Utils.GiveDepthModuleForVehicle(vehicleType);
        }

        public override bool Despawn => false;
    }
}
