import { IsNumber, IsDefined, IsOptional, Min, Max, IsArray, IsBoolean, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for for a series of louvered shades over a wall. */
export class _LouversBase extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    /** A number for the depth to extrude the louvers. */
    Depth!: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    /** A number for the distance to louvers from the wall. */
    Offset: number = 0;
	
    @IsNumber()
    @IsOptional()
    @Min(-90)
    @Max(90)
    /** A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. */
    Angle: number = 0;
	
    @IsArray()
    @IsNumber({},{ each: true })
    @IsOptional()
    /** A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours. */
    ContourVector: number[] = [0, 1];
	
    @IsBoolean()
    @IsOptional()
    /** Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left. */
    FlipStartSide: boolean = false;
	
    @IsString()
    @IsOptional()
    @Matches(/^_LouversBase$/)
    /** Type */
    Type: string = "_LouversBase";
	

    constructor() {
        super();
        this.Offset = 0;
        this.Angle = 0;
        this.ContourVector = [0, 1];
        this.FlipStartSide = false;
        this.Type = "_LouversBase";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(_LouversBase, _data, { enableImplicitConversion: true });
            this.depth = obj.depth;
            this.offset = obj.offset;
            this.angle = obj.angle;
            this.contour_vector = obj.contour_vector;
            this.flip_start_side = obj.flip_start_side;
            this.type = obj.type;
        }
    }


    static override fromJS(data: any): _LouversBase {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new _LouversBase();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["depth"] = this.depth;
        data["offset"] = this.offset;
        data["angle"] = this.angle;
        data["contour_vector"] = this.contour_vector;
        data["flip_start_side"] = this.flip_start_side;
        data["type"] = this.type;
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
