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
    /// Several rectangular windows, defined by origin, width and height.
    /// </summary>
    [Summary(@"Several rectangular windows, defined by origin, width and height.")]
    [System.Serializable]
    [DataContract(Name = "RectangularWindows")]
    public partial class RectangularWindows : WindowParameterBase, System.IEquatable<RectangularWindows>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RectangularWindows" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected RectangularWindows() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "RectangularWindows";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RectangularWindows" /> class.
        /// </summary>
        /// <param name="origins">An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive.</param>
        /// <param name="widths">An array of positive numbers for the window widths. The length of this list must match the length of the origins.</param>
        /// <param name="heights">An array of positive numbers for the window heights. The length of this list must match the length of the origins.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.</param>
        /// <param name="areDoors">An array of booleans that align with the origins and note whether each of the geometries represents a door (True) or a window (False). If None, it will be assumed that all geometries represent windows and they will be translated to Apertures in any resulting Honeybee model.</param>
        public RectangularWindows
        (
            List<List<double>> origins, List<double> widths, List<double> heights, object userData = default, List<bool> areDoors = default
        ) : base(userData: userData)
        {
            this.Origins = origins ?? throw new System.ArgumentNullException("origins is a required property for RectangularWindows and cannot be null");
            this.Widths = widths ?? throw new System.ArgumentNullException("widths is a required property for RectangularWindows and cannot be null");
            this.Heights = heights ?? throw new System.ArgumentNullException("heights is a required property for RectangularWindows and cannot be null");
            this.AreDoors = areDoors;

            // Set readonly properties with defaultValue
            this.Type = "RectangularWindows";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(RectangularWindows))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive.
        /// </summary>
        [Summary(@"An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive.")]
        [Required]
        [DataMember(Name = "origins", IsRequired = true)] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("origins")] // For System.Text.Json
        public List<List<double>> Origins { get; set; }

        /// <summary>
        /// An array of positive numbers for the window widths. The length of this list must match the length of the origins.
        /// </summary>
        [Summary(@"An array of positive numbers for the window widths. The length of this list must match the length of the origins.")]
        [Required]
        [DataMember(Name = "widths", IsRequired = true)] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("widths")] // For System.Text.Json
        public List<double> Widths { get; set; }

        /// <summary>
        /// An array of positive numbers for the window heights. The length of this list must match the length of the origins.
        /// </summary>
        [Summary(@"An array of positive numbers for the window heights. The length of this list must match the length of the origins.")]
        [Required]
        [DataMember(Name = "heights", IsRequired = true)] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("heights")] // For System.Text.Json
        public List<double> Heights { get; set; }

        /// <summary>
        /// An array of booleans that align with the origins and note whether each of the geometries represents a door (True) or a window (False). If None, it will be assumed that all geometries represent windows and they will be translated to Apertures in any resulting Honeybee model.
        /// </summary>
        [Summary(@"An array of booleans that align with the origins and note whether each of the geometries represents a door (True) or a window (False). If None, it will be assumed that all geometries represent windows and they will be translated to Apertures in any resulting Honeybee model.")]
        [DataMember(Name = "are_doors")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("are_doors")] // For System.Text.Json
        public List<bool> AreDoors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RectangularWindows";
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
            sb.Append("RectangularWindows:\n");
            sb.Append("  Origins: ").Append(this.Origins).Append("\n");
            sb.Append("  Widths: ").Append(this.Widths).Append("\n");
            sb.Append("  Heights: ").Append(this.Heights).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  AreDoors: ").Append(this.AreDoors).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RectangularWindows object</returns>
        public static RectangularWindows FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RectangularWindows>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RectangularWindows object</returns>
        public virtual RectangularWindows DuplicateRectangularWindows()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowParameterBase</returns>
        public override WindowParameterBase DuplicateWindowParameterBase()
        {
            return DuplicateRectangularWindows();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RectangularWindows);
        }


        /// <summary>
        /// Returns true if RectangularWindows instances are equal
        /// </summary>
        /// <param name="input">Instance of RectangularWindows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RectangularWindows input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.AllEquals(this.Origins, input.Origins) && 
                    Extension.AllEquals(this.Widths, input.Widths) && 
                    Extension.AllEquals(this.Heights, input.Heights) && 
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
                if (this.Origins != null)
                    hashCode = hashCode * 59 + this.Origins.GetHashCode();
                if (this.Widths != null)
                    hashCode = hashCode * 59 + this.Widths.GetHashCode();
                if (this.Heights != null)
                    hashCode = hashCode * 59 + this.Heights.GetHashCode();
                if (this.AreDoors != null)
                    hashCode = hashCode * 59 + this.AreDoors.GetHashCode();
                return hashCode;
            }
        }


    }
}
