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
    /// Several detailed windows defined by 2D Polygons (lists of 2D vertices).
    /// </summary>
    [Serializable]
    [DataContract(Name = "DetailedWindows")]
    public partial class DetailedWindows : WindowParameterBase, IEquatable<DetailedWindows>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedWindows" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DetailedWindows() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DetailedWindows";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailedWindows" /> class.
        /// </summary>
        /// <param name="polygons">An array of arrays with each sub-array representing a polygonal boundary of a window. Each sub-array should consist of arrays representing points, which can either contain 2 values (indicating they are 2D vertices within the plane of a parent wall segment) or they can contain 3 values (indicating they are 3D world coordinates). For 2D points, the wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows (required).</param>
        /// <param name="areDoors">An array of booleans that align with the polygons and note whether each of the polygons represents a door (True) or a window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures..</param>
        public DetailedWindows
        (
           List<List<List<double>>> polygons, // Required parameters
            Object userData= default, List<bool> areDoors= default// Optional parameters
        ) : base(userData: userData)// BaseClass
        {
            // to ensure "polygons" is required (not null)
            this.Polygons = polygons ?? throw new ArgumentNullException("polygons is a required property for DetailedWindows and cannot be null");
            this.AreDoors = areDoors;

            // Set non-required readonly properties with defaultValue
            this.Type = "DetailedWindows";

            // check if object is valid
            if (this.GetType() == typeof(DetailedWindows))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; protected set; }  = "DetailedWindows";

        /// <summary>
        /// An array of arrays with each sub-array representing a polygonal boundary of a window. Each sub-array should consist of arrays representing points, which can either contain 2 values (indicating they are 2D vertices within the plane of a parent wall segment) or they can contain 3 values (indicating they are 3D world coordinates). For 2D points, the wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows
        /// </summary>
        /// <value>An array of arrays with each sub-array representing a polygonal boundary of a window. Each sub-array should consist of arrays representing points, which can either contain 2 values (indicating they are 2D vertices within the plane of a parent wall segment) or they can contain 3 values (indicating they are 3D world coordinates). For 2D points, the wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows</value>
        [DataMember(Name = "polygons", IsRequired = true)]
        public List<List<List<double>>> Polygons { get; set; } 
        /// <summary>
        /// An array of booleans that align with the polygons and note whether each of the polygons represents a door (True) or a window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model.
        /// </summary>
        /// <value>An array of booleans that align with the polygons and note whether each of the polygons represents a door (True) or a window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model.</value>
        [DataMember(Name = "are_doors")]
        public List<bool> AreDoors { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DetailedWindows";
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
            sb.Append("DetailedWindows:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Polygons: ").Append(Polygons).Append("\n");
            sb.Append("  AreDoors: ").Append(AreDoors).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DetailedWindows object</returns>
        public static DetailedWindows FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DetailedWindows>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DetailedWindows object</returns>
        public virtual DetailedWindows DuplicateDetailedWindows()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDetailedWindows();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override WindowParameterBase DuplicateWindowParameterBase()
        {
            return DuplicateDetailedWindows();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DetailedWindows);
        }

        /// <summary>
        /// Returns true if DetailedWindows instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailedWindows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailedWindows input)
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
            Regex regexType = new Regex(@"^DetailedWindows$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
