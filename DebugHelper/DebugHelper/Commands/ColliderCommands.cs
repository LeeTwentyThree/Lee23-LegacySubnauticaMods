using UnityEngine;
using SMLHelper.V2.Commands;
using System.Collections;
using System.Collections.Generic;
using UWE;

namespace DebugHelper.Commands
{
    public static class ColliderCommands
    {
        private static Material colliderMaterial; // generic colliders
        private static Material physicsColliderMaterial; // colliders on non-kinematic rigidbodies
        private static Material triggerMaterial; // colliders with isTrigger set to true
        private static Material meshColliderMaterial; // anything with the MeshCollider component

        private static List<GameObject> colliderRendererObjects = new List<GameObject>();

        private static IEnumerator LoadStasisFieldMaterial()
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.StasisRifle);
            yield return task;

            GameObject stasisRifle = task.GetResult();
            var stasisBall = stasisRifle.GetComponent<StasisRifle>().effectSpherePrefab.GetComponentInChildren<Renderer>();
            colliderMaterial = new Material(stasisBall.materials[1]);
            colliderMaterial.color = new Color(0.3f, 1f, 0f);
            physicsColliderMaterial = new Material(stasisBall.materials[1]);
            physicsColliderMaterial.color = new Color(1f, 0.2f, 0.2f);
            triggerMaterial = new Material(stasisBall.materials[1]);
            triggerMaterial.color = new Color(0.5f, 0.5f, 0.5f);
            meshColliderMaterial = new Material(stasisBall.materials[1]);
            meshColliderMaterial.color = new Color(0.2f, 0.2f, 1f);
        }

        [ConsoleCommand("showcolliders")]
        public static void ShowColliders(bool hitsTriggers = false)
        {
            CoroutineHost.StartCoroutine(ShowCollidersCoroutine(hitsTriggers));
        }

        [ConsoleCommand("showallcolliders")]
        public static void ShowCollidersInRange(float maxRange)
        {
            CoroutineHost.StartCoroutine(ShowCollidersInRangeCoroutine(maxRange));
        }

        [ConsoleCommand("hidecolliders")]
        public static void HideColliders()
        {
            int destruido = 0;
            foreach (var obj in colliderRendererObjects)
            {
                if (obj != null)
                {
                    Object.Destroy(obj);
                    destruido++;
                }
            }
            colliderRendererObjects.Clear();
            ErrorMessage.AddMessage($"Destroyed all {destruido} collider renderers.");
        }

        private static IEnumerator ShowCollidersCoroutine(bool hitsTriggers)
        {
            if (colliderMaterial == null)
            {
                yield return CoroutineHost.StartCoroutine(LoadStasisFieldMaterial());
            }
            Transform scanTransform = SNCameraRoot.main.transform;
            if (Physics.Raycast(scanTransform.position + scanTransform.forward, scanTransform.forward, out RaycastHit hit, float.MaxValue, -1, hitsTriggers ? QueryTriggerInteraction.Collide : QueryTriggerInteraction.Ignore))
            {
                if (hit.collider.GetComponentInParent<Player>())
                {
                    ErrorMessage.AddMessage("Warning: raycast hit player");
                    yield break;
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
                RenderCollidersInChildren(root);
            }
            else
            {
                ErrorMessage.AddMessage("Raycast failed to hit anything.");
            }
        }

        private static IEnumerator ShowCollidersInRangeCoroutine(float maxRange)
        {
            if (colliderMaterial == null)
            {
                yield return CoroutineHost.StartCoroutine(LoadStasisFieldMaterial());
            }
            HideColliders();
            var center = SNCameraRoot.main.transform.position;
            var allColliders = Physics.OverlapSphere(center, maxRange); // all colliders
            var colliders = new List<Collider>(); // just colliders we want to use
            var playerRb = Player.main.rigidBody;
            foreach (var collider in allColliders)
            {
                if (collider.attachedRigidbody != playerRb) // don't show player colliders
                {
                    colliders.Add(collider);
                }
            }
            ErrorMessage.AddMessage($"Showing all {colliders.Count} colliders within {(int)maxRange} meters.");
            foreach (var collider in colliders)
            {
                RenderCollider(collider);
            }
            ErrorMessage.AddMessage("Use the 'hidecolliders' command to revert these changes. Running the command again will also reset the colliders.");
        }

        private static void RenderCollidersInChildren(Transform objectRoot)
        {
            foreach (var collider in objectRoot.GetComponentsInChildren<Collider>())
            {
                RenderCollider(collider);
            }
        }

        private static void RenderCollider(Collider col)
        {
            var colliderType = ColliderType.Collider;
            if (col.attachedRigidbody != null && !col.attachedRigidbody.isKinematic) colliderType = ColliderType.PhysicsCollider;
            if (col.isTrigger) colliderType = ColliderType.Trigger;
            if (col is MeshCollider) colliderType = ColliderType.Mesh;
            var parent = col.transform;
            if (col is SphereCollider sphere)
            {
                var sphereTransform = RenderCollider(parent, GameObject.CreatePrimitive(PrimitiveType.Sphere), Vector3.one * sphere.radius * 2f, sphere.center, colliderType);
                sphereTransform.transform.parent = null;
                sphereTransform.transform.localScale = Vector3.one * sphere.radius * 2f; // spheres are always spherical regardless of parent size!
                sphereTransform.transform.parent = parent;
            }
            if (col is BoxCollider box)
            {
                RenderCollider(parent, GameObject.CreatePrimitive(PrimitiveType.Cube), box.size, box.center, colliderType);
            }
            if (col is CapsuleCollider capsule)
            {
                var capsuleTransform = RenderCollider(parent, GameObject.CreatePrimitive(PrimitiveType.Capsule), new Vector3(capsule.radius * 2f, capsule.height / 2, capsule.radius * 2f), capsule.center, colliderType);
                capsuleTransform.localEulerAngles = AnglesFromCapsuleDirection(capsule.direction);
            }
            if (col is MeshCollider meshCollider)
            {
                var rendererObj = new GameObject("Mesh Collider Object");
                rendererObj.AddComponent<MeshRenderer>();
                var mesh = new Mesh();
                mesh = meshCollider.sharedMesh;
                rendererObj.AddComponent<MeshFilter>().mesh = mesh;
                RenderCollider(parent, rendererObj, Vector3.one, Vector3.zero, colliderType);
            }
        }

        private static Transform RenderCollider(Transform parent, GameObject shape, Vector3 localScale, Vector3 center, ColliderType colliderType)
        {
            Object.DestroyImmediate(shape.GetComponent<Collider>());
            shape.transform.parent = parent;
            shape.transform.localScale = localScale;
            shape.transform.localPosition = center;
            shape.transform.localEulerAngles = Vector3.zero;
            var r = shape.GetComponent<Renderer>();
            r.material = GetMaterialForColliderType(colliderType);
            colliderRendererObjects.Add(shape);
            return shape.transform;
        }

        private static Material GetMaterialForColliderType(ColliderType type)
        {
            switch (type)
            {
                default: return colliderMaterial; ;
                case ColliderType.Trigger: return triggerMaterial;
                case ColliderType.PhysicsCollider: return physicsColliderMaterial;
                case ColliderType.Mesh: return meshColliderMaterial;
            }

        }

        private static Vector3 AnglesFromCapsuleDirection(int capsuleDirection)
        {
            switch (capsuleDirection)
            {
                default: // x
                    return Vector3.forward * 90;
                case 1: // y
                    return Vector3.zero;
                case 2: // z
                    return Vector3.right * 90f;
            }
        }

        private enum ColliderType
        {
            Collider,
            PhysicsCollider,
            Trigger,
            Mesh
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
