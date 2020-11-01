/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.6.12
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
    /// Base class for all-air systems.
    /// </summary>
    [DataContract]
    public partial class AllAirBase : IDdEnergyBaseModel, IEquatable<AllAirBase>, IValidatableObject
    {

        /// <summary>
        /// Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards
        /// </summary>
        /// <value>Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards</value>
        [DataMember(Name="vintage", EmitDefaultValue=false)]
        public Vintages? Vintage { get; set; }   
        /// <summary>
        /// Text to indicate the type of air-side economizer used on the system (from the AllAirEconomizerType enumeration). If Inferred, the economizer will be set to whatever is recommended for the given vintage.
        /// </summary>
        /// <value>Text to indicate the type of air-side economizer used on the system (from the AllAirEconomizerType enumeration). If Inferred, the economizer will be set to whatever is recommended for the given vintage.</value>
        [DataMember(Name="economizer_type", EmitDefaultValue=false)]
        public AllAirEconomizerType? EconomizerType { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="AllAirBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AllAirBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AllAirBase" /> class.
        /// </summary>
        /// <param name="vintage">Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards.</param>
        /// <param name="economizerType">Text to indicate the type of air-side economizer used on the system (from the AllAirEconomizerType enumeration). If Inferred, the economizer will be set to whatever is recommended for the given vintage..</param>
        /// <param name="sensibleHeatRecovery">A number between 0 and 1 for the effectiveness of sensible heat recovery within the system. If None or Autosize, it will be whatever is recommended for the given vintage..</param>
        /// <param name="latentHeatRecovery">A number between 0 and 1 for the effectiveness of latent heat recovery within the system. If None or Autosize, it will be whatever is recommended for the given vintage..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public AllAirBase
        (
            string identifier, // Required parameters
            string displayName= default, Vintages? vintage= default, AllAirEconomizerType? economizerType= default, AnyOf<Autosize,double> sensibleHeatRecovery= default, AnyOf<Autosize,double> latentHeatRecovery= default // Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.Vintage = vintage;
            this.EconomizerType = economizerType;
            this.SensibleHeatRecovery = sensibleHeatRecovery;
            this.LatentHeatRecovery = latentHeatRecovery;

            // Set non-required readonly properties with defaultValue
            this.Type = "_AllAirBase";
        }
        
        /// <summary>
        /// A number between 0 and 1 for the effectiveness of sensible heat recovery within the system. If None or Autosize, it will be whatever is recommended for the given vintage.
        /// </summary>
        /// <value>A number between 0 and 1 for the effectiveness of sensible heat recovery within the system. If None or Autosize, it will be whatever is recommended for the given vintage.</value>
        [DataMember(Name="sensible_heat_recovery", EmitDefaultValue=false)]
        [JsonProperty("sensible_heat_recovery")]
        public AnyOf<Autosize,double> SensibleHeatRecovery { get; set; } 
        /// <summary>
        /// A number between 0 and 1 for the effectiveness of latent heat recovery within the system. If None or Autosize, it will be whatever is recommended for the given vintage.
        /// </summary>
        /// <value>A number between 0 and 1 for the effectiveness of latent heat recovery within the system. If None or Autosize, it will be whatever is recommended for the given vintage.</value>
        [DataMember(Name="latent_heat_recovery", EmitDefaultValue=false)]
        [JsonProperty("latent_heat_recovery")]
        public AnyOf<Autosize,double> LatentHeatRecovery { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"AllAirBase {iDd.Identifier}";
       
            return "AllAirBase";
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
            sb.Append("AllAirBase:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Vintage: ").Append(Vintage).Append("\n");
            sb.Append("  EconomizerType: ").Append(EconomizerType).Append("\n");
            sb.Append("  SensibleHeatRecovery: ").Append(SensibleHeatRecovery).Append("\n");
            sb.Append("  LatentHeatRecovery: ").Append(LatentHeatRecovery).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>AllAirBase object</returns>
        public static AllAirBase FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<AllAirBase>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>AllAirBase object</returns>
        public AllAirBase DuplicateAllAirBase()
        {
            return Duplicate() as AllAirBase;
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
            return this.Equals(input as AllAirBase);
        }

        /// <summary>
        /// Returns true if AllAirBase instances are equal
        /// </summary>
        /// <param name="input">Instance of AllAirBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllAirBase input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Vintage == input.Vintage ||
                    (this.Vintage != null &&
                    this.Vintage.Equals(input.Vintage))
                ) && base.Equals(input) && 
                (
                    this.EconomizerType == input.EconomizerType ||
                    (this.EconomizerType != null &&
                    this.EconomizerType.Equals(input.EconomizerType))
                ) && base.Equals(input) && 
                (
                    this.SensibleHeatRecovery == input.SensibleHeatRecovery ||
                    (this.SensibleHeatRecovery != null &&
                    this.SensibleHeatRecovery.Equals(input.SensibleHeatRecovery))
                ) && base.Equals(input) && 
                (
                    this.LatentHeatRecovery == input.LatentHeatRecovery ||
                    (this.LatentHeatRecovery != null &&
                    this.LatentHeatRecovery.Equals(input.LatentHeatRecovery))
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
                if (this.Vintage != null)
                    hashCode = hashCode * 59 + this.Vintage.GetHashCode();
                if (this.EconomizerType != null)
                    hashCode = hashCode * 59 + this.EconomizerType.GetHashCode();
                if (this.SensibleHeatRecovery != null)
                    hashCode = hashCode * 59 + this.SensibleHeatRecovery.GetHashCode();
                if (this.LatentHeatRecovery != null)
                    hashCode = hashCode * 59 + this.LatentHeatRecovery.GetHashCode();
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
            Regex regexType = new Regex(@"^_AllAirBase$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
