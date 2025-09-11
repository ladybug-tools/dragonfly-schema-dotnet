import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class ContextShadeRadiancePropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^ContextShadeRadiancePropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "ContextShadeRadiancePropertiesAbridged";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Expose({ name: "modifier" })
    /** Name of a Modifier to set the reflectance and specularity of the ContextShade. If None, the the default of 0.2 diffuse reflectance will be used. */
    modifier?: string;
	

    constructor() {
        super();
        this.type = "ContextShadeRadiancePropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(ContextShadeRadiancePropertiesAbridged, _data);
            this.type = obj.type ?? "ContextShadeRadiancePropertiesAbridged";
            this.modifier = obj.modifier;
        }
    }


    static override fromJS(data: any): ContextShadeRadiancePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ContextShadeRadiancePropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "ContextShadeRadiancePropertiesAbridged";
        data["modifier"] = this.modifier;
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
