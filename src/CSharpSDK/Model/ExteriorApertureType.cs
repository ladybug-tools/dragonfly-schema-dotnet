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
    public enum ExteriorApertureType
    {

        [EnumMember(Value = "Window")]
        [JsonProperty("Window")]       // Newtonsoft
        // [JsonPropertyName("Window")]                   // STJ
        Window = 1,

        [EnumMember(Value = "Skylight")]
        [JsonProperty("Skylight")]       // Newtonsoft
        // [JsonPropertyName("Skylight")]                   // STJ
        Skylight = 2,

        [EnumMember(Value = "All")]
        [JsonProperty("All")]       // Newtonsoft
        // [JsonPropertyName("All")]                   // STJ
        All = 3,

    }
 
}