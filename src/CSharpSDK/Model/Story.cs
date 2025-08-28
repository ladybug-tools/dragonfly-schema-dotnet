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
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [Summary(@"Base class for all objects requiring a identifiers acceptable for all engines.")]
    [System.Serializable]
    [DataContract(Name = "Story")] // Enables DataMember rules. For internal Serialization XML/JSON
    public partial class Story : IDdBaseModel, System.IEquatable<Story>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Story" /> class.
        /// </summary>
        [LBT.Newtonsoft.Json.JsonConstructorAttribute]
        // [System.Text.Json.Serialization.JsonConstructor] // for future switching to System.Text.Json
        protected Story() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Story";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Story" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be < 100 characters and not contain any spaces or special characters.</param>
        /// <param name="room2ds">An array of dragonfly Room2D objects that together form an entire story of a building.</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus).</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="floorToFloorHeight">A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If Autocalculate, this value will be the maximum floor_to_ceiling_height of the input room_2ds.</param>
        /// <param name="floorHeight">A number to indicate the height of the floor plane in the Z axis.If Autocalculate, this will be the minimum floor height of all the room_2ds, which is suitable for cases where there are no floor plenums.</param>
        /// <param name="multiplier">An integer that denotes the number of times that this Story is repeated over the height of the building.</param>
        /// <param name="roof">An optional RoofSpecification object containing geometry for generating sloped roofs over the Story. The RoofSpecification will only affect the child Room2Ds that have a True is_top_exposed property and it will only be utilized in translation to Honeybee when the Story multiplier is 1. If None, all Room2D ceilings will be flat.</param>
        /// <param name="storyType">Text to indicate the type of story. Stories that are plenums are translated to Honeybee with excluded floor areas.</param>
        public Story
        (
            string identifier, List<Room2D> room2ds, StoryPropertiesAbridged properties, string displayName = default, object userData = default, AnyOf<Autocalculate, double> floorToFloorHeight = default, AnyOf<Autocalculate, double> floorHeight = default, int multiplier = 1, RoofSpecification roof = default, StoryType storyType = StoryType.Standard
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.Room2ds = room2ds ?? throw new System.ArgumentNullException("room2ds is a required property for Story and cannot be null");
            this.Properties = properties ?? throw new System.ArgumentNullException("properties is a required property for Story and cannot be null");
            this.FloorToFloorHeight = floorToFloorHeight ?? new Autocalculate();
            this.FloorHeight = floorHeight ?? new Autocalculate();
            this.Multiplier = multiplier;
            this.Roof = roof;
            this.StoryType = storyType;

            // Set readonly properties with defaultValue
            this.Type = "Story";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Story))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// An array of dragonfly Room2D objects that together form an entire story of a building.
        /// </summary>
        [Summary(@"An array of dragonfly Room2D objects that together form an entire story of a building.")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "room_2ds", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("room_2ds", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("room_2ds")] // For System.Text.Json
        public List<Room2D> Room2ds { get; set; }

        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        [Summary(@"Extension properties for particular simulation engines (Radiance, EnergyPlus).")]
        [Required] // For validation after deserialization
        // [System.Text.Json.Serialization.JsonRequired] // For System.Text.Json 
        [DataMember(Name = "properties", IsRequired = true)] // For internal Serialization XML/JSON
        [JsonProperty("properties", Required = Required.Always)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("properties")] // For System.Text.Json
        public StoryPropertiesAbridged Properties { get; set; }

        /// <summary>
        /// A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If Autocalculate, this value will be the maximum floor_to_ceiling_height of the input room_2ds.
        /// </summary>
        [Summary(@"A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If Autocalculate, this value will be the maximum floor_to_ceiling_height of the input room_2ds.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "floor_to_floor_height")] // For internal Serialization XML/JSON
        [JsonProperty("floor_to_floor_height", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("floor_to_floor_height")] // For System.Text.Json
        public AnyOf<Autocalculate, double> FloorToFloorHeight { get; set; } = new Autocalculate();

        /// <summary>
        /// A number to indicate the height of the floor plane in the Z axis.If Autocalculate, this will be the minimum floor height of all the room_2ds, which is suitable for cases where there are no floor plenums.
        /// </summary>
        [Summary(@"A number to indicate the height of the floor plane in the Z axis.If Autocalculate, this will be the minimum floor height of all the room_2ds, which is suitable for cases where there are no floor plenums.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "floor_height")] // For internal Serialization XML/JSON
        [JsonProperty("floor_height", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("floor_height")] // For System.Text.Json
        public AnyOf<Autocalculate, double> FloorHeight { get; set; } = new Autocalculate();

        /// <summary>
        /// An integer that denotes the number of times that this Story is repeated over the height of the building.
        /// </summary>
        [Summary(@"An integer that denotes the number of times that this Story is repeated over the height of the building.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [Range(1, int.MaxValue)]
        [DataMember(Name = "multiplier")] // For internal Serialization XML/JSON
        [JsonProperty("multiplier", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("multiplier")] // For System.Text.Json
        public int Multiplier { get; set; } = 1;

        /// <summary>
        /// An optional RoofSpecification object containing geometry for generating sloped roofs over the Story. The RoofSpecification will only affect the child Room2Ds that have a True is_top_exposed property and it will only be utilized in translation to Honeybee when the Story multiplier is 1. If None, all Room2D ceilings will be flat.
        /// </summary>
        [Summary(@"An optional RoofSpecification object containing geometry for generating sloped roofs over the Story. The RoofSpecification will only affect the child Room2Ds that have a True is_top_exposed property and it will only be utilized in translation to Honeybee when the Story multiplier is 1. If None, all Room2D ceilings will be flat.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "roof")] // For internal Serialization XML/JSON
        [JsonProperty("roof", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("roof")] // For System.Text.Json
        public RoofSpecification Roof { get; set; }

        /// <summary>
        /// Text to indicate the type of story. Stories that are plenums are translated to Honeybee with excluded floor areas.
        /// </summary>
        [Summary(@"Text to indicate the type of story. Stories that are plenums are translated to Honeybee with excluded floor areas.")]
        // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]  // For System.Text.Json  
        [DataMember(Name = "story_type")] // For internal Serialization XML/JSON
        [JsonProperty("story_type", NullValueHandling = NullValueHandling.Ignore)] // For Newtonsoft.Json
        // [System.Text.Json.Serialization.JsonPropertyName("story_type")] // For System.Text.Json
        public StoryType StoryType { get; set; } = StoryType.Standard;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Story";
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
            sb.Append("Story:\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  Room2ds: ").Append(this.Room2ds).Append("\n");
            sb.Append("  Properties: ").Append(this.Properties).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  FloorToFloorHeight: ").Append(this.FloorToFloorHeight).Append("\n");
            sb.Append("  FloorHeight: ").Append(this.FloorHeight).Append("\n");
            sb.Append("  Multiplier: ").Append(this.Multiplier).Append("\n");
            sb.Append("  Roof: ").Append(this.Roof).Append("\n");
            sb.Append("  StoryType: ").Append(this.StoryType).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Story object</returns>
        public static Story FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Story>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Story object</returns>
        public virtual Story DuplicateStory()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdBaseModel</returns>
        public override IDdBaseModel DuplicateIDdBaseModel()
        {
            return DuplicateStory();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Story);
        }


        /// <summary>
        /// Returns true if Story instances are equal
        /// </summary>
        /// <param name="input">Instance of Story to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Story input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.AllEquals(this.Room2ds, input.Room2ds) && 
                    Extension.Equals(this.Properties, input.Properties) && 
                    Extension.Equals(this.FloorToFloorHeight, input.FloorToFloorHeight) && 
                    Extension.Equals(this.FloorHeight, input.FloorHeight) && 
                    Extension.Equals(this.Multiplier, input.Multiplier) && 
                    Extension.Equals(this.Roof, input.Roof) && 
                    Extension.Equals(this.StoryType, input.StoryType);
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
                if (this.Room2ds != null)
                    hashCode = hashCode * 59 + this.Room2ds.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.FloorToFloorHeight != null)
                    hashCode = hashCode * 59 + this.FloorToFloorHeight.GetHashCode();
                if (this.FloorHeight != null)
                    hashCode = hashCode * 59 + this.FloorHeight.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                if (this.Roof != null)
                    hashCode = hashCode * 59 + this.Roof.GetHashCode();
                if (this.StoryType != null)
                    hashCode = hashCode * 59 + this.StoryType.GetHashCode();
                return hashCode;
            }
        }


    }
}
