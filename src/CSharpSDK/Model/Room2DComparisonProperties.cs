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
    [DataContract(Name = "Room2DComparisonProperties")]
    public partial class Room2DComparisonProperties : OpenAPIGenBaseModel, System.IEquatable<Room2DComparisonProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DComparisonProperties" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected Room2DComparisonProperties() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Room2DComparisonProperties";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DComparisonProperties" /> class.
        /// </summary>
        /// <param name="floorBoundary">A list of 2D points representing the outer boundary vertices of the Room2D to which the host Room2D is being compared. The list should include at least 3 points and each point should be a list of 2 (x, y) values.</param>
        /// <param name="floorHoles">Optional list of lists with one list for each hole in the floor plate of the Room2D to which the host Room2D is being compared. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate.</param>
        /// <param name="comparisonWindows">A list of WindowParameter objects that dictate the window geometries of the Room2D to which the host Room2D is being compared.</param>
        /// <param name="comparisonSkylight">A SkylightParameter object for the Room2D to which the host Room2D is being compared.</param>
        public Room2DComparisonProperties
        (
            List<List<double>> floorBoundary = default, List<List<List<double>>> floorHoles = default, List<AnyOf<SingleWindow, SimpleWindowArea, SimpleWindowRatio, RepeatingWindowRatio, RectangularWindows, DetailedWindows>> comparisonWindows = default, AnyOf<GriddedSkylightArea, GriddedSkylightRatio, DetailedSkylights> comparisonSkylight = default
        ) : base()
        {
            this.FloorBoundary = floorBoundary;
            this.FloorHoles = floorHoles;
            this.ComparisonWindows = comparisonWindows;
            this.ComparisonSkylight = comparisonSkylight;

            // Set readonly properties with defaultValue
            this.Type = "Room2DComparisonProperties";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Room2DComparisonProperties))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A list of 2D points representing the outer boundary vertices of the Room2D to which the host Room2D is being compared. The list should include at least 3 points and each point should be a list of 2 (x, y) values.
        /// </summary>
        [Summary(@"A list of 2D points representing the outer boundary vertices of the Room2D to which the host Room2D is being compared. The list should include at least 3 points and each point should be a list of 2 (x, y) values.")]
        [DataMember(Name = "floor_boundary")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("floor_boundary")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public List<List<double>> FloorBoundary { get; set; }

        /// <summary>
        /// Optional list of lists with one list for each hole in the floor plate of the Room2D to which the host Room2D is being compared. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate.
        /// </summary>
        [Summary(@"Optional list of lists with one list for each hole in the floor plate of the Room2D to which the host Room2D is being compared. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate.")]
        [DataMember(Name = "floor_holes")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("floor_holes")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public List<List<List<double>>> FloorHoles { get; set; }

        /// <summary>
        /// A list of WindowParameter objects that dictate the window geometries of the Room2D to which the host Room2D is being compared.
        /// </summary>
        [Summary(@"A list of WindowParameter objects that dictate the window geometries of the Room2D to which the host Room2D is being compared.")]
        [DataMember(Name = "comparison_windows")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("comparison_windows")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public List<AnyOf<SingleWindow, SimpleWindowArea, SimpleWindowRatio, RepeatingWindowRatio, RectangularWindows, DetailedWindows>> ComparisonWindows { get; set; }

        /// <summary>
        /// A SkylightParameter object for the Room2D to which the host Room2D is being compared.
        /// </summary>
        [Summary(@"A SkylightParameter object for the Room2D to which the host Room2D is being compared.")]
        [DataMember(Name = "comparison_skylight")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("comparison_skylight")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public AnyOf<GriddedSkylightArea, GriddedSkylightRatio, DetailedSkylights> ComparisonSkylight { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Room2DComparisonProperties";
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
            sb.Append("Room2DComparisonProperties:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  FloorBoundary: ").Append(this.FloorBoundary).Append("\n");
            sb.Append("  FloorHoles: ").Append(this.FloorHoles).Append("\n");
            sb.Append("  ComparisonWindows: ").Append(this.ComparisonWindows).Append("\n");
            sb.Append("  ComparisonSkylight: ").Append(this.ComparisonSkylight).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Room2DComparisonProperties object</returns>
        public static Room2DComparisonProperties FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Room2DComparisonProperties>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Room2DComparisonProperties object</returns>
        public virtual Room2DComparisonProperties DuplicateRoom2DComparisonProperties()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRoom2DComparisonProperties();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Room2DComparisonProperties);
        }


        /// <summary>
        /// Returns true if Room2DComparisonProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of Room2DComparisonProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Room2DComparisonProperties input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.AllEquals(this.FloorBoundary, input.FloorBoundary) && 
                    Extension.AllEquals(this.FloorHoles, input.FloorHoles) && 
                    Extension.AllEquals(this.ComparisonWindows, input.ComparisonWindows) && 
                    Extension.Equals(this.ComparisonSkylight, input.ComparisonSkylight);
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
                if (this.FloorBoundary != null)
                    hashCode = hashCode * 59 + this.FloorBoundary.GetHashCode();
                if (this.FloorHoles != null)
                    hashCode = hashCode * 59 + this.FloorHoles.GetHashCode();
                if (this.ComparisonWindows != null)
                    hashCode = hashCode * 59 + this.ComparisonWindows.GetHashCode();
                if (this.ComparisonSkylight != null)
                    hashCode = hashCode * 59 + this.ComparisonSkylight.GetHashCode();
                return hashCode;
            }
        }


    }
}
