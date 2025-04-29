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
    [DataContract(Name = "Building")]
    public partial class Building : IDdBaseModel, System.IEquatable<Building>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Building" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Building() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Building";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Building" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be < 100 characters and not contain any spaces or special characters.</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus).</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="uniqueStories">An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor, though this is not required. Note that, if a given Story is repeated several times over the height of the building and this is represented by the multiplier, the unique story included in this list should be the first (lowest) story of the repeated floors.</param>
        /// <param name="room3ds">An optional array of 3D Honeybee Room objects for additional Rooms that are a part of the Building but are not represented within the unique_stories. This is useful when there are parts of the Building geometry that cannot easily be represented with the extruded floor plate and sloped roof assumptions that underlie Dragonfly Room2Ds and RoofSpecification. Cases where this input is most useful include sloped walls and certain types of domed roofs that become tedious to implement with RoofSpecification. Matching the Honeybee Room.story property to the Dragonfly Story.display_name of an object within the unique_stories will effectively place the Honeybee Room on that Story for the purposes of floor_area, exterior_wall_area, etc. However, note that the Honeybee Room.multiplier property takes precedence over whatever multiplier is assigned to the Dragonfly Story that the Room.story may reference. (Default: None).</param>
        /// <param name="roof">An optional RoofSpecification object that provides an alternative way to describe roof geometry over rooms (instead of specifying roofs on each story). If trying to decide between the two, specifying geometry on each story is closer to how dragonfly natively works with roof geometry as it relates to rooms. However, when it is unknown which roof geometries correspond to which stories, this Building-level attribute may be used and each roof geometry will automatically be added to the best Story in the Building upon serialization to Python. This automatic assignment will happen by checking for overlaps between the Story Room2Ds and the Roof geometry in plan. When a given roof geometry overlaps with several Stories, the top-most Story will get the roof geometry assigned to it unless this top Story has a floor_height above the roof geometry, in which case the next highest story will be checked until a compatible one is found.</param>
        public Building
        (
            string identifier, BuildingPropertiesAbridged properties, string displayName = default, object userData = default, List<Story> uniqueStories = default, List<Room> room3ds = default, RoofSpecification roof = default
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.Properties = properties ?? throw new System.ArgumentNullException("properties is a required property for Building and cannot be null");
            this.UniqueStories = uniqueStories;
            this.Room3ds = room3ds;
            this.Roof = roof;

            // Set readonly properties with defaultValue
            this.Type = "Building";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Building))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        [Summary(@"Extension properties for particular simulation engines (Radiance, EnergyPlus).")]
        [Required]
        [DataMember(Name = "properties", IsRequired = true)]
        public BuildingPropertiesAbridged Properties { get; set; }

        /// <summary>
        /// An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor, though this is not required. Note that, if a given Story is repeated several times over the height of the building and this is represented by the multiplier, the unique story included in this list should be the first (lowest) story of the repeated floors.
        /// </summary>
        [Summary(@"An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor, though this is not required. Note that, if a given Story is repeated several times over the height of the building and this is represented by the multiplier, the unique story included in this list should be the first (lowest) story of the repeated floors.")]
        [DataMember(Name = "unique_stories")]
        public List<Story> UniqueStories { get; set; }

        /// <summary>
        /// An optional array of 3D Honeybee Room objects for additional Rooms that are a part of the Building but are not represented within the unique_stories. This is useful when there are parts of the Building geometry that cannot easily be represented with the extruded floor plate and sloped roof assumptions that underlie Dragonfly Room2Ds and RoofSpecification. Cases where this input is most useful include sloped walls and certain types of domed roofs that become tedious to implement with RoofSpecification. Matching the Honeybee Room.story property to the Dragonfly Story.display_name of an object within the unique_stories will effectively place the Honeybee Room on that Story for the purposes of floor_area, exterior_wall_area, etc. However, note that the Honeybee Room.multiplier property takes precedence over whatever multiplier is assigned to the Dragonfly Story that the Room.story may reference. (Default: None).
        /// </summary>
        [Summary(@"An optional array of 3D Honeybee Room objects for additional Rooms that are a part of the Building but are not represented within the unique_stories. This is useful when there are parts of the Building geometry that cannot easily be represented with the extruded floor plate and sloped roof assumptions that underlie Dragonfly Room2Ds and RoofSpecification. Cases where this input is most useful include sloped walls and certain types of domed roofs that become tedious to implement with RoofSpecification. Matching the Honeybee Room.story property to the Dragonfly Story.display_name of an object within the unique_stories will effectively place the Honeybee Room on that Story for the purposes of floor_area, exterior_wall_area, etc. However, note that the Honeybee Room.multiplier property takes precedence over whatever multiplier is assigned to the Dragonfly Story that the Room.story may reference. (Default: None).")]
        [DataMember(Name = "room_3ds")]
        public List<Room> Room3ds { get; set; }

        /// <summary>
        /// An optional RoofSpecification object that provides an alternative way to describe roof geometry over rooms (instead of specifying roofs on each story). If trying to decide between the two, specifying geometry on each story is closer to how dragonfly natively works with roof geometry as it relates to rooms. However, when it is unknown which roof geometries correspond to which stories, this Building-level attribute may be used and each roof geometry will automatically be added to the best Story in the Building upon serialization to Python. This automatic assignment will happen by checking for overlaps between the Story Room2Ds and the Roof geometry in plan. When a given roof geometry overlaps with several Stories, the top-most Story will get the roof geometry assigned to it unless this top Story has a floor_height above the roof geometry, in which case the next highest story will be checked until a compatible one is found.
        /// </summary>
        [Summary(@"An optional RoofSpecification object that provides an alternative way to describe roof geometry over rooms (instead of specifying roofs on each story). If trying to decide between the two, specifying geometry on each story is closer to how dragonfly natively works with roof geometry as it relates to rooms. However, when it is unknown which roof geometries correspond to which stories, this Building-level attribute may be used and each roof geometry will automatically be added to the best Story in the Building upon serialization to Python. This automatic assignment will happen by checking for overlaps between the Story Room2Ds and the Roof geometry in plan. When a given roof geometry overlaps with several Stories, the top-most Story will get the roof geometry assigned to it unless this top Story has a floor_height above the roof geometry, in which case the next highest story will be checked until a compatible one is found.")]
        [DataMember(Name = "roof")]
        public RoofSpecification Roof { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Building";
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
            sb.Append("Building:\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  Properties: ").Append(this.Properties).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  UniqueStories: ").Append(this.UniqueStories).Append("\n");
            sb.Append("  Room3ds: ").Append(this.Room3ds).Append("\n");
            sb.Append("  Roof: ").Append(this.Roof).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Building object</returns>
        public static Building FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Building>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Building object</returns>
        public virtual Building DuplicateBuilding()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdBaseModel</returns>
        public override IDdBaseModel DuplicateIDdBaseModel()
        {
            return DuplicateBuilding();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Building);
        }


        /// <summary>
        /// Returns true if Building instances are equal
        /// </summary>
        /// <param name="input">Instance of Building to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Building input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Properties, input.Properties) && 
                    Extension.AllEquals(this.UniqueStories, input.UniqueStories) && 
                    Extension.AllEquals(this.Room3ds, input.Room3ds) && 
                    Extension.Equals(this.Roof, input.Roof);
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
                if (this.UniqueStories != null)
                    hashCode = hashCode * 59 + this.UniqueStories.GetHashCode();
                if (this.Room3ds != null)
                    hashCode = hashCode * 59 + this.Room3ds.GetHashCode();
                if (this.Roof != null)
                    hashCode = hashCode * 59 + this.Roof.GetHashCode();
                return hashCode;
            }
        }


    }
}
