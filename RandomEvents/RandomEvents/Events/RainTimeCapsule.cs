using UnityEngine;
using UWE;

namespace RandomEvents.Events
{
    class RainTimeCapsule : RandomEventBase
    {
        public override float GetDestroyTime => 8f;

        public override string GetEventStartMessage => "It's raining time capsules!";

        float timeSpawnNext;

        GameObject prefab;

        public override void StartRandomEvent()
        {
            PrefabDatabase.TryGetPrefab("c129d979-4f68-41d8-b9bc-557676d18a5a", out prefab);
        }

        void Update()
        {
            if(Time.time > timeSpawnNext)
            {
                timeSpawnNext = Time.time + 0.3f;
                SpawnRain();
            }
        }

        void SpawnRain()
        {
            var obj = GameObject.Instantiate(prefab, Utils.GetRainPosition(25f), Quaternion.identity);
            obj.SetActive(true);
            Rigidbody rb = obj.EnsureComponent<Rigidbody>();
            rb.isKinematic = false;
            Destroy(obj, 30f);
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
