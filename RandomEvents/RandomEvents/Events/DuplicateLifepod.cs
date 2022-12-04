using UnityEngine;

namespace RandomEvents.Events
{
    class DuplicateLifepod : RandomEventBase
    {
        public override float GetDestroyTime => 1f;

        public override string GetEventStartMessage => "Here's a free lifepod, take it or leave it.";

        const float spawnDistance = 15f;

        public override void StartRandomEvent()
        {
            Utils.PlaySound("event:/env/splash");
            EscapePod main = EscapePod.main;
            if (main != null && main.gameObject != null)
            {
                bool oldContinueModeTemp = global::Utils.continueMode;
                EscapePod oldMain = EscapePod.main;

                global::Utils.continueMode = true;

                GameObject newEscapePod = GameObject.Instantiate(main.gameObject);
                var pos = Player.main.transform.position + (Random.onUnitSphere * spawnDistance);
                newEscapePod.transform.position = pos;
                EscapePod escapePodComponent = newEscapePod.GetComponent<EscapePod>();
                if (escapePodComponent) escapePodComponent.isNewBorn = false;
                Destroy(escapePodComponent);
                var soi = newEscapePod.GetComponent<SceneObjectIdentifier>();
                Destroy(soi);
                newEscapePod.transform.position = pos;

                global::Utils.continueMode = oldContinueModeTemp;
                EscapePod.main = oldMain;
            }
        }
    }
}
