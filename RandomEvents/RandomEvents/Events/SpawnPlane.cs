using ECCLibrary;
using UWE;
using UnityEngine;
using System.Collections;
using RandomEvents.Mono;

namespace RandomEvents.Events
{
    class SpawnPlane : RandomEventBase
    {
        public override float GetDestroyTime => 30f;

        public override string GetEventStartMessage => "SEEK SHELTER IMMEDIATELY";

        public override void StartRandomEvent()
        {
            GameObject obj = GameObject.Instantiate(Mod.assetBundle.LoadAsset<GameObject>("PlaneEvent_Prefab"));
            obj.transform.position = Vector3.zero;
            ECCHelpers.ApplySNShaders(obj, new UBERMaterialProperties(8f, 1f, 1f));
            Utils.AddSkyApplier(obj);
            Destroy(obj, 20f);
            Utils.IncreaseFarplane();

            StartCoroutine(Lifetime());
            PlaySFX();
        }

        IEnumerator Lifetime()
        {
            yield return new WaitForSeconds(10f);
            DropBomb();
        }

        void PlaySFX()
        {
            GameObject obj = new GameObject("Plane SFX");
            var src = obj.AddComponent<AudioSource>();
            src.clip = Mod.assetBundle.LoadAsset<AudioClip>("PlaneFly");
            src.volume = ECCHelpers.GetECCVolume();
            src.Play();
        }

        void DropBomb()
        {
            GameObject bomb = Instantiate(Mod.assetBundle.LoadAsset<GameObject>("AmongUsBomb_Prefab"), new Vector3(-420, 1228, 0), Quaternion.identity);
            Utils.LookAtPlayerUpright(bomb.transform);
            Utils.AddSkyApplier(bomb);
            ECCHelpers.ApplySNShaders(bomb, new UBERMaterialProperties(8f, 1f, 1f));
            var rb = bomb.AddComponent<Rigidbody>();
            rb.mass = 69420;
            rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
            var c = bomb.AddComponent<AmongUsBomb>();
            c.rb = rb;
        }
    }
}
