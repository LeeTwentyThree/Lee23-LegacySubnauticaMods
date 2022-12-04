using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Assets;
using UnityEngine;

namespace RandomEvents
{
    public class RandomEventItem : Craftable
    {
        public RandomEventItem() : base("RandomEventItem", "Random Event Starter", "Drop outside to force a random event to happen!")
        {
        }

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData() { craftAmount = 1, Ingredients = new List<Ingredient>() { new Ingredient(TechType.Titanium, 1), new Ingredient(TechType.Copper, 1) } };
        }

        public override bool HasSprite => true;

        public override string IconFileName => "RandomEventItem.png";

        public override CraftTree.Type FabricatorType => CraftTree.Type.Fabricator;

        public override string[] StepsToFabricatorTab => new string[] { "Personal", "Tools" };

        public override GameObject GetGameObject()
        {
            GameObject obj = new GameObject();
            obj.EnsureComponent<Pickupable>();
            obj.EnsureComponent<TechTag>();
            obj.EnsureComponent<PrefabIdentifier>();
            obj.EnsureComponent<RandomEventOnDrop>();
            obj.EnsureComponent<LargeWorldEntity>().cellLevel = LargeWorldEntity.CellLevel.Medium;
            return obj;
        }
    }
}
