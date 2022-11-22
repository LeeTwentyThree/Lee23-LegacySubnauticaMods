using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RisingLava.Mono.Equipment
{
    public class LavaMonitor : PlayerTool
    {
        public override string animToolName => TechType.Welder.AsString(true);

        public override string GetCustomUseText()
        {
            return string.Empty;
        }

        public override void OnToolUseAnim(GUIHand guiHand)
        {
            
        }

        public override bool GetUsedToolThisFrame()
        {
            return false;
        }
    }
}
