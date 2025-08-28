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
    /// A single window defined by an absolute area.
    /// </summary>
    [Summary(@"A single window defined by an absolute area.")]
    [System.Serializable]
    [DataContract(Name = "SimpleWindowArea")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class SimpleWindowArea : WindowParameterBase, System.IEquatable<SimpleWindowArea>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWindowArea" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected SimpleWindowArea() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "SimpleWindowArea";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWindowArea" /> class.
        /// </summary>
        /// <param name="windowArea">A number for the window area in current model units. If this area is larger than the area of the Wall that it is appliedto, the window will fill the parent Wall at a 99 percent ratio.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.</param>
        /// <param name="rectSplit">Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result.</param>
        public SimpleWindowArea
        (
            double windowArea, object userData = default, bool rectSplit = true
        ) : base(userData: userData)
        {
            this.WindowArea = windowArea;
            this.RectSplit = rectSplit;

            // Set readonly properties with defaultValue
            this.Type = "SimpleWindowArea";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(SimpleWindowArea))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for the window area in current model units. If this area is larger than the area of the Wall that it is appliedto, the window will fill the parent Wall at a 99 percent ratio.
        /// </summary>
        [Summary(@"A number for the window area in current model units. If this area is larger than the area of the Wall that it is appliedto, the window will fill the parent Wall at a 99 percent ratio.")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "window_area", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("window_area", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("window_area")] // For System.Text.Json
        public double WindowArea { get; set; }

        /// <summary>
        /// Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result.
        /// </summary>
        [Summary(@"Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "rect_split")] // For internal Serialization XML/JSON
        [JsonProperty("rect_split", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("rect_split")] // For System.Text.Json
        public bool RectSplit { get; set; } = true;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SimpleWindowArea";
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
            sb.Append("SimpleWindowArea:\n");
            sb.Append("  WindowArea: ").Append(this.WindowArea).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  RectSplit: ").Append(this.RectSplit).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SimpleWindowArea object</returns>
        public static SimpleWindowArea FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimpleWindowArea>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimpleWindowArea object</returns>
        public virtual SimpleWindowArea DuplicateSimpleWindowArea()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowParameterBase</returns>
        public override WindowParameterBase DuplicateWindowParameterBase()
        {
            return DuplicateSimpleWindowArea();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as SimpleWindowArea);
        }


        /// <summary>
        /// Returns true if SimpleWindowArea instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleWindowArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleWindowArea input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.WindowArea, input.WindowArea) && 
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
                if (this.WindowArea != null)
                    hashCode = hashCode * 59 + this.WindowArea.GetHashCode();
                if (this.RectSplit != null)
                    hashCode = hashCode * 59 + this.RectSplit.GetHashCode();
                return hashCode;
            }
        }


    }
}
