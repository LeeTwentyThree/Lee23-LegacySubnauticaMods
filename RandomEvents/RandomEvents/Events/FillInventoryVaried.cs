using UnityEngine;

namespace RandomEvents.Events
{
    class FillInventoryVaried : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "You got a supply drop of various items!";

        public override void StartRandomEvent()
        {
            int amount = Random.Range(2, 4);
            for (int i = 0; i < amount; i++)
            {
                DoSupplyDrop();
            }
        }

        void DoSupplyDrop()
        {
            GameObject prefab = CraftData.GetPrefabForTechType(TechType.SmallStorage);
            GameObject obj = GameObject.Instantiate(prefab, Player.main.transform.position + Random.onUnitSphere, Quaternion.identity);
            obj.transform.localScale = Vector3.one * 2f;
            Utils.ChangeFloatingLockerText(obj, "Random");
            obj.GetComponent<FPModel>().OnUnequip(null, null);
            StorageContainer container = obj.GetComponentInChildren<StorageContainer>(true);
            for (int i = 0; i < 16; i++)
            {
                TechType tt = Utils.GetRandomTechType(true);
                GameObject item = GameObject.Instantiate(CraftData.GetPrefabForTechType(tt));
                item.SetActive(false);
                container.container.AddItem(item.GetComponent<Pickupable>());
            }
            obj.SetActive(true);
        }
    }
}
