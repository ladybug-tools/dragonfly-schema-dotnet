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
    /// A single window defined by an area ratio with the base surface.
    /// </summary>
    [Summary(@"A single window defined by an area ratio with the base surface.")]
    [System.Serializable]
    [DataContract(Name = "SimpleWindowRatio")]
    public partial class SimpleWindowRatio : WindowParameterBase, System.IEquatable<SimpleWindowRatio>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWindowRatio" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected SimpleWindowRatio() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "SimpleWindowRatio";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWindowRatio" /> class.
        /// </summary>
        /// <param name="windowRatio">A number between 0 and 1 for the ratio between the window area and the parent wall surface area.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.</param>
        /// <param name="rectSplit">Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result.</param>
        public SimpleWindowRatio
        (
            double windowRatio, object userData = default, bool rectSplit = true
        ) : base(userData: userData)
        {
            this.WindowRatio = windowRatio;
            this.RectSplit = rectSplit;

            // Set readonly properties with defaultValue
            this.Type = "SimpleWindowRatio";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(SimpleWindowRatio))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number between 0 and 1 for the ratio between the window area and the parent wall surface area.
        /// </summary>
        [Summary(@"A number between 0 and 1 for the ratio between the window area and the parent wall surface area.")]
        [Required]
        [DataMember(Name = "window_ratio", IsRequired = true)] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("window_ratio")] // For System.Text.Json
        public double WindowRatio { get; set; }

        /// <summary>
        /// Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result.
        /// </summary>
        [Summary(@"Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result.")]
        [DataMember(Name = "rect_split")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("rect_split")] // For System.Text.Json
        public bool RectSplit { get; set; } = true;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SimpleWindowRatio";
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
            sb.Append("SimpleWindowRatio:\n");
            sb.Append("  WindowRatio: ").Append(this.WindowRatio).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  RectSplit: ").Append(this.RectSplit).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SimpleWindowRatio object</returns>
        public static SimpleWindowRatio FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimpleWindowRatio>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimpleWindowRatio object</returns>
        public virtual SimpleWindowRatio DuplicateSimpleWindowRatio()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowParameterBase</returns>
        public override WindowParameterBase DuplicateWindowParameterBase()
        {
            return DuplicateSimpleWindowRatio();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as SimpleWindowRatio);
        }


        /// <summary>
        /// Returns true if SimpleWindowRatio instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleWindowRatio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleWindowRatio input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.WindowRatio, input.WindowRatio) && 
                    Extension.Equals(this.RectSplit, input.RectSplit);
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
                if (this.RectSplit != null)
                    hashCode = hashCode * 59 + this.RectSplit.GetHashCode();
                return hashCode;
            }
        }


    }
}
