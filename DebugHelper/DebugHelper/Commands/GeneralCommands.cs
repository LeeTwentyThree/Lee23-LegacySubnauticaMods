using DebugHelper.Systems;
using SMLHelper.V2.Commands;
using UnityEngine;

namespace DebugHelper.Commands
{
    public static class GeneralCommands
    {
        [ConsoleCommand("createreferencepoint")]
        public static void CreateReferencePoint()
        {
            new GameObject("ReferencePoint").AddComponent<ReferencePoint>().position = SNCameraRoot.main.transform.position;
        }

        private class ReferencePoint : BasicDebugIcon
        {
            public Vector3 position;
            
            public override string Label
            {
                get
                {
                    return Mathf.Round(position.x) + ", " + Mathf.Round(position.y) + ", " + Mathf.Round(position.z) + "\n" + Mathf.Round(Vector3.Distance(position, SNCameraRoot.main.transform.position)) + "m";
                }
            }

            public override Sprite Icon => DebugIconManager.Icons.Pointer;

            public override Vector3 Position => position;

            public override float Scale => 1f;

            public override Color Color => Color.green;
        }
        
        [ConsoleCommand("drawstar")]
        public static void DrawStar(float duration, float radius = 1f)
        {
            Utils.DebugDrawStar(Player.main.transform.position, radius, Color.cyan, duration);
        }
    }
}
