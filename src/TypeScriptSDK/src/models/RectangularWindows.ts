import { IsArray, IsDefined, IsNumber, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { IsNestedNumberArray } from "./../helpers/class-validator";
import { _WindowParameterBase } from "./_WindowParameterBase";

/** Several rectangular windows, defined by origin, width and height. */
export class RectangularWindows extends _WindowParameterBase {
    @IsArray()
    @IsNestedNumberArray()
    @IsDefined()
    @Expose({ name: "origins" })
    /** An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive. */
    origins!: number[][];
	
    @IsArray()
    @Type(() => Number)
    @IsNumber({},{ each: true })
    @IsDefined()
    @Expose({ name: "widths" })
    /** An array of positive numbers for the window widths. The length of this list must match the length of the origins. */
    widths!: number[];
	
    @IsArray()
    @Type(() => Number)
    @IsNumber({},{ each: true })
    @IsDefined()
    @Expose({ name: "heights" })
    /** An array of positive numbers for the window heights. The length of this list must match the length of the origins. */
    heights!: number[];
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^RectangularWindows$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "RectangularWindows";
	
    @IsArray()
    @Type(() => Boolean)
    @IsBoolean({ each: true })
    @IsOptional()
    @Expose({ name: "are_doors" })
    /** An array of booleans that align with the origins and note whether each of the geometries represents a door (True) or a window (False). If None, it will be assumed that all geometries represent windows and they will be translated to Apertures in any resulting Honeybee model. */
    areDoors?: boolean[];
	

    constructor() {
        super();
        this.type = "RectangularWindows";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(RectangularWindows, _data);
            this.origins = obj.origins;
            this.widths = obj.widths;
            this.heights = obj.heights;
            this.type = obj.type ?? "RectangularWindows";
            this.areDoors = obj.areDoors;
            this.userData = obj.userData;
        }
    }


    static override fromJS(data: any): RectangularWindows {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new RectangularWindows();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["origins"] = this.origins;
        data["widths"] = this.widths;
        data["heights"] = this.heights;
        data["type"] = this.type ?? "RectangularWindows";
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
