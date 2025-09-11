import { IsArray, IsDefined, IsInstance, ValidateNested, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { ContextShadePropertiesAbridged } from "./ContextShadePropertiesAbridged";
import { Face3D } from "honeybee-schema";
import { IDdBaseModel } from "honeybee-schema";
import { Mesh3D } from "honeybee-schema";

/** Base class for all objects requiring a identifiers acceptable for all engines. */
export class ContextShade extends IDdBaseModel {
    @IsArray()
    @IsDefined()
    @Expose({ name: "geometry" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'Face3D') return Face3D.fromJS(item);
      else if (item?.type === 'Mesh3D') return Mesh3D.fromJS(item);
      else return item;
    }))
    /** An array of planar Face3Ds and or Mesh3Ds that together represent the context shade. */
    geometry!: (Face3D | Mesh3D)[];
	
    @Type(() => ContextShadePropertiesAbridged)
    @IsInstance(ContextShadePropertiesAbridged)
    @ValidateNested()
    @IsDefined()
    @Expose({ name: "properties" })
    /** Extension properties for particular simulation engines (Radiance, EnergyPlus). */
    properties!: ContextShadePropertiesAbridged;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^ContextShade$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "ContextShade";
	
    @Type(() => Boolean)
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "is_detached" })
    /** Boolean to note whether this shade is detached from any of the other geometry in the model. Cases where this should be True include shade representing surrounding buildings or context. */
    isDetached: boolean = true;
	

    constructor() {
        super();
        this.type = "ContextShade";
        this.isDetached = true;
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(ContextShade, _data);
            this.geometry = obj.geometry;
            this.properties = obj.properties;
            this.type = obj.type ?? "ContextShade";
            this.isDetached = obj.isDetached ?? true;
            this.identifier = obj.identifier;
            this.displayName = obj.displayName;
            this.userData = obj.userData;
        }
    }


    static override fromJS(data: any): ContextShade {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ContextShade();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["geometry"] = this.geometry;
        data["properties"] = this.properties;
        data["type"] = this.type ?? "ContextShade";
        data["is_detached"] = this.isDetached ?? true;
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
