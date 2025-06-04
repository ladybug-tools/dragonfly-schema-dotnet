import { IsString, IsOptional, Matches, IsNumber, IsEnum, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _GridParameterBase } from "./_GridParameterBase";
import { ExteriorApertureType } from "./ExteriorApertureType";

/** Instructions for a SensorGrid generated from exterior Aperture. */
export class ExteriorApertureGridParameter extends _GridParameterBase {
    @IsString()
    @IsOptional()
    @Matches(/^ExteriorApertureGridParameter$/)
    /** Type */
    Type: string = "ExteriorApertureGridParameter";
	
    @IsNumber()
    @IsOptional()
    /** A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters). */
    Offset: number = 0.1;
	
    @IsEnum(ExteriorApertureType)
    @Type(() => String)
    @IsOptional()
    /** Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces. */
    ApertureType: ExteriorApertureType = ExteriorApertureType.All;
	

    constructor() {
        super();
        this.Type = "ExteriorApertureGridParameter";
        this.Offset = 0.1;
        this.ApertureType = ExteriorApertureType.All;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ExteriorApertureGridParameter, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.offset = obj.offset;
            this.aperture_type = obj.aperture_type;
        }
    }


    static override fromJS(data: any): ExteriorApertureGridParameter {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ExteriorApertureGridParameter();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["offset"] = this.offset;
        data["aperture_type"] = this.aperture_type;
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
