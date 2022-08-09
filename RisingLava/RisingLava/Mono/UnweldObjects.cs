using UnityEngine;

namespace RisingLava.Mono
{
    public class UnweldObjects : MonoBehaviour
    {
        private float interval = 0.5f;
        private float timeUnweldAgain;
        private float depth = 30f;
        private float width = 30f;
        private float maxDistance = 65f;
        private float yOffset = -2f;

        private void Update()
        {
            if (Time.time > timeUnweldAgain && Ready())
            {
                timeUnweldAgain = Time.time + interval;
                UnweldInBounds(GetRandomBounds());
            }
        }

        private bool Ready()
        {
            return Main.config.UnweldObjects && Helpers.Distance1D(Main.LavaLevel, MainCamera.camera.transform.position.y) < 100f;
        }

        private Bounds GetRandomBounds()
        {
            var camPos = MainCamera.camera.transform.position;
            var xz = new Vector2(camPos.x, camPos.z) + Random.insideUnitCircle * maxDistance;
            var center = new Vector3(xz.x, Main.LavaLevel + yOffset - (depth / 2f), xz.y);
            return new Bounds(center, new Vector3(width / 2f, depth / 2f, width / 2f));
        }

        private void UnweldInBounds(Bounds bounds)
        {
            var colliders = UWE.Utils.OverlapBoxIntoSharedBuffer(bounds.center, bounds.size, Quaternion.identity, -1, QueryTriggerInteraction.Ignore);
            for (int i = 0; i < colliders; i++)
            {
                var col = UWE.Utils.sharedColliderBuffer[i];
                var entityRoot = UWE.Utils.GetEntityRoot(col.gameObject);
                if (entityRoot != null)
                {
                    UnweldObject(entityRoot);
                }
            }
        }

        private void UnweldObject(GameObject obj)
        {
            bool hasWorldForces = false;
            var wf = obj.GetComponent<WorldForces>();
            Rigidbody rb;
            if (wf != null)
            {
                rb = wf.useRigidbody;
                hasWorldForces = true;
            }
            else
            {
                rb = obj.GetComponent<Rigidbody>();
            }
            if (rb != null && !rb.isKinematic)
            {
                return;
            }
            var prefabIdentifier = obj.GetComponent<PrefabIdentifier>();
            if (prefabIdentifier == null)
            {
                return;
            }
            if (rb == null)
            {
                rb = obj.EnsureComponent<Rigidbody>();
                rb.mass = 100f;
            }
            if (!hasWorldForces)
            {
                wf = obj.AddComponent<WorldForces>();
                wf.handleGravity = true;
            }
            rb.useGravity = false;
            wf.useRigidbody = rb;
            rb.isKinematic = false;
        }
    }
}