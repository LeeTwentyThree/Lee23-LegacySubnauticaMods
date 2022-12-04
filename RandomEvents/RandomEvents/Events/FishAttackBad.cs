using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEvents.Events
{
    class FishAttackBad : SpawnStuff
    {
        public override float GetSpawnDistance => 17f;

        public override bool InsideSphere => false;

        public override List<TechType> GetSpawnList => new List<TechType>() { TechType.LavaLizard, TechType.Crash, TechType.Sandshark, TechType.BoneShark, TechType.SpineEel, TechType.Shocker };

        public override int MinSpawns => 15;

        public override int MaxSpawns => 20;

        public override float CreatureDespawnDelay => 45f;

        public override string GetEventStartMessage => "";

        protected override void DoCustomStuff(TechType creatureTechType)
        {
            ErrorMessage.AddMessage("A swarm of " + Language.main.Get(creatureTechType) + " has appeared!");

        }
    }
}
