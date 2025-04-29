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
    /// A series of louvered Shades at a given distance between each louver.
    /// </summary>
    [Summary(@"A series of louvered Shades at a given distance between each louver.")]
    [System.Serializable]
    [DataContract(Name = "LouversByDistance")]
    public partial class LouversByDistance : LouversBase, System.IEquatable<LouversByDistance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LouversByDistance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LouversByDistance() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "LouversByDistance";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LouversByDistance" /> class.
        /// </summary>
        /// <param name="depth">A number for the depth to extrude the louvers.</param>
        /// <param name="distance">A number for the approximate distance between each louver.</param>
        /// <param name="offset">A number for the distance to louvers from the wall.</param>
        /// <param name="angle">A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.</param>
        /// <param name="contourVector">A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours.</param>
        /// <param name="flipStartSide">Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left.</param>
        public LouversByDistance
        (
            double depth, double distance, double offset = 0D, double angle = 0D, List<double> contourVector = default, bool flipStartSide = false
        ) : base(depth: depth, offset: offset, angle: angle, contourVector: contourVector, flipStartSide: flipStartSide)
        {
            this.Distance = distance;

            // Set readonly properties with defaultValue
            this.Type = "LouversByDistance";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(LouversByDistance))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for the approximate distance between each louver.
        /// </summary>
        [Summary(@"A number for the approximate distance between each louver.")]
        [Required]
        [DataMember(Name = "distance", IsRequired = true)]
        public double Distance { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "LouversByDistance";
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
            sb.Append("LouversByDistance:\n");
            sb.Append("  Depth: ").Append(this.Depth).Append("\n");
            sb.Append("  Distance: ").Append(this.Distance).Append("\n");
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
        /// <returns>LouversByDistance object</returns>
        public static LouversByDistance FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<LouversByDistance>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LouversByDistance object</returns>
        public virtual LouversByDistance DuplicateLouversByDistance()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LouversBase</returns>
        public override LouversBase DuplicateLouversBase()
        {
            return DuplicateLouversByDistance();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as LouversByDistance);
        }


        /// <summary>
        /// Returns true if LouversByDistance instances are equal
        /// </summary>
        /// <param name="input">Instance of LouversByDistance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LouversByDistance input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Distance, input.Distance);
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
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                return hashCode;
            }
        }


    }
}
