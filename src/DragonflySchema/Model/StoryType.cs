/* 
 * DragonflySchema
 *
 * Contact: info@ladybug.tools
 */

 extern alias LBTNewtonSoft;
 using System.Runtime.Serialization;
 using LBTNewtonSoft::Newtonsoft.Json;
 using LBTNewtonSoft::Newtonsoft.Json.Converters;

namespace DragonflySchema
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StoryType
    {

        [EnumMember(Value = "Standard")]
        Standard = 1,

        [EnumMember(Value = "CeilingPlenum")]
        CeilingPlenum = 2,

        [EnumMember(Value = "FloorPlenum")]
        FloorPlenum = 3,

    }
 
}