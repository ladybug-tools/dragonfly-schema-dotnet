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
    [DataContract(Name = "BuildingPropertiesAbridged")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class BuildingPropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<BuildingPropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingPropertiesAbridged" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected BuildingPropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "BuildingPropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="energy">Energy</param>
        /// <param name="radiance">Radiance</param>
        public BuildingPropertiesAbridged
        (
            BuildingEnergyPropertiesAbridged energy = default, BuildingRadiancePropertiesAbridged radiance = default
        ) : base()
        {
            this.Energy = energy;
            this.Radiance = radiance;

            // Set readonly properties with defaultValue
            this.Type = "BuildingPropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(BuildingPropertiesAbridged))
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
        public BuildingEnergyPropertiesAbridged Energy { get; set; }

        /// <summary>
        /// Radiance
        /// </summary>
        [Summary(@"Radiance")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "radiance")] // For internal Serialization XML/JSON
        [JsonProperty("radiance", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("radiance")] // For System.Text.Json
        public BuildingRadiancePropertiesAbridged Radiance { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "BuildingPropertiesAbridged";
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
            sb.Append("BuildingPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Energy: ").Append(this.Energy).Append("\n");
            sb.Append("  Radiance: ").Append(this.Radiance).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>BuildingPropertiesAbridged object</returns>
        public static BuildingPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BuildingPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BuildingPropertiesAbridged object</returns>
        public virtual BuildingPropertiesAbridged DuplicateBuildingPropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateBuildingPropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as BuildingPropertiesAbridged);
        }


        /// <summary>
        /// Returns true if BuildingPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildingPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildingPropertiesAbridged input)
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
