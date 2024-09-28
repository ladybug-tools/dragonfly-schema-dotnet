import { IsString, IsOptional, Matches, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel.ts";
import { Room2DEnergyPropertiesAbridged } from "./Room2DEnergyPropertiesAbridged.ts";
import { Room2DRadiancePropertiesAbridged } from "./Room2DRadiancePropertiesAbridged.ts";

export class Room2DPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^Room2DPropertiesAbridged$/)
    type?: string;
	
    @IsInstance(Room2DEnergyPropertiesAbridged)
    @Type(() => Room2DEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    energy?: Room2DEnergyPropertiesAbridged;
	
    @IsInstance(Room2DRadiancePropertiesAbridged)
    @Type(() => Room2DRadiancePropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    radiance?: Room2DRadiancePropertiesAbridged;
	

    constructor() {
        super();
        this.type = "Room2DPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Room2DPropertiesAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.energy = obj.energy;
            this.radiance = obj.radiance;
        }
    }


    static override fromJS(data: any): Room2DPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Room2DPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
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

