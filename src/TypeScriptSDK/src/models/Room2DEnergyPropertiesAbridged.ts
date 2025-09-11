import { IsString, IsOptional, Matches, MinLength, MaxLength, IsInstance, ValidateNested, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { ProcessAbridged } from "honeybee-schema";
import { VentilationControlAbridged } from "honeybee-schema";
import { VentilationOpening } from "honeybee-schema";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class Room2DEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Matches(/^Room2DEnergyPropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Room2DEnergyPropertiesAbridged";
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "construction_set" })
    /** Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects. */
    constructionSet?: string;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "program_type" })
    /** Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints. */
    programType?: string;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "hvac" })
    /** An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned. */
    hvac?: string;
	
    @Type(() => String)
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "shw" })
    /** An optional identifier of a Service Hot Water (SHW) system that specifies how the hot water load of the Room is met. If None, the hot water load will be met with a generic system that only measures thermal loadand does not account for system efficiencies. */
    shw?: string;
	
    @Type(() => VentilationControlAbridged)
    @IsInstance(VentilationControlAbridged)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "window_vent_control" })
    /** An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open. */
    windowVentControl?: VentilationControlAbridged;
	
    @Type(() => VentilationOpening)
    @IsInstance(VentilationOpening)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "window_vent_opening" })
    /** An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open. */
    windowVentOpening?: VentilationOpening;
	
    @IsArray()
    @Type(() => ProcessAbridged)
    @IsInstance(ProcessAbridged, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "process_loads" })
    /** An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators. */
    processLoads?: ProcessAbridged[];
	

    constructor() {
        super();
        this.type = "Room2DEnergyPropertiesAbridged";
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(Room2DEnergyPropertiesAbridged, _data);
            this.type = obj.type ?? "Room2DEnergyPropertiesAbridged";
            this.constructionSet = obj.constructionSet;
            this.programType = obj.programType;
            this.hvac = obj.hvac;
            this.shw = obj.shw;
            this.windowVentControl = obj.windowVentControl;
            this.windowVentOpening = obj.windowVentOpening;
            this.processLoads = obj.processLoads;
        }
    }


    static override fromJS(data: any): Room2DEnergyPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Room2DEnergyPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "Room2DEnergyPropertiesAbridged";
        data["construction_set"] = this.constructionSet;
        data["program_type"] = this.programType;
        data["hvac"] = this.hvac;
        data["shw"] = this.shw;
        data["window_vent_control"] = this.windowVentControl;
        data["window_vent_opening"] = this.windowVentOpening;
        data["process_loads"] = this.processLoads;
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
