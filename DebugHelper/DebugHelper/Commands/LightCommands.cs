using UnityEngine;
using SMLHelper.V2.Commands;
using System.Collections.Generic;
using UWE;
using DebugHelper.Systems;

namespace DebugHelper.Commands
{
    public static class LightCommands
    {
        private static List<RenderedLight> renderedLights = new List<RenderedLight>();

        [ConsoleCommand("showlights")]
        public static void ShowLights(float inRange, bool hideMessage = false)
        {
            HideLights();
            var comparePosition = SNCameraRoot.main.transform.position;
            var actualDistanceThreshold = inRange < 0f ? float.MaxValue : inRange;
            var all = Object.FindObjectsOfType<Light>();
            var lightsToRender = new List<Light>();
            var squareDistance = actualDistanceThreshold * actualDistanceThreshold;
            foreach (var l in all)
            {
                if (Vector3.SqrMagnitude(l.transform.position - comparePosition) < squareDistance)
                {
                    lightsToRender.Add(l);
                }
            }
            if (!hideMessage) ErrorMessage.AddMessage($"Showing all {lightsToRender.Count} lights within a range of {actualDistanceThreshold} meters.");
            foreach (var light in lightsToRender)
            {
                var component = light.gameObject.EnsureComponent<RenderedLight>();
                component.attachedLight = light;
                renderedLights.Add(component);
            }
        }

        [ConsoleCommand("hidelights")]
        public static void HideLights()
        {
            foreach (var renderedLight in renderedLights)
            {
                if (renderedLight != null)
                {
                    Object.DestroyImmediate(renderedLight);
                }
            }
            renderedLights.Clear();
        }

        private class RenderedLight : BasicDebugIcon, IDebugIcon
        {
            public Light attachedLight;

            public override string Label
            {
                get
                {
                    if (attachedLight == null) return "Null";
                    return gameObject.name;
                }
            }

            public override Sprite Icon
            {
                get
                {
                    if (attachedLight == null)
                    {
                        return DebugIconManager.Icons.Question;
                    }
                    switch (attachedLight.type)
                    {
                        default: return DebugIconManager.Icons.Light;
                        case LightType.Directional: return DebugIconManager.Icons.Sun;
                        case LightType.Spot: return DebugIconManager.Icons.Spotlight;
                        case LightType.Area: return DebugIconManager.Icons.CubeHollow;
                        case LightType.Disc: return DebugIconManager.Icons.Circle;
                    }
                }
            }

            public override Vector3 Position => transform.position;

            public override float Scale => 1f;

            public override Color Color
            {
                get
                {
                    if (attachedLight)
                    {
                        if (!attachedLight.enabled)
                        {
                            return attachedLight.color.WithAlpha(DebugIconManager.kInactiveComponentAlpha);
                        }
                        return attachedLight.color;
                    }
                    return invalidColor;
                }
            }
        }
    }
}
