import { IsInt, IsOptional, IsArray, IsNumber, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { Autocalculate } from "honeybee-schema";
import { RoomGridParameter } from "./RoomGridParameter";

/** Instructions for a SensorGrid of radial directions around positions from floors.\n\nThis type of sensor grid is particularly helpful for studies of multiple\nview directions, such as imageless glare studies. */
export class RoomRadialGridParameter extends RoomGridParameter {
    @IsInt()
    @IsOptional()
    /** A positive integer for the number of radial directions to be generated around each position. */
    dir_count?: number;
	
    @IsArray()
    @IsNumber({},{ each: true })
    @IsOptional()
    /** A vector as 3 (x, y, z) values to set the start direction of the generated directions. This can be used to orient the resulting sensors to specific parts of the scene. It can also change the elevation of the resulting directions since this start vector will always be rotated in the XY plane to generate the resulting directions. */
    start_vector?: number [];
	
    @IsOptional()
    /** An optional number to override the radius of the meshes generated around each sensor. If Autocalculate, it will be equal to 45 percent of the grid dimension. */
    mesh_radius?: (Autocalculate | number);
	
    @IsString()
    @IsOptional()
    @Matches(/^RoomRadialGridParameter$/)
    type?: string;
	

    constructor() {
        super();
        this.dir_count = 8;
        this.mesh_radius = new Autocalculate();
        this.type = "RoomRadialGridParameter";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(RoomRadialGridParameter, _data);
            this.dir_count = obj.dir_count;
            this.start_vector = obj.start_vector;
            this.mesh_radius = obj.mesh_radius;
            this.type = obj.type;
        }
    }


    static override fromJS(data: any): RoomRadialGridParameter {
        data = typeof data === 'object' ? data : {};

        let result = new RoomRadialGridParameter();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["dir_count"] = this.dir_count;
        data["start_vector"] = this.start_vector;
        data["mesh_radius"] = this.mesh_radius;
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
