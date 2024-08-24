import { IsNumber, IsDefined, IsBoolean, IsOptional, IsString, validate, ValidationError as TsValidationError } from 'class-validator';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { ExteriorApertureGridParameter } from "./ExteriorApertureGridParameter";
import { ExteriorFaceGridParameter } from "./ExteriorFaceGridParameter";
import { RoomGridParameter } from "./RoomGridParameter";
import { RoomRadialGridParameter } from "./RoomRadialGridParameter";

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
    type?: string;
	

    constructor() {
        super();
        this.include_mesh = true;
        this.type = "_GridParameterBase";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.dimension = _data["dimension"];
            this.include_mesh = _data["include_mesh"] !== undefined ? _data["include_mesh"] : true;
            this.type = _data["type"] !== undefined ? _data["type"] : "_GridParameterBase";
        }
    }


    static override fromJS(data: any): _GridParameterBase {
        data = typeof data === 'object' ? data : {};

        if (data["type"] === "RoomGridParameter") {
            let result = new RoomGridParameter();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoomRadialGridParameter") {
            let result = new RoomRadialGridParameter();
            result.init(data);
            return result;
        }
        if (data["type"] === "ExteriorFaceGridParameter") {
            let result = new ExteriorFaceGridParameter();
            result.init(data);
            return result;
        }
        if (data["type"] === "ExteriorApertureGridParameter") {
            let result = new ExteriorApertureGridParameter();
            result.init(data);
            return result;
        }
        let result = new _GridParameterBase();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["dimension"] = this.dimension;
        data["include_mesh"] = this.include_mesh;
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
