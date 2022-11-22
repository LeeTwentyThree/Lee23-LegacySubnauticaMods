using UnityEngine;

namespace MirrorWorld
{
    public static class FlipLogic
    {
        private const float kAuroraDefaultY = -70.21f;

        public static void Flip(bool x, bool y, bool z)
        {
            var root = GetLandscapeRoot();
            root.localScale = new Vector3(x ? -1f : 1f, y ? -1f : 1f, z ? -1f : 1f);
            var terrainY = GetTerrainY();
            root.localPosition = new Vector3(0f, terrainY, 0f);
            if (Ocean.main != null)
            {
                FixOceanPosition(Ocean.main.gameObject);
            }
        }

        public static void FixOceanPosition(GameObject ocean)
        {
            if (ocean != null)
            {
                ocean.transform.position = new Vector3(0, 0, 0);
            }
        }

        public static void FixAuroraPosition(Transform root)
        {
            root.localScale = new Vector3(1f, 1f, -1f);
            root.position = new Vector3(root.position.x, kAuroraDefaultY + GetTerrainY(), root.position.z);
        }

        private static Transform GetLandscapeRoot()
        {
            return LargeWorld.main.transform.parent;
        }

        public static float GetTerrainY()
        {
            return Mod.config.yAxis ? Mod.config.shallowsYLevel : 0f;
        }
    }
}
