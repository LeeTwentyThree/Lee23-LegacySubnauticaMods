using UnityEngine;

namespace RisingLava
{
    public class LavaAmbientSounds : MonoBehaviour
    {
        private static FMODAsset sound = Helpers.GetFMODAsset("event:/env/background/lava_river_loop");

        private static float maxDistanceOverPlane = 30f;

        private FMOD_CustomLoopingEmitter emitter;

        private void Start()
        {
            var emitter = new GameObject("LavaAmbientSounds").AddComponent<FMOD_CustomLoopingEmitter>();
            emitter.SetAsset(sound);
            emitter.transform.parent = transform;
            emitter.transform.localPosition = Vector3.zero;
            this.emitter = emitter;
        }

        private void Update()
        {
            bool inRadius = MainCamera.camera.transform.position.y < Main.LavaLevel + maxDistanceOverPlane;
            if (inRadius)
            {
                emitter.Play();
            }
            else if (emitter.playing)
            {
                emitter.Stop();
            }
        }
    }
}
