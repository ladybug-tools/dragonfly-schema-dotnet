import { IsNumber, IsDefined, IsBoolean, IsOptional, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base object for all GridParameters. */
export class _GridParameterBase extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    @Expose({ name: "dimension" })
    /** The dimension of the grid cells as a number. */
    dimension!: number;
	
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "include_mesh" })
    /** A boolean to note whether the resulting SensorGrid should include the mesh. */
    includeMesh: boolean = true;
	
    @IsString()
    @IsOptional()
    @Matches(/^_GridParameterBase$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "_GridParameterBase";
	

    constructor() {
        super();
        this.includeMesh = true;
        this.type = "_GridParameterBase";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(_GridParameterBase, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.dimension = obj.dimension;
            this.includeMesh = obj.includeMesh ?? true;
            this.type = obj.type ?? "_GridParameterBase";
        }
    }


    static override fromJS(data: any): _GridParameterBase {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new _GridParameterBase();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["dimension"] = this.dimension;
        data["include_mesh"] = this.includeMesh ?? true;
        data["type"] = this.type ?? "_GridParameterBase";
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
