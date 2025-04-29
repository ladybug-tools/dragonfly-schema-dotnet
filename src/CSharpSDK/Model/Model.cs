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
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [Summary(@"Base class for all objects requiring a identifiers acceptable for all engines.")]
    [System.Serializable]
    [DataContract(Name = "Model")]
    public partial class Model : IDdBaseModel, System.IEquatable<Model>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Model() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Model";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be < 100 characters and not contain any spaces or special characters.</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus).</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="version">Text string for the current version of the schema.</param>
        /// <param name="buildings">A list of Buildings in the model.</param>
        /// <param name="contextShades">A list of ContextShades in the model.</param>
        /// <param name="units">Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters.</param>
        /// <param name="tolerance">The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters.</param>
        /// <param name="angleTolerance">The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model.</param>
        public Model
        (
            string identifier, ModelProperties properties, string displayName = default, object userData = default, string version = "0.0.0", List<Building> buildings = default, List<ContextShade> contextShades = default, Units units = Units.Meters, double tolerance = 0.01D, double angleTolerance = 1D
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.Properties = properties ?? throw new System.ArgumentNullException("properties is a required property for Model and cannot be null");
            this.Version = version ?? "0.0.0";
            this.Buildings = buildings;
            this.ContextShades = contextShades;
            this.Units = units;
            this.Tolerance = tolerance;
            this.AngleTolerance = angleTolerance;

            // Set readonly properties with defaultValue
            this.Type = "Model";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Model))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        [Summary(@"Extension properties for particular simulation engines (Radiance, EnergyPlus).")]
        [Required]
        [DataMember(Name = "properties", IsRequired = true)]
        public ModelProperties Properties { get; set; }

        /// <summary>
        /// Text string for the current version of the schema.
        /// </summary>
        [Summary(@"Text string for the current version of the schema.")]
        [RegularExpression(@"([0-9]+)\.([0-9]+)\.([0-9]+)")]
        [DataMember(Name = "version")]
        public string Version { get; set; } = "0.0.0";

        /// <summary>
        /// A list of Buildings in the model.
        /// </summary>
        [Summary(@"A list of Buildings in the model.")]
        [DataMember(Name = "buildings")]
        public List<Building> Buildings { get; set; }

        /// <summary>
        /// A list of ContextShades in the model.
        /// </summary>
        [Summary(@"A list of ContextShades in the model.")]
        [DataMember(Name = "context_shades")]
        public List<ContextShade> ContextShades { get; set; }

        /// <summary>
        /// Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters.
        /// </summary>
        [Summary(@"Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters.")]
        [DataMember(Name = "units")]
        public Units Units { get; set; } = Units.Meters;

        /// <summary>
        /// The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters.
        /// </summary>
        [Summary(@"The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters.")]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "tolerance")]
        public double Tolerance { get; set; } = 0.01D;

        /// <summary>
        /// The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model.
        /// </summary>
        [Summary(@"The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model.")]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "angle_tolerance")]
        public double AngleTolerance { get; set; } = 1D;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Model";
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
            sb.Append("Model:\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  Properties: ").Append(this.Properties).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  Version: ").Append(this.Version).Append("\n");
            sb.Append("  Buildings: ").Append(this.Buildings).Append("\n");
            sb.Append("  ContextShades: ").Append(this.ContextShades).Append("\n");
            sb.Append("  Units: ").Append(this.Units).Append("\n");
            sb.Append("  Tolerance: ").Append(this.Tolerance).Append("\n");
            sb.Append("  AngleTolerance: ").Append(this.AngleTolerance).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Model object</returns>
        public static Model FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Model>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Model object</returns>
        public virtual Model DuplicateModel()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdBaseModel</returns>
        public override IDdBaseModel DuplicateIDdBaseModel()
        {
            return DuplicateModel();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Model);
        }


        /// <summary>
        /// Returns true if Model instances are equal
        /// </summary>
        /// <param name="input">Instance of Model to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Properties, input.Properties) && 
                    Extension.Equals(this.Version, input.Version) && 
                    Extension.AllEquals(this.Buildings, input.Buildings) && 
                    Extension.AllEquals(this.ContextShades, input.ContextShades) && 
                    Extension.Equals(this.Units, input.Units) && 
                    Extension.Equals(this.Tolerance, input.Tolerance) && 
                    Extension.Equals(this.AngleTolerance, input.AngleTolerance);
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
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Buildings != null)
                    hashCode = hashCode * 59 + this.Buildings.GetHashCode();
                if (this.ContextShades != null)
                    hashCode = hashCode * 59 + this.ContextShades.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.Tolerance != null)
                    hashCode = hashCode * 59 + this.Tolerance.GetHashCode();
                if (this.AngleTolerance != null)
                    hashCode = hashCode * 59 + this.AngleTolerance.GetHashCode();
                return hashCode;
            }
        }


    }
}
