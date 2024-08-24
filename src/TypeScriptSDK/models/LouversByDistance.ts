import { IsNumber, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { _LouversBase } from "./_LouversBase";

/** A series of louvered Shades at a given distance between each louver. */
export class LouversByDistance extends _LouversBase {
    @IsNumber()
    @IsDefined()
    /** A number for the approximate distance between each louver. */
    distance!: number;
	
    @IsString()
    @IsOptional()
    type?: string;
	

    constructor() {
        super();
        this.type = "LouversByDistance";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.distance = _data["distance"];
            this.type = _data["type"] !== undefined ? _data["type"] : "LouversByDistance";
        }
    }


    static override fromJS(data: any): LouversByDistance {
        data = typeof data === 'object' ? data : {};

        let result = new LouversByDistance();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["distance"] = this.distance;
        data["type"] = this.type;
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
