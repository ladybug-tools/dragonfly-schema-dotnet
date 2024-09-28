import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel.ts";
import { Autocalculate } from "honeybee-schema";

/** Gridded skylights derived from an area ratio with the roof. */
export class GriddedSkylightRatio extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    /** A number between 0 and 1 for the ratio between the skylight area and the total Roof face area. */
    skylight_ratio!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^GriddedSkylightRatio$/)
    type?: string;
	
    @IsOptional()
    /** A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed. */
    spacing?: (Autocalculate | number);
	

    constructor() {
        super();
        this.type = "GriddedSkylightRatio";
        this.spacing = new Autocalculate();
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(GriddedSkylightRatio, _data, { enableImplicitConversion: true });
            this.skylight_ratio = obj.skylight_ratio;
            this.type = obj.type;
            this.spacing = obj.spacing;
        }
    }


    static override fromJS(data: any): GriddedSkylightRatio {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new GriddedSkylightRatio();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["skylight_ratio"] = this.skylight_ratio;
        data["type"] = this.type;
        data["spacing"] = this.spacing;
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

