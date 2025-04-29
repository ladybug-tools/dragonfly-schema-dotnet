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
    /// A single window in the wall center defined by a width * height.
    /// </summary>
    [Summary(@"A single window in the wall center defined by a width * height.")]
    [System.Serializable]
    [DataContract(Name = "SingleWindow")]
    public partial class SingleWindow : WindowParameterBase, System.IEquatable<SingleWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleWindow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SingleWindow() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "SingleWindow";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleWindow" /> class.
        /// </summary>
        /// <param name="width">A number for the window width. Note that, if this width is applied to a wall that is too narrow for this width, the generated window will automatically be shortened when it is applied to the wall. In this way, setting the width to be `float(""inf"")` will create parameters that always generate a ribbon window.</param>
        /// <param name="height">A number for the window height. Note that, if this height is applied to a wall that is too short for this height, the generated window will automatically be shortened when it is applied to the wall.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.</param>
        /// <param name="sillHeight">A number for the window sill height.</param>
        public SingleWindow
        (
            double width, double height, object userData = default, double sillHeight = 1D
        ) : base(userData: userData)
        {
            this.Width = width;
            this.Height = height;
            this.SillHeight = sillHeight;

            // Set readonly properties with defaultValue
            this.Type = "SingleWindow";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(SingleWindow))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for the window width. Note that, if this width is applied to a wall that is too narrow for this width, the generated window will automatically be shortened when it is applied to the wall. In this way, setting the width to be `float(""inf"")` will create parameters that always generate a ribbon window.
        /// </summary>
        [Summary(@"A number for the window width. Note that, if this width is applied to a wall that is too narrow for this width, the generated window will automatically be shortened when it is applied to the wall. In this way, setting the width to be `float(""inf"")` will create parameters that always generate a ribbon window.")]
        [Required]
        [DataMember(Name = "width", IsRequired = true)]
        public double Width { get; set; }

        /// <summary>
        /// A number for the window height. Note that, if this height is applied to a wall that is too short for this height, the generated window will automatically be shortened when it is applied to the wall.
        /// </summary>
        [Summary(@"A number for the window height. Note that, if this height is applied to a wall that is too short for this height, the generated window will automatically be shortened when it is applied to the wall.")]
        [Required]
        [DataMember(Name = "height", IsRequired = true)]
        public double Height { get; set; }

        /// <summary>
        /// A number for the window sill height.
        /// </summary>
        [Summary(@"A number for the window sill height.")]
        [DataMember(Name = "sill_height")]
        public double SillHeight { get; set; } = 1D;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
            sb.Append("  Width: ").Append(this.Width).Append("\n");
            sb.Append("  Height: ").Append(this.Height).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  SillHeight: ").Append(this.SillHeight).Append("\n");
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
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SingleWindow object</returns>
        public virtual SingleWindow DuplicateSingleWindow()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowParameterBase</returns>
        public override WindowParameterBase DuplicateWindowParameterBase()
        {
            return DuplicateSingleWindow();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
            return base.Equals(input) && 
                    Extension.Equals(this.Width, input.Width) && 
                    Extension.Equals(this.Height, input.Height) && 
                    Extension.Equals(this.SillHeight, input.SillHeight);
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
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.SillHeight != null)
                    hashCode = hashCode * 59 + this.SillHeight.GetHashCode();
                return hashCode;
            }
        }


    }
}
