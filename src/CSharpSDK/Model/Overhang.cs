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
    /// A single overhang over an entire wall.
    /// </summary>
    [Summary(@"A single overhang over an entire wall.")]
    [System.Serializable]
    [DataContract(Name = "Overhang")]
    public partial class Overhang : OpenAPIGenBaseModel, System.IEquatable<Overhang>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Overhang" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Overhang() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Overhang";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Overhang" /> class.
        /// </summary>
        /// <param name="depth">A number for the overhang depth.</param>
        /// <param name="angle">A number between -90 and 90 for the for an angle to rotate the overhang in degrees. 0 indicates an overhang perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.</param>
        public Overhang
        (
            double depth, double angle = 0D
        ) : base()
        {
            this.Depth = depth;
            this.Angle = angle;

            // Set readonly properties with defaultValue
            this.Type = "Overhang";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Overhang))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for the overhang depth.
        /// </summary>
        [Summary(@"A number for the overhang depth.")]
        [Required]
        [DataMember(Name = "depth", IsRequired = true)]
        public double Depth { get; set; }

        /// <summary>
        /// A number between -90 and 90 for the for an angle to rotate the overhang in degrees. 0 indicates an overhang perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.
        /// </summary>
        [Summary(@"A number between -90 and 90 for the for an angle to rotate the overhang in degrees. 0 indicates an overhang perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation.")]
        [Range(-90, 90)]
        [DataMember(Name = "angle")]
        public double Angle { get; set; } = 0D;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Overhang";
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
            sb.Append("Overhang:\n");
            sb.Append("  Depth: ").Append(this.Depth).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Angle: ").Append(this.Angle).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Overhang object</returns>
        public static Overhang FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Overhang>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Overhang object</returns>
        public virtual Overhang DuplicateOverhang()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateOverhang();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Overhang);
        }


        /// <summary>
        /// Returns true if Overhang instances are equal
        /// </summary>
        /// <param name="input">Instance of Overhang to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Overhang input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Depth, input.Depth) && 
                    Extension.Equals(this.Angle, input.Angle);
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
                if (this.Angle != null)
                    hashCode = hashCode * 59 + this.Angle.GetHashCode();
                return hashCode;
            }
        }


    }
}
