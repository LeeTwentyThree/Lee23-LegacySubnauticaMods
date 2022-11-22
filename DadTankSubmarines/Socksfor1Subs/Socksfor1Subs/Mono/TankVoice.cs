using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socksfor1Subs.Mono
{
    public class TankVoice : SubVoice
    {
        protected override void OnInitialize()
        {
            InitializeVoiceLines(
                new VoiceLine("TankHullDamage", 3f, 6f),
                new VoiceLine("TankHullIntegrityCritical", 2.5f, 20f),
                new VoiceLine("TankNoPower", 5f, 10f),
                new VoiceLine("TankKill", new string[] { "TankKill1", "TankKill2", "TankKill3", "TankKill4", "TankKill5", "TankKill6", "TankKill7", "TankKill8" }, 2.5f, 8f),
                new VoiceLine("TankKillLeviathan", new string[] { "TankKillLeviathan1", "TankKillLeviathan2", "TankKillLeviathan3", "TankKillLeviathan4" }, 2f, 2f),
                new VoiceLine("TankFriendlyFire", new string[] { "TankFriendlyFire1", "TankFriendlyFire2" }, 3.2f, 6f),
                new VoiceLine("TankWelcome", 4.3f, 10f),
                new VoiceLine("TankNoTorpedoes", 2f, 8f),
                new VoiceLine("TankUserError", 2f, 10f)
            );
        }
    }
}