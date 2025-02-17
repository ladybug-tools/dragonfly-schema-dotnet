﻿import { IsNumber, IsDefined, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _WindowParameterBase } from "./_WindowParameterBase";

/** A single window defined by an area ratio with the base surface. */
export class SimpleWindowRatio extends _WindowParameterBase {
    @IsNumber()
    @IsDefined()
    /** A number between 0 and 1 for the ratio between the window area and the parent wall surface area. */
    window_ratio!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^SimpleWindowRatio$/)
    /** Type */
    type?: string;
	
    @IsBoolean()
    @IsOptional()
    /** Boolean to note whether rectangular portions of base Face should be extracted before scaling them to create apertures. For pentagonal gabled geometries, this results in one rectangle and one triangle, which can often look more realistic and is a better input for engines like EnergyPlus that cannot model windows with more than 4 vertices. However, if a single pentagonal window is desired for such a gabled shape, this input can be set to False to produce such a result. */
    rect_split?: boolean;
	

    constructor() {
        super();
        this.type = "SimpleWindowRatio";
        this.rect_split = true;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(SimpleWindowRatio, _data, { enableImplicitConversion: true });
            this.window_ratio = obj.window_ratio;
            this.type = obj.type;
            this.rect_split = obj.rect_split;
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
        data["window_ratio"] = this.window_ratio;
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

