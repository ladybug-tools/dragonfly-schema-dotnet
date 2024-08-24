import { IsArray, ValidateNested, IsDefined, IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Several detailed skylights defined by 2D Polygons (lists of 2D vertices). */
export class DetailedSkylights extends _OpenAPIGenBaseModel {
    @IsArray()
    @ValidateNested({ each: true })
    @IsDefined()
    /** An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon. */
    polygons!: number [] [] [];
	
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsArray()
    @ValidateNested({ each: true })
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
            this.polygons = _data["polygons"];
            this.type = _data["type"] !== undefined ? _data["type"] : "DetailedSkylights";
            this.are_doors = _data["are_doors"];
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
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["polygons"] = this.polygons;
        data["type"] = this.type;
        data["are_doors"] = this.are_doors;
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
