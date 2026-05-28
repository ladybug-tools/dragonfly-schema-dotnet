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
    /// Geometry for specifying sloped roofs over a Story.
    /// </summary>
    [Summary(@"Geometry for specifying sloped roofs over a Story.")]
    [System.Serializable]
    [DataContract(Name = "RoofSpecification")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class RoofSpecification : OpenAPIGenBaseModel, System.IEquatable<RoofSpecification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoofSpecification" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected RoofSpecification() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "RoofSpecification";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoofSpecification" /> class.
        /// </summary>
        /// <param name="geometry">An array of Face3D (or Mesh3D) objects representing the geometry of the Roof. Cases where Room2Ds are only partially covered by these roof geometries will result in those portions of the Room2Ds being extruded to their floor_to_ceiling_height.</param>
        /// <param name="clearstoryParameters">A list of ClearstoryParameter objects that dictate how to generate window geometries for any vertical walls that result from the translation of roof geometry. If None, no clearstory windows will exist over the roof.</param>
        public RoofSpecification
        (
            List<AnyOf<Face3D, Mesh3D>> geometry, List<DetailedClearstory> clearstoryParameters = default
        ) : base()
        {
            this.Geometry = geometry ?? throw new System.ArgumentNullException("geometry is a required property for RoofSpecification and cannot be null");
            this.ClearstoryParameters = clearstoryParameters;

            // Set readonly properties with defaultValue
            this.Type = "RoofSpecification";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(RoofSpecification))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// An array of Face3D (or Mesh3D) objects representing the geometry of the Roof. Cases where Room2Ds are only partially covered by these roof geometries will result in those portions of the Room2Ds being extruded to their floor_to_ceiling_height.
        /// </summary>
        [Summary(@"An array of Face3D (or Mesh3D) objects representing the geometry of the Roof. Cases where Room2Ds are only partially covered by these roof geometries will result in those portions of the Room2Ds being extruded to their floor_to_ceiling_height.")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "geometry", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("geometry", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("geometry")] // For System.Text.Json
        public List<AnyOf<Face3D, Mesh3D>> Geometry { get; set; }

        /// <summary>
        /// A list of ClearstoryParameter objects that dictate how to generate window geometries for any vertical walls that result from the translation of roof geometry. If None, no clearstory windows will exist over the roof.
        /// </summary>
        [Summary(@"A list of ClearstoryParameter objects that dictate how to generate window geometries for any vertical walls that result from the translation of roof geometry. If None, no clearstory windows will exist over the roof.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "clearstory_parameters")] // For internal Serialization XML/JSON
        [JsonProperty("clearstory_parameters", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("clearstory_parameters")] // For System.Text.Json
        public List<DetailedClearstory> ClearstoryParameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RoofSpecification";
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
            sb.Append("RoofSpecification:\n");
            sb.Append("  Geometry: ").Append(this.Geometry).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ClearstoryParameters: ").Append(this.ClearstoryParameters).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RoofSpecification object</returns>
        public static RoofSpecification FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RoofSpecification>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RoofSpecification object</returns>
        public virtual RoofSpecification DuplicateRoofSpecification()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRoofSpecification();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RoofSpecification);
        }


        /// <summary>
        /// Returns true if RoofSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of RoofSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoofSpecification input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.AllEquals(this.Geometry, input.Geometry) && 
                    Extension.AllEquals(this.ClearstoryParameters, input.ClearstoryParameters);
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
                if (this.ClearstoryParameters != null)
                    hashCode = hashCode * 59 + this.ClearstoryParameters.GetHashCode();
                return hashCode;
            }
        }


    }
}
