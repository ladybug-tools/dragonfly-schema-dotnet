/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.6.7
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
    public partial class Model : IDdBaseModel, IEquatable<Model>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public Units? Units { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Model() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="buildings">A list of Buildings in the model. (required).</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="version">Text string for the current version of the schema. (default to &quot;1.6.7&quot;).</param>
        /// <param name="contextShades">A list of ContextShades in the model..</param>
        /// <param name="units">units.</param>
        /// <param name="tolerance">The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters. (default to 0.01D).</param>
        /// <param name="angleTolerance">The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model. (default to 1.0D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public Model
        (
            string identifier, List<Building> buildings, ModelProperties properties, // Required parameters
            string displayName= default, Object userData= default, string version = "1.6.7", List<ContextShade> contextShades= default, Units? units= default, double tolerance = 0.01D, double angleTolerance = 1.0D// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData )// BaseClass
        {
            // to ensure "buildings" is required (not null)
            if (buildings == null)
            {
                throw new InvalidDataException("buildings is a required property for Model and cannot be null");
            }
            else
            {
                this.Buildings = buildings;
            }
            
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new InvalidDataException("properties is a required property for Model and cannot be null");
            }
            else
            {
                this.Properties = properties;
            }
            
            // use default value if no "version" provided
            if (version == null)
            {
                this.Version = "1.6.7";
            }
            else
            {
                this.Version = version;
            }
            this.ContextShades = contextShades;
            this.Units = units;
            // use default value if no "tolerance" provided
            if (tolerance == null)
            {
                this.Tolerance = 0.01D;
            }
            else
            {
                this.Tolerance = tolerance;
            }
            // use default value if no "angleTolerance" provided
            if (angleTolerance == null)
            {
                this.AngleTolerance = 1.0D;
            }
            else
            {
                this.AngleTolerance = angleTolerance;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "Model";
        }
        
        /// <summary>
        /// A list of Buildings in the model.
        /// </summary>
        /// <value>A list of Buildings in the model.</value>
        [DataMember(Name="buildings", EmitDefaultValue=false)]
        [JsonProperty("buildings")]
        public List<Building> Buildings { get; set; } 
        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        [JsonProperty("properties")]
        public ModelProperties Properties { get; set; } 
        /// <summary>
        /// Text string for the current version of the schema.
        /// </summary>
        /// <value>Text string for the current version of the schema.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        [JsonProperty("version")]
        public string Version { get; set; }  = "1.6.7";
        /// <summary>
        /// A list of ContextShades in the model.
        /// </summary>
        /// <value>A list of ContextShades in the model.</value>
        [DataMember(Name="context_shades", EmitDefaultValue=false)]
        [JsonProperty("context_shades")]
        public List<ContextShade> ContextShades { get; set; } 
        /// <summary>
        /// The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters.
        /// </summary>
        /// <value>The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters.</value>
        [DataMember(Name="tolerance", EmitDefaultValue=false)]
        [JsonProperty("tolerance")]
        public double Tolerance { get; set; }  = 0.01D;
        /// <summary>
        /// The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model.
        /// </summary>
        /// <value>The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model.</value>
        [DataMember(Name="angle_tolerance", EmitDefaultValue=false)]
        [JsonProperty("angle_tolerance")]
        public double AngleTolerance { get; set; }  = 1.0D;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Model {iDd.Identifier}";
       
            return "Model";
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
            sb.Append("Model:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Buildings: ").Append(Buildings).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ContextShades: ").Append(ContextShades).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  Tolerance: ").Append(Tolerance).Append("\n");
            sb.Append("  AngleTolerance: ").Append(AngleTolerance).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Model object</returns>
        public static Model FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Model>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Model object</returns>
        public Model DuplicateModel()
        {
            return Duplicate() as Model;
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
            return this.Equals(input as Model);
        }

        /// <summary>
        /// Returns true if Model instances are equal
        /// </summary>
        /// <param name="input">Instance of Model to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Buildings == input.Buildings ||
                    this.Buildings != null &&
                    input.Buildings != null &&
                    this.Buildings.SequenceEqual(input.Buildings)
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
                ) && base.Equals(input) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && base.Equals(input) && 
                (
                    this.ContextShades == input.ContextShades ||
                    this.ContextShades != null &&
                    input.ContextShades != null &&
                    this.ContextShades.SequenceEqual(input.ContextShades)
                ) && base.Equals(input) && 
                (
                    this.Units == input.Units ||
                    (this.Units != null &&
                    this.Units.Equals(input.Units))
                ) && base.Equals(input) && 
                (
                    this.Tolerance == input.Tolerance ||
                    (this.Tolerance != null &&
                    this.Tolerance.Equals(input.Tolerance))
                ) && base.Equals(input) && 
                (
                    this.AngleTolerance == input.AngleTolerance ||
                    (this.AngleTolerance != null &&
                    this.AngleTolerance.Equals(input.AngleTolerance))
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
                if (this.Buildings != null)
                    hashCode = hashCode * 59 + this.Buildings.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ContextShades != null)
                    hashCode = hashCode * 59 + this.ContextShades.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Tolerance != null)
                    hashCode = hashCode * 59 + this.Tolerance.GetHashCode();
                if (this.AngleTolerance != null)
                    hashCode = hashCode * 59 + this.AngleTolerance.GetHashCode();
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
            Regex regexType = new Regex(@"^Model$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Version (string) pattern
            Regex regexVersion = new Regex(@"([0-9]+)\\.([0-9]+)\\.([0-9]+)", RegexOptions.CultureInvariant);
            if (false == regexVersion.Match(this.Version).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Version, must match a pattern of " + regexVersion, new [] { "Version" });
            }

            // Tolerance (double) minimum
            if(this.Tolerance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Tolerance, must be a value greater than or equal to 0.", new [] { "Tolerance" });
            }

            // AngleTolerance (double) minimum
            if(this.AngleTolerance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AngleTolerance, must be a value greater than or equal to 0.", new [] { "AngleTolerance" });
            }

            yield break;
        }
    }
}
