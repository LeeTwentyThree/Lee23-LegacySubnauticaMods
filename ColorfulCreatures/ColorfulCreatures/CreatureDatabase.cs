using System.Collections.Generic;
using UnityEngine;

namespace ColorfulCreatures
{
    internal static class CreatureDatabase
    {
        public static readonly Dictionary<string, CreatureColors> creaturePrefabColors = new Dictionary<string, CreatureColors>();

        public static void Initialize()
        {
            // Peeper
            var peeper = new CreatureColors();
            var peeperAlbino = new TextureSet("aqua_bird_01_variantalbi", "aqua_bird_01_illum_variantalbi", "aqua_bird_01_spec_variantalbi");
            var peeperBase = new TextureSet("aqua_bird_01", "aqua_bird_01_illum", "aqua_bird_01_spec");
            var peeperMelanistic = new TextureSet("aqua_bird_01_variantmela", "aqua_bird_01_illum_variantmela", "aqua_bird_01_spec_variantmela");
            var peeperMaterial = new MaterialPreset(peeperAlbino, peeperBase, peeperMelanistic);
            peeper.AddRenderer(new CreatureRenderer("model/peeper/aqua_bird_LOD1/Aqua_Bird", peeperMaterial, null));
            peeper.AddRenderer(new CreatureRenderer("model/peeper/aqua_bird/peeper", peeperMaterial, null));
            Add("3fcd548b-781f-46ba-b076-7412608deeef", peeper);
        }

        private static void Add(string classId, CreatureColors data)
        {
            creaturePrefabColors.Add(classId, data);
        }

        public static void ApplyColors(Creature creature, string prefabId)
        {
            if (creaturePrefabColors.TryGetValue(prefabId, out CreatureColors colorData))
            {
                ApplyMaterialsToGameObject(creature.gameObject, colorData);
            }
        }

        private static List<MaterialPreset> tempMaterialSets = new List<MaterialPreset>();
        private static List<TextureSet> tempTextureSets = new List<TextureSet>();

        private static void ApplyMaterialsToGameObject(GameObject obj, CreatureColors data)
        {
            data.Randomize();
            foreach (var rendererData in data.rendererData)
            {
                var model = obj.transform.Find(rendererData.pathToModel);
                var rendererComponent = model.GetComponent<Renderer>();
                var materials = rendererComponent.materials;
                for (int i = 0; i < rendererData.materialData.Length; i++)
                {
                    var materialPreset = rendererData.materialData[i];
                    if (materialPreset == null) continue;
                    var textureSet = materialPreset.chosenTextureSet; // this is flawed, you don't want to do this more than once
                    ApplyTexureSetToRenderer(materials, i, textureSet);
                }
                rendererComponent.materials = materials;
            }
        }

        private static void ApplyTexureSetToRenderer(Material[] array, int materialIndex, TextureSet set)
        {
            array[materialIndex].SetTexture("_Color", set.diffuse);
            array[materialIndex].SetTexture("_Illum", set.illum);
            array[materialIndex].SetTexture("_SpecTex", set.specular);
        }
    }
}
