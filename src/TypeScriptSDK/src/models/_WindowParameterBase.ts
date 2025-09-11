import { IsOptional, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all window parameters. */
export class _WindowParameterBase extends _OpenAPIGenBaseModel {
    @IsOptional()
    @Expose({ name: "user_data" })
    /** Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures. */
    userData?: Object;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^_WindowParameterBase$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "_WindowParameterBase";
	

    constructor() {
        super();
        this.type = "_WindowParameterBase";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(_WindowParameterBase, _data);
            this.userData = obj.userData;
            this.type = obj.type ?? "_WindowParameterBase";
        }
    }


    static override fromJS(data: any): _WindowParameterBase {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new _WindowParameterBase();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["user_data"] = this.userData;
        data["type"] = this.type ?? "_WindowParameterBase";
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
