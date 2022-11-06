using System;
using UnityEngine;

namespace DebugHelper.Structs
{
    public enum ColliderType
    {
        Static,
        Rigidbody,
        KinematicRigidbody
    }
    public enum ColliderShape
    {
        Box,
        Sphere,
        Capsule,
        Mesh
    }
    public abstract class BaseDebugCollider
    {
        // References:
        // https://docs.unity3d.com/560/Documentation/Manual/CollidersOverview.html

        #region Fields
        private Collider m_collider;
        private ColliderType m_type;
        private ColliderShape m_shape;
        protected GameObject m_visualObject;
        protected Renderer m_renderer;
        #endregion
        #region Getters
        #region Properties
        public bool wasDrawn
        {
            get
            {
                if (m_visualObject == null) return false;
                return true;
            }
        }
        /// <summary>
        /// Returns one of these collider type: Static, Rigidbody, KinematicRigidbody
        /// </summary>
        public ColliderType type { get => GetColliderType(); }
        /// <summary>
        /// Returns one of these shape type: Box, Sphere, Capsule, Mesh
        /// </summary>
        public ColliderShape shape { get => GetColliderShape(); }
        public bool isTrigger { get => IsTrigger(); }
        #endregion
        #region Methods
        /// <summary>
        /// Returns collider
        /// </summary>
        public Collider Get() => m_collider;
        /// <summary>
        /// Returns one of these collider type: Static, Rigidbody, KinematicRigidbody
        /// </summary>
        public ColliderType GetColliderType()
        {
            bool flag1 = m_collider.attachedRigidbody != null; // Has rigidbody attached
            if (flag1)
            {
                bool flag3 = m_collider.attachedRigidbody.isKinematic; // Is kinematic
                switch (flag3)
                {
                    case true: return ColliderType.KinematicRigidbody;
                    case false: return ColliderType.Rigidbody;
                }
            }
            return ColliderType.Static;
        }
        /// <summary>
        /// Returns one of these shape type: Box, Sphere, Capsule, Mesh
        /// </summary>
        public ColliderShape GetColliderShape()
        {
            switch (m_collider.GetType().Name)
            {
                case nameof(BoxCollider):
                    return ColliderShape.Box;
                case nameof(SphereCollider):
                    return ColliderShape.Sphere;
                case nameof(CapsuleCollider):
                    return ColliderShape.Capsule;
            }
            return ColliderShape.Mesh;
        }
        public bool IsTrigger() => m_collider.isTrigger;
        #endregion
        #endregion
        #region Visual
        public void SetColor(Color color)
        {
            if (!wasDrawn) return;
            m_renderer.material.color = color;
        }
        public void SetMaterial(Material material)
        {
            if (!wasDrawn) return;
            m_renderer.material = material;
        }
        public virtual void CreateVisual()
        {
            if (wasDrawn) return;
            PrimitiveType pt = PrimitiveType.Cube;
            switch (shape)
            {
                case ColliderShape.Box: 
                    break;
                case ColliderShape.Sphere: 
                    pt = PrimitiveType.Sphere;
                    break;
                case ColliderShape.Capsule:
                    pt = PrimitiveType.Capsule;
                    break;
                default: throw new ArgumentException();
            }
            m_visualObject = GameObject.CreatePrimitive(pt);
            m_renderer = m_visualObject.GetComponent<Renderer>();
            UnityEngine.Object.DestroyImmediate(m_visualObject.GetComponent<Collider>());
            m_visualObject.SetActive(true);
            Transform transform = m_visualObject.transform;
            transform.SetParent(m_collider.transform);
            transform.localEulerAngles = Vector3.zero;
        }
        public void DestroyVisual()
        {
            if (!wasDrawn) return;
            UnityEngine.GameObject.DestroyImmediate(m_visualObject);
        }
        #endregion
        BaseDebugCollider() { }
        internal BaseDebugCollider(Collider collider) => this.m_collider = collider;
    }
    public abstract class BaseDebugCollider<T> : BaseDebugCollider where T : Collider
    {
        /// <summary>
        /// Returns collider
        /// </summary>
        public T Get() => (T)base.Get();

        public BaseDebugCollider(T collider) : base(collider) { }
    }
    public sealed class DebugBoxCollider : BaseDebugCollider<BoxCollider>
    {
        public Vector3 center { get => this.GetCenter(); }
        public Vector3 size { get => this.GetSize(); }

        public Vector3 GetCenter() => base.Get().center;
        public Vector3 GetSize() => base.Get().size;

        public override void CreateVisual()
        {
            base.CreateVisual();
            m_visualObject.transform.localPosition = center;
            m_visualObject.transform.localScale = size;
        }

        internal DebugBoxCollider(BoxCollider collider) : base(collider) { }
    }
    public sealed class DebugSphereCollider : BaseDebugCollider<SphereCollider>
    {
        public Vector3 center { get => this.GetCenter(); }
        public float radius { get => this.GetRadius(); }

        public Vector3 GetCenter() => base.Get().center;
        public float GetRadius() => base.Get().radius;

        public override void CreateVisual()
        {
            base.CreateVisual();
            m_visualObject.transform.localPosition = center;
            m_visualObject.transform.localScale = Vector3.one * GetRadius() * 2f;
        }

        internal DebugSphereCollider(SphereCollider collider) : base(collider) { }
    }
    public sealed class DebugCapsuleCollider : BaseDebugCollider<CapsuleCollider>
    {
        public Vector3 center { get => this.GetCenter(); }
        public float radius { get => this.GetRadius(); }
        public float height { get => this.GetHeight(); }
        public int direction { get => this.GetDirection(); }

        public Vector3 GetCenter() => base.Get().center;
        public float GetRadius() => base.Get().radius;
        public float GetHeight() => base.Get().height;
        public int GetDirection() => base.Get().direction;

        public override void CreateVisual()
        {
            base.CreateVisual();
            Transform transform = m_visualObject.transform;
            Vector3 angle = 90 * (direction != 1 ? (direction == 0 ? Vector3.forward : Vector3.right) : Vector3.zero);
            transform.localPosition = center;
            transform.localEulerAngles = angle;
            transform.localScale = new Vector3(radius * 2f, height / 2, radius * 2f);
        }

        internal DebugCapsuleCollider(CapsuleCollider collider) : base(collider) { }
    }
    public sealed class DebugMeshCollider : BaseDebugCollider<MeshCollider>
    {
        private MeshFilter m_filter;
        public Mesh mesh { get => this.GetMesh(); }
        public bool convex { get => this.IsConvex(); }

        public Mesh GetMesh() => base.Get().sharedMesh;
        public bool IsConvex() => base.Get().convex;

        public override void CreateVisual()
        {
            if (wasDrawn) return;

            m_visualObject = new GameObject("DebugMeshCollider");
            m_renderer = m_visualObject.AddComponent<MeshRenderer>();
            m_filter = m_visualObject.AddComponent<MeshFilter>();
            m_filter.mesh = Get().sharedMesh;
            m_visualObject.SetActive(true);

            Transform transform = m_visualObject.transform;
            transform.SetParent(Get().transform);
            transform.localPosition = Vector3.zero;
            transform.localEulerAngles = Vector3.zero;
            transform.localScale = Vector3.one;
        }

        internal DebugMeshCollider(MeshCollider collider) : base(collider) { }
    }
}
