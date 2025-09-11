import { IsString, IsOptional, Matches, IsNumber, IsEnum, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _GridParameterBase } from "./_GridParameterBase";
import { ExteriorFaceType } from "./ExteriorFaceType";

/** Instructions for a SensorGrid generated from exterior Faces. */
export class ExteriorFaceGridParameter extends _GridParameterBase {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^ExteriorFaceGridParameter$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "ExteriorFaceGridParameter";
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Expose({ name: "offset" })
    /** A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters). */
    offset: number = 0.1;
	
    @Type(() => String)
    @IsEnum(ExteriorFaceType)
    @IsOptional()
    @Expose({ name: "face_type" })
    /** Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever. */
    faceType: ExteriorFaceType = ExteriorFaceType.Wall;
	
    @Type(() => Boolean)
    @IsBoolean()
    @IsOptional()
    @Expose({ name: "punched_geometry" })
    /** A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False). */
    punchedGeometry: boolean = false;
	

    constructor() {
        super();
        this.type = "ExteriorFaceGridParameter";
        this.offset = 0.1;
        this.faceType = ExteriorFaceType.Wall;
        this.punchedGeometry = false;
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(ExteriorFaceGridParameter, _data);
            this.type = obj.type ?? "ExteriorFaceGridParameter";
            this.offset = obj.offset ?? 0.1;
            this.faceType = obj.faceType ?? ExteriorFaceType.Wall;
            this.punchedGeometry = obj.punchedGeometry ?? false;
            this.dimension = obj.dimension;
            this.includeMesh = obj.includeMesh ?? true;
        }
    }


    static override fromJS(data: any): ExteriorFaceGridParameter {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ExteriorFaceGridParameter();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "ExteriorFaceGridParameter";
        data["offset"] = this.offset ?? 0.1;
        data["face_type"] = this.faceType ?? ExteriorFaceType.Wall;
        data["punched_geometry"] = this.punchedGeometry ?? false;
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
