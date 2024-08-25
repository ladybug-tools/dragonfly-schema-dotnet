import { IsArray, ValidateNested, IsDefined, IsNumber, IsInstance, IsString, IsOptional, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
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
    @ValidateNested({ each: true })
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
    @ValidateNested()
    @IsDefined()
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: Room2DPropertiesAbridged;
	
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsArray()
    @ValidateNested({ each: true })
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
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane). */
    boundary_conditions?: (Ground | Outdoors | Surface | Adiabatic | OtherSideTemperature) [];
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D. */
    window_parameters?: (SingleWindow | SimpleWindowArea | SimpleWindowRatio | RepeatingWindowRatio | RectangularWindows | DetailedWindows) [];
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D. */
    shading_parameters?: (ExtrudedBorder | Overhang | LouversByDistance | LouversByCount) [];
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of booleans for whether each wall has an air boundary type. False values indicate a standard opaque type while True values indicate an AirBoundary type. All walls will be False by default. Note that any walls with a True air boundary must have a Surface boundary condition without any windows. */
    air_boundaries?: boolean [];
	
    @IsOptional()
    /** A SkylightParameter object describing how to generate skylights. If None, no skylights will exist on the Room2D. */
    skylight_parameters?: (GriddedSkylightArea | GriddedSkylightRatio | DetailedSkylights);
	

    constructor() {
        super();
        this.type = "Room2D";
        this.is_ground_contact = false;
        this.is_top_exposed = false;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.floor_boundary = _data["floor_boundary"];
            this.floor_height = _data["floor_height"];
            this.floor_to_ceiling_height = _data["floor_to_ceiling_height"];
            this.properties = _data["properties"];
            this.type = _data["type"] !== undefined ? _data["type"] : "Room2D";
            this.floor_holes = _data["floor_holes"];
            this.is_ground_contact = _data["is_ground_contact"] !== undefined ? _data["is_ground_contact"] : false;
            this.is_top_exposed = _data["is_top_exposed"] !== undefined ? _data["is_top_exposed"] : false;
            this.boundary_conditions = _data["boundary_conditions"];
            this.window_parameters = _data["window_parameters"];
            this.shading_parameters = _data["shading_parameters"];
            this.air_boundaries = _data["air_boundaries"];
            this.skylight_parameters = _data["skylight_parameters"];
        }
    }


    static override fromJS(data: any): Room2D {
        data = typeof data === 'object' ? data : {};

        let result = new Room2D();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["floor_boundary"] = this.floor_boundary;
        data["floor_height"] = this.floor_height;
        data["floor_to_ceiling_height"] = this.floor_to_ceiling_height;
        data["properties"] = this.properties;
        data["type"] = this.type;
        data["floor_holes"] = this.floor_holes;
        data["is_ground_contact"] = this.is_ground_contact;
        data["is_top_exposed"] = this.is_top_exposed;
        data["boundary_conditions"] = this.boundary_conditions;
        data["window_parameters"] = this.window_parameters;
        data["shading_parameters"] = this.shading_parameters;
        data["air_boundaries"] = this.air_boundaries;
        data["skylight_parameters"] = this.skylight_parameters;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || {}).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
