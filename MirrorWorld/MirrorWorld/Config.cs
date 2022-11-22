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
        [Slider(Label = "Shallows depth (for Y flip)", Tooltip = "The depth of shallow areas of the map, also used for the lifepod spawn level.", DefaultValue = -2048f, Min = -2048, Max = 0, Step = 16)]
        public float shallowsYLevel = -2048f;
    }
}
