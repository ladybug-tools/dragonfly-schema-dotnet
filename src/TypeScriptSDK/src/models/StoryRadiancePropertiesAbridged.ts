import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class StoryRadiancePropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^StoryRadiancePropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "StoryRadiancePropertiesAbridged";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Expose({ name: "modifier_set" })
    /** Name of a ModifierSet to specify all modifiers for the Story. If None, the Story will use the Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects. */
    modifierSet?: string;
	

    constructor() {
        super();
        this.type = "StoryRadiancePropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(StoryRadiancePropertiesAbridged, _data);
            this.type = obj.type ?? "StoryRadiancePropertiesAbridged";
            this.modifierSet = obj.modifierSet;
        }
    }


    static override fromJS(data: any): StoryRadiancePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new StoryRadiancePropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "StoryRadiancePropertiesAbridged";
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
