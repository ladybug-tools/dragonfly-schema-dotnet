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
    /// <summary>
    /// Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.
    /// </summary>
    [Summary(@"Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects.")]
    [System.Serializable]
    [DataContract(Name = "StoryEnergyPropertiesAbridged")]
    public partial class StoryEnergyPropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<StoryEnergyPropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryEnergyPropertiesAbridged" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected StoryEnergyPropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "StoryEnergyPropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="constructionSet">Name of a ConstructionSet to specify all constructions for the Story. If None, the Story will use the Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects.</param>
        public StoryEnergyPropertiesAbridged
        (
            string constructionSet = default
        ) : base()
        {
            this.ConstructionSet = constructionSet;

            // Set readonly properties with defaultValue
            this.Type = "StoryEnergyPropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(StoryEnergyPropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Name of a ConstructionSet to specify all constructions for the Story. If None, the Story will use the Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects.
        /// </summary>
        [Summary(@"Name of a ConstructionSet to specify all constructions for the Story. If None, the Story will use the Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects.")]
        [MinLength(1)]
        [MaxLength(100)]
        [DataMember(Name = "construction_set")] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("construction_set")] // For System.Text.Json
        [LBT.Newtonsoft.Json.JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json
        public string ConstructionSet { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "StoryEnergyPropertiesAbridged";
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
            sb.Append("StoryEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ConstructionSet: ").Append(this.ConstructionSet).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>StoryEnergyPropertiesAbridged object</returns>
        public static StoryEnergyPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StoryEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StoryEnergyPropertiesAbridged object</returns>
        public virtual StoryEnergyPropertiesAbridged DuplicateStoryEnergyPropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateStoryEnergyPropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as StoryEnergyPropertiesAbridged);
        }


        /// <summary>
        /// Returns true if StoryEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of StoryEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoryEnergyPropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.ConstructionSet, input.ConstructionSet);
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
                return hashCode;
            }
        }


    }
}
