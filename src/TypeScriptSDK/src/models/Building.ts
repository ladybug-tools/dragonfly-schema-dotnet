import { IsInstance, ValidateNested, IsDefined, IsString, IsOptional, Matches, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { BuildingPropertiesAbridged } from "./BuildingPropertiesAbridged";
import { IDdBaseModel } from "honeybee-schema";
import { RoofSpecification } from "./RoofSpecification";
import { Room } from "honeybee-schema";
import { Story } from "./Story";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Building extends IDdBaseModel {
    @Type(() => BuildingPropertiesAbridged)
    @IsInstance(BuildingPropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    @Expose({ name: "properties" })
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: BuildingPropertiesAbridged;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^Building$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Building";
	
    @IsArray()
    @Type(() => Story)
    @IsInstance(Story, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "unique_stories" })
    /** An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor, though this is not required. Note that, if a given Story is repeated several times over the height of the building and this is represented by the multiplier, the unique story included in this list should be the first (lowest) story of the repeated floors. */
    uniqueStories?: Story[];
	
    @IsArray()
    @Type(() => Room)
    @IsInstance(Room, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "room_3ds" })
    /** An optional array of 3D Honeybee Room objects for additional Rooms that are a part of the Building but are not represented within the unique_stories. This is useful when there are parts of the Building geometry that cannot easily be represented with the extruded floor plate and sloped roof assumptions that underlie Dragonfly Room2Ds and RoofSpecification. Cases where this input is most useful include sloped walls and certain types of domed roofs that become tedious to implement with RoofSpecification. Matching the Honeybee Room.story property to the Dragonfly Story.display_name of an object within the unique_stories will effectively place the Honeybee Room on that Story for the purposes of floor_area, exterior_wall_area, etc. However, note that the Honeybee Room.multiplier property takes precedence over whatever multiplier is assigned to the Dragonfly Story that the Room.story may reference. (Default: None). */
    room3ds?: Room[];
	
    @Type(() => RoofSpecification)
    @IsInstance(RoofSpecification)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "roof" })
    /** An optional RoofSpecification object that provides an alternative way to describe roof geometry over rooms (instead of specifying roofs on each story). If trying to decide between the two, specifying geometry on each story is closer to how dragonfly natively works with roof geometry as it relates to rooms. However, when it is unknown which roof geometries correspond to which stories, this Building-level attribute may be used and each roof geometry will automatically be added to the best Story in the Building upon serialization to Python. This automatic assignment will happen by checking for overlaps between the Story Room2Ds and the Roof geometry in plan. When a given roof geometry overlaps with several Stories, the top-most Story will get the roof geometry assigned to it unless this top Story has a floor_height above the roof geometry, in which case the next highest story will be checked until a compatible one is found. */
    roof?: RoofSpecification;
	

    constructor() {
        super();
        this.type = "Building";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(Building, _data);
            this.properties = obj.properties;
            this.type = obj.type ?? "Building";
            this.uniqueStories = obj.uniqueStories;
            this.room3ds = obj.room3ds;
            this.roof = obj.roof;
            this.identifier = obj.identifier;
            this.displayName = obj.displayName;
            this.userData = obj.userData;
        }
    }


    static override fromJS(data: any): Building {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Building();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["properties"] = this.properties;
        data["type"] = this.type ?? "Building";
        data["unique_stories"] = this.uniqueStories;
        data["room_3ds"] = this.room3ds;
        data["roof"] = this.roof;
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
