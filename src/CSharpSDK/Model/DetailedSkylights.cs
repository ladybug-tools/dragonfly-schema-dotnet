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
    /// Several detailed skylights defined by 2D Polygons (lists of 2D vertices).
    /// </summary>
    [Summary(@"Several detailed skylights defined by 2D Polygons (lists of 2D vertices).")]
    [System.Serializable]
    [DataContract(Name = "DetailedSkylights")]
    public partial class DetailedSkylights : OpenAPIGenBaseModel, System.IEquatable<DetailedSkylights>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSkylights" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected DetailedSkylights() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "DetailedSkylights";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSkylights" /> class.
        /// </summary>
        /// <param name="polygons">An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon.</param>
        /// <param name="areDoors">An array of booleans that align with the polygons and note whether each of the polygons represents an overhead door (True) or a skylight (False). If None, it will be assumed that all polygons represent skylights and they will be translated to Apertures in any resulting Honeybee model.</param>
        public DetailedSkylights
        (
            List<List<List<double>>> polygons, List<bool> areDoors = default
        ) : base()
        {
            this.Polygons = polygons ?? throw new System.ArgumentNullException("polygons is a required property for DetailedSkylights and cannot be null");
            this.AreDoors = areDoors;

            // Set readonly properties with defaultValue
            this.Type = "DetailedSkylights";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(DetailedSkylights))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon.
        /// </summary>
        [Summary(@"An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon.")]
        [Required]
        [DataMember(Name = "polygons", IsRequired = true)] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("polygons")] // For System.Text.Json
        public List<List<List<double>>> Polygons { get; set; }

        /// <summary>
        /// An array of booleans that align with the polygons and note whether each of the polygons represents an overhead door (True) or a skylight (False). If None, it will be assumed that all polygons represent skylights and they will be translated to Apertures in any resulting Honeybee model.
        /// </summary>
        [Summary(@"An array of booleans that align with the polygons and note whether each of the polygons represents an overhead door (True) or a skylight (False). If None, it will be assumed that all polygons represent skylights and they will be translated to Apertures in any resulting Honeybee model.")]
        [DataMember(Name = "are_doors")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("are_doors")] // For System.Text.Json
        public List<bool> AreDoors { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DetailedSkylights";
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
            sb.Append("DetailedSkylights:\n");
            sb.Append("  Polygons: ").Append(this.Polygons).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  AreDoors: ").Append(this.AreDoors).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DetailedSkylights object</returns>
        public static DetailedSkylights FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DetailedSkylights>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DetailedSkylights object</returns>
        public virtual DetailedSkylights DuplicateDetailedSkylights()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDetailedSkylights();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DetailedSkylights);
        }


        /// <summary>
        /// Returns true if DetailedSkylights instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedSkylights to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedSkylights input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.AllEquals(this.Polygons, input.Polygons) && 
                    Extension.AllEquals(this.AreDoors, input.AreDoors);
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
                if (this.Polygons != null)
                    hashCode = hashCode * 59 + this.Polygons.GetHashCode();
                if (this.AreDoors != null)
                    hashCode = hashCode * 59 + this.AreDoors.GetHashCode();
                return hashCode;
            }
        }


    }
}
