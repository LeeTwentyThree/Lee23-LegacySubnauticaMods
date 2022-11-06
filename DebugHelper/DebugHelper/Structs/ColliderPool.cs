using System.Collections.Generic;
using UnityEngine;

namespace DebugHelper.Structs
{
    public class ColliderPool
    {
        /// <exception>
        /// Do not modify it!
        /// </exception>
        public HashSet<BaseDebugCollider> list = new HashSet<BaseDebugCollider>();

        public BaseDebugCollider Register(Collider collider)
        {
            BaseDebugCollider pc = null;
            switch (collider.GetType().Name)
            {
                case nameof(BoxCollider):
                    pc = new DebugBoxCollider((BoxCollider)collider);
                    break;
                case nameof(SphereCollider):
                    pc = new DebugSphereCollider((SphereCollider)collider);
                    break;
                case nameof(CapsuleCollider):
                    pc = new DebugCapsuleCollider((CapsuleCollider)collider);
                    break;
                case nameof(MeshCollider):
                    pc = new DebugMeshCollider((MeshCollider)collider);
                    break;
                default:
                    Debug.Log(collider.GetType().Name + " is not supported!");
                    return null;
            }
            list.Add(pc);
            return pc;
        }
        public void Unregister(BaseDebugCollider collider)
        {
            if (!list.Contains(collider)) return;
            collider.DestroyVisual();
            list.Remove(collider);
        }
        public int Clear()
        {
            int destroyed = 0;
            foreach (var obj in list)
            {
                obj.DestroyVisual();
            }
            list.Clear();
            return destroyed;
        }

        public void Unregister(Collider collider) => list.RemoveWhere(x => x.Get().GetInstanceID() == collider.GetInstanceID());
    }
}
