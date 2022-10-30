using DebugHelper.Commands;
using UnityEngine;

namespace DebugHelper.Systems
{
    internal class DebugAutomation : MonoBehaviour
    {
        private bool automatedLights;
        private bool automatedSkyAppliers;
        private bool automatedEmitters;
        private bool automatedCreatureActions;
        private bool automatedHealth;

        private bool lightsLastFrame;
        private bool skyAppliersLastFrame;
        private bool emittersLastFrame;
        private bool creatureActionsLastFrame;
        private bool healthLastFrame;

        private float timeLastUpdated;

        private void Update()
        {
            if (Time.time > timeLastUpdated + Main.config.DebugUpdateInterval || UpdateNeeded())
            {
                timeLastUpdated = Time.time;
                LazyUpdate();
            }
        }

        private bool UpdateNeeded()
        {
            bool necessary = false;
            var config = Main.config;
            if (lightsLastFrame != config.ShowLights) necessary = true;
            if (skyAppliersLastFrame != config.ShowSkyAppliers) necessary = true;
            if (emittersLastFrame != config.ShowEmitters) necessary = true;
            if (creatureActionsLastFrame != config.ShowCreatureActions) necessary = true;
            if (healthLastFrame != config.ShowHealth) necessary = true;
            lightsLastFrame = config.ShowLights;
            skyAppliersLastFrame = config.ShowSkyAppliers;
            emittersLastFrame = config.ShowEmitters;
            creatureActionsLastFrame = config.ShowCreatureActions;
            healthLastFrame = config.ShowHealth;
            return necessary;
        }

        private void LazyUpdate()
        {
            var config = Main.config;
            // hide any ongoing things if needed
            if (automatedLights && !config.ShowLights)
            {
                LightCommands.HideLights();
                automatedLights = false;
            }
            if (automatedSkyAppliers && !config.ShowSkyAppliers)
            {
                SkyApplierCommands.HideSkyAppliers();
                automatedSkyAppliers = false;
            }
            if (automatedEmitters && !config.ShowEmitters)
            {
                AudioCommands.HideEmitters();
                automatedEmitters = false;
            }
            if (automatedCreatureActions && !config.ShowCreatureActions)
            {
                CreatureCommands.HideCreatureActions();
                automatedCreatureActions = false;
            }
            if (automatedHealth && !config.ShowHealth)
            {
                LiveMixinCommands.HideHealth();
                automatedHealth = false;
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
            if (config.ShowCreatureActions)
            {
                CreatureCommands.ShowCreatureActions(range, true);
                automatedCreatureActions = true;
            }
            if (config.ShowHealth)
            {
                LiveMixinCommands.ShowHealth(range, true);
                automatedHealth = true;
            }
        }
    }
}
