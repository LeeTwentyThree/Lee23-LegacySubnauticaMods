using UnityEngine;

namespace RandomEvents.Events
{
    class FillInventory : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "";

        public override void StartRandomEvent()
        {
            int amount = Random.Range(2, 5);
            for(int i = 0; i < amount; i++)
            {
                DoSupplyDrop();
            }
        }

        void DoSupplyDrop()
        {
            GameObject prefab = CraftData.GetPrefabForTechType(TechType.SmallStorage);
            GameObject obj = GameObject.Instantiate(prefab, Player.main.transform.position + (Random.onUnitSphere * 2f), Quaternion.identity);
            obj.transform.localScale = Vector3.one * 1.3f;
            obj.GetComponent<FPModel>().OnUnequip(null, null);
            StorageContainer container = obj.GetComponentInChildren<StorageContainer>(true);
            TechType tt = Utils.GetSupplyDropTechType();
            GameObject itemPrefab = CraftData.GetPrefabForTechType(tt);
            string itemName = Language.main.Get(tt);
            Utils.ChangeFloatingLockerText(obj, itemName);
            ErrorMessage.AddMessage("You got a supply drop for " + itemName + "!");
            for (int i = 0; i < 16; i++)
            {
                GameObject item = GameObject.Instantiate(itemPrefab);
                item.SetActive(false);
                container.container.AddItem(item.GetComponent<Pickupable>());
            }
            obj.SetActive(true);
        }
    }
}
