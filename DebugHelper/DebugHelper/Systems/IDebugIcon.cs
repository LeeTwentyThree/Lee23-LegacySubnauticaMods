using UnityEngine;

namespace DebugHelper.Systems
{
    public interface IDebugIcon
    {
        string Label { get; }
        Sprite Icon { get; }
        Vector3 Position { get; }
        float Scale { get; }
        Color Color { get; }
        void OnCreation(DebugIconInstance instance);
    }
}