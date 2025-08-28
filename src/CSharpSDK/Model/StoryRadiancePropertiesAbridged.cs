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
    [DataContract(Name = "StoryRadiancePropertiesAbridged")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class StoryRadiancePropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<StoryRadiancePropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryRadiancePropertiesAbridged" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected StoryRadiancePropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "StoryRadiancePropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoryRadiancePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="modifierSet">Name of a ModifierSet to specify all modifiers for the Story. If None, the Story will use the Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects.</param>
        public StoryRadiancePropertiesAbridged
        (
            string modifierSet = default
        ) : base()
        {
            this.ModifierSet = modifierSet;

            // Set readonly properties with defaultValue
            this.Type = "StoryRadiancePropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(StoryRadiancePropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Name of a ModifierSet to specify all modifiers for the Story. If None, the Story will use the Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects.
        /// </summary>
        [Summary(@"Name of a ModifierSet to specify all modifiers for the Story. If None, the Story will use the Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "modifier_set")] // For internal Serialization XML/JSON
        [JsonProperty("modifier_set", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("modifier_set")] // For System.Text.Json
        public string ModifierSet { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "StoryRadiancePropertiesAbridged";
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
            sb.Append("StoryRadiancePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ModifierSet: ").Append(this.ModifierSet).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>StoryRadiancePropertiesAbridged object</returns>
        public static StoryRadiancePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<StoryRadiancePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>StoryRadiancePropertiesAbridged object</returns>
        public virtual StoryRadiancePropertiesAbridged DuplicateStoryRadiancePropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateStoryRadiancePropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as StoryRadiancePropertiesAbridged);
        }


        /// <summary>
        /// Returns true if StoryRadiancePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of StoryRadiancePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoryRadiancePropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.ModifierSet, input.ModifierSet);
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
                if (this.ModifierSet != null)
                    hashCode = hashCode * 59 + this.ModifierSet.GetHashCode();
                return hashCode;
            }
        }


    }
}
