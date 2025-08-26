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
    /// Base object for all GridParameters.
    /// </summary>
    [Summary(@"Base object for all GridParameters.")]
    [System.Serializable]
    [DataContract(Name = "_GridParameterBase")]
    public partial class GridParameterBase : OpenAPIGenBaseModel, System.IEquatable<GridParameterBase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridParameterBase" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected GridParameterBase() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "_GridParameterBase";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GridParameterBase" /> class.
        /// </summary>
        /// <param name="dimension">The dimension of the grid cells as a number.</param>
        /// <param name="includeMesh">A boolean to note whether the resulting SensorGrid should include the mesh.</param>
        public GridParameterBase
        (
            double dimension, bool includeMesh = true
        ) : base()
        {
            this.Dimension = dimension;
            this.IncludeMesh = includeMesh;

            // Set readonly properties with defaultValue
            this.Type = "_GridParameterBase";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(GridParameterBase))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// The dimension of the grid cells as a number.
        /// </summary>
        [Summary(@"The dimension of the grid cells as a number.")]
        [Required]
        [DataMember(Name = "dimension", IsRequired = true)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("dimension")] // For System.Text.Json
        public double Dimension { get; set; }

        /// <summary>
        /// A boolean to note whether the resulting SensorGrid should include the mesh.
        /// </summary>
        [Summary(@"A boolean to note whether the resulting SensorGrid should include the mesh.")]
        [DataMember(Name = "include_mesh")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("include_mesh")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public bool IncludeMesh { get; set; } = true;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "GridParameterBase";
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
            sb.Append("GridParameterBase:\n");
            sb.Append("  Dimension: ").Append(this.Dimension).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  IncludeMesh: ").Append(this.IncludeMesh).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>GridParameterBase object</returns>
        public static GridParameterBase FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<GridParameterBase>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GridParameterBase object</returns>
        public virtual GridParameterBase DuplicateGridParameterBase()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateGridParameterBase();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as GridParameterBase);
        }


        /// <summary>
        /// Returns true if GridParameterBase instances are equal
        /// </summary>
        /// <param name="input">Instance of GridParameterBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GridParameterBase input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Dimension, input.Dimension) && 
                    Extension.Equals(this.IncludeMesh, input.IncludeMesh);
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
                if (this.Dimension != null)
                    hashCode = hashCode * 59 + this.Dimension.GetHashCode();
                if (this.IncludeMesh != null)
                    hashCode = hashCode * 59 + this.IncludeMesh.GetHashCode();
                return hashCode;
            }
        }


    }
}
