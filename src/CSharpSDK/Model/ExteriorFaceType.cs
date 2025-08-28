/* 
 * DragonflySchema
 *
 * Contact: info@ladybug.tools
 */

 using System.Runtime.Serialization;
 // using System.Text.Json;
 // using System.Text.Json.Serialization;
 using LBT.Newtonsoft.Json;
 using LBT.Newtonsoft.Json.Converters;

namespace DragonflySchema
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    // Shared enum across all serializers
    [DataContract] // For DataContractSerializer
    [JsonConverter(typeof(StringEnumConverter))] // Newtonsoft string form
    // [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))] // STJ string form
    public enum ExteriorFaceType
    {

        [EnumMember(Value = "Wall")]
        [JsonProperty("Wall")]       // Newtonsoft
        // [JsonPropertyName("Wall")]                   // STJ
        Wall = 1,

        [EnumMember(Value = "Roof")]
        [JsonProperty("Roof")]       // Newtonsoft
        // [JsonPropertyName("Roof")]                   // STJ
        Roof = 2,

        [EnumMember(Value = "Floor")]
        [JsonProperty("Floor")]       // Newtonsoft
        // [JsonPropertyName("Floor")]                   // STJ
        Floor = 3,

        [EnumMember(Value = "All")]
        [JsonProperty("All")]       // Newtonsoft
        // [JsonPropertyName("All")]                   // STJ
        All = 4,

    }
 
}