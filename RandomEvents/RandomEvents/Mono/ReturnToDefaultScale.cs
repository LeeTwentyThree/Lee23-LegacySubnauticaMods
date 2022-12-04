using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RandomEvents.Mono
{
    class ReturnToDefaultScale : MonoBehaviour
    {
        float defaultScale;
        public void StartCountdown(float defaultScale, float length)
        {
            this.defaultScale = defaultScale;
            Destroy(this, length);
        }

        void OnDestroy()
        {
            transform.localScale = Vector3.one * defaultScale;
        }
    }
}
