/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.18
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
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract]
    public partial class ContextShadeEnergyPropertiesAbridged : HoneybeeObject, IEquatable<ContextShadeEnergyPropertiesAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShadeEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="construction">Name of a ShadeConstruction to set the reflectance and specularity of the ContextShade. If None, the the EnergyPlus default of 0.2 diffuse reflectance will be used..</param>
        /// <param name="transmittanceSchedule">Name of a schedule to set the transmittance of the ContextShade, which can vary throughout the simulation. If None, the ContextShade will be completely opaque..</param>
        public ContextShadeEnergyPropertiesAbridged
        (
             // Required parameters
            string construction= default, string transmittanceSchedule= default// Optional parameters
        )// BaseClass
        {
            this.Construction = construction;
            this.TransmittanceSchedule = transmittanceSchedule;

            // Set non-required readonly properties with defaultValue
            this.Type = "ContextShadeEnergyPropertiesAbridged";
        }
        
        /// <summary>
        /// Name of a ShadeConstruction to set the reflectance and specularity of the ContextShade. If None, the the EnergyPlus default of 0.2 diffuse reflectance will be used.
        /// </summary>
        /// <value>Name of a ShadeConstruction to set the reflectance and specularity of the ContextShade. If None, the the EnergyPlus default of 0.2 diffuse reflectance will be used.</value>
        [DataMember(Name="construction", EmitDefaultValue=false)]
        [JsonProperty("construction")]
        public string Construction { get; set; } 
        /// <summary>
        /// Name of a schedule to set the transmittance of the ContextShade, which can vary throughout the simulation. If None, the ContextShade will be completely opaque.
        /// </summary>
        /// <value>Name of a schedule to set the transmittance of the ContextShade, which can vary throughout the simulation. If None, the ContextShade will be completely opaque.</value>
        [DataMember(Name="transmittance_schedule", EmitDefaultValue=false)]
        [JsonProperty("transmittance_schedule")]
        public string TransmittanceSchedule { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ContextShadeEnergyPropertiesAbridged {iDd.Identifier}";
       
            return "ContextShadeEnergyPropertiesAbridged";
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
            sb.Append("ContextShadeEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Construction: ").Append(Construction).Append("\n");
            sb.Append("  TransmittanceSchedule: ").Append(TransmittanceSchedule).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ContextShadeEnergyPropertiesAbridged object</returns>
        public static ContextShadeEnergyPropertiesAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ContextShadeEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContextShadeEnergyPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if ContextShadeEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ContextShadeEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContextShadeEnergyPropertiesAbridged input)
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
                    this.Construction == input.Construction ||
                    (this.Construction != null &&
                    this.Construction.Equals(input.Construction))
                ) && 
                (
                    this.TransmittanceSchedule == input.TransmittanceSchedule ||
                    (this.TransmittanceSchedule != null &&
                    this.TransmittanceSchedule.Equals(input.TransmittanceSchedule))
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
                if (this.Construction != null)
                    hashCode = hashCode * 59 + this.Construction.GetHashCode();
                if (this.TransmittanceSchedule != null)
                    hashCode = hashCode * 59 + this.TransmittanceSchedule.GetHashCode();
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
            Regex regexType = new Regex(@"^ContextShadeEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Construction (string) maxLength
            if(this.Construction != null && this.Construction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be less than 100.", new [] { "Construction" });
            }

            // Construction (string) minLength
            if(this.Construction != null && this.Construction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be greater than 1.", new [] { "Construction" });
            }

            // TransmittanceSchedule (string) maxLength
            if(this.TransmittanceSchedule != null && this.TransmittanceSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransmittanceSchedule, length must be less than 100.", new [] { "TransmittanceSchedule" });
            }

            // TransmittanceSchedule (string) minLength
            if(this.TransmittanceSchedule != null && this.TransmittanceSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransmittanceSchedule, length must be greater than 1.", new [] { "TransmittanceSchedule" });
            }

            yield break;
        }
    }

}
