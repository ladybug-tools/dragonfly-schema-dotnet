import { IsString, IsOptional, Matches, IsNumber, IsEnum, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _GridParameterBase } from "./_GridParameterBase";
import { ExteriorApertureType } from "./ExteriorApertureType";

/** Instructions for a SensorGrid generated from exterior Aperture. */
export class ExteriorApertureGridParameter extends _GridParameterBase {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^ExteriorApertureGridParameter$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "ExteriorApertureGridParameter";
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Expose({ name: "offset" })
    /** A number for how far to offset the grid from the Apertures. (Default: 0.1, suitable for Models in Meters). */
    offset: number = 0.1;
	
    @Type(() => String)
    @IsEnum(ExteriorApertureType)
    @IsOptional()
    @Expose({ name: "aperture_type" })
    /** Text to specify the type of Aperture that will be used to generate grids. Window indicates Apertures in Walls. Skylights are in parent Roof faces. */
    apertureType: ExteriorApertureType = ExteriorApertureType.All;
	

    constructor() {
        super();
        this.type = "ExteriorApertureGridParameter";
        this.offset = 0.1;
        this.apertureType = ExteriorApertureType.All;
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(ExteriorApertureGridParameter, _data);
            this.type = obj.type ?? "ExteriorApertureGridParameter";
            this.offset = obj.offset ?? 0.1;
            this.apertureType = obj.apertureType ?? ExteriorApertureType.All;
            this.dimension = obj.dimension;
            this.includeMesh = obj.includeMesh ?? true;
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
        data["type"] = this.type ?? "ExteriorApertureGridParameter";
        data["offset"] = this.offset ?? 0.1;
        data["aperture_type"] = this.apertureType ?? ExteriorApertureType.All;
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
