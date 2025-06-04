import { IsInstance, ValidateNested, IsDefined, IsString, IsOptional, Matches, IsArray, IsEnum, IsNumber, Min, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { Building } from "./Building";
import { ContextShade } from "./ContextShade";
import { IDdBaseModel } from "honeybee-schema";
import { ModelProperties } from "./ModelProperties";
import { Units } from "honeybee-schema";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class Model extends IDdBaseModel {
    @IsInstance(ModelProperties)
    @Type(() => ModelProperties)
    @ValidateNested()
    @IsDefined()
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    Properties!: ModelProperties;
	
    @IsString()
    @IsOptional()
    @Matches(/^Model$/)
    /** Type */
    Type: string = "Model";
	
    @IsString()
    @IsOptional()
    @Matches(/([0-9]+)\.([0-9]+)\.([0-9]+)/)
    /** Text string for the current version of the schema. */
    Version: string = "0.0.0";
	
    @IsArray()
    @IsInstance(Building, { each: true })
    @Type(() => Building)
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of Buildings in the model. */
    Buildings?: Building[];
	
    @IsArray()
    @IsInstance(ContextShade, { each: true })
    @Type(() => ContextShade)
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of ContextShades in the model. */
    ContextShades?: ContextShade[];
	
    @IsEnum(Units)
    @Type(() => String)
    @IsOptional()
    /** Text indicating the units in which the model geometry exists. This is used to scale the geometry to the correct units for simulation engines like EnergyPlus, which requires all geometry be in meters. */
    Units: Units = Units.Meters;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    /** The maximum difference between x, y, and z values at which vertices are considered equivalent. This value should be in the Model units and is used in a variety of checks and operations. A value of 0 will result in bypassing all checks so it is recommended that this always be a positive number when checks have not already been performed on a Model. The default of 0.01 is suitable for models in meters. */
    Tolerance: number = 0.01;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    /** The max angle difference in degrees that vertices are allowed to differ from one another in order to consider them colinear. This value is used in a variety of checks and operations that can be performed on geometry. A value of 0 will result in no checks and an inability to perform certain operations so it is recommended that this always be a positive number when checks have not already been performed on a given Model. */
    AngleTolerance: number = 1;
	
    @IsArray()
    @IsNumber({},{ each: true })
    @IsOptional()
    /** A n optional list of 3 (x, y, z) values that describe a Vector3D relating the model to an original source coordinate system. Setting a value here is useful if the model has been moved from its original location and there may be future operations of merging geometry from the original source system. */
    ReferenceVector?: number[];
	

    constructor() {
        super();
        this.Type = "Model";
        this.Version = "0.0.0";
        this.Units = Units.Meters;
        this.Tolerance = 0.01;
        this.AngleTolerance = 1;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Model, _data, { enableImplicitConversion: true });
            this.properties = obj.properties;
            this.type = obj.type;
            this.version = obj.version;
            this.buildings = obj.buildings;
            this.context_shades = obj.context_shades;
            this.units = obj.units;
            this.tolerance = obj.tolerance;
            this.angle_tolerance = obj.angle_tolerance;
            this.reference_vector = obj.reference_vector;
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
        data["type"] = this.type;
        data["version"] = this.version;
        data["buildings"] = this.buildings;
        data["context_shades"] = this.context_shades;
        data["units"] = this.units;
        data["tolerance"] = this.tolerance;
        data["angle_tolerance"] = this.angle_tolerance;
        data["reference_vector"] = this.reference_vector;
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
