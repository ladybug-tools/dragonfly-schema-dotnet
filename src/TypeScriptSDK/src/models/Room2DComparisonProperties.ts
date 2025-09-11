import { IsString, IsOptional, Matches, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { IsNestedNumberArray } from "./../helpers/class-validator";
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { DetailedSkylights } from "./DetailedSkylights";
import { DetailedWindows } from "./DetailedWindows";
import { GriddedSkylightArea } from "./GriddedSkylightArea";
import { GriddedSkylightRatio } from "./GriddedSkylightRatio";
import { RectangularWindows } from "./RectangularWindows";
import { RepeatingWindowRatio } from "./RepeatingWindowRatio";
import { SimpleWindowArea } from "./SimpleWindowArea";
import { SimpleWindowRatio } from "./SimpleWindowRatio";
import { SingleWindow } from "./SingleWindow";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class Room2DComparisonProperties extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^Room2DComparisonProperties$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Room2DComparisonProperties";
	
    @IsArray()
    @IsNestedNumberArray()
    @IsOptional()
    @Expose({ name: "floor_boundary" })
    /** A list of 2D points representing the outer boundary vertices of the Room2D to which the host Room2D is being compared. The list should include at least 3 points and each point should be a list of 2 (x, y) values. */
    floorBoundary?: number[][];
	
    @IsArray()
    @IsNestedNumberArray()
    @IsOptional()
    @Expose({ name: "floor_holes" })
    /** Optional list of lists with one list for each hole in the floor plate of the Room2D to which the host Room2D is being compared. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate. */
    floorHoles?: number[][][];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "comparison_windows" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'SingleWindow') return SingleWindow.fromJS(item);
      else if (item?.type === 'SimpleWindowArea') return SimpleWindowArea.fromJS(item);
      else if (item?.type === 'SimpleWindowRatio') return SimpleWindowRatio.fromJS(item);
      else if (item?.type === 'RepeatingWindowRatio') return RepeatingWindowRatio.fromJS(item);
      else if (item?.type === 'RectangularWindows') return RectangularWindows.fromJS(item);
      else if (item?.type === 'DetailedWindows') return DetailedWindows.fromJS(item);
      else return item;
    }))
    /** A list of WindowParameter objects that dictate the window geometries of the Room2D to which the host Room2D is being compared. */
    comparisonWindows?: (SingleWindow | SimpleWindowArea | SimpleWindowRatio | RepeatingWindowRatio | RectangularWindows | DetailedWindows)[];
	
    @IsOptional()
    @Expose({ name: "comparison_skylight" })
    @Transform(({ value }) => {
      const item = value;
      if (item?.type === 'GriddedSkylightArea') return GriddedSkylightArea.fromJS(item);
      else if (item?.type === 'GriddedSkylightRatio') return GriddedSkylightRatio.fromJS(item);
      else if (item?.type === 'DetailedSkylights') return DetailedSkylights.fromJS(item);
      else return item;
    })
    /** A SkylightParameter object for the Room2D to which the host Room2D is being compared. */
    comparisonSkylight?: (GriddedSkylightArea | GriddedSkylightRatio | DetailedSkylights);
	

    constructor() {
        super();
        this.type = "Room2DComparisonProperties";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(Room2DComparisonProperties, _data);
            this.type = obj.type ?? "Room2DComparisonProperties";
            this.floorBoundary = obj.floorBoundary;
            this.floorHoles = obj.floorHoles;
            this.comparisonWindows = obj.comparisonWindows;
            this.comparisonSkylight = obj.comparisonSkylight;
        }
    }


    static override fromJS(data: any): Room2DComparisonProperties {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Room2DComparisonProperties();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "Room2DComparisonProperties";
        data["floor_boundary"] = this.floorBoundary;
        data["floor_holes"] = this.floorHoles;
        data["comparison_windows"] = this.comparisonWindows;
        data["comparison_skylight"] = this.comparisonSkylight;
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
