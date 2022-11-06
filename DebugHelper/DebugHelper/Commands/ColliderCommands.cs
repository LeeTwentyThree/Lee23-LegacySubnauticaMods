using UnityEngine;
using SMLHelper.V2.Commands;
using System.Collections;
using System.Collections.Generic;
using UWE;
using DebugHelper.Structs;
using System;

namespace DebugHelper.Commands
{
    public static class ColliderCommands
    {
        private static Material colliderMaterial; // generic colliders
        private static Material physicsColliderMaterial; // colliders on non-kinematic rigidbodies
        private static Material triggerMaterial; // colliders with isTrigger set to true
        private static Material meshColliderMaterial; // anything with the MeshCollider component

        static ColliderPool pool = new ColliderPool();

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
        public static void ShowCollidersInRange(float maxRange, bool hideMessages = false)
        {
            CoroutineHost.StartCoroutine(ShowCollidersInRangeCoroutine(maxRange, hideMessages));
        }

        [ConsoleCommand("hidecolliders")]
        public static void HideColliders(bool hideMessages = false)
        {
            if (!hideMessages) ErrorMessage.AddMessage($"Destroyed all {pool.Clear()} collider renderers.");
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

        private static IEnumerator ShowCollidersInRangeCoroutine(float maxRange, bool hideMessages = false)
        {
            if (colliderMaterial == null)
            {
                yield return CoroutineHost.StartCoroutine(LoadStasisFieldMaterial());
            }

            HideColliders(hideMessages);

            var center = SNCameraRoot.main.transform.position;
            var allColliders = Physics.OverlapSphere(center, maxRange); // all colliders in range
            var playerRb = Player.main.rigidBody;
            int counter = 0;
            foreach (var collider in allColliders)
            {
                //if (collider is MeshCollider) continue;
                if (collider.GetComponent<Player>() != null) continue;
                pool.Register(collider);
                counter++;
            }
            if (!hideMessages) ErrorMessage.AddMessage($"Showing all {counter} colliders within {(int)maxRange} meters.");
            foreach (var collider in pool.list)
            {
                RenderCollider(collider);
            }
            if (!hideMessages) ErrorMessage.AddMessage("Use the 'hidecolliders' command to revert these changes. Running the command again will also reset the colliders.");
        }

        private static void RenderCollidersInChildren(Transform objectRoot)
        {
            foreach (var collider in objectRoot.GetComponentsInChildren<Collider>())
            {
                BaseDebugCollider c = pool.Register(collider);
                RenderCollider(c);
            }
        }

        private static void RenderCollider(BaseDebugCollider collider)
        {
            //if (collider.shape == ColliderShape.Mesh) return;

            Material material = GetMaterialForCollider(collider);

            collider.CreateVisual();
            collider.SetMaterial(material);

            return;
        }

        private static Material GetMaterialForCollider(BaseDebugCollider collider)
        {
            if (collider.isTrigger) return triggerMaterial;
            if (collider.type == ColliderType.Rigidbody) return physicsColliderMaterial;
            if (collider.shape == ColliderShape.Mesh) return meshColliderMaterial;
            return colliderMaterial;
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
