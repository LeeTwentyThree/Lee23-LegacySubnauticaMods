﻿using UWE;
using UnityEngine;
using RandomEvents.Mono;

namespace RandomEvents.Events
{
    class SpawnBloop : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "A Bloop emerges from the depths!";

        public override void StartRandomEvent()
        {
            PrefabDatabase.TryGetPrefab("Bloop", out GameObject prefab);
            GameObject obj = GameObject.Instantiate(prefab, Player.main.transform.position + (Random.onUnitSphere * 50f), Quaternion.identity);
            obj.SetActive(true);
            obj.GetComponent<LargeWorldEntity>().enabled = false;
            obj.AddComponent<DestroyOffScreen>().InitValues(0f, 60f, 120f);
        }
    }
}
