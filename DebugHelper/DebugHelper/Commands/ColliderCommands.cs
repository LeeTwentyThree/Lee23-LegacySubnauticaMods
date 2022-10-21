using UnityEngine;
using SMLHelper.V2.Commands;
using System.Collections;
using UWE;

namespace DebugHelper.Commands
{
    public static class ColliderCommands
    {
        private static Material stasisFieldMaterial;

        private static IEnumerator LoadStasisFieldMaterial()
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.StasisRifle);
            yield return task;

            GameObject stasisRifle = task.GetResult();
            stasisFieldMaterial = new Material(stasisRifle.GetComponent<StasisRifle>().effectSpherePrefab.GetComponentInChildren<Renderer>().materials[1]);
            stasisFieldMaterial.color = new Color(0.3f, 1f, 0f);
        }

        [ConsoleCommand("showcolliders")]
        public static void ShowColliders() // make this into a coroutine  p         leeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeease                 ALSO add hitTriggers bool
        {
            if (stasisFieldMaterial == null)
            {
                ErrorMessage.AddMessage("Materials not loaded! Please try again in a moment.");
                CoroutineHost.StartCoroutine(LoadStasisFieldMaterial());
                return;
            }
            Transform scanTransform = MainCameraControl.main.transform;
            if (Physics.Raycast(scanTransform.position + scanTransform.forward, scanTransform.forward, out RaycastHit hit, 1000f))
            {
                if (hit.collider.GetComponentInParent<Player>())
                {
                    ErrorMessage.AddMessage("Warning: raycast hit player");
                    return;
                }
                Transform root = hit.collider.transform;
                var prefabIdentifier = hit.collider.GetComponentInParent<PrefabIdentifier>();
                if (prefabIdentifier != null)
                {
                    root = prefabIdentifier.transform;
                }
                else
                {
                    var rb = hit.collider.attachedRigidbody;
                    if (rb != null)
                    {
                        root = rb.transform;
                    }
                }
                ErrorMessage.AddMessage(string.Format("Showing colliders within object '{0}'.", root.gameObject.name));
                ShowColliders(root);
            }
            else
            {
                ErrorMessage.AddMessage("Raycast failed to hit anything.");
            }
        }

        private static void ShowColliders(Transform objectRoot)
        {
            foreach (var col in objectRoot.GetComponentsInChildren<Collider>())
            {
                var parent = col.transform;
                if (col is SphereCollider sphere)
                {
                    var sphereTransform = RenderCollider(parent, GameObject.CreatePrimitive(PrimitiveType.Sphere), Vector3.one * sphere.radius * 2f, sphere.center);
                    sphereTransform.transform.parent = null;
                    sphereTransform.transform.localScale = Vector3.one * sphere.radius * 2f; // spheres are always spherical regardless of parent size!
                    sphereTransform.transform.parent = parent;
                }
                if (col is BoxCollider box)
                {
                    RenderCollider(parent, GameObject.CreatePrimitive(PrimitiveType.Cube), box.size, box.center);
                }
                if (col is CapsuleCollider capsule)
                {
                    RenderCollider(parent, GameObject.CreatePrimitive(PrimitiveType.Capsule), new Vector3(capsule.radius * 2f, capsule.height / 2, capsule.radius * 2f), capsule.center);
                    // account for all rotations!!
                }
                if (col is MeshCollider meshCollider)
                {
                    var rendererObj = new GameObject("Mesh Collider Object");
                    rendererObj.AddComponent<MeshRenderer>();
                    rendererObj.AddComponent<MeshFilter>().mesh = meshCollider.sharedMesh;
                    RenderCollider(parent, rendererObj, Vector3.one, Vector3.zero);
                }
            }
        }

        private static Transform RenderCollider(Transform parent, GameObject shape, Vector3 localScale, Vector3 center)
        {
            Object.DestroyImmediate(shape.GetComponent<Collider>());
            shape.transform.parent = parent;
            shape.transform.localScale = localScale;
            shape.transform.localPosition = center;
            shape.transform.localEulerAngles = Vector3.zero;
            var r = shape.GetComponent<Renderer>();
            r.material = stasisFieldMaterial;
            return shape.transform;
        }

        [ConsoleCommand("lookingat")]
        public static void LookingAt(bool hitTriggers = false)
        {
            Transform scanTransform = MainCameraControl.main.transform;
            if (Physics.Raycast(scanTransform.position + scanTransform.forward, scanTransform.forward, out RaycastHit hit, float.MaxValue, -1, hitTriggers ? QueryTriggerInteraction.Collide : QueryTriggerInteraction.Ignore))
            {
                var hitGameObject = hit.collider.gameObject;
                var parent = hitGameObject.transform.parent;
                var attachedRb = hit.collider.attachedRigidbody;
                var root = UWE.Utils.GetEntityRoot(hitGameObject);
                ErrorMessage.AddMessage($"Raycast hit collider of name '{hitGameObject.name}'");
                if (parent != null)
                {
                    ErrorMessage.AddMessage($"Collider is direct child of '{parent.name}'");
                }
                if (attachedRb != null)
                {
                    ErrorMessage.AddMessage($"Collider is attached to the RigidBody '{attachedRb.gameObject.name}'");
                }
                if (root != null)
                {
                    ErrorMessage.AddMessage($"Entity root of this collider is '{root.name}'");
                }
            }
            else
            {
                ErrorMessage.AddMessage("Raycast failed.");
            }
        }
    }
}
