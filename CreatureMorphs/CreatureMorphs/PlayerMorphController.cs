using UnityEngine;
using UWE;
using System.Collections;
using SMLHelper.V2.Commands;

namespace CreatureMorphs
{
    internal class PlayerMorphController : MonoBehaviour
    {
        private static PlayerMorphController main;

        private Player _player;
        private bool _morphing;
        private MorphController _currentMorph;

        private GameObject _playerModelRoot;

        public bool CanMorph { get { return !_morphing && _currentMorph == null; } }

        private void Awake()
        {
            main = this;
            _player = GetComponent<Player>();
            _playerModelRoot = _player.gameObject.transform.Find("body/player_view/male_geo").gameObject;
        }

        public void InitiateMorph(MorphType morph)
        {
            if (!CanMorph) return;
            StartCoroutine(InitiateMorphCoroutine(morph));
        }

        public void BecomeHuman()
        {
            if (_currentMorph != null)
            {
                Destroy(_currentMorph.gameObject);
            }
            TogglePlayerModel(true);
        }

        private void TogglePlayerModel(bool enabled)
        {
            foreach (var r in _playerModelRoot.GetComponentsInChildren<Renderer>(true))
            {
                r.enabled = enabled;
            }
        }

        private IEnumerator InitiateMorphCoroutine(MorphType morph)
        {
            _morphing = true;
            var r = PrefabDatabase.GetPrefabAsync(morph.MorphClassId);
            yield return r;
            r.TryGetPrefab(out var prefab);
            var spawnedCreature = Instantiate(prefab, Helpers.CameraTransform.position, Helpers.CameraTransform.rotation);
            spawnedCreature.SetActive(true);
            MorphController.ControlCreature(spawnedCreature, morph);
            TogglePlayerModel(false);
            _morphing = false;
        }

        [ConsoleCommand("morph")]
        public static string MorphCommand(string techTypeName)
        {
            if (!TechTypeExtensions.FromString(techTypeName, out var techType, true)) return $"TechType '{techTypeName}' not found!";
            if (main == null) return "No instance of the PlayerMorphController was found!";
            if (!main.CanMorph) return "Player is unable to morph at this moment!";
            main.InitiateMorph(MorphDatabase.GetMorphType(techType));
            return $"Successfully morphing into '{techType}'";
        }

    }
}
