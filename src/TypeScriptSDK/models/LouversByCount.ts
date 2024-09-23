import { IsInt, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { _LouversBase } from "./_LouversBase";

/** A specific number of louvered Shades over a wall. */
export class LouversByCount extends _LouversBase {
    @IsInt()
    @IsDefined()
    /** A positive integer for the number of louvers to generate. */
    louver_count!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^LouversByCount$/)
    type?: string;
	

    constructor() {
        super();
        this.type = "LouversByCount";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(LouversByCount, _data, { enableImplicitConversion: true });
            this.louver_count = obj.louver_count;
            this.type = obj.type;
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
        data["louver_count"] = this.louver_count;
        data["type"] = this.type;
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

