﻿import { IsInstance, ValidateNested, IsDefined, IsString, IsOptional, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { BuildingPropertiesAbridged } from "./BuildingPropertiesAbridged";
import { IDdBaseModel } from "honeybee-schema";
import { RoofSpecification } from "./RoofSpecification";
import { Room } from "honeybee-schema";
import { Story } from "./Story";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Building extends IDdBaseModel {
    @IsInstance(BuildingPropertiesAbridged)
    @Type(() => BuildingPropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: BuildingPropertiesAbridged;
	
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsArray()
    @IsInstance(Story, { each: true })
    @Type(() => Story)
    @ValidateNested({ each: true })
    @IsOptional()
    /** An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor, though this is not required. Note that, if a given Story is repeated several times over the height of the building and this is represented by the multiplier, the unique story included in this list should be the first (lowest) story of the repeated floors. */
    unique_stories?: Story [];
	
    @IsArray()
    @IsInstance(Room, { each: true })
    @Type(() => Room)
    @ValidateNested({ each: true })
    @IsOptional()
    /** An optional array of 3D Honeybee Room objects for additional Rooms that are a part of the Building but are not represented within the unique_stories. This is useful when there are parts of the Building geometry that cannot easily be represented with the extruded floor plate and sloped roof assumptions that underlie Dragonfly Room2Ds and RoofSpecification. Cases where this input is most useful include sloped walls and certain types of domed roofs that become tedious to implement with RoofSpecification. Matching the Honeybee Room.story property to the Dragonfly Story.display_name of an object within the unique_stories will effectively place the Honeybee Room on that Story for the purposes of floor_area, exterior_wall_area, etc. However, note that the Honeybee Room.multiplier property takes precedence over whatever multiplier is assigned to the Dragonfly Story that the Room.story may reference. (Default: None). */
    room_3ds?: Room [];
	
    @IsInstance(RoofSpecification)
    @Type(() => RoofSpecification)
    @ValidateNested()
    @IsOptional()
    /** An optional RoofSpecification object that provides an alternative way to describe roof geometry over rooms (instead of specifying roofs on each story). If trying to decide between the two, specifying geometry on each story is closer to how dragonfly natively works with roof geometry as it relates to rooms. However, when it is unknown which roof geometries correspond to which stories, this Building-level attribute may be used and each roof geometry will automatically be added to the best Story in the Building upon serialization to Python. This automatic assignment will happen by checking for overlaps between the Story Room2Ds and the Roof geometry in plan. When a given roof geometry overlaps with several Stories, the top-most Story will get the roof geometry assigned to it unless this top Story has a floor_height above the roof geometry, in which case the next highest story will be checked until a compatible one is found. */
    roof?: RoofSpecification;
	

    constructor() {
        super();
        this.type = "Building";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Building, _data);
            this.properties = obj.properties;
            this.type = obj.type;
            this.unique_stories = obj.unique_stories;
            this.room_3ds = obj.room_3ds;
            this.roof = obj.roof;
        }
    }


    static override fromJS(data: any): Building {
        data = typeof data === 'object' ? data : {};

        let result = new Building();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["properties"] = this.properties;
        data["type"] = this.type;
        data["unique_stories"] = this.unique_stories;
        data["room_3ds"] = this.room_3ds;
        data["roof"] = this.roof;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error.property]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
