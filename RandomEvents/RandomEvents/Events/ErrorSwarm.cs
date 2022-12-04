using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEvents.Events
{
    class ErrorSwarm : SpawnStuff
    {
        public override float GetSpawnDistance => 16f;

        public override bool InsideSphere => true;

        public override List<TechType> GetSpawnList => new List<TechType>() { Mod.errorModelFish.TechType };

        public override int MinSpawns => 8;

        public override int MaxSpawns => 11;

        public override float CreatureDespawnDelay => 60f;

        public override bool Despawn => false;

        public override string GetEventStartMessage => "Spawning {undefined}. Warning: Models did not load successfully";

        protected override void DoCustomStuff(TechType creatureTechType)
        {
            Utils.PlaySound("event:/tools/use_loot");
        }
    }
}
