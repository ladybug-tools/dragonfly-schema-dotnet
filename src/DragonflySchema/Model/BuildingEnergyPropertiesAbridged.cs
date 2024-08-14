/* 
 * DragonflySchema
 *
 * Contact: info@ladybug.tools
 */

extern alias LBTNewtonSoft;
//using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonSoft::Newtonsoft.Json;
using LBTNewtonSoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;

namespace DragonflySchema
{
    /// <summary>
    /// Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.
    /// </summary>
    [Summary(@"Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.")]
    [System.Serializable]
    [DataContract(Name = "BuildingEnergyPropertiesAbridged")]
    public partial class BuildingEnergyPropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<BuildingEnergyPropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingEnergyPropertiesAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BuildingEnergyPropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "BuildingEnergyPropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="constructionSet">Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used.</param>
        public BuildingEnergyPropertiesAbridged
        (
            string constructionSet = default
        ) : base()
        {
            this.ConstructionSet = constructionSet;

            // Set readonly properties with defaultValue
            this.Type = "BuildingEnergyPropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(BuildingEnergyPropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used.
        /// </summary>
        [Summary(@"Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used.")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "construction_set")]
        public string ConstructionSet { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "BuildingEnergyPropertiesAbridged";
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
            sb.Append("BuildingEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ConstructionSet: ").Append(this.ConstructionSet).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>BuildingEnergyPropertiesAbridged object</returns>
        public static BuildingEnergyPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<BuildingEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>BuildingEnergyPropertiesAbridged object</returns>
        public virtual BuildingEnergyPropertiesAbridged DuplicateBuildingEnergyPropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateBuildingEnergyPropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as BuildingEnergyPropertiesAbridged);
        }


        /// <summary>
        /// Returns true if BuildingEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildingEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildingEnergyPropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.ConstructionSet, input.ConstructionSet);
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
                if (this.ConstructionSet != null)
                    hashCode = hashCode * 59 + this.ConstructionSet.GetHashCode();
                return hashCode;
            }
        }


    }
}
