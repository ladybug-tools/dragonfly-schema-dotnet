import { IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _LouversBase } from "./_LouversBase";

/** A series of louvered Shades at a given distance between each louver. */
export class LouversByDistance extends _LouversBase {
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "distance" })
    /** A number for the approximate distance between each louver. */
    distance!: number;
	
    @Type(() => String)
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

        if (_data) {
            const obj = deepTransform(LouversByDistance, _data);
            this.distance = obj.distance;
            this.type = obj.type ?? "LouversByDistance";
            this.depth = obj.depth;
            this.offset = obj.offset ?? 0;
            this.angle = obj.angle ?? 0;
            this.contourVector = obj.contourVector ?? [0, 1];
            this.flipStartSide = obj.flipStartSide ?? false;
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
