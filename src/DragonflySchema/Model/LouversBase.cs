/* 
 * Dragonfly Model Schema
 *
 * Documentation for Dragonfly model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using HoneybeeSchema;
using System.ComponentModel.DataAnnotations;


namespace DragonflySchema
{
    /// <summary>
    /// Base class for for a series of louvered shades over a wall.
    /// </summary>
    [Serializable]
    [DataContract(Name = "_LouversBase")]
    public partial class LouversBase : OpenAPIGenBaseModel, IEquatable<LouversBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LouversBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LouversBase() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "_LouversBase";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="LouversBase" /> class.
        /// </summary>
        /// <param name="depth">A number for the depth to extrude the louvers. (required).</param>
        /// <param name="offset">A number for the distance to louvers from the wall. (default to 0D).</param>
        /// <param name="angle">A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. (default to 0D).</param>
        /// <param name="contourVector">A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours..</param>
        /// <param name="flipStartSide">Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left. (default to false).</param>
        public LouversBase
        (
           double depth, // Required parameters
           double offset = 0D, double angle = 0D, List<double> contourVector= default, bool flipStartSide = false // Optional parameters
        ) : base()// BaseClass
        {
            this.Depth = depth;
            this.Offset = offset;
            this.Angle = angle;
            this.ContourVector = contourVector;
            this.FlipStartSide = flipStartSide;

            // Set non-required readonly properties with defaultValue
            this.Type = "_LouversBase";

            // check if object is valid
            if (this.GetType() == typeof(LouversBase))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "_LouversBase";

        /// <summary>
        /// A number for the depth to extrude the louvers.
        /// </summary>
        /// <value>A number for the depth to extrude the louvers.</value>
        [DataMember(Name = "depth", IsRequired = true)]
        public double Depth { get; set; } 
        /// <summary>
        /// A number for the distance to louvers from the wall.
        /// </summary>
        /// <value>A number for the distance to louvers from the wall.</value>
        [DataMember(Name = "offset")]
        public double Offset { get; set; }  = 0D;
        /// <summary>
        /// A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.
        /// </summary>
        /// <value>A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.</value>
        [DataMember(Name = "angle")]
        public double Angle { get; set; }  = 0D;
        /// <summary>
        /// A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours.
        /// </summary>
        /// <value>A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours.</value>
        [DataMember(Name = "contour_vector")]
        public List<double> ContourVector { get; set; } 
        /// <summary>
        /// Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left.
        /// </summary>
        /// <value>Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left.</value>
        [DataMember(Name = "flip_start_side")]
        public bool FlipStartSide { get; set; }  = false;

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
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  ContourVector: ").Append(ContourVector).Append("\n");
            sb.Append("  FlipStartSide: ").Append(FlipStartSide).Append("\n");
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
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateLouversBase();
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
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && base.Equals(input) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && base.Equals(input) && 
                (
                    this.Angle == input.Angle ||
                    (this.Angle != null &&
                    this.Angle.Equals(input.Angle))
                ) && base.Equals(input) && 
                (
                    this.ContourVector == input.ContourVector ||
                    this.ContourVector != null &&
                    input.ContourVector != null &&
                    this.ContourVector.SequenceEqual(input.ContourVector)
                ) && base.Equals(input) && 
                (
                    this.FlipStartSide == input.FlipStartSide ||
                    (this.FlipStartSide != null &&
                    this.FlipStartSide.Equals(input.FlipStartSide))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Offset (double) minimum
            if(this.Offset < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Offset, must be a value greater than or equal to 0.", new [] { "Offset" });
            }


            
            // Angle (double) maximum
            if(this.Angle > (double)90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Angle, must be a value less than or equal to 90.", new [] { "Angle" });
            }

            // Angle (double) minimum
            if(this.Angle < (double)-90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Angle, must be a value greater than or equal to -90.", new [] { "Angle" });
            }


            
            // Type (string) pattern
            Regex regexType = new Regex(@"^_LouversBase$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
