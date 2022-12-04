using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace RandomEvents.Events
{
    class Rain : RandomEventBase
    {
        public override float GetDestroyTime => 40f;

        public override string GetEventStartMessage => "";

        TechType techTypeToSpawn;
        GameObject prefabToSpawn;
        float timeSpawnNext;

        public override void StartRandomEvent()
        {
            techTypeToSpawn = Utils.GetRandomRainTechType();
            string text = Language.main.Get(techTypeToSpawn);
            if (text[text.Length - 1] == 'h')
            {
                text += "e";
            }
            if (text[text.Length - 1] != 's' && text[text.Length - 1] != 'm' && text[text.Length - 1] != 'e')
            {
                text += "s";
            }
            ErrorMessage.AddMessage("It's raining " + text + "!");
            prefabToSpawn = CraftData.GetPrefabForTechType(techTypeToSpawn);
            if(prefabToSpawn == null)
            {
                StartCoroutine(GetPrefabAsyncInCase(techTypeToSpawn));
            }
        }

        IEnumerator GetPrefabAsyncInCase(TechType tt)
        {
            var task = CraftData.GetPrefabForTechTypeAsync(tt);
            yield return task;
            prefabToSpawn = task.GetResult();
        }

        void Update()
        {
            if(Time.time > timeSpawnNext)
            {
                timeSpawnNext = Time.time + 0.5f;
                if(techTypeToSpawn == TechType.Locker || techTypeToSpawn == TechType.SmallLocker)
                {
                    SpawnRain(false);
                    timeSpawnNext = Time.time + 2f;
                }
                else
                {
                    SpawnRain();
                    SpawnRain();
                    SpawnRain();
                    SpawnRain();
                }
            }
        }

        void SpawnRain(bool destroy = true)
        {
            if(prefabToSpawn == null)
            {
                return;
            }
            var obj = GameObject.Instantiate(prefabToSpawn, Utils.GetRainPosition(50f), Quaternion.identity);
            obj.SetActive(true);
            Rigidbody rb = obj.EnsureComponent<Rigidbody>();
            rb.isKinematic = false;
            if (destroy) obj.AddComponent<DestroyDelayed>().destroyDelay = 20f;
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
