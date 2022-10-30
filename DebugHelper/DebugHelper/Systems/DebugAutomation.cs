using DebugHelper.Commands;
using UnityEngine;

namespace DebugHelper.Systems
{
    internal class DebugAutomation : MonoBehaviour
    {
        private bool automatedLights;
        private bool automatedSkyAppliers;
        private bool automatedEmitters;
        private bool automatedColliders;

        private float timeLastUpdated;
        private float updateRate = 1f;

        private void Update()
        {
            if (Time.time > timeLastUpdated + updateRate)
            {
                timeLastUpdated = Time.time;
                LazyUpdate();
            }
        }

        private void LazyUpdate()
        {
            var config = Main.config;
            // hide any ongoing things if needed
            if (automatedLights && !config.ShowLights)
            {
                LightCommands.HideLights();
            }
            if (automatedSkyAppliers && !config.ShowSkyAppliers)
            {
                SkyApplierCommands.HideSkyAppliers();
            }
            if (automatedEmitters && !config.ShowEmitters)
            {
                AudioCommands.HideEmitters();
            }
            if (automatedColliders && !config.ShowColliders)
            {
                ColliderCommands.HideColliders(true);
            }

            // show things that need to be shown
            var range = config.DebugRange;
            if (config.ShowLights)
            {
                LightCommands.ShowLights(range, true);
                automatedLights = true;
            }
            if (config.ShowSkyAppliers)
            {
                SkyApplierCommands.ShowSkyAppliers(range, true);
                automatedSkyAppliers = true;
            }
            if (config.ShowEmitters)
            {
                AudioCommands.ShowEmitters(range, true);
                automatedEmitters = true;
            }
            if (config.ShowColliders)
            {
                ColliderCommands.ShowCollidersInRange(range, true);
                automatedColliders = true;
            }
        }
    }
}
