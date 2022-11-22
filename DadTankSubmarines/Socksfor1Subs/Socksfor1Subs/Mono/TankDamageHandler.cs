using UnityEngine;
using UWE;

namespace Socksfor1Subs.Mono
{
    public class TankDamageHandler : MonoBehaviour, IOnTakeDamage
    {
        public Tank tank;

        private FMODAsset damageSound = Helpers.GetFmodAsset("event:/sub/seamoth/impact_solid_hard");

        private void Update()
        {
            DoVoiceLines();
            ManageInvincibility();
        }

        private void DoVoiceLines()
        {
            if (Player.main.currentMountedVehicle != tank)
            {
                return;
            }
            if (tank.HealthPercent < 0.25f)
            {
                tank.voice.PlayVoiceLine("TankHullIntegrityCritical");
            }
        }

        private void ManageInvincibility()
        {
            tank.liveMixin.invincible = tank.docked;
        }

        public void OnTakeDamage(DamageInfo damageInfo)
        {
            if (Player.main.currentMountedVehicle == tank)
            {
                if (damageInfo.damage >= 80f)
                {
                    if (tank.liveMixin != null && tank.liveMixin.health > 0f)
                    {
                        if (damageInfo.dealer != null && damageInfo.dealer.GetComponent<ExplosiveTorpedo>() != null)
                        {
                            tank.voice.PlayVoiceLine("TankUserError");
                        }
                        else
                        {
                            tank.voice.PlayVoiceLine("TankHullDamage");
                        }
                    }
                    else
                    {
                        tank.voice.PlayVoiceLine("TankHullIntegrityCritical");
                    }
                }
                if (damageInfo.damage >= 25f)
                {
                    Utils.PlayFMODAsset(damageSound, Player.main.transform.position);
                }
            }
        }
    }
}
