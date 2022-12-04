using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEvents.Events
{
    class AlienRobotAttack : SpawnStuff
    {
        public override float GetSpawnDistance => 3f;

        public override bool InsideSphere => false;

        public override List<TechType> GetSpawnList => new List<TechType>() { TechType.PrecursorDroid };

        public override int MinSpawns => 7;

        public override int MaxSpawns => 12;

        public override float CreatureDespawnDelay => 25f;

        public override string GetEventStartMessage => "A swarm of Alien Robots has appeared!";
    }
}
