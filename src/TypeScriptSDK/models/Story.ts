import { IsArray, ValidateNested, IsDefined, IsInstance, IsString, IsOptional, IsInt, validate, ValidationError as TsValidationError } from 'class-validator';
import { Autocalculate } from "./Autocalculate";
import { IDdBaseModel } from "./IDdBaseModel";
import { RoofSpecification } from "./RoofSpecification";
import { Room2D } from "./Room2D";
import { StoryPropertiesAbridged } from "./StoryPropertiesAbridged";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Story extends IDdBaseModel {
    @IsArray()
    @ValidateNested({ each: true })
    @IsDefined()
    /** An array of dragonfly Room2D objects that together form an entire story of a building. */
    room_2ds!: Room2D [];
	
    @IsInstance(StoryPropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: StoryPropertiesAbridged;
	
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsOptional()
    /** A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If Autocalculate, this value will be the maximum floor_to_ceiling_height of the input room_2ds. */
    floor_to_floor_height?: (Autocalculate | number);
	
    @IsOptional()
    /** A number to indicate the height of the floor plane in the Z axis.If Autocalculate, this will be the minimum floor height of all the room_2ds, which is suitable for cases where there are no floor plenums. */
    floor_height?: (Autocalculate | number);
	
    @IsInt()
    @IsOptional()
    /** An integer that denotes the number of times that this Story is repeated over the height of the building. */
    multiplier?: number;
	
    @IsInstance(RoofSpecification)
    @ValidateNested()
    @IsOptional()
    /** An optional RoofSpecification object containing geometry for generating sloped roofs over the Story. The RoofSpecification will only affect the child Room2Ds that have a True is_top_exposed property and it will only be utilized in translation to Honeybee when the Story multiplier is 1. If None, all Room2D ceilings will be flat. */
    roof?: RoofSpecification;
	

    constructor() {
        super();
        this.type = "Story";
        this.floor_to_floor_height = new Autocalculate();
        this.floor_height = new Autocalculate();
        this.multiplier = 1;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.room_2ds = _data["room_2ds"];
            this.properties = _data["properties"];
            this.type = _data["type"] !== undefined ? _data["type"] : "Story";
            this.floor_to_floor_height = _data["floor_to_floor_height"] !== undefined ? _data["floor_to_floor_height"] : new Autocalculate();
            this.floor_height = _data["floor_height"] !== undefined ? _data["floor_height"] : new Autocalculate();
            this.multiplier = _data["multiplier"] !== undefined ? _data["multiplier"] : 1;
            this.roof = _data["roof"];
        }
    }


    static override fromJS(data: any): Story {
        data = typeof data === 'object' ? data : {};

        let result = new Story();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["room_2ds"] = this.room_2ds;
        data["properties"] = this.properties;
        data["type"] = this.type;
        data["floor_to_floor_height"] = this.floor_to_floor_height;
        data["floor_height"] = this.floor_height;
        data["multiplier"] = this.multiplier;
        data["roof"] = this.roof;
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
