import { IsNumber, IsDefined, IsOptional, Min, Max, IsArray, IsBoolean, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for for a series of louvered shades over a wall. */
export class _LouversBase extends _OpenAPIGenBaseModel {
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "depth" })
    /** A number for the depth to extrude the louvers. */
    depth!: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "offset" })
    /** A number for the distance to louvers from the wall. */
    offset: number = 0;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(-90)
    @Max(90)
    @Expose({ name: "angle" })
    /** A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. */
    angle: number = 0;
	
    @IsArray()
    @Type(() => Number)
    @IsNumber({},{ each: true })
    @IsOptional()
    @Expose({ name: "contour_vector" })
    /** A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours. */
    contourVector: number[] = [0, 1];
	
    @Type(() => Boolean)
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "flip_start_side" })
    /** Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left. */
    flipStartSide: boolean = false;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^_LouversBase$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "_LouversBase";
	

    constructor() {
        super();
        this.offset = 0;
        this.angle = 0;
        this.contourVector = [0, 1];
        this.flipStartSide = false;
        this.type = "_LouversBase";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(_LouversBase, _data);
            this.depth = obj.depth;
            this.offset = obj.offset ?? 0;
            this.angle = obj.angle ?? 0;
            this.contourVector = obj.contourVector ?? [0, 1];
            this.flipStartSide = obj.flipStartSide ?? false;
            this.type = obj.type ?? "_LouversBase";
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
        data["offset"] = this.offset ?? 0;
        data["angle"] = this.angle ?? 0;
        data["contour_vector"] = this.contourVector ?? [0, 1];
        data["flip_start_side"] = this.flipStartSide ?? false;
        data["type"] = this.type ?? "_LouversBase";
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
