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
    /// Instructions for detailed clearstory windows, defined by 2D Polygons.
    /// </summary>
    [Summary(@"Instructions for detailed clearstory windows, defined by 2D Polygons.")]
    [System.Serializable]
    [DataContract(Name = "DetailedClearstory")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class DetailedClearstory : OpenAPIGenBaseModel, System.IEquatable<DetailedClearstory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedClearstory" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected DetailedClearstory() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "DetailedClearstory";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedClearstory" /> class.
        /// </summary>
        /// <param name="baseLine">An array of two sub-arrays with each sub-array representing the start and end point of a 2D line segment in the world XY system. This establishes the plane and domain in which the clearstory geometries exist.</param>
        /// <param name="elevation">A number for the Z-coordinate that places the base_line and the corresponding clearstory window polygons in 3D space. This elevation value should be below all of the 3D clearstory window geometries and helps set the origin of the plane in which the clearstory geometry exists.</param>
        /// <param name="polygons">An array of arrays with each sub-array representing a polygonal boundary of a clearstory window or door. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the plane defined by the base_line. The base_line plane is assumed to have an origin at the end point of the line segment (the second point) and an X-axis extending along the length of the segment. The Y-axis of the plane always points upwards. Therefore, both X and Y coordinates of the points in each polygon should be positive.</param>
        /// <param name="areDoors">An array of booleans that align with the polygons and note whether each of the polygons represents a door out onto a roof or balcony (True) or a clearstory window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model</param>
        public DetailedClearstory
        (
            List<List<double>> baseLine, double elevation, List<List<List<double>>> polygons, List<bool> areDoors = default
        ) : base()
        {
            this.BaseLine = baseLine ?? throw new System.ArgumentNullException("baseLine is a required property for DetailedClearstory and cannot be null");
            this.Elevation = elevation;
            this.Polygons = polygons ?? throw new System.ArgumentNullException("polygons is a required property for DetailedClearstory and cannot be null");
            this.AreDoors = areDoors;

            // Set readonly properties with defaultValue
            this.Type = "DetailedClearstory";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(DetailedClearstory))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// An array of two sub-arrays with each sub-array representing the start and end point of a 2D line segment in the world XY system. This establishes the plane and domain in which the clearstory geometries exist.
        /// </summary>
        [Summary(@"An array of two sub-arrays with each sub-array representing the start and end point of a 2D line segment in the world XY system. This establishes the plane and domain in which the clearstory geometries exist.")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "base_line", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("base_line", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("base_line")] // For System.Text.Json
        public List<List<double>> BaseLine { get; set; }

        /// <summary>
        /// A number for the Z-coordinate that places the base_line and the corresponding clearstory window polygons in 3D space. This elevation value should be below all of the 3D clearstory window geometries and helps set the origin of the plane in which the clearstory geometry exists.
        /// </summary>
        [Summary(@"A number for the Z-coordinate that places the base_line and the corresponding clearstory window polygons in 3D space. This elevation value should be below all of the 3D clearstory window geometries and helps set the origin of the plane in which the clearstory geometry exists.")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "elevation", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("elevation", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("elevation")] // For System.Text.Json
        public double Elevation { get; set; }

        /// <summary>
        /// An array of arrays with each sub-array representing a polygonal boundary of a clearstory window or door. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the plane defined by the base_line. The base_line plane is assumed to have an origin at the end point of the line segment (the second point) and an X-axis extending along the length of the segment. The Y-axis of the plane always points upwards. Therefore, both X and Y coordinates of the points in each polygon should be positive.
        /// </summary>
        [Summary(@"An array of arrays with each sub-array representing a polygonal boundary of a clearstory window or door. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the plane defined by the base_line. The base_line plane is assumed to have an origin at the end point of the line segment (the second point) and an X-axis extending along the length of the segment. The Y-axis of the plane always points upwards. Therefore, both X and Y coordinates of the points in each polygon should be positive.")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "polygons", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("polygons", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("polygons")] // For System.Text.Json
        public List<List<List<double>>> Polygons { get; set; }

        /// <summary>
        /// An array of booleans that align with the polygons and note whether each of the polygons represents a door out onto a roof or balcony (True) or a clearstory window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model
        /// </summary>
        [Summary(@"An array of booleans that align with the polygons and note whether each of the polygons represents a door out onto a roof or balcony (True) or a clearstory window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "are_doors")] // For internal Serialization XML/JSON
        [JsonProperty("are_doors", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("are_doors")] // For System.Text.Json
        public List<bool> AreDoors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DetailedClearstory";
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
            sb.Append("DetailedClearstory:\n");
            sb.Append("  BaseLine: ").Append(this.BaseLine).Append("\n");
            sb.Append("  Elevation: ").Append(this.Elevation).Append("\n");
            sb.Append("  Polygons: ").Append(this.Polygons).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  AreDoors: ").Append(this.AreDoors).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DetailedClearstory object</returns>
        public static DetailedClearstory FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DetailedClearstory>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DetailedClearstory object</returns>
        public virtual DetailedClearstory DuplicateDetailedClearstory()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDetailedClearstory();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DetailedClearstory);
        }


        /// <summary>
        /// Returns true if DetailedClearstory instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedClearstory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedClearstory input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.AllEquals(this.BaseLine, input.BaseLine) && 
                    Extension.Equals(this.Elevation, input.Elevation) && 
                    Extension.AllEquals(this.Polygons, input.Polygons) && 
                    Extension.AllEquals(this.AreDoors, input.AreDoors);
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
                if (this.BaseLine != null)
                    hashCode = hashCode * 59 + this.BaseLine.GetHashCode();
                if (this.Elevation != null)
                    hashCode = hashCode * 59 + this.Elevation.GetHashCode();
                if (this.Polygons != null)
                    hashCode = hashCode * 59 + this.Polygons.GetHashCode();
                if (this.AreDoors != null)
                    hashCode = hashCode * 59 + this.AreDoors.GetHashCode();
                return hashCode;
            }
        }


    }
}
