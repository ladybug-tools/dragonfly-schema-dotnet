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
    /// Instructions for a SensorGrid generated from exterior Faces.
    /// </summary>
    [Summary(@"Instructions for a SensorGrid generated from exterior Faces.")]
    [System.Serializable]
    [DataContract(Name = "ExteriorFaceGridParameter")]
    public partial class ExteriorFaceGridParameter : GridParameterBase, System.IEquatable<ExteriorFaceGridParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExteriorFaceGridParameter" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected ExteriorFaceGridParameter() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ExteriorFaceGridParameter";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExteriorFaceGridParameter" /> class.
        /// </summary>
        /// <param name="dimension">The dimension of the grid cells as a number.</param>
        /// <param name="includeMesh">A boolean to note whether the resulting SensorGrid should include the mesh.</param>
        /// <param name="offset">A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters).</param>
        /// <param name="faceType">Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever.</param>
        /// <param name="punchedGeometry">A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False).</param>
        public ExteriorFaceGridParameter
        (
            double dimension, bool includeMesh = true, double offset = 0.1D, ExteriorFaceType faceType = ExteriorFaceType.Wall, bool punchedGeometry = false
        ) : base(dimension: dimension, includeMesh: includeMesh)
        {
            this.Offset = offset;
            this.FaceType = faceType;
            this.PunchedGeometry = punchedGeometry;

            // Set readonly properties with defaultValue
            this.Type = "ExteriorFaceGridParameter";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ExteriorFaceGridParameter))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters).
        /// </summary>
        [Summary(@"A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters).")]
        [DataMember(Name = "offset")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("offset")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public double Offset { get; set; } = 0.1D;

        /// <summary>
        /// Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever.
        /// </summary>
        [Summary(@"Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever.")]
        [DataMember(Name = "face_type")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("face_type")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public ExteriorFaceType FaceType { get; set; } = ExteriorFaceType.Wall;

        /// <summary>
        /// A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False).
        /// </summary>
        [Summary(@"A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False).")]
        [DataMember(Name = "punched_geometry")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("punched_geometry")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public bool PunchedGeometry { get; set; } = false;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ExteriorFaceGridParameter";
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
            sb.Append("ExteriorFaceGridParameter:\n");
            sb.Append("  Dimension: ").Append(this.Dimension).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  IncludeMesh: ").Append(this.IncludeMesh).Append("\n");
            sb.Append("  Offset: ").Append(this.Offset).Append("\n");
            sb.Append("  FaceType: ").Append(this.FaceType).Append("\n");
            sb.Append("  PunchedGeometry: ").Append(this.PunchedGeometry).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ExteriorFaceGridParameter object</returns>
        public static ExteriorFaceGridParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ExteriorFaceGridParameter>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ExteriorFaceGridParameter object</returns>
        public virtual ExteriorFaceGridParameter DuplicateExteriorFaceGridParameter()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GridParameterBase</returns>
        public override GridParameterBase DuplicateGridParameterBase()
        {
            return DuplicateExteriorFaceGridParameter();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ExteriorFaceGridParameter);
        }


        /// <summary>
        /// Returns true if ExteriorFaceGridParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ExteriorFaceGridParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExteriorFaceGridParameter input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Offset, input.Offset) && 
                    Extension.Equals(this.FaceType, input.FaceType) && 
                    Extension.Equals(this.PunchedGeometry, input.PunchedGeometry);
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
                if (this.FaceType != null)
                    hashCode = hashCode * 59 + this.FaceType.GetHashCode();
                if (this.PunchedGeometry != null)
                    hashCode = hashCode * 59 + this.PunchedGeometry.GetHashCode();
                return hashCode;
            }
        }


    }
}
