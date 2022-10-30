using DebugHelper.Systems;
using SMLHelper.V2.Commands;
using UnityEngine;
using System.Collections.Generic;

namespace DebugHelper.Commands
{
    public static class CreatureCommands
    {
        private static List<RenderedCreatureAction> rendered = new List<RenderedCreatureAction>();

        [ConsoleCommand("creatureactions")]
        public static void ShowCreatureActions(float inRange, bool hideMessage = false)
        {
            HideCreatureActions();
            var comparePosition = SNCameraRoot.main.transform.position;
            var actualDistanceThreshold = inRange < 0f ? float.MaxValue : inRange;
            var all = Object.FindObjectsOfType<Creature>();
            var toRender = new List<Creature>();
            var squareDistance = actualDistanceThreshold * actualDistanceThreshold;
            foreach (var c in all)
            {
                if (Vector3.SqrMagnitude(c.transform.position - comparePosition) < squareDistance)
                {
                    toRender.Add(c);
                }
            }
            if (!hideMessage) ErrorMessage.AddMessage($"Showing CreatureActions on all {toRender.Count} Creatures within a range of {actualDistanceThreshold} meters.");
            foreach (var creature in toRender)
            {
                var component = creature.gameObject.EnsureComponent<RenderedCreatureAction>();
                component.creature = creature;
                rendered.Add(component);
            }
        }

        [ConsoleCommand("hidecreatureactions")]
        public static void HideCreatureActions()
        {
            foreach (var rendered in rendered)
            {
                if (rendered != null)
                {
                    Object.DestroyImmediate(rendered);
                }
            }
            rendered.Clear();
        }

        private class RenderedCreatureAction : BasicDebugIcon
        {
            public Creature creature;

            private bool Invalid
            {
                get
                {
                    return creature == null;
                }
            }

            public override string Label
            {
                get
                {
                    if (Invalid) return "None";
                    var bestAction = creature.GetBestAction();
                    if (bestAction == null) return "Unknown\n(" + gameObject.name + ")";
                    return bestAction.GetType().Name + "\n(" + gameObject.name + ")"; ;
                }
            }

            public override Sprite Icon => null;

            public override Vector3 Position => transform.position + transform.forward + Vector3.up;

            public override float Scale => 2f;

            public override Color Color => Color.green;
        }
    }
}
