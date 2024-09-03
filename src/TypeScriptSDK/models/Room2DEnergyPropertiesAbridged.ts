﻿import { IsString, IsOptional, Matches, MinLength, MaxLength, IsInstance, ValidateNested, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { ProcessAbridged } from "honeybee-schema";
import { VentilationControlAbridged } from "honeybee-schema";
import { VentilationOpening } from "honeybee-schema";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class Room2DEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^Room2DEnergyPropertiesAbridged$/)
    type?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects. */
    construction_set?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints. */
    program_type?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned. */
    hvac?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** An optional identifier of a Service Hot Water (SHW) system that specifies how the hot water load of the Room is met. If None, the hot water load will be met with a generic system that only measures thermal loadand does not account for system efficiencies. */
    shw?: string;
	
    @IsInstance(VentilationControlAbridged)
    @Type(() => VentilationControlAbridged)
    @ValidateNested()
    @IsOptional()
    /** An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open. */
    window_vent_control?: VentilationControlAbridged;
	
    @IsInstance(VentilationOpening)
    @Type(() => VentilationOpening)
    @ValidateNested()
    @IsOptional()
    /** An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open. */
    window_vent_opening?: VentilationOpening;
	
    @IsArray()
    @IsInstance(ProcessAbridged, { each: true })
    @Type(() => ProcessAbridged)
    @ValidateNested({ each: true })
    @IsOptional()
    /** An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators. */
    process_loads?: ProcessAbridged [];
	

    constructor() {
        super();
        this.type = "Room2DEnergyPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Room2DEnergyPropertiesAbridged, _data);
            this.type = obj.type;
            this.construction_set = obj.construction_set;
            this.program_type = obj.program_type;
            this.hvac = obj.hvac;
            this.shw = obj.shw;
            this.window_vent_control = obj.window_vent_control;
            this.window_vent_opening = obj.window_vent_opening;
            this.process_loads = obj.process_loads;
        }
    }


    static override fromJS(data: any): Room2DEnergyPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new Room2DEnergyPropertiesAbridged();
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
        data["construction_set"] = this.construction_set;
        data["program_type"] = this.program_type;
        data["hvac"] = this.hvac;
        data["shw"] = this.shw;
        data["window_vent_control"] = this.window_vent_control;
        data["window_vent_opening"] = this.window_vent_opening;
        data["process_loads"] = this.process_loads;
        super.toJSON(data);
        return data;
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error.property]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}
