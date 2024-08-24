﻿import { IsInstance, ValidateNested, IsDefined, IsString, IsOptional, IsArray, IsEnum, IsNumber, validate, ValidationError as TsValidationError } from 'class-validator';
import { Building } from "./Building";
import { ContextShade } from "./ContextShade";
import { IDdBaseModel } from "./IDdBaseModel";
import { ModelProperties } from "./ModelProperties";
import { Units } from "./Units";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Model extends IDdBaseModel {
    @IsInstance(ModelProperties)
    @ValidateNested()
    @IsDefined()
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: ModelProperties;
	
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsString()
    @IsOptional()
    /** Text string for the current version of the schema. */
    version?: string;
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of Buildings in the model. */
    buildings?: Building [];
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of ContextShades in the model. */
    context_shades?: ContextShade [];
	
    @IsEnum(Units)
    @ValidateNested()
    @IsOptional()
    /** Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters. */
    units?: Units;
	
    @IsNumber()
    @IsOptional()
    /** The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters. */
    tolerance?: number;
	
    @IsNumber()
    @IsOptional()
    /** The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model. */
    angle_tolerance?: number;
	

    constructor() {
        super();
        this.type = "Model";
        this.version = "0.0.0";
        this.units = Units.Meters;
        this.tolerance = 0.01;
        this.angle_tolerance = 1;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.properties = _data["properties"];
            this.type = _data["type"] !== undefined ? _data["type"] : "Model";
            this.version = _data["version"] !== undefined ? _data["version"] : "0.0.0";
            this.buildings = _data["buildings"];
            this.context_shades = _data["context_shades"];
            this.units = _data["units"] !== undefined ? _data["units"] : Units.Meters;
            this.tolerance = _data["tolerance"] !== undefined ? _data["tolerance"] : 0.01;
            this.angle_tolerance = _data["angle_tolerance"] !== undefined ? _data["angle_tolerance"] : 1;
        }
    }


    static override fromJS(data: any): Model {
        data = typeof data === 'object' ? data : {};

        let result = new Model();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["properties"] = this.properties;
        data["type"] = this.type;
        data["version"] = this.version;
        data["buildings"] = this.buildings;
        data["context_shades"] = this.context_shades;
        data["units"] = this.units;
        data["tolerance"] = this.tolerance;
        data["angle_tolerance"] = this.angle_tolerance;
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
