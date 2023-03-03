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
    /// Instructions for a SensorGrid generated from exterior Faces.
    /// </summary>
    [Serializable]
    [DataContract(Name = "ExteriorFaceGridParameter")]
    public partial class ExteriorFaceGridParameter : GridParameterBase, IEquatable<ExteriorFaceGridParameter>, IValidatableObject
    {
        /// <summary>
        /// Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever.
        /// </summary>
        /// <value>Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever.</value>
        [DataMember(Name="face_type")]
        public ExteriorFaceType FaceType { get; set; } = ExteriorFaceType.Wall;
        /// <summary>
        /// Initializes a new instance of the <see cref="ExteriorFaceGridParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExteriorFaceGridParameter() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ExteriorFaceGridParameter";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ExteriorFaceGridParameter" /> class.
        /// </summary>
        /// <param name="offset">A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters). (default to 0.1D).</param>
        /// <param name="faceType">Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever..</param>
        /// <param name="punchedGeometry">A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False). (default to false).</param>
        /// <param name="dimension">The dimension of the grid cells as a number. (required).</param>
        /// <param name="includeMesh">A boolean to note whether the resulting SensorGrid should include the mesh. (default to true).</param>
        public ExteriorFaceGridParameter
        (
            double dimension, // Required parameters
            bool includeMesh = true, double offset = 0.1D, ExteriorFaceType faceType= ExteriorFaceType.Wall, bool punchedGeometry = false// Optional parameters
        ) : base(dimension: dimension, includeMesh: includeMesh)// BaseClass
        {
            this.Offset = offset;
            this.FaceType = faceType;
            this.PunchedGeometry = punchedGeometry;

            // Set non-required readonly properties with defaultValue
            this.Type = "ExteriorFaceGridParameter";

            // check if object is valid
            if (this.GetType() == typeof(ExteriorFaceGridParameter))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "ExteriorFaceGridParameter";

        /// <summary>
        /// A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters).
        /// </summary>
        /// <value>A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters).</value>
        [DataMember(Name = "offset")]
        public double Offset { get; set; }  = 0.1D;
        /// <summary>
        /// A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False).
        /// </summary>
        /// <value>A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False).</value>
        [DataMember(Name = "punched_geometry")]
        public bool PunchedGeometry { get; set; }  = false;

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
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  IncludeMesh: ").Append(IncludeMesh).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  FaceType: ").Append(FaceType).Append("\n");
            sb.Append("  PunchedGeometry: ").Append(PunchedGeometry).Append("\n");
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
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateExteriorFaceGridParameter();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
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
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && base.Equals(input) && 
                (
                    this.FaceType == input.FaceType ||
                    (this.FaceType != null &&
                    this.FaceType.Equals(input.FaceType))
                ) && base.Equals(input) && 
                (
                    this.PunchedGeometry == input.PunchedGeometry ||
                    (this.PunchedGeometry != null &&
                    this.PunchedGeometry.Equals(input.PunchedGeometry))
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.FaceType != null)
                    hashCode = hashCode * 59 + this.FaceType.GetHashCode();
                if (this.PunchedGeometry != null)
                    hashCode = hashCode * 59 + this.PunchedGeometry.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^ExteriorFaceGridParameter$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
