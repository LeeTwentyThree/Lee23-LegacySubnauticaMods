using System.Collections.Generic;
using UnityEngine;

namespace ColorfulCreatures
{
    internal static class CreatureDatabase
    {
        public static readonly Dictionary<string, CreatureColors> creaturePrefabColors = new Dictionary<string, CreatureColors>();

        private static int mainTex = Shader.PropertyToID("_MainTex");
        private static int illum = Shader.PropertyToID("_Illum");
        private static int specTex = Shader.PropertyToID("_SpecTex");

        public static void Initialize()
        {
            // Crabsquid
            var crabsquid = new CreatureColors();
            var crabsquidBase = new TextureSet("crab_squid", "crab_squid_illum", "crab_squid_spec");
            var crabsquidMembraneBase = new TextureSet("crab_squid_membrane", "crab_squid_membrane_illum", "crab_squid_membrane_spec");
            var crabsquidVariants = new TextureSetBuilder("crab_squid_variant_", "crab_squid_illum_variant_", "crab_squid_spec_variant_");
            var crabsquidMembraneVariants = new TextureSetBuilder("crab_squid_membrane_variant_", "crab_squid_membrane_illum_variant_", "crab_squid_membrane_spec_variant_");
            var crabsquidMaterial = new MaterialSet(crabsquidBase, crabsquidVariants.A, crabsquidVariants.B, crabsquidVariants.C, crabsquidVariants.D, crabsquidVariants.E, crabsquidVariants.F, crabsquidVariants.Albino, crabsquidVariants.Melanistic);
            var crabsquidMembraneMaterial = new MaterialSet(crabsquidMembraneBase, crabsquidMembraneVariants.A, crabsquidMembraneVariants.B, crabsquidMembraneVariants.C, crabsquidMembraneVariants.D, crabsquidMembraneVariants.E, crabsquidMembraneVariants.F, crabsquidMembraneVariants.Albino, crabsquidMembraneVariants.Melanistic);
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_body_geo", crabsquidMaterial, crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_body_geo_LOD1", crabsquidMaterial, crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_body_geo_LOD2", crabsquidMaterial, crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_body_geo_LOD3", crabsquidMaterial, crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_head_geo1", crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_head_geo1_LOD1", crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_head_geo1_LOD2", crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_head_geo1_LOD3", crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_head_geo2", crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_head_geo2_LOD1", crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_head_geo2_LOD2", crabsquidMembraneMaterial));
            crabsquid.AddRenderer(new CreatureRenderer("models/Crab_Squid/crab_squid_geo/crab_squid_head_geo2_LOD3", crabsquidMembraneMaterial));
            Add("4c2808fe-e051-44d2-8e64-120ddcdc8abb", crabsquid);

            // Peeper
            var peeper = new CreatureColors();
            var peeperBase = new TextureSet("aqua_bird_01", "aqua_bird_01_illum", "aqua_bird_01_spec");
            var peeperVariants = new TextureSetBuilder("aqua_bird_01_variant", "aqua_bird_01_illum_variant", "aqua_bird_01_spec_variantalbi");
            var peeperMaterial = new MaterialSet(peeperBase, peeperVariants.A, peeperVariants.B, peeperVariants.C, peeperVariants.D, peeperVariants.E, peeperVariants.F, peeperVariants.Albino, peeperVariants.Melanistic);
            peeper.AddRenderer(new CreatureRenderer("model/peeper/aqua_bird_LOD1/Aqua_Bird", peeperMaterial, peeperMaterial));
            peeper.AddRenderer(new CreatureRenderer("model/peeper/aqua_bird/peeper", peeperMaterial, peeperMaterial));
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

        private static void ApplyMaterialsToGameObject(GameObject obj, CreatureColors data)
        {
            data.Randomize(Random.value);
            foreach (var rendererData in data.rendererData)
            {
                var model = obj.transform.Find(rendererData.pathToModel);
                var rendererComponent = model.GetComponent<Renderer>();
                var materials = rendererComponent.materials;
                for (int i = 0; i < rendererData.materialData.Length; i++)
                {
                    var materialPreset = rendererData.materialData[i];
                    if (materialPreset == null) continue;
                    var textureSet = materialPreset.chosenTextureSet;
                    ApplyTexureSetToRenderer(materials, i, textureSet);
                }
                rendererComponent.materials = materials;
            }
        }

        private static void ApplyTexureSetToRenderer(Material[] materials, int materialIndex, TextureSet set)
        {
            if (set.useDiffuse) materials[materialIndex].SetTexture(mainTex, set.diffuse);
            if (set.useIllum) materials[materialIndex].SetTexture(illum, set.illum);
            if (set.useSpecular) materials[materialIndex].SetTexture(specTex, set.specular);
        }
    }
}
