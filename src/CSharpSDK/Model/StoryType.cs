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
    public enum StoryType
    {

        [EnumMember(Value = "Standard")]
        [JsonProperty("Standard")]       // Newtonsoft
        // [JsonPropertyName("Standard")]                   // STJ
        Standard = 1,

        [EnumMember(Value = "CeilingPlenum")]
        [JsonProperty("CeilingPlenum")]       // Newtonsoft
        // [JsonPropertyName("CeilingPlenum")]                   // STJ
        CeilingPlenum = 2,

        [EnumMember(Value = "FloorPlenum")]
        [JsonProperty("FloorPlenum")]       // Newtonsoft
        // [JsonPropertyName("FloorPlenum")]                   // STJ
        FloorPlenum = 3,

    }
 
}