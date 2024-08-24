import { IsString, IsOptional, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Room2DEnergyPropertiesAbridged } from "./Room2DEnergyPropertiesAbridged";
import { Room2DRadiancePropertiesAbridged } from "./Room2DRadiancePropertiesAbridged";

export class Room2DPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    type?: string;
	
    @IsInstance(Room2DEnergyPropertiesAbridged)
    @ValidateNested()
    @IsOptional()
    energy?: Room2DEnergyPropertiesAbridged;
	
    @IsInstance(Room2DRadiancePropertiesAbridged)
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
            this.type = _data["type"] !== undefined ? _data["type"] : "Room2DPropertiesAbridged";
            this.energy = _data["energy"];
            this.radiance = _data["radiance"];
        }
    }


    static override fromJS(data: any): Room2DPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new Room2DPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["type"] = this.type;
        data["energy"] = this.energy;
        data["radiance"] = this.radiance;
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
