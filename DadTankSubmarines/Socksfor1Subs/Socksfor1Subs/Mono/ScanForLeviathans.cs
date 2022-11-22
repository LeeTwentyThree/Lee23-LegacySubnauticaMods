using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class ScanForLeviathans : MonoBehaviour
    {
        public DadSubBehaviour sub;

        private float _scanInterval = 3f;
        private float _dangerDuration = 10f;
        private float _dangerRange = 180f;

        private float _timeScanAgain;
        private float _timeDangerTimeout;

        private void Update()
        {
            if (Time.time > _timeScanAgain)
            {
                Scan();
            }
            sub.pilotHUD.leviathanWarning.show = EnvironmentIsDangerous();
        }

        private void Scan()
        {
            _timeScanAgain = Time.time + _scanInterval;
            var ghostSpawner = VoidGhostLeviathansSpawner.main;
            if (ghostSpawner != null && ghostSpawner.spawnedCreatures != null && ghostSpawner.spawnedCreatures.Count > 0)
            {
                Report();
                return;
            }
            var target = EcoRegionManager.main.FindNearestTarget(EcoTargetType.Leviathan, transform.position, null, 6);
            if ((Object)target == null || target.GetGameObject() == null)
            {
                return;
            }
            var distance = Vector3.Distance(target.GetPosition(), transform.position);
            if (distance < _dangerRange)
            {
                Report();
            }
        }

        private void Report()
        {
            var wasDangerous = EnvironmentIsDangerous();
            _timeDangerTimeout = Time.time + _dangerDuration;
            if (!wasDangerous)
            {
                if (Player.main.GetCurrentSub() == sub)
                {
                    sub.voice.PlayVoiceLine("DadHostileLifeform");
                }
            }
        }

        public bool EnvironmentIsDangerous()
        {
            return Time.time < _timeDangerTimeout;
        }
    }
}
