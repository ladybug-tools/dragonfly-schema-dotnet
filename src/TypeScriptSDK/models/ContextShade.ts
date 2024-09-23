import { IsArray, IsDefined, IsInstance, ValidateNested, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { ContextShadePropertiesAbridged } from "./ContextShadePropertiesAbridged";
import { Face3D } from "honeybee-schema";
import { IDdBaseModel } from "honeybee-schema";
import { Mesh3D } from "honeybee-schema";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class ContextShade extends IDdBaseModel {
    @IsArray()
    @IsDefined()
    /** An array of planar Face3Ds and or Mesh3Ds that together represent the context shade. */
    geometry!: (Face3D | Mesh3D) [];
	
    @IsInstance(ContextShadePropertiesAbridged)
    @Type(() => ContextShadePropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: ContextShadePropertiesAbridged;
	
    @IsString()
    @IsOptional()
    @Matches(/^ContextShade$/)
    type?: string;
	
    @IsBoolean()
    @IsOptional()
    /** Boolean to note whether this shade is detached from any of the other geometry in the model. Cases where this should be True include shade representing surrounding buildings or context. */
    is_detached?: boolean;
	

    constructor() {
        super();
        this.type = "ContextShade";
        this.is_detached = true;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ContextShade, _data, { enableImplicitConversion: true });
            this.geometry = obj.geometry;
            this.properties = obj.properties;
            this.type = obj.type;
            this.is_detached = obj.is_detached;
        }
    }


    static override fromJS(data: any): ContextShade {
        data = typeof data === 'object' ? data : {};

        let result = new ContextShade();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["geometry"] = this.geometry;
        data["properties"] = this.properties;
        data["type"] = this.type;
        data["is_detached"] = this.is_detached;
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

