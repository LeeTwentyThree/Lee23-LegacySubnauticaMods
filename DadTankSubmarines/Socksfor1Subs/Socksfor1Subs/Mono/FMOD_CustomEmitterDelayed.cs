using System.Collections;
using FMOD;
using SMLHelper.V2.Handlers;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class FMOD_CustomEmitterDelayed : FMOD_CustomEmitter
    {
        public float delayMin = 0f;
        public float delayMax = 0f;

        private bool _stopped;

        public override void Start()
        {
            StartCoroutine(DelayedPlay());
        }

        private IEnumerator DelayedPlay()
        {
            for (; ; )
            {
                if (_stopped)
                {
                    yield return null;
                }
                else
                {
                    Play();
                    CustomSoundHandler.TryGetCustomSoundChannel(GetInstanceID(), out var channel);
                    channel.getCurrentSound(out var sound);
                    sound.getLength(out var len, TIMEUNIT.MS);
                    yield return new WaitForSeconds(len / 1000f + Random.Range(delayMin, delayMax));
                }
            }
        }

        public override void OnStop()
        {
            base.OnStop();
            _stopped = true;
        }
    }
}
