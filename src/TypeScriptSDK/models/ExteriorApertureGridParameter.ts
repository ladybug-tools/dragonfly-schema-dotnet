import { IsString, IsOptional, IsNumber, IsEnum, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { _GridParameterBase } from "./_GridParameterBase";
import { ExteriorApertureType } from "./ExteriorApertureType";

/** Instructions for a SensorGrid generated from exterior Aperture. */
export class ExteriorApertureGridParameter extends _GridParameterBase {
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsNumber()
    @IsOptional()
    /** A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters). */
    offset?: number;
	
    @IsEnum(ExteriorApertureType)
    @ValidateNested()
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
            this.type = _data["type"] !== undefined ? _data["type"] : "ExteriorApertureGridParameter";
            this.offset = _data["offset"] !== undefined ? _data["offset"] : 0.1;
            this.aperture_type = _data["aperture_type"] !== undefined ? _data["aperture_type"] : ExteriorApertureType.All;
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
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["type"] = this.type;
        data["offset"] = this.offset;
        data["aperture_type"] = this.aperture_type;
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
