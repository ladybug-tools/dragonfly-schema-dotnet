import { IsNumber, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** A single overhang over an entire wall. */
export class Overhang extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    /** A number for the overhang depth. */
    depth!: number;
	
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsNumber()
    @IsOptional()
    /** A number between -90 and 90 for the for an angle to rotate the overhang in degrees. 0 indicates an overhang perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. */
    angle?: number;
	

    constructor() {
        super();
        this.type = "Overhang";
        this.angle = 0;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.depth = _data["depth"];
            this.type = _data["type"] !== undefined ? _data["type"] : "Overhang";
            this.angle = _data["angle"] !== undefined ? _data["angle"] : 0;
        }
    }


    static override fromJS(data: any): Overhang {
        data = typeof data === 'object' ? data : {};

        let result = new Overhang();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["depth"] = this.depth;
        data["type"] = this.type;
        data["angle"] = this.angle;
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
