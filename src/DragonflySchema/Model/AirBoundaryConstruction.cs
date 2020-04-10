/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.0.0
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


namespace DragonflySchema
{
    /// <summary>
    /// Construction for Air Boundary objects.
    /// </summary>
    [DataContract]
    public partial class AirBoundaryConstruction :  IEquatable<AirBoundaryConstruction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AirBoundaryConstruction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AirBoundaryConstruction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirBoundaryConstruction" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="airMixingSchedule">A fractional schedule as a ScheduleRuleset or ScheduleFixedInterval for the air mixing schedule across the construction. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="type">type (default to &quot;AirBoundaryConstruction&quot;).</param>
        /// <param name="airMixingPerArea">A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system. (default to 0.1).</param>
        public AirBoundaryConstruction(string identifier, AnyOf<ScheduleRuleset,ScheduleFixedInterval> airMixingSchedule, string displayName = default, string type = "AirBoundaryConstruction", double airMixingPerArea = 0.1)
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for AirBoundaryConstruction and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            
            // to ensure "airMixingSchedule" is required (not null)
            if (airMixingSchedule == null)
            {
                throw new InvalidDataException("airMixingSchedule is a required property for AirBoundaryConstruction and cannot be null");
            }
            else
            {
                this.AirMixingSchedule = airMixingSchedule;
            }
            
            this.DisplayName = displayName;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "AirBoundaryConstruction";
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "airMixingPerArea" provided
            if (airMixingPerArea == null)
            {
                this.AirMixingPerArea = 0.1;
            }
            else
            {
                this.AirMixingPerArea = airMixingPerArea;
            }
        }
        
        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// A fractional schedule as a ScheduleRuleset or ScheduleFixedInterval for the air mixing schedule across the construction.
        /// </summary>
        /// <value>A fractional schedule as a ScheduleRuleset or ScheduleFixedInterval for the air mixing schedule across the construction.</value>
        [DataMember(Name="air_mixing_schedule", EmitDefaultValue=false)]
        [JsonProperty("air_mixing_schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> AirMixingSchedule { get; set; }

        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system.
        /// </summary>
        /// <value>A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system.</value>
        [DataMember(Name="air_mixing_per_area", EmitDefaultValue=false)]
        [JsonProperty("air_mixing_per_area")]
        public double AirMixingPerArea { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AirBoundaryConstruction {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  AirMixingSchedule: ").Append(AirMixingSchedule).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AirMixingPerArea: ").Append(AirMixingPerArea).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>AirBoundaryConstruction object</returns>
        public static AirBoundaryConstruction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AirBoundaryConstruction>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AirBoundaryConstruction);
        }

        /// <summary>
        /// Returns true if AirBoundaryConstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of AirBoundaryConstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirBoundaryConstruction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.AirMixingSchedule == input.AirMixingSchedule ||
                    (this.AirMixingSchedule != null &&
                    this.AirMixingSchedule.Equals(input.AirMixingSchedule))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AirMixingPerArea == input.AirMixingPerArea ||
                    (this.AirMixingPerArea != null &&
                    this.AirMixingPerArea.Equals(input.AirMixingPerArea))
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
                int hashCode = 41;
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.AirMixingSchedule != null)
                    hashCode = hashCode * 59 + this.AirMixingSchedule.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AirMixingPerArea != null)
                    hashCode = hashCode * 59 + this.AirMixingPerArea.GetHashCode();
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
            // Identifier (string) maxLength
            if(this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            // Identifier (string) minLength
            if(this.Identifier != null && this.Identifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be greater than 1.", new [] { "Identifier" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^AirBoundaryConstruction$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // AirMixingPerArea (double) minimum
            if(this.AirMixingPerArea < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirMixingPerArea, must be a value greater than or equal to 0.", new [] { "AirMixingPerArea" });
            }

            yield break;
        }
    }

}
