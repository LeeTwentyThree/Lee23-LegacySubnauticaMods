using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;

namespace MirrorWorld
{
    [Menu("Mirror World")]
    public class Config : ConfigFile
    {
        [Toggle(Label = "Mirror X-axis", Tooltip = "Flip the map about the X-axis\nWest <-> East")]
        public bool xAxis = false;
        [Toggle(Label = "Mirror Y-axis", Tooltip = "Flip the map about the Y-axis\nUp <-> Down")]
        public bool yAxis = true;
        [Toggle(Label = "Mirror Z-axis", Tooltip = "Flip the map about the Z-axis\nNorth <-> South")]
        public bool zAxis = false;
        [Toggle(Label = "Move escape pod")]
        public bool moveEscapePod = true;
        [Toggle(Label = "Flip escape pod")]
        public bool flipEscapePod = true;
    }
}
