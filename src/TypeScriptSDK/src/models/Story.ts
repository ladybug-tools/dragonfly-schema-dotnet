import { IsArray, IsInstance, ValidateNested, IsDefined, IsString, IsOptional, Matches, IsInt, Min, IsEnum, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { Autocalculate } from "honeybee-schema";
import { IDdBaseModel } from "honeybee-schema";
import { RoofSpecification } from "./RoofSpecification";
import { Room2D } from "./Room2D";
import { StoryPropertiesAbridged } from "./StoryPropertiesAbridged";
import { StoryType } from "./StoryType";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Story extends IDdBaseModel {
    @IsArray()
    @Type(() => Room2D)
    @IsInstance(Room2D, { each: true })
    @ValidateNested({ each: true })
    @IsDefined()
    @Expose({ name: "room_2ds" })
    /** An array of dragonfly Room2D objects that together form an entire story of a building. */
    room2ds!: Room2D[];
	
    @Type(() => StoryPropertiesAbridged)
    @IsInstance(StoryPropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    @Expose({ name: "properties" })
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: StoryPropertiesAbridged;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^Story$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Story";
	
    @IsOptional()
    @Expose({ name: "floor_to_floor_height" })
    /** A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If Autocalculate, this value will be the maximum floor_to_ceiling_height of the input room_2ds. */
    floorToFloorHeight: (Autocalculate | number) = new Autocalculate();
	
    @IsOptional()
    @Expose({ name: "floor_height" })
    /** A number to indicate the height of the floor plane in the Z axis.If Autocalculate, this will be the minimum floor height of all the room_2ds, which is suitable for cases where there are no floor plenums. */
    floorHeight: (Autocalculate | number) = new Autocalculate();
	
    @Type(() => Number)
    @IsInt()
    @IsOptional()
    @Min(1)
    @Expose({ name: "multiplier" })
    /** An integer that denotes the number of times that this Story is repeated over the height of the building. */
    multiplier: number = 1;
	
    @Type(() => RoofSpecification)
    @IsInstance(RoofSpecification)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "roof" })
    /** An optional RoofSpecification object containing geometry for generating sloped roofs over the Story. The RoofSpecification will only affect the child Room2Ds that have a True is_top_exposed property and it will only be utilized in translation to Honeybee when the Story multiplier is 1. If None, all Room2D ceilings will be flat. */
    roof?: RoofSpecification;
	
    @Type(() => String)
    @IsEnum(StoryType)
    @IsOptional()
    @Expose({ name: "story_type" })
    /** Text to indicate the type of story. Stories that are plenums are translated to Honeybee with excluded floor areas. */
    storyType: StoryType = StoryType.Standard;
	

    constructor() {
        super();
        this.type = "Story";
        this.floorToFloorHeight = new Autocalculate();
        this.floorHeight = new Autocalculate();
        this.multiplier = 1;
        this.storyType = StoryType.Standard;
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(Story, _data);
            this.room2ds = obj.room2ds;
            this.properties = obj.properties;
            this.type = obj.type ?? "Story";
            this.floorToFloorHeight = obj.floorToFloorHeight ?? new Autocalculate();
            this.floorHeight = obj.floorHeight ?? new Autocalculate();
            this.multiplier = obj.multiplier ?? 1;
            this.roof = obj.roof;
            this.storyType = obj.storyType ?? StoryType.Standard;
            this.identifier = obj.identifier;
            this.displayName = obj.displayName;
            this.userData = obj.userData;
        }
    }


    static override fromJS(data: any): Story {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Story();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["room_2ds"] = this.room2ds;
        data["properties"] = this.properties;
        data["type"] = this.type ?? "Story";
        data["floor_to_floor_height"] = this.floorToFloorHeight ?? new Autocalculate();
        data["floor_height"] = this.floorHeight ?? new Autocalculate();
        data["multiplier"] = this.multiplier ?? 1;
        data["roof"] = this.roof;
        data["story_type"] = this.storyType ?? StoryType.Standard;
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
