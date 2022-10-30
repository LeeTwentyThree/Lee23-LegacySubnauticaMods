using DebugHelper.Systems;
using SMLHelper.V2.Commands;
using UnityEngine;
using System.Collections.Generic;

namespace DebugHelper.Commands
{
    public static class LiveMixinCommands
    {
        private static List<RenderedLiveMixin> rendered = new List<RenderedLiveMixin>();

        [ConsoleCommand("showhealth")]
        public static void ShowHealth(float inRange, bool hideMessage = false)
        {
            HideHealth();
            var comparePosition = SNCameraRoot.main.transform.position;
            var actualDistanceThreshold = inRange < 0f ? float.MaxValue : inRange;
            var all = Object.FindObjectsOfType<LiveMixin>();
            var toRender = new List<LiveMixin>();
            var squareDistance = actualDistanceThreshold * actualDistanceThreshold;
            foreach (var lm in all)
            {
                if (Vector3.SqrMagnitude(lm.transform.position - comparePosition) < squareDistance)
                {
                    toRender.Add(lm);
                }
            }
            if (!hideMessage) ErrorMessage.AddMessage($"Showing CreatureActions on all {toRender.Count} Creatures within a range of {actualDistanceThreshold} meters.");
            foreach (var liveMixin in toRender)
            {
                var component = liveMixin.gameObject.EnsureComponent<RenderedLiveMixin>();
                component.liveMixin = liveMixin;
                rendered.Add(component);
            }
        }

        [ConsoleCommand("hidehealth")]
        public static void HideHealth()
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

        private class RenderedLiveMixin : BasicDebugIcon
        {
            public LiveMixin liveMixin;

            private static Gradient healthGradient = new Gradient() { colorKeys = new GradientColorKey[] { new GradientColorKey(Color.red, 0f), new GradientColorKey(Color.green, 1f) } };

            private bool Invalid
            {
                get
                {
                    return liveMixin == null;
                }
            }

            public override string Label
            {
                get
                {
                    if (Invalid) return "Unknown";
                    if (liveMixin.maxHealth == 0f) return "Invalid!";
                    return Mathf.RoundToInt(liveMixin.health) + " / " + Mathf.RoundToInt(liveMixin.maxHealth) + " HP\n" + Mathf.RoundToInt(100f * (liveMixin.health / liveMixin.maxHealth));
                }
            }

            public override Sprite Icon => null;

            public override Vector3 Position => transform.position + transform.up * 0.5f;

            public override float Scale => 2f;

            public override Color Color
            {
                get
                {
                    if (Invalid || liveMixin.maxHealth == 0f)
                    {
                        return invalidColor;
                    }
                    return healthGradient.Evaluate(liveMixin.health / liveMixin.maxHealth);
                }
            }
        }
    }
}
