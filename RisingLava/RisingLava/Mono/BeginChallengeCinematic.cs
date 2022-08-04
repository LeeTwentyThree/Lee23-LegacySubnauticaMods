using UnityEngine;
using System.Collections;

namespace RisingLava.Mono
{
    public class BeginChallengeCinematic : MonoBehaviour
    {
        public static void BeginCinematic()
        {
            var cinematic = new GameObject("BeginChallengeCinematic").AddComponent<BeginChallengeCinematic>();
        }

        private IEnumerator Start()
        {
            instance = this;
            yield return new WaitForSeconds(2f);
            Utils.PlayFMODAsset(sound, Player.main.transform.position);
            ScreenShake();
            yield return new WaitForSeconds(4f);
            DisplayText();
            Destroy(gameObject);
            instance = null;
        }

        private void ScreenShake()
        {
            MainCameraControl.main.ShakeCamera(3f, 7f, MainCameraControl.ShakeMode.Quadratic, 0.8f);
        }

        private void DisplayText()
        {
            ErrorMessage.AddMessage("<color=red>The crater is erupting!</color>");
        }

        public static bool CinematicActive()
        {
            return instance != null;
        }

        private static FMODAsset sound = Helpers.GetFMODAsset("event:/env/geyser_erupt");

        private static BeginChallengeCinematic instance;
    }
}
