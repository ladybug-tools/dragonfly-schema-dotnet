import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Extruded borders over all windows in the wall. */
export class ExtrudedBorder extends _OpenAPIGenBaseModel {
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "depth" })
    /** A number for the depth of the border. */
    depth!: number;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^ExtrudedBorder$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "ExtrudedBorder";
	

    constructor() {
        super();
        this.type = "ExtrudedBorder";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(ExtrudedBorder, _data);
            this.depth = obj.depth;
            this.type = obj.type ?? "ExtrudedBorder";
        }
    }


    static override fromJS(data: any): ExtrudedBorder {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ExtrudedBorder();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["depth"] = this.depth;
        data["type"] = this.type ?? "ExtrudedBorder";
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
