import { IsNumber, IsDefined, IsString, IsOptional, Matches, Min, Max, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** A single overhang over an entire wall. */
export class Overhang extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    @Expose({ name: "depth" })
    /** A number for the overhang depth. */
    depth!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^Overhang$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Overhang";
	
    @IsNumber()
    @IsOptional()
    @Min(-90)
    @Max(90)
    @Expose({ name: "angle" })
    /** A number between -90 and 90 for the for an angle to rotate the overhang in degrees. 0 indicates an overhang perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. */
    angle: number = 0;
	

    constructor() {
        super();
        this.type = "Overhang";
        this.angle = 0;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Overhang, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.depth = obj.depth;
            this.type = obj.type ?? "Overhang";
            this.angle = obj.angle ?? 0;
        }
    }


    static override fromJS(data: any): Overhang {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Overhang();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["depth"] = this.depth;
        data["type"] = this.type ?? "Overhang";
        data["angle"] = this.angle ?? 0;
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
