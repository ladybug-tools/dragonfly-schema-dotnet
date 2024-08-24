﻿import { IsNumber, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
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
            this.width = _data["width"];
            this.height = _data["height"];
            this.type = _data["type"] !== undefined ? _data["type"] : "SingleWindow";
            this.sill_height = _data["sill_height"] !== undefined ? _data["sill_height"] : 1;
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
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["width"] = this.width;
        data["height"] = this.height;
        data["type"] = this.type;
        data["sill_height"] = this.sill_height;
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
