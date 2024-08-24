import { IsNumber, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** Repeating windows derived from an area ratio with the base wall. */
export class RepeatingWindowRatio extends _WindowParameterBase {
    @IsNumber()
    @IsDefined()
    /** A number between 0 and 1 for the ratio between the window area and the parent wall surface area. */
    window_ratio!: number;
	
    @IsNumber()
    @IsDefined()
    /** A number for the target height of the windows. Note that, if the window ratio is too large for the height, the ratio will take precedence and the actual window_height will be larger than this value. */
    window_height!: number;
	
    @IsNumber()
    @IsDefined()
    /** A number for the target height above the bottom edge of the wall to start the windows. Note that, if the ratio is too large for the height, the ratio will take precedence and the sill_height will be smaller than this value. */
    sill_height!: number;
	
    @IsNumber()
    @IsDefined()
    /** A number for the target separation between individual window centerlines.  If this number is larger than the parent rectangle base, only one window will be produced. */
    horizontal_separation!: number;
	
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsNumber()
    @IsOptional()
    /** An optional number to create a single vertical separation between top and bottom windows. */
    vertical_separation?: number;
	

    constructor() {
        super();
        this.type = "RepeatingWindowRatio";
        this.vertical_separation = 0;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.window_ratio = _data["window_ratio"];
            this.window_height = _data["window_height"];
            this.sill_height = _data["sill_height"];
            this.horizontal_separation = _data["horizontal_separation"];
            this.type = _data["type"] !== undefined ? _data["type"] : "RepeatingWindowRatio";
            this.vertical_separation = _data["vertical_separation"] !== undefined ? _data["vertical_separation"] : 0;
        }
    }


    static override fromJS(data: any): RepeatingWindowRatio {
        data = typeof data === 'object' ? data : {};

        let result = new RepeatingWindowRatio();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["window_ratio"] = this.window_ratio;
        data["window_height"] = this.window_height;
        data["sill_height"] = this.sill_height;
        data["horizontal_separation"] = this.horizontal_separation;
        data["type"] = this.type;
        data["vertical_separation"] = this.vertical_separation;
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
