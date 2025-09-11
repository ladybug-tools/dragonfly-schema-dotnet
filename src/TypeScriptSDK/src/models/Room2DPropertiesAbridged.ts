import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Room2DComparisonProperties } from "./Room2DComparisonProperties";
import { Room2DDoe2Properties } from "./Room2DDoe2Properties";
import { Room2DEnergyPropertiesAbridged } from "./Room2DEnergyPropertiesAbridged";
import { Room2DRadiancePropertiesAbridged } from "./Room2DRadiancePropertiesAbridged";

export class Room2DPropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^Room2DPropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Room2DPropertiesAbridged";
	
    @Type(() => Room2DEnergyPropertiesAbridged)
    @IsInstance(Room2DEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "energy" })
    /** energy */
    energy?: Room2DEnergyPropertiesAbridged;
	
    @Type(() => Room2DRadiancePropertiesAbridged)
    @IsInstance(Room2DRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "radiance" })
    /** radiance */
    radiance?: Room2DRadiancePropertiesAbridged;
	
    @Type(() => Room2DDoe2Properties)
    @IsInstance(Room2DDoe2Properties)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "doe2" })
    /** doe2 */
    doe2?: Room2DDoe2Properties;
	
    @Type(() => Room2DComparisonProperties)
    @IsInstance(Room2DComparisonProperties)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "comparison" })
    /** comparison */
    comparison?: Room2DComparisonProperties;
	

    constructor() {
        super();
        this.type = "Room2DPropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(Room2DPropertiesAbridged, _data);
            this.type = obj.type ?? "Room2DPropertiesAbridged";
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
        data["type"] = this.type ?? "Room2DPropertiesAbridged";
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
        data["doe2"] = this.doe2;
        data["comparison"] = this.comparison;
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
