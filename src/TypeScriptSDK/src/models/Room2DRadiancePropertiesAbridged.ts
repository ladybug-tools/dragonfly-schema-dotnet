import { IsString, IsOptional, Matches, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { ExteriorApertureGridParameter } from "./ExteriorApertureGridParameter";
import { ExteriorFaceGridParameter } from "./ExteriorFaceGridParameter";
import { RoomGridParameter } from "./RoomGridParameter";
import { RoomRadialGridParameter } from "./RoomRadialGridParameter";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class Room2DRadiancePropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^Room2DRadiancePropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Room2DRadiancePropertiesAbridged";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Expose({ name: "modifier_set" })
    /** Identifier of a ModifierSet to specify all modifiers for the Room2D. If None, the Room2D will use the Story or Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects. */
    modifierSet?: string;
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "grid_parameters" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'RoomGridParameter') return RoomGridParameter.fromJS(item);
      else if (item?.type === 'RoomRadialGridParameter') return RoomRadialGridParameter.fromJS(item);
      else if (item?.type === 'ExteriorFaceGridParameter') return ExteriorFaceGridParameter.fromJS(item);
      else if (item?.type === 'ExteriorApertureGridParameter') return ExteriorApertureGridParameter.fromJS(item);
      else return item;
    }))
    /** An optional list of GridParameter objects to describe how sensor grids should be generated for the Room2D. */
    gridParameters?: (RoomGridParameter | RoomRadialGridParameter | ExteriorFaceGridParameter | ExteriorApertureGridParameter)[];
	

    constructor() {
        super();
        this.type = "Room2DRadiancePropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(Room2DRadiancePropertiesAbridged, _data);
            this.type = obj.type ?? "Room2DRadiancePropertiesAbridged";
            this.modifierSet = obj.modifierSet;
            this.gridParameters = obj.gridParameters;
        }
    }


    static override fromJS(data: any): Room2DRadiancePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Room2DRadiancePropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "Room2DRadiancePropertiesAbridged";
        data["modifier_set"] = this.modifierSet;
        data["grid_parameters"] = this.gridParameters;
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
