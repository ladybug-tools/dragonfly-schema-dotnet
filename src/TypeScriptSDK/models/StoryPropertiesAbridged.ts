import { IsString, IsOptional, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { StoryEnergyPropertiesAbridged } from "./StoryEnergyPropertiesAbridged";
import { StoryRadiancePropertiesAbridged } from "./StoryRadiancePropertiesAbridged";

export class StoryPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsInstance(StoryEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    energy?: StoryEnergyPropertiesAbridged;
	
    @IsInstance(StoryRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    radiance?: StoryRadiancePropertiesAbridged;
	

    constructor() {
        super();
        this.type = "StoryPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.type = _data["type"] !== undefined ? _data["type"] : "StoryPropertiesAbridged";
            this.energy = _data["energy"];
            this.radiance = _data["radiance"];
        }
    }


    static override fromJS(data: any): StoryPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new StoryPropertiesAbridged();
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
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || {}).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
