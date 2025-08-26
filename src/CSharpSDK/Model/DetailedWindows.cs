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
    /// Several detailed windows defined by 2D Polygons (lists of 2D vertices).
    /// </summary>
    [Summary(@"Several detailed windows defined by 2D Polygons (lists of 2D vertices).")]
    [System.Serializable]
    [DataContract(Name = "DetailedWindows")]
    public partial class DetailedWindows : WindowParameterBase, System.IEquatable<DetailedWindows>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedWindows" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected DetailedWindows() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "DetailedWindows";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedWindows" /> class.
        /// </summary>
        /// <param name="polygons">An array of arrays with each sub-array representing a polygonal boundary of a window. Each sub-array should consist of arrays representing points, which can either contain 2 values (indicating they are 2D vertices within the plane of a parent wall segment) or they can contain 3 values (indicating they are 3D world coordinates). For 2D points, the wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.</param>
        /// <param name="areDoors">An array of booleans that align with the polygons and note whether each of the polygons represents a door (True) or a window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model.</param>
        public DetailedWindows
        (
            List<List<List<double>>> polygons, object userData = default, List<bool> areDoors = default
        ) : base(userData: userData)
        {
            this.Polygons = polygons ?? throw new System.ArgumentNullException("polygons is a required property for DetailedWindows and cannot be null");
            this.AreDoors = areDoors;

            // Set readonly properties with defaultValue
            this.Type = "DetailedWindows";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(DetailedWindows))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// An array of arrays with each sub-array representing a polygonal boundary of a window. Each sub-array should consist of arrays representing points, which can either contain 2 values (indicating they are 2D vertices within the plane of a parent wall segment) or they can contain 3 values (indicating they are 3D world coordinates). For 2D points, the wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows
        /// </summary>
        [Summary(@"An array of arrays with each sub-array representing a polygonal boundary of a window. Each sub-array should consist of arrays representing points, which can either contain 2 values (indicating they are 2D vertices within the plane of a parent wall segment) or they can contain 3 values (indicating they are 3D world coordinates). For 2D points, the wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows")]
        [Required]
        [DataMember(Name = "polygons", IsRequired = true)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("polygons")] // For System.Text.Json
        public List<List<List<double>>> Polygons { get; set; }

        /// <summary>
        /// An array of booleans that align with the polygons and note whether each of the polygons represents a door (True) or a window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model.
        /// </summary>
        [Summary(@"An array of booleans that align with the polygons and note whether each of the polygons represents a door (True) or a window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model.")]
        [DataMember(Name = "are_doors")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("are_doors")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public List<bool> AreDoors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DetailedWindows";
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
            sb.Append("DetailedWindows:\n");
            sb.Append("  Polygons: ").Append(this.Polygons).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  AreDoors: ").Append(this.AreDoors).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DetailedWindows object</returns>
        public static DetailedWindows FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DetailedWindows>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DetailedWindows object</returns>
        public virtual DetailedWindows DuplicateDetailedWindows()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowParameterBase</returns>
        public override WindowParameterBase DuplicateWindowParameterBase()
        {
            return DuplicateDetailedWindows();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DetailedWindows);
        }


        /// <summary>
        /// Returns true if DetailedWindows instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedWindows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedWindows input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
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
                if (this.Polygons != null)
                    hashCode = hashCode * 59 + this.Polygons.GetHashCode();
                if (this.AreDoors != null)
                    hashCode = hashCode * 59 + this.AreDoors.GetHashCode();
                return hashCode;
            }
        }


    }
}
