import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel.ts";
import { StoryEnergyPropertiesAbridged } from "./StoryEnergyPropertiesAbridged.ts";
import { StoryRadiancePropertiesAbridged } from "./StoryRadiancePropertiesAbridged.ts";

export class StoryPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^StoryPropertiesAbridged$/)
    type?: string;
	
    @IsInstance(StoryEnergyPropertiesAbridged)
    @Type(() => StoryEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    energy?: StoryEnergyPropertiesAbridged;
	
    @IsInstance(StoryRadiancePropertiesAbridged)
    @Type(() => StoryRadiancePropertiesAbridged)
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
            const obj = plainToClass(StoryPropertiesAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
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
        data["type"] = this.type;
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
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

