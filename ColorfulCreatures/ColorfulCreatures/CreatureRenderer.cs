using System.Collections.Generic;

namespace ColorfulCreatures
{
    internal class CreatureRenderer : IRandomizable
    {
        public string pathToModel;
        public MaterialSet[] materialData;

        public CreatureRenderer(string pathToModel, params MaterialSet[] materials)
        {
            this.pathToModel = pathToModel;
            this.materialData = materials;
        }

        public void Randomize(float value)
        {
            foreach (var preset in materialData)
            {
                if (preset != null)
                {
                    preset.Randomize(value);
                }
            }
        }
    }
}
