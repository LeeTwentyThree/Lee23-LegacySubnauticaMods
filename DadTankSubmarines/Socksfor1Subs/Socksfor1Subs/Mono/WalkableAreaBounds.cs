using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class ShipWalkableAreaBounds : MonoBehaviour
    {
        public SubRoot ship;
        private float _timeCheckAgain;
        private float _checkInterval = 1.2f;
        private float _maxDistance = 60f;

        private void Update()
        {
            if (Time.time > _timeCheckAgain)
            {
                if (Player.main.GetCurrentSub() == ship)
                {
                    var distance = Vector3.Distance(Player.main.transform.position, transform.position);
                    if (distance > _maxDistance)
                    {
                        Player.main.SetCurrentSub(null);
                    }
                }
                _timeCheckAgain = Time.time + _checkInterval;
            }
        }
    }
}
