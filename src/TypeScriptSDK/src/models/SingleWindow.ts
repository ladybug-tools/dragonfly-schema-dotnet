import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** A single window in the wall center defined by a width * height. */
export class SingleWindow extends _WindowParameterBase {
    @IsNumber()
    @IsDefined()
    /** A number for the window width. Note that, if this width is applied to a wall that is too narrow for this width, the generated window will automatically be shortened when it is applied to the wall. In this way, setting the width to be `float(""inf"")` will create parameters that always generate a ribbon window. */
    Width!: number;
	
    @IsNumber()
    @IsDefined()
    /** A number for the window height. Note that, if this height is applied to a wall that is too short for this height, the generated window will automatically be shortened when it is applied to the wall. */
    Height!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^SingleWindow$/)
    /** Type */
    Type: string = "SingleWindow";
	
    @IsNumber()
    @IsOptional()
    /** A number for the window sill height. */
    SillHeight: number = 1;
	

    constructor() {
        super();
        this.Type = "SingleWindow";
        this.SillHeight = 1;
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

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
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
