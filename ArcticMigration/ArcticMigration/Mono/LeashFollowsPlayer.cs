using UnityEngine;

namespace ArcticMigration.Mono
{
    internal class LeashFollowsPlayer : MonoBehaviour
    {
        private Creature creature;

        private void Start()
        {
            creature = GetComponent<Creature>();
        }

        private void Update()
        {
            creature.leashPosition = Player.main.transform.position;
        }
    }
}
