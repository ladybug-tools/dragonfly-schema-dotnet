import { IsArray, IsDefined, IsNumber, IsString, IsOptional, Equals, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { IsNestedNumberArray } from "./../helpers/class-validator";
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Instructions for detailed clearstory windows, defined by 2D Polygons. */
export class DetailedClearstory extends _OpenAPIGenBaseModel {
    @IsArray()
    @IsNestedNumberArray()
    @IsDefined()
    @Expose({ name: "base_line" })
    /** An array of two sub-arrays with each sub-array representing the start and end point of a 2D line segment in the world XY system. This establishes the plane and domain in which the clearstory geometries exist. */
    baseLine!: number[][];
	
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "elevation" })
    /** A number for the Z-coordinate that places the base_line and the corresponding clearstory window polygons in 3D space. This elevation value should be below all of the 3D clearstory window geometries and helps set the origin of the plane in which the clearstory geometry exists. */
    elevation!: number;
	
    @IsArray()
    @IsNestedNumberArray()
    @IsDefined()
    @Expose({ name: "polygons" })
    /** An array of arrays with each sub-array representing a polygonal boundary of a clearstory window or door. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the plane defined by the base_line. The base_line plane is assumed to have an origin at the end point of the line segment (the second point) and an X-axis extending along the length of the segment. The Y-axis of the plane always points upwards. Therefore, both X and Y coordinates of the points in each polygon should be positive. */
    polygons!: number[][][];
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Equals("DetailedClearstory")
    @Expose({ name: "type" })
    /** type */
    type: string = "DetailedClearstory";
	
    @IsArray()
    @Type(() => Boolean)
    @IsBoolean({ each: true })
    @IsOptional()
    @Expose({ name: "are_doors" })
    /** An array of booleans that align with the polygons and note whether each of the polygons represents a door out onto a roof or balcony (True) or a clearstory window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model */
    areDoors?: boolean[];
	

    constructor() {
        super();
        this.type = "DetailedClearstory";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(DetailedClearstory, _data);
            this.baseLine = obj.baseLine;
            this.elevation = obj.elevation;
            this.polygons = obj.polygons;
            this.type = obj.type ?? "DetailedClearstory";
            this.areDoors = obj.areDoors;
        }
    }


    static override fromJS(data: any): DetailedClearstory {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new DetailedClearstory();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["base_line"] = this.baseLine;
        data["elevation"] = this.elevation;
        data["polygons"] = this.polygons;
        data["type"] = this.type ?? "DetailedClearstory";
        data["are_doors"] = this.areDoors;
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
