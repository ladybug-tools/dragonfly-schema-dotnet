import { IsArray, IsDefined, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { IsNestedNumberArray } from "./../helpers/class-validator";
import { _WindowParameterBase } from "./_WindowParameterBase";

/** Several detailed windows defined by 2D Polygons (lists of 2D vertices). */
export class DetailedWindows extends _WindowParameterBase {
    @IsArray()
    @IsNestedNumberArray()
    @IsDefined()
    @Expose({ name: "polygons" })
    /** An array of arrays with each sub-array representing a polygonal boundary of a window. Each sub-array should consist of arrays representing points, which can either contain 2 values (indicating they are 2D vertices within the plane of a parent wall segment) or they can contain 3 values (indicating they are 3D world coordinates). For 2D points, the wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows */
    polygons!: number[][][];
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^DetailedWindows$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "DetailedWindows";
	
    @IsArray()
    @Type(() => Boolean)
    @IsBoolean({ each: true })
    @IsOptional()
    @Expose({ name: "are_doors" })
    /** An array of booleans that align with the polygons and note whether each of the polygons represents a door (True) or a window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model. */
    areDoors?: boolean[];
	

    constructor() {
        super();
        this.type = "DetailedWindows";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(DetailedWindows, _data);
            this.polygons = obj.polygons;
            this.type = obj.type ?? "DetailedWindows";
            this.areDoors = obj.areDoors;
            this.userData = obj.userData;
        }
    }


    static override fromJS(data: any): DetailedWindows {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new DetailedWindows();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["polygons"] = this.polygons;
        data["type"] = this.type ?? "DetailedWindows";
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
