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
    /// Gridded skylights defined by an absolute area.
    /// </summary>
    [Summary(@"Gridded skylights defined by an absolute area.")]
    [System.Serializable]
    [DataContract(Name = "GriddedSkylightArea")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class GriddedSkylightArea : OpenAPIGenBaseModel, System.IEquatable<GriddedSkylightArea>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GriddedSkylightArea" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected GriddedSkylightArea() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "GriddedSkylightArea";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GriddedSkylightArea" /> class.
        /// </summary>
        /// <param name="skylightArea">A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio.</param>
        /// <param name="spacing">A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed.</param>
        public GriddedSkylightArea
        (
            double skylightArea, AnyOf<Autocalculate, double> spacing = default
        ) : base()
        {
            this.SkylightArea = skylightArea;
            this.Spacing = spacing ?? new Autocalculate();

            // Set readonly properties with defaultValue
            this.Type = "GriddedSkylightArea";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(GriddedSkylightArea))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio.
        /// </summary>
        [Summary(@"A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio.")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "skylight_area", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("skylight_area", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("skylight_area")] // For System.Text.Json
        public double SkylightArea { get; set; }

        /// <summary>
        /// A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed.
        /// </summary>
        [Summary(@"A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "spacing")] // For internal Serialization XML/JSON
        [JsonProperty("spacing", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("spacing")] // For System.Text.Json
        public AnyOf<Autocalculate, double> Spacing { get; set; } = new Autocalculate();


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "GriddedSkylightArea";
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
            sb.Append("GriddedSkylightArea:\n");
            sb.Append("  SkylightArea: ").Append(this.SkylightArea).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Spacing: ").Append(this.Spacing).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>GriddedSkylightArea object</returns>
        public static GriddedSkylightArea FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<GriddedSkylightArea>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GriddedSkylightArea object</returns>
        public virtual GriddedSkylightArea DuplicateGriddedSkylightArea()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateGriddedSkylightArea();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as GriddedSkylightArea);
        }


        /// <summary>
        /// Returns true if GriddedSkylightArea instances are equal
        /// </summary>
        /// <param name="input">Instance of GriddedSkylightArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GriddedSkylightArea input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.SkylightArea, input.SkylightArea) && 
                    Extension.Equals(this.Spacing, input.Spacing);
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
                if (this.SkylightArea != null)
                    hashCode = hashCode * 59 + this.SkylightArea.GetHashCode();
                if (this.Spacing != null)
                    hashCode = hashCode * 59 + this.Spacing.GetHashCode();
                return hashCode;
            }
        }


    }
}
