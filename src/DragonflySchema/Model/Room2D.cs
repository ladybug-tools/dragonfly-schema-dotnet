/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.12
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
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [DataContract]
    public partial class Room2D : IDdBaseModel, IEquatable<Room2D>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Room2D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Room2D() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2D" /> class.
        /// </summary>
        /// <param name="floorBoundary">A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values. (required).</param>
        /// <param name="floorHeight">A number to indicate the height of the floor plane in the Z axis. (required).</param>
        /// <param name="floorToCeilingHeight">A number for the distance between the floor and the ceiling. (required).</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="floorHoles">Optional list of lists with one list for each hole in the floor plate.Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate..</param>
        /// <param name="isGroundContact">A boolean noting whether this Room2D has its floor in contact with the ground. (default to false).</param>
        /// <param name="isTopExposed">A boolean noting whether this Room2D has its ceiling exposed to the outdoors. (default to false).</param>
        /// <param name="boundaryConditions">A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane)..</param>
        /// <param name="windowParameters">A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D..</param>
        /// <param name="shadingParameters">A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public Room2D
        (
            string identifier, List<List<double>> floorBoundary, double floorHeight, double floorToCeilingHeight, Room2DPropertiesAbridged properties, // Required parameters
            string displayName= default, Object userData= default, List<List<List<double>>> floorHoles= default, bool isGroundContact = false, bool isTopExposed = false, List<AnyOf<Ground,Outdoors,Adiabatic,Surface>> boundaryConditions= default, List<AnyOf<SingleWindow,SimpleWindowRatio,RepeatingWindowRatio,RectangularWindows,DetailedWindows>> windowParameters= default, List<AnyOf<ExtrudedBorder,Overhang,LouversByDistance,LouversByCount>> shadingParameters= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData )// BaseClass
        {
            // to ensure "floorBoundary" is required (not null)
            if (floorBoundary == null)
            {
                throw new InvalidDataException("floorBoundary is a required property for Room2D and cannot be null");
            }
            else
            {
                this.FloorBoundary = floorBoundary;
            }
            
            // to ensure "floorHeight" is required (not null)
            if (floorHeight == null)
            {
                throw new InvalidDataException("floorHeight is a required property for Room2D and cannot be null");
            }
            else
            {
                this.FloorHeight = floorHeight;
            }
            
            // to ensure "floorToCeilingHeight" is required (not null)
            if (floorToCeilingHeight == null)
            {
                throw new InvalidDataException("floorToCeilingHeight is a required property for Room2D and cannot be null");
            }
            else
            {
                this.FloorToCeilingHeight = floorToCeilingHeight;
            }
            
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new InvalidDataException("properties is a required property for Room2D and cannot be null");
            }
            else
            {
                this.Properties = properties;
            }
            
            this.FloorHoles = floorHoles;
            // use default value if no "isGroundContact" provided
            if (isGroundContact == null)
            {
                this.IsGroundContact = false;
            }
            else
            {
                this.IsGroundContact = isGroundContact;
            }
            // use default value if no "isTopExposed" provided
            if (isTopExposed == null)
            {
                this.IsTopExposed = false;
            }
            else
            {
                this.IsTopExposed = isTopExposed;
            }
            this.BoundaryConditions = boundaryConditions;
            this.WindowParameters = windowParameters;
            this.ShadingParameters = shadingParameters;

            // Set non-required readonly properties with defaultValue
            this.Type = "Room2D";
        }
        
        /// <summary>
        /// A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values.
        /// </summary>
        /// <value>A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values.</value>
        [DataMember(Name="floor_boundary", EmitDefaultValue=false)]
        [JsonProperty("floor_boundary")]
        public List<List<double>> FloorBoundary { get; set; }
        /// <summary>
        /// A number to indicate the height of the floor plane in the Z axis.
        /// </summary>
        /// <value>A number to indicate the height of the floor plane in the Z axis.</value>
        [DataMember(Name="floor_height", EmitDefaultValue=false)]
        [JsonProperty("floor_height")]
        public double FloorHeight { get; set; }
        /// <summary>
        /// A number for the distance between the floor and the ceiling.
        /// </summary>
        /// <value>A number for the distance between the floor and the ceiling.</value>
        [DataMember(Name="floor_to_ceiling_height", EmitDefaultValue=false)]
        [JsonProperty("floor_to_ceiling_height")]
        public double FloorToCeilingHeight { get; set; }
        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        [JsonProperty("properties")]
        public Room2DPropertiesAbridged Properties { get; set; }
        /// <summary>
        /// Optional list of lists with one list for each hole in the floor plate.Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate.
        /// </summary>
        /// <value>Optional list of lists with one list for each hole in the floor plate.Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate.</value>
        [DataMember(Name="floor_holes", EmitDefaultValue=false)]
        [JsonProperty("floor_holes")]
        public List<List<List<double>>> FloorHoles { get; set; }
        /// <summary>
        /// A boolean noting whether this Room2D has its floor in contact with the ground.
        /// </summary>
        /// <value>A boolean noting whether this Room2D has its floor in contact with the ground.</value>
        [DataMember(Name="is_ground_contact", EmitDefaultValue=false)]
        [JsonProperty("is_ground_contact")]
        public bool IsGroundContact { get; set; }
        /// <summary>
        /// A boolean noting whether this Room2D has its ceiling exposed to the outdoors.
        /// </summary>
        /// <value>A boolean noting whether this Room2D has its ceiling exposed to the outdoors.</value>
        [DataMember(Name="is_top_exposed", EmitDefaultValue=false)]
        [JsonProperty("is_top_exposed")]
        public bool IsTopExposed { get; set; }
        /// <summary>
        /// A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane).
        /// </summary>
        /// <value>A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane).</value>
        [DataMember(Name="boundary_conditions", EmitDefaultValue=false)]
        [JsonProperty("boundary_conditions")]
        public List<AnyOf<Ground,Outdoors,Adiabatic,Surface>> BoundaryConditions { get; set; }
        /// <summary>
        /// A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D.
        /// </summary>
        /// <value>A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D.</value>
        [DataMember(Name="window_parameters", EmitDefaultValue=false)]
        [JsonProperty("window_parameters")]
        public List<AnyOf<SingleWindow,SimpleWindowRatio,RepeatingWindowRatio,RectangularWindows,DetailedWindows>> WindowParameters { get; set; }
        /// <summary>
        /// A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D.
        /// </summary>
        /// <value>A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D.</value>
        [DataMember(Name="shading_parameters", EmitDefaultValue=false)]
        [JsonProperty("shading_parameters")]
        public List<AnyOf<ExtrudedBorder,Overhang,LouversByDistance,LouversByCount>> ShadingParameters { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Room2D {iDd.Identifier}";
       
            return "Room2D";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public string ToString(bool detailed)
        {
            if (detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("Room2D:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FloorBoundary: ").Append(FloorBoundary).Append("\n");
            sb.Append("  FloorHeight: ").Append(FloorHeight).Append("\n");
            sb.Append("  FloorToCeilingHeight: ").Append(FloorToCeilingHeight).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  FloorHoles: ").Append(FloorHoles).Append("\n");
            sb.Append("  IsGroundContact: ").Append(IsGroundContact).Append("\n");
            sb.Append("  IsTopExposed: ").Append(IsTopExposed).Append("\n");
            sb.Append("  BoundaryConditions: ").Append(BoundaryConditions).Append("\n");
            sb.Append("  WindowParameters: ").Append(WindowParameters).Append("\n");
            sb.Append("  ShadingParameters: ").Append(ShadingParameters).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Room2D object</returns>
        public static Room2D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Room2D>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Room2D);
        }

        /// <summary>
        /// Returns true if Room2D instances are equal
        /// </summary>
        /// <param name="input">Instance of Room2D to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Room2D input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.FloorBoundary == input.FloorBoundary ||
                    this.FloorBoundary != null &&
                    input.FloorBoundary != null &&
                    this.FloorBoundary.SequenceEqual(input.FloorBoundary)
                ) && base.Equals(input) && 
                (
                    this.FloorHeight == input.FloorHeight ||
                    (this.FloorHeight != null &&
                    this.FloorHeight.Equals(input.FloorHeight))
                ) && base.Equals(input) && 
                (
                    this.FloorToCeilingHeight == input.FloorToCeilingHeight ||
                    (this.FloorToCeilingHeight != null &&
                    this.FloorToCeilingHeight.Equals(input.FloorToCeilingHeight))
                ) && base.Equals(input) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.FloorHoles == input.FloorHoles ||
                    this.FloorHoles != null &&
                    input.FloorHoles != null &&
                    this.FloorHoles.SequenceEqual(input.FloorHoles)
                ) && base.Equals(input) && 
                (
                    this.IsGroundContact == input.IsGroundContact ||
                    (this.IsGroundContact != null &&
                    this.IsGroundContact.Equals(input.IsGroundContact))
                ) && base.Equals(input) && 
                (
                    this.IsTopExposed == input.IsTopExposed ||
                    (this.IsTopExposed != null &&
                    this.IsTopExposed.Equals(input.IsTopExposed))
                ) && base.Equals(input) && 
                (
                    this.BoundaryConditions == input.BoundaryConditions ||
                    this.BoundaryConditions != null &&
                    input.BoundaryConditions != null &&
                    this.BoundaryConditions.SequenceEqual(input.BoundaryConditions)
                ) && base.Equals(input) && 
                (
                    this.WindowParameters == input.WindowParameters ||
                    this.WindowParameters != null &&
                    input.WindowParameters != null &&
                    this.WindowParameters.SequenceEqual(input.WindowParameters)
                ) && base.Equals(input) && 
                (
                    this.ShadingParameters == input.ShadingParameters ||
                    this.ShadingParameters != null &&
                    input.ShadingParameters != null &&
                    this.ShadingParameters.SequenceEqual(input.ShadingParameters)
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
                int hashCode = base.GetHashCode();
                if (this.FloorBoundary != null)
                    hashCode = hashCode * 59 + this.FloorBoundary.GetHashCode();
                if (this.FloorHeight != null)
                    hashCode = hashCode * 59 + this.FloorHeight.GetHashCode();
                if (this.FloorToCeilingHeight != null)
                    hashCode = hashCode * 59 + this.FloorToCeilingHeight.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FloorHoles != null)
                    hashCode = hashCode * 59 + this.FloorHoles.GetHashCode();
                if (this.IsGroundContact != null)
                    hashCode = hashCode * 59 + this.IsGroundContact.GetHashCode();
                if (this.IsTopExposed != null)
                    hashCode = hashCode * 59 + this.IsTopExposed.GetHashCode();
                if (this.BoundaryConditions != null)
                    hashCode = hashCode * 59 + this.BoundaryConditions.GetHashCode();
                if (this.WindowParameters != null)
                    hashCode = hashCode * 59 + this.WindowParameters.GetHashCode();
                if (this.ShadingParameters != null)
                    hashCode = hashCode * 59 + this.ShadingParameters.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // Type (string) pattern
            Regex regexType = new Regex(@"^Room2D$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
