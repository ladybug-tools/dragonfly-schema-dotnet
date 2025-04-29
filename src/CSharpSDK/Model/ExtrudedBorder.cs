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
    /// Extruded borders over all windows in the wall.
    /// </summary>
    [Summary(@"Extruded borders over all windows in the wall.")]
    [System.Serializable]
    [DataContract(Name = "ExtrudedBorder")]
    public partial class ExtrudedBorder : OpenAPIGenBaseModel, System.IEquatable<ExtrudedBorder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrudedBorder" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected ExtrudedBorder() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ExtrudedBorder";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrudedBorder" /> class.
        /// </summary>
        /// <param name="depth">A number for the depth of the border.</param>
        public ExtrudedBorder
        (
            double depth
        ) : base()
        {
            this.Depth = depth;

            // Set readonly properties with defaultValue
            this.Type = "ExtrudedBorder";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ExtrudedBorder))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for the depth of the border.
        /// </summary>
        [Summary(@"A number for the depth of the border.")]
        [Required]
        [DataMember(Name = "depth", IsRequired = true)] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("depth")] // For System.Text.Json
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
            sb.Append("  Depth: ").Append(this.Depth).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
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
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
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
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
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
            return base.Equals(input) && 
                    Extension.Equals(this.Depth, input.Depth);
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
                return hashCode;
            }
        }


    }
}
