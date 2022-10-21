using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class DadNoPowerNotification : MonoBehaviour
    {
        private DadSubBehaviour _sub;
        private float _timeCheckAgain;
        private float _checkInterval = 2f;

        private void Start()
        {
            _sub = GetComponent<DadSubBehaviour>();
        }

        private void Update()
        {
            if (Time.time < _timeCheckAgain)
            {
                return;
            }
            if (Player.main.GetCurrentSub() != _sub)
            {
                return;
            }
            if (_sub.powerRelay == null || !_sub.powerRelay.IsPowered())
            {
                _sub.voice.PlayVoiceLine("DadEmergencyPower");
            }
            _timeCheckAgain = Time.time + _checkInterval;
        }
    }
}
