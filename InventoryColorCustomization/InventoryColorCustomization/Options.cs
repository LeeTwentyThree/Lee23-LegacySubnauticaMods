using SMLHelper.V2.Json;
using SMLHelper.V2.Options;
using SMLHelper.V2.Options.Attributes;
using System.Collections.Generic;

namespace InventoryColorCustomization
{
    // worst class i've written since the pre-ECC gargantuan leviathan
    public class Options : ModOptions
    {
        private SaveOptions savedOptions;

        public Options() : base("Inventory Color Customization (Requires game restart)")
        {
            ToggleChanged += OnToggleChanged;
            ChoiceChanged += OnChoiceChanged;
            savedOptions = new SaveOptions();
            savedOptions.Load(true);
        }

        public override void BuildModOptions()
        {
            AddBackgroundColorOption(CraftData.BackgroundType.Normal, "Normal Item Color");
            AddBackgroundColorOption(CraftData.BackgroundType.ExosuitArm, "Exosuit Arm Color");
            AddBackgroundColorOption(CraftData.BackgroundType.PlantWater, "Plant Color");
            AddBackgroundColorOption(CraftData.BackgroundType.PlantAir, "Land Plant Color");
            AddBackgroundColorOption(CraftData.BackgroundType.PlantWaterSeed, "Seed Color");
            AddBackgroundColorOption(CraftData.BackgroundType.PlantAirSeed, "Land Seed Color");
            AddToggleOption("TransparentBackgrounds", "Transparent Backgrounds", savedOptions.TransparentBackgrounds);
            AddToggleOption("SquareIcons", "Use Square Icons", savedOptions.SquareIcons);

            // AddBackgroundColorOption(CraftData.BackgroundType.Blueprint, "Blueprint Color (Unused)");
        }

        public void OnToggleChanged(object sender, ToggleChangedEventArgs eventArgs)
        {
            switch (eventArgs.Id)
            {
                case "TransparentBackgrounds":
                    savedOptions.TransparentBackgrounds = eventArgs.Value;
                    break;
                case "SquareIcons":
                    savedOptions.SquareIcons = eventArgs.Value;
                    break;
            }
            savedOptions.Save();
        }

        public void OnChoiceChanged(object sender, ChoiceChangedEventArgs eventArgs)
        {
            var key = eventArgs.Id;
            int value = ItemBackgroundData.ChoiceNameToIndex(key, eventArgs.Value);
            if (savedOptions.BackgroundColorChoices == null)
            {
                savedOptions.BackgroundColorChoices = new Dictionary<string, int>();
            }
            var dict = savedOptions.BackgroundColorChoices;
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
            }
            else
            {
                dict.Add(key, value);
            }
            savedOptions.Save();
        }

        private void AddBackgroundColorOption(CraftData.BackgroundType backgroundType, string label)
        {
            string id = ItemBackgroundData.GetBackgroundData(backgroundType).ID;
            var choices = ItemBackgroundData.GetColorChoiceNames(backgroundType);
            AddChoiceOption(id, label, choices, savedOptions.GetBackgroundColorChoice(ItemBackgroundData.GetBackgroundData(backgroundType).ID));
        }

        public int GetSelectedIndexForBackground(string backgroundType)
        {
            return savedOptions.GetBackgroundColorChoice(backgroundType);
        }

        public bool TransparentBackgrounds { get { return savedOptions.TransparentBackgrounds; } }

        public bool SquareIcons { get { return savedOptions.SquareIcons; } }

    }
}