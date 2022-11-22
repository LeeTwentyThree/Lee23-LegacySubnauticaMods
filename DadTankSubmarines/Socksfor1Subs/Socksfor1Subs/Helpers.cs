using System.Reflection;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

namespace Socksfor1Subs
{
    public static class Helpers
    {
        public static void ApplySNShaders(GameObject prefab, float shininess = 8f, float specularInt = 1f, float glowStrength = 1f, Material glassMaterial = null)
        {
            var renderers = prefab.GetComponentsInChildren<Renderer>(true);
            var newShader = Shader.Find("MarmosetUBER");
            bool hasGlassMaterial = glassMaterial != null;
            for (int i = 0; i < renderers.Length; i++)
            {
                if (renderers[i] is ParticleSystemRenderer)
                {
                    continue;
                }
                for (int j = 0; j < renderers[i].materials.Length; j++)
                {
                    Material material = renderers[i].materials[j];
                    if (hasGlassMaterial && material.name.ToLower().Contains("glass"))
                    {
                        var materials = renderers[i].materials;
                        materials[j] = new Material(glassMaterial);
                        renderers[i].materials = materials;
                        continue;
                    }
                    Texture specularTexture = material.GetTexture("_SpecGlossMap");
                    Texture emissionTexture = material.GetTexture("_EmissionMap");
                    Color emissionColor = material.GetColor(ShaderPropertyID._EmissionColor);
                    material.shader = newShader;

                    material.DisableKeyword("_SPECGLOSSMAP");
                    material.DisableKeyword("_NORMALMAP");
                    if (specularTexture != null)
                    {
                        material.SetTexture("_SpecTex", specularTexture);
                        material.SetFloat("_SpecInt", specularInt);
                    }
                    else
                    {
                        material.SetFloat("_SpecInt", 0.1f);
                    }
                    material.SetFloat("_Shininess", shininess);
                    material.EnableKeyword("MARMO_SPECMAP");
                    material.SetColor("_SpecColor", new Color(1f, 1f, 1f, 1f));
                    material.SetFloat("_Fresnel", 0.24f);
                    material.SetVector("_SpecTex_ST", new Vector4(1.0f, 1.0f, 0.0f, 0.0f));
                    if (material.IsKeywordEnabled("_EMISSION"))
                    {
                        material.EnableKeyword("MARMO_EMISSION");
                        material.SetFloat(ShaderPropertyID._EnableGlow, 1f);
                        material.SetTexture(ShaderPropertyID._Illum, emissionTexture);
                        material.SetColor(ShaderPropertyID._GlowColor, emissionColor);
                        material.SetFloat(ShaderPropertyID._GlowStrength, glowStrength);
                        material.SetFloat(ShaderPropertyID._GlowStrengthNight, glowStrength);
                    }

                    if (material.GetTexture("_BumpMap"))
                    {
                        material.EnableKeyword("MARMO_NORMALMAP");
                    }

                    if (material.name.Contains("Cutout"))
                    {
                        material.EnableKeyword("MARMO_ALPHA_CLIP");
                    }
                    if (material.name.Contains("Transparent"))
                    {
                        material.EnableKeyword("_ZWRITE_ON");
                        material.EnableKeyword("WBOIT");
                        material.SetInt("_ZWrite", 0);
                        material.SetInt("_Cutoff", 0);
                        material.SetFloat("_SrcBlend", 1f);
                        material.SetFloat("_DstBlend", 1f);
                        material.SetFloat("_SrcBlend2", 0f);
                        material.SetFloat("_DstBlend2", 10f);
                        material.SetFloat("_AddSrcBlend", 1f);
                        material.SetFloat("_AddDstBlend", 1f);
                        material.SetFloat("_AddSrcBlend2", 0f);
                        material.SetFloat("_AddDstBlend2", 10f);
                        material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.EmissiveIsBlack | MaterialGlobalIlluminationFlags.RealtimeEmissive;
                        material.renderQueue = 3101;
                        material.enableInstancing = true;
                    }
                }
            }
        }

        public static AssetBundle LoadAssetBundleFromAssetsFolder(Assembly modAssembly, string assetsFileName)
        {
            return AssetBundle.LoadFromFile(Path.Combine(Path.GetDirectoryName(modAssembly.Location), "Assets", assetsFileName));
        }

        public static float JessyMap(float value, float from1, float to1, float from2, float to2) // thanks Jessy
        {
            return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
        }

        public static GameObject FindChild(GameObject parent, string byName)
        {
            foreach (Transform child in parent.transform)
            {
                if (child.gameObject.name == byName)
                {
                    return child.gameObject;
                }
                GameObject recursive = FindChild(child.gameObject, byName);
                if (recursive)
                {
                    return recursive;
                }
            }
            return null;
        }

        public static void CleanupPrefabComponents(GameObject obj)
        {
            Object.DestroyImmediate(obj.GetComponent<SkyApplier>());
            Object.DestroyImmediate(obj.GetComponent<PrefabIdentifier>());
            Object.DestroyImmediate(obj.GetComponent<Constructable>());
            Object.DestroyImmediate(obj.GetComponent<LargeWorldEntity>());
        }

        public static FMODAsset GetFmodAsset(string audioPath)
        {
            FMODAsset asset = ScriptableObject.CreateInstance<FMODAsset>();
            asset.path = audioPath;
            return asset;
        }
    }
}
