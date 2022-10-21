using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class TankAim : MonoBehaviour
    {
        public Tank tank;

        public Transform vehicleRoot;
        public Transform barrelPivotDummy;
        public Transform barrelRoot;
        public Transform barrelPivot;
        public float upperXRotLimit;
        public float lowerXRotLimit;
        public float aimDegreesPerSecond = 100f;
        public float aimDegreesPerSecondWhileLocked = 20f;
        public FMOD_CustomLoopingEmitter rotateEmitter;

        private Vector3 _aimDirection;

        void Start()
        {
            _aimDirection = vehicleRoot.forward;
        }

        void Update()
        {
            UpdateAimDirection();
            UpdateDummyLocation();
            UpdateBarrelLocation();
            UpdateRotateSound();
        }

        private bool ResettingPosition
        {
            get
            {
                if (tank == null || !tank.IsPowered())
                {
                    return true;
                }
                if (Player.main.GetVehicle() == tank)
                {
                    return false;
                }
                return true;
            }
        }

        private bool Locked
        {
            get
            {
                if (tank.weapons.ShootingTorpedo)
                {
                    return true;
                }
                return false;
            }
        }

        private float AimDegreesPerSecond
        {
            get
            {
                if (ResettingPosition)
                {
                    return aimDegreesPerSecondWhileLocked;
                }
                return aimDegreesPerSecond;
            }
        }

        private void UpdateAimDirection()
        {
            if (tank.weapons.HarpoonDeployed)
            {
                _aimDirection = (tank.weapons.CurrentHarpoon.transform.position - barrelPivot.transform.position).normalized;
            }
            else if (ResettingPosition)
            {
                _aimDirection = vehicleRoot.forward;
            }
            else
            {
                _aimDirection = MainCameraControl.main.transform.forward;
            }
        }

        private void UpdateDummyLocation()
        {
            var rot = Quaternion.LookRotation(_aimDirection, vehicleRoot.up);
            barrelPivotDummy.rotation = rot;
            var localEuler = barrelPivotDummy.localEulerAngles;
            if (localEuler.x > 180f)
            {
                barrelPivotDummy.localEulerAngles = new Vector3(Mathf.Max(localEuler.x, upperXRotLimit), localEuler.y, 0f);
            }
            else
            {
                barrelPivotDummy.localEulerAngles = new Vector3(Mathf.Min(localEuler.x, lowerXRotLimit), localEuler.y, 0f);
            }
        }

        private void UpdateBarrelLocation()
        {
            if (!Locked)
            {
                barrelPivot.localRotation = Quaternion.RotateTowards(barrelPivot.localRotation, barrelPivotDummy.localRotation, Time.deltaTime * AimDegreesPerSecond);
            }
        }

        public void SetAimDirection(Vector3 aimDirection)
        {
            _aimDirection = aimDirection;
        }

        private void UpdateRotateSound()
        {
            var angleDifference = Quaternion.Angle(barrelPivotDummy.rotation, barrelPivot.rotation);
            bool shouldPlay = angleDifference > 1f;
            if (shouldPlay)
            {
                rotateEmitter.Play();
            }
            else
            {
                rotateEmitter.Stop();
            }
        }
    }

}
