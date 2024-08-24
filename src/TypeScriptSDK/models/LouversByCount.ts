import { IsInt, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { _LouversBase } from "./_LouversBase";

/** A specific number of louvered Shades over a wall. */
export class LouversByCount extends _LouversBase {
    @IsInt()
    @IsDefined()
    /** A positive integer for the number of louvers to generate. */
    louver_count!: number;
	
    @IsString()
    @IsOptional()
    type?: string;
	

    constructor() {
        super();
        this.type = "LouversByCount";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.louver_count = _data["louver_count"];
            this.type = _data["type"] !== undefined ? _data["type"] : "LouversByCount";
        }
    }


    static override fromJS(data: any): LouversByCount {
        data = typeof data === 'object' ? data : {};

        let result = new LouversByCount();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["louver_count"] = this.louver_count;
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
