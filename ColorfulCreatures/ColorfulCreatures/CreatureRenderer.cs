using System.Collections.Generic;

namespace ColorfulCreatures
{
    internal class CreatureRenderer : IRandomizable
    {
        public string pathToModel;
        public MaterialPreset[] materialData;

        public CreatureRenderer(string pathToModel, params MaterialPreset[] materials)
        {
            this.pathToModel = pathToModel;
            this.materialData = materials;
        }

        public void Randomize()
        {
            foreach (var preset in materialData)
            {
                if (preset != null)
                {
                    preset.Randomize();
                }
            }
        }
    }
}
