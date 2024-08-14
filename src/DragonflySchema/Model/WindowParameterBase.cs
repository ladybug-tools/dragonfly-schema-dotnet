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
    /// Base class for all window parameters.
    /// </summary>
    [Summary(@"Base class for all window parameters.")]
    [System.Serializable]
    [DataContract(Name = "_WindowParameterBase")]
    public partial class WindowParameterBase : OpenAPIGenBaseModel, System.IEquatable<WindowParameterBase>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowParameterBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindowParameterBase() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "_WindowParameterBase";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowParameterBase" /> class.
        /// </summary>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.</param>
        public WindowParameterBase
        (
            object userData = default
        ) : base()
        {
            this.UserData = userData;

            // Set readonly properties with defaultValue
            this.Type = "_WindowParameterBase";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(WindowParameterBase))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.
        /// </summary>
        [Summary(@"Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures.")]
        [DataMember(Name = "user_data")]
        public object UserData { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "WindowParameterBase";
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
            sb.Append("WindowParameterBase:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>WindowParameterBase object</returns>
        public static WindowParameterBase FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<WindowParameterBase>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowParameterBase object</returns>
        public virtual WindowParameterBase DuplicateWindowParameterBase()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateWindowParameterBase();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as WindowParameterBase);
        }


        /// <summary>
        /// Returns true if WindowParameterBase instances are equal
        /// </summary>
        /// <param name="input">Instance of WindowParameterBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindowParameterBase input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.UserData, input.UserData);
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
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                return hashCode;
            }
        }


    }
}
