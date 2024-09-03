import { IsNumber, IsDefined, IsOptional, IsArray, IsBoolean, IsString, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for for a series of louvered shades over a wall. */
export class _LouversBase extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    /** A number for the depth to extrude the louvers. */
    depth!: number;
	
    @IsNumber()
    @IsOptional()
    /** A number for the distance to louvers from the wall. */
    offset?: number;
	
    @IsNumber()
    @IsOptional()
    /** A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. */
    angle?: number;
	
    @IsArray()
    @IsNumber({},{ each: true })
    @IsOptional()
    /** A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours. */
    contour_vector?: number [];
	
    @IsBoolean()
    @IsOptional()
    /** Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left. */
    flip_start_side?: boolean;
	
    @IsString()
    @IsOptional()
    type?: string;
	

    constructor() {
        super();
        this.offset = 0;
        this.angle = 0;
        this.contour_vector = [0, 1];
        this.flip_start_side = false;
        this.type = "_LouversBase";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(_LouversBase, _data);
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

        let result = new _LouversBase();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["depth"] = this.depth;
        data["offset"] = this.offset;
        data["angle"] = this.angle;
        data["contour_vector"] = this.contour_vector;
        data["flip_start_side"] = this.flip_start_side;
        data["type"] = this.type;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error.property]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
