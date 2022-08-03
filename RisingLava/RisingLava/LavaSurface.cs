using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UWE;

namespace RisingLava
{
    public class LavaSurface : MonoBehaviour
    {
        public static LavaSurface main;
        public float gridWidthLength = 2500f;

        private bool _fixedMaterial;
        private bool _runningCoroutine;

        private void Awake()
        {
            main = this;
        }

        public static LavaSurface EnsureLavaSurface()
        {
            if (main != null)
            {
                return main;
            }
            var spawned = Instantiate(Main.assetBundle.LoadAsset<GameObject>("LavaPlane_Prefab"));
            main = spawned.AddComponent<LavaSurface>();
            main.gameObject.EnsureComponent<LavaLightManager>();
            return main;
        }

        private void Update()
        {
            var mainCam = MainCamera.camera.transform.position;
            var posXZ = new Vector2(mainCam.x, mainCam.z);
            posXZ = new Vector2(Mathf.Round(posXZ.x / gridWidthLength) * gridWidthLength, Mathf.Round(posXZ.y / gridWidthLength) * gridWidthLength);
            transform.position = new Vector3(posXZ.x, Main.LavaLevel, posXZ.y) + GetLavaModelOffset();

            if (!_fixedMaterial && !_runningCoroutine)
            {
                UseLavaFallMaterial();
            }
        }

        public void UseTerrainMaterial(int index)
        {
            var largeWorld = LargeWorld.main;
            if (!largeWorld)
            {
                return;
            }
            var voxeland = largeWorld.land;
            if (!voxeland)
            {
                return;
            }
            var typesArray = voxeland.types;
            if (typesArray == null)
            {
                return;
            }
            var lava = typesArray[index];
            if (lava == null)//LavaSurface
            {
                return;
            }
            var lavaMaterial = new Material(lava.material);
            gameObject.GetComponentInChildren<MeshRenderer>().material = lavaMaterial;
            _fixedMaterial = true;
        }

        public void UseLavaFallMaterial()
        {
            IEnumerator GrabPrefabCoroutine()
            {
                _runningCoroutine = true;
                var request = PrefabDatabase.GetPrefabAsync("04781674-e27a-43ce-891f-a82781314c15");
                yield return request;
                if (request.TryGetPrefab(out var prefab))
                {
                    var lavaMaterial = new Material(prefab.transform.GetChild(0).gameObject.GetComponent<Renderer>().materials[0]);
                    lavaMaterial.SetColor("_Color", new Color(1.00f, 0.36f, 0.08f, 10.00f));
                    lavaMaterial.SetFloat("_InvFade", 3f);
                    gameObject.transform.GetChild(1).GetComponentInChildren<MeshRenderer>().material = lavaMaterial;
                    _fixedMaterial = true;
                    var planeMaterial = gameObject.transform.GetChild(0).GetComponentInChildren<MeshRenderer>().material;
                    planeMaterial.SetColor("_GlowColor", new Color(1.50f, 1.40f, 1f));
                }
                Helpers.ApplySNShaders(transform.GetChild(0).gameObject, 3f, 1f, 1f);
                _runningCoroutine = false;
                gameObject.AddComponent<SkyApplier>().renderers = gameObject.GetComponentsInChildren<Renderer>();
            }
            StartCoroutine(GrabPrefabCoroutine());
        }

        private float lavaModelCycleDuration = 60f;
        private float lavaModelCycleStrength = 11f;

        private float lavaModelHeightCycleLengthScale = 0.6f;
        private float lavaModelHeightCycleHeightScale = 0.1f;

        private Vector3 GetLavaModelOffset()
        {
            var angleRadians = Mathf.PI * 2f * Time.time / lavaModelCycleDuration;
            return new Vector3(Mathf.Cos(angleRadians) * lavaModelCycleStrength, Mathf.Sin(Time.time / lavaModelHeightCycleLengthScale) * lavaModelHeightCycleHeightScale, Mathf.Sin(angleRadians) * lavaModelCycleStrength);
        }
    }
}