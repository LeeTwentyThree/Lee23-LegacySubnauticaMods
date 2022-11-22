using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class TankPhysics : MonoBehaviour
    {
        public Tank tank;

        private Rigidbody _rb;
        private VFXConstructing _constructing;

        private int _noConstraint = 0;
        private int _defaultConstraint = 112;
        private float _maxRotationAllowed = 5f;
        private bool _wasUnconstrainted;

        private void Start()
        {
            _constructing = gameObject.GetComponent<VFXConstructing>();
            _rb = gameObject.GetComponent<Rigidbody>();
        }

        private void Update()
        {
            _rb.isKinematic = DetermineKinematic();
            _rb.constraints = (RigidbodyConstraints)DetermineConstraints();
        }

        private bool DetermineKinematic()
        {
            if (!_constructing.IsConstructed())
            {
                return true;
            }
            if (tank.docked)
            {
                return true;
            }
            if (transform.localPosition.y > Ocean.main.GetOceanLevel())
            {
                return false;
            }
            if (Vector3.Distance(Player.main.transform.position, _rb.position) > 36f)
            {
                return true;
            }
            return false;
        }

        private int DetermineConstraints()
        {
            var localEulers = tank.transform.localEulerAngles;
            if (Mathf.Abs(localEulers.x) > _maxRotationAllowed || Mathf.Abs(localEulers.z) > _maxRotationAllowed)
            {
                _wasUnconstrainted = true;
                return _noConstraint;
            }
            if (_wasUnconstrainted)
            {
                tank.transform.localEulerAngles = new Vector3(0f, localEulers.y, 0f);
                _wasUnconstrainted = false;
            }
            return _defaultConstraint;
        }
    }
}
