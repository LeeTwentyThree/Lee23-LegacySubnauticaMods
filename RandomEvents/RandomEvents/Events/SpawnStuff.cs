using UnityEngine;
using System.Collections.Generic;
using UWE;

namespace RandomEvents.Events
{
    abstract class SpawnStuff : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override void StartRandomEvent()
        {
            var list = GetSpawnList;
            TechType toSpawn = list[Random.Range(0, list.Count)];
            DoCustomStuff(toSpawn);
            GameObject prefab = CraftData.GetPrefabForTechType(toSpawn);
            if (prefab == null) return;
            int maxSpawns = Random.Range(MinSpawns, MaxSpawns);
            for(int i = 0; i < maxSpawns; i++)
            {
                GameObject obj = Instantiate(prefab, GetSpawnPosition(), Random.rotation);
                obj.SetActive(true);
                OnSpawned(obj, toSpawn);
                if (Despawn)
                {
                    Destroy(obj, CreatureDespawnDelay);
                }
            }
        }

        protected virtual void OnSpawned(GameObject spawnedObj, TechType tt)
        {

        }
        protected virtual void DoCustomStuff(TechType creatureTechType)
        {

        }

        public Vector3 GetSpawnPosition()
        {
            Vector3 pos = Player.main.transform.position;
            if (InsideSphere)
            {
                pos += Random.insideUnitSphere * GetSpawnDistance;
            }
            else
            {
                pos += Random.onUnitSphere * GetSpawnDistance;
            }
            pos = new Vector3(pos.x, Mathf.Clamp(pos.y, Mathf.NegativeInfinity, Ocean.main.GetOceanLevel()), pos.z);
            return pos;
        }
        
        public abstract float GetSpawnDistance { get; }
        public abstract bool InsideSphere { get; }
        public abstract List<TechType> GetSpawnList { get; }
        public abstract int MinSpawns { get; }
        public abstract int MaxSpawns { get; }
        public abstract float CreatureDespawnDelay { get; }
        public virtual bool Despawn { get { return true; } }
    }
}
