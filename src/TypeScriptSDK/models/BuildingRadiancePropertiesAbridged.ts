import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class BuildingRadiancePropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^BuildingRadiancePropertiesAbridged$/)
    type?: string;
	
    @IsString()
    @IsOptional()
    /** Name of a ModifierSet to specify all modifiers for the Building. If None, the Model global_modifier_set will be used. */
    modifier_set?: string;
	

    constructor() {
        super();
        this.type = "BuildingRadiancePropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(BuildingRadiancePropertiesAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.modifier_set = obj.modifier_set;
        }
    }


    static override fromJS(data: any): BuildingRadiancePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new BuildingRadiancePropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["modifier_set"] = this.modifier_set;
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

