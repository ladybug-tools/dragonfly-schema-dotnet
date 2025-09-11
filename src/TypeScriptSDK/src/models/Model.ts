import { IsInstance, ValidateNested, IsDefined, IsString, IsOptional, Matches, IsArray, IsEnum, IsNumber, Min, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { Building } from "./Building";
import { ContextShade } from "./ContextShade";
import { IDdBaseModel } from "honeybee-schema";
import { ModelProperties } from "./ModelProperties";
import { Units } from "honeybee-schema";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Model extends IDdBaseModel {
    @Type(() => ModelProperties)
    @IsInstance(ModelProperties)
    @ValidateNested()
    @IsDefined()
    @Expose({ name: "properties" })
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: ModelProperties;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^Model$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Model";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/([0-9]+)\.([0-9]+)\.([0-9]+)/)
    @Expose({ name: "version" })
    /** Text string for the current version of the schema. */
    version: string = "0.0.0";
	
    @IsArray()
    @Type(() => Building)
    @IsInstance(Building, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "buildings" })
    /** A list of Buildings in the model. */
    buildings?: Building[];
	
    @IsArray()
    @Type(() => ContextShade)
    @IsInstance(ContextShade, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "context_shades" })
    /** A list of ContextShades in the model. */
    contextShades?: ContextShade[];
	
    @Type(() => String)
    @IsEnum(Units)
    @IsOptional()
    @Expose({ name: "units" })
    /** Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters. */
    units: Units = Units.Meters;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "tolerance" })
    /** The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters. */
    tolerance: number = 0.01;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "angle_tolerance" })
    /** The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model. */
    angleTolerance: number = 1;
	
    @IsArray()
    @Type(() => Number)
    @IsNumber({},{ each: true })
    @IsOptional()
    @Expose({ name: "reference_vector" })
    /** A n optional list of 3 (x, y, z) values that describe a Vector3D relating the model to an original source coordinate system. Setting a value here is useful if the model has been moved from its original location and there may be future operations of merging geometry from the original source system. */
    referenceVector?: number[];
	

    constructor() {
        super();
        this.type = "Model";
        this.version = "0.0.0";
        this.units = Units.Meters;
        this.tolerance = 0.01;
        this.angleTolerance = 1;
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(Model, _data);
            this.properties = obj.properties;
            this.type = obj.type ?? "Model";
            this.version = obj.version ?? "0.0.0";
            this.buildings = obj.buildings;
            this.contextShades = obj.contextShades;
            this.units = obj.units ?? Units.Meters;
            this.tolerance = obj.tolerance ?? 0.01;
            this.angleTolerance = obj.angleTolerance ?? 1;
            this.referenceVector = obj.referenceVector;
            this.identifier = obj.identifier;
            this.displayName = obj.displayName;
            this.userData = obj.userData;
        }
    }


    static override fromJS(data: any): Model {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Model();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["properties"] = this.properties;
        data["type"] = this.type ?? "Model";
        data["version"] = this.version ?? "0.0.0";
        data["buildings"] = this.buildings;
        data["context_shades"] = this.contextShades;
        data["units"] = this.units ?? Units.Meters;
        data["tolerance"] = this.tolerance ?? 0.01;
        data["angle_tolerance"] = this.angleTolerance ?? 1;
        data["reference_vector"] = this.referenceVector;
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
