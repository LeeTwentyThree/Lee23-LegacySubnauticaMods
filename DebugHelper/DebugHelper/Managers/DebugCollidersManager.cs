using DebugHelper.Basis;
using DebugHelper.Pools;
using DebugHelper.Structs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UWE;

namespace DebugHelper.Managers
{
    public class DebugCollidersManager : BaseManager
    {
        public static DebugCollidersManager main;
        public ColliderPool pool { get; private set; }

        private Material m_colliderMaterial; // generic colliders
        private Material m_physicsColliderMaterial; // colliders on non-kinematic rigidbodies
        private Material m_triggerMaterial; // colliders with isTrigger set to true
        private Material m_meshColliderMaterial; // anything with the MeshCollider component

        public bool enabledShowInRange { get; private set; }
        public float targetRange { get; private set; }

        private Transform m_camTransform 
        {
            get => SNCameraRoot.main.transform;
        }
        
        private void OnEnable()
        {
            main = this;
            enabledShowInRange = false;
            targetRange = 10f;
            pool = new ColliderPool();
            CoroutineHost.StartCoroutine(f_setupMaterials());
            StartTicking();
        }
        private void OnDisable()
        {
            CoroutineHost.StartCoroutine(c_hideColliders());
            StopTicking();
        }
        #region API
        public void ShowCollidersRange(float range)
        {
            this.targetRange = Mathf.Clamp(range, 0.01f, 1700f);
            enabledShowInRange = true;
            Tick();
        }
        public void HideColliders() => CoroutineHost.StartCoroutine(c_hideColliders());
        public override void Tick()
        {
            if (enabledShowInRange) CoroutineHost.StartCoroutine(c_drawCollidersRange());
        }
        #endregion
        #region coroutines
        private IEnumerator c_drawCollidersRange()
        {
            List<Collider> casted = m_getCollidersRange(m_camTransform.position, targetRange).ToList();
            var pooled = pool.ToSet();
            foreach (BaseDebugCollider p in pooled)
            {
                Collider c = p.Get();
                switch (casted.Contains(c))
                {
                    case true:
                        casted.Remove(c);
                        continue;
                    case false:
                        pool.Unregister(p);
                        continue;
                }
            }
            foreach (Collider c in casted)
            {
                if (c.GetComponentInParent<Player>() != null) continue;
                BaseDebugCollider nc = pool.Register(c);
                f_renderCollider(nc);
            }
            yield return null;
        }
        private IEnumerator c_hideColliders()
        {
            enabledShowInRange = false;
            pool.Clear();
            yield return null;
        }
        private IEnumerator f_setupMaterials()
        {
            CoroutineTask<GameObject> task = CraftData.GetPrefabForTechTypeAsync(TechType.StasisRifle);
            yield return task;

            GameObject stasisRifle = task.GetResult();
            var stasisBall = stasisRifle.GetComponent<StasisRifle>().effectSpherePrefab.GetComponentInChildren<Renderer>();
            m_colliderMaterial = new Material(stasisBall.materials[1]);
            m_colliderMaterial.color = new Color(0.3f, 1f, 0f);
            m_physicsColliderMaterial = new Material(stasisBall.materials[1]);
            m_physicsColliderMaterial.color = new Color(1f, 0.2f, 0.2f);
            m_triggerMaterial = new Material(stasisBall.materials[1]);
            m_triggerMaterial.color = new Color(0.5f, 0.5f, 0.5f);
            m_meshColliderMaterial = new Material(stasisBall.materials[1]);
            m_meshColliderMaterial.color = new Color(0.2f, 0.2f, 1f);
        }
        #endregion
        #region helpers
        private void f_renderCollider(BaseDebugCollider collider)
        {
            Material m = f_colliderMaterial(collider);
            collider.CreateVisual();
            collider.SetMaterial(m);
        }
        private Collider[] m_getCollidersRange(Vector3 position, float range) => Physics.OverlapSphere(position, range);
        private Collider[] m_getCollidersRay(Ray ray, float range) => throw new NotImplementedException();
        private Material f_colliderMaterial(BaseDebugCollider collider)
        {
            if (collider.IsTrigger) return m_triggerMaterial;
            if (collider.Type == ColliderType.Rigidbody) return m_physicsColliderMaterial;
            if (collider.Shape == ColliderShape.Mesh) return m_meshColliderMaterial;
            return m_colliderMaterial;
        }
        #endregion
    }
}
