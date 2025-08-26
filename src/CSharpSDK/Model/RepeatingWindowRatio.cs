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
    /// Repeating windows derived from an area ratio with the base wall.
    /// </summary>
    [Summary(@"Repeating windows derived from an area ratio with the base wall.")]
    [System.Serializable]
    [DataContract(Name = "RepeatingWindowRatio")]
    public partial class RepeatingWindowRatio : WindowParameterBase, System.IEquatable<RepeatingWindowRatio>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepeatingWindowRatio" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected RepeatingWindowRatio() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "RepeatingWindowRatio";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepeatingWindowRatio" /> class.
        /// </summary>
        /// <param name="windowRatio">A number between 0 and 1 for the ratio between the window area and the parent wall surface area.</param>
        /// <param name="windowHeight">A number for the target height of the windows. Note that, if the window ratio is too large for the height, the ratio will take precedence and the actual window_height will be larger than this value.</param>
        /// <param name="sillHeight">A number for the target height above the bottom edge of the wall to start the windows. Note that, if the ratio is too large for the height, the ratio will take precedence and the sill_height will be smaller than this value.</param>
        /// <param name="horizontalSeparation">A number for the target separation between individual window centerlines.  If this number is larger than the parent rectangle base, only one window will be produced.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.</param>
        /// <param name="verticalSeparation">An optional number to create a single vertical separation between top and bottom windows.</param>
        public RepeatingWindowRatio
        (
            double windowRatio, double windowHeight, double sillHeight, double horizontalSeparation, object userData = default, double verticalSeparation = 0D
        ) : base(userData: userData)
        {
            this.WindowRatio = windowRatio;
            this.WindowHeight = windowHeight;
            this.SillHeight = sillHeight;
            this.HorizontalSeparation = horizontalSeparation;
            this.VerticalSeparation = verticalSeparation;

            // Set readonly properties with defaultValue
            this.Type = "RepeatingWindowRatio";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(RepeatingWindowRatio))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number between 0 and 1 for the ratio between the window area and the parent wall surface area.
        /// </summary>
        [Summary(@"A number between 0 and 1 for the ratio between the window area and the parent wall surface area.")]
        [Required]
        [DataMember(Name = "window_ratio", IsRequired = true)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("window_ratio")] // For System.Text.Json
        public double WindowRatio { get; set; }

        /// <summary>
        /// A number for the target height of the windows. Note that, if the window ratio is too large for the height, the ratio will take precedence and the actual window_height will be larger than this value.
        /// </summary>
        [Summary(@"A number for the target height of the windows. Note that, if the window ratio is too large for the height, the ratio will take precedence and the actual window_height will be larger than this value.")]
        [Required]
        [DataMember(Name = "window_height", IsRequired = true)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("window_height")] // For System.Text.Json
        public double WindowHeight { get; set; }

        /// <summary>
        /// A number for the target height above the bottom edge of the wall to start the windows. Note that, if the ratio is too large for the height, the ratio will take precedence and the sill_height will be smaller than this value.
        /// </summary>
        [Summary(@"A number for the target height above the bottom edge of the wall to start the windows. Note that, if the ratio is too large for the height, the ratio will take precedence and the sill_height will be smaller than this value.")]
        [Required]
        [DataMember(Name = "sill_height", IsRequired = true)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("sill_height")] // For System.Text.Json
        public double SillHeight { get; set; }

        /// <summary>
        /// A number for the target separation between individual window centerlines.  If this number is larger than the parent rectangle base, only one window will be produced.
        /// </summary>
        [Summary(@"A number for the target separation between individual window centerlines.  If this number is larger than the parent rectangle base, only one window will be produced.")]
        [Required]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "horizontal_separation", IsRequired = true)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("horizontal_separation")] // For System.Text.Json
        public double HorizontalSeparation { get; set; }

        /// <summary>
        /// An optional number to create a single vertical separation between top and bottom windows.
        /// </summary>
        [Summary(@"An optional number to create a single vertical separation between top and bottom windows.")]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "vertical_separation")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("vertical_separation")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public double VerticalSeparation { get; set; } = 0D;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RepeatingWindowRatio";
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
            sb.Append("RepeatingWindowRatio:\n");
            sb.Append("  WindowRatio: ").Append(this.WindowRatio).Append("\n");
            sb.Append("  WindowHeight: ").Append(this.WindowHeight).Append("\n");
            sb.Append("  SillHeight: ").Append(this.SillHeight).Append("\n");
            sb.Append("  HorizontalSeparation: ").Append(this.HorizontalSeparation).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  VerticalSeparation: ").Append(this.VerticalSeparation).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RepeatingWindowRatio object</returns>
        public static RepeatingWindowRatio FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RepeatingWindowRatio>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RepeatingWindowRatio object</returns>
        public virtual RepeatingWindowRatio DuplicateRepeatingWindowRatio()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowParameterBase</returns>
        public override WindowParameterBase DuplicateWindowParameterBase()
        {
            return DuplicateRepeatingWindowRatio();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RepeatingWindowRatio);
        }


        /// <summary>
        /// Returns true if RepeatingWindowRatio instances are equal
        /// </summary>
        /// <param name="input">Instance of RepeatingWindowRatio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepeatingWindowRatio input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.WindowRatio, input.WindowRatio) && 
                    Extension.Equals(this.WindowHeight, input.WindowHeight) && 
                    Extension.Equals(this.SillHeight, input.SillHeight) && 
                    Extension.Equals(this.HorizontalSeparation, input.HorizontalSeparation) && 
                    Extension.Equals(this.VerticalSeparation, input.VerticalSeparation);
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
                if (this.WindowRatio != null)
                    hashCode = hashCode * 59 + this.WindowRatio.GetHashCode();
                if (this.WindowHeight != null)
                    hashCode = hashCode * 59 + this.WindowHeight.GetHashCode();
                if (this.SillHeight != null)
                    hashCode = hashCode * 59 + this.SillHeight.GetHashCode();
                if (this.HorizontalSeparation != null)
                    hashCode = hashCode * 59 + this.HorizontalSeparation.GetHashCode();
                if (this.VerticalSeparation != null)
                    hashCode = hashCode * 59 + this.VerticalSeparation.GetHashCode();
                return hashCode;
            }
        }


    }
}
