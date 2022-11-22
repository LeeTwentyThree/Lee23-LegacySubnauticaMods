using UnityEngine;

namespace MirrorWorld
{
    public class EscapePodFixer : MonoBehaviour
    {
        private const float kMinDistanceToBringPlayer = 100f;

        private void FixedUpdate()
        {
            if (!Mod.config.moveEscapePod)
            {
                return;
            }
            var oldPos = transform.position;
            transform.position = new Vector3(transform.position.x, FlipLogic.GetTerrainY(), transform.position.z);
            var rb = GetComponent<Rigidbody>();
            if (rb)
            {
                rb.isKinematic = true;
            }
            if (Player.main.currentEscapePod != null && Vector3.Distance(oldPos, transform.position) > kMinDistanceToBringPlayer)
            {
                TeleportPlayerWithEscapePod();
            }
            if (Mod.config.flipEscapePod)
            {
                transform.localEulerAngles = new Vector3(Mod.config.yAxis ? 180f : 0f, 0f, 0f);
            }
            else
            {
                transform.localEulerAngles = Vector3.zero;
            }
        }

        private void TeleportPlayerWithEscapePod()
        {
            var player = Player.main;
            if (player.lastEscapePod)
            {
                player.lastEscapePod.RespawnPlayer();
                return;
            }
            EscapePod.main.RespawnPlayer();
        }
    }
}
