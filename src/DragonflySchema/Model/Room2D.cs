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
    [DataContract(Name = "Room2D")]
    public partial class Room2D : IDdBaseModel, System.IEquatable<Room2D>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2D" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Room2D() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "Room2D";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Room2D" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be < 100 characters and not contain any spaces or special characters.</param>
        /// <param name="floorBoundary">A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values.</param>
        /// <param name="floorHeight">A number to indicate the height of the floor plane in the Z axis.</param>
        /// <param name="floorToCeilingHeight">A number for the distance between the floor and the ceiling.</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus).</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="floorHoles">Optional list of lists with one list for each hole in the floor plate. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate.</param>
        /// <param name="isGroundContact">A boolean noting whether this Room2D has its floor in contact with the ground.</param>
        /// <param name="isTopExposed">A boolean noting whether this Room2D has its ceiling exposed to the outdoors.</param>
        /// <param name="hasFloor">A boolean for whether the room has a Floor (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D below this one with a has_ceiling property set to False.</param>
        /// <param name="hasCeiling">A boolean for whether the room has a RoofCeiling (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D above this one with a has_floor property set to False.</param>
        /// <param name="ceilingPlenumDepth">A number for the depth that a ceiling plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The bottom of this ceiling plenum will always be at this Room2D ceiling height minus the value specified here. Setting this to zero indicates that the room has no ceiling plenum.</param>
        /// <param name="floorPlenumDepth">A number for the depth that a floor plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The top of this floor plenum will always be at this Room2D floor height plus the value specified here. Setting this to zero indicates that the room has no floor plenum.</param>
        /// <param name="boundaryConditions">A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane).</param>
        /// <param name="windowParameters">A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D.</param>
        /// <param name="shadingParameters">A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D.</param>
        /// <param name="airBoundaries">A list of booleans for whether each wall has an air boundary type. False values indicate a standard opaque type while True values indicate an AirBoundary type. All walls will be False by default. Note that any walls with a True air boundary must have a Surface boundary condition without any windows.</param>
        /// <param name="skylightParameters">A SkylightParameter object describing how to generate skylights. If None, no skylights will exist on the Room2D.</param>
        public Room2D
        (
            string identifier, List<List<double>> floorBoundary, double floorHeight, double floorToCeilingHeight, Room2DPropertiesAbridged properties, string displayName = default, object userData = default, List<List<List<double>>> floorHoles = default, bool isGroundContact = false, bool isTopExposed = false, bool hasFloor = true, bool hasCeiling = true, double ceilingPlenumDepth = 0D, double floorPlenumDepth = 0D, List<AnyOf<Ground, Outdoors, Surface, Adiabatic, OtherSideTemperature>> boundaryConditions = default, List<AnyOf<SingleWindow, SimpleWindowArea, SimpleWindowRatio, RepeatingWindowRatio, RectangularWindows, DetailedWindows>> windowParameters = default, List<AnyOf<ExtrudedBorder, Overhang, LouversByDistance, LouversByCount>> shadingParameters = default, List<bool> airBoundaries = default, AnyOf<GriddedSkylightArea, GriddedSkylightRatio, DetailedSkylights> skylightParameters = default
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.FloorBoundary = floorBoundary ?? throw new System.ArgumentNullException("floorBoundary is a required property for Room2D and cannot be null");
            this.FloorHeight = floorHeight;
            this.FloorToCeilingHeight = floorToCeilingHeight;
            this.Properties = properties ?? throw new System.ArgumentNullException("properties is a required property for Room2D and cannot be null");
            this.FloorHoles = floorHoles;
            this.IsGroundContact = isGroundContact;
            this.IsTopExposed = isTopExposed;
            this.HasFloor = hasFloor;
            this.HasCeiling = hasCeiling;
            this.CeilingPlenumDepth = ceilingPlenumDepth;
            this.FloorPlenumDepth = floorPlenumDepth;
            this.BoundaryConditions = boundaryConditions;
            this.WindowParameters = windowParameters;
            this.ShadingParameters = shadingParameters;
            this.AirBoundaries = airBoundaries;
            this.SkylightParameters = skylightParameters;

            // Set readonly properties with defaultValue
            this.Type = "Room2D";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Room2D))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values.
        /// </summary>
        [Summary(@"A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values.")]
        [Required]
        [DataMember(Name = "floor_boundary", IsRequired = true)]
        public List<List<double>> FloorBoundary { get; set; }

        /// <summary>
        /// A number to indicate the height of the floor plane in the Z axis.
        /// </summary>
        [Summary(@"A number to indicate the height of the floor plane in the Z axis.")]
        [Required]
        [DataMember(Name = "floor_height", IsRequired = true)]
        public double FloorHeight { get; set; }

        /// <summary>
        /// A number for the distance between the floor and the ceiling.
        /// </summary>
        [Summary(@"A number for the distance between the floor and the ceiling.")]
        [Required]
        [DataMember(Name = "floor_to_ceiling_height", IsRequired = true)]
        public double FloorToCeilingHeight { get; set; }

        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        [Summary(@"Extension properties for particular simulation engines (Radiance, EnergyPlus).")]
        [Required]
        [DataMember(Name = "properties", IsRequired = true)]
        public Room2DPropertiesAbridged Properties { get; set; }

        /// <summary>
        /// Optional list of lists with one list for each hole in the floor plate. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate.
        /// </summary>
        [Summary(@"Optional list of lists with one list for each hole in the floor plate. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate.")]
        [DataMember(Name = "floor_holes")]
        public List<List<List<double>>> FloorHoles { get; set; }

        /// <summary>
        /// A boolean noting whether this Room2D has its floor in contact with the ground.
        /// </summary>
        [Summary(@"A boolean noting whether this Room2D has its floor in contact with the ground.")]
        [DataMember(Name = "is_ground_contact")]
        public bool IsGroundContact { get; set; } = false;

        /// <summary>
        /// A boolean noting whether this Room2D has its ceiling exposed to the outdoors.
        /// </summary>
        [Summary(@"A boolean noting whether this Room2D has its ceiling exposed to the outdoors.")]
        [DataMember(Name = "is_top_exposed")]
        public bool IsTopExposed { get; set; } = false;

        /// <summary>
        /// A boolean for whether the room has a Floor (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D below this one with a has_ceiling property set to False.
        /// </summary>
        [Summary(@"A boolean for whether the room has a Floor (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D below this one with a has_ceiling property set to False.")]
        [DataMember(Name = "has_floor")]
        public bool HasFloor { get; set; } = true;

        /// <summary>
        /// A boolean for whether the room has a RoofCeiling (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D above this one with a has_floor property set to False.
        /// </summary>
        [Summary(@"A boolean for whether the room has a RoofCeiling (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D above this one with a has_floor property set to False.")]
        [DataMember(Name = "has_ceiling")]
        public bool HasCeiling { get; set; } = true;

        /// <summary>
        /// A number for the depth that a ceiling plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The bottom of this ceiling plenum will always be at this Room2D ceiling height minus the value specified here. Setting this to zero indicates that the room has no ceiling plenum.
        /// </summary>
        [Summary(@"A number for the depth that a ceiling plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The bottom of this ceiling plenum will always be at this Room2D ceiling height minus the value specified here. Setting this to zero indicates that the room has no ceiling plenum.")]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "ceiling_plenum_depth")]
        public double CeilingPlenumDepth { get; set; } = 0D;

        /// <summary>
        /// A number for the depth that a floor plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The top of this floor plenum will always be at this Room2D floor height plus the value specified here. Setting this to zero indicates that the room has no floor plenum.
        /// </summary>
        [Summary(@"A number for the depth that a floor plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The top of this floor plenum will always be at this Room2D floor height plus the value specified here. Setting this to zero indicates that the room has no floor plenum.")]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "floor_plenum_depth")]
        public double FloorPlenumDepth { get; set; } = 0D;

        /// <summary>
        /// A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane).
        /// </summary>
        [Summary(@"A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane).")]
        [DataMember(Name = "boundary_conditions")]
        public List<AnyOf<Ground, Outdoors, Surface, Adiabatic, OtherSideTemperature>> BoundaryConditions { get; set; }

        /// <summary>
        /// A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D.
        /// </summary>
        [Summary(@"A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D.")]
        [DataMember(Name = "window_parameters")]
        public List<AnyOf<SingleWindow, SimpleWindowArea, SimpleWindowRatio, RepeatingWindowRatio, RectangularWindows, DetailedWindows>> WindowParameters { get; set; }

        /// <summary>
        /// A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D.
        /// </summary>
        [Summary(@"A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D.")]
        [DataMember(Name = "shading_parameters")]
        public List<AnyOf<ExtrudedBorder, Overhang, LouversByDistance, LouversByCount>> ShadingParameters { get; set; }

        /// <summary>
        /// A list of booleans for whether each wall has an air boundary type. False values indicate a standard opaque type while True values indicate an AirBoundary type. All walls will be False by default. Note that any walls with a True air boundary must have a Surface boundary condition without any windows.
        /// </summary>
        [Summary(@"A list of booleans for whether each wall has an air boundary type. False values indicate a standard opaque type while True values indicate an AirBoundary type. All walls will be False by default. Note that any walls with a True air boundary must have a Surface boundary condition without any windows.")]
        [DataMember(Name = "air_boundaries")]
        public List<bool> AirBoundaries { get; set; }

        /// <summary>
        /// A SkylightParameter object describing how to generate skylights. If None, no skylights will exist on the Room2D.
        /// </summary>
        [Summary(@"A SkylightParameter object describing how to generate skylights. If None, no skylights will exist on the Room2D.")]
        [DataMember(Name = "skylight_parameters")]
        public AnyOf<GriddedSkylightArea, GriddedSkylightRatio, DetailedSkylights> SkylightParameters { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Room2D";
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
            sb.Append("Room2D:\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  FloorBoundary: ").Append(this.FloorBoundary).Append("\n");
            sb.Append("  FloorHeight: ").Append(this.FloorHeight).Append("\n");
            sb.Append("  FloorToCeilingHeight: ").Append(this.FloorToCeilingHeight).Append("\n");
            sb.Append("  Properties: ").Append(this.Properties).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  FloorHoles: ").Append(this.FloorHoles).Append("\n");
            sb.Append("  IsGroundContact: ").Append(this.IsGroundContact).Append("\n");
            sb.Append("  IsTopExposed: ").Append(this.IsTopExposed).Append("\n");
            sb.Append("  HasFloor: ").Append(this.HasFloor).Append("\n");
            sb.Append("  HasCeiling: ").Append(this.HasCeiling).Append("\n");
            sb.Append("  CeilingPlenumDepth: ").Append(this.CeilingPlenumDepth).Append("\n");
            sb.Append("  FloorPlenumDepth: ").Append(this.FloorPlenumDepth).Append("\n");
            sb.Append("  BoundaryConditions: ").Append(this.BoundaryConditions).Append("\n");
            sb.Append("  WindowParameters: ").Append(this.WindowParameters).Append("\n");
            sb.Append("  ShadingParameters: ").Append(this.ShadingParameters).Append("\n");
            sb.Append("  AirBoundaries: ").Append(this.AirBoundaries).Append("\n");
            sb.Append("  SkylightParameters: ").Append(this.SkylightParameters).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Room2D object</returns>
        public static Room2D FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Room2D>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Room2D object</returns>
        public virtual Room2D DuplicateRoom2D()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdBaseModel</returns>
        public override IDdBaseModel DuplicateIDdBaseModel()
        {
            return DuplicateRoom2D();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
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
                    Extension.AllEquals(this.FloorBoundary, input.FloorBoundary) && 
                    Extension.Equals(this.FloorHeight, input.FloorHeight) && 
                    Extension.Equals(this.FloorToCeilingHeight, input.FloorToCeilingHeight) && 
                    Extension.Equals(this.Properties, input.Properties) && 
                    Extension.AllEquals(this.FloorHoles, input.FloorHoles) && 
                    Extension.Equals(this.IsGroundContact, input.IsGroundContact) && 
                    Extension.Equals(this.IsTopExposed, input.IsTopExposed) && 
                    Extension.Equals(this.HasFloor, input.HasFloor) && 
                    Extension.Equals(this.HasCeiling, input.HasCeiling) && 
                    Extension.Equals(this.CeilingPlenumDepth, input.CeilingPlenumDepth) && 
                    Extension.Equals(this.FloorPlenumDepth, input.FloorPlenumDepth) && 
                    Extension.AllEquals(this.BoundaryConditions, input.BoundaryConditions) && 
                    Extension.AllEquals(this.WindowParameters, input.WindowParameters) && 
                    Extension.AllEquals(this.ShadingParameters, input.ShadingParameters) && 
                    Extension.AllEquals(this.AirBoundaries, input.AirBoundaries) && 
                    Extension.Equals(this.SkylightParameters, input.SkylightParameters);
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
                if (this.FloorHoles != null)
                    hashCode = hashCode * 59 + this.FloorHoles.GetHashCode();
                if (this.IsGroundContact != null)
                    hashCode = hashCode * 59 + this.IsGroundContact.GetHashCode();
                if (this.IsTopExposed != null)
                    hashCode = hashCode * 59 + this.IsTopExposed.GetHashCode();
                if (this.HasFloor != null)
                    hashCode = hashCode * 59 + this.HasFloor.GetHashCode();
                if (this.HasCeiling != null)
                    hashCode = hashCode * 59 + this.HasCeiling.GetHashCode();
                if (this.CeilingPlenumDepth != null)
                    hashCode = hashCode * 59 + this.CeilingPlenumDepth.GetHashCode();
                if (this.FloorPlenumDepth != null)
                    hashCode = hashCode * 59 + this.FloorPlenumDepth.GetHashCode();
                if (this.BoundaryConditions != null)
                    hashCode = hashCode * 59 + this.BoundaryConditions.GetHashCode();
                if (this.WindowParameters != null)
                    hashCode = hashCode * 59 + this.WindowParameters.GetHashCode();
                if (this.ShadingParameters != null)
                    hashCode = hashCode * 59 + this.ShadingParameters.GetHashCode();
                if (this.AirBoundaries != null)
                    hashCode = hashCode * 59 + this.AirBoundaries.GetHashCode();
                if (this.SkylightParameters != null)
                    hashCode = hashCode * 59 + this.SkylightParameters.GetHashCode();
                return hashCode;
            }
        }


    }
}
