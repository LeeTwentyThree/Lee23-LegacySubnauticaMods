using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomEvents.Events
{
    class FishAttack : SpawnStuff
    {
        public override float GetSpawnDistance => 17f;

        public override bool InsideSphere => true;

        public override List<TechType> GetSpawnList => new List<TechType>() { TechType.Peeper, TechType.GarryFish, TechType.RabbitRay, TechType.Mesmer, TechType.Gasopod, TechType.Bladderfish, TechType.Hoverfish, TechType.Hoopfish, TechType.LavaLarva, TechType.Bladderfish };

        public override int MinSpawns => 30;

        public override int MaxSpawns => 40;

        public override float CreatureDespawnDelay => 45f;

        public override string GetEventStartMessage => "";

        protected override void DoCustomStuff(TechType creatureTechType)
        {
            ErrorMessage.AddMessage("A swarm of " + Language.main.Get(creatureTechType) + " has appeared!");

        }
    }
}
