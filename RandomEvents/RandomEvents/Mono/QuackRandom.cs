using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ECCLibrary;

namespace RandomEvents.Mono
{
    class QuackRandom : MonoBehaviour
    {
        AudioSource src;
        ECCAudio.AudioClipPool clipPool;
        WorldForces worldForces;

        void Start()
        {
            src = gameObject.AddComponent<AudioSource>();
            src.volume = ECCHelpers.GetECCVolume();
            src.spatialBlend = 1f;
            src.minDistance = 4f;
            src.maxDistance = 15f;
            clipPool = ECCAudio.CreateClipPool("Quack");
            StartCoroutine(Loop());
            worldForces = GetComponent<WorldForces>();
        }

        IEnumerator Loop()
        {
            while (true)
            {
                AudioClip clip = clipPool.GetRandomClip();
                float length = clip.length;
                src.clip = clip;
                src.Play();
                yield return new WaitForSeconds(length + Random.Range(2f, 6f));
            }
        }

        void Update()
        {
            worldForces.waterDepth = Ocean.main.GetOceanLevel() - 1f;
        }
    }
}
