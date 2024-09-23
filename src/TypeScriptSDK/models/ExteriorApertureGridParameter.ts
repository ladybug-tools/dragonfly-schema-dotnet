import { IsString, IsOptional, Matches, IsNumber, IsEnum, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { _GridParameterBase } from "./_GridParameterBase";
import { ExteriorApertureType } from "./ExteriorApertureType";

/** Instructions for a SensorGrid generated from exterior Aperture. */
export class ExteriorApertureGridParameter extends _GridParameterBase {
    @IsString()
    @IsOptional()
    @Matches(/^ExteriorApertureGridParameter$/)
    type?: string;
	
    @IsNumber()
    @IsOptional()
    /** A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters). */
    offset?: number;
	
    @IsEnum(ExteriorApertureType)
    @Type(() => String)
    @IsOptional()
    /** Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces. */
    aperture_type?: ExteriorApertureType;
	

    constructor() {
        super();
        this.type = "ExteriorApertureGridParameter";
        this.offset = 0.1;
        this.aperture_type = ExteriorApertureType.All;
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

