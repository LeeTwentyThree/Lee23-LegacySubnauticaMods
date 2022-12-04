using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWE;

namespace RandomEvents.Events
{
    class LeviathanAttack : SpawnStuff
    {
        public override float GetSpawnDistance => 50f;

        public override bool InsideSphere => false;

        public override List<TechType> GetSpawnList => new List<TechType>() { TechType.ReaperLeviathan, TechType.SeaDragon, TechType.GhostLeviathan, TechType.SeaTreader };

        public override int MinSpawns => 2;

        public override int MaxSpawns => 5;

        public override string GetEventStartMessage => "";

        public override float CreatureDespawnDelay => 90f;

        protected override void DoCustomStuff(TechType creatureTechType)
        {
            Utils.PlaySound("event:/player/story/Goal_BiomeDunes");
            Subtitles.main.Add("Goal_BiomeDunes");
        }
    }
}
