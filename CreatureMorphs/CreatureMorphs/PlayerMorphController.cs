using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UWE;
using System.Collections;
using SMLHelper.V2.Commands;

namespace CreatureMorphs
{
    internal class PlayerMorphController : MonoBehaviour
    {
        public static PlayerMorphController main;

        private Player _player;
        private bool _morphing;
        private MorphController _currentMorph;

        private GameObject _playerModelRoot;
        private GameObject _selectorMenu;
        private GameObject _creatureMenu;

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
            _player.liveMixin.invincible = !enabled;
            if (enabled) _player.FreezeStats();
            else _player.UnfreezeStats();
        }

        public MorphController GetCurrentMorph()
        {
            return _currentMorph;
        }

        private IEnumerator InitiateMorphCoroutine(MorphType morph)
        {
            _morphing = true;
            var r = PrefabDatabase.GetPrefabAsync(morph.MorphClassId);
            yield return r;
            r.TryGetPrefab(out var prefab);
            var spawnedCreature = Instantiate(prefab, Helpers.CameraTransform.position, Helpers.CameraTransform.rotation);
            spawnedCreature.SetActive(true);
            TogglePlayerModel(false);
            _currentMorph = MorphController.ControlCreature(spawnedCreature, morph);
            var morphMode = MorphModeData.GetData(morph.MorphModeType);
            FadingOverlay.PlayFX(Color.black, 0.1f, morphMode.transformationDuration, 1f);
            Utils.PlayFMODAsset(morphMode.soundAsset, Helpers.CameraTransform.position);
            yield return new WaitForSeconds(morphMode.transformationDuration);
            _currentMorph.GainControl();
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

        private void Update()
        {
            if (Input.GetKeyDown(Main.config.OpenMorphMenu))
            {
                if (_currentMorph == null && _selectorMenu == null && _creatureMenu == null)
                {
                    _selectorMenu = Instantiate(Main.bundle.LoadAsset<GameObject>("SelectorMenu-Type"));
                    RadialTabHelper.SetupRadialTab(_selectorMenu,
                        new RadialTabHelper.Selector("Prey", GetEvent(ChoosePrey)),
                        new RadialTabHelper.Selector("Herbivores", GetEvent(ChooseHerbivores)),
                        new RadialTabHelper.Selector("Sharks", GetEvent(ChooseSharks)),
                        new RadialTabHelper.Selector("Leviathans", GetEvent(ChooseLeviathans))
                        );
                }
                else
                {
                    Destroy(_selectorMenu);
                    Destroy(_creatureMenu);
                    BecomeHuman();
                }
            }
        }

        private Button.ButtonClickedEvent GetEvent(UnityAction call)
        {
            var ev = new Button.ButtonClickedEvent();
            ev.AddListener(call);
            return ev;
        }

        private void ChoosePrey()
        {
            Destroy(_selectorMenu);
            _creatureMenu = Instantiate(Main.bundle.LoadAsset<GameObject>("SelectorMenu-Prey"));
            RadialTabHelper.SetupRadialTab(_creatureMenu,
                new RadialTabHelper.Selector("Boomerang", GetEvent(() => ChooseMorph(TechType.Boomerang))),
                new RadialTabHelper.Selector("Peeper", GetEvent(() => ChooseMorph(TechType.Peeper))),
                new RadialTabHelper.Selector("Hoverfish", GetEvent(() => ChooseMorph(TechType.Hoverfish)))
                );
        }

        private void ChooseMorph(TechType techType)
        {
            InitiateMorph(MorphDatabase.GetMorphType(techType));
            Destroy(_creatureMenu);
        }

        private void ChooseHerbivores()
        {
            Destroy(_selectorMenu);
            _selectorMenu = Instantiate(Main.bundle.LoadAsset<GameObject>("SelectorMenu-Prey"));
            _creatureMenu = Instantiate(Main.bundle.LoadAsset<GameObject>("SelectorMenu-Prey"));
            RadialTabHelper.SetupRadialTab(_creatureMenu,
                new RadialTabHelper.Selector("Ghost Ray", GetEvent(() => ChooseMorph(TechType.GhostRayBlue))),
                new RadialTabHelper.Selector("Gasopod", GetEvent(() => ChooseMorph(TechType.Gasopod))),
                new RadialTabHelper.Selector("Rabbit Ray", GetEvent(() => ChooseMorph(TechType.RabbitRay)))
                );
        }

        private void ChooseSharks()
        {
            Destroy(_selectorMenu);
            RadialTabHelper.SetupRadialTab(_creatureMenu,
                new RadialTabHelper.Selector("Stalker", GetEvent(() => ChooseMorph(TechType.Stalker))),
                new RadialTabHelper.Selector("Ampeel", GetEvent(() => ChooseMorph(TechType.Shocker)))
            );
        }

        private void ChooseLeviathans()
        {
            Destroy(_selectorMenu);
            RadialTabHelper.SetupRadialTab(_creatureMenu,
                new RadialTabHelper.Selector("Reaper Leviathan", GetEvent(() => ChooseMorph(TechType.GhostRayBlue))),
                new RadialTabHelper.Selector("Ghost Leviathan", "Ghost\nLeviathan", GetEvent(() => ChooseMorph(TechType.Gasopod))),
                new RadialTabHelper.Selector("Sea Dragon", GetEvent(() => ChooseMorph(TechType.RabbitRay))),
                new RadialTabHelper.Selector("Gargantuan Leviathan", "Gargantuan\nLeviathan", GetEvent(() => ChooseMorph(TechType.RabbitRay)))
            );
        }
    }
}
