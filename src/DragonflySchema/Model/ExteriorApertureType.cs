/* 
 * Honeybee Schema
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