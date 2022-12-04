using UnityEngine;
using UWE;

namespace RandomEvents.Events
{
    class RainWater : RandomEventBase
    {
        public override float GetDestroyTime => 8f;

        public override string GetEventStartMessage => "It's raining water!";

        float timeSpawnNext;

        GameObject prefab;

        public override void StartRandomEvent()
        {
            PrefabDatabase.TryGetPrefab("f7fb4077-b4d7-443c-b367-349cc1d39cc8", out prefab);
        }

        void Update()
        {
            if(Time.time > timeSpawnNext)
            {
                timeSpawnNext = Time.time + 0.3f;
                SpawnRain();
                SpawnRain();
                SpawnRain();
            }
        }

        void SpawnRain()
        {
            var obj = GameObject.Instantiate(prefab, Utils.GetRainPosition(20f), Quaternion.identity);
            obj.SetActive(true);
            Rigidbody rb = obj.EnsureComponent<Rigidbody>();
            rb.isKinematic = false;
            obj.AddComponent<DestroyDelayed>().destroyDelay = 30f;
            WorldForces wf = obj.GetComponent<WorldForces>();
            if(wf == null)
            {
                rb.useGravity = true;
            }
            else
            {
                wf.aboveWaterGravity = 9.81f;
            }
        }
    }
}
