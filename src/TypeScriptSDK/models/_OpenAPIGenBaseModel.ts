import { IsString, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { _AllAirBase } from "./_AllAirBase";
import { _DOASBase } from "./_DOASBase";
import { _EquipmentBase } from "./_EquipmentBase";
import { _FaceSubSet } from "./_FaceSubSet";
import { _FaceSubSetAbridged } from "./_FaceSubSetAbridged";
import { _GridParameterBase } from "./_GridParameterBase";
import { _HeatCoolBase } from "./_HeatCoolBase";
import { _LouversBase } from "./_LouversBase";
import { _PropertiesBaseAbridged } from "./_PropertiesBaseAbridged";
import { _TemplateSystem } from "./_TemplateSystem";
import { _WindowParameterBase } from "./_WindowParameterBase";
import { Adiabatic } from "./Adiabatic";
import { AFNCrack } from "./AFNCrack";
import { AirBoundaryConstruction } from "./AirBoundaryConstruction";
import { AirBoundaryConstructionAbridged } from "./AirBoundaryConstructionAbridged";
import { Aperture } from "./Aperture";
import { ApertureConstructionSet } from "./ApertureConstructionSet";
import { ApertureConstructionSetAbridged } from "./ApertureConstructionSetAbridged";
import { ApertureEnergyPropertiesAbridged } from "./ApertureEnergyPropertiesAbridged";
import { ApertureModifierSet } from "./ApertureModifierSet";
import { ApertureModifierSetAbridged } from "./ApertureModifierSetAbridged";
import { AperturePropertiesAbridged } from "./AperturePropertiesAbridged";
import { ApertureRadiancePropertiesAbridged } from "./ApertureRadiancePropertiesAbridged";
import { Autocalculate } from "./Autocalculate";
import { Autosize } from "./Autosize";
import { Baseboard } from "./Baseboard";
import { BaseModifierSet } from "./BaseModifierSet";
import { BaseModifierSetAbridged } from "./BaseModifierSetAbridged";
import { BSDF } from "./BSDF";
import { Building } from "./Building";
import { BuildingEnergyPropertiesAbridged } from "./BuildingEnergyPropertiesAbridged";
import { BuildingPropertiesAbridged } from "./BuildingPropertiesAbridged";
import { BuildingRadiancePropertiesAbridged } from "./BuildingRadiancePropertiesAbridged";
import { Color } from "./Color";
import { ConstructionSet } from "./ConstructionSet";
import { ConstructionSetAbridged } from "./ConstructionSetAbridged";
import { ContextShade } from "./ContextShade";
import { ContextShadeEnergyPropertiesAbridged } from "./ContextShadeEnergyPropertiesAbridged";
import { ContextShadePropertiesAbridged } from "./ContextShadePropertiesAbridged";
import { ContextShadeRadiancePropertiesAbridged } from "./ContextShadeRadiancePropertiesAbridged";
import { DatedBaseModel } from "./DatedBaseModel";
import { DaylightingControl } from "./DaylightingControl";
import { DetailedHVAC } from "./DetailedHVAC";
import { DetailedSkylights } from "./DetailedSkylights";
import { DetailedWindows } from "./DetailedWindows";
import { Door } from "./Door";
import { DoorConstructionSet } from "./DoorConstructionSet";
import { DoorConstructionSetAbridged } from "./DoorConstructionSetAbridged";
import { DoorEnergyPropertiesAbridged } from "./DoorEnergyPropertiesAbridged";
import { DoorModifierSet } from "./DoorModifierSet";
import { DoorModifierSetAbridged } from "./DoorModifierSetAbridged";
import { DoorPropertiesAbridged } from "./DoorPropertiesAbridged";
import { DoorRadiancePropertiesAbridged } from "./DoorRadiancePropertiesAbridged";
import { ElectricEquipment } from "./ElectricEquipment";
import { ElectricEquipmentAbridged } from "./ElectricEquipmentAbridged";
import { EnergyBaseModel } from "./EnergyBaseModel";
import { EnergyMaterial } from "./EnergyMaterial";
import { EnergyMaterialNoMass } from "./EnergyMaterialNoMass";
import { EnergyMaterialVegetation } from "./EnergyMaterialVegetation";
import { EnergyWindowFrame } from "./EnergyWindowFrame";
import { EnergyWindowMaterialBlind } from "./EnergyWindowMaterialBlind";
import { EnergyWindowMaterialGas } from "./EnergyWindowMaterialGas";
import { EnergyWindowMaterialGasCustom } from "./EnergyWindowMaterialGasCustom";
import { EnergyWindowMaterialGasMixture } from "./EnergyWindowMaterialGasMixture";
import { EnergyWindowMaterialGlazing } from "./EnergyWindowMaterialGlazing";
import { EnergyWindowMaterialShade } from "./EnergyWindowMaterialShade";
import { EnergyWindowMaterialSimpleGlazSys } from "./EnergyWindowMaterialSimpleGlazSys";
import { EvaporativeCooler } from "./EvaporativeCooler";
import { ExteriorApertureGridParameter } from "./ExteriorApertureGridParameter";
import { ExteriorFaceGridParameter } from "./ExteriorFaceGridParameter";
import { ExtrudedBorder } from "./ExtrudedBorder";
import { Face } from "./Face";
import { Face3D } from "./Face3D";
import { FaceEnergyPropertiesAbridged } from "./FaceEnergyPropertiesAbridged";
import { FacePropertiesAbridged } from "./FacePropertiesAbridged";
import { FaceRadiancePropertiesAbridged } from "./FaceRadiancePropertiesAbridged";
import { FCU } from "./FCU";
import { FCUwithDOASAbridged } from "./FCUwithDOASAbridged";
import { FloorConstructionSet } from "./FloorConstructionSet";
import { FloorConstructionSetAbridged } from "./FloorConstructionSetAbridged";
import { FloorModifierSet } from "./FloorModifierSet";
import { FloorModifierSetAbridged } from "./FloorModifierSetAbridged";
import { ForcedAirFurnace } from "./ForcedAirFurnace";
import { GasEquipment } from "./GasEquipment";
import { GasEquipmentAbridged } from "./GasEquipmentAbridged";
import { GasUnitHeater } from "./GasUnitHeater";
import { Glass } from "./Glass";
import { GlobalConstructionSet } from "./GlobalConstructionSet";
import { GlobalModifierSet } from "./GlobalModifierSet";
import { Glow } from "./Glow";
import { GriddedSkylightArea } from "./GriddedSkylightArea";
import { GriddedSkylightRatio } from "./GriddedSkylightRatio";
import { Ground } from "./Ground";
import { IDdBaseModel } from "./IDdBaseModel";
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";
import { IDdRadianceBaseModel } from "./IDdRadianceBaseModel";
import { IdealAirSystemAbridged } from "./IdealAirSystemAbridged";
import { Infiltration } from "./Infiltration";
import { InfiltrationAbridged } from "./InfiltrationAbridged";
import { InternalMassAbridged } from "./InternalMassAbridged";
import { Light } from "./Light";
import { Lighting } from "./Lighting";
import { LightingAbridged } from "./LightingAbridged";
import { LouversByCount } from "./LouversByCount";
import { LouversByDistance } from "./LouversByDistance";
import { Mesh3D } from "./Mesh3D";
import { Metal } from "./Metal";
import { Mirror } from "./Mirror";
import { Model } from "./Model";
import { ModelEnergyProperties } from "./ModelEnergyProperties";
import { ModelProperties } from "./ModelProperties";
import { ModelRadianceProperties } from "./ModelRadianceProperties";
import { ModifierBase } from "./ModifierBase";
import { ModifierSet } from "./ModifierSet";
import { ModifierSetAbridged } from "./ModifierSetAbridged";
import { NoLimit } from "./NoLimit";
import { OpaqueConstruction } from "./OpaqueConstruction";
import { OpaqueConstructionAbridged } from "./OpaqueConstructionAbridged";
import { OtherSideTemperature } from "./OtherSideTemperature";
import { Outdoors } from "./Outdoors";
import { Overhang } from "./Overhang";
import { People } from "./People";
import { PeopleAbridged } from "./PeopleAbridged";
import { Plane } from "./Plane";
import { Plastic } from "./Plastic";
import { ProcessAbridged } from "./ProcessAbridged";
import { ProgramType } from "./ProgramType";
import { ProgramTypeAbridged } from "./ProgramTypeAbridged";
import { PSZ } from "./PSZ";
import { PTAC } from "./PTAC";
import { PVAV } from "./PVAV";
import { PVProperties } from "./PVProperties";
import { RadianceShadeStateAbridged } from "./RadianceShadeStateAbridged";
import { RadianceSubFaceStateAbridged } from "./RadianceSubFaceStateAbridged";
import { Radiant } from "./Radiant";
import { RadiantwithDOASAbridged } from "./RadiantwithDOASAbridged";
import { RectangularWindows } from "./RectangularWindows";
import { RepeatingWindowRatio } from "./RepeatingWindowRatio";
import { Residential } from "./Residential";
import { RoofCeilingConstructionSet } from "./RoofCeilingConstructionSet";
import { RoofCeilingConstructionSetAbridged } from "./RoofCeilingConstructionSetAbridged";
import { RoofCeilingModifierSet } from "./RoofCeilingModifierSet";
import { RoofCeilingModifierSetAbridged } from "./RoofCeilingModifierSetAbridged";
import { RoofSpecification } from "./RoofSpecification";
import { Room } from "./Room";
import { Room2D } from "./Room2D";
import { Room2DEnergyPropertiesAbridged } from "./Room2DEnergyPropertiesAbridged";
import { Room2DPropertiesAbridged } from "./Room2DPropertiesAbridged";
import { Room2DRadiancePropertiesAbridged } from "./Room2DRadiancePropertiesAbridged";
import { RoomDoe2Properties } from "./RoomDoe2Properties";
import { RoomEnergyPropertiesAbridged } from "./RoomEnergyPropertiesAbridged";
import { RoomGridParameter } from "./RoomGridParameter";
import { RoomPropertiesAbridged } from "./RoomPropertiesAbridged";
import { RoomRadialGridParameter } from "./RoomRadialGridParameter";
import { RoomRadiancePropertiesAbridged } from "./RoomRadiancePropertiesAbridged";
import { ScheduleDay } from "./ScheduleDay";
import { ScheduleFixedInterval } from "./ScheduleFixedInterval";
import { ScheduleFixedIntervalAbridged } from "./ScheduleFixedIntervalAbridged";
import { ScheduleRuleAbridged } from "./ScheduleRuleAbridged";
import { ScheduleRuleset } from "./ScheduleRuleset";
import { ScheduleRulesetAbridged } from "./ScheduleRulesetAbridged";
import { ScheduleTypeLimit } from "./ScheduleTypeLimit";
import { ServiceHotWater } from "./ServiceHotWater";
import { ServiceHotWaterAbridged } from "./ServiceHotWaterAbridged";
import { Setpoint } from "./Setpoint";
import { SetpointAbridged } from "./SetpointAbridged";
import { Shade } from "./Shade";
import { ShadeConstruction } from "./ShadeConstruction";
import { ShadeEnergyPropertiesAbridged } from "./ShadeEnergyPropertiesAbridged";
import { ShadeModifierSet } from "./ShadeModifierSet";
import { ShadeModifierSetAbridged } from "./ShadeModifierSetAbridged";
import { ShadePropertiesAbridged } from "./ShadePropertiesAbridged";
import { ShadeRadiancePropertiesAbridged } from "./ShadeRadiancePropertiesAbridged";
import { SHWSystem } from "./SHWSystem";
import { SimpleWindowArea } from "./SimpleWindowArea";
import { SimpleWindowRatio } from "./SimpleWindowRatio";
import { SingleWindow } from "./SingleWindow";
import { StateGeometryAbridged } from "./StateGeometryAbridged";
import { Story } from "./Story";
import { StoryEnergyPropertiesAbridged } from "./StoryEnergyPropertiesAbridged";
import { StoryPropertiesAbridged } from "./StoryPropertiesAbridged";
import { StoryRadiancePropertiesAbridged } from "./StoryRadiancePropertiesAbridged";
import { Surface } from "./Surface";
import { Trans } from "./Trans";
import { VAV } from "./VAV";
import { Ventilation } from "./Ventilation";
import { VentilationAbridged } from "./VentilationAbridged";
import { VentilationControlAbridged } from "./VentilationControlAbridged";
import { VentilationFan } from "./VentilationFan";
import { VentilationOpening } from "./VentilationOpening";
import { Void } from "./Void";
import { VRF } from "./VRF";
import { VRFwithDOASAbridged } from "./VRFwithDOASAbridged";
import { WallConstructionSet } from "./WallConstructionSet";
import { WallConstructionSetAbridged } from "./WallConstructionSetAbridged";
import { WallModifierSet } from "./WallModifierSet";
import { WallModifierSetAbridged } from "./WallModifierSetAbridged";
import { WindowAC } from "./WindowAC";
import { WindowConstruction } from "./WindowConstruction";
import { WindowConstructionAbridged } from "./WindowConstructionAbridged";
import { WindowConstructionDynamic } from "./WindowConstructionDynamic";
import { WindowConstructionShade } from "./WindowConstructionShade";
import { WindowConstructionShadeAbridged } from "./WindowConstructionShadeAbridged";
import { WSHP } from "./WSHP";
import { WSHPwithDOASAbridged } from "./WSHPwithDOASAbridged";

export abstract class _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    /** A base class to use when there is no baseclass available to fall on. */
    type?: string;
	

    constructor() {
        this.type = "InvalidType";
    }


    init(_data?: any) {
        if (_data) {
            this.type = _data["type"] !== undefined ? _data["type"] : "InvalidType";
        }
    }


    static fromJS(data: any): _OpenAPIGenBaseModel {
        data = typeof data === 'object' ? data : {};

        if (data["type"] === "InfiltrationAbridged") {
            let result = new InfiltrationAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "IDdEnergyBaseModel") {
            let result = new IDdEnergyBaseModel();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyBaseModel") {
            let result = new EnergyBaseModel();
            result.init(data);
            return result;
        }
        if (data["type"] === "ScheduleDay") {
            let result = new ScheduleDay();
            result.init(data);
            return result;
        }
        if (data["type"] === "ScheduleRuleAbridged") {
            let result = new ScheduleRuleAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "DatedBaseModel") {
            let result = new DatedBaseModel();
            result.init(data);
            return result;
        }
        if (data["type"] === "NoLimit") {
            let result = new NoLimit();
            result.init(data);
            return result;
        }
        if (data["type"] === "ScheduleTypeLimit") {
            let result = new ScheduleTypeLimit();
            result.init(data);
            return result;
        }
        if (data["type"] === "ScheduleRuleset") {
            let result = new ScheduleRuleset();
            result.init(data);
            return result;
        }
        if (data["type"] === "ScheduleFixedInterval") {
            let result = new ScheduleFixedInterval();
            result.init(data);
            return result;
        }
        if (data["type"] === "Autocalculate") {
            let result = new Autocalculate();
            result.init(data);
            return result;
        }
        if (data["type"] === "People") {
            let result = new People();
            result.init(data);
            return result;
        }
        if (data["type"] === "WallConstructionSetAbridged") {
            let result = new WallConstructionSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "_FaceSubSetAbridged") {
            let result = new _FaceSubSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ContextShadeEnergyPropertiesAbridged") {
            let result = new ContextShadeEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Void") {
            let result = new Void();
            result.init(data);
            return result;
        }
        if (data["type"] === "Mirror") {
            let result = new Mirror();
            result.init(data);
            return result;
        }
        if (data["type"] === "ModifierBase") {
            let result = new ModifierBase();
            result.init(data);
            return result;
        }
        if (data["type"] === "IDdRadianceBaseModel") {
            let result = new IDdRadianceBaseModel();
            result.init(data);
            return result;
        }
        if (data["type"] === "Plastic") {
            let result = new Plastic();
            result.init(data);
            return result;
        }
        if (data["type"] === "Glass") {
            let result = new Glass();
            result.init(data);
            return result;
        }
        if (data["type"] === "BSDF") {
            let result = new BSDF();
            result.init(data);
            return result;
        }
        if (data["type"] === "Glow") {
            let result = new Glow();
            result.init(data);
            return result;
        }
        if (data["type"] === "Light") {
            let result = new Light();
            result.init(data);
            return result;
        }
        if (data["type"] === "Trans") {
            let result = new Trans();
            result.init(data);
            return result;
        }
        if (data["type"] === "Metal") {
            let result = new Metal();
            result.init(data);
            return result;
        }
        if (data["type"] === "ShadeModifierSet") {
            let result = new ShadeModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "Plane") {
            let result = new Plane();
            result.init(data);
            return result;
        }
        if (data["type"] === "Face3D") {
            let result = new Face3D();
            result.init(data);
            return result;
        }
        if (data["type"] === "StateGeometryAbridged") {
            let result = new StateGeometryAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RadianceSubFaceStateAbridged") {
            let result = new RadianceSubFaceStateAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RadianceShadeStateAbridged") {
            let result = new RadianceShadeStateAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ApertureRadiancePropertiesAbridged") {
            let result = new ApertureRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "_PropertiesBaseAbridged") {
            let result = new _PropertiesBaseAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "PeopleAbridged") {
            let result = new PeopleAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "LightingAbridged") {
            let result = new LightingAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ElectricEquipmentAbridged") {
            let result = new ElectricEquipmentAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "_EquipmentBase") {
            let result = new _EquipmentBase();
            result.init(data);
            return result;
        }
        if (data["type"] === "GasEquipmentAbridged") {
            let result = new GasEquipmentAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ServiceHotWaterAbridged") {
            let result = new ServiceHotWaterAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "VentilationAbridged") {
            let result = new VentilationAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "SetpointAbridged") {
            let result = new SetpointAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ProgramTypeAbridged") {
            let result = new ProgramTypeAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "SHWSystem") {
            let result = new SHWSystem();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyWindowMaterialSimpleGlazSys") {
            let result = new EnergyWindowMaterialSimpleGlazSys();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyWindowMaterialGlazing") {
            let result = new EnergyWindowMaterialGlazing();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyWindowMaterialGas") {
            let result = new EnergyWindowMaterialGas();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyWindowMaterialGasCustom") {
            let result = new EnergyWindowMaterialGasCustom();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyWindowMaterialGasMixture") {
            let result = new EnergyWindowMaterialGasMixture();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyWindowFrame") {
            let result = new EnergyWindowFrame();
            result.init(data);
            return result;
        }
        if (data["type"] === "WindowConstruction") {
            let result = new WindowConstruction();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyWindowMaterialShade") {
            let result = new EnergyWindowMaterialShade();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyWindowMaterialBlind") {
            let result = new EnergyWindowMaterialBlind();
            result.init(data);
            return result;
        }
        if (data["type"] === "WindowConstructionShade") {
            let result = new WindowConstructionShade();
            result.init(data);
            return result;
        }
        if (data["type"] === "WindowConstructionDynamic") {
            let result = new WindowConstructionDynamic();
            result.init(data);
            return result;
        }
        if (data["type"] === "ApertureConstructionSet") {
            let result = new ApertureConstructionSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "DoorModifierSet") {
            let result = new DoorModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "Ground") {
            let result = new Ground();
            result.init(data);
            return result;
        }
        if (data["type"] === "Outdoors") {
            let result = new Outdoors();
            result.init(data);
            return result;
        }
        if (data["type"] === "Adiabatic") {
            let result = new Adiabatic();
            result.init(data);
            return result;
        }
        if (data["type"] === "Surface") {
            let result = new Surface();
            result.init(data);
            return result;
        }
        if (data["type"] === "OtherSideTemperature") {
            let result = new OtherSideTemperature();
            result.init(data);
            return result;
        }
        if (data["type"] === "PVProperties") {
            let result = new PVProperties();
            result.init(data);
            return result;
        }
        if (data["type"] === "ShadeEnergyPropertiesAbridged") {
            let result = new ShadeEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ShadeRadiancePropertiesAbridged") {
            let result = new ShadeRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ShadePropertiesAbridged") {
            let result = new ShadePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Shade") {
            let result = new Shade();
            result.init(data);
            return result;
        }
        if (data["type"] === "IDdBaseModel") {
            let result = new IDdBaseModel();
            result.init(data);
            return result;
        }
        if (data["type"] === "VentilationOpening") {
            let result = new VentilationOpening();
            result.init(data);
            return result;
        }
        if (data["type"] === "ApertureEnergyPropertiesAbridged") {
            let result = new ApertureEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "AperturePropertiesAbridged") {
            let result = new AperturePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Aperture") {
            let result = new Aperture();
            result.init(data);
            return result;
        }
        if (data["type"] === "DoorEnergyPropertiesAbridged") {
            let result = new DoorEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "DoorRadiancePropertiesAbridged") {
            let result = new DoorRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "DoorPropertiesAbridged") {
            let result = new DoorPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Door") {
            let result = new Door();
            result.init(data);
            return result;
        }
        if (data["type"] === "AFNCrack") {
            let result = new AFNCrack();
            result.init(data);
            return result;
        }
        if (data["type"] === "FaceEnergyPropertiesAbridged") {
            let result = new FaceEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "FaceRadiancePropertiesAbridged") {
            let result = new FaceRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "FacePropertiesAbridged") {
            let result = new FacePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Face") {
            let result = new Face();
            result.init(data);
            return result;
        }
        if (data["type"] === "DaylightingControl") {
            let result = new DaylightingControl();
            result.init(data);
            return result;
        }
        if (data["type"] === "VentilationControlAbridged") {
            let result = new VentilationControlAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "VentilationFan") {
            let result = new VentilationFan();
            result.init(data);
            return result;
        }
        if (data["type"] === "InternalMassAbridged") {
            let result = new InternalMassAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ProcessAbridged") {
            let result = new ProcessAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoomEnergyPropertiesAbridged") {
            let result = new RoomEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoomRadiancePropertiesAbridged") {
            let result = new RoomRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoomDoe2Properties") {
            let result = new RoomDoe2Properties();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoomPropertiesAbridged") {
            let result = new RoomPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Room") {
            let result = new Room();
            result.init(data);
            return result;
        }
        if (data["type"] === "FloorModifierSetAbridged") {
            let result = new FloorModifierSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "BaseModifierSetAbridged") {
            let result = new BaseModifierSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "SimpleWindowArea") {
            let result = new SimpleWindowArea();
            result.init(data);
            return result;
        }
        if (data["type"] === "_WindowParameterBase") {
            let result = new _WindowParameterBase();
            result.init(data);
            return result;
        }
        if (data["type"] === "RectangularWindows") {
            let result = new RectangularWindows();
            result.init(data);
            return result;
        }
        if (data["type"] === "Residential") {
            let result = new Residential();
            result.init(data);
            return result;
        }
        if (data["type"] === "OpaqueConstructionAbridged") {
            let result = new OpaqueConstructionAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Color") {
            let result = new Color();
            result.init(data);
            return result;
        }
        if (data["type"] === "Mesh3D") {
            let result = new Mesh3D();
            result.init(data);
            return result;
        }
        if (data["type"] === "ContextShadeRadiancePropertiesAbridged") {
            let result = new ContextShadeRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ContextShadePropertiesAbridged") {
            let result = new ContextShadePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyMaterial") {
            let result = new EnergyMaterial();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyMaterialNoMass") {
            let result = new EnergyMaterialNoMass();
            result.init(data);
            return result;
        }
        if (data["type"] === "WindowConstructionAbridged") {
            let result = new WindowConstructionAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ShadeConstruction") {
            let result = new ShadeConstruction();
            result.init(data);
            return result;
        }
        if (data["type"] === "AirBoundaryConstructionAbridged") {
            let result = new AirBoundaryConstructionAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "FloorConstructionSetAbridged") {
            let result = new FloorConstructionSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoofCeilingConstructionSetAbridged") {
            let result = new RoofCeilingConstructionSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ApertureConstructionSetAbridged") {
            let result = new ApertureConstructionSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "DoorConstructionSetAbridged") {
            let result = new DoorConstructionSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "GlobalConstructionSet") {
            let result = new GlobalConstructionSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "ConstructionSetAbridged") {
            let result = new ConstructionSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "EnergyMaterialVegetation") {
            let result = new EnergyMaterialVegetation();
            result.init(data);
            return result;
        }
        if (data["type"] === "OpaqueConstruction") {
            let result = new OpaqueConstruction();
            result.init(data);
            return result;
        }
        if (data["type"] === "WallConstructionSet") {
            let result = new WallConstructionSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "FloorConstructionSet") {
            let result = new FloorConstructionSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoofCeilingConstructionSet") {
            let result = new RoofCeilingConstructionSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "DoorConstructionSet") {
            let result = new DoorConstructionSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "AirBoundaryConstruction") {
            let result = new AirBoundaryConstruction();
            result.init(data);
            return result;
        }
        if (data["type"] === "ConstructionSet") {
            let result = new ConstructionSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "Autosize") {
            let result = new Autosize();
            result.init(data);
            return result;
        }
        if (data["type"] === "IdealAirSystemAbridged") {
            let result = new IdealAirSystemAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "VAV") {
            let result = new VAV();
            result.init(data);
            return result;
        }
        if (data["type"] === "PVAV") {
            let result = new PVAV();
            result.init(data);
            return result;
        }
        if (data["type"] === "PSZ") {
            let result = new PSZ();
            result.init(data);
            return result;
        }
        if (data["type"] === "PTAC") {
            let result = new PTAC();
            result.init(data);
            return result;
        }
        if (data["type"] === "ForcedAirFurnace") {
            let result = new ForcedAirFurnace();
            result.init(data);
            return result;
        }
        if (data["type"] === "FCUwithDOASAbridged") {
            let result = new FCUwithDOASAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "WSHPwithDOASAbridged") {
            let result = new WSHPwithDOASAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "VRFwithDOASAbridged") {
            let result = new VRFwithDOASAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RadiantwithDOASAbridged") {
            let result = new RadiantwithDOASAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "FCU") {
            let result = new FCU();
            result.init(data);
            return result;
        }
        if (data["type"] === "WSHP") {
            let result = new WSHP();
            result.init(data);
            return result;
        }
        if (data["type"] === "VRF") {
            let result = new VRF();
            result.init(data);
            return result;
        }
        if (data["type"] === "Baseboard") {
            let result = new Baseboard();
            result.init(data);
            return result;
        }
        if (data["type"] === "EvaporativeCooler") {
            let result = new EvaporativeCooler();
            result.init(data);
            return result;
        }
        if (data["type"] === "WindowAC") {
            let result = new WindowAC();
            result.init(data);
            return result;
        }
        if (data["type"] === "GasUnitHeater") {
            let result = new GasUnitHeater();
            result.init(data);
            return result;
        }
        if (data["type"] === "Radiant") {
            let result = new Radiant();
            result.init(data);
            return result;
        }
        if (data["type"] === "DetailedHVAC") {
            let result = new DetailedHVAC();
            result.init(data);
            return result;
        }
        if (data["type"] === "Lighting") {
            let result = new Lighting();
            result.init(data);
            return result;
        }
        if (data["type"] === "ElectricEquipment") {
            let result = new ElectricEquipment();
            result.init(data);
            return result;
        }
        if (data["type"] === "GasEquipment") {
            let result = new GasEquipment();
            result.init(data);
            return result;
        }
        if (data["type"] === "ServiceHotWater") {
            let result = new ServiceHotWater();
            result.init(data);
            return result;
        }
        if (data["type"] === "Infiltration") {
            let result = new Infiltration();
            result.init(data);
            return result;
        }
        if (data["type"] === "Ventilation") {
            let result = new Ventilation();
            result.init(data);
            return result;
        }
        if (data["type"] === "Setpoint") {
            let result = new Setpoint();
            result.init(data);
            return result;
        }
        if (data["type"] === "ProgramType") {
            let result = new ProgramType();
            result.init(data);
            return result;
        }
        if (data["type"] === "ScheduleRulesetAbridged") {
            let result = new ScheduleRulesetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ScheduleFixedIntervalAbridged") {
            let result = new ScheduleFixedIntervalAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ModelEnergyProperties") {
            let result = new ModelEnergyProperties();
            result.init(data);
            return result;
        }
        if (data["type"] === "WallModifierSetAbridged") {
            let result = new WallModifierSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoofCeilingModifierSetAbridged") {
            let result = new RoofCeilingModifierSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ApertureModifierSetAbridged") {
            let result = new ApertureModifierSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "DoorModifierSetAbridged") {
            let result = new DoorModifierSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ShadeModifierSetAbridged") {
            let result = new ShadeModifierSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "GlobalModifierSet") {
            let result = new GlobalModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "WallModifierSet") {
            let result = new WallModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "FloorModifierSet") {
            let result = new FloorModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoofCeilingModifierSet") {
            let result = new RoofCeilingModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "ApertureModifierSet") {
            let result = new ApertureModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "ModifierSet") {
            let result = new ModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "ModifierSetAbridged") {
            let result = new ModifierSetAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "ModelRadianceProperties") {
            let result = new ModelRadianceProperties();
            result.init(data);
            return result;
        }
        if (data["type"] === "ModelProperties") {
            let result = new ModelProperties();
            result.init(data);
            return result;
        }
        if (data["type"] === "StoryEnergyPropertiesAbridged") {
            let result = new StoryEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "StoryRadiancePropertiesAbridged") {
            let result = new StoryRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Room2DEnergyPropertiesAbridged") {
            let result = new Room2DEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoomGridParameter") {
            let result = new RoomGridParameter();
            result.init(data);
            return result;
        }
        if (data["type"] === "_GridParameterBase") {
            let result = new _GridParameterBase();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoomRadialGridParameter") {
            let result = new RoomRadialGridParameter();
            result.init(data);
            return result;
        }
        if (data["type"] === "ExteriorFaceGridParameter") {
            let result = new ExteriorFaceGridParameter();
            result.init(data);
            return result;
        }
        if (data["type"] === "ExteriorApertureGridParameter") {
            let result = new ExteriorApertureGridParameter();
            result.init(data);
            return result;
        }
        if (data["type"] === "Room2DRadiancePropertiesAbridged") {
            let result = new Room2DRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Room2DPropertiesAbridged") {
            let result = new Room2DPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "SingleWindow") {
            let result = new SingleWindow();
            result.init(data);
            return result;
        }
        if (data["type"] === "BuildingEnergyPropertiesAbridged") {
            let result = new BuildingEnergyPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "BuildingRadiancePropertiesAbridged") {
            let result = new BuildingRadiancePropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "BuildingPropertiesAbridged") {
            let result = new BuildingPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "DetailedSkylights") {
            let result = new DetailedSkylights();
            result.init(data);
            return result;
        }
        if (data["type"] === "ContextShade") {
            let result = new ContextShade();
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
        if (data["type"] === "ExtrudedBorder") {
            let result = new ExtrudedBorder();
            result.init(data);
            return result;
        }
        if (data["type"] === "Overhang") {
            let result = new Overhang();
            result.init(data);
            return result;
        }
        if (data["type"] === "LouversByDistance") {
            let result = new LouversByDistance();
            result.init(data);
            return result;
        }
        if (data["type"] === "_LouversBase") {
            let result = new _LouversBase();
            result.init(data);
            return result;
        }
        if (data["type"] === "LouversByCount") {
            let result = new LouversByCount();
            result.init(data);
            return result;
        }
        if (data["type"] === "GriddedSkylightArea") {
            let result = new GriddedSkylightArea();
            result.init(data);
            return result;
        }
        if (data["type"] === "GriddedSkylightRatio") {
            let result = new GriddedSkylightRatio();
            result.init(data);
            return result;
        }
        if (data["type"] === "Room2D") {
            let result = new Room2D();
            result.init(data);
            return result;
        }
        if (data["type"] === "RoofSpecification") {
            let result = new RoofSpecification();
            result.init(data);
            return result;
        }
        if (data["type"] === "StoryPropertiesAbridged") {
            let result = new StoryPropertiesAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "Story") {
            let result = new Story();
            result.init(data);
            return result;
        }
        if (data["type"] === "Building") {
            let result = new Building();
            result.init(data);
            return result;
        }
        if (data["type"] === "Model") {
            let result = new Model();
            result.init(data);
            return result;
        }
        if (data["type"] === "BaseModifierSet") {
            let result = new BaseModifierSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "WindowConstructionShadeAbridged") {
            let result = new WindowConstructionShadeAbridged();
            result.init(data);
            return result;
        }
        if (data["type"] === "_HeatCoolBase") {
            let result = new _HeatCoolBase();
            result.init(data);
            return result;
        }
        if (data["type"] === "_TemplateSystem") {
            let result = new _TemplateSystem();
            result.init(data);
            return result;
        }
        if (data["type"] === "_DOASBase") {
            let result = new _DOASBase();
            result.init(data);
            return result;
        }
        if (data["type"] === "_FaceSubSet") {
            let result = new _FaceSubSet();
            result.init(data);
            return result;
        }
        if (data["type"] === "_AllAirBase") {
            let result = new _AllAirBase();
            result.init(data);
            return result;
        }
        throw new Error("The abstract class '_OpenAPIGenBaseModel' cannot be instantiated.");
    }

	toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["type"] = this.type;
        return data;
    }

}
