using UnityEngine;

namespace RisingLava.Mono
{
    public class FloatInLava : MonoBehaviour
    {
        private Rigidbody _rb;

        private const float kBuoyancyConstant = 1.5f;

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            if (transform.position.y < Main.LavaLevel && _rb != null)
            {
                var upwardForce = _rb.mass * kBuoyancyConstant;
                _rb.AddForce(Vector3.up * upwardForce);
            }
        }
    }
}
