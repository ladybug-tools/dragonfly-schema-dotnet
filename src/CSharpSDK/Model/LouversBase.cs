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
    /// Base class for for a series of louvered shades over a wall.
    /// </summary>
    [Summary(@"Base class for for a series of louvered shades over a wall.")]
    [System.Serializable]
    [DataContract(Name = "_LouversBase")]
    public partial class LouversBase : OpenAPIGenBaseModel, System.IEquatable<LouversBase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LouversBase" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected LouversBase() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "_LouversBase";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LouversBase" /> class.
        /// </summary>
        /// <param name="depth">A number for the depth to extrude the louvers.</param>
        /// <param name="offset">A number for the distance to louvers from the wall.</param>
        /// <param name="angle">A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.</param>
        /// <param name="contourVector">A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours.</param>
        /// <param name="flipStartSide">Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left.</param>
        public LouversBase
        (
            double depth, double offset = 0D, double angle = 0D, List<double> contourVector = default, bool flipStartSide = false
        ) : base()
        {
            this.Depth = depth;
            this.Offset = offset;
            this.Angle = angle;
            this.ContourVector = contourVector ?? new List<double>{ 0, 1 };
            this.FlipStartSide = flipStartSide;

            // Set readonly properties with defaultValue
            this.Type = "_LouversBase";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(LouversBase))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for the depth to extrude the louvers.
        /// </summary>
        [Summary(@"A number for the depth to extrude the louvers.")]
        [Required]
        [DataMember(Name = "depth", IsRequired = true)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("depth")] // For System.Text.Json
        public double Depth { get; set; }

        /// <summary>
        /// A number for the distance to louvers from the wall.
        /// </summary>
        [Summary(@"A number for the distance to louvers from the wall.")]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "offset")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("offset")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public double Offset { get; set; } = 0D;

        /// <summary>
        /// A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.
        /// </summary>
        [Summary(@"A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.")]
        [Range(-90, 90)]
        [DataMember(Name = "angle")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("angle")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public double Angle { get; set; } = 0D;

        /// <summary>
        /// A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours.
        /// </summary>
        [Summary(@"A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours.")]
        [DataMember(Name = "contour_vector")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("contour_vector")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public List<double> ContourVector { get; set; } = new List<double>{ 0, 1 };

        /// <summary>
        /// Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left.
        /// </summary>
        [Summary(@"Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left.")]
        [DataMember(Name = "flip_start_side")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("flip_start_side")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public bool FlipStartSide { get; set; } = false;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "LouversBase";
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
            sb.Append("LouversBase:\n");
            sb.Append("  Depth: ").Append(this.Depth).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Offset: ").Append(this.Offset).Append("\n");
            sb.Append("  Angle: ").Append(this.Angle).Append("\n");
            sb.Append("  ContourVector: ").Append(this.ContourVector).Append("\n");
            sb.Append("  FlipStartSide: ").Append(this.FlipStartSide).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>LouversBase object</returns>
        public static LouversBase FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LouversBase>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LouversBase object</returns>
        public virtual LouversBase DuplicateLouversBase()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateLouversBase();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as LouversBase);
        }


        /// <summary>
        /// Returns true if LouversBase instances are equal
        /// </summary>
        /// <param name="input">Instance of LouversBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LouversBase input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Depth, input.Depth) && 
                    Extension.Equals(this.Offset, input.Offset) && 
                    Extension.Equals(this.Angle, input.Angle) && 
                    Extension.AllEquals(this.ContourVector, input.ContourVector) && 
                    Extension.Equals(this.FlipStartSide, input.FlipStartSide);
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
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Angle != null)
                    hashCode = hashCode * 59 + this.Angle.GetHashCode();
                if (this.ContourVector != null)
                    hashCode = hashCode * 59 + this.ContourVector.GetHashCode();
                if (this.FlipStartSide != null)
                    hashCode = hashCode * 59 + this.FlipStartSide.GetHashCode();
                return hashCode;
            }
        }


    }
}
