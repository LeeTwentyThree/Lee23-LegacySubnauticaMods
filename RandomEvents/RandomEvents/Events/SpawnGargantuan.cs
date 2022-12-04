using UWE;
using UnityEngine;

namespace RandomEvents.Events
{
    class SpawnGargantuan : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "The Gargantuan Leviathan approaches! Good luck...";

        public override void StartRandomEvent()
        {
            PrefabDatabase.TryGetPrefab("GargantuanJuvenile", out GameObject prefab);
            GameObject obj = GameObject.Instantiate(prefab, Utils.GetRainPosition(100f, false), Quaternion.identity);
            obj.SetActive(true);
            obj.GetComponent<LargeWorldEntity>().enabled = false;
        }
    }
}
