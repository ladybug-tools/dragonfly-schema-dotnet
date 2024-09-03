import { IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class ContextShadeRadiancePropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsString()
    @IsOptional()
    /** Name of a Modifier to set the reflectance and specularity of the ContextShade. If None, the the default of 0.2 diffuse reflectance will be used. */
    modifier?: string;
	

    constructor() {
        super();
        this.type = "ContextShadeRadiancePropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ContextShadeRadiancePropertiesAbridged, _data);
            this.type = obj.type;
            this.modifier = obj.modifier;
        }
    }


    static override fromJS(data: any): ContextShadeRadiancePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new ContextShadeRadiancePropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["type"] = this.type;
        data["modifier"] = this.modifier;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error.property]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
