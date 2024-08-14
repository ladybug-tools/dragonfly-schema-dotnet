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
    /// Geometry for specifying sloped roofs over a Story.
    /// </summary>
    [Summary(@"Geometry for specifying sloped roofs over a Story.")]
    [System.Serializable]
    [DataContract(Name = "RoofSpecification")]
    public partial class RoofSpecification : OpenAPIGenBaseModel, System.IEquatable<RoofSpecification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoofSpecification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoofSpecification() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "RoofSpecification";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoofSpecification" /> class.
        /// </summary>
        /// <param name="geometry">An array of Face3D objects representing the geometry of the Roof. None of these geometries should overlap in plan and, together, these Face3D should either completely cover or skip each Room2D of the Story to which the RoofSpecification is assigned.</param>
        public RoofSpecification
        (
            List<Face3D> geometry
        ) : base()
        {
            this.Geometry = geometry ?? throw new System.ArgumentNullException("geometry is a required property for RoofSpecification and cannot be null");

            // Set readonly properties with defaultValue
            this.Type = "RoofSpecification";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(RoofSpecification))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// An array of Face3D objects representing the geometry of the Roof. None of these geometries should overlap in plan and, together, these Face3D should either completely cover or skip each Room2D of the Story to which the RoofSpecification is assigned.
        /// </summary>
        [Summary(@"An array of Face3D objects representing the geometry of the Roof. None of these geometries should overlap in plan and, together, these Face3D should either completely cover or skip each Room2D of the Story to which the RoofSpecification is assigned.")]
        [Required]
        [DataMember(Name = "geometry", IsRequired = true)]
        public List<Face3D> Geometry { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RoofSpecification";
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
            sb.Append("RoofSpecification:\n");
            sb.Append("  Geometry: ").Append(this.Geometry).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RoofSpecification object</returns>
        public static RoofSpecification FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RoofSpecification>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RoofSpecification object</returns>
        public virtual RoofSpecification DuplicateRoofSpecification()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRoofSpecification();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RoofSpecification);
        }


        /// <summary>
        /// Returns true if RoofSpecification instances are equal
        /// </summary>
        /// <param name="input">Instance of RoofSpecification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoofSpecification input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.AllEquals(this.Geometry, input.Geometry);
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                return hashCode;
            }
        }


    }
}
