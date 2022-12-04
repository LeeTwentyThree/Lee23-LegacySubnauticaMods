using System;
using UnityEngine;

namespace RandomEvents.Events
{
    class GuaranteeVehicles : RandomEventBase
    {
        public override float GetDestroyTime => 5f;

        public override string GetEventStartMessage => "";

        public VehicleType vehicleType;

        public override void StartRandomEvent()
        {
            Vector3 playerPosition = Player.main.transform.position;
            if(vehicleType == VehicleType.Seamoth)
            {
                ErrorMessage.AddMessage("You have received a Seamoth for free!");
                GameObject seamothPrefab = CraftData.GetPrefabForTechType(TechType.Seamoth);
                GameObject spawnedObj = Instantiate(seamothPrefab, playerPosition + new Vector3(5f, 10f, 5f), Quaternion.identity);
                CrafterLogic.NotifyCraftEnd(spawnedObj, TechType.Seamoth);
                spawnedObj.SendMessage("StartConstruction", SendMessageOptions.DontRequireReceiver);
            }
            if (vehicleType == VehicleType.Exosuit)
            {
                ErrorMessage.AddMessage("You have received a Prawn Suit for free!");
                GameObject exosuitPrefab = CraftData.GetPrefabForTechType(TechType.Exosuit);
                GameObject spawnedObj = Instantiate(exosuitPrefab, playerPosition + new Vector3(-5f, 10f, 5f), Quaternion.identity);
                CrafterLogic.NotifyCraftEnd(spawnedObj, TechType.Exosuit);
                spawnedObj.SendMessage("StartConstruction", SendMessageOptions.DontRequireReceiver);
            }
            if (vehicleType == VehicleType.Cyclops)
            {
                ErrorMessage.AddMessage("You have received a Cyclops for free!");
                string scenePrefabName = "cyclops";
                spawnPosition = playerPosition + new Vector3(0f, 25f, 5f);
                spawnRotation = Quaternion.identity;
                LightmappedPrefabs.main.RequestScenePrefab(scenePrefabName, new LightmappedPrefabs.OnPrefabLoaded(OnSubPrefabLoaded));
            }
            Utils.GiveDepthModuleForVehicle(vehicleType);
        }

        private void OnSubPrefabLoaded(GameObject prefab)
        {
            GameObject gameObject = global::Utils.SpawnPrefabAt(prefab, null, spawnPosition);
            gameObject.transform.rotation = spawnRotation;
            gameObject.SetActive(true);
            gameObject.SendMessage("StartConstruction", SendMessageOptions.DontRequireReceiver);
            LargeWorldEntity.Register(gameObject);
            CrafterLogic.NotifyCraftEnd(gameObject, CraftData.GetTechType(gameObject));
        }

        private Vector3 spawnPosition;

        private Quaternion spawnRotation;
    }
}
