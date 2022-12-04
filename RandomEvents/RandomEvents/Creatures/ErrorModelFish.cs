using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECCLibrary;
using UnityEngine;
using RandomEvents.Mono;

namespace RandomEvents.Creatures
{
    public class ErrorModelFish : CreatureAsset
    {
        public ErrorModelFish(string classId, string friendlyName, string description, GameObject model, Texture2D spriteTexture) : base(classId, friendlyName, description, model, spriteTexture)
        {
        }

        public override BehaviourType BehaviourType => BehaviourType.MediumFish;

        public override LargeWorldEntity.CellLevel CellLevel => LargeWorldEntity.CellLevel.Medium;

        public override SwimRandomData SwimRandomSettings => new SwimRandomData(true, new Vector3(15f, 10f, 15f), 2f, 2f, 0.1f);

        public override AvoidObstaclesData AvoidObstaclesSettings => new AvoidObstaclesData(0.5f, true, 5f);

        public override EcoTargetType EcoTargetType => EcoTargetType.MediumFish;

        public override void AddCustomBehaviour(CreatureComponents components)
        {
            prefab.transform.GetChild(0).gameObject.AddComponent<ErrorModelAnimate>();
        }

        public override void SetLiveMixinData(ref LiveMixinData liveMixinData)
        {
            liveMixinData.maxHealth = 541903f;
            liveMixinData.knifeable = false;
        }
    }
}
