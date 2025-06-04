import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Room2DComparisonProperties } from "./Room2DComparisonProperties";
import { Room2DDoe2Properties } from "./Room2DDoe2Properties";
import { Room2DEnergyPropertiesAbridged } from "./Room2DEnergyPropertiesAbridged";
import { Room2DRadiancePropertiesAbridged } from "./Room2DRadiancePropertiesAbridged";

export class Room2DPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^Room2DPropertiesAbridged$/)
    /** Type */
    Type: string = "Room2DPropertiesAbridged";
	
    @IsInstance(Room2DEnergyPropertiesAbridged)
    @Type(() => Room2DEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    /** Energy */
    Energy?: Room2DEnergyPropertiesAbridged;
	
    @IsInstance(Room2DRadiancePropertiesAbridged)
    @Type(() => Room2DRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    /** Radiance */
    Radiance?: Room2DRadiancePropertiesAbridged;
	
    @IsInstance(Room2DDoe2Properties)
    @Type(() => Room2DDoe2Properties)
    @ValidateNested()
    @IsOptional()
    /** Doe2 */
    Doe2?: Room2DDoe2Properties;
	
    @IsInstance(Room2DComparisonProperties)
    @Type(() => Room2DComparisonProperties)
    @ValidateNested()
    @IsOptional()
    /** Comparison */
    Comparison?: Room2DComparisonProperties;
	

    constructor() {
        super();
        this.Type = "Room2DPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Room2DPropertiesAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.energy = obj.energy;
            this.radiance = obj.radiance;
            this.doe2 = obj.doe2;
            this.comparison = obj.comparison;
        }
    }


    static override fromJS(data: any): Room2DPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Room2DPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
        data["doe2"] = this.doe2;
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
