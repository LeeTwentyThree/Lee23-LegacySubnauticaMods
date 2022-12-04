using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using RandomEvents.Mono;

namespace RandomEvents.Events
{
    class SpawnReefback : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "Watch your head!";

        public override void StartRandomEvent()
        {
            var prefab = CraftData.GetPrefabForTechType(TechType.Reefback);
            for (int i = 0; i < 3; i++)
            {
                var spawned = Instantiate(prefab, Player.main.transform.position + new Vector3(0, 100f + (i * 30), 0f), Quaternion.identity);
                spawned.SetActive(true);
                spawned.GetComponent<LargeWorldEntity>().enabled = false;
                spawned.AddComponent<DestroyOffScreen>().InitValues(-0.1f, 30f, 120f);
            }
        }
    }
}
