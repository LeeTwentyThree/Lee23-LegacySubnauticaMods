using UWE;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityStandardAssets.ImageEffects;
using RandomEvents.Mono;

namespace RandomEvents.Events
{
    class Suspense : RandomEventBase
    {
        public override float GetDestroyTime => 25f;

        public override string GetEventStartMessage => "Something's watching you...";

        public override void StartRandomEvent()
        {
            StartCoroutine(Lifetime());
        }

        private GameObject reaper;

        private void SpawnReaper()
        {
            PrefabDatabase.TryGetPrefab(CraftData.GetClassIdForTechType(TechType.ReaperLeviathan), out GameObject prefab);
            reaper = GameObject.Instantiate(prefab, Player.main.transform.position + (GetPlayerCamera().transform.forward * 10f), Quaternion.identity);
            reaper.transform.LookAt(GetPlayerCamera().transform);
            reaper.SetActive(true);
            LargeWorldEntity reaperLwe = reaper.GetComponent<LargeWorldEntity>();
            if (reaperLwe != null)
            {
                reaperLwe.StopFading();
            }
            reaper.GetComponent<Rigidbody>().isKinematic = true;
            reaper.AddComponent<DestroyOffScreen>().InitValues(0f, 10f, 30f);
        }

        private Camera GetPlayerCamera()
        {
            return Player.main.viewModelCamera;
        }
        
        private IEnumerator Lifetime()
        {
            SetSuspenseState(true);
            var sound = GetBaseInteriorAudio();
            yield return new WaitForSeconds(15f);
            SpawnReaper();
            Time.timeScale = 0.2f;
            sound.Stop();
            yield return new WaitForSecondsRealtime(3f);
            if (reaper != null)
            {
                reaper.GetComponent<Rigidbody>().isKinematic = false;
            }
            Time.timeScale = 1f;
            Destroy(sound.gameObject);
            SetSuspenseState(false);
        }

        private FMOD_CustomLoopingEmitter GetBaseInteriorAudio()
        {
            FMODAsset asset = ScriptableObject.CreateInstance<FMODAsset>();
            asset.path = "event:/sub/base/base_background";
            var obj = new GameObject("BaseInteriorSound");
            var emitter = obj.AddComponent<FMOD_CustomLoopingEmitter>();
            emitter.SetAsset(asset);
            emitter.Play();
            return emitter;
        }

        private void SetSuspenseState(bool enabled)
        {
            var cam = GetPlayerCamera();
            var grayscale = cam.GetComponent<Grayscale>();
            grayscale.enabled = enabled;
            grayscale.effectAmount = enabled ? 1f : 0f;
            var blur = cam.GetComponent<RadialBlurScreenFXController>();
            blur.SetAmount(enabled ? 1f : 0f);
        }
    }
}
