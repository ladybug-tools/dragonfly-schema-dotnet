import { IsNumber, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Extruded borders over all windows in the wall. */
export class ExtrudedBorder extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    /** A number for the depth of the border. */
    depth!: number;
	
    @IsString()
    @IsOptional()
    type?: string;
	

    constructor() {
        super();
        this.type = "ExtrudedBorder";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ExtrudedBorder, _data);
            this.depth = obj.depth;
            this.type = obj.type;
        }
    }


    static override fromJS(data: any): ExtrudedBorder {
        data = typeof data === 'object' ? data : {};

        let result = new ExtrudedBorder();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["depth"] = this.depth;
        data["type"] = this.type;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error.property]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
