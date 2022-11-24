using ECCLibrary;
using UnityEngine;

namespace ArcticMigration
{
    internal abstract class CreaturePortBase : CreatureAsset
    {
        protected CreaturePortBase(string classId, string friendlyName, string description, GameObject model, Texture2D spriteTexture) : base(classId, friendlyName, description, model, spriteTexture)
        {
        }
    }
}