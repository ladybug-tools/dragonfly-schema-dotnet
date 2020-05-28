/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.16
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using HoneybeeSchema;


namespace DragonflySchema
{
    /// <summary>
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract]
    public partial class ModelEnergyProperties : HoneybeeObject, IEquatable<ModelEnergyProperties>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEnergyProperties" /> class.
        /// </summary>
        /// <param name="globalConstructionSet">Name for the ConstructionSet to be used for all objects lacking their own construction or a parent construction_set. This ConstructionSet must appear under the Model construction_sets..</param>
        /// <param name="constructionSets">List of all ConstructionSets in the Model..</param>
        /// <param name="constructions">A list of all unique constructions in the model. This includes constructions across all the Model construction_sets..</param>
        /// <param name="materials">A list of all unique materials in the model. This includes materials needed to make the Model constructions..</param>
        /// <param name="hvacs">List of all HVAC systems in the Model..</param>
        /// <param name="programTypes">List of all ProgramTypes in the Model..</param>
        /// <param name="schedules">A list of all unique schedules in the model. This includes schedules across all HVAC systems, ProgramTypes and ContextShades..</param>
        /// <param name="scheduleTypeLimits">A list of all unique ScheduleTypeLimits in the model. This all ScheduleTypeLimits needed to make the Model schedules..</param>
        public ModelEnergyProperties
        (
             // Required parameters
            string globalConstructionSet= default, List<AnyOf<ConstructionSetAbridged,ConstructionSet>> constructionSets= default, List<AnyOf<OpaqueConstructionAbridged,WindowConstructionAbridged,ShadeConstruction,AirBoundaryConstructionAbridged,OpaqueConstruction,WindowConstruction,AirBoundaryConstruction>> constructions= default, List<AnyOf<EnergyMaterial,EnergyMaterialNoMass,EnergyWindowMaterialGas,EnergyWindowMaterialGasCustom,EnergyWindowMaterialGasMixture,EnergyWindowMaterialSimpleGlazSys,EnergyWindowMaterialBlind,EnergyWindowMaterialGlazing,EnergyWindowMaterialShade>> materials= default, List<IdealAirSystemAbridged> hvacs= default, List<AnyOf<ProgramTypeAbridged,ProgramType>> programTypes= default, List<AnyOf<ScheduleRulesetAbridged,ScheduleFixedIntervalAbridged,ScheduleRuleset,ScheduleFixedInterval>> schedules= default, List<ScheduleTypeLimit> scheduleTypeLimits= default// Optional parameters
        )// BaseClass
        {
            this.GlobalConstructionSet = globalConstructionSet;
            this.ConstructionSets = constructionSets;
            this.Constructions = constructions;
            this.Materials = materials;
            this.Hvacs = hvacs;
            this.ProgramTypes = programTypes;
            this.Schedules = schedules;
            this.ScheduleTypeLimits = scheduleTypeLimits;

            // Set non-required readonly properties with defaultValue
            this.Type = "ModelEnergyProperties";
        }
        
        /// <summary>
        /// Name for the ConstructionSet to be used for all objects lacking their own construction or a parent construction_set. This ConstructionSet must appear under the Model construction_sets.
        /// </summary>
        /// <value>Name for the ConstructionSet to be used for all objects lacking their own construction or a parent construction_set. This ConstructionSet must appear under the Model construction_sets.</value>
        [DataMember(Name="global_construction_set", EmitDefaultValue=false)]
        [JsonProperty("global_construction_set")]
        public string GlobalConstructionSet { get; set; } 
        /// <summary>
        /// List of all ConstructionSets in the Model.
        /// </summary>
        /// <value>List of all ConstructionSets in the Model.</value>
        [DataMember(Name="construction_sets", EmitDefaultValue=false)]
        [JsonProperty("construction_sets")]
        public List<AnyOf<ConstructionSetAbridged,ConstructionSet>> ConstructionSets { get; set; } 
        /// <summary>
        /// A list of all unique constructions in the model. This includes constructions across all the Model construction_sets.
        /// </summary>
        /// <value>A list of all unique constructions in the model. This includes constructions across all the Model construction_sets.</value>
        [DataMember(Name="constructions", EmitDefaultValue=false)]
        [JsonProperty("constructions")]
        public List<AnyOf<OpaqueConstructionAbridged,WindowConstructionAbridged,ShadeConstruction,AirBoundaryConstructionAbridged,OpaqueConstruction,WindowConstruction,AirBoundaryConstruction>> Constructions { get; set; } 
        /// <summary>
        /// A list of all unique materials in the model. This includes materials needed to make the Model constructions.
        /// </summary>
        /// <value>A list of all unique materials in the model. This includes materials needed to make the Model constructions.</value>
        [DataMember(Name="materials", EmitDefaultValue=false)]
        [JsonProperty("materials")]
        public List<AnyOf<EnergyMaterial,EnergyMaterialNoMass,EnergyWindowMaterialGas,EnergyWindowMaterialGasCustom,EnergyWindowMaterialGasMixture,EnergyWindowMaterialSimpleGlazSys,EnergyWindowMaterialBlind,EnergyWindowMaterialGlazing,EnergyWindowMaterialShade>> Materials { get; set; } 
        /// <summary>
        /// List of all HVAC systems in the Model.
        /// </summary>
        /// <value>List of all HVAC systems in the Model.</value>
        [DataMember(Name="hvacs", EmitDefaultValue=false)]
        [JsonProperty("hvacs")]
        public List<IdealAirSystemAbridged> Hvacs { get; set; } 
        /// <summary>
        /// List of all ProgramTypes in the Model.
        /// </summary>
        /// <value>List of all ProgramTypes in the Model.</value>
        [DataMember(Name="program_types", EmitDefaultValue=false)]
        [JsonProperty("program_types")]
        public List<AnyOf<ProgramTypeAbridged,ProgramType>> ProgramTypes { get; set; } 
        /// <summary>
        /// A list of all unique schedules in the model. This includes schedules across all HVAC systems, ProgramTypes and ContextShades.
        /// </summary>
        /// <value>A list of all unique schedules in the model. This includes schedules across all HVAC systems, ProgramTypes and ContextShades.</value>
        [DataMember(Name="schedules", EmitDefaultValue=false)]
        [JsonProperty("schedules")]
        public List<AnyOf<ScheduleRulesetAbridged,ScheduleFixedIntervalAbridged,ScheduleRuleset,ScheduleFixedInterval>> Schedules { get; set; } 
        /// <summary>
        /// A list of all unique ScheduleTypeLimits in the model. This all ScheduleTypeLimits needed to make the Model schedules.
        /// </summary>
        /// <value>A list of all unique ScheduleTypeLimits in the model. This all ScheduleTypeLimits needed to make the Model schedules.</value>
        [DataMember(Name="schedule_type_limits", EmitDefaultValue=false)]
        [JsonProperty("schedule_type_limits")]
        public List<ScheduleTypeLimit> ScheduleTypeLimits { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ModelEnergyProperties {iDd.Identifier}";
       
            return "ModelEnergyProperties";
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
            sb.Append("ModelEnergyProperties:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  GlobalConstructionSet: ").Append(GlobalConstructionSet).Append("\n");
            sb.Append("  ConstructionSets: ").Append(ConstructionSets).Append("\n");
            sb.Append("  Constructions: ").Append(Constructions).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  Hvacs: ").Append(Hvacs).Append("\n");
            sb.Append("  ProgramTypes: ").Append(ProgramTypes).Append("\n");
            sb.Append("  Schedules: ").Append(Schedules).Append("\n");
            sb.Append("  ScheduleTypeLimits: ").Append(ScheduleTypeLimits).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ModelEnergyProperties object</returns>
        public static ModelEnergyProperties FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ModelEnergyProperties>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelEnergyProperties);
        }

        /// <summary>
        /// Returns true if ModelEnergyProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelEnergyProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelEnergyProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.GlobalConstructionSet == input.GlobalConstructionSet ||
                    (this.GlobalConstructionSet != null &&
                    this.GlobalConstructionSet.Equals(input.GlobalConstructionSet))
                ) && 
                (
                    this.ConstructionSets == input.ConstructionSets ||
                    this.ConstructionSets != null &&
                    input.ConstructionSets != null &&
                    this.ConstructionSets.SequenceEqual(input.ConstructionSets)
                ) && 
                (
                    this.Constructions == input.Constructions ||
                    this.Constructions != null &&
                    input.Constructions != null &&
                    this.Constructions.SequenceEqual(input.Constructions)
                ) && 
                (
                    this.Materials == input.Materials ||
                    this.Materials != null &&
                    input.Materials != null &&
                    this.Materials.SequenceEqual(input.Materials)
                ) && 
                (
                    this.Hvacs == input.Hvacs ||
                    this.Hvacs != null &&
                    input.Hvacs != null &&
                    this.Hvacs.SequenceEqual(input.Hvacs)
                ) && 
                (
                    this.ProgramTypes == input.ProgramTypes ||
                    this.ProgramTypes != null &&
                    input.ProgramTypes != null &&
                    this.ProgramTypes.SequenceEqual(input.ProgramTypes)
                ) && 
                (
                    this.Schedules == input.Schedules ||
                    this.Schedules != null &&
                    input.Schedules != null &&
                    this.Schedules.SequenceEqual(input.Schedules)
                ) && 
                (
                    this.ScheduleTypeLimits == input.ScheduleTypeLimits ||
                    this.ScheduleTypeLimits != null &&
                    input.ScheduleTypeLimits != null &&
                    this.ScheduleTypeLimits.SequenceEqual(input.ScheduleTypeLimits)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.GlobalConstructionSet != null)
                    hashCode = hashCode * 59 + this.GlobalConstructionSet.GetHashCode();
                if (this.ConstructionSets != null)
                    hashCode = hashCode * 59 + this.ConstructionSets.GetHashCode();
                if (this.Constructions != null)
                    hashCode = hashCode * 59 + this.Constructions.GetHashCode();
                if (this.Materials != null)
                    hashCode = hashCode * 59 + this.Materials.GetHashCode();
                if (this.Hvacs != null)
                    hashCode = hashCode * 59 + this.Hvacs.GetHashCode();
                if (this.ProgramTypes != null)
                    hashCode = hashCode * 59 + this.ProgramTypes.GetHashCode();
                if (this.Schedules != null)
                    hashCode = hashCode * 59 + this.Schedules.GetHashCode();
                if (this.ScheduleTypeLimits != null)
                    hashCode = hashCode * 59 + this.ScheduleTypeLimits.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Type (string) pattern
            Regex regexType = new Regex(@"^ModelEnergyProperties$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // GlobalConstructionSet (string) maxLength
            if(this.GlobalConstructionSet != null && this.GlobalConstructionSet.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GlobalConstructionSet, length must be less than 100.", new [] { "GlobalConstructionSet" });
            }

            // GlobalConstructionSet (string) minLength
            if(this.GlobalConstructionSet != null && this.GlobalConstructionSet.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GlobalConstructionSet, length must be greater than 1.", new [] { "GlobalConstructionSet" });
            }

            yield break;
        }
    }

}
