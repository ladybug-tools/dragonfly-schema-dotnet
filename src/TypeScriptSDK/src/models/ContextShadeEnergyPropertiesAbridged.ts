import { IsString, IsOptional, Matches, MinLength, MaxLength, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class ContextShadeEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^ContextShadeEnergyPropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "ContextShadeEnergyPropertiesAbridged";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "construction" })
    /** Name of a ShadeConstruction to set the reflectance and specularity of the ContextShade. If None, the the EnergyPlus default of 0.2 diffuse reflectance will be used. */
    construction?: string;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "transmittance_schedule" })
    /** Name of a schedule to set the transmittance of the ContextShade, which can vary throughout the simulation. If None, the ContextShade will be completely opaque. */
    transmittanceSchedule?: string;
	

    constructor() {
        super();
        this.type = "ContextShadeEnergyPropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(ContextShadeEnergyPropertiesAbridged, _data);
            this.type = obj.type ?? "ContextShadeEnergyPropertiesAbridged";
            this.construction = obj.construction;
            this.transmittanceSchedule = obj.transmittanceSchedule;
        }
    }


    static override fromJS(data: any): ContextShadeEnergyPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ContextShadeEnergyPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "ContextShadeEnergyPropertiesAbridged";
        data["construction"] = this.construction;
        data["transmittance_schedule"] = this.transmittanceSchedule;
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
