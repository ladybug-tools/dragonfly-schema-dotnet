import { IsArray, IsDefined, IsNumber, IsInstance, ValidateNested, IsString, IsOptional, Matches, IsBoolean, Min, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { IsNestedNumberArray } from "./../helpers/class-validator";
import { Adiabatic } from "honeybee-schema";
import { DetailedSkylights } from "./DetailedSkylights";
import { DetailedWindows } from "./DetailedWindows";
import { ExtrudedBorder } from "./ExtrudedBorder";
import { GriddedSkylightArea } from "./GriddedSkylightArea";
import { GriddedSkylightRatio } from "./GriddedSkylightRatio";
import { Ground } from "honeybee-schema";
import { IDdBaseModel } from "honeybee-schema";
import { LouversByCount } from "./LouversByCount";
import { LouversByDistance } from "./LouversByDistance";
import { OtherSideTemperature } from "honeybee-schema";
import { Outdoors } from "honeybee-schema";
import { Overhang } from "./Overhang";
import { RectangularWindows } from "./RectangularWindows";
import { RepeatingWindowRatio } from "./RepeatingWindowRatio";
import { Room2DPropertiesAbridged } from "./Room2DPropertiesAbridged";
import { SimpleWindowArea } from "./SimpleWindowArea";
import { SimpleWindowRatio } from "./SimpleWindowRatio";
import { SingleWindow } from "./SingleWindow";
import { Surface } from "honeybee-schema";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Room2D extends IDdBaseModel {
    @IsArray()
    @IsNestedNumberArray()
    @IsDefined()
    @Expose({ name: "floor_boundary" })
    /** A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values. */
    floorBoundary!: number[][];
	
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "floor_height" })
    /** A number to indicate the height of the floor plane in the Z axis. */
    floorHeight!: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "floor_to_ceiling_height" })
    /** A number for the distance between the floor and the ceiling. */
    floorToCeilingHeight!: number;
	
    @Type(() => Room2DPropertiesAbridged)
    @IsInstance(Room2DPropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    @Expose({ name: "properties" })
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: Room2DPropertiesAbridged;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^Room2D$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Room2D";
	
    @IsArray()
    @IsNestedNumberArray()
    @IsOptional()
    @Expose({ name: "floor_holes" })
    /** Optional list of lists with one list for each hole in the floor plate. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate. */
    floorHoles?: number[][][];
	
    @Type(() => Boolean)
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "is_ground_contact" })
    /** A boolean noting whether this Room2D has its floor in contact with the ground. */
    isGroundContact: boolean = false;
	
    @Type(() => Boolean)
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "is_top_exposed" })
    /** A boolean noting whether this Room2D has its ceiling exposed to the outdoors. */
    isTopExposed: boolean = false;
	
    @Type(() => Boolean)
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "has_floor" })
    /** A boolean for whether the room has a Floor (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D below this one with a has_ceiling property set to False. */
    hasFloor: boolean = true;
	
    @Type(() => Boolean)
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "has_ceiling" })
    /** A boolean for whether the room has a RoofCeiling (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D above this one with a has_floor property set to False. */
    hasCeiling: boolean = true;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "ceiling_plenum_depth" })
    /** A number for the depth that a ceiling plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The bottom of this ceiling plenum will always be at this Room2D ceiling height minus the value specified here. Setting this to zero indicates that the room has no ceiling plenum. */
    ceilingPlenumDepth: number = 0;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "floor_plenum_depth" })
    /** A number for the depth that a floor plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The top of this floor plenum will always be at this Room2D floor height plus the value specified here. Setting this to zero indicates that the room has no floor plenum. */
    floorPlenumDepth: number = 0;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Expose({ name: "zone" })
    /** Text string for for the zone identifier to which this Room2D  belongs. Room2Ds sharing the same zone identifier are considered part of the same zone in a Building. If the zone identifier has not been specified, it will be the same as the Room2D identifier in the destination engine. Note that this property has no character restrictions. */
    zone?: string;
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "boundary_conditions" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'Ground') return Ground.fromJS(item);
      else if (item?.type === 'Outdoors') return Outdoors.fromJS(item);
      else if (item?.type === 'Surface') return Surface.fromJS(item);
      else if (item?.type === 'Adiabatic') return Adiabatic.fromJS(item);
      else if (item?.type === 'OtherSideTemperature') return OtherSideTemperature.fromJS(item);
      else return item;
    }))
    /** A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane). */
    boundaryConditions?: (Ground | Outdoors | Surface | Adiabatic | OtherSideTemperature)[];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "window_parameters" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'SingleWindow') return SingleWindow.fromJS(item);
      else if (item?.type === 'SimpleWindowArea') return SimpleWindowArea.fromJS(item);
      else if (item?.type === 'SimpleWindowRatio') return SimpleWindowRatio.fromJS(item);
      else if (item?.type === 'RepeatingWindowRatio') return RepeatingWindowRatio.fromJS(item);
      else if (item?.type === 'RectangularWindows') return RectangularWindows.fromJS(item);
      else if (item?.type === 'DetailedWindows') return DetailedWindows.fromJS(item);
      else return item;
    }))
    /** A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D. */
    windowParameters?: (SingleWindow | SimpleWindowArea | SimpleWindowRatio | RepeatingWindowRatio | RectangularWindows | DetailedWindows)[];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "shading_parameters" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'ExtrudedBorder') return ExtrudedBorder.fromJS(item);
      else if (item?.type === 'Overhang') return Overhang.fromJS(item);
      else if (item?.type === 'LouversByDistance') return LouversByDistance.fromJS(item);
      else if (item?.type === 'LouversByCount') return LouversByCount.fromJS(item);
      else return item;
    }))
    /** A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D. */
    shadingParameters?: (ExtrudedBorder | Overhang | LouversByDistance | LouversByCount)[];
	
    @IsArray()
    @Type(() => Boolean)
    @IsBoolean({ each: true })
    @IsOptional()
    @Expose({ name: "air_boundaries" })
    /** A list of booleans for whether each wall has an air boundary type. False values indicate a standard opaque type while True values indicate an AirBoundary type. All walls will be False by default. Note that any walls with a True air boundary must have a Surface boundary condition without any windows. */
    airBoundaries?: boolean[];
	
    @IsOptional()
    @Expose({ name: "skylight_parameters" })
    @Transform(({ value }) => {
      const item = value;
      if (item?.type === 'GriddedSkylightArea') return GriddedSkylightArea.fromJS(item);
      else if (item?.type === 'GriddedSkylightRatio') return GriddedSkylightRatio.fromJS(item);
      else if (item?.type === 'DetailedSkylights') return DetailedSkylights.fromJS(item);
      else return item;
    })
    /** A SkylightParameter object describing how to generate skylights. If None, no skylights will exist on the Room2D. */
    skylightParameters?: (GriddedSkylightArea | GriddedSkylightRatio | DetailedSkylights);
	

    constructor() {
        super();
        this.type = "Room2D";
        this.isGroundContact = false;
        this.isTopExposed = false;
        this.hasFloor = true;
        this.hasCeiling = true;
        this.ceilingPlenumDepth = 0;
        this.floorPlenumDepth = 0;
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(Room2D, _data);
            this.floorBoundary = obj.floorBoundary;
            this.floorHeight = obj.floorHeight;
            this.floorToCeilingHeight = obj.floorToCeilingHeight;
            this.properties = obj.properties;
            this.type = obj.type ?? "Room2D";
            this.floorHoles = obj.floorHoles;
            this.isGroundContact = obj.isGroundContact ?? false;
            this.isTopExposed = obj.isTopExposed ?? false;
            this.hasFloor = obj.hasFloor ?? true;
            this.hasCeiling = obj.hasCeiling ?? true;
            this.ceilingPlenumDepth = obj.ceilingPlenumDepth ?? 0;
            this.floorPlenumDepth = obj.floorPlenumDepth ?? 0;
            this.zone = obj.zone;
            this.boundaryConditions = obj.boundaryConditions;
            this.windowParameters = obj.windowParameters;
            this.shadingParameters = obj.shadingParameters;
            this.airBoundaries = obj.airBoundaries;
            this.skylightParameters = obj.skylightParameters;
            this.identifier = obj.identifier;
            this.displayName = obj.displayName;
            this.userData = obj.userData;
        }
    }


    static override fromJS(data: any): Room2D {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Room2D();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["floor_boundary"] = this.floorBoundary;
        data["floor_height"] = this.floorHeight;
        data["floor_to_ceiling_height"] = this.floorToCeilingHeight;
        data["properties"] = this.properties;
        data["type"] = this.type ?? "Room2D";
        data["floor_holes"] = this.floorHoles;
        data["is_ground_contact"] = this.isGroundContact ?? false;
        data["is_top_exposed"] = this.isTopExposed ?? false;
        data["has_floor"] = this.hasFloor ?? true;
        data["has_ceiling"] = this.hasCeiling ?? true;
        data["ceiling_plenum_depth"] = this.ceilingPlenumDepth ?? 0;
        data["floor_plenum_depth"] = this.floorPlenumDepth ?? 0;
        data["zone"] = this.zone;
        data["boundary_conditions"] = this.boundaryConditions;
        data["window_parameters"] = this.windowParameters;
        data["shading_parameters"] = this.shadingParameters;
        data["air_boundaries"] = this.airBoundaries;
        data["skylight_parameters"] = this.skylightParameters;
        data = super.toJSON(data);
        return instanceToPlain(data, { exposeUnsetFields: false });
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
