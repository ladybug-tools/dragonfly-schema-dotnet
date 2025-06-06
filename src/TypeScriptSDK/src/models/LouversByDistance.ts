﻿import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _LouversBase } from "./_LouversBase";

/** A series of louvered Shades at a given distance between each louver. */
export class LouversByDistance extends _LouversBase {
    @IsNumber()
    @IsDefined()
    @Expose({ name: "distance" })
    /** A number for the approximate distance between each louver. */
    distance!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^LouversByDistance$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "LouversByDistance";
	

    constructor() {
        super();
        this.type = "LouversByDistance";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(LouversByDistance, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.distance = obj.distance;
            this.type = obj.type ?? "LouversByDistance";
        }
    }


    static override fromJS(data: any): LouversByDistance {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new LouversByDistance();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["distance"] = this.distance;
        data["type"] = this.type ?? "LouversByDistance";
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
