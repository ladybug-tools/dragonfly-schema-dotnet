import { IsString, IsOptional, Matches, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
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
    @IsString()
    @IsOptional()
    @Matches(/^Room2DComparisonProperties$/)
    /** Type */
    type?: string;
	
    @IsArray()
    @IsNestedNumberArray()
    @IsOptional()
    /** A list of 2D points representing the outer boundary vertices of the Room2D to which the host Room2D is being compared. The list should include at least 3 points and each point should be a list of 2 (x, y) values. */
    floor_boundary?: number [] [];
	
    @IsArray()
    @IsNestedNumberArray()
    @IsOptional()
    /** Optional list of lists with one list for each hole in the floor plate of the Room2D to which the host Room2D is being compared. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate. */
    floor_holes?: number [] [] [];
	
    @IsArray()
    @IsOptional()
    @Transform(({ value }) => value.map((item: any) => {
      if (item?.type === 'SingleWindow') return SingleWindow.fromJS(item);
      else if (item?.type === 'SimpleWindowArea') return SimpleWindowArea.fromJS(item);
      else if (item?.type === 'SimpleWindowRatio') return SimpleWindowRatio.fromJS(item);
      else if (item?.type === 'RepeatingWindowRatio') return RepeatingWindowRatio.fromJS(item);
      else if (item?.type === 'RectangularWindows') return RectangularWindows.fromJS(item);
      else if (item?.type === 'DetailedWindows') return DetailedWindows.fromJS(item);
      else return item;
    }))
    /** A list of WindowParameter objects that dictate the window geometries of the Room2D to which the host Room2D is being compared. */
    comparison_windows?: (SingleWindow | SimpleWindowArea | SimpleWindowRatio | RepeatingWindowRatio | RectangularWindows | DetailedWindows) [];
	
    @IsOptional()
    @Transform(({ value }) => {
      const item = value;
      if (item?.type === 'GriddedSkylightArea') return GriddedSkylightArea.fromJS(item);
      else if (item?.type === 'GriddedSkylightRatio') return GriddedSkylightRatio.fromJS(item);
      else if (item?.type === 'DetailedSkylights') return DetailedSkylights.fromJS(item);
      else return item;
    })
    /** A SkylightParameter object for the Room2D to which the host Room2D is being compared. */
    comparison_skylight?: (GriddedSkylightArea | GriddedSkylightRatio | DetailedSkylights);
	

    constructor() {
        super();
        this.type = "Room2DComparisonProperties";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Room2DComparisonProperties, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.floor_boundary = obj.floor_boundary;
            this.floor_holes = obj.floor_holes;
            this.comparison_windows = obj.comparison_windows;
            this.comparison_skylight = obj.comparison_skylight;
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
        data["type"] = this.type;
        data["floor_boundary"] = this.floor_boundary;
        data["floor_holes"] = this.floor_holes;
        data["comparison_windows"] = this.comparison_windows;
        data["comparison_skylight"] = this.comparison_skylight;
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

