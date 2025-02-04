import { IsArray, IsDefined, IsNumber, IsInstance, ValidateNested, IsString, IsOptional, Matches, IsBoolean, Min, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
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
    /** A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values. */
    floor_boundary!: number [] [];
	
    @IsNumber()
    @IsDefined()
    /** A number to indicate the height of the floor plane in the Z axis. */
    floor_height!: number;
	
    @IsNumber()
    @IsDefined()
    /** A number for the distance between the floor and the ceiling. */
    floor_to_ceiling_height!: number;
	
    @IsInstance(Room2DPropertiesAbridged)
    @Type(() => Room2DPropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: Room2DPropertiesAbridged;
	
    @IsString()
    @IsOptional()
    @Matches(/^Room2D$/)
    type?: string;
	
    @IsArray()
    @IsNestedNumberArray()
    @IsOptional()
    /** Optional list of lists with one list for each hole in the floor plate. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate. */
    floor_holes?: number [] [] [];
	
    @IsBoolean()
    @IsOptional()
    /** A boolean noting whether this Room2D has its floor in contact with the ground. */
    is_ground_contact?: boolean;
	
    @IsBoolean()
    @IsOptional()
    /** A boolean noting whether this Room2D has its ceiling exposed to the outdoors. */
    is_top_exposed?: boolean;
	
    @IsBoolean()
    @IsOptional()
    /** A boolean for whether the room has a Floor (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D below this one with a has_ceiling property set to False. */
    has_floor?: boolean;
	
    @IsBoolean()
    @IsOptional()
    /** A boolean for whether the room has a RoofCeiling (True) or an AirBoundary (False). If False, this property will only be meaningful if the model is translated to Honeybee with ceiling adjacency solved and there is a Room2D above this one with a has_floor property set to False. */
    has_ceiling?: boolean;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    /** A number for the depth that a ceiling plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The bottom of this ceiling plenum will always be at this Room2D ceiling height minus the value specified here. Setting this to zero indicates that the room has no ceiling plenum. */
    ceiling_plenum_depth?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    /** A number for the depth that a floor plenum extends into the room. Setting this to a positive value will result in a separate plenum room being split off of the Room2D volume during translation from Dragonfly to Honeybee. The top of this floor plenum will always be at this Room2D floor height plus the value specified here. Setting this to zero indicates that the room has no floor plenum. */
    floor_plenum_depth?: number;
	
    @IsArray()
    @IsOptional()
    @Transform(({ value }) => value.map((item: any) => {
      if (item?.type === 'Ground') return Ground.fromJS(item);
      else if (item?.type === 'Outdoors') return Outdoors.fromJS(item);
      else if (item?.type === 'Surface') return Surface.fromJS(item);
      else if (item?.type === 'Adiabatic') return Adiabatic.fromJS(item);
      else if (item?.type === 'OtherSideTemperature') return OtherSideTemperature.fromJS(item);
      else return item;
    }))
    /** A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane). */
    boundary_conditions?: (Ground | Outdoors | Surface | Adiabatic | OtherSideTemperature) [];
	
    @IsArray()
    @IsOptional()
    @Transform(({ value }) => value.map((item: any) => {
      if (item?.type === 'SingleWindow') return SingleWindow.fromJS(item);
      else if (item?.type === 'SimpleWindowArea') return SimpleWindowArea.fromJS(item);
      else if (item?.type === 'SimpleWindowRatio') return SimpleWindowRatio.fromJS(item);
      else if (item?.type === 'RepeatingWindowRatio') return RepeatingWindowRatio.fromJS(item);
      else if (item?.type === 'RectangularWindows') return RectangularWindows.fromJS(item);
      else if (item?.type === 'DetailedWindows') return DetailedWindows.fromJS(item);
      else return item;
    }))
    /** A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D. */
    window_parameters?: (SingleWindow | SimpleWindowArea | SimpleWindowRatio | RepeatingWindowRatio | RectangularWindows | DetailedWindows) [];
	
    @IsArray()
    @IsOptional()
    @Transform(({ value }) => value.map((item: any) => {
      if (item?.type === 'ExtrudedBorder') return ExtrudedBorder.fromJS(item);
      else if (item?.type === 'Overhang') return Overhang.fromJS(item);
      else if (item?.type === 'LouversByDistance') return LouversByDistance.fromJS(item);
      else if (item?.type === 'LouversByCount') return LouversByCount.fromJS(item);
      else return item;
    }))
    /** A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D. */
    shading_parameters?: (ExtrudedBorder | Overhang | LouversByDistance | LouversByCount) [];
	
    @IsArray()
    @IsBoolean({ each: true })
    @IsOptional()
    /** A list of booleans for whether each wall has an air boundary type. False values indicate a standard opaque type while True values indicate an AirBoundary type. All walls will be False by default. Note that any walls with a True air boundary must have a Surface boundary condition without any windows. */
    air_boundaries?: boolean [];
	
    @IsOptional()
    @Transform(({ value }) => {
      const item = value;
      if (item?.type === 'GriddedSkylightArea') return GriddedSkylightArea.fromJS(item);
      else if (item?.type === 'GriddedSkylightRatio') return GriddedSkylightRatio.fromJS(item);
      else if (item?.type === 'DetailedSkylights') return DetailedSkylights.fromJS(item);
      else return item;
    })
    /** A SkylightParameter object describing how to generate skylights. If None, no skylights will exist on the Room2D. */
    skylight_parameters?: (GriddedSkylightArea | GriddedSkylightRatio | DetailedSkylights);
	

    constructor() {
        super();
        this.type = "Room2D";
        this.is_ground_contact = false;
        this.is_top_exposed = false;
        this.has_floor = true;
        this.has_ceiling = true;
        this.ceiling_plenum_depth = 0;
        this.floor_plenum_depth = 0;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Room2D, _data, { enableImplicitConversion: true });
            this.floor_boundary = obj.floor_boundary;
            this.floor_height = obj.floor_height;
            this.floor_to_ceiling_height = obj.floor_to_ceiling_height;
            this.properties = obj.properties;
            this.type = obj.type;
            this.floor_holes = obj.floor_holes;
            this.is_ground_contact = obj.is_ground_contact;
            this.is_top_exposed = obj.is_top_exposed;
            this.has_floor = obj.has_floor;
            this.has_ceiling = obj.has_ceiling;
            this.ceiling_plenum_depth = obj.ceiling_plenum_depth;
            this.floor_plenum_depth = obj.floor_plenum_depth;
            this.boundary_conditions = obj.boundary_conditions;
            this.window_parameters = obj.window_parameters;
            this.shading_parameters = obj.shading_parameters;
            this.air_boundaries = obj.air_boundaries;
            this.skylight_parameters = obj.skylight_parameters;
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
        data["floor_boundary"] = this.floor_boundary;
        data["floor_height"] = this.floor_height;
        data["floor_to_ceiling_height"] = this.floor_to_ceiling_height;
        data["properties"] = this.properties;
        data["type"] = this.type;
        data["floor_holes"] = this.floor_holes;
        data["is_ground_contact"] = this.is_ground_contact;
        data["is_top_exposed"] = this.is_top_exposed;
        data["has_floor"] = this.has_floor;
        data["has_ceiling"] = this.has_ceiling;
        data["ceiling_plenum_depth"] = this.ceiling_plenum_depth;
        data["floor_plenum_depth"] = this.floor_plenum_depth;
        data["boundary_conditions"] = this.boundary_conditions;
        data["window_parameters"] = this.window_parameters;
        data["shading_parameters"] = this.shading_parameters;
        data["air_boundaries"] = this.air_boundaries;
        data["skylight_parameters"] = this.skylight_parameters;
        data = super.toJSON(data);
        return instanceToPlain(data);
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

