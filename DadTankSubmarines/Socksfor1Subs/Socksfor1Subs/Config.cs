using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;

namespace Socksfor1Subs
{
    [Menu("D.A.D. Submersible & S.O.C.K. Tank")]
    public class Config : ConfigFile
    {
        [Toggle("Enable torpedo flash", Tooltip = "Check this box if you want the S.O.C.K. Tank's torpedoes to flash a white light onto the screen when exploding in close proximity.")]
        public bool EnableTorpedoFlash = false;
        [Toggle("Disable leviathan fear", Tooltip = "Check this box if you want leviathans to not swim away into walls when taking damage.\nRESTART REQUIRED.")]
        public bool DisableLeviathanFear = true;
        [Toggle("More vicious Reapers", Tooltip = "Check this box if you want Reaper Leviathans to be more aggressive towards the S.O.C.K. Tank.\nRESTART REQUIRED.")]
        public bool MoreViciousReapers = true;
    }
}