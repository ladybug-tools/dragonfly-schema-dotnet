import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { StoryEnergyPropertiesAbridged } from "./StoryEnergyPropertiesAbridged";
import { StoryRadiancePropertiesAbridged } from "./StoryRadiancePropertiesAbridged";

export class StoryPropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^StoryPropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "StoryPropertiesAbridged";
	
    @Type(() => StoryEnergyPropertiesAbridged)
    @IsInstance(StoryEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "energy" })
    /** energy */
    energy?: StoryEnergyPropertiesAbridged;
	
    @Type(() => StoryRadiancePropertiesAbridged)
    @IsInstance(StoryRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "radiance" })
    /** radiance */
    radiance?: StoryRadiancePropertiesAbridged;
	

    constructor() {
        super();
        this.type = "StoryPropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(StoryPropertiesAbridged, _data);
            this.type = obj.type ?? "StoryPropertiesAbridged";
            this.energy = obj.energy;
            this.radiance = obj.radiance;
        }
    }


    static override fromJS(data: any): StoryPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new StoryPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "StoryPropertiesAbridged";
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
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
