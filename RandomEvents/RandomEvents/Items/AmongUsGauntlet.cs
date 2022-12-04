using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using SMLHelper.V2.Assets;
using SMLHelper.V2.Crafting;

namespace RandomEvents.Items
{
    class AmongUsGauntlet : Equipable
    {
        public AmongUsGauntlet(string classId, string friendlyName, string description) : base(classId, friendlyName, description)
        {
        }

        public override EquipmentType EquipmentType => EquipmentType.Hand;

        protected override TechData GetBlueprintRecipe()
        {
            return new TechData(new Ingredient(TechType.Knife, 999));
        }
    }
}
