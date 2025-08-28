/* 
 * DragonflySchema
 *
 * Contact: info@ladybug.tools
 */

//using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBT.Newtonsoft.Json;
using LBT.Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;

namespace DragonflySchema
{
    /// <summary>
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [Summary(@"Base class for all objects requiring a identifiers acceptable for all engines.")]
    [System.Serializable]
    [DataContract(Name = "ContextShade")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class ContextShade : IDdBaseModel, System.IEquatable<ContextShade>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShade" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected ContextShade() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ContextShade";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShade" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be < 100 characters and not contain any spaces or special characters.</param>
        /// <param name="geometry">An array of planar Face3Ds and or Mesh3Ds that together represent the context shade.</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus).</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="isDetached">Boolean to note whether this shade is detached from any of the other geometry in the model. Cases where this should be True include shade representing surrounding buildings or context.</param>
        public ContextShade
        (
            string identifier, List<AnyOf<Face3D, Mesh3D>> geometry, ContextShadePropertiesAbridged properties, string displayName = default, object userData = default, bool isDetached = true
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.Geometry = geometry ?? throw new System.ArgumentNullException("geometry is a required property for ContextShade and cannot be null");
            this.Properties = properties ?? throw new System.ArgumentNullException("properties is a required property for ContextShade and cannot be null");
            this.IsDetached = isDetached;

            // Set readonly properties with defaultValue
            this.Type = "ContextShade";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ContextShade))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// An array of planar Face3Ds and or Mesh3Ds that together represent the context shade.
        /// </summary>
        [Summary(@"An array of planar Face3Ds and or Mesh3Ds that together represent the context shade.")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "geometry", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("geometry", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("geometry")] // For System.Text.Json
        public List<AnyOf<Face3D, Mesh3D>> Geometry { get; set; }

        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        [Summary(@"Extension properties for particular simulation engines (Radiance, EnergyPlus).")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "properties", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("properties", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("properties")] // For System.Text.Json
        public ContextShadePropertiesAbridged Properties { get; set; }

        /// <summary>
        /// Boolean to note whether this shade is detached from any of the other geometry in the model. Cases where this should be True include shade representing surrounding buildings or context.
        /// </summary>
        [Summary(@"Boolean to note whether this shade is detached from any of the other geometry in the model. Cases where this should be True include shade representing surrounding buildings or context.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "is_detached")] // For internal Serialization XML/JSON
        [JsonProperty("is_detached", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("is_detached")] // For System.Text.Json
        public bool IsDetached { get; set; } = true;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ContextShade";
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
            sb.Append("ContextShade:\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  Geometry: ").Append(this.Geometry).Append("\n");
            sb.Append("  Properties: ").Append(this.Properties).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  IsDetached: ").Append(this.IsDetached).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ContextShade object</returns>
        public static ContextShade FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ContextShade>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ContextShade object</returns>
        public virtual ContextShade DuplicateContextShade()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdBaseModel</returns>
        public override IDdBaseModel DuplicateIDdBaseModel()
        {
            return DuplicateContextShade();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ContextShade);
        }


        /// <summary>
        /// Returns true if ContextShade instances are equal
        /// </summary>
        /// <param name="input">Instance of ContextShade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContextShade input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.AllEquals(this.Geometry, input.Geometry) && 
                    Extension.Equals(this.Properties, input.Properties) && 
                    Extension.Equals(this.IsDetached, input.IsDetached);
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.IsDetached != null)
                    hashCode = hashCode * 59 + this.IsDetached.GetHashCode();
                return hashCode;
            }
        }


    }
}
