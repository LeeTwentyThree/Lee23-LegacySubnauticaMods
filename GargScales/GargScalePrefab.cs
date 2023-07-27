using SMLHelper.V2.Assets;
using UnityEngine;

namespace GargScales
{
    public class GargScalePrefab : Spawnable
    {
        public GargScalePrefab() : base(
            "GargScale",
            "Gargantuan Leviathan Scale",
            "An extremely tough material obtained from a formidable leviathan. Can be used to craft advanced alloys with exceptional strength.")
        { }

        public override GameObject GetGameObject()
        {
            var prefab = Object.Instantiate(CraftData.GetPrefabForTechType(TechType.BulboTreePiece));
            prefab.GetComponent<BoxCollider>().size *= 5;
            var renderer = prefab.GetComponentInChildren<Renderer>();
            renderer.transform.localScale *= 5;
            var material = renderer.material;
            material.SetColor("_Color", new Color(0.1f, 0f, 0.05f));
            material.SetColor("_SpecColor", new Color(1, 1, 4));
            material.SetFloat("_SpecInt", 2);
            material.SetFloat("_Shininess", 7);
            material.SetFloat("_Fresnel", 0.5f);
            return prefab;
        }

        public override bool HasSprite => true;

        public override Vector2int SizeInInventory => new Vector2int(2, 1);
    }
}
