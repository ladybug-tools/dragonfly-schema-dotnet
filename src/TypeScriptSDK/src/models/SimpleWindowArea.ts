import { IsNumber, IsDefined, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** A single window defined by an absolute area. */
export class SimpleWindowArea extends _WindowParameterBase {
    @IsNumber()
    @IsDefined()
    @Expose({ name: "window_area" })
    /** A number for the window area in current model units. If this area is larger than the area of the Wall that it is appliedto, the window will fill the parent Wall at a 99 percent ratio. */
    windowArea!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^SimpleWindowArea$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "SimpleWindowArea";
	
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "rect_split" })
    /** Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result. */
    rectSplit: boolean = true;
	

    constructor() {
        super();
        this.type = "SimpleWindowArea";
        this.rectSplit = true;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(SimpleWindowArea, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.windowArea = obj.windowArea;
            this.type = obj.type ?? "SimpleWindowArea";
            this.rectSplit = obj.rectSplit ?? true;
        }
    }


    static override fromJS(data: any): SimpleWindowArea {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new SimpleWindowArea();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["window_area"] = this.windowArea;
        data["type"] = this.type ?? "SimpleWindowArea";
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
