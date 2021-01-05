/* 
 * Dragonfly Model Schema
 *
 * Documentation for Dragonfly model schema
 *
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
using HoneybeeSchema;
using System.ComponentModel.DataAnnotations;


namespace DragonflySchema
{
    /// <summary>
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract(Name = "_EquipmentBase")]
    public partial class EquipmentBase : IEquatable<EquipmentBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EquipmentBase() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "_EquipmentBase";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EquipmentBase" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="wattsPerArea">Equipment level per floor area as [W/m2]. (required).</param>
        /// <param name="schedule">Identifier of the schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile. (required).</param>
        /// <param name="radiantFraction">Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0. (default to 0D).</param>
        /// <param name="latentFraction">Number for the amount of latent heat given off by electricequipment. Default value is 0. (default to 0D).</param>
        /// <param name="lostFraction">Number for the amount of “lost” heat being given off by equipment. The default value is 0. (default to 0D).</param>
        public EquipmentBase
        (
             string identifier, double wattsPerArea, string schedule, // Required parameters
            string displayName= default, double radiantFraction = 0D, double latentFraction = 0D, double lostFraction = 0D// Optional parameters
        )// BaseClass
        {
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for EquipmentBase and cannot be null");
            this.WattsPerArea = wattsPerArea;
            // to ensure "schedule" is required (not null)
            this.Schedule = schedule ?? throw new ArgumentNullException("schedule is a required property for EquipmentBase and cannot be null");
            this.DisplayName = displayName;
            this.RadiantFraction = radiantFraction;
            this.LatentFraction = latentFraction;
            this.LostFraction = lostFraction;

            // Set non-required readonly properties with defaultValue
            this.Type = "_EquipmentBase";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "_EquipmentBase";

        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; } 
        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; } 
        /// <summary>
        /// Equipment level per floor area as [W/m2].
        /// </summary>
        /// <value>Equipment level per floor area as [W/m2].</value>
        [DataMember(Name = "watts_per_area", IsRequired = true)]
        public double WattsPerArea { get; set; } 
        /// <summary>
        /// Identifier of the schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.
        /// </summary>
        /// <value>Identifier of the schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.</value>
        [DataMember(Name = "schedule", IsRequired = true)]
        public string Schedule { get; set; } 
        /// <summary>
        /// Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0.
        /// </summary>
        /// <value>Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0.</value>
        [DataMember(Name = "radiant_fraction")]
        public double RadiantFraction { get; set; }  = 0D;
        /// <summary>
        /// Number for the amount of latent heat given off by electricequipment. Default value is 0.
        /// </summary>
        /// <value>Number for the amount of latent heat given off by electricequipment. Default value is 0.</value>
        [DataMember(Name = "latent_fraction")]
        public double LatentFraction { get; set; }  = 0D;
        /// <summary>
        /// Number for the amount of “lost” heat being given off by equipment. The default value is 0.
        /// </summary>
        /// <value>Number for the amount of “lost” heat being given off by equipment. The default value is 0.</value>
        [DataMember(Name = "lost_fraction")]
        public double LostFraction { get; set; }  = 0D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "EquipmentBase";
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
            sb.Append("EquipmentBase:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  WattsPerArea: ").Append(WattsPerArea).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  RadiantFraction: ").Append(RadiantFraction).Append("\n");
            sb.Append("  LatentFraction: ").Append(LatentFraction).Append("\n");
            sb.Append("  LostFraction: ").Append(LostFraction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>EquipmentBase object</returns>
        public static EquipmentBase FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<EquipmentBase>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>EquipmentBase object</returns>
        public virtual EquipmentBase DuplicateEquipmentBase()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateEquipmentBase();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as EquipmentBase);
        }

        /// <summary>
        /// Returns true if EquipmentBase instances are equal
        /// </summary>
        /// <param name="input">Instance of EquipmentBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EquipmentBase input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.WattsPerArea != null)
                    hashCode = hashCode * 59 + this.WattsPerArea.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.RadiantFraction != null)
                    hashCode = hashCode * 59 + this.RadiantFraction.GetHashCode();
                if (this.LatentFraction != null)
                    hashCode = hashCode * 59 + this.LatentFraction.GetHashCode();
                if (this.LostFraction != null)
                    hashCode = hashCode * 59 + this.LostFraction.GetHashCode();
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

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^_EquipmentBase$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

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

            // Schedule (string) maxLength
            if(this.Schedule != null && this.Schedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be less than 100.", new [] { "Schedule" });
            }

            // Schedule (string) minLength
            if(this.Schedule != null && this.Schedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be greater than 1.", new [] { "Schedule" });
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

            yield break;
        }
    }
}
