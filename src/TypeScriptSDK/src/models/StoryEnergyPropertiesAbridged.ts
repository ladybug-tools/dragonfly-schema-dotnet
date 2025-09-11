import { IsString, IsOptional, Matches, MinLength, MaxLength, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class StoryEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^StoryEnergyPropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "StoryEnergyPropertiesAbridged";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "construction_set" })
    /** Name of a ConstructionSet to specify all constructions for the Story. If None, the Story will use the Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects. */
    constructionSet?: string;
	

    constructor() {
        super();
        this.type = "StoryEnergyPropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(StoryEnergyPropertiesAbridged, _data);
            this.type = obj.type ?? "StoryEnergyPropertiesAbridged";
            this.constructionSet = obj.constructionSet;
        }
    }


    static override fromJS(data: any): StoryEnergyPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new StoryEnergyPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "StoryEnergyPropertiesAbridged";
        data["construction_set"] = this.constructionSet;
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
