using UnityEngine;

namespace RandomEvents.Events
{
    class RainUseful : RandomEventBase
    {
        public override float GetDestroyTime => 30f;

        public override string GetEventStartMessage => "";

        float timeSpawnNext;

        public override void StartRandomEvent()
        {
            ErrorMessage.AddMessage("It's raining crafting materials!");
        }

        void Update()
        {
            if(Time.time > timeSpawnNext)
            {
                timeSpawnNext = Time.time + 0.5f;
                SpawnRain();
                SpawnRain();
            }
        }

        void SpawnRain()
        {
            GameObject prefab = CraftData.GetPrefabForTechType(Utils.GetRandomUsefulItem());
            var obj = GameObject.Instantiate(prefab, Utils.GetRainPosition(25f), Quaternion.identity);
            obj.SetActive(true);
            Rigidbody rb = obj.EnsureComponent<Rigidbody>();
            rb.isKinematic = false;
            obj.AddComponent<DestroyDelayed>().destroyDelay = 45f;
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
