/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.6.0
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
    public partial class Room2DEnergyPropertiesAbridged : HoneybeeObject, IEquatable<Room2DEnergyPropertiesAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="constructionSet">Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects..</param>
        /// <param name="programType">Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints..</param>
        /// <param name="hvac">An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned..</param>
        /// <param name="windowVentControl">An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open..</param>
        /// <param name="windowVentOpening">An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open..</param>
        public Room2DEnergyPropertiesAbridged
        (
             // Required parameters
            string constructionSet= default, string programType= default, string hvac= default, VentilationControlAbridged windowVentControl= default, VentilationOpening windowVentOpening= default// Optional parameters
        )// BaseClass
        {
            this.ConstructionSet = constructionSet;
            this.ProgramType = programType;
            this.Hvac = hvac;
            this.WindowVentControl = windowVentControl;
            this.WindowVentOpening = windowVentOpening;

            // Set non-required readonly properties with defaultValue
            this.Type = "Room2DEnergyPropertiesAbridged";
        }
        
        /// <summary>
        /// Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects.
        /// </summary>
        /// <value>Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects.</value>
        [DataMember(Name="construction_set", EmitDefaultValue=false)]
        [JsonProperty("construction_set")]
        public string ConstructionSet { get; set; } 
        /// <summary>
        /// Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints.
        /// </summary>
        /// <value>Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints.</value>
        [DataMember(Name="program_type", EmitDefaultValue=false)]
        [JsonProperty("program_type")]
        public string ProgramType { get; set; } 
        /// <summary>
        /// An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned.
        /// </summary>
        /// <value>An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned.</value>
        [DataMember(Name="hvac", EmitDefaultValue=false)]
        [JsonProperty("hvac")]
        public string Hvac { get; set; } 
        /// <summary>
        /// An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open.
        /// </summary>
        /// <value>An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open.</value>
        [DataMember(Name="window_vent_control", EmitDefaultValue=false)]
        [JsonProperty("window_vent_control")]
        public VentilationControlAbridged WindowVentControl { get; set; } 
        /// <summary>
        /// An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open.
        /// </summary>
        /// <value>An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open.</value>
        [DataMember(Name="window_vent_opening", EmitDefaultValue=false)]
        [JsonProperty("window_vent_opening")]
        public VentilationOpening WindowVentOpening { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Room2DEnergyPropertiesAbridged {iDd.Identifier}";
       
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
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ConstructionSet: ").Append(ConstructionSet).Append("\n");
            sb.Append("  ProgramType: ").Append(ProgramType).Append("\n");
            sb.Append("  Hvac: ").Append(Hvac).Append("\n");
            sb.Append("  WindowVentControl: ").Append(WindowVentControl).Append("\n");
            sb.Append("  WindowVentOpening: ").Append(WindowVentOpening).Append("\n");
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
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Room2DEnergyPropertiesAbridged object</returns>
        public Room2DEnergyPropertiesAbridged DuplicateRoom2DEnergyPropertiesAbridged()
        {
            return Duplicate() as Room2DEnergyPropertiesAbridged;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HoneybeeObject</returns>
        public override HoneybeeObject Duplicate()
        {
            return FromJson(this.ToJson());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
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

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ConstructionSet == input.ConstructionSet ||
                    (this.ConstructionSet != null &&
                    this.ConstructionSet.Equals(input.ConstructionSet))
                ) && 
                (
                    this.ProgramType == input.ProgramType ||
                    (this.ProgramType != null &&
                    this.ProgramType.Equals(input.ProgramType))
                ) && 
                (
                    this.Hvac == input.Hvac ||
                    (this.Hvac != null &&
                    this.Hvac.Equals(input.Hvac))
                ) && 
                (
                    this.WindowVentControl == input.WindowVentControl ||
                    (this.WindowVentControl != null &&
                    this.WindowVentControl.Equals(input.WindowVentControl))
                ) && 
                (
                    this.WindowVentOpening == input.WindowVentOpening ||
                    (this.WindowVentOpening != null &&
                    this.WindowVentOpening.Equals(input.WindowVentOpening))
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
                if (this.ConstructionSet != null)
                    hashCode = hashCode * 59 + this.ConstructionSet.GetHashCode();
                if (this.ProgramType != null)
                    hashCode = hashCode * 59 + this.ProgramType.GetHashCode();
                if (this.Hvac != null)
                    hashCode = hashCode * 59 + this.Hvac.GetHashCode();
                if (this.WindowVentControl != null)
                    hashCode = hashCode * 59 + this.WindowVentControl.GetHashCode();
                if (this.WindowVentOpening != null)
                    hashCode = hashCode * 59 + this.WindowVentOpening.GetHashCode();
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
            Regex regexType = new Regex(@"^Room2DEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ConstructionSet (string) maxLength
            if(this.ConstructionSet != null && this.ConstructionSet.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConstructionSet, length must be less than 100.", new [] { "ConstructionSet" });
            }

            // ConstructionSet (string) minLength
            if(this.ConstructionSet != null && this.ConstructionSet.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConstructionSet, length must be greater than 1.", new [] { "ConstructionSet" });
            }

            // ProgramType (string) maxLength
            if(this.ProgramType != null && this.ProgramType.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramType, length must be less than 100.", new [] { "ProgramType" });
            }

            // ProgramType (string) minLength
            if(this.ProgramType != null && this.ProgramType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramType, length must be greater than 1.", new [] { "ProgramType" });
            }

            // Hvac (string) maxLength
            if(this.Hvac != null && this.Hvac.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hvac, length must be less than 100.", new [] { "Hvac" });
            }

            // Hvac (string) minLength
            if(this.Hvac != null && this.Hvac.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hvac, length must be greater than 1.", new [] { "Hvac" });
            }

            yield break;
        }
    }
}
