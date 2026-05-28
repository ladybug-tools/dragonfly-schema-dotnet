import { IsString, IsOptional, Equals, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

export class ModelComparisonProperties extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Equals("ModelComparisonProperties")
    @Expose({ name: "type" })
    /** type */
    type: string = "ModelComparisonProperties";
	

    constructor() {
        super();
        this.type = "ModelComparisonProperties";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(ModelComparisonProperties, _data);
            this.type = obj.type ?? "ModelComparisonProperties";
        }
    }


    static override fromJS(data: any): ModelComparisonProperties {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ModelComparisonProperties();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "ModelComparisonProperties";
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
