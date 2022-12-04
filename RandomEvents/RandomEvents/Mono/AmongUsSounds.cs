using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ECCLibrary;

namespace RandomEvents.Mono
{
    class AmongUsSounds : MonoBehaviour
    {
        AudioSource src;
        ECCAudio.AudioClipPool clipPool;

        void Start()
        {
            src = gameObject.AddComponent<AudioSource>();
            src.volume = ECCHelpers.GetECCVolume();
            src.spatialBlend = 1f;
            src.maxDistance = 10f;
            clipPool = ECCAudio.CreateClipPool("AmongUs");
            StartCoroutine(Loop());
        }

        IEnumerator Loop()
        {
            while (true)
            {
                AudioClip clip = clipPool.GetRandomClip();
                float length = clip.length;
                src.clip = clip;
                src.Play();
                yield return new WaitForSeconds(length * Random.Range(0.15f, 1.5f));
            }
        }
    }
}
