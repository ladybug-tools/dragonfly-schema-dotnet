import { IsArray, IsDefined, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { IsNestedNumberArray } from "./../helpers/class-validator";
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Several detailed skylights defined by 2D Polygons (lists of 2D vertices). */
export class DetailedSkylights extends _OpenAPIGenBaseModel {
    @IsArray()
    @IsNestedNumberArray()
    @IsDefined()
    /** An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon. */
    polygons!: number [] [] [];
	
    @IsString()
    @IsOptional()
    @Matches(/^DetailedSkylights$/)
    type?: string;
	
    @IsArray()
    @IsBoolean({ each: true })
    @IsOptional()
    /** An array of booleans that align with the polygons and note whether each of the polygons represents an overhead door (True) or a skylight (False). If None, it will be assumed that all polygons represent skylights and they will be translated to Apertures in any resulting Honeybee model. */
    are_doors?: boolean [];
	

    constructor() {
        super();
        this.type = "DetailedSkylights";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(DetailedSkylights, _data, { enableImplicitConversion: true });
            this.polygons = obj.polygons;
            this.type = obj.type;
            this.are_doors = obj.are_doors;
        }
    }


    static override fromJS(data: any): DetailedSkylights {
        data = typeof data === 'object' ? data : {};

        let result = new DetailedSkylights();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["polygons"] = this.polygons;
        data["type"] = this.type;
        data["are_doors"] = this.are_doors;
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

