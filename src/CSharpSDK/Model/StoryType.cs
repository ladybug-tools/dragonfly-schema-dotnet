/* 
 * DragonflySchema
 *
 * Contact: info@ladybug.tools
 */

 using System.Runtime.Serialization;
 using LBT.Newtonsoft.Json;
 using LBT.Newtonsoft.Json.Converters;

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