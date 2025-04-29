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
    /// Instructions for a SensorGrid generated from a Room2D's floors.
    /// </summary>
    [Summary(@"Instructions for a SensorGrid generated from a Room2D's floors.")]
    [System.Serializable]
    [DataContract(Name = "RoomGridParameter")]
    public partial class RoomGridParameter : GridParameterBase, System.IEquatable<RoomGridParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomGridParameter" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected RoomGridParameter() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "RoomGridParameter";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomGridParameter" /> class.
        /// </summary>
        /// <param name="dimension">The dimension of the grid cells as a number.</param>
        /// <param name="includeMesh">A boolean to note whether the resulting SensorGrid should include the mesh.</param>
        /// <param name="offset">A number for how far to offset the grid from the Room2D floors. (Default: 1.0, suitable for Models in Meters).</param>
        /// <param name="wallOffset">A number for the distance at which sensors close to walls should be removed. Note that this option has no effect unless the value is more than half of the dimension.</param>
        public RoomGridParameter
        (
            double dimension, bool includeMesh = true, double offset = 1D, double wallOffset = 0D
        ) : base(dimension: dimension, includeMesh: includeMesh)
        {
            this.Offset = offset;
            this.WallOffset = wallOffset;

            // Set readonly properties with defaultValue
            this.Type = "RoomGridParameter";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(RoomGridParameter))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for how far to offset the grid from the Room2D floors. (Default: 1.0, suitable for Models in Meters).
        /// </summary>
        [Summary(@"A number for how far to offset the grid from the Room2D floors. (Default: 1.0, suitable for Models in Meters).")]
        [DataMember(Name = "offset")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("offset")] // For System.Text.Json
        public double Offset { get; set; } = 1D;

        /// <summary>
        /// A number for the distance at which sensors close to walls should be removed. Note that this option has no effect unless the value is more than half of the dimension.
        /// </summary>
        [Summary(@"A number for the distance at which sensors close to walls should be removed. Note that this option has no effect unless the value is more than half of the dimension.")]
        [DataMember(Name = "wall_offset")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("wall_offset")] // For System.Text.Json
        public double WallOffset { get; set; } = 0D;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RoomGridParameter";
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
            sb.Append("RoomGridParameter:\n");
            sb.Append("  Dimension: ").Append(this.Dimension).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  IncludeMesh: ").Append(this.IncludeMesh).Append("\n");
            sb.Append("  Offset: ").Append(this.Offset).Append("\n");
            sb.Append("  WallOffset: ").Append(this.WallOffset).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RoomGridParameter object</returns>
        public static RoomGridParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RoomGridParameter>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RoomGridParameter object</returns>
        public virtual RoomGridParameter DuplicateRoomGridParameter()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GridParameterBase</returns>
        public override GridParameterBase DuplicateGridParameterBase()
        {
            return DuplicateRoomGridParameter();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RoomGridParameter);
        }


        /// <summary>
        /// Returns true if RoomGridParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of RoomGridParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomGridParameter input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Offset, input.Offset) && 
                    Extension.Equals(this.WallOffset, input.WallOffset);
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.WallOffset != null)
                    hashCode = hashCode * 59 + this.WallOffset.GetHashCode();
                return hashCode;
            }
        }


    }
}
