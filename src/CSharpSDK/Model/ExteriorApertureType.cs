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
    public enum ExteriorApertureType
    {

        [EnumMember(Value = "Window")]
        Window = 1,

        [EnumMember(Value = "Skylight")]
        Skylight = 2,

        [EnumMember(Value = "All")]
        All = 3,

    }
 
}