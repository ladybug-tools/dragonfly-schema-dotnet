import { IsNumber, IsDefined, IsBoolean, IsOptional, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel.ts";

/** Base object for all GridParameters. */
export class _GridParameterBase extends _OpenAPIGenBaseModel {
    @IsNumber()
    @IsDefined()
    /** The dimension of the grid cells as a number. */
    dimension!: number;
	
    @IsBoolean()
    @IsOptional()
    /** A boolean to note whether the resulting SensorGrid should include the mesh. */
    include_mesh?: boolean;
	
    @IsString()
    @IsOptional()
    @Matches(/^_GridParameterBase$/)
    type?: string;
	

    constructor() {
        super();
        this.include_mesh = true;
        this.type = "_GridParameterBase";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(_GridParameterBase, _data, { enableImplicitConversion: true });
            this.dimension = obj.dimension;
            this.include_mesh = obj.include_mesh;
            this.type = obj.type;
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
        data["include_mesh"] = this.include_mesh;
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

