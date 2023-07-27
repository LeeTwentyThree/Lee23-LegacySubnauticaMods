using SMLHelper.V2.Assets;
using System.Security.Cryptography;
using UnityEngine;

namespace SpawnablePlayerModels
{
    internal class SpawnablePlayerModel : Spawnable
    {
        public SpawnablePlayerModel() : base("PlayerModel", "Player", "The one who plays.")
        {
        }

        private static System.Type[] _allowedComponentsOnPlayer = new System.Type[]
        {
            typeof(Transform),
            typeof(Renderer),
            typeof(SkinnedMeshRenderer),
            typeof(MeshRenderer),
            typeof(Animator),
            typeof(Rigidbody),
            typeof(SkyApplier)
        };

        public override GameObject GetGameObject()
        {
            var player = Player.main.gameObject;
            player.SetActive(false);
            var mdl = Object.Instantiate(player);
            player.SetActive(true);

            for (int i = 0; i < 10; i++)
            {
                StripComponents(mdl);
            }

            mdl.EnsureComponent<PrefabIdentifier>().ClassId = ClassID;
            mdl.EnsureComponent<TechTag>().type = TechType;
            mdl.EnsureComponent<LargeWorldEntity>().cellLevel = LargeWorldEntity.CellLevel.VeryFar;
            mdl.EnsureComponent<Rigidbody>().isKinematic = true;
            mdl.transform.Find("body").localPosition = new Vector3(0, 1.35f, 0);
            mdl.transform.Find("body/player_view/male_geo/radiationSuit/radiationSuit_head_geo").gameObject.SetActive(true);
            var animator = mdl.GetComponentInChildren<Animator>();
            animator.runtimeAnimatorController = Mod.bundle.LoadAsset<RuntimeAnimatorController>("PlayerWaveAnimator");
            mdl.EnsureComponent<PlayAnimationOnPressKey>();

            mdl.SetActive(true);
            return mdl;
        }

        private static void StripComponents(GameObject mdl)
        {
            foreach (Component c in mdl.GetComponentsInChildren<Component>(true))
            {
                bool allowed = false;
                var type = c.GetType();
                foreach (var a in _allowedComponentsOnPlayer)
                {
                    if (type == a)
                        allowed = true;
                }
                if (!allowed)
                    Object.DestroyImmediate(c);
            }
        }
    }
}
