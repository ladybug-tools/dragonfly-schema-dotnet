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
    /// Instructions for a SensorGrid generated from exterior Aperture.
    /// </summary>
    [Summary(@"Instructions for a SensorGrid generated from exterior Aperture.")]
    [System.Serializable]
    [DataContract(Name = "ExteriorApertureGridParameter")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class ExteriorApertureGridParameter : GridParameterBase, System.IEquatable<ExteriorApertureGridParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExteriorApertureGridParameter" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected ExteriorApertureGridParameter() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ExteriorApertureGridParameter";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExteriorApertureGridParameter" /> class.
        /// </summary>
        /// <param name="dimension">The dimension of the grid cells as a number.</param>
        /// <param name="includeMesh">A boolean to note whether the resulting SensorGrid should include the mesh.</param>
        /// <param name="offset">A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters).</param>
        /// <param name="apertureType">Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces.</param>
        public ExteriorApertureGridParameter
        (
            double dimension, bool includeMesh = true, double offset = 0.1D, ExteriorApertureType apertureType = ExteriorApertureType.All
        ) : base(dimension: dimension, includeMesh: includeMesh)
        {
            this.Offset = offset;
            this.ApertureType = apertureType;

            // Set readonly properties with defaultValue
            this.Type = "ExteriorApertureGridParameter";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ExteriorApertureGridParameter))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters).
        /// </summary>
        [Summary(@"A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters).")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "offset")] // For internal Serialization XML/JSON
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("offset")] // For System.Text.Json
        public double Offset { get; set; } = 0.1D;

        /// <summary>
        /// Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces.
        /// </summary>
        [Summary(@"Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "aperture_type")] // For internal Serialization XML/JSON
        [JsonProperty("aperture_type", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("aperture_type")] // For System.Text.Json
        public ExteriorApertureType ApertureType { get; set; } = ExteriorApertureType.All;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ExteriorApertureGridParameter";
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
            sb.Append("ExteriorApertureGridParameter:\n");
            sb.Append("  Dimension: ").Append(this.Dimension).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  IncludeMesh: ").Append(this.IncludeMesh).Append("\n");
            sb.Append("  Offset: ").Append(this.Offset).Append("\n");
            sb.Append("  ApertureType: ").Append(this.ApertureType).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ExteriorApertureGridParameter object</returns>
        public static ExteriorApertureGridParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ExteriorApertureGridParameter>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ExteriorApertureGridParameter object</returns>
        public virtual ExteriorApertureGridParameter DuplicateExteriorApertureGridParameter()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GridParameterBase</returns>
        public override GridParameterBase DuplicateGridParameterBase()
        {
            return DuplicateExteriorApertureGridParameter();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ExteriorApertureGridParameter);
        }


        /// <summary>
        /// Returns true if ExteriorApertureGridParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ExteriorApertureGridParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExteriorApertureGridParameter input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Offset, input.Offset) && 
                    Extension.Equals(this.ApertureType, input.ApertureType);
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.ApertureType != null)
                    hashCode = hashCode * 59 + this.ApertureType.GetHashCode();
                return hashCode;
            }
        }


    }
}
