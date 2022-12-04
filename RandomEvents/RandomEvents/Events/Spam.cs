using System;
using UnityEngine;

namespace RandomEvents.Events
{
    class Spam : RandomEventBase
    {
        float timeStart;

        public override float GetDestroyTime => 2f;

        public override string GetEventStartMessage => "Your PDA is malfunctioning!";

        public override void StartRandomEvent()
        {
            timeStart = Time.time + 1f;
        }
        
        void Update()
        {
            if(Time.time > timeStart)
            {
                ErrorMessage.AddMessage(GetRandomMessage());
            }
        }

        string GetRandomMessage()
        {
            return UnityEngine.Random.Range(0, 1000).ToString() + UnityEngine.Random.Range(0, 1000).ToString() + UnityEngine.Random.Range(0, 1000).ToString() + UnityEngine.Random.Range(0, 1000).ToString() + UnityEngine.Random.Range(0, 1000).ToString() + UnityEngine.Random.Range(0, 1000).ToString() + UnityEngine.Random.Range(0, 1000).ToString() + UnityEngine.Random.Range(0, 1000).ToString();
        }
    }
}
