using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class DadSubPhysics : MonoBehaviour
    {
        public DadSubBehaviour sub;

        private Rigidbody _rb;
        private VFXConstructing _constructing;

        private void Start()
        {
            _constructing = gameObject.GetComponent<VFXConstructing>();
            _rb = gameObject.GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _rb.isKinematic = DetermineKinematic();
        }

        private bool DetermineKinematic()
        {
            if (!_constructing.IsConstructed())
            {
                return true;
            }
            if (sub.Depth <= 0f)
            {
                return false;
            }
            if (Vector3.Distance(Player.main.transform.position, _rb.position) > 100f)
            {
                return true;
            }
            return false;
        }
    }
}
