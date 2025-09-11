import { IsNumber, IsDefined, Min, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** Repeating windows derived from an area ratio with the base wall. */
export class RepeatingWindowRatio extends _WindowParameterBase {
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "window_ratio" })
    /** A number between 0 and 1 for the ratio between the window area and the parent wall surface area. */
    windowRatio!: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "window_height" })
    /** A number for the target height of the windows. Note that, if the window ratio is too large for the height, the ratio will take precedence and the actual window_height will be larger than this value. */
    windowHeight!: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "sill_height" })
    /** A number for the target height above the bottom edge of the wall to start the windows. Note that, if the ratio is too large for the height, the ratio will take precedence and the sill_height will be smaller than this value. */
    sillHeight!: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Min(0)
    @Expose({ name: "horizontal_separation" })
    /** A number for the target separation between individual window centerlines.  If this number is larger than the parent rectangle base, only one window will be produced. */
    horizontalSeparation!: number;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^RepeatingWindowRatio$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "RepeatingWindowRatio";
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "vertical_separation" })
    /** An optional number to create a single vertical separation between top and bottom windows. */
    verticalSeparation: number = 0;
	

    constructor() {
        super();
        this.type = "RepeatingWindowRatio";
        this.verticalSeparation = 0;
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(RepeatingWindowRatio, _data);
            this.windowRatio = obj.windowRatio;
            this.windowHeight = obj.windowHeight;
            this.sillHeight = obj.sillHeight;
            this.horizontalSeparation = obj.horizontalSeparation;
            this.type = obj.type ?? "RepeatingWindowRatio";
            this.verticalSeparation = obj.verticalSeparation ?? 0;
            this.userData = obj.userData;
        }
    }


    static override fromJS(data: any): RepeatingWindowRatio {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new RepeatingWindowRatio();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["window_ratio"] = this.windowRatio;
        data["window_height"] = this.windowHeight;
        data["sill_height"] = this.sillHeight;
        data["horizontal_separation"] = this.horizontalSeparation;
        data["type"] = this.type ?? "RepeatingWindowRatio";
        data["vertical_separation"] = this.verticalSeparation ?? 0;
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
