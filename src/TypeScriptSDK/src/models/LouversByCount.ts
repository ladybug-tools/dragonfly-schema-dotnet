import { IsInt, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _LouversBase } from "./_LouversBase";

/** A specific number of louvered Shades over a wall. */
export class LouversByCount extends _LouversBase {
    @IsInt()
    @IsDefined()
    @Expose({ name: "louver_count" })
    /** A positive integer for the number of louvers to generate. */
    louverCount!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^LouversByCount$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "LouversByCount";
	

    constructor() {
        super();
        this.type = "LouversByCount";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(LouversByCount, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.louverCount = obj.louverCount;
            this.type = obj.type ?? "LouversByCount";
        }
    }


    static override fromJS(data: any): LouversByCount {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new LouversByCount();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["louver_count"] = this.louverCount;
        data["type"] = this.type ?? "LouversByCount";
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
