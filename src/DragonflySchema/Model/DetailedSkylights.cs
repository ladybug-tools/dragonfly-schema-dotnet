/* 
 * Dragonfly Model Schema
 *
 * Documentation for Dragonfly model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using HoneybeeSchema;
using System.ComponentModel.DataAnnotations;


namespace DragonflySchema
{
    /// <summary>
    /// Several detailed skylights defined by 2D Polygons (lists of 2D vertices).
    /// </summary>
    [Serializable]
    [DataContract(Name = "DetailedSkylights")]
    public partial class DetailedSkylights : OpenAPIGenBaseModel, IEquatable<DetailedSkylights>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSkylights" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DetailedSkylights() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DetailedSkylights";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedSkylights" /> class.
        /// </summary>
        /// <param name="polygons">An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon. (required).</param>
        /// <param name="areDoors">An array of booleans that align with the polygons and note whether each of the polygons represents an overhead door (True) or a skylight (False). If None, it will be assumed that all polygons represent skylights and they will be translated to Apertures in any resulting Honeybee model..</param>
        public DetailedSkylights
        (
           List<List<List<double>>> polygons, // Required parameters
           List<bool> areDoors= default// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "polygons" is required (not null)
            this.Polygons = polygons ?? throw new ArgumentNullException("polygons is a required property for DetailedSkylights and cannot be null");
            this.AreDoors = areDoors;

            // Set non-required readonly properties with defaultValue
            this.Type = "DetailedSkylights";

            // check if object is valid
            if (this.GetType() == typeof(DetailedSkylights))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "DetailedSkylights";

        /// <summary>
        /// An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon.
        /// </summary>
        /// <value>An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon.</value>
        [DataMember(Name = "polygons", IsRequired = true)]
        public List<List<List<double>>> Polygons { get; set; } 
        /// <summary>
        /// An array of booleans that align with the polygons and note whether each of the polygons represents an overhead door (True) or a skylight (False). If None, it will be assumed that all polygons represent skylights and they will be translated to Apertures in any resulting Honeybee model.
        /// </summary>
        /// <value>An array of booleans that align with the polygons and note whether each of the polygons represents an overhead door (True) or a skylight (False). If None, it will be assumed that all polygons represent skylights and they will be translated to Apertures in any resulting Honeybee model.</value>
        [DataMember(Name = "are_doors")]
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
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Polygons: ").Append(Polygons).Append("\n");
            sb.Append("  AreDoors: ").Append(AreDoors).Append("\n");
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
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDetailedSkylights();
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
                (
                    this.Polygons == input.Polygons ||
                    this.Polygons != null &&
                    input.Polygons != null &&
                    this.Polygons.SequenceEqual(input.Polygons)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.AreDoors == input.AreDoors ||
                    this.AreDoors != null &&
                    input.AreDoors != null &&
                    this.AreDoors.SequenceEqual(input.AreDoors)
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
                if (this.Polygons != null)
                    hashCode = hashCode * 59 + this.Polygons.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AreDoors != null)
                    hashCode = hashCode * 59 + this.AreDoors.GetHashCode();
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
            Regex regexType = new Regex(@"^DetailedSkylights$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
