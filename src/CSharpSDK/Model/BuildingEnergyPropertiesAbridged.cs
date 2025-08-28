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
    /// Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.
    /// </summary>
    [Summary(@"Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.")]
    [System.Serializable]
    [DataContract(Name = "BuildingEnergyPropertiesAbridged")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class BuildingEnergyPropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<BuildingEnergyPropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingEnergyPropertiesAbridged" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected BuildingEnergyPropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "BuildingEnergyPropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="constructionSet">Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used.</param>
        /// <param name="ceilingPlenumConstruction">Identifier of an OpaqueConstruction for the bottoms of ceiling plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple acoustic tile construction.</param>
        /// <param name="floorPlenumConstruction">Identifier of an OpaqueConstruction for the tops of floor plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple wood plank construction.</param>
        public BuildingEnergyPropertiesAbridged
        (
            string constructionSet = default, string ceilingPlenumConstruction = default, string floorPlenumConstruction = default
        ) : base()
        {
            this.ConstructionSet = constructionSet;
            this.CeilingPlenumConstruction = ceilingPlenumConstruction;
            this.FloorPlenumConstruction = floorPlenumConstruction;

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
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "construction_set")] // For internal Serialization XML/JSON
        [JsonProperty("construction_set", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("construction_set")] // For System.Text.Json
        public string ConstructionSet { get; set; }

        /// <summary>
        /// Identifier of an OpaqueConstruction for the bottoms of ceiling plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple acoustic tile construction.
        /// </summary>
        [Summary(@"Identifier of an OpaqueConstruction for the bottoms of ceiling plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple acoustic tile construction.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "ceiling_plenum_construction")] // For internal Serialization XML/JSON
        [JsonProperty("ceiling_plenum_construction", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("ceiling_plenum_construction")] // For System.Text.Json
        public string CeilingPlenumConstruction { get; set; }

        /// <summary>
        /// Identifier of an OpaqueConstruction for the tops of floor plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple wood plank construction.
        /// </summary>
        [Summary(@"Identifier of an OpaqueConstruction for the tops of floor plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple wood plank construction.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "floor_plenum_construction")] // For internal Serialization XML/JSON
        [JsonProperty("floor_plenum_construction", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("floor_plenum_construction")] // For System.Text.Json
        public string FloorPlenumConstruction { get; set; }


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
            sb.Append("  CeilingPlenumConstruction: ").Append(this.CeilingPlenumConstruction).Append("\n");
            sb.Append("  FloorPlenumConstruction: ").Append(this.FloorPlenumConstruction).Append("\n");
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
                    Extension.Equals(this.ConstructionSet, input.ConstructionSet) && 
                    Extension.Equals(this.CeilingPlenumConstruction, input.CeilingPlenumConstruction) && 
                    Extension.Equals(this.FloorPlenumConstruction, input.FloorPlenumConstruction);
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
                if (this.CeilingPlenumConstruction != null)
                    hashCode = hashCode * 59 + this.CeilingPlenumConstruction.GetHashCode();
                if (this.FloorPlenumConstruction != null)
                    hashCode = hashCode * 59 + this.FloorPlenumConstruction.GetHashCode();
                return hashCode;
            }
        }


    }
}
