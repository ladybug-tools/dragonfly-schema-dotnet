import { IsInt, IsOptional, IsArray, IsNumber, IsString, Equals, IsDefined, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { Autocalculate } from "honeybee-schema";

/** Instructions for a SensorGrid of radial directions around positions from floors.\n\nThis type of sensor grid is particularly helpful for studies of multiple\nview directions, such as imageless glare studies. */
export class RoomRadialGridParameter {
    @Type(() => Number)
    @IsInt()
    @IsOptional()
    @Expose({ name: "dir_count" })
    /** A positive integer for the number of radial directions to be generated around each position. */
    dirCount: number = 8;
	
    @IsArray()
    @Type(() => Number)
    @IsNumber({},{ each: true })
    @IsOptional()
    @Expose({ name: "start_vector" })
    /** A vector as 3 (x, y, z) values to set the start direction of the generated directions. This can be used to orient the resulting sensors to specific parts of the scene. It can also change the elevation of the resulting directions since this start vector will always be rotated in the XY plane to generate the resulting directions. */
    startVector?: number[];
	
    @IsOptional()
    @Expose({ name: "mesh_radius" })
    /** An optional number to override the radius of the meshes generated around each sensor. If Autocalculate, it will be equal to 45 percent of the grid dimension. */
    meshRadius: (Autocalculate | number) = new Autocalculate();
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Equals("RoomRadialGridParameter")
    @Expose({ name: "type" })
    /** type */
    type: string = "RoomRadialGridParameter";
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Expose({ name: "offset" })
    /** A number for how far to offset the grid from the Room2D floors. (Default: 1.0, suitable for Models in Meters). */
    offset: number = 1;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Expose({ name: "wall_offset" })
    /** A number for the distance at which sensors close to walls should be removed. Note that this option has no effect unless the value is more than half of the dimension. */
    wallOffset: number = 0;
	
    @Type(() => Number)
    @IsNumber()
    @IsDefined()
    @Expose({ name: "dimension" })
    /** The dimension of the grid cells as a number. */
    dimension!: number;
	
    @Type(() => Boolean)
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "include_mesh" })
    /** A boolean to note whether the resulting SensorGrid should include the mesh. */
    includeMesh: boolean = true;
	

    constructor() {
        this.dirCount = 8;
        this.meshRadius = new Autocalculate();
        this.type = "RoomRadialGridParameter";
        this.offset = 1;
        this.wallOffset = 0;
        this.includeMesh = true;
    }


    init(_data?: any) {

        if (_data) {
            const obj = deepTransform(RoomRadialGridParameter, _data);
            this.dirCount = obj.dirCount ?? 8;
            this.startVector = obj.startVector;
            this.meshRadius = obj.meshRadius ?? new Autocalculate();
            this.type = obj.type ?? "RoomRadialGridParameter";
            this.offset = obj.offset ?? 1;
            this.wallOffset = obj.wallOffset ?? 0;
            this.dimension = obj.dimension;
            this.includeMesh = obj.includeMesh ?? true;
        }
    }


    static fromJS(data: any): RoomRadialGridParameter {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new RoomRadialGridParameter();
        result.init(data);
        return result;
    }

	toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["dir_count"] = this.dirCount ?? 8;
        data["start_vector"] = this.startVector;
        data["mesh_radius"] = this.meshRadius ?? new Autocalculate();
        data["type"] = this.type ?? "RoomRadialGridParameter";
        data["offset"] = this.offset ?? 1;
        data["wall_offset"] = this.wallOffset ?? 0;
        data["dimension"] = this.dimension;
        data["include_mesh"] = this.includeMesh ?? true;
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
