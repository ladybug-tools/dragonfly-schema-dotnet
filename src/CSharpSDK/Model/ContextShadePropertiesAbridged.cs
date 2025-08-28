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
    [Summary(@"")]
    [System.Serializable]
    [DataContract(Name = "ContextShadePropertiesAbridged")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class ContextShadePropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<ContextShadePropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShadePropertiesAbridged" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected ContextShadePropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ContextShadePropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShadePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="energy">Energy</param>
        /// <param name="radiance">Radiance</param>
        public ContextShadePropertiesAbridged
        (
            ContextShadeEnergyPropertiesAbridged energy = default, ContextShadeRadiancePropertiesAbridged radiance = default
        ) : base()
        {
            this.Energy = energy;
            this.Radiance = radiance;

            // Set readonly properties with defaultValue
            this.Type = "ContextShadePropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ContextShadePropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Energy
        /// </summary>
        [Summary(@"Energy")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "energy")] // For internal Serialization XML/JSON
        [JsonProperty("energy", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("energy")] // For System.Text.Json
        public ContextShadeEnergyPropertiesAbridged Energy { get; set; }

        /// <summary>
        /// Radiance
        /// </summary>
        [Summary(@"Radiance")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "radiance")] // For internal Serialization XML/JSON
        [JsonProperty("radiance", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("radiance")] // For System.Text.Json
        public ContextShadeRadiancePropertiesAbridged Radiance { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ContextShadePropertiesAbridged";
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
            sb.Append("ContextShadePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Energy: ").Append(this.Energy).Append("\n");
            sb.Append("  Radiance: ").Append(this.Radiance).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ContextShadePropertiesAbridged object</returns>
        public static ContextShadePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ContextShadePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ContextShadePropertiesAbridged object</returns>
        public virtual ContextShadePropertiesAbridged DuplicateContextShadePropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateContextShadePropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ContextShadePropertiesAbridged);
        }


        /// <summary>
        /// Returns true if ContextShadePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ContextShadePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContextShadePropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Energy, input.Energy) && 
                    Extension.Equals(this.Radiance, input.Radiance);
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
                if (this.Energy != null)
                    hashCode = hashCode * 59 + this.Energy.GetHashCode();
                if (this.Radiance != null)
                    hashCode = hashCode * 59 + this.Radiance.GetHashCode();
                return hashCode;
            }
        }


    }
}
