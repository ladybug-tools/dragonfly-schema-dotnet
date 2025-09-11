import { IsInt, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _LouversBase } from "./_LouversBase";

/** A specific number of louvered Shades over a wall. */
export class LouversByCount extends _LouversBase {
    @Type(() => Number)
    @IsInt()
    @IsDefined()
    @Expose({ name: "louver_count" })
    /** A positive integer for the number of louvers to generate. */
    louverCount!: number;
	
    @Type(() => String)
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

        if (_data) {
            const obj = deepTransform(LouversByCount, _data);
            this.louverCount = obj.louverCount;
            this.type = obj.type ?? "LouversByCount";
            this.depth = obj.depth;
            this.offset = obj.offset ?? 0;
            this.angle = obj.angle ?? 0;
            this.contourVector = obj.contourVector ?? [0, 1];
            this.flipStartSide = obj.flipStartSide ?? false;
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
