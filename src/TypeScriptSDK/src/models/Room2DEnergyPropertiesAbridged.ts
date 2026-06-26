import { IsString, IsOptional, Equals, MinLength, MaxLength, IsNumber, Min, IsArray, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { DaylightingControl } from "honeybee-schema";
import { ProcessAbridged } from "honeybee-schema";
import { VentilationControlAbridged } from "honeybee-schema";
import { VentilationFan } from "honeybee-schema";
import { VentilationOpening } from "honeybee-schema";

export class Room2DEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Equals("Room2DEnergyPropertiesAbridged")
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
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "person_count" })
    /** Number for the total number of people in the room or an Unassigned object to indicate that people are assigned via the program_type. */
    personCount?: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "lighting_watts" })
    /** Number for the total wattage of lighting in the room or an Unassigned object to indicate that lighting is assigned via the program_type. */
    lightingWatts?: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "electric_equipment_watts" })
    /** Number for the total wattage of electric equipment in the room or an Unassigned object to indicate that electric equipment is assigned via the program_type. */
    electricEquipmentWatts?: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "gas_equipment_watts" })
    /** Number for the total wattage of gas equipment in the room or an Unassigned object to indicate that gas equipment is assigned via the program_type. */
    gasEquipmentWatts?: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "hot_water_flow" })
    /** Number for the total flow of hot water in the room or an Unassigned object to indicate that service hot water is assigned via the program_type. */
    hotWaterFlow?: number;
	
    @Type(() => Number)
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Expose({ name: "infiltration_ach" })
    /** Number for the infiltration of the room in air changes per hour or an Unassigned object to indicate that infiltration is assigned via the program_type. */
    infiltrationAch?: number;
	
    @IsArray()
    @Type(() => ProcessAbridged)
    @IsInstance(ProcessAbridged, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "process_loads" })
    /** An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators. */
    processLoads?: ProcessAbridged[];
	
    @Type(() => DaylightingControl)
    @IsInstance(DaylightingControl)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "daylighting_control" })
    /** An optional DaylightingControl object to dictate the dimming of lights. If None, the lighting will respond only to the schedule and not the daylight conditions within the room. */
    daylightingControl?: DaylightingControl;
	
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
    @Type(() => VentilationFan)
    @IsInstance(VentilationFan, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "fans" })
    /** An optional list of VentilationFan objects for fans within the room. Note that these fans are not connected to the heating or cooling system and are meant to represent the intentional circulation of unconditioned outdoor air for the purposes of keeping a space cooler, drier or free of indoor pollutants (as in the case of kitchen or bathroom exhaust fans). For the specification of mechanical ventilation of conditioned outdoor air, the Room.ventilation property should be used and the Room should be given a HVAC that can meet this specification. */
    fans?: VentilationFan[];
	

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
            this.personCount = obj.personCount;
            this.lightingWatts = obj.lightingWatts;
            this.electricEquipmentWatts = obj.electricEquipmentWatts;
            this.gasEquipmentWatts = obj.gasEquipmentWatts;
            this.hotWaterFlow = obj.hotWaterFlow;
            this.infiltrationAch = obj.infiltrationAch;
            this.processLoads = obj.processLoads;
            this.daylightingControl = obj.daylightingControl;
            this.windowVentControl = obj.windowVentControl;
            this.windowVentOpening = obj.windowVentOpening;
            this.fans = obj.fans;
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
        data["person_count"] = this.personCount;
        data["lighting_watts"] = this.lightingWatts;
        data["electric_equipment_watts"] = this.electricEquipmentWatts;
        data["gas_equipment_watts"] = this.gasEquipmentWatts;
        data["hot_water_flow"] = this.hotWaterFlow;
        data["infiltration_ach"] = this.infiltrationAch;
        data["process_loads"] = this.processLoads;
        data["daylighting_control"] = this.daylightingControl;
        data["window_vent_control"] = this.windowVentControl;
        data["window_vent_opening"] = this.windowVentOpening;
        data["fans"] = this.fans;
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
