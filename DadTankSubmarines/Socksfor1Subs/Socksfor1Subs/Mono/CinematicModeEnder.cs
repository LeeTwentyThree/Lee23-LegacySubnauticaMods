using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class CinematicModeEnder : MonoBehaviour
    {
        public PlayerCinematicController associatedCinematic;
        public float cinematicDuration;
        public GameObject[] cinematicEndListenerObjects;

        private void Update()
        {
            if (associatedCinematic.cinematicModeActive)
            {
                if (Time.time >= associatedCinematic.timeCinematicModeStarted + cinematicDuration)
                {
                    End();
                }
            }
        }

        private void End()
        {
            associatedCinematic.OnPlayerCinematicModeEnd();
            if (cinematicEndListenerObjects != null)
            {
                foreach (var obj in cinematicEndListenerObjects)
                {
                    foreach (var i in obj.GetComponents<ICinematicEndListener>())
                    {
                        i.OnPlayerCinematicModeEnd(associatedCinematic);
                    }
                }
            }
        }
    }

    public interface ICinematicEndListener
    {
        void OnPlayerCinematicModeEnd(PlayerCinematicController playerCinematicController);
    }
}
