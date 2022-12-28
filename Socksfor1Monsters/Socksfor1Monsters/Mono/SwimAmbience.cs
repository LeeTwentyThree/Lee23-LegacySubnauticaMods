using ECCLibrary;
using ECCLibrary.Internal;
using System.Collections;
using UnityEngine;

namespace Socksfor1Monsters.Mono
{
    public class SwimAmbience : MonoBehaviour
    {
        public string swimSoundPrefix = "BloopSwim";
        public int audioSourceCount = 3;
        public float delay = 2f;

        ECCAudio.AudioClipPool clipPool;
        AudioSource[] myAudioSources;

        void Awake()
        {
            clipPool = ECCAudio.CreateClipPool(swimSoundPrefix);
            myAudioSources = new AudioSource[audioSourceCount];
            for(int i = 0; i < audioSourceCount; i++)
            {
                myAudioSources[i] = AddSource();
            }
            
        }

        AudioSource AddSource()
        {
            AudioSource source;
            source = gameObject.AddComponent<AudioSource>();
            source.volume = ECCHelpers.GetECCVolume();
            source.maxDistance = 40f;
            source.spatialBlend = 1f;
            return source;
        }

        AudioSource GetAvailableSource()
        {
            for(int i = 0; i < audioSourceCount; i++)
            {
                if (!myAudioSources[i].isPlaying)
                {
                    return myAudioSources[i];
                }
            }
            ECCLog.AddMessage("No empty source found");
            return null;
        }

        IEnumerator Start()
        {
            for(; ; )
            {
                yield return new WaitForSeconds(delay);
                AudioSource nextSource = GetAvailableSource();
                nextSource.clip = clipPool.GetRandomClip();
                nextSource.pitch = Random.Range(0.9f, 1.1f);
                nextSource.Play();
            }
        }
    }
}
