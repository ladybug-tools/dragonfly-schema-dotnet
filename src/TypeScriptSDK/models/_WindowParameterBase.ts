import { IsOptional, IsString, validate, ValidationError as TsValidationError } from 'class-validator';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { DetailedWindows } from "./DetailedWindows";
import { RectangularWindows } from "./RectangularWindows";
import { RepeatingWindowRatio } from "./RepeatingWindowRatio";
import { SimpleWindowArea } from "./SimpleWindowArea";
import { SimpleWindowRatio } from "./SimpleWindowRatio";
import { SingleWindow } from "./SingleWindow";

/** Base class for all window parameters. */
export class _WindowParameterBase extends _OpenAPIGenBaseModel {
    @IsOptional()
    /** Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). When a list is used, each item in the list will be assigned to the generated Honeybee apertures. */
    user_data?: Object;
	
    @IsString()
    @IsOptional()
    type?: string;
	

    constructor() {
        super();
        this.type = "_WindowParameterBase";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.user_data = _data["user_data"];
            this.type = _data["type"] !== undefined ? _data["type"] : "_WindowParameterBase";
        }
    }


    static override fromJS(data: any): _WindowParameterBase {
        data = typeof data === 'object' ? data : {};

        if (data["type"] === "SimpleWindowArea") {
            let result = new SimpleWindowArea();
            result.init(data);
            return result;
        }
        if (data["type"] === "RectangularWindows") {
            let result = new RectangularWindows();
            result.init(data);
            return result;
        }
        if (data["type"] === "SingleWindow") {
            let result = new SingleWindow();
            result.init(data);
            return result;
        }
        if (data["type"] === "SimpleWindowRatio") {
            let result = new SimpleWindowRatio();
            result.init(data);
            return result;
        }
        if (data["type"] === "RepeatingWindowRatio") {
            let result = new RepeatingWindowRatio();
            result.init(data);
            return result;
        }
        if (data["type"] === "DetailedWindows") {
            let result = new DetailedWindows();
            result.init(data);
            return result;
        }
        let result = new _WindowParameterBase();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["user_data"] = this.user_data;
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
