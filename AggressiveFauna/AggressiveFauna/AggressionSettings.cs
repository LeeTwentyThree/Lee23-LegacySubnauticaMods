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
    }
}
