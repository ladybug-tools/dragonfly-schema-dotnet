import { IsString, IsOptional, Matches, MinLength, MaxLength, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class BuildingEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^BuildingEnergyPropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "BuildingEnergyPropertiesAbridged";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "construction_set" })
    /** Name of a ConstructionSet to specify all constructions for the Building. If None, the Model global_construction_set will be used. */
    constructionSet?: string;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "ceiling_plenum_construction" })
    /** Identifier of an OpaqueConstruction for the bottoms of ceiling plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple acoustic tile construction. */
    ceilingPlenumConstruction?: string;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "floor_plenum_construction" })
    /** Identifier of an OpaqueConstruction for the tops of floor plenums. Materials should be ordered from the plenum side to the room side. By default, this is a simple wood plank construction. */
    floorPlenumConstruction?: string;
	

    constructor() {
        super();
        this.type = "BuildingEnergyPropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(BuildingEnergyPropertiesAbridged, _data);
            this.type = obj.type ?? "BuildingEnergyPropertiesAbridged";
            this.constructionSet = obj.constructionSet;
            this.ceilingPlenumConstruction = obj.ceilingPlenumConstruction;
            this.floorPlenumConstruction = obj.floorPlenumConstruction;
        }
    }


    static override fromJS(data: any): BuildingEnergyPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new BuildingEnergyPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "BuildingEnergyPropertiesAbridged";
        data["construction_set"] = this.constructionSet;
        data["ceiling_plenum_construction"] = this.ceilingPlenumConstruction;
        data["floor_plenum_construction"] = this.floorPlenumConstruction;
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
