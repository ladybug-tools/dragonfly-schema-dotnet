import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { Autocalculate } from "honeybee-schema";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class Room2DDoe2Properties extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^Room2DDoe2Properties$/)
    /** Type */
    Type: string = "Room2DDoe2Properties";
	
    @IsOptional()
    /** A number for the design supply air flow rate for the zone the Room is assigned to (cfm). This establishes the minimum allowed design air flow. Note that the actual design flow may be larger. If Autocalculate, this parameter will not be written into the INP. */
    AssignedFlow: (Autocalculate | number) = new Autocalculate();
	
    @IsOptional()
    /** A number for the design supply air flow rate to the zone per unit floor area (cfm/ft2). If Autocalculate, this parameter will not be written into the INP. */
    FlowPerArea: (Autocalculate | number) = new Autocalculate();
	
    @IsOptional()
    /** A number between 0 and 1 for the minimum allowable zone air supply flow rate, expressed as a fraction of design flow rate. Applicable to variable-volume type systems only. If Autocalculate, this parameter will not be written into the INP. */
    MinFlowRatio: (Autocalculate | number) = new Autocalculate();
	
    @IsOptional()
    /** A number for the minimum air flow per square foot of floor area (cfm/ft2). This is an alternative way of specifying the min_flow_ratio. If Autocalculate, this parameter will not be written into the INP. */
    MinFlowPerArea: (Autocalculate | number) = new Autocalculate();
	
    @IsOptional()
    /** A number between 0 and 1 for the ratio of the maximum (or fixed) heating airflow to the cooling airflow. The specific meaning varies according to the type of zone terminal. If Autocalculate, this parameter will not be written into the INP. */
    HmaxFlowRatio: (Autocalculate | number) = new Autocalculate();
	

    constructor() {
        super();
        this.Type = "Room2DDoe2Properties";
        this.AssignedFlow = new Autocalculate();
        this.FlowPerArea = new Autocalculate();
        this.MinFlowRatio = new Autocalculate();
        this.MinFlowPerArea = new Autocalculate();
        this.HmaxFlowRatio = new Autocalculate();
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Room2DDoe2Properties, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.assigned_flow = obj.assigned_flow;
            this.flow_per_area = obj.flow_per_area;
            this.min_flow_ratio = obj.min_flow_ratio;
            this.min_flow_per_area = obj.min_flow_per_area;
            this.hmax_flow_ratio = obj.hmax_flow_ratio;
        }
    }


    static override fromJS(data: any): Room2DDoe2Properties {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Room2DDoe2Properties();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["assigned_flow"] = this.assigned_flow;
        data["flow_per_area"] = this.flow_per_area;
        data["min_flow_ratio"] = this.min_flow_ratio;
        data["min_flow_per_area"] = this.min_flow_per_area;
        data["hmax_flow_ratio"] = this.hmax_flow_ratio;
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
