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
    /// Gridded skylights derived from an area ratio with the roof.
    /// </summary>
    [Summary(@"Gridded skylights derived from an area ratio with the roof.")]
    [System.Serializable]
    [DataContract(Name = "GriddedSkylightRatio")]
    public partial class GriddedSkylightRatio : OpenAPIGenBaseModel, System.IEquatable<GriddedSkylightRatio>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GriddedSkylightRatio" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GriddedSkylightRatio() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "GriddedSkylightRatio";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GriddedSkylightRatio" /> class.
        /// </summary>
        /// <param name="skylightRatio">A number between 0 and 1 for the ratio between the skylight area and the total Roof face area.</param>
        /// <param name="spacing">A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed.</param>
        public GriddedSkylightRatio
        (
            double skylightRatio, AnyOf<Autocalculate, double> spacing = default
        ) : base()
        {
            this.SkylightRatio = skylightRatio;
            this.Spacing = spacing ?? new Autocalculate();

            // Set readonly properties with defaultValue
            this.Type = "GriddedSkylightRatio";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(GriddedSkylightRatio))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number between 0 and 1 for the ratio between the skylight area and the total Roof face area.
        /// </summary>
        [Summary(@"A number between 0 and 1 for the ratio between the skylight area and the total Roof face area.")]
        [Required]
        [DataMember(Name = "skylight_ratio", IsRequired = true)]
        public double SkylightRatio { get; set; }

        /// <summary>
        /// A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed.
        /// </summary>
        [Summary(@"A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed.")]
        [DataMember(Name = "spacing")]
        public AnyOf<Autocalculate, double> Spacing { get; set; } = new Autocalculate();


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "GriddedSkylightRatio";
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
            sb.Append("GriddedSkylightRatio:\n");
            sb.Append("  SkylightRatio: ").Append(this.SkylightRatio).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Spacing: ").Append(this.Spacing).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>GriddedSkylightRatio object</returns>
        public static GriddedSkylightRatio FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<GriddedSkylightRatio>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GriddedSkylightRatio object</returns>
        public virtual GriddedSkylightRatio DuplicateGriddedSkylightRatio()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateGriddedSkylightRatio();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as GriddedSkylightRatio);
        }


        /// <summary>
        /// Returns true if GriddedSkylightRatio instances are equal
        /// </summary>
        /// <param name="input">Instance of GriddedSkylightRatio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GriddedSkylightRatio input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.SkylightRatio, input.SkylightRatio) && 
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
                if (this.SkylightRatio != null)
                    hashCode = hashCode * 59 + this.SkylightRatio.GetHashCode();
                if (this.Spacing != null)
                    hashCode = hashCode * 59 + this.Spacing.GetHashCode();
                return hashCode;
            }
        }


    }
}
