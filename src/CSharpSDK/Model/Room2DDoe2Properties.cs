﻿/* 
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
    [DataContract(Name = "Room2DDoe2Properties")]
    public partial class Room2DDoe2Properties : OpenAPIGenBaseModel, System.IEquatable<Room2DDoe2Properties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DDoe2Properties" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected Room2DDoe2Properties() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Room2DDoe2Properties";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DDoe2Properties" /> class.
        /// </summary>
        /// <param name="assignedFlow">A number for the design supply air flow rate for the zone the Room is assigned to (cfm). This establishes the minimum allowed design air flow. Note that the actual design flow may be larger. If Autocalculate, this parameter will not be written into the INP.</param>
        /// <param name="flowPerArea">A number for the design supply air flow rate to the zone per unit floor area (cfm/ft2). If Autocalculate, this parameter will not be written into the INP.</param>
        /// <param name="minFlowRatio">A number between 0 and 1 for the minimum allowable zone air supply flow rate, expressed as a fraction of design flow rate. Applicable to variable-volume type systems only. If Autocalculate, this parameter will not be written into the INP.</param>
        /// <param name="minFlowPerArea">A number for the minimum air flow per square foot of floor area (cfm/ft2). This is an alternative way of specifying the min_flow_ratio. If Autocalculate, this parameter will not be written into the INP.</param>
        /// <param name="hmaxFlowRatio">A number between 0 and 1 for the ratio of the maximum (or fixed) heating airflow to the cooling airflow. The specific meaning varies according to the type of zone terminal. If Autocalculate, this parameter will not be written into the INP.</param>
        public Room2DDoe2Properties
        (
            AnyOf<Autocalculate, double> assignedFlow = default, AnyOf<Autocalculate, double> flowPerArea = default, AnyOf<Autocalculate, double> minFlowRatio = default, AnyOf<Autocalculate, double> minFlowPerArea = default, AnyOf<Autocalculate, double> hmaxFlowRatio = default
        ) : base()
        {
            this.AssignedFlow = assignedFlow ?? new Autocalculate();
            this.FlowPerArea = flowPerArea ?? new Autocalculate();
            this.MinFlowRatio = minFlowRatio ?? new Autocalculate();
            this.MinFlowPerArea = minFlowPerArea ?? new Autocalculate();
            this.HmaxFlowRatio = hmaxFlowRatio ?? new Autocalculate();

            // Set readonly properties with defaultValue
            this.Type = "Room2DDoe2Properties";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Room2DDoe2Properties))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number for the design supply air flow rate for the zone the Room is assigned to (cfm). This establishes the minimum allowed design air flow. Note that the actual design flow may be larger. If Autocalculate, this parameter will not be written into the INP.
        /// </summary>
        [Summary(@"A number for the design supply air flow rate for the zone the Room is assigned to (cfm). This establishes the minimum allowed design air flow. Note that the actual design flow may be larger. If Autocalculate, this parameter will not be written into the INP.")]
        [DataMember(Name = "assigned_flow")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("assigned_flow")] // For System.Text.Json
        public AnyOf<Autocalculate, double> AssignedFlow { get; set; } = new Autocalculate();

        /// <summary>
        /// A number for the design supply air flow rate to the zone per unit floor area (cfm/ft2). If Autocalculate, this parameter will not be written into the INP.
        /// </summary>
        [Summary(@"A number for the design supply air flow rate to the zone per unit floor area (cfm/ft2). If Autocalculate, this parameter will not be written into the INP.")]
        [DataMember(Name = "flow_per_area")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("flow_per_area")] // For System.Text.Json
        public AnyOf<Autocalculate, double> FlowPerArea { get; set; } = new Autocalculate();

        /// <summary>
        /// A number between 0 and 1 for the minimum allowable zone air supply flow rate, expressed as a fraction of design flow rate. Applicable to variable-volume type systems only. If Autocalculate, this parameter will not be written into the INP.
        /// </summary>
        [Summary(@"A number between 0 and 1 for the minimum allowable zone air supply flow rate, expressed as a fraction of design flow rate. Applicable to variable-volume type systems only. If Autocalculate, this parameter will not be written into the INP.")]
        [DataMember(Name = "min_flow_ratio")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("min_flow_ratio")] // For System.Text.Json
        public AnyOf<Autocalculate, double> MinFlowRatio { get; set; } = new Autocalculate();

        /// <summary>
        /// A number for the minimum air flow per square foot of floor area (cfm/ft2). This is an alternative way of specifying the min_flow_ratio. If Autocalculate, this parameter will not be written into the INP.
        /// </summary>
        [Summary(@"A number for the minimum air flow per square foot of floor area (cfm/ft2). This is an alternative way of specifying the min_flow_ratio. If Autocalculate, this parameter will not be written into the INP.")]
        [DataMember(Name = "min_flow_per_area")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("min_flow_per_area")] // For System.Text.Json
        public AnyOf<Autocalculate, double> MinFlowPerArea { get; set; } = new Autocalculate();

        /// <summary>
        /// A number between 0 and 1 for the ratio of the maximum (or fixed) heating airflow to the cooling airflow. The specific meaning varies according to the type of zone terminal. If Autocalculate, this parameter will not be written into the INP.
        /// </summary>
        [Summary(@"A number between 0 and 1 for the ratio of the maximum (or fixed) heating airflow to the cooling airflow. The specific meaning varies according to the type of zone terminal. If Autocalculate, this parameter will not be written into the INP.")]
        [DataMember(Name = "hmax_flow_ratio")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("hmax_flow_ratio")] // For System.Text.Json
        public AnyOf<Autocalculate, double> HmaxFlowRatio { get; set; } = new Autocalculate();


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Room2DDoe2Properties";
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
            sb.Append("Room2DDoe2Properties:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  AssignedFlow: ").Append(this.AssignedFlow).Append("\n");
            sb.Append("  FlowPerArea: ").Append(this.FlowPerArea).Append("\n");
            sb.Append("  MinFlowRatio: ").Append(this.MinFlowRatio).Append("\n");
            sb.Append("  MinFlowPerArea: ").Append(this.MinFlowPerArea).Append("\n");
            sb.Append("  HmaxFlowRatio: ").Append(this.HmaxFlowRatio).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Room2DDoe2Properties object</returns>
        public static Room2DDoe2Properties FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Room2DDoe2Properties>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Room2DDoe2Properties object</returns>
        public virtual Room2DDoe2Properties DuplicateRoom2DDoe2Properties()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRoom2DDoe2Properties();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Room2DDoe2Properties);
        }


        /// <summary>
        /// Returns true if Room2DDoe2Properties instances are equal
        /// </summary>
        /// <param name="input">Instance of Room2DDoe2Properties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Room2DDoe2Properties input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.AssignedFlow, input.AssignedFlow) && 
                    Extension.Equals(this.FlowPerArea, input.FlowPerArea) && 
                    Extension.Equals(this.MinFlowRatio, input.MinFlowRatio) && 
                    Extension.Equals(this.MinFlowPerArea, input.MinFlowPerArea) && 
                    Extension.Equals(this.HmaxFlowRatio, input.HmaxFlowRatio);
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
                if (this.AssignedFlow != null)
                    hashCode = hashCode * 59 + this.AssignedFlow.GetHashCode();
                if (this.FlowPerArea != null)
                    hashCode = hashCode * 59 + this.FlowPerArea.GetHashCode();
                if (this.MinFlowRatio != null)
                    hashCode = hashCode * 59 + this.MinFlowRatio.GetHashCode();
                if (this.MinFlowPerArea != null)
                    hashCode = hashCode * 59 + this.MinFlowPerArea.GetHashCode();
                if (this.HmaxFlowRatio != null)
                    hashCode = hashCode * 59 + this.HmaxFlowRatio.GetHashCode();
                return hashCode;
            }
        }


    }
}
