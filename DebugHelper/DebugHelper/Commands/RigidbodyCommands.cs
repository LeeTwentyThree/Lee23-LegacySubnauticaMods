﻿using DebugHelper.Systems;
using SMLHelper.V2.Commands;
using UnityEngine;
using System.Collections.Generic;

namespace DebugHelper.Commands
{
    public static class RigidbodyCommands
    {
        private static List<RendereredRigidbody> rendered = new List<RendereredRigidbody>();

        [ConsoleCommand("showrigidbodies")]
        public static void ShowRigidbodies(float inRange, bool hideMessage = false)
        {
            HideRigidbodies();
            var comparePosition = SNCameraRoot.main.transform.position;
            var actualDistanceThreshold = inRange < 0f ? float.MaxValue : inRange;
            var all = Object.FindObjectsOfType<Rigidbody>();
            var toRender = new List<Rigidbody>();
            var squareDistance = actualDistanceThreshold * actualDistanceThreshold;
            foreach (var lm in all)
            {
                if (Vector3.SqrMagnitude(lm.transform.position - comparePosition) < squareDistance)
                {
                    toRender.Add(lm);
                }
            }
            if (!hideMessage) ErrorMessage.AddMessage($"Showing Rigidbodies on all {toRender.Count} GameObjects within a range of {actualDistanceThreshold} meters.");
            foreach (var rigidbody in toRender)
            {
                var component = rigidbody.gameObject.EnsureComponent<RendereredRigidbody>();
                component.rb = rigidbody;
                rendered.Add(component);
            }
        }

        [ConsoleCommand("hiderigidbodies")]
        public static void HideRigidbodies()
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

        private class RendereredRigidbody : BasicDebugIcon
        {
            public Rigidbody rb;
            private WorldForces wf;

            private void Start()
            {
                wf = GetComponent<WorldForces>();
            }

            private static Gradient massGradient = new Gradient() { colorKeys = new GradientColorKey[]
            {
                new GradientColorKey(Color.white, 0f),
                new GradientColorKey(Color.green, 0.25f),
                new GradientColorKey(Color.blue, 0.5f),
                new GradientColorKey(Color.yellow, 0.75f),
                new GradientColorKey(Color.red, 1f)
            } };

            private static float gradientUpperLimit = 2500f;

            private bool Invalid
            {
                get
                {
                    return rb == null;
                }
            }

            public override string Label
            {
                get
                {
                    if (Invalid) return "Removed";
                    return "Mass: " + rb.mass + "\nKinematic: " + rb.isKinematic + "\n" + GetWorldForcesInfo();
                }
            }

            private string GetWorldForcesInfo()
            {
                if (wf == null)
                {
                    return "Missing WorldForces";
                }
                if (wf.useRigidbody != rb)
                {
                    return "WorldForces incorrectly assigned";
                }
                if (wf.handleGravity && rb.useGravity)
                {
                    return "useGravity should be disabled!";
                }
                return "Good WorldForces";
            }

            public override Sprite Icon => DebugIconManager.Icons.CubeSolid;

            public override Vector3 Position => transform.position + Vector3.down;

            public override float Scale => 0.8f;

            public override Color Color
            {
                get
                {
                    if (Invalid)
                    {
                        return invalidColor;
                    }
                    return massGradient.Evaluate(rb.mass / gradientUpperLimit);
                }
            }
        }
    }
}
