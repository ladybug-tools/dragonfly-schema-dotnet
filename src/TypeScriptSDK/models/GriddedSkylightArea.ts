import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Autocalculate } from "honeybee-schema";

/** Gridded skylights defined by an absolute area. */
export class GriddedSkylightArea extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    /** A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio. */
    skylight_area!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^GriddedSkylightArea$/)
    type?: string;
	
    @IsOptional()
    /** A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed. */
    spacing?: (Autocalculate | number);
	

    constructor() {
        super();
        this.type = "GriddedSkylightArea";
        this.spacing = new Autocalculate();
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(GriddedSkylightArea, _data);
            this.skylight_area = obj.skylight_area;
            this.type = obj.type;
            this.spacing = obj.spacing;
        }
    }


    static override fromJS(data: any): GriddedSkylightArea {
        data = typeof data === 'object' ? data : {};

        let result = new GriddedSkylightArea();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["skylight_area"] = this.skylight_area;
        data["type"] = this.type;
        data["spacing"] = this.spacing;
        super.toJSON(data);
        return data;
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
