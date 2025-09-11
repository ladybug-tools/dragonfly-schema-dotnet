import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Autocalculate } from "honeybee-schema";

/** Gridded skylights derived from an area ratio with the roof. */
export class GriddedSkylightRatio extends _OpenAPIGenBaseModel {
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "skylight_ratio" })
    /** A number between 0 and 1 for the ratio between the skylight area and the total Roof face area. */
    skylightRatio!: number;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^GriddedSkylightRatio$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "GriddedSkylightRatio";
	
    @IsOptional()
    @Expose({ name: "spacing" })
    /** A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed. */
    spacing: (Autocalculate | number) = new Autocalculate();
	

    constructor() {
        super();
        this.type = "GriddedSkylightRatio";
        this.spacing = new Autocalculate();
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(GriddedSkylightRatio, _data);
            this.skylightRatio = obj.skylightRatio;
            this.type = obj.type ?? "GriddedSkylightRatio";
            this.spacing = obj.spacing ?? new Autocalculate();
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
        data["skylight_ratio"] = this.skylightRatio;
        data["type"] = this.type ?? "GriddedSkylightRatio";
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
