import { IsNumber, IsDefined, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** A single window defined by an area ratio with the base surface. */
export class SimpleWindowRatio extends _WindowParameterBase {
    @IsNumber()
    @IsDefined()
    @Expose({ name: "window_ratio" })
    /** A number between 0 and 1 for the ratio between the window area and the parent wall surface area. */
    windowRatio!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^SimpleWindowRatio$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "SimpleWindowRatio";
	
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "rect_split" })
    /** Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result. */
    rectSplit: boolean = true;
	

    constructor() {
        super();
        this.type = "SimpleWindowRatio";
        this.rectSplit = true;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(SimpleWindowRatio, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.windowRatio = obj.windowRatio;
            this.type = obj.type ?? "SimpleWindowRatio";
            this.rectSplit = obj.rectSplit ?? true;
        }
    }


    static override fromJS(data: any): SimpleWindowRatio {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new SimpleWindowRatio();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["window_ratio"] = this.windowRatio;
        data["type"] = this.type ?? "SimpleWindowRatio";
        data["rect_split"] = this.rectSplit ?? true;
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
