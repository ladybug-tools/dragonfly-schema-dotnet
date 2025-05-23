import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { ModelComparisonProperties } from "./ModelComparisonProperties";
import { ModelEnergyProperties } from "./ModelEnergyProperties";
import { ModelRadianceProperties } from "./ModelRadianceProperties";

export class ModelProperties extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^ModelProperties$/)
    /** Type */
    type?: string;
	
    @IsInstance(ModelEnergyProperties)
    @Type(() => ModelEnergyProperties)
    @ValidateNested()
    @IsOptional()
    /** Energy */
    energy?: ModelEnergyProperties;
	
    @IsInstance(ModelRadianceProperties)
    @Type(() => ModelRadianceProperties)
    @ValidateNested()
    @IsOptional()
    /** Radiance */
    radiance?: ModelRadianceProperties;
	
    @IsInstance(ModelComparisonProperties)
    @Type(() => ModelComparisonProperties)
    @ValidateNested()
    @IsOptional()
    /** Comparison */
    comparison?: ModelComparisonProperties;
	

    constructor() {
        super();
        this.type = "ModelProperties";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ModelProperties, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.energy = obj.energy;
            this.radiance = obj.radiance;
            this.comparison = obj.comparison;
        }
    }


    static override fromJS(data: any): ModelProperties {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ModelProperties();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
        data["comparison"] = this.comparison;
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

