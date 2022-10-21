using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socksfor1Subs.Mono
{
    public class DadSubVoice : SubVoice
    {
        protected override void OnInitialize()
        {
            InitializeVoiceLines(
                new VoiceLine("DadHolographicDecoy", 3f, 1f),
                new VoiceLine("DadHostileLifeform", 4f, 30f),
                new VoiceLine("DadHullDamage", 3f, 20f),
                new VoiceLine("DadPassingSafeDepth", 3f, 15f),
                new VoiceLine("DadStealthDisabled", 5f, 5f),
                new VoiceLine("DadStealthEnabled", 2f, 1f),
                new VoiceLine("DadStealthReady", 3f, 1f),
                new VoiceLine("DadWelcomeAboard", 6.6f, 60f),
                new VoiceLine("DadEmergencyPower", 4f, 20f),
                new VoiceLine("DadEngineOn", 2f, 3f),
                new VoiceLine("DadHullDamage", 3f, 30f),
                new VoiceLine("DadHullFailureImminent", 3f, 20f),
                new VoiceLine("DadWelcomeNegative", 6.6f, 10f),
                new VoiceLine("DadWelcomeSecret", 5f, 60f)
            );
        }
    }
}
