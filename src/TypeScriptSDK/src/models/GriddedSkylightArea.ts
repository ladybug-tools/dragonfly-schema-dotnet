import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Autocalculate } from "honeybee-schema";

/** Gridded skylights defined by an absolute area. */
export class GriddedSkylightArea extends _OpenAPIGenBaseModel {
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "skylight_area" })
    /** A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio. */
    skylightArea!: number;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^GriddedSkylightArea$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "GriddedSkylightArea";
	
    @IsOptional()
    @Expose({ name: "spacing" })
    /** A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed. */
    spacing: (Autocalculate | number) = new Autocalculate();
	

    constructor() {
        super();
        this.type = "GriddedSkylightArea";
        this.spacing = new Autocalculate();
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(GriddedSkylightArea, _data);
            this.skylightArea = obj.skylightArea;
            this.type = obj.type ?? "GriddedSkylightArea";
            this.spacing = obj.spacing ?? new Autocalculate();
        }
    }


    static override fromJS(data: any): GriddedSkylightArea {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new GriddedSkylightArea();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["skylight_area"] = this.skylightArea;
        data["type"] = this.type ?? "GriddedSkylightArea";
        data["spacing"] = this.spacing ?? new Autocalculate();
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
