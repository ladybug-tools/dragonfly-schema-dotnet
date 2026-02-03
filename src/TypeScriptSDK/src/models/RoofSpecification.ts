import { IsArray, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Face3D } from "honeybee-schema";
import { Mesh3D } from "honeybee-schema";

/** Geometry for specifying sloped roofs over a Story. */
export class RoofSpecification extends _OpenAPIGenBaseModel {
    @IsArray()
    @IsDefined()
    @Expose({ name: "geometry" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'Face3D') return Face3D.fromJS(item);
      else if (item?.type === 'Mesh3D') return Mesh3D.fromJS(item);
      else return item;
    }))
    /** An array of Face3D (or Mesh3D) objects representing the geometry of the Roof. Cases where Room2Ds are only partially covered by these roof geometries will result in those portions of the Room2Ds being extruded to their floor_to_ceiling_height. */
    geometry!: (Face3D | Mesh3D)[];
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^RoofSpecification$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "RoofSpecification";
	

    constructor() {
        super();
        this.type = "RoofSpecification";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(RoofSpecification, _data);
            this.geometry = obj.geometry;
            this.type = obj.type ?? "RoofSpecification";
        }
    }


    static override fromJS(data: any): RoofSpecification {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new RoofSpecification();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["geometry"] = this.geometry;
        data["type"] = this.type ?? "RoofSpecification";
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
