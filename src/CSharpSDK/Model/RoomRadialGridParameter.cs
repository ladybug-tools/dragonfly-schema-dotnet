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
    /// Instructions for a SensorGrid of radial directions around positions from floors.\n\nThis type of sensor grid is particularly helpful for studies of multiple\nview directions, such as imageless glare studies.
    /// </summary>
    [Summary(@"Instructions for a SensorGrid of radial directions around positions from floors.\n\nThis type of sensor grid is particularly helpful for studies of multiple\nview directions, such as imageless glare studies.")]
    [System.Serializable]
    [DataContract(Name = "RoomRadialGridParameter")]
    public partial class RoomRadialGridParameter : RoomGridParameter, System.IEquatable<RoomRadialGridParameter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomRadialGridParameter" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected RoomRadialGridParameter() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "RoomRadialGridParameter";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomRadialGridParameter" /> class.
        /// </summary>
        /// <param name="dimension">The dimension of the grid cells as a number.</param>
        /// <param name="includeMesh">A boolean to note whether the resulting SensorGrid should include the mesh.</param>
        /// <param name="offset">A number for how far to offset the grid from the Room2D floors. (Default: 1.0, suitable for Models in Meters).</param>
        /// <param name="wallOffset">A number for the distance at which sensors close to walls should be removed. Note that this option has no effect unless the value is more than half of the dimension.</param>
        /// <param name="dirCount">A positive integer for the number of radial directions to be generated around each position.</param>
        /// <param name="startVector">A vector as 3 (x, y, z) values to set the start direction of the generated directions. This can be used to orient the resulting sensors to specific parts of the scene. It can also change the elevation of the resulting directions since this start vector will always be rotated in the XY plane to generate the resulting directions.</param>
        /// <param name="meshRadius">An optional number to override the radius of the meshes generated around each sensor. If Autocalculate, it will be equal to 45 percent of the grid dimension.</param>
        public RoomRadialGridParameter
        (
            double dimension, bool includeMesh = true, double offset = 1D, double wallOffset = 0D, int dirCount = 8, List<double> startVector = default, AnyOf<Autocalculate, double> meshRadius = default
        ) : base(dimension: dimension, includeMesh: includeMesh, offset: offset, wallOffset: wallOffset)
        {
            this.DirCount = dirCount;
            this.StartVector = startVector;
            this.MeshRadius = meshRadius ?? new Autocalculate();

            // Set readonly properties with defaultValue
            this.Type = "RoomRadialGridParameter";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(RoomRadialGridParameter))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A positive integer for the number of radial directions to be generated around each position.
        /// </summary>
        [Summary(@"A positive integer for the number of radial directions to be generated around each position.")]
        [DataMember(Name = "dir_count")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("dir_count")] // For System.Text.Json
        public int DirCount { get; set; } = 8;

        /// <summary>
        /// A vector as 3 (x, y, z) values to set the start direction of the generated directions. This can be used to orient the resulting sensors to specific parts of the scene. It can also change the elevation of the resulting directions since this start vector will always be rotated in the XY plane to generate the resulting directions.
        /// </summary>
        [Summary(@"A vector as 3 (x, y, z) values to set the start direction of the generated directions. This can be used to orient the resulting sensors to specific parts of the scene. It can also change the elevation of the resulting directions since this start vector will always be rotated in the XY plane to generate the resulting directions.")]
        [DataMember(Name = "start_vector")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("start_vector")] // For System.Text.Json
        public List<double> StartVector { get; set; }

        /// <summary>
        /// An optional number to override the radius of the meshes generated around each sensor. If Autocalculate, it will be equal to 45 percent of the grid dimension.
        /// </summary>
        [Summary(@"An optional number to override the radius of the meshes generated around each sensor. If Autocalculate, it will be equal to 45 percent of the grid dimension.")]
        [DataMember(Name = "mesh_radius")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("mesh_radius")] // For System.Text.Json
        [LBTNewtonSoft.Newtonsoft.Json.JsonConverter(typeof(AnyOfJsonConverter))] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonConverter(typeof(AnyOfSystemJsonConverter))] // For System.Text.Json
        public AnyOf<Autocalculate, double> MeshRadius { get; set; } = new Autocalculate();


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "RoomRadialGridParameter";
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
            sb.Append("RoomRadialGridParameter:\n");
            sb.Append("  Dimension: ").Append(this.Dimension).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  IncludeMesh: ").Append(this.IncludeMesh).Append("\n");
            sb.Append("  Offset: ").Append(this.Offset).Append("\n");
            sb.Append("  WallOffset: ").Append(this.WallOffset).Append("\n");
            sb.Append("  DirCount: ").Append(this.DirCount).Append("\n");
            sb.Append("  StartVector: ").Append(this.StartVector).Append("\n");
            sb.Append("  MeshRadius: ").Append(this.MeshRadius).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RoomRadialGridParameter object</returns>
        public static RoomRadialGridParameter FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RoomRadialGridParameter>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RoomRadialGridParameter object</returns>
        public virtual RoomRadialGridParameter DuplicateRoomRadialGridParameter()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RoomGridParameter</returns>
        public override RoomGridParameter DuplicateRoomGridParameter()
        {
            return DuplicateRoomRadialGridParameter();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as RoomRadialGridParameter);
        }


        /// <summary>
        /// Returns true if RoomRadialGridParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of RoomRadialGridParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomRadialGridParameter input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.DirCount, input.DirCount) && 
                    Extension.AllEquals(this.StartVector, input.StartVector) && 
                    Extension.Equals(this.MeshRadius, input.MeshRadius);
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
                if (this.DirCount != null)
                    hashCode = hashCode * 59 + this.DirCount.GetHashCode();
                if (this.StartVector != null)
                    hashCode = hashCode * 59 + this.StartVector.GetHashCode();
                if (this.MeshRadius != null)
                    hashCode = hashCode * 59 + this.MeshRadius.GetHashCode();
                return hashCode;
            }
        }


    }
}
