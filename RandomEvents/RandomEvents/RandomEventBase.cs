using UnityEngine;

namespace RandomEvents
{
    abstract class RandomEventBase : MonoBehaviour
    {
        public abstract void StartRandomEvent();
        public abstract float GetDestroyTime { get; }
        public abstract string GetEventStartMessage { get; }

        public virtual void Start()
        {
            if(!string.IsNullOrEmpty(GetEventStartMessage))
                ErrorMessage.AddMessage(GetEventStartMessage);
            if (GetDestroyTime >= 0f) Destroy(gameObject, GetDestroyTime);
            StartRandomEvent();
        }
    }
}
