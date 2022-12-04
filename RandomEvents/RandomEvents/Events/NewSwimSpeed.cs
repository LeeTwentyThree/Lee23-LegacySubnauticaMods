using UnityEngine;

namespace RandomEvents.Events
{
    class NewSwimSpeed : RandomEventBase
    {
        public override float GetDestroyTime => 30f;

        public override string GetEventStartMessage => "Your fear of the ocean is making you swim faster!";

        private bool active;

        private float speed;

        public override void StartRandomEvent()
        {
            speed = Random.Range(1.5f, 2f);
            active = true;
        }

        void Update()
        {
            if (active)
            {
                SetSwimSpeed(speed);
            }
        }

        void SetSwimSpeed(float speed)
        {
            float max = 5f * speed;
            float acceleration = 20f * speed;
            Player.main.playerController.underWaterController.forwardMaxSpeed = max;
            Player.main.playerController.underWaterController.backwardMaxSpeed = max;
            Player.main.playerController.underWaterController.strafeMaxSpeed = max;
            Player.main.playerController.underWaterController.verticalMaxSpeed = max;
            Player.main.playerController.underWaterController.acceleration = acceleration;
        }

        void OnDestroy()
        {
            SetSwimSpeed(1f);
        }
    }
}
