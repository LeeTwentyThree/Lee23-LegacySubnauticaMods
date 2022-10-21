using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public class CameraManager : MonoBehaviour
    {
        public DadSubBehaviour sub;
        public Transform sittingPosition;
        public Transform mainViewParent;
        public DadSubCamera topCamera;
        public DadSubCamera bottomCamera;

        public DadSubCamera activeCamera;

        private bool _wasPiloting;
        private bool _isPiloting;

        public bool InCameras
        {
            get
            {
                return activeCamera != null;
            }
        }

        public GameObject PlayerViewGameObject
        {
            get
            {
                return Player.main.transform.Find("body/player_view").gameObject;
            }
        }

        private void Update()
        {
            _isPiloting = DeterminePiloting();
            if (!_isPiloting && InCameras)
            {
                ExitCameras();
            }
            if (!InCameras)
            {
                sittingPosition.parent = mainViewParent;
                sittingPosition.localPosition = Vector3.zero;
                sittingPosition.localEulerAngles = Vector3.zero;
            }
            _wasPiloting = _isPiloting;
            PlayerViewGameObject.SetActive(!InCameras);
        }

        private void LateUpdate()
        {
            if (InCameras)
            {
                MainCameraControl.main.ResetCamera();
            }
        }

        public void ExitCameras()
        {
            activeCamera = null;
            SetSittingPositionParent(mainViewParent);
            sittingPosition.localPosition = Vector3.zero;
            sittingPosition.localEulerAngles = Vector3.zero;
            PlayerViewGameObject.SetActive(true);
        }

        public void SetSittingPositionParent(Transform parent)
        {
            if (parent == null)
            {
                return;
            }
            sittingPosition.transform.parent = parent;
            sittingPosition.transform.localPosition = Vector3.zero;
        }

        private bool DeterminePiloting()
        {
            var chair = Player.main.GetPilotingChair();
            if (chair == null)
            {
                return false;
            }
            if (chair.subRoot == sub)
            {
                return true;
            }
            return false;
        }

        private void OnDestroy()
        {
            PlayerViewGameObject.SetActive(true);
        }
    }
}
