/* 
 * DragonflySchema
 *
 * Contact: info@ladybug.tools
 */

//using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBT.Newtonsoft.Json;
using LBT.Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;

namespace DragonflySchema
{
    [Summary(@"")]
    [System.Serializable]
    [DataContract(Name = "Room2DEnergyPropertiesAbridged")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class Room2DEnergyPropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<Room2DEnergyPropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DEnergyPropertiesAbridged" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
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
        /// <param name="personCount">Number for the total number of people in the room or an Unassigned object to indicate that people are assigned via the program_type.</param>
        /// <param name="lightingWatts">Number for the total wattage of lighting in the room or an Unassigned object to indicate that lighting is assigned via the program_type.</param>
        /// <param name="electricEquipmentWatts">Number for the total wattage of electric equipment in the room or an Unassigned object to indicate that electric equipment is assigned via the program_type.</param>
        /// <param name="gasEquipmentWatts">Number for the total wattage of gas equipment in the room or an Unassigned object to indicate that gas equipment is assigned via the program_type.</param>
        /// <param name="hotWaterFlow">Number for the total flow of hot water in the room or an Unassigned object to indicate that service hot water is assigned via the program_type.</param>
        /// <param name="infiltrationAch">Number for the infiltration of the room in air changes per hour or an Unassigned object to indicate that infiltration is assigned via the program_type.</param>
        /// <param name="processLoads">An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators.</param>
        /// <param name="daylightingControl">An optional DaylightingControl object to dictate the dimming of lights. If None, the lighting will respond only to the schedule and not the daylight conditions within the room.</param>
        /// <param name="windowVentControl">An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open.</param>
        /// <param name="windowVentOpening">An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open.</param>
        /// <param name="fans">An optional list of VentilationFan objects for fans within the room. Note that these fans are not connected to the heating or cooling system and are meant to represent the intentional circulation of unconditioned outdoor air for the purposes of keeping a space cooler, drier or free of indoor pollutants (as in the case of kitchen or bathroom exhaust fans). For the specification of mechanical ventilation of conditioned outdoor air, the Room.ventilation property should be used and the Room should be given a HVAC that can meet this specification.</param>
        public Room2DEnergyPropertiesAbridged
        (
            string constructionSet = default, string programType = default, string hvac = default, string shw = default, double? personCount = default, double? lightingWatts = default, double? electricEquipmentWatts = default, double? gasEquipmentWatts = default, double? hotWaterFlow = default, double? infiltrationAch = default, List<ProcessAbridged> processLoads = default, DaylightingControl daylightingControl = default, VentilationControlAbridged windowVentControl = default, VentilationOpening windowVentOpening = default, List<VentilationFan> fans = default
        ) : base()
        {
            this.ConstructionSet = constructionSet;
            this.ProgramType = programType;
            this.Hvac = hvac;
            this.Shw = shw;
            this.PersonCount = personCount;
            this.LightingWatts = lightingWatts;
            this.ElectricEquipmentWatts = electricEquipmentWatts;
            this.GasEquipmentWatts = gasEquipmentWatts;
            this.HotWaterFlow = hotWaterFlow;
            this.InfiltrationAch = infiltrationAch;
            this.ProcessLoads = processLoads;
            this.DaylightingControl = daylightingControl;
            this.WindowVentControl = windowVentControl;
            this.WindowVentOpening = windowVentOpening;
            this.Fans = fans;

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
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "construction_set")] // For internal Serialization XML/JSON
        [JsonProperty("construction_set", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("construction_set")] // For System.Text.Json
        public string ConstructionSet { get; set; }

        /// <summary>
        /// Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints.
        /// </summary>
        [Summary(@"Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "program_type")] // For internal Serialization XML/JSON
        [JsonProperty("program_type", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("program_type")] // For System.Text.Json
        public string ProgramType { get; set; }

        /// <summary>
        /// An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned.
        /// </summary>
        [Summary(@"An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "hvac")] // For internal Serialization XML/JSON
        [JsonProperty("hvac", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("hvac")] // For System.Text.Json
        public string Hvac { get; set; }

        /// <summary>
        /// An optional identifier of a Service Hot Water (SHW) system that specifies how the hot water load of the Room is met. If None, the hot water load will be met with a generic system that only measures thermal loadand does not account for system efficiencies.
        /// </summary>
        [Summary(@"An optional identifier of a Service Hot Water (SHW) system that specifies how the hot water load of the Room is met. If None, the hot water load will be met with a generic system that only measures thermal loadand does not account for system efficiencies.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "shw")] // For internal Serialization XML/JSON
        [JsonProperty("shw", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("shw")] // For System.Text.Json
        public string Shw { get; set; }

        /// <summary>
        /// Number for the total number of people in the room or an Unassigned object to indicate that people are assigned via the program_type.
        /// </summary>
        [Summary(@"Number for the total number of people in the room or an Unassigned object to indicate that people are assigned via the program_type.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [Range(0, double.MaxValue)]
        [DataMember(Name = "person_count")] // For internal Serialization XML/JSON
        [JsonProperty("person_count", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("person_count")] // For System.Text.Json
        public double? PersonCount { get; set; }

        /// <summary>
        /// Number for the total wattage of lighting in the room or an Unassigned object to indicate that lighting is assigned via the program_type.
        /// </summary>
        [Summary(@"Number for the total wattage of lighting in the room or an Unassigned object to indicate that lighting is assigned via the program_type.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [Range(0, double.MaxValue)]
        [DataMember(Name = "lighting_watts")] // For internal Serialization XML/JSON
        [JsonProperty("lighting_watts", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("lighting_watts")] // For System.Text.Json
        public double? LightingWatts { get; set; }

        /// <summary>
        /// Number for the total wattage of electric equipment in the room or an Unassigned object to indicate that electric equipment is assigned via the program_type.
        /// </summary>
        [Summary(@"Number for the total wattage of electric equipment in the room or an Unassigned object to indicate that electric equipment is assigned via the program_type.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [Range(0, double.MaxValue)]
        [DataMember(Name = "electric_equipment_watts")] // For internal Serialization XML/JSON
        [JsonProperty("electric_equipment_watts", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("electric_equipment_watts")] // For System.Text.Json
        public double? ElectricEquipmentWatts { get; set; }

        /// <summary>
        /// Number for the total wattage of gas equipment in the room or an Unassigned object to indicate that gas equipment is assigned via the program_type.
        /// </summary>
        [Summary(@"Number for the total wattage of gas equipment in the room or an Unassigned object to indicate that gas equipment is assigned via the program_type.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [Range(0, double.MaxValue)]
        [DataMember(Name = "gas_equipment_watts")] // For internal Serialization XML/JSON
        [JsonProperty("gas_equipment_watts", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("gas_equipment_watts")] // For System.Text.Json
        public double? GasEquipmentWatts { get; set; }

        /// <summary>
        /// Number for the total flow of hot water in the room or an Unassigned object to indicate that service hot water is assigned via the program_type.
        /// </summary>
        [Summary(@"Number for the total flow of hot water in the room or an Unassigned object to indicate that service hot water is assigned via the program_type.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [Range(0, double.MaxValue)]
        [DataMember(Name = "hot_water_flow")] // For internal Serialization XML/JSON
        [JsonProperty("hot_water_flow", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("hot_water_flow")] // For System.Text.Json
        public double? HotWaterFlow { get; set; }

        /// <summary>
        /// Number for the infiltration of the room in air changes per hour or an Unassigned object to indicate that infiltration is assigned via the program_type.
        /// </summary>
        [Summary(@"Number for the infiltration of the room in air changes per hour or an Unassigned object to indicate that infiltration is assigned via the program_type.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [Range(0, double.MaxValue)]
        [DataMember(Name = "infiltration_ach")] // For internal Serialization XML/JSON
        [JsonProperty("infiltration_ach", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("infiltration_ach")] // For System.Text.Json
        public double? InfiltrationAch { get; set; }

        /// <summary>
        /// An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators.
        /// </summary>
        [Summary(@"An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "process_loads")] // For internal Serialization XML/JSON
        [JsonProperty("process_loads", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("process_loads")] // For System.Text.Json
        public List<ProcessAbridged> ProcessLoads { get; set; }

        /// <summary>
        /// An optional DaylightingControl object to dictate the dimming of lights. If None, the lighting will respond only to the schedule and not the daylight conditions within the room.
        /// </summary>
        [Summary(@"An optional DaylightingControl object to dictate the dimming of lights. If None, the lighting will respond only to the schedule and not the daylight conditions within the room.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "daylighting_control")] // For internal Serialization XML/JSON
        [JsonProperty("daylighting_control", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("daylighting_control")] // For System.Text.Json
        public DaylightingControl DaylightingControl { get; set; }

        /// <summary>
        /// An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open.
        /// </summary>
        [Summary(@"An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "window_vent_control")] // For internal Serialization XML/JSON
        [JsonProperty("window_vent_control", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("window_vent_control")] // For System.Text.Json
        public VentilationControlAbridged WindowVentControl { get; set; }

        /// <summary>
        /// An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open.
        /// </summary>
        [Summary(@"An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "window_vent_opening")] // For internal Serialization XML/JSON
        [JsonProperty("window_vent_opening", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("window_vent_opening")] // For System.Text.Json
        public VentilationOpening WindowVentOpening { get; set; }

        /// <summary>
        /// An optional list of VentilationFan objects for fans within the room. Note that these fans are not connected to the heating or cooling system and are meant to represent the intentional circulation of unconditioned outdoor air for the purposes of keeping a space cooler, drier or free of indoor pollutants (as in the case of kitchen or bathroom exhaust fans). For the specification of mechanical ventilation of conditioned outdoor air, the Room.ventilation property should be used and the Room should be given a HVAC that can meet this specification.
        /// </summary>
        [Summary(@"An optional list of VentilationFan objects for fans within the room. Note that these fans are not connected to the heating or cooling system and are meant to represent the intentional circulation of unconditioned outdoor air for the purposes of keeping a space cooler, drier or free of indoor pollutants (as in the case of kitchen or bathroom exhaust fans). For the specification of mechanical ventilation of conditioned outdoor air, the Room.ventilation property should be used and the Room should be given a HVAC that can meet this specification.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "fans")] // For internal Serialization XML/JSON
        [JsonProperty("fans", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("fans")] // For System.Text.Json
        public List<VentilationFan> Fans { get; set; }


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
            sb.Append("  PersonCount: ").Append(this.PersonCount).Append("\n");
            sb.Append("  LightingWatts: ").Append(this.LightingWatts).Append("\n");
            sb.Append("  ElectricEquipmentWatts: ").Append(this.ElectricEquipmentWatts).Append("\n");
            sb.Append("  GasEquipmentWatts: ").Append(this.GasEquipmentWatts).Append("\n");
            sb.Append("  HotWaterFlow: ").Append(this.HotWaterFlow).Append("\n");
            sb.Append("  InfiltrationAch: ").Append(this.InfiltrationAch).Append("\n");
            sb.Append("  ProcessLoads: ").Append(this.ProcessLoads).Append("\n");
            sb.Append("  DaylightingControl: ").Append(this.DaylightingControl).Append("\n");
            sb.Append("  WindowVentControl: ").Append(this.WindowVentControl).Append("\n");
            sb.Append("  WindowVentOpening: ").Append(this.WindowVentOpening).Append("\n");
            sb.Append("  Fans: ").Append(this.Fans).Append("\n");
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
                    Extension.Equals(this.PersonCount, input.PersonCount) && 
                    Extension.Equals(this.LightingWatts, input.LightingWatts) && 
                    Extension.Equals(this.ElectricEquipmentWatts, input.ElectricEquipmentWatts) && 
                    Extension.Equals(this.GasEquipmentWatts, input.GasEquipmentWatts) && 
                    Extension.Equals(this.HotWaterFlow, input.HotWaterFlow) && 
                    Extension.Equals(this.InfiltrationAch, input.InfiltrationAch) && 
                    Extension.AllEquals(this.ProcessLoads, input.ProcessLoads) && 
                    Extension.Equals(this.DaylightingControl, input.DaylightingControl) && 
                    Extension.Equals(this.WindowVentControl, input.WindowVentControl) && 
                    Extension.Equals(this.WindowVentOpening, input.WindowVentOpening) && 
                    Extension.AllEquals(this.Fans, input.Fans);
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
                if (this.PersonCount != null)
                    hashCode = hashCode * 59 + this.PersonCount.GetHashCode();
                if (this.LightingWatts != null)
                    hashCode = hashCode * 59 + this.LightingWatts.GetHashCode();
                if (this.ElectricEquipmentWatts != null)
                    hashCode = hashCode * 59 + this.ElectricEquipmentWatts.GetHashCode();
                if (this.GasEquipmentWatts != null)
                    hashCode = hashCode * 59 + this.GasEquipmentWatts.GetHashCode();
                if (this.HotWaterFlow != null)
                    hashCode = hashCode * 59 + this.HotWaterFlow.GetHashCode();
                if (this.InfiltrationAch != null)
                    hashCode = hashCode * 59 + this.InfiltrationAch.GetHashCode();
                if (this.ProcessLoads != null)
                    hashCode = hashCode * 59 + this.ProcessLoads.GetHashCode();
                if (this.DaylightingControl != null)
                    hashCode = hashCode * 59 + this.DaylightingControl.GetHashCode();
                if (this.WindowVentControl != null)
                    hashCode = hashCode * 59 + this.WindowVentControl.GetHashCode();
                if (this.WindowVentOpening != null)
                    hashCode = hashCode * 59 + this.WindowVentOpening.GetHashCode();
                if (this.Fans != null)
                    hashCode = hashCode * 59 + this.Fans.GetHashCode();
                return hashCode;
            }
        }


    }
}
