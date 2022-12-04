using UWE;
using UnityEngine;

namespace RandomEvents.Events
{
    class SpawnAmongUs : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "You're very suspicious of something lurking nearby...";

        public override void StartRandomEvent()
        {
            PrefabDatabase.TryGetPrefab(Mod.amongUs.ClassID, out GameObject prefab);
            GameObject obj = GameObject.Instantiate(prefab, Player.main.transform.position + (Random.onUnitSphere * 25f), Quaternion.identity);
            obj.SetActive(true);
            Destroy(obj, 60f);
        }
    }
}
