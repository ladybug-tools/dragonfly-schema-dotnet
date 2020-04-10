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
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract]
    public partial class ElectricEquipment :  IEquatable<ElectricEquipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEquipment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElectricEquipment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEquipment" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="wattsPerArea">Equipment level per floor area as [W/m2]. (required).</param>
        /// <param name="schedule">The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="radiantFraction">Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0. (default to 0).</param>
        /// <param name="latentFraction">Number for the amount of latent heat given off by electricequipment. Default value is 0. (default to 0).</param>
        /// <param name="lostFraction">Number for the amount of “lost” heat being given off by equipment. The default value is 0. (default to 0).</param>
        /// <param name="type">type (default to &quot;ElectricEquipment&quot;).</param>
        public ElectricEquipment(string identifier, double wattsPerArea, AnyOf<ScheduleRuleset,ScheduleFixedInterval> schedule, string displayName = default, double radiantFraction = 0, double latentFraction = 0, double lostFraction = 0, string type = "ElectricEquipment")
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for ElectricEquipment and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            
            // to ensure "wattsPerArea" is required (not null)
            if (wattsPerArea == null)
            {
                throw new InvalidDataException("wattsPerArea is a required property for ElectricEquipment and cannot be null");
            }
            else
            {
                this.WattsPerArea = wattsPerArea;
            }
            
            // to ensure "schedule" is required (not null)
            if (schedule == null)
            {
                throw new InvalidDataException("schedule is a required property for ElectricEquipment and cannot be null");
            }
            else
            {
                this.Schedule = schedule;
            }
            
            this.DisplayName = displayName;
            // use default value if no "radiantFraction" provided
            if (radiantFraction == null)
            {
                this.RadiantFraction = 0;
            }
            else
            {
                this.RadiantFraction = radiantFraction;
            }
            // use default value if no "latentFraction" provided
            if (latentFraction == null)
            {
                this.LatentFraction = 0;
            }
            else
            {
                this.LatentFraction = latentFraction;
            }
            // use default value if no "lostFraction" provided
            if (lostFraction == null)
            {
                this.LostFraction = 0;
            }
            else
            {
                this.LostFraction = lostFraction;
            }
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "ElectricEquipment";
            }
            else
            {
                this.Type = type;
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
        /// Equipment level per floor area as [W/m2].
        /// </summary>
        /// <value>Equipment level per floor area as [W/m2].</value>
        [DataMember(Name="watts_per_area", EmitDefaultValue=false)]
        [JsonProperty("watts_per_area")]
        public double WattsPerArea { get; set; }

        /// <summary>
        /// The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.
        /// </summary>
        /// <value>The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        [JsonProperty("schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> Schedule { get; set; }

        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0.
        /// </summary>
        /// <value>Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0.</value>
        [DataMember(Name="radiant_fraction", EmitDefaultValue=false)]
        [JsonProperty("radiant_fraction")]
        public double RadiantFraction { get; set; }

        /// <summary>
        /// Number for the amount of latent heat given off by electricequipment. Default value is 0.
        /// </summary>
        /// <value>Number for the amount of latent heat given off by electricequipment. Default value is 0.</value>
        [DataMember(Name="latent_fraction", EmitDefaultValue=false)]
        [JsonProperty("latent_fraction")]
        public double LatentFraction { get; set; }

        /// <summary>
        /// Number for the amount of “lost” heat being given off by equipment. The default value is 0.
        /// </summary>
        /// <value>Number for the amount of “lost” heat being given off by equipment. The default value is 0.</value>
        [DataMember(Name="lost_fraction", EmitDefaultValue=false)]
        [JsonProperty("lost_fraction")]
        public double LostFraction { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElectricEquipment {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  WattsPerArea: ").Append(WattsPerArea).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  RadiantFraction: ").Append(RadiantFraction).Append("\n");
            sb.Append("  LatentFraction: ").Append(LatentFraction).Append("\n");
            sb.Append("  LostFraction: ").Append(LostFraction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// <returns>ElectricEquipment object</returns>
        public static ElectricEquipment FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ElectricEquipment>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ElectricEquipment);
        }

        /// <summary>
        /// Returns true if ElectricEquipment instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectricEquipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectricEquipment input)
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
                    this.WattsPerArea == input.WattsPerArea ||
                    (this.WattsPerArea != null &&
                    this.WattsPerArea.Equals(input.WattsPerArea))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.RadiantFraction == input.RadiantFraction ||
                    (this.RadiantFraction != null &&
                    this.RadiantFraction.Equals(input.RadiantFraction))
                ) && 
                (
                    this.LatentFraction == input.LatentFraction ||
                    (this.LatentFraction != null &&
                    this.LatentFraction.Equals(input.LatentFraction))
                ) && 
                (
                    this.LostFraction == input.LostFraction ||
                    (this.LostFraction != null &&
                    this.LostFraction.Equals(input.LostFraction))
                ) && 
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
                int hashCode = 41;
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.WattsPerArea != null)
                    hashCode = hashCode * 59 + this.WattsPerArea.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.RadiantFraction != null)
                    hashCode = hashCode * 59 + this.RadiantFraction.GetHashCode();
                if (this.LatentFraction != null)
                    hashCode = hashCode * 59 + this.LatentFraction.GetHashCode();
                if (this.LostFraction != null)
                    hashCode = hashCode * 59 + this.LostFraction.GetHashCode();
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

            // WattsPerArea (double) minimum
            if(this.WattsPerArea < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WattsPerArea, must be a value greater than or equal to 0.", new [] { "WattsPerArea" });
            }

            // RadiantFraction (double) maximum
            if(this.RadiantFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RadiantFraction, must be a value less than or equal to 1.", new [] { "RadiantFraction" });
            }

            // RadiantFraction (double) minimum
            if(this.RadiantFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RadiantFraction, must be a value greater than or equal to 0.", new [] { "RadiantFraction" });
            }

            // LatentFraction (double) maximum
            if(this.LatentFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LatentFraction, must be a value less than or equal to 1.", new [] { "LatentFraction" });
            }

            // LatentFraction (double) minimum
            if(this.LatentFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LatentFraction, must be a value greater than or equal to 0.", new [] { "LatentFraction" });
            }

            // LostFraction (double) maximum
            if(this.LostFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LostFraction, must be a value less than or equal to 1.", new [] { "LostFraction" });
            }

            // LostFraction (double) minimum
            if(this.LostFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LostFraction, must be a value greater than or equal to 0.", new [] { "LostFraction" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^ElectricEquipment$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
