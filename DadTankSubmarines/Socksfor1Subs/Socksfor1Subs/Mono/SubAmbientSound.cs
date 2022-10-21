using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class SubAmbientSound : MonoBehaviour
    {
        public DadSubBehaviour sub;
        public FMODAsset soundAsset;
        public float radius;

        private FMOD_CustomEmitterDelayed emitter;

        private void Start()
        {
            emitter = gameObject.AddComponent<FMOD_CustomEmitterDelayed>();
            emitter.SetAsset(soundAsset);
            emitter.followParent = true;
        }
        
        private void Update()
        {
            if (CanPlay())
            {
                emitter.Play();
            }
            else
            {
                emitter.Stop();
            }
        }
        
        private bool CanPlay()
        {
            if (sub.LOD.current != LODState.Full)
            {
                return false;
            }
            if (Player.main.GetCurrentSub() != sub)
            {
                return false;
            }
            return Vector3.Distance(transform.position, MainCameraControl.main.transform.position) < radius;
        }
    }
}
