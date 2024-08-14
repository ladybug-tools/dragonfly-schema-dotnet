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
    /// Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.
    /// </summary>
    [Summary(@"Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.")]
    [System.Serializable]
    [DataContract(Name = "ContextShadeRadiancePropertiesAbridged")]
    public partial class ContextShadeRadiancePropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<ContextShadeRadiancePropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShadeRadiancePropertiesAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContextShadeRadiancePropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ContextShadeRadiancePropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShadeRadiancePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="modifier">Name of a Modifier to set the reflectance and specularity of the ContextShade. If None, the the default of 0.2 diffuse reflectance will be used.</param>
        public ContextShadeRadiancePropertiesAbridged
        (
            string modifier = default
        ) : base()
        {
            this.Modifier = modifier;

            // Set readonly properties with defaultValue
            this.Type = "ContextShadeRadiancePropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ContextShadeRadiancePropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Name of a Modifier to set the reflectance and specularity of the ContextShade. If None, the the default of 0.2 diffuse reflectance will be used.
        /// </summary>
        [Summary(@"Name of a Modifier to set the reflectance and specularity of the ContextShade. If None, the the default of 0.2 diffuse reflectance will be used.")]
        [DataMember(Name = "modifier")]
        public string Modifier { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ContextShadeRadiancePropertiesAbridged";
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
            sb.Append("ContextShadeRadiancePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Modifier: ").Append(this.Modifier).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ContextShadeRadiancePropertiesAbridged object</returns>
        public static ContextShadeRadiancePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ContextShadeRadiancePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ContextShadeRadiancePropertiesAbridged object</returns>
        public virtual ContextShadeRadiancePropertiesAbridged DuplicateContextShadeRadiancePropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateContextShadeRadiancePropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ContextShadeRadiancePropertiesAbridged);
        }


        /// <summary>
        /// Returns true if ContextShadeRadiancePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ContextShadeRadiancePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContextShadeRadiancePropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Modifier, input.Modifier);
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
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                return hashCode;
            }
        }


    }
}
