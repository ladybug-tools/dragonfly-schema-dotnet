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
    [DataContract(Name = "ContextShadeEnergyPropertiesAbridged")]
    public partial class ContextShadeEnergyPropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<ContextShadeEnergyPropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShadeEnergyPropertiesAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContextShadeEnergyPropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ContextShadeEnergyPropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContextShadeEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="construction">Name of a ShadeConstruction to set the reflectance and specularity of the ContextShade. If None, the the EnergyPlus default of 0.2 diffuse reflectance will be used.</param>
        /// <param name="transmittanceSchedule">Name of a schedule to set the transmittance of the ContextShade, which can vary throughout the simulation. If None, the ContextShade will be completely opaque.</param>
        public ContextShadeEnergyPropertiesAbridged
        (
            string construction = default, string transmittanceSchedule = default
        ) : base()
        {
            this.Construction = construction;
            this.TransmittanceSchedule = transmittanceSchedule;

            // Set readonly properties with defaultValue
            this.Type = "ContextShadeEnergyPropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ContextShadeEnergyPropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Name of a ShadeConstruction to set the reflectance and specularity of the ContextShade. If None, the the EnergyPlus default of 0.2 diffuse reflectance will be used.
        /// </summary>
        [Summary(@"Name of a ShadeConstruction to set the reflectance and specularity of the ContextShade. If None, the the EnergyPlus default of 0.2 diffuse reflectance will be used.")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "construction")]
        public string Construction { get; set; }

        /// <summary>
        /// Name of a schedule to set the transmittance of the ContextShade, which can vary throughout the simulation. If None, the ContextShade will be completely opaque.
        /// </summary>
        [Summary(@"Name of a schedule to set the transmittance of the ContextShade, which can vary throughout the simulation. If None, the ContextShade will be completely opaque.")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "transmittance_schedule")]
        public string TransmittanceSchedule { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ContextShadeEnergyPropertiesAbridged";
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
            sb.Append("ContextShadeEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Construction: ").Append(this.Construction).Append("\n");
            sb.Append("  TransmittanceSchedule: ").Append(this.TransmittanceSchedule).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ContextShadeEnergyPropertiesAbridged object</returns>
        public static ContextShadeEnergyPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ContextShadeEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ContextShadeEnergyPropertiesAbridged object</returns>
        public virtual ContextShadeEnergyPropertiesAbridged DuplicateContextShadeEnergyPropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateContextShadeEnergyPropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ContextShadeEnergyPropertiesAbridged);
        }


        /// <summary>
        /// Returns true if ContextShadeEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ContextShadeEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContextShadeEnergyPropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Construction, input.Construction) && 
                    Extension.Equals(this.TransmittanceSchedule, input.TransmittanceSchedule);
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
                if (this.Construction != null)
                    hashCode = hashCode * 59 + this.Construction.GetHashCode();
                if (this.TransmittanceSchedule != null)
                    hashCode = hashCode * 59 + this.TransmittanceSchedule.GetHashCode();
                return hashCode;
            }
        }


    }
}
