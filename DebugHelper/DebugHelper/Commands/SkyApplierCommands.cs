﻿using UnityEngine;
using SMLHelper.V2.Commands;
using System.Collections.Generic;
using UWE;
using DebugHelper.Systems;

namespace DebugHelper.Commands
{
    public static class SkyApplierCommands
    {
        private static List<RenderedSkyApplier> renderedSkyAppliers = new List<RenderedSkyApplier>();

        [ConsoleCommand("showskyappliers")]
        public static void ShowSkyAppliers(float inRange)
        {
            HideSkyAppliers();
            var comparePosition = SNCameraRoot.main.transform.position;
            var actualDistanceThreshold = inRange < 0f ? float.MaxValue : inRange;
            var all = Object.FindObjectsOfType<SkyApplier>();
            var toRender = new List<SkyApplier>();
            foreach (var s in all)
            {
                if (Vector3.Distance(s.transform.position, comparePosition) < actualDistanceThreshold)
                {
                    toRender.Add(s);
                }
            }
            ErrorMessage.AddMessage($"Showing all {toRender.Count} SkyAppliers within a range of {actualDistanceThreshold} meters.");
            foreach (var skyApplier in toRender)
            {
                var component = skyApplier.gameObject.EnsureComponent<RenderedSkyApplier>();
                component.attachedSkyApplier = skyApplier;
                renderedSkyAppliers.Add(component);
            }
        }

        [ConsoleCommand("hideskyappliers")]
        public static void HideSkyAppliers()
        {
            foreach (var rendered in renderedSkyAppliers)
            {
                if (rendered != null)
                {
                    Object.DestroyImmediate(rendered);
                }
            }
            renderedSkyAppliers.Clear();
        }

        private class RenderedSkyApplier : MonoBehaviour, IDebugIcon
        {
            private void OnEnable()
            {
                DebugIconManager.Main.Register(this);
            }

            private void OnDisable()
            {
                DebugIconManager.Main.Unregister(this);
            }

            public void OnCreation(DebugIconInstance instance)
            {
                
            }

            public SkyApplier attachedSkyApplier;

            private Color invalidColor = new Color(1f, 0f, 0f, DebugIconManager.kInactiveComponentAlpha);

            public string Label
            {
                get
                {
                    if (attachedSkyApplier == null) return "Null";
                    return gameObject.name;
                }
            }

            public Sprite Icon
            {
                get
                {
                    if (attachedSkyApplier == null)
                    {
                        return DebugIconManager.Icons.Question;
                    }
                    return DebugIconManager.Icons.Globe;
                }
            }

            public Vector3 Position => transform.position;

            public float Scale => 1f;

            public Color Color
            {
                get
                {
                    if (attachedSkyApplier == null)
                    {
                        return invalidColor;
                    }
                    var sky = attachedSkyApplier.applySky;
                    if (sky == null)
                    {
                        return Color.white;
                    }
                    if (sky.Outdoors)
                    {
                        return Color.blue;
                    }
                    else
                    {
                        return Color.yellow;
                    }
                }
            }
        }
    }
}
