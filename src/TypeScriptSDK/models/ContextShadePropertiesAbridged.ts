import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel.ts";
import { ContextShadeEnergyPropertiesAbridged } from "./ContextShadeEnergyPropertiesAbridged.ts";
import { ContextShadeRadiancePropertiesAbridged } from "./ContextShadeRadiancePropertiesAbridged.ts";

export class ContextShadePropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^ContextShadePropertiesAbridged$/)
    type?: string;
	
    @IsInstance(ContextShadeEnergyPropertiesAbridged)
    @Type(() => ContextShadeEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    energy?: ContextShadeEnergyPropertiesAbridged;
	
    @IsInstance(ContextShadeRadiancePropertiesAbridged)
    @Type(() => ContextShadeRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    radiance?: ContextShadeRadiancePropertiesAbridged;
	

    constructor() {
        super();
        this.type = "ContextShadePropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ContextShadePropertiesAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.energy = obj.energy;
            this.radiance = obj.radiance;
        }
    }


    static override fromJS(data: any): ContextShadePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ContextShadePropertiesAbridged();
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

