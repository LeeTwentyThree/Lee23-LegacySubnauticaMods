using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class SetWaterDepth : MonoBehaviour
    {
        public float newWaterDepth;

        private void Start()
        {
            GetComponent<WorldForces>().waterDepth = newWaterDepth;
        }

        public static void SetWaterDepthOfPrefab(GameObject prefab, float depth)
        {
            prefab.AddComponent<SetWaterDepth>().newWaterDepth = depth;
        }
    }
}
