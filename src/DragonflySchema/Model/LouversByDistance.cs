/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.6.8
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;


namespace DragonflySchema
{
    /// <summary>
    /// A series of louvered Shades at a given distance between each louver.
    /// </summary>
    [DataContract]
    public partial class LouversByDistance : LouversBase, IEquatable<LouversByDistance>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="LouversByDistance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LouversByDistance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LouversByDistance" /> class.
        /// </summary>
        /// <param name="distance">A number for the approximate distance between each louver. (required).</param>
        /// <param name="depth">A number for the depth to extrude the louvers. (required).</param>
        /// <param name="offset">A number for the distance to louvers from the wall. (default to 0D).</param>
        /// <param name="angle">A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. (default to 0D).</param>
        /// <param name="contourVector">A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours..</param>
        /// <param name="flipStartSide">Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left. (default to false).</param>
        public LouversByDistance
        (
            double depth, double distance, // Required parameters
            double offset = 0D, double angle = 0D, List<double> contourVector= default, bool flipStartSide = false // Optional parameters
        ) : base(depth: depth, offset: offset, angle: angle, contourVector: contourVector, flipStartSide: flipStartSide )// BaseClass
        {
            // to ensure "distance" is required (not null)
            if (distance == null)
            {
                throw new InvalidDataException("distance is a required property for LouversByDistance and cannot be null");
            }
            else
            {
                this.Distance = distance;
            }
            

            // Set non-required readonly properties with defaultValue
            this.Type = "LouversByDistance";
        }
        
        /// <summary>
        /// A number for the approximate distance between each louver.
        /// </summary>
        /// <value>A number for the approximate distance between each louver.</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        [JsonProperty("distance")]
        public double Distance { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"LouversByDistance {iDd.Identifier}";
       
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
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
            sb.Append("  ContourVector: ").Append(ContourVector).Append("\n");
            sb.Append("  FlipStartSide: ").Append(FlipStartSide).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
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
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>LouversByDistance object</returns>
        public LouversByDistance DuplicateLouversByDistance()
        {
            return Duplicate() as LouversByDistance;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HoneybeeObject</returns>
        public override HoneybeeObject Duplicate()
        {
            return FromJson(this.ToJson());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
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
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
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
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // Type (string) pattern
            Regex regexType = new Regex(@"^LouversByDistance$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
