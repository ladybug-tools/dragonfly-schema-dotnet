import { IsNumber, IsDefined, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** A single window defined by an absolute area. */
export class SimpleWindowArea extends _WindowParameterBase {
    @IsNumber()
    @IsDefined()
    /** A number for the window area in current model units. If this area is larger than the area of the Wall that it is appliedto, the window will fill the parent Wall at a 99 percent ratio. */
    window_area!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^SimpleWindowArea$/)
    type?: string;
	
    @IsBoolean()
    @IsOptional()
    /** Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result. */
    rect_split?: boolean;
	

    constructor() {
        super();
        this.type = "SimpleWindowArea";
        this.rect_split = true;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(SimpleWindowArea, _data, { enableImplicitConversion: true });
            this.window_area = obj.window_area;
            this.type = obj.type;
            this.rect_split = obj.rect_split;
        }
    }


    static override fromJS(data: any): SimpleWindowArea {
        data = typeof data === 'object' ? data : {};

        let result = new SimpleWindowArea();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["window_area"] = this.window_area;
        data["type"] = this.type;
        data["rect_split"] = this.rect_split;
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

