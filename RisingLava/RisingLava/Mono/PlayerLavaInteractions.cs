using UnityEngine;

namespace RisingLava.Mono
{
    public class PlayerLavaInteractions : MonoBehaviour
    {
        private Player _player;
        private float _timeLastDamage;
        private float _damageDelay = 2f;
        private float _damageAmount = 20f;
        private float _damageYOffset = 0.5f;

        private float _sizzleRange = 10f;
        private float _timeLastSizzle;
        private float _sizzleDelay = 1.5f;
        private float _sizzleDamageAmount = 0.25f;

        private void Start()
        {
            _player = GetComponent<Player>();
        }

        private bool PlayerIsUnderWater()
        {
            return _player.transform.position.y < Ocean.main.GetOceanLevel();
        }

        private void Update()
        {
            var playerY = Player.main.transform.position.y;
            var lavaLevel = Main.LavaLevel;
            bool playerInLava = playerY < lavaLevel + _damageYOffset;
            if (playerInLava)
            {
                InsideLavaDamageTick();
            }
            if (playerY < lavaLevel + _sizzleRange)
            {
                SizzleDamageTick();
            }
        }

        private void InsideLavaDamageTick()
        {
            if (Time.time > _timeLastDamage + _damageDelay)
            {
                _timeLastDamage = Time.time;
                var instakill = false;
                if (!PlayerIsUnderWater())
                {
                    var playerY = Player.main.transform.position.y;
                    if (playerY < Ocean.main.GetOceanLevel() + 2f)
                    {
                        instakill = true;
                    }
                    else if (playerY < Main.LavaLevel + 5f)
                    {
                        instakill = true;
                    }
                }
                if (instakill)
                {
                    if (GameModeUtils.IsInvisible() || NoDamageConsoleCommand.main.GetNoDamageCheat())
                    {
                        return;
                    }
                    _player.liveMixin.Kill();
                }
                else
                {
                    _player.liveMixin.TakeDamage(_damageAmount, _player.transform.position, DamageType.Normal);
                    _player.liveMixin.TakeDamage(0.1f, _player.transform.position, DamageType.Heat);
                }
            }
        }

        private void SizzleDamageTick()
        {
            if (Time.time > _timeLastSizzle + _sizzleDelay)
            {
                _timeLastSizzle = Time.time;
                _player.liveMixin.TakeDamage(_sizzleDamageAmount, _player.transform.position, DamageType.Heat);
            }
        }
    }
}
