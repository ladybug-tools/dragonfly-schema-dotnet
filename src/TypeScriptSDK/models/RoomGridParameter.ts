import { IsString, IsOptional, IsNumber, validate, ValidationError as TsValidationError } from 'class-validator';
import { _GridParameterBase } from "./_GridParameterBase";
import { RoomRadialGridParameter } from "./RoomRadialGridParameter";

/** Instructions for a SensorGrid generated from a Room2D's floors. */
export class RoomGridParameter extends _GridParameterBase {
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsNumber()
    @IsOptional()
    /** A number for how far to offset the grid from the Room2D floors. (Default: 1.0, suitable for Models in Meters). */
    offset?: number;
	
    @IsNumber()
    @IsOptional()
    /** A number for the distance at which sensors close to walls should be removed. Note that this option has no effect unless the value is more than half of the dimension. */
    wall_offset?: number;
	

    constructor() {
        super();
        this.type = "RoomGridParameter";
        this.offset = 1;
        this.wall_offset = 0;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.type = _data["type"] !== undefined ? _data["type"] : "RoomGridParameter";
            this.offset = _data["offset"] !== undefined ? _data["offset"] : 1;
            this.wall_offset = _data["wall_offset"] !== undefined ? _data["wall_offset"] : 0;
        }
    }


    static override fromJS(data: any): RoomGridParameter {
        data = typeof data === 'object' ? data : {};

        if (data["type"] === "RoomRadialGridParameter") {
            let result = new RoomRadialGridParameter();
            result.init(data);
            return result;
        }
        let result = new RoomGridParameter();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["type"] = this.type;
        data["offset"] = this.offset;
        data["wall_offset"] = this.wall_offset;
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
