/* 
 * Dragonfly Model Schema
 *
 * Documentation for Dragonfly model schema
 *
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
using HoneybeeSchema;
using System.ComponentModel.DataAnnotations;


namespace DragonflySchema
{
    /// <summary>
    /// Extruded borders over all windows in the wall.
    /// </summary>
    [DataContract(Name = "ExtrudedBorder")]
    public partial class ExtrudedBorder : IEquatable<ExtrudedBorder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrudedBorder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtrudedBorder() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ExtrudedBorder";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrudedBorder" /> class.
        /// </summary>
        /// <param name="depth">A number for the depth of the border. (required).</param>
        public ExtrudedBorder
        (
           double depth// Required parameters
           // Optional parameters
        ) : base()// BaseClass
        {
            this.Depth = depth;

            // Set non-required readonly properties with defaultValue
            this.Type = "ExtrudedBorder";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "ExtrudedBorder";

        /// <summary>
        /// A number for the depth of the border.
        /// </summary>
        /// <value>A number for the depth of the border.</value>
        [DataMember(Name = "depth", IsRequired = true)]
        public double Depth { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ExtrudedBorder";
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
            sb.Append("ExtrudedBorder:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ExtrudedBorder object</returns>
        public static ExtrudedBorder FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ExtrudedBorder>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ExtrudedBorder object</returns>
        public virtual ExtrudedBorder DuplicateExtrudedBorder()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateExtrudedBorder();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ExtrudedBorder);
        }

        /// <summary>
        /// Returns true if ExtrudedBorder instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtrudedBorder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtrudedBorder input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
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
            Regex regexType = new Regex(@"^ExtrudedBorder$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
