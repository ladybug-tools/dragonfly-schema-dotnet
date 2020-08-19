/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.6.2
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
    /// A single window in the wall center defined by a width * height.
    /// </summary>
    [DataContract]
    public partial class SingleWindow : HoneybeeObject, IEquatable<SingleWindow>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleWindow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SingleWindow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleWindow" /> class.
        /// </summary>
        /// <param name="width">A number for the window width. Note that, if this width is applied to a wall that is too narrow for this width, the generated window will automatically be shortened when it is applied to the wall. In this way, setting the width to be &#x60;float(\&quot;inf\&quot;)&#x60; will create parameters that always generate a ribbon window. (required).</param>
        /// <param name="height">A number for the window height. Note that, if this height is applied to a wall that is too short for this height, the generated window will automatically be shortened when it is applied to the wall. (required).</param>
        /// <param name="sillHeight">A number for the window sill height. (default to 1.0D).</param>
        public SingleWindow
        (
             double width, double height, // Required parameters
            double sillHeight = 1.0D// Optional parameters
        )// BaseClass
        {
            // to ensure "width" is required (not null)
            if (width == null)
            {
                throw new InvalidDataException("width is a required property for SingleWindow and cannot be null");
            }
            else
            {
                this.Width = width;
            }
            
            // to ensure "height" is required (not null)
            if (height == null)
            {
                throw new InvalidDataException("height is a required property for SingleWindow and cannot be null");
            }
            else
            {
                this.Height = height;
            }
            
            // use default value if no "sillHeight" provided
            if (sillHeight == null)
            {
                this.SillHeight = 1.0D;
            }
            else
            {
                this.SillHeight = sillHeight;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "SingleWindow";
        }
        
        /// <summary>
        /// A number for the window width. Note that, if this width is applied to a wall that is too narrow for this width, the generated window will automatically be shortened when it is applied to the wall. In this way, setting the width to be &#x60;float(\&quot;inf\&quot;)&#x60; will create parameters that always generate a ribbon window.
        /// </summary>
        /// <value>A number for the window width. Note that, if this width is applied to a wall that is too narrow for this width, the generated window will automatically be shortened when it is applied to the wall. In this way, setting the width to be &#x60;float(\&quot;inf\&quot;)&#x60; will create parameters that always generate a ribbon window.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        [JsonProperty("width")]
        public double Width { get; set; } 
        /// <summary>
        /// A number for the window height. Note that, if this height is applied to a wall that is too short for this height, the generated window will automatically be shortened when it is applied to the wall.
        /// </summary>
        /// <value>A number for the window height. Note that, if this height is applied to a wall that is too short for this height, the generated window will automatically be shortened when it is applied to the wall.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        [JsonProperty("height")]
        public double Height { get; set; } 
        /// <summary>
        /// A number for the window sill height.
        /// </summary>
        /// <value>A number for the window sill height.</value>
        [DataMember(Name="sill_height", EmitDefaultValue=false)]
        [JsonProperty("sill_height")]
        public double SillHeight { get; set; }  = 1.0D;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"SingleWindow {iDd.Identifier}";
       
            return "SingleWindow";
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
            sb.Append("SingleWindow:\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SillHeight: ").Append(SillHeight).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SingleWindow object</returns>
        public static SingleWindow FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SingleWindow>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SingleWindow object</returns>
        public SingleWindow DuplicateSingleWindow()
        {
            return Duplicate() as SingleWindow;
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
            return this.Equals(input as SingleWindow);
        }

        /// <summary>
        /// Returns true if SingleWindow instances are equal
        /// </summary>
        /// <param name="input">Instance of SingleWindow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SingleWindow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SillHeight == input.SillHeight ||
                    (this.SillHeight != null &&
                    this.SillHeight.Equals(input.SillHeight))
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
                int hashCode = 41;
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SillHeight != null)
                    hashCode = hashCode * 59 + this.SillHeight.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^SingleWindow$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
