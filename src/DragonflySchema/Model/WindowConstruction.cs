/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.10
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


namespace DragonflySchema
{
    /// <summary>
    /// Construction for window objects (Aperture, Door).
    /// </summary>
    [DataContract]
    public partial class WindowConstruction :  IEquatable<WindowConstruction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstruction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindowConstruction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstruction" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="layers">List of strings for material identifiers. The order of the materials is from exterior to interior. (required).</param>
        /// <param name="materials">List of materials. The order of the materials is from outside to inside. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public WindowConstruction(string identifier, List<string> layers, List<AnyOf<EnergyWindowMaterialGas,EnergyWindowMaterialGasCustom,EnergyWindowMaterialGasMixture,EnergyWindowMaterialSimpleGlazSys,EnergyWindowMaterialBlind,EnergyWindowMaterialGlazing,EnergyWindowMaterialShade>> materials, string displayName = default)
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for WindowConstruction and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            
            // to ensure "layers" is required (not null)
            if (layers == null)
            {
                throw new InvalidDataException("layers is a required property for WindowConstruction and cannot be null");
            }
            else
            {
                this.Layers = layers;
            }
            
            // to ensure "materials" is required (not null)
            if (materials == null)
            {
                throw new InvalidDataException("materials is a required property for WindowConstruction and cannot be null");
            }
            else
            {
                this.Materials = materials;
            }
            
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// List of strings for material identifiers. The order of the materials is from exterior to interior.
        /// </summary>
        /// <value>List of strings for material identifiers. The order of the materials is from exterior to interior.</value>
        [DataMember(Name="layers", EmitDefaultValue=false)]
        [JsonProperty("layers")]
        public List<string> Layers { get; set; }

        /// <summary>
        /// List of materials. The order of the materials is from outside to inside.
        /// </summary>
        /// <value>List of materials. The order of the materials is from outside to inside.</value>
        [DataMember(Name="materials", EmitDefaultValue=false)]
        [JsonProperty("materials")]
        public List<AnyOf<EnergyWindowMaterialGas,EnergyWindowMaterialGasCustom,EnergyWindowMaterialGasMixture,EnergyWindowMaterialSimpleGlazSys,EnergyWindowMaterialBlind,EnergyWindowMaterialGlazing,EnergyWindowMaterialShade>> Materials { get; set; }

        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindowConstruction {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Layers: ").Append(Layers).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>WindowConstruction object</returns>
        public static WindowConstruction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<WindowConstruction>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WindowConstruction);
        }

        /// <summary>
        /// Returns true if WindowConstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of WindowConstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindowConstruction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Layers == input.Layers ||
                    this.Layers != null &&
                    input.Layers != null &&
                    this.Layers.SequenceEqual(input.Layers)
                ) && 
                (
                    this.Materials == input.Materials ||
                    this.Materials != null &&
                    input.Materials != null &&
                    this.Materials.SequenceEqual(input.Materials)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Layers != null)
                    hashCode = hashCode * 59 + this.Layers.GetHashCode();
                if (this.Materials != null)
                    hashCode = hashCode * 59 + this.Materials.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Identifier (string) maxLength
            if(this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            // Identifier (string) minLength
            if(this.Identifier != null && this.Identifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be greater than 1.", new [] { "Identifier" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^WindowConstruction$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
