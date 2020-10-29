/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.6.9
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;


namespace DragonflySchema
{
    /// <summary>
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [DataContract]
    public partial class Building : IDdBaseModel, IEquatable<Building>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Building" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Building() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Building" /> class.
        /// </summary>
        /// <param name="uniqueStories">An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor. Note that, if a given Story is repeated several times over the height of the building, the unique story included in this list should be the first (lowest) story of the repeated floors. (required).</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public Building
        (
            string identifier, List<Story> uniqueStories, BuildingPropertiesAbridged properties, // Required parameters
            string displayName= default, Object userData= default // Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData )// BaseClass
        {
            // to ensure "uniqueStories" is required (not null)
            if (uniqueStories == null)
            {
                throw new InvalidDataException("uniqueStories is a required property for Building and cannot be null");
            }
            else
            {
                this.UniqueStories = uniqueStories;
            }
            
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new InvalidDataException("properties is a required property for Building and cannot be null");
            }
            else
            {
                this.Properties = properties;
            }
            

            // Set non-required readonly properties with defaultValue
            this.Type = "Building";
        }
        
        /// <summary>
        /// An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor. Note that, if a given Story is repeated several times over the height of the building, the unique story included in this list should be the first (lowest) story of the repeated floors.
        /// </summary>
        /// <value>An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor. Note that, if a given Story is repeated several times over the height of the building, the unique story included in this list should be the first (lowest) story of the repeated floors.</value>
        [DataMember(Name="unique_stories", EmitDefaultValue=false)]
        [JsonProperty("unique_stories")]
        public List<Story> UniqueStories { get; set; } 
        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        [JsonProperty("properties")]
        public BuildingPropertiesAbridged Properties { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Building {iDd.Identifier}";
       
            return "Building";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("Building:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UniqueStories: ").Append(UniqueStories).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Building object</returns>
        public static Building FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Building>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Building object</returns>
        public Building DuplicateBuilding()
        {
            return Duplicate() as Building;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HoneybeeObject</returns>
        public override HoneybeeObject Duplicate()
        {
            return FromJson(this.ToJson());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Building);
        }

        /// <summary>
        /// Returns true if Building instances are equal
        /// </summary>
        /// <param name="input">Instance of Building to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Building input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.UniqueStories == input.UniqueStories ||
                    this.UniqueStories != null &&
                    input.UniqueStories != null &&
                    this.UniqueStories.SequenceEqual(input.UniqueStories)
                ) && base.Equals(input) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.UniqueStories != null)
                    hashCode = hashCode * 59 + this.UniqueStories.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // Type (string) pattern
            Regex regexType = new Regex(@"^Building$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
