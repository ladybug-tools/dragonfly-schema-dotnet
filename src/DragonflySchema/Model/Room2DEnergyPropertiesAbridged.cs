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
    [DataContract(Name = "Room2DEnergyPropertiesAbridged")]
    public partial class Room2DEnergyPropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<Room2DEnergyPropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DEnergyPropertiesAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Room2DEnergyPropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Room2DEnergyPropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="constructionSet">Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects.</param>
        /// <param name="programType">Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints.</param>
        /// <param name="hvac">An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned.</param>
        /// <param name="shw">An optional identifier of a Service Hot Water (SHW) system that specifies how the hot water load of the Room is met. If None, the hot water load will be met with a generic system that only measures thermal loadand does not account for system efficiencies.</param>
        /// <param name="windowVentControl">An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open.</param>
        /// <param name="windowVentOpening">An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open.</param>
        /// <param name="processLoads">An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators.</param>
        public Room2DEnergyPropertiesAbridged
        (
            string constructionSet = default, string programType = default, string hvac = default, string shw = default, VentilationControlAbridged windowVentControl = default, VentilationOpening windowVentOpening = default, List<ProcessAbridged> processLoads = default
        ) : base()
        {
            this.ConstructionSet = constructionSet;
            this.ProgramType = programType;
            this.Hvac = hvac;
            this.Shw = shw;
            this.WindowVentControl = windowVentControl;
            this.WindowVentOpening = windowVentOpening;
            this.ProcessLoads = processLoads;

            // Set readonly properties with defaultValue
            this.Type = "Room2DEnergyPropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Room2DEnergyPropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects.
        /// </summary>
        [Summary(@"Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects.")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "construction_set")]
        public string ConstructionSet { get; set; }

        /// <summary>
        /// Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints.
        /// </summary>
        [Summary(@"Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints.")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "program_type")]
        public string ProgramType { get; set; }

        /// <summary>
        /// An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned.
        /// </summary>
        [Summary(@"An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned.")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "hvac")]
        public string Hvac { get; set; }

        /// <summary>
        /// An optional identifier of a Service Hot Water (SHW) system that specifies how the hot water load of the Room is met. If None, the hot water load will be met with a generic system that only measures thermal loadand does not account for system efficiencies.
        /// </summary>
        [Summary(@"An optional identifier of a Service Hot Water (SHW) system that specifies how the hot water load of the Room is met. If None, the hot water load will be met with a generic system that only measures thermal loadand does not account for system efficiencies.")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "shw")]
        public string Shw { get; set; }

        /// <summary>
        /// An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open.
        /// </summary>
        [Summary(@"An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open.")]
        [DataMember(Name = "window_vent_control")]
        public VentilationControlAbridged WindowVentControl { get; set; }

        /// <summary>
        /// An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open.
        /// </summary>
        [Summary(@"An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open.")]
        [DataMember(Name = "window_vent_opening")]
        public VentilationOpening WindowVentOpening { get; set; }

        /// <summary>
        /// An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators.
        /// </summary>
        [Summary(@"An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators.")]
        [DataMember(Name = "process_loads")]
        public List<ProcessAbridged> ProcessLoads { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Room2DEnergyPropertiesAbridged";
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
            sb.Append("Room2DEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ConstructionSet: ").Append(this.ConstructionSet).Append("\n");
            sb.Append("  ProgramType: ").Append(this.ProgramType).Append("\n");
            sb.Append("  Hvac: ").Append(this.Hvac).Append("\n");
            sb.Append("  Shw: ").Append(this.Shw).Append("\n");
            sb.Append("  WindowVentControl: ").Append(this.WindowVentControl).Append("\n");
            sb.Append("  WindowVentOpening: ").Append(this.WindowVentOpening).Append("\n");
            sb.Append("  ProcessLoads: ").Append(this.ProcessLoads).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Room2DEnergyPropertiesAbridged object</returns>
        public static Room2DEnergyPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Room2DEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Room2DEnergyPropertiesAbridged object</returns>
        public virtual Room2DEnergyPropertiesAbridged DuplicateRoom2DEnergyPropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRoom2DEnergyPropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Room2DEnergyPropertiesAbridged);
        }


        /// <summary>
        /// Returns true if Room2DEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of Room2DEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Room2DEnergyPropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.ConstructionSet, input.ConstructionSet) && 
                    Extension.Equals(this.ProgramType, input.ProgramType) && 
                    Extension.Equals(this.Hvac, input.Hvac) && 
                    Extension.Equals(this.Shw, input.Shw) && 
                    Extension.Equals(this.WindowVentControl, input.WindowVentControl) && 
                    Extension.Equals(this.WindowVentOpening, input.WindowVentOpening) && 
                    Extension.AllEquals(this.ProcessLoads, input.ProcessLoads);
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
                if (this.ConstructionSet != null)
                    hashCode = hashCode * 59 + this.ConstructionSet.GetHashCode();
                if (this.ProgramType != null)
                    hashCode = hashCode * 59 + this.ProgramType.GetHashCode();
                if (this.Hvac != null)
                    hashCode = hashCode * 59 + this.Hvac.GetHashCode();
                if (this.Shw != null)
                    hashCode = hashCode * 59 + this.Shw.GetHashCode();
                if (this.WindowVentControl != null)
                    hashCode = hashCode * 59 + this.WindowVentControl.GetHashCode();
                if (this.WindowVentOpening != null)
                    hashCode = hashCode * 59 + this.WindowVentOpening.GetHashCode();
                if (this.ProcessLoads != null)
                    hashCode = hashCode * 59 + this.ProcessLoads.GetHashCode();
                return hashCode;
            }
        }


    }
}
