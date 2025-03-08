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
    [Summary(@"")]
    [System.Serializable]
    [DataContract(Name = "ModelProperties")]
    public partial class ModelProperties : OpenAPIGenBaseModel, System.IEquatable<ModelProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProperties" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelProperties() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ModelProperties";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelProperties" /> class.
        /// </summary>
        /// <param name="energy">Energy</param>
        /// <param name="radiance">Radiance</param>
        /// <param name="comparison">Comparison</param>
        public ModelProperties
        (
            ModelEnergyProperties energy = default, ModelRadianceProperties radiance = default, ModelComparisonProperties comparison = default
        ) : base()
        {
            this.Energy = energy;
            this.Radiance = radiance;
            this.Comparison = comparison;

            // Set readonly properties with defaultValue
            this.Type = "ModelProperties";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ModelProperties))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Energy
        /// </summary>
        [Summary(@"Energy")]
        [DataMember(Name = "energy")]
        public ModelEnergyProperties Energy { get; set; }

        /// <summary>
        /// Radiance
        /// </summary>
        [Summary(@"Radiance")]
        [DataMember(Name = "radiance")]
        public ModelRadianceProperties Radiance { get; set; }

        /// <summary>
        /// Comparison
        /// </summary>
        [Summary(@"Comparison")]
        [DataMember(Name = "comparison")]
        public ModelComparisonProperties Comparison { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ModelProperties";
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
            sb.Append("ModelProperties:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Energy: ").Append(this.Energy).Append("\n");
            sb.Append("  Radiance: ").Append(this.Radiance).Append("\n");
            sb.Append("  Comparison: ").Append(this.Comparison).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ModelProperties object</returns>
        public static ModelProperties FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ModelProperties>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ModelProperties object</returns>
        public virtual ModelProperties DuplicateModelProperties()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateModelProperties();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ModelProperties);
        }


        /// <summary>
        /// Returns true if ModelProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelProperties input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Energy, input.Energy) && 
                    Extension.Equals(this.Radiance, input.Radiance) && 
                    Extension.Equals(this.Comparison, input.Comparison);
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
                if (this.Energy != null)
                    hashCode = hashCode * 59 + this.Energy.GetHashCode();
                if (this.Radiance != null)
                    hashCode = hashCode * 59 + this.Radiance.GetHashCode();
                if (this.Comparison != null)
                    hashCode = hashCode * 59 + this.Comparison.GetHashCode();
                return hashCode;
            }
        }


    }
}
