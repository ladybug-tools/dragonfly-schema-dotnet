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
    public enum ExteriorFaceType
    {

        [EnumMember(Value = "Wall")]
        Wall = 1,

        [EnumMember(Value = "Roof")]
        Roof = 2,

        [EnumMember(Value = "Floor")]
        Floor = 3,

        [EnumMember(Value = "All")]
        All = 4,

    }
 
}