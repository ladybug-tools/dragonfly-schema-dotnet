import { IsString, IsOptional, Matches, IsNumber, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _GridParameterBase } from "./_GridParameterBase";

/** Instructions for a SensorGrid generated from a Room2D's floors. */
export class RoomGridParameter extends _GridParameterBase {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^RoomGridParameter$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "RoomGridParameter";
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Expose({ name: "offset" })
    /** A number for how far to offset the grid from the Room2D floors. (Default: 1.0, suitable for Models in Meters). */
    offset: number = 1;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Expose({ name: "wall_offset" })
    /** A number for the distance at which sensors close to walls should be removed. Note that this option has no effect unless the value is more than half of the dimension. */
    wallOffset: number = 0;
	

    constructor() {
        super();
        this.type = "RoomGridParameter";
        this.offset = 1;
        this.wallOffset = 0;
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(RoomGridParameter, _data);
            this.type = obj.type ?? "RoomGridParameter";
            this.offset = obj.offset ?? 1;
            this.wallOffset = obj.wallOffset ?? 0;
            this.dimension = obj.dimension;
            this.includeMesh = obj.includeMesh ?? true;
        }
    }


    static override fromJS(data: any): RoomGridParameter {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new RoomGridParameter();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "RoomGridParameter";
        data["offset"] = this.offset ?? 1;
        data["wall_offset"] = this.wallOffset ?? 0;
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
