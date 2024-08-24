import { IsNumber, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Autocalculate } from "./Autocalculate";

/** Gridded skylights derived from an area ratio with the roof. */
export class GriddedSkylightRatio extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    /** A number between 0 and 1 for the ratio between the skylight area and the total Roof face area. */
    skylight_ratio!: number;
	
    @IsString()
    @IsOptional()
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
            this.skylight_ratio = _data["skylight_ratio"];
            this.type = _data["type"] !== undefined ? _data["type"] : "GriddedSkylightRatio";
            this.spacing = _data["spacing"] !== undefined ? _data["spacing"] : new Autocalculate();
        }
    }


    static override fromJS(data: any): GriddedSkylightRatio {
        data = typeof data === 'object' ? data : {};

        let result = new GriddedSkylightRatio();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["skylight_ratio"] = this.skylight_ratio;
        data["type"] = this.type;
        data["spacing"] = this.spacing;
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
