import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class BuildingRadiancePropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^BuildingRadiancePropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "BuildingRadiancePropertiesAbridged";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Expose({ name: "modifier_set" })
    /** Name of a ModifierSet to specify all modifiers for the Building. If None, the Model global_modifier_set will be used. */
    modifierSet?: string;
	

    constructor() {
        super();
        this.type = "BuildingRadiancePropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(BuildingRadiancePropertiesAbridged, _data);
            this.type = obj.type ?? "BuildingRadiancePropertiesAbridged";
            this.modifierSet = obj.modifierSet;
        }
    }


    static override fromJS(data: any): BuildingRadiancePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new BuildingRadiancePropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "BuildingRadiancePropertiesAbridged";
        data["modifier_set"] = this.modifierSet;
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
