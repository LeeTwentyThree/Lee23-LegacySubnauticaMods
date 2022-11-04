using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggressiveFauna
{
    public static class AggressionSettings
    {
        public static int SearchRingScale { get { return 3; } }

        public static bool CanSeeThroughTerrain { get { return false; } }

        public static bool DisableFleeing { get { return true; } }

        public static bool DisableElectricityFlee { get { return true; } }

        public static bool CanFeed { get { return false; } }

        public static float PlayerPrioritizationMultiplier { get { return 3f; } }

        public static float AggressionMultiplier { get { return 3f; } }

        public static bool AllowFriends { get { return true; } }

        public static bool CanSeeInsideBases { get { return false; } }
    }
}
