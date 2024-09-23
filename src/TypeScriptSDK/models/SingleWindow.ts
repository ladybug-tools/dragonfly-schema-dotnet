import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** A single window in the wall center defined by a width * height. */
export class SingleWindow extends _WindowParameterBase {
    @IsNumber()
    @IsDefined()
    /** A number for the window width. Note that, if this width is applied to a wall that is too narrow for this width, the generated window will automatically be shortened when it is applied to the wall. In this way, setting the width to be `float(""inf"")` will create parameters that always generate a ribbon window. */
    width!: number;
	
    @IsNumber()
    @IsDefined()
    /** A number for the window height. Note that, if this height is applied to a wall that is too short for this height, the generated window will automatically be shortened when it is applied to the wall. */
    height!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^SingleWindow$/)
    type?: string;
	
    @IsNumber()
    @IsOptional()
    /** A number for the window sill height. */
    sill_height?: number;
	

    constructor() {
        super();
        this.type = "SingleWindow";
        this.sill_height = 1;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(SingleWindow, _data, { enableImplicitConversion: true });
            this.width = obj.width;
            this.height = obj.height;
            this.type = obj.type;
            this.sill_height = obj.sill_height;
        }
    }


    static override fromJS(data: any): SingleWindow {
        data = typeof data === 'object' ? data : {};

        let result = new SingleWindow();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["width"] = this.width;
        data["height"] = this.height;
        data["type"] = this.type;
        data["sill_height"] = this.sill_height;
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

