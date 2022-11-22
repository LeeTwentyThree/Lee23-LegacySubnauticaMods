using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Socksfor1Subs.Mono.UI
{
    public class MiniHUDController : MonoBehaviour
    {
        public DadSubBehaviour sub;

        public RectTransform canvasTransform;
        public Transform anchorRootTransform;

        public Text statusText;
        public Text solarPanelText;
        public Text healthText;
        public Text powerText;
        public Text stealthText;

        private Transform[] anchors;

        private float _updateAnchorInterval = 0.5f;
        private float _timeUpdateAnchorAgain;
        private bool _moving;
        private float _moveDuration = 0.5f;
        private float _defaultScale = 0.002f;

        private void Start()
        {
            anchors = new Transform[anchorRootTransform.childCount];
            for (int i = 0; i < anchors.Length; i++)
            {
                anchors[i] = anchorRootTransform.GetChild(i);
            }
        }

        private void Update()
        {
            if (sub.LOD.current != LODState.Full)
            {
                return;
            }

            if (!_moving && Time.time > _timeUpdateAnchorAgain)
            {
                _timeUpdateAnchorAgain = Time.time + _updateAnchorInterval;
                var best = GetBestAnchor();
                if (canvasTransform.parent != best)
                {
                    StartCoroutine(MoveTo(best));
                }
            }

            canvasTransform.LookAt(MainCameraControl.main.transform.position);
            canvasTransform.localEulerAngles = new Vector3(0f, canvasTransform.localEulerAngles.y + 180f, 0f);

            if (_moving)
            {
                return;
            }

            statusText.text = string.Format("Status: {0}", sub.CurrentStatusFormatted);
            solarPanelText.text = string.Format("{0}%", sub.SolarPowerPercentFormatted);
            healthText.text = string.Format("{0}%", sub.HealthPercentFormatted);
            powerText.text = string.Format("{0}%", sub.PowerPercentFormatted);
            stealthText.text = string.Format("{0}%", sub.stealthManager.ChargeFormatted);
        }

        private IEnumerator MoveTo(Transform newParent)
        {
            _moving = true;
            float fadeTime = _moveDuration / 2f;
            float fadeStartTime = Time.time;
            Vector3 startingScale = Vector3.one * _defaultScale;
            Vector3 targetScale = new Vector3(0f, _defaultScale, _defaultScale);
            var tScale = 2f / _moveDuration;
            while (Time.time < fadeStartTime + fadeTime)
            {
                canvasTransform.localScale = Vector3.Lerp(startingScale, targetScale, (Time.time - fadeStartTime) * tScale);
                yield return null;
            }
            canvasTransform.localScale = targetScale;

            canvasTransform.SetParent(newParent);
            canvasTransform.localPosition = Vector3.zero;

            startingScale = targetScale;
            fadeStartTime = Time.time;
            targetScale = Vector3.one * _defaultScale;
            while (Time.time < fadeStartTime + fadeTime)
            {
                canvasTransform.localScale = Vector3.Lerp(startingScale, targetScale, (Time.time - fadeStartTime) * tScale);
                yield return null;
            }
            canvasTransform.localScale = targetScale;

            _moving = false;
        }

        private Transform GetBestAnchor()
        {
            var playerPos = Player.main.transform.position;
            float bestDistance = float.MaxValue;
            Transform bestAnchor = anchors[0];
            foreach (var anchor in anchors)
            {
                var dist = Vector3.Distance(anchor.position, playerPos);
                if (dist < bestDistance)
                {
                    bestDistance = dist;
                    bestAnchor = anchor;
                }
            }
            return bestAnchor;
        }
    }
}
