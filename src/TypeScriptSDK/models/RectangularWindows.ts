import { IsArray, ValidateNested, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** Several rectangular windows, defined by origin, width and height. */
export class RectangularWindows extends _WindowParameterBase {
    @IsArray()
    @ValidateNested({ each: true })
    @IsDefined()
    /** An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive. */
    origins!: number [] [];
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsDefined()
    /** An array of positive numbers for the window widths. The length of this list must match the length of the origins. */
    widths!: number [];
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsDefined()
    /** An array of positive numbers for the window heights. The length of this list must match the length of the origins. */
    heights!: number [];
	
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsArray()
    @ValidateNested({ each: true })
    @IsOptional()
    /** An array of booleans that align with the origins and note whether each of the geometries represents a door (True) or a window (False). If None, it will be assumed that all geometries represent windows and they will be translated to Apertures in any resulting Honeybee model. */
    are_doors?: boolean [];
	

    constructor() {
        super();
        this.type = "RectangularWindows";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.origins = _data["origins"];
            this.widths = _data["widths"];
            this.heights = _data["heights"];
            this.type = _data["type"] !== undefined ? _data["type"] : "RectangularWindows";
            this.are_doors = _data["are_doors"];
        }
    }


    static override fromJS(data: any): RectangularWindows {
        data = typeof data === 'object' ? data : {};

        let result = new RectangularWindows();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["origins"] = this.origins;
        data["widths"] = this.widths;
        data["heights"] = this.heights;
        data["type"] = this.type;
        data["are_doors"] = this.are_doors;
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
