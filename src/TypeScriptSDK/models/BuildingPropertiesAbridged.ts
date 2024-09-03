import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { BuildingEnergyPropertiesAbridged } from "./BuildingEnergyPropertiesAbridged";
import { BuildingRadiancePropertiesAbridged } from "./BuildingRadiancePropertiesAbridged";

export class BuildingPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^BuildingPropertiesAbridged$/)
    type?: string;
	
    @IsInstance(BuildingEnergyPropertiesAbridged)
    @Type(() => BuildingEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    energy?: BuildingEnergyPropertiesAbridged;
	
    @IsInstance(BuildingRadiancePropertiesAbridged)
    @Type(() => BuildingRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    radiance?: BuildingRadiancePropertiesAbridged;
	

    constructor() {
        super();
        this.type = "BuildingPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(BuildingPropertiesAbridged, _data);
            this.type = obj.type;
            this.energy = obj.energy;
            this.radiance = obj.radiance;
        }
    }


    static override fromJS(data: any): BuildingPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new BuildingPropertiesAbridged();
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
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error.property]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
