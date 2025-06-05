import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { BuildingEnergyPropertiesAbridged } from "./BuildingEnergyPropertiesAbridged";
import { BuildingRadiancePropertiesAbridged } from "./BuildingRadiancePropertiesAbridged";

export class BuildingPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^BuildingPropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "BuildingPropertiesAbridged";
	
    @IsInstance(BuildingEnergyPropertiesAbridged)
    @Type(() => BuildingEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "energy" })
    /** energy */
    energy?: BuildingEnergyPropertiesAbridged;
	
    @IsInstance(BuildingRadiancePropertiesAbridged)
    @Type(() => BuildingRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "radiance" })
    /** radiance */
    radiance?: BuildingRadiancePropertiesAbridged;
	

    constructor() {
        super();
        this.type = "BuildingPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(BuildingPropertiesAbridged, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.type = obj.type ?? "BuildingPropertiesAbridged";
            this.energy = obj.energy;
            this.radiance = obj.radiance;
        }
    }


    static override fromJS(data: any): BuildingPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new BuildingPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "BuildingPropertiesAbridged";
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
