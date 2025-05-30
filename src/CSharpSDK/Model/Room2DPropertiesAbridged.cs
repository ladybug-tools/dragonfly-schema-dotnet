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
    [DataContract(Name = "Room2DPropertiesAbridged")]
    public partial class Room2DPropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<Room2DPropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DPropertiesAbridged" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected Room2DPropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Room2DPropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="energy">Energy</param>
        /// <param name="radiance">Radiance</param>
        /// <param name="doe2">Doe2</param>
        /// <param name="comparison">Comparison</param>
        public Room2DPropertiesAbridged
        (
            Room2DEnergyPropertiesAbridged energy = default, Room2DRadiancePropertiesAbridged radiance = default, Room2DDoe2Properties doe2 = default, Room2DComparisonProperties comparison = default
        ) : base()
        {
            this.Energy = energy;
            this.Radiance = radiance;
            this.Doe2 = doe2;
            this.Comparison = comparison;

            // Set readonly properties with defaultValue
            this.Type = "Room2DPropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Room2DPropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Energy
        /// </summary>
        [Summary(@"Energy")]
        [DataMember(Name = "energy")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("energy")] // For System.Text.Json
        public Room2DEnergyPropertiesAbridged Energy { get; set; }

        /// <summary>
        /// Radiance
        /// </summary>
        [Summary(@"Radiance")]
        [DataMember(Name = "radiance")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("radiance")] // For System.Text.Json
        public Room2DRadiancePropertiesAbridged Radiance { get; set; }

        /// <summary>
        /// Doe2
        /// </summary>
        [Summary(@"Doe2")]
        [DataMember(Name = "doe2")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("doe2")] // For System.Text.Json
        public Room2DDoe2Properties Doe2 { get; set; }

        /// <summary>
        /// Comparison
        /// </summary>
        [Summary(@"Comparison")]
        [DataMember(Name = "comparison")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("comparison")] // For System.Text.Json
        public Room2DComparisonProperties Comparison { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Room2DPropertiesAbridged";
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
            sb.Append("Room2DPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Energy: ").Append(this.Energy).Append("\n");
            sb.Append("  Radiance: ").Append(this.Radiance).Append("\n");
            sb.Append("  Doe2: ").Append(this.Doe2).Append("\n");
            sb.Append("  Comparison: ").Append(this.Comparison).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Room2DPropertiesAbridged object</returns>
        public static Room2DPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Room2DPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Room2DPropertiesAbridged object</returns>
        public virtual Room2DPropertiesAbridged DuplicateRoom2DPropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRoom2DPropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Room2DPropertiesAbridged);
        }


        /// <summary>
        /// Returns true if Room2DPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of Room2DPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Room2DPropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Energy, input.Energy) && 
                    Extension.Equals(this.Radiance, input.Radiance) && 
                    Extension.Equals(this.Doe2, input.Doe2) && 
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
                if (this.Doe2 != null)
                    hashCode = hashCode * 59 + this.Doe2.GetHashCode();
                if (this.Comparison != null)
                    hashCode = hashCode * 59 + this.Comparison.GetHashCode();
                return hashCode;
            }
        }


    }
}
