﻿import { IsString, IsOptional, Matches, MinLength, MaxLength, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class ContextShadeEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^ContextShadeEnergyPropertiesAbridged$/)
    /** Type */
    type?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Name of a ShadeConstruction to set the reflectance and specularity of the ContextShade. If None, the the EnergyPlus default of 0.2 diffuse reflectance will be used. */
    construction?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Name of a schedule to set the transmittance of the ContextShade, which can vary throughout the simulation. If None, the ContextShade will be completely opaque. */
    transmittance_schedule?: string;
	

    constructor() {
        super();
        this.type = "ContextShadeEnergyPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ContextShadeEnergyPropertiesAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.construction = obj.construction;
            this.transmittance_schedule = obj.transmittance_schedule;
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
        data["type"] = this.type;
        data["construction"] = this.construction;
        data["transmittance_schedule"] = this.transmittance_schedule;
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

