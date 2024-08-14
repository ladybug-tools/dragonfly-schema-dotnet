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
    [DataContract(Name = "Room2DRadiancePropertiesAbridged")]
    public partial class Room2DRadiancePropertiesAbridged : OpenAPIGenBaseModel, System.IEquatable<Room2DRadiancePropertiesAbridged>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DRadiancePropertiesAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Room2DRadiancePropertiesAbridged() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Room2DRadiancePropertiesAbridged";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2DRadiancePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="modifierSet">Identifier of a ModifierSet to specify all modifiers for the Room2D. If None, the Room2D will use the Story or Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects.</param>
        /// <param name="gridParameters">An optional list of GridParameter objects to describe how sensor grids should be generated for the Room2D.</param>
        public Room2DRadiancePropertiesAbridged
        (
            string modifierSet = default, List<AnyOf<RoomGridParameter, RoomRadialGridParameter, ExteriorFaceGridParameter, ExteriorApertureGridParameter>> gridParameters = default
        ) : base()
        {
            this.ModifierSet = modifierSet;
            this.GridParameters = gridParameters;

            // Set readonly properties with defaultValue
            this.Type = "Room2DRadiancePropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Room2DRadiancePropertiesAbridged))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Identifier of a ModifierSet to specify all modifiers for the Room2D. If None, the Room2D will use the Story or Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects.
        /// </summary>
        [Summary(@"Identifier of a ModifierSet to specify all modifiers for the Room2D. If None, the Room2D will use the Story or Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects.")]
        [DataMember(Name = "modifier_set")]
        public string ModifierSet { get; set; }

        /// <summary>
        /// An optional list of GridParameter objects to describe how sensor grids should be generated for the Room2D.
        /// </summary>
        [Summary(@"An optional list of GridParameter objects to describe how sensor grids should be generated for the Room2D.")]
        [DataMember(Name = "grid_parameters")]
        public List<AnyOf<RoomGridParameter, RoomRadialGridParameter, ExteriorFaceGridParameter, ExteriorApertureGridParameter>> GridParameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Room2DRadiancePropertiesAbridged";
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
            sb.Append("Room2DRadiancePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ModifierSet: ").Append(this.ModifierSet).Append("\n");
            sb.Append("  GridParameters: ").Append(this.GridParameters).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Room2DRadiancePropertiesAbridged object</returns>
        public static Room2DRadiancePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Room2DRadiancePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Room2DRadiancePropertiesAbridged object</returns>
        public virtual Room2DRadiancePropertiesAbridged DuplicateRoom2DRadiancePropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateRoom2DRadiancePropertiesAbridged();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Room2DRadiancePropertiesAbridged);
        }


        /// <summary>
        /// Returns true if Room2DRadiancePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of Room2DRadiancePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Room2DRadiancePropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.ModifierSet, input.ModifierSet) && 
                    Extension.AllEquals(this.GridParameters, input.GridParameters);
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
                if (this.GridParameters != null)
                    hashCode = hashCode * 59 + this.GridParameters.GetHashCode();
                return hashCode;
            }
        }


    }
}
