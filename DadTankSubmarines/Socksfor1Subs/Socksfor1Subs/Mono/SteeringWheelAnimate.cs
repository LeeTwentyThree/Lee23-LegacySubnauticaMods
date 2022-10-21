using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class SteeringWheelAnimate : MonoBehaviour
    {
        public SubControl subControl;
        public Transform animatedTransform;
        public float degreesPerSecond = 10f;

        private Quaternion[] _rotations;

        private Direction _currentDirection = Direction.Default;

        private void Start()
        {
            _rotations = new Quaternion[]
            {
                Quaternion.Euler(new Vector3(1, 0, 0)), // Default
                Quaternion.Euler(new Vector3(1, -4, 0)), // Left
                Quaternion.Euler(new Vector3(1, 4, 0)), // Right
                Quaternion.Euler(new Vector3(1.5f, 0, 0)), // Forward
                Quaternion.Euler(new Vector3(0.5f, 0, 0)), // Back
                Quaternion.Euler(new Vector3(0.5f, 0, 0)), // Down
                Quaternion.Euler(new Vector3(1.5f, 0, 0)) // Up
            };
        }

        private void Update()
        {
            var targetDir = UpdateTargetRotation();
            animatedTransform.localRotation = Quaternion.RotateTowards(animatedTransform.localRotation, targetDir, Time.deltaTime * degreesPerSecond);
        }

        private Quaternion UpdateTargetRotation()
        {
            if (subControl.controlMode != SubControl.Mode.DirectInput || !subControl.canAccel || subControl.throttle == Vector3.zero)
            {
                return GetLocalRotForDir(Direction.Default);
            }
            return GetLocalRotForDir(DetermineCurrentDirection(subControl.throttle));

        }

        private Direction DetermineCurrentDirection(Vector3 throttle)
        {
            if (throttle.x < -0.0001f)
            {
                return Direction.Left;
            }
            if (throttle.x > 0.0001f)
            {
                return Direction.Right;
            }
            if (throttle.z < -0.0001f)
            {
                return Direction.Back;
            }
            if (throttle.z > 0.0001f)
            {
                return Direction.Forward;
            }
            if (throttle.y < -0.0001f)
            {
                return Direction.Down;
            }
            if (throttle.y > 0.0001f)
            {
                return Direction.Up;
            }
            return Direction.Default;
        }

        private Quaternion GetLocalRotForDir(Direction direction)
        {
            return _rotations[(int)direction];
        }

        private enum Direction
        {
            Default,
            Left,
            Right,
            Forward,
            Back,
            Down,
            Up
        }
    }
}
