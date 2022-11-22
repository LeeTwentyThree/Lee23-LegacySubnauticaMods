using System.Collections.Generic;
using UnityEngine;

namespace ColorfulCreatures
{
    internal class CreatureColors : IRandomizable
    {
        public List<CreatureRenderer> rendererData = new List<CreatureRenderer>();

        public CreatureColors()
        {
        }

        public void AddRenderer(CreatureRenderer renderer)
        {
            rendererData.Add(renderer);
        }

        public void Randomize(float value)
        {
            foreach (var renderer in rendererData)
            {
                renderer.Randomize(value);
            }
        }
    }
}
