import { IsString, IsOptional, Equals, IsInstance, ValidateNested, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { AirBoundaryConstruction } from "honeybee-schema";
import { AirBoundaryConstructionAbridged } from "honeybee-schema";
import { Baseboard } from "honeybee-schema";
import { ConstructionSet } from "honeybee-schema";
import { ConstructionSetAbridged } from "honeybee-schema";
import { DetailedHVAC } from "honeybee-schema";
import { EnergyMaterial } from "honeybee-schema";
import { EnergyMaterialNoMass } from "honeybee-schema";
import { EnergyMaterialVegetation } from "honeybee-schema";
import { EnergyWindowFrame } from "honeybee-schema";
import { EnergyWindowMaterialBlind } from "honeybee-schema";
import { EnergyWindowMaterialGas } from "honeybee-schema";
import { EnergyWindowMaterialGasCustom } from "honeybee-schema";
import { EnergyWindowMaterialGasMixture } from "honeybee-schema";
import { EnergyWindowMaterialGlazing } from "honeybee-schema";
import { EnergyWindowMaterialShade } from "honeybee-schema";
import { EnergyWindowMaterialSimpleGlazSys } from "honeybee-schema";
import { EvaporativeCooler } from "honeybee-schema";
import { FCU } from "honeybee-schema";
import { FCUwithDOASAbridged } from "honeybee-schema";
import { ForcedAirFurnace } from "honeybee-schema";
import { GasUnitHeater } from "honeybee-schema";
import { GlobalConstructionSet } from "honeybee-schema";
import { IdealAirSystemAbridged } from "honeybee-schema";
import { OpaqueConstruction } from "honeybee-schema";
import { OpaqueConstructionAbridged } from "honeybee-schema";
import { ProgramType } from "honeybee-schema";
import { ProgramTypeAbridged } from "honeybee-schema";
import { PSZ } from "honeybee-schema";
import { PTAC } from "honeybee-schema";
import { PVAV } from "honeybee-schema";
import { Radiant } from "honeybee-schema";
import { RadiantwithDOASAbridged } from "honeybee-schema";
import { Residential } from "honeybee-schema";
import { ScheduleFixedInterval } from "honeybee-schema";
import { ScheduleFixedIntervalAbridged } from "honeybee-schema";
import { ScheduleRuleset } from "honeybee-schema";
import { ScheduleRulesetAbridged } from "honeybee-schema";
import { ScheduleTypeLimit } from "honeybee-schema";
import { ShadeConstruction } from "honeybee-schema";
import { SHWSystem } from "honeybee-schema";
import { VAV } from "honeybee-schema";
import { VRF } from "honeybee-schema";
import { VRFwithDOASAbridged } from "honeybee-schema";
import { WindowAC } from "honeybee-schema";
import { WindowConstruction } from "honeybee-schema";
import { WindowConstructionAbridged } from "honeybee-schema";
import { WSHP } from "honeybee-schema";
import { WSHPwithDOASAbridged } from "honeybee-schema";

export class ModelEnergyProperties extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Equals("ModelEnergyProperties")
    @Expose({ name: "type" })
    /** type */
    type: string = "ModelEnergyProperties";
	
    @Type(() => GlobalConstructionSet)
    @IsInstance(GlobalConstructionSet)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "global_construction_set" })
    /** Global Energy construction set. */
    globalConstructionSet: GlobalConstructionSet = GlobalConstructionSet.fromJS({
  "type": "GlobalConstructionSet",
  "materials": [
    {
      "conductivity": 0.16,
      "density": 1120.0,
      "display_name": null,
      "identifier": "Generic Roof Membrane",
      "roughness": "MediumRough",
      "solar_absorptance": 0.65,
      "specific_heat": 1460.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.01,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.65
    },
    {
      "conductivity": 0.06,
      "density": 368.0,
      "display_name": null,
      "identifier": "Generic Acoustic Tile",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.2,
      "specific_heat": 590.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.02,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.2
    },
    {
      "conductivity": 0.15,
      "density": 608.0,
      "display_name": null,
      "identifier": "Generic 25mm Wood",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.5,
      "specific_heat": 1630.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0254,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 1.95,
      "density": 2240.0,
      "display_name": null,
      "identifier": "Generic HW Concrete",
      "roughness": "MediumRough",
      "solar_absorptance": 0.8,
      "specific_heat": 900.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.2,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.8
    },
    {
      "display_name": null,
      "gas_type": "Air",
      "identifier": "Generic Window Air Gap",
      "thickness": 0.0127,
      "type": "EnergyWindowMaterialGas",
      "user_data": null
    },
    {
      "conductivity": 0.16,
      "density": 800.0,
      "display_name": null,
      "identifier": "Generic Gypsum Board",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.5,
      "specific_heat": 1090.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0127,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 0.667,
      "density": 1.28,
      "display_name": null,
      "identifier": "Generic Wall Air Gap",
      "roughness": "Smooth",
      "solar_absorptance": 0.7,
      "specific_heat": 1000.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 0.556,
      "density": 1.28,
      "display_name": null,
      "identifier": "Generic Ceiling Air Gap",
      "roughness": "Smooth",
      "solar_absorptance": 0.7,
      "specific_heat": 1000.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 0.9,
      "density": 1920.0,
      "display_name": null,
      "identifier": "Generic Brick",
      "roughness": "MediumRough",
      "solar_absorptance": 0.65,
      "specific_heat": 790.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.65
    },
    {
      "conductivity": 0.03,
      "density": 43.0,
      "display_name": null,
      "identifier": "Generic 50mm Insulation",
      "roughness": "MediumRough",
      "solar_absorptance": 0.7,
      "specific_heat": 1210.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.05,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 1.0,
      "dirt_correction": 1.0,
      "display_name": null,
      "emissivity": 0.84,
      "emissivity_back": 0.047,
      "identifier": "Generic Low-e Glass",
      "infrared_transmittance": 0.0,
      "solar_diffusing": false,
      "solar_reflectance": 0.36,
      "solar_reflectance_back": 0.36,
      "solar_transmittance": 0.45,
      "thickness": 0.006,
      "type": "EnergyWindowMaterialGlazing",
      "user_data": null,
      "visible_reflectance": 0.21,
      "visible_reflectance_back": 0.21,
      "visible_transmittance": 0.71
    },
    {
      "conductivity": 45.0,
      "density": 7690.0,
      "display_name": null,
      "identifier": "Generic Painted Metal",
      "roughness": "Smooth",
      "solar_absorptance": 0.5,
      "specific_heat": 410.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0015,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 0.53,
      "density": 1280.0,
      "display_name": null,
      "identifier": "Generic LW Concrete",
      "roughness": "MediumRough",
      "solar_absorptance": 0.8,
      "specific_heat": 840.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.8
    },
    {
      "conductivity": 0.03,
      "density": 43.0,
      "display_name": null,
      "identifier": "Generic 25mm Insulation",
      "roughness": "MediumRough",
      "solar_absorptance": 0.7,
      "specific_heat": 1210.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.025,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 1.0,
      "dirt_correction": 1.0,
      "display_name": null,
      "emissivity": 0.84,
      "emissivity_back": 0.84,
      "identifier": "Generic Clear Glass",
      "infrared_transmittance": 0.0,
      "solar_diffusing": false,
      "solar_reflectance": 0.07,
      "solar_reflectance_back": 0.07,
      "solar_transmittance": 0.77,
      "thickness": 0.006,
      "type": "EnergyWindowMaterialGlazing",
      "user_data": null,
      "visible_reflectance": 0.08,
      "visible_reflectance_back": 0.08,
      "visible_transmittance": 0.88
    }
  ],
  "constructions": [
    {
      "display_name": null,
      "identifier": "Generic Interior Door",
      "materials": [
        "Generic 25mm Wood"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "frame": null,
      "identifier": "Generic Single Pane",
      "materials": [
        "Generic Clear Glass"
      ],
      "type": "WindowConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Shade",
      "is_specular": false,
      "solar_reflectance": 0.35,
      "type": "ShadeConstruction",
      "user_data": null,
      "visible_reflectance": 0.35
    },
    {
      "display_name": null,
      "identifier": "Generic Context",
      "is_specular": false,
      "solar_reflectance": 0.2,
      "type": "ShadeConstruction",
      "user_data": null,
      "visible_reflectance": 0.2
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Ceiling",
      "materials": [
        "Generic LW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Wall",
      "materials": [
        "Generic Gypsum Board",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exposed Floor",
      "materials": [
        "Generic Painted Metal",
        "Generic Ceiling Air Gap",
        "Generic 50mm Insulation",
        "Generic LW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Floor",
      "materials": [
        "Generic Acoustic Tile",
        "Generic Ceiling Air Gap",
        "Generic LW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Ground Slab",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Roof",
      "materials": [
        "Generic Roof Membrane",
        "Generic 50mm Insulation",
        "Generic LW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exterior Wall",
      "materials": [
        "Generic Brick",
        "Generic LW Concrete",
        "Generic 50mm Insulation",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Underground Wall",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "air_mixing_per_area": 0.1,
      "air_mixing_schedule": "Always On",
      "display_name": null,
      "identifier": "Generic Air Boundary",
      "type": "AirBoundaryConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Underground Roof",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "frame": null,
      "identifier": "Generic Double Pane",
      "materials": [
        "Generic Low-e Glass",
        "Generic Window Air Gap",
        "Generic Clear Glass"
      ],
      "type": "WindowConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exterior Door",
      "materials": [
        "Generic Painted Metal",
        "Generic 25mm Insulation",
        "Generic Painted Metal"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    }
  ],
  "wall_set": {
    "exterior_construction": "Generic Exterior Wall",
    "ground_construction": "Generic Underground Wall",
    "interior_construction": "Generic Interior Wall",
    "type": "WallConstructionSetAbridged"
  },
  "floor_set": {
    "exterior_construction": "Generic Exposed Floor",
    "ground_construction": "Generic Ground Slab",
    "interior_construction": "Generic Interior Floor",
    "type": "FloorConstructionSetAbridged"
  },
  "roof_ceiling_set": {
    "exterior_construction": "Generic Roof",
    "ground_construction": "Generic Underground Roof",
    "interior_construction": "Generic Interior Ceiling",
    "type": "RoofCeilingConstructionSetAbridged"
  },
  "aperture_set": {
    "interior_construction": "Generic Single Pane",
    "operable_construction": "Generic Double Pane",
    "skylight_construction": "Generic Double Pane",
    "type": "ApertureConstructionSetAbridged",
    "window_construction": "Generic Double Pane"
  },
  "door_set": {
    "exterior_construction": "Generic Exterior Door",
    "exterior_glass_construction": "Generic Double Pane",
    "interior_construction": "Generic Interior Door",
    "interior_glass_construction": "Generic Single Pane",
    "overhead_construction": "Generic Exterior Door",
    "type": "DoorConstructionSetAbridged"
  },
  "shade_construction": "Generic Shade",
  "context_construction": "Generic Context",
  "air_boundary_construction": "Generic Air Boundary"
});
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "construction_sets" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'ConstructionSetAbridged') return ConstructionSetAbridged.fromJS(item);
      else if (item?.type === 'ConstructionSet') return ConstructionSet.fromJS(item);
      else return item;
    }))
    /** List of all ConstructionSets in the Model. */
    constructionSets?: (ConstructionSetAbridged | ConstructionSet)[];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "constructions" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'OpaqueConstructionAbridged') return OpaqueConstructionAbridged.fromJS(item);
      else if (item?.type === 'WindowConstructionAbridged') return WindowConstructionAbridged.fromJS(item);
      else if (item?.type === 'ShadeConstruction') return ShadeConstruction.fromJS(item);
      else if (item?.type === 'AirBoundaryConstructionAbridged') return AirBoundaryConstructionAbridged.fromJS(item);
      else if (item?.type === 'OpaqueConstruction') return OpaqueConstruction.fromJS(item);
      else if (item?.type === 'WindowConstruction') return WindowConstruction.fromJS(item);
      else if (item?.type === 'AirBoundaryConstruction') return AirBoundaryConstruction.fromJS(item);
      else return item;
    }))
    /** A list of all unique constructions in the model. This includes constructions across all the Model construction_sets. */
    constructions?: (OpaqueConstructionAbridged | WindowConstructionAbridged | ShadeConstruction | AirBoundaryConstructionAbridged | OpaqueConstruction | WindowConstruction | AirBoundaryConstruction)[];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "materials" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'EnergyMaterial') return EnergyMaterial.fromJS(item);
      else if (item?.type === 'EnergyMaterialNoMass') return EnergyMaterialNoMass.fromJS(item);
      else if (item?.type === 'EnergyMaterialVegetation') return EnergyMaterialVegetation.fromJS(item);
      else if (item?.type === 'EnergyWindowMaterialGas') return EnergyWindowMaterialGas.fromJS(item);
      else if (item?.type === 'EnergyWindowMaterialGasCustom') return EnergyWindowMaterialGasCustom.fromJS(item);
      else if (item?.type === 'EnergyWindowMaterialGasMixture') return EnergyWindowMaterialGasMixture.fromJS(item);
      else if (item?.type === 'EnergyWindowFrame') return EnergyWindowFrame.fromJS(item);
      else if (item?.type === 'EnergyWindowMaterialSimpleGlazSys') return EnergyWindowMaterialSimpleGlazSys.fromJS(item);
      else if (item?.type === 'EnergyWindowMaterialGlazing') return EnergyWindowMaterialGlazing.fromJS(item);
      else if (item?.type === 'EnergyWindowMaterialBlind') return EnergyWindowMaterialBlind.fromJS(item);
      else if (item?.type === 'EnergyWindowMaterialShade') return EnergyWindowMaterialShade.fromJS(item);
      else return item;
    }))
    /** A list of all unique materials in the model. This includes materials needed to make the Model constructions. */
    materials?: (EnergyMaterial | EnergyMaterialNoMass | EnergyMaterialVegetation | EnergyWindowMaterialGas | EnergyWindowMaterialGasCustom | EnergyWindowMaterialGasMixture | EnergyWindowFrame | EnergyWindowMaterialSimpleGlazSys | EnergyWindowMaterialGlazing | EnergyWindowMaterialBlind | EnergyWindowMaterialShade)[];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "hvacs" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'IdealAirSystemAbridged') return IdealAirSystemAbridged.fromJS(item);
      else if (item?.type === 'VAV') return VAV.fromJS(item);
      else if (item?.type === 'PVAV') return PVAV.fromJS(item);
      else if (item?.type === 'PSZ') return PSZ.fromJS(item);
      else if (item?.type === 'PTAC') return PTAC.fromJS(item);
      else if (item?.type === 'ForcedAirFurnace') return ForcedAirFurnace.fromJS(item);
      else if (item?.type === 'FCUwithDOASAbridged') return FCUwithDOASAbridged.fromJS(item);
      else if (item?.type === 'WSHPwithDOASAbridged') return WSHPwithDOASAbridged.fromJS(item);
      else if (item?.type === 'VRFwithDOASAbridged') return VRFwithDOASAbridged.fromJS(item);
      else if (item?.type === 'RadiantwithDOASAbridged') return RadiantwithDOASAbridged.fromJS(item);
      else if (item?.type === 'FCU') return FCU.fromJS(item);
      else if (item?.type === 'WSHP') return WSHP.fromJS(item);
      else if (item?.type === 'VRF') return VRF.fromJS(item);
      else if (item?.type === 'Baseboard') return Baseboard.fromJS(item);
      else if (item?.type === 'EvaporativeCooler') return EvaporativeCooler.fromJS(item);
      else if (item?.type === 'Residential') return Residential.fromJS(item);
      else if (item?.type === 'WindowAC') return WindowAC.fromJS(item);
      else if (item?.type === 'GasUnitHeater') return GasUnitHeater.fromJS(item);
      else if (item?.type === 'Radiant') return Radiant.fromJS(item);
      else if (item?.type === 'DetailedHVAC') return DetailedHVAC.fromJS(item);
      else return item;
    }))
    /** List of all HVAC systems in the Model. */
    hvacs?: (IdealAirSystemAbridged | VAV | PVAV | PSZ | PTAC | ForcedAirFurnace | FCUwithDOASAbridged | WSHPwithDOASAbridged | VRFwithDOASAbridged | RadiantwithDOASAbridged | FCU | WSHP | VRF | Baseboard | EvaporativeCooler | Residential | WindowAC | GasUnitHeater | Radiant | DetailedHVAC)[];
	
    @IsArray()
    @Type(() => SHWSystem)
    @IsInstance(SHWSystem, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "shws" })
    /** List of all Service Hot Water (SHW) systems in the Model. */
    shws?: SHWSystem[];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "program_types" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'ProgramTypeAbridged') return ProgramTypeAbridged.fromJS(item);
      else if (item?.type === 'ProgramType') return ProgramType.fromJS(item);
      else return item;
    }))
    /** List of all ProgramTypes in the Model. */
    programTypes?: (ProgramTypeAbridged | ProgramType)[];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "schedules" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'ScheduleRulesetAbridged') return ScheduleRulesetAbridged.fromJS(item);
      else if (item?.type === 'ScheduleFixedIntervalAbridged') return ScheduleFixedIntervalAbridged.fromJS(item);
      else if (item?.type === 'ScheduleRuleset') return ScheduleRuleset.fromJS(item);
      else if (item?.type === 'ScheduleFixedInterval') return ScheduleFixedInterval.fromJS(item);
      else return item;
    }))
    /** A list of all unique schedules in the model. This includes schedules across all HVAC systems, ProgramTypes and ContextShades. */
    schedules?: (ScheduleRulesetAbridged | ScheduleFixedIntervalAbridged | ScheduleRuleset | ScheduleFixedInterval)[];
	
    @IsArray()
    @Type(() => ScheduleTypeLimit)
    @IsInstance(ScheduleTypeLimit, { each: true })
    @ValidateNested({ each: true })
    @IsOptional()
    @Expose({ name: "schedule_type_limits" })
    /** A list of all unique ScheduleTypeLimits in the model. This all ScheduleTypeLimits needed to make the Model schedules. */
    scheduleTypeLimits?: ScheduleTypeLimit[];
	

    constructor() {
        super();
        this.type = "ModelEnergyProperties";
        this.globalConstructionSet = GlobalConstructionSet.fromJS({
  "type": "GlobalConstructionSet",
  "materials": [
    {
      "conductivity": 0.16,
      "density": 1120.0,
      "display_name": null,
      "identifier": "Generic Roof Membrane",
      "roughness": "MediumRough",
      "solar_absorptance": 0.65,
      "specific_heat": 1460.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.01,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.65
    },
    {
      "conductivity": 0.06,
      "density": 368.0,
      "display_name": null,
      "identifier": "Generic Acoustic Tile",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.2,
      "specific_heat": 590.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.02,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.2
    },
    {
      "conductivity": 0.15,
      "density": 608.0,
      "display_name": null,
      "identifier": "Generic 25mm Wood",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.5,
      "specific_heat": 1630.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0254,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 1.95,
      "density": 2240.0,
      "display_name": null,
      "identifier": "Generic HW Concrete",
      "roughness": "MediumRough",
      "solar_absorptance": 0.8,
      "specific_heat": 900.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.2,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.8
    },
    {
      "display_name": null,
      "gas_type": "Air",
      "identifier": "Generic Window Air Gap",
      "thickness": 0.0127,
      "type": "EnergyWindowMaterialGas",
      "user_data": null
    },
    {
      "conductivity": 0.16,
      "density": 800.0,
      "display_name": null,
      "identifier": "Generic Gypsum Board",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.5,
      "specific_heat": 1090.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0127,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 0.667,
      "density": 1.28,
      "display_name": null,
      "identifier": "Generic Wall Air Gap",
      "roughness": "Smooth",
      "solar_absorptance": 0.7,
      "specific_heat": 1000.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 0.556,
      "density": 1.28,
      "display_name": null,
      "identifier": "Generic Ceiling Air Gap",
      "roughness": "Smooth",
      "solar_absorptance": 0.7,
      "specific_heat": 1000.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 0.9,
      "density": 1920.0,
      "display_name": null,
      "identifier": "Generic Brick",
      "roughness": "MediumRough",
      "solar_absorptance": 0.65,
      "specific_heat": 790.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.65
    },
    {
      "conductivity": 0.03,
      "density": 43.0,
      "display_name": null,
      "identifier": "Generic 50mm Insulation",
      "roughness": "MediumRough",
      "solar_absorptance": 0.7,
      "specific_heat": 1210.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.05,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 1.0,
      "dirt_correction": 1.0,
      "display_name": null,
      "emissivity": 0.84,
      "emissivity_back": 0.047,
      "identifier": "Generic Low-e Glass",
      "infrared_transmittance": 0.0,
      "solar_diffusing": false,
      "solar_reflectance": 0.36,
      "solar_reflectance_back": 0.36,
      "solar_transmittance": 0.45,
      "thickness": 0.006,
      "type": "EnergyWindowMaterialGlazing",
      "user_data": null,
      "visible_reflectance": 0.21,
      "visible_reflectance_back": 0.21,
      "visible_transmittance": 0.71
    },
    {
      "conductivity": 45.0,
      "density": 7690.0,
      "display_name": null,
      "identifier": "Generic Painted Metal",
      "roughness": "Smooth",
      "solar_absorptance": 0.5,
      "specific_heat": 410.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0015,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 0.53,
      "density": 1280.0,
      "display_name": null,
      "identifier": "Generic LW Concrete",
      "roughness": "MediumRough",
      "solar_absorptance": 0.8,
      "specific_heat": 840.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.8
    },
    {
      "conductivity": 0.03,
      "density": 43.0,
      "display_name": null,
      "identifier": "Generic 25mm Insulation",
      "roughness": "MediumRough",
      "solar_absorptance": 0.7,
      "specific_heat": 1210.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.025,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 1.0,
      "dirt_correction": 1.0,
      "display_name": null,
      "emissivity": 0.84,
      "emissivity_back": 0.84,
      "identifier": "Generic Clear Glass",
      "infrared_transmittance": 0.0,
      "solar_diffusing": false,
      "solar_reflectance": 0.07,
      "solar_reflectance_back": 0.07,
      "solar_transmittance": 0.77,
      "thickness": 0.006,
      "type": "EnergyWindowMaterialGlazing",
      "user_data": null,
      "visible_reflectance": 0.08,
      "visible_reflectance_back": 0.08,
      "visible_transmittance": 0.88
    }
  ],
  "constructions": [
    {
      "display_name": null,
      "identifier": "Generic Interior Door",
      "materials": [
        "Generic 25mm Wood"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "frame": null,
      "identifier": "Generic Single Pane",
      "materials": [
        "Generic Clear Glass"
      ],
      "type": "WindowConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Shade",
      "is_specular": false,
      "solar_reflectance": 0.35,
      "type": "ShadeConstruction",
      "user_data": null,
      "visible_reflectance": 0.35
    },
    {
      "display_name": null,
      "identifier": "Generic Context",
      "is_specular": false,
      "solar_reflectance": 0.2,
      "type": "ShadeConstruction",
      "user_data": null,
      "visible_reflectance": 0.2
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Ceiling",
      "materials": [
        "Generic LW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Wall",
      "materials": [
        "Generic Gypsum Board",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exposed Floor",
      "materials": [
        "Generic Painted Metal",
        "Generic Ceiling Air Gap",
        "Generic 50mm Insulation",
        "Generic LW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Floor",
      "materials": [
        "Generic Acoustic Tile",
        "Generic Ceiling Air Gap",
        "Generic LW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Ground Slab",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Roof",
      "materials": [
        "Generic Roof Membrane",
        "Generic 50mm Insulation",
        "Generic LW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exterior Wall",
      "materials": [
        "Generic Brick",
        "Generic LW Concrete",
        "Generic 50mm Insulation",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Underground Wall",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "air_mixing_per_area": 0.1,
      "air_mixing_schedule": "Always On",
      "display_name": null,
      "identifier": "Generic Air Boundary",
      "type": "AirBoundaryConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Underground Roof",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "frame": null,
      "identifier": "Generic Double Pane",
      "materials": [
        "Generic Low-e Glass",
        "Generic Window Air Gap",
        "Generic Clear Glass"
      ],
      "type": "WindowConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exterior Door",
      "materials": [
        "Generic Painted Metal",
        "Generic 25mm Insulation",
        "Generic Painted Metal"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    }
  ],
  "wall_set": {
    "exterior_construction": "Generic Exterior Wall",
    "ground_construction": "Generic Underground Wall",
    "interior_construction": "Generic Interior Wall",
    "type": "WallConstructionSetAbridged"
  },
  "floor_set": {
    "exterior_construction": "Generic Exposed Floor",
    "ground_construction": "Generic Ground Slab",
    "interior_construction": "Generic Interior Floor",
    "type": "FloorConstructionSetAbridged"
  },
  "roof_ceiling_set": {
    "exterior_construction": "Generic Roof",
    "ground_construction": "Generic Underground Roof",
    "interior_construction": "Generic Interior Ceiling",
    "type": "RoofCeilingConstructionSetAbridged"
  },
  "aperture_set": {
    "interior_construction": "Generic Single Pane",
    "operable_construction": "Generic Double Pane",
    "skylight_construction": "Generic Double Pane",
    "type": "ApertureConstructionSetAbridged",
    "window_construction": "Generic Double Pane"
  },
  "door_set": {
    "exterior_construction": "Generic Exterior Door",
    "exterior_glass_construction": "Generic Double Pane",
    "interior_construction": "Generic Interior Door",
    "interior_glass_construction": "Generic Single Pane",
    "overhead_construction": "Generic Exterior Door",
    "type": "DoorConstructionSetAbridged"
  },
  "shade_construction": "Generic Shade",
  "context_construction": "Generic Context",
  "air_boundary_construction": "Generic Air Boundary"
});
    }


    override init(_data?: any) {

        if (_data) {
            const obj = deepTransform(ModelEnergyProperties, _data);
            this.type = obj.type ?? "ModelEnergyProperties";
            this.globalConstructionSet = obj.globalConstructionSet ?? GlobalConstructionSet.fromJS({
  "type": "GlobalConstructionSet",
  "materials": [
    {
      "conductivity": 0.16,
      "density": 1120.0,
      "display_name": null,
      "identifier": "Generic Roof Membrane",
      "roughness": "MediumRough",
      "solar_absorptance": 0.65,
      "specific_heat": 1460.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.01,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.65
    },
    {
      "conductivity": 0.06,
      "density": 368.0,
      "display_name": null,
      "identifier": "Generic Acoustic Tile",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.2,
      "specific_heat": 590.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.02,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.2
    },
    {
      "conductivity": 0.15,
      "density": 608.0,
      "display_name": null,
      "identifier": "Generic 25mm Wood",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.5,
      "specific_heat": 1630.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0254,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 1.95,
      "density": 2240.0,
      "display_name": null,
      "identifier": "Generic HW Concrete",
      "roughness": "MediumRough",
      "solar_absorptance": 0.8,
      "specific_heat": 900.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.2,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.8
    },
    {
      "display_name": null,
      "gas_type": "Air",
      "identifier": "Generic Window Air Gap",
      "thickness": 0.0127,
      "type": "EnergyWindowMaterialGas",
      "user_data": null
    },
    {
      "conductivity": 0.16,
      "density": 800.0,
      "display_name": null,
      "identifier": "Generic Gypsum Board",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.5,
      "specific_heat": 1090.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0127,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 0.667,
      "density": 1.28,
      "display_name": null,
      "identifier": "Generic Wall Air Gap",
      "roughness": "Smooth",
      "solar_absorptance": 0.7,
      "specific_heat": 1000.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 0.556,
      "density": 1.28,
      "display_name": null,
      "identifier": "Generic Ceiling Air Gap",
      "roughness": "Smooth",
      "solar_absorptance": 0.7,
      "specific_heat": 1000.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 0.9,
      "density": 1920.0,
      "display_name": null,
      "identifier": "Generic Brick",
      "roughness": "MediumRough",
      "solar_absorptance": 0.65,
      "specific_heat": 790.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.65
    },
    {
      "conductivity": 0.03,
      "density": 43.0,
      "display_name": null,
      "identifier": "Generic 50mm Insulation",
      "roughness": "MediumRough",
      "solar_absorptance": 0.7,
      "specific_heat": 1210.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.05,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 1.0,
      "dirt_correction": 1.0,
      "display_name": null,
      "emissivity": 0.84,
      "emissivity_back": 0.047,
      "identifier": "Generic Low-e Glass",
      "infrared_transmittance": 0.0,
      "solar_diffusing": false,
      "solar_reflectance": 0.36,
      "solar_reflectance_back": 0.36,
      "solar_transmittance": 0.45,
      "thickness": 0.006,
      "type": "EnergyWindowMaterialGlazing",
      "user_data": null,
      "visible_reflectance": 0.21,
      "visible_reflectance_back": 0.21,
      "visible_transmittance": 0.71
    },
    {
      "conductivity": 45.0,
      "density": 7690.0,
      "display_name": null,
      "identifier": "Generic Painted Metal",
      "roughness": "Smooth",
      "solar_absorptance": 0.5,
      "specific_heat": 410.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0015,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 0.53,
      "density": 1280.0,
      "display_name": null,
      "identifier": "Generic LW Concrete",
      "roughness": "MediumRough",
      "solar_absorptance": 0.8,
      "specific_heat": 840.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.8
    },
    {
      "conductivity": 0.03,
      "density": 43.0,
      "display_name": null,
      "identifier": "Generic 25mm Insulation",
      "roughness": "MediumRough",
      "solar_absorptance": 0.7,
      "specific_heat": 1210.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.025,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 1.0,
      "dirt_correction": 1.0,
      "display_name": null,
      "emissivity": 0.84,
      "emissivity_back": 0.84,
      "identifier": "Generic Clear Glass",
      "infrared_transmittance": 0.0,
      "solar_diffusing": false,
      "solar_reflectance": 0.07,
      "solar_reflectance_back": 0.07,
      "solar_transmittance": 0.77,
      "thickness": 0.006,
      "type": "EnergyWindowMaterialGlazing",
      "user_data": null,
      "visible_reflectance": 0.08,
      "visible_reflectance_back": 0.08,
      "visible_transmittance": 0.88
    }
  ],
  "constructions": [
    {
      "display_name": null,
      "identifier": "Generic Interior Door",
      "materials": [
        "Generic 25mm Wood"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "frame": null,
      "identifier": "Generic Single Pane",
      "materials": [
        "Generic Clear Glass"
      ],
      "type": "WindowConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Shade",
      "is_specular": false,
      "solar_reflectance": 0.35,
      "type": "ShadeConstruction",
      "user_data": null,
      "visible_reflectance": 0.35
    },
    {
      "display_name": null,
      "identifier": "Generic Context",
      "is_specular": false,
      "solar_reflectance": 0.2,
      "type": "ShadeConstruction",
      "user_data": null,
      "visible_reflectance": 0.2
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Ceiling",
      "materials": [
        "Generic LW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Wall",
      "materials": [
        "Generic Gypsum Board",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exposed Floor",
      "materials": [
        "Generic Painted Metal",
        "Generic Ceiling Air Gap",
        "Generic 50mm Insulation",
        "Generic LW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Floor",
      "materials": [
        "Generic Acoustic Tile",
        "Generic Ceiling Air Gap",
        "Generic LW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Ground Slab",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Roof",
      "materials": [
        "Generic Roof Membrane",
        "Generic 50mm Insulation",
        "Generic LW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exterior Wall",
      "materials": [
        "Generic Brick",
        "Generic LW Concrete",
        "Generic 50mm Insulation",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Underground Wall",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "air_mixing_per_area": 0.1,
      "air_mixing_schedule": "Always On",
      "display_name": null,
      "identifier": "Generic Air Boundary",
      "type": "AirBoundaryConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Underground Roof",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "frame": null,
      "identifier": "Generic Double Pane",
      "materials": [
        "Generic Low-e Glass",
        "Generic Window Air Gap",
        "Generic Clear Glass"
      ],
      "type": "WindowConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exterior Door",
      "materials": [
        "Generic Painted Metal",
        "Generic 25mm Insulation",
        "Generic Painted Metal"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    }
  ],
  "wall_set": {
    "exterior_construction": "Generic Exterior Wall",
    "ground_construction": "Generic Underground Wall",
    "interior_construction": "Generic Interior Wall",
    "type": "WallConstructionSetAbridged"
  },
  "floor_set": {
    "exterior_construction": "Generic Exposed Floor",
    "ground_construction": "Generic Ground Slab",
    "interior_construction": "Generic Interior Floor",
    "type": "FloorConstructionSetAbridged"
  },
  "roof_ceiling_set": {
    "exterior_construction": "Generic Roof",
    "ground_construction": "Generic Underground Roof",
    "interior_construction": "Generic Interior Ceiling",
    "type": "RoofCeilingConstructionSetAbridged"
  },
  "aperture_set": {
    "interior_construction": "Generic Single Pane",
    "operable_construction": "Generic Double Pane",
    "skylight_construction": "Generic Double Pane",
    "type": "ApertureConstructionSetAbridged",
    "window_construction": "Generic Double Pane"
  },
  "door_set": {
    "exterior_construction": "Generic Exterior Door",
    "exterior_glass_construction": "Generic Double Pane",
    "interior_construction": "Generic Interior Door",
    "interior_glass_construction": "Generic Single Pane",
    "overhead_construction": "Generic Exterior Door",
    "type": "DoorConstructionSetAbridged"
  },
  "shade_construction": "Generic Shade",
  "context_construction": "Generic Context",
  "air_boundary_construction": "Generic Air Boundary"
});
            this.constructionSets = obj.constructionSets;
            this.constructions = obj.constructions;
            this.materials = obj.materials;
            this.hvacs = obj.hvacs;
            this.shws = obj.shws;
            this.programTypes = obj.programTypes;
            this.schedules = obj.schedules;
            this.scheduleTypeLimits = obj.scheduleTypeLimits;
        }
    }


    static override fromJS(data: any): ModelEnergyProperties {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ModelEnergyProperties();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "ModelEnergyProperties";
        data["global_construction_set"] = this.globalConstructionSet ?? GlobalConstructionSet.fromJS({
  "type": "GlobalConstructionSet",
  "materials": [
    {
      "conductivity": 0.16,
      "density": 1120.0,
      "display_name": null,
      "identifier": "Generic Roof Membrane",
      "roughness": "MediumRough",
      "solar_absorptance": 0.65,
      "specific_heat": 1460.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.01,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.65
    },
    {
      "conductivity": 0.06,
      "density": 368.0,
      "display_name": null,
      "identifier": "Generic Acoustic Tile",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.2,
      "specific_heat": 590.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.02,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.2
    },
    {
      "conductivity": 0.15,
      "density": 608.0,
      "display_name": null,
      "identifier": "Generic 25mm Wood",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.5,
      "specific_heat": 1630.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0254,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 1.95,
      "density": 2240.0,
      "display_name": null,
      "identifier": "Generic HW Concrete",
      "roughness": "MediumRough",
      "solar_absorptance": 0.8,
      "specific_heat": 900.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.2,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.8
    },
    {
      "display_name": null,
      "gas_type": "Air",
      "identifier": "Generic Window Air Gap",
      "thickness": 0.0127,
      "type": "EnergyWindowMaterialGas",
      "user_data": null
    },
    {
      "conductivity": 0.16,
      "density": 800.0,
      "display_name": null,
      "identifier": "Generic Gypsum Board",
      "roughness": "MediumSmooth",
      "solar_absorptance": 0.5,
      "specific_heat": 1090.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0127,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 0.667,
      "density": 1.28,
      "display_name": null,
      "identifier": "Generic Wall Air Gap",
      "roughness": "Smooth",
      "solar_absorptance": 0.7,
      "specific_heat": 1000.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 0.556,
      "density": 1.28,
      "display_name": null,
      "identifier": "Generic Ceiling Air Gap",
      "roughness": "Smooth",
      "solar_absorptance": 0.7,
      "specific_heat": 1000.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 0.9,
      "density": 1920.0,
      "display_name": null,
      "identifier": "Generic Brick",
      "roughness": "MediumRough",
      "solar_absorptance": 0.65,
      "specific_heat": 790.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.65
    },
    {
      "conductivity": 0.03,
      "density": 43.0,
      "display_name": null,
      "identifier": "Generic 50mm Insulation",
      "roughness": "MediumRough",
      "solar_absorptance": 0.7,
      "specific_heat": 1210.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.05,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 1.0,
      "dirt_correction": 1.0,
      "display_name": null,
      "emissivity": 0.84,
      "emissivity_back": 0.047,
      "identifier": "Generic Low-e Glass",
      "infrared_transmittance": 0.0,
      "solar_diffusing": false,
      "solar_reflectance": 0.36,
      "solar_reflectance_back": 0.36,
      "solar_transmittance": 0.45,
      "thickness": 0.006,
      "type": "EnergyWindowMaterialGlazing",
      "user_data": null,
      "visible_reflectance": 0.21,
      "visible_reflectance_back": 0.21,
      "visible_transmittance": 0.71
    },
    {
      "conductivity": 45.0,
      "density": 7690.0,
      "display_name": null,
      "identifier": "Generic Painted Metal",
      "roughness": "Smooth",
      "solar_absorptance": 0.5,
      "specific_heat": 410.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.0015,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.5
    },
    {
      "conductivity": 0.53,
      "density": 1280.0,
      "display_name": null,
      "identifier": "Generic LW Concrete",
      "roughness": "MediumRough",
      "solar_absorptance": 0.8,
      "specific_heat": 840.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.1,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.8
    },
    {
      "conductivity": 0.03,
      "density": 43.0,
      "display_name": null,
      "identifier": "Generic 25mm Insulation",
      "roughness": "MediumRough",
      "solar_absorptance": 0.7,
      "specific_heat": 1210.0,
      "thermal_absorptance": 0.9,
      "thickness": 0.025,
      "type": "EnergyMaterial",
      "user_data": null,
      "visible_absorptance": 0.7
    },
    {
      "conductivity": 1.0,
      "dirt_correction": 1.0,
      "display_name": null,
      "emissivity": 0.84,
      "emissivity_back": 0.84,
      "identifier": "Generic Clear Glass",
      "infrared_transmittance": 0.0,
      "solar_diffusing": false,
      "solar_reflectance": 0.07,
      "solar_reflectance_back": 0.07,
      "solar_transmittance": 0.77,
      "thickness": 0.006,
      "type": "EnergyWindowMaterialGlazing",
      "user_data": null,
      "visible_reflectance": 0.08,
      "visible_reflectance_back": 0.08,
      "visible_transmittance": 0.88
    }
  ],
  "constructions": [
    {
      "display_name": null,
      "identifier": "Generic Interior Door",
      "materials": [
        "Generic 25mm Wood"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "frame": null,
      "identifier": "Generic Single Pane",
      "materials": [
        "Generic Clear Glass"
      ],
      "type": "WindowConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Shade",
      "is_specular": false,
      "solar_reflectance": 0.35,
      "type": "ShadeConstruction",
      "user_data": null,
      "visible_reflectance": 0.35
    },
    {
      "display_name": null,
      "identifier": "Generic Context",
      "is_specular": false,
      "solar_reflectance": 0.2,
      "type": "ShadeConstruction",
      "user_data": null,
      "visible_reflectance": 0.2
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Ceiling",
      "materials": [
        "Generic LW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Wall",
      "materials": [
        "Generic Gypsum Board",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exposed Floor",
      "materials": [
        "Generic Painted Metal",
        "Generic Ceiling Air Gap",
        "Generic 50mm Insulation",
        "Generic LW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Interior Floor",
      "materials": [
        "Generic Acoustic Tile",
        "Generic Ceiling Air Gap",
        "Generic LW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Ground Slab",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Roof",
      "materials": [
        "Generic Roof Membrane",
        "Generic 50mm Insulation",
        "Generic LW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exterior Wall",
      "materials": [
        "Generic Brick",
        "Generic LW Concrete",
        "Generic 50mm Insulation",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Underground Wall",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete",
        "Generic Wall Air Gap",
        "Generic Gypsum Board"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "air_mixing_per_area": 0.1,
      "air_mixing_schedule": "Always On",
      "display_name": null,
      "identifier": "Generic Air Boundary",
      "type": "AirBoundaryConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Underground Roof",
      "materials": [
        "Generic 50mm Insulation",
        "Generic HW Concrete",
        "Generic Ceiling Air Gap",
        "Generic Acoustic Tile"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "frame": null,
      "identifier": "Generic Double Pane",
      "materials": [
        "Generic Low-e Glass",
        "Generic Window Air Gap",
        "Generic Clear Glass"
      ],
      "type": "WindowConstructionAbridged",
      "user_data": null
    },
    {
      "display_name": null,
      "identifier": "Generic Exterior Door",
      "materials": [
        "Generic Painted Metal",
        "Generic 25mm Insulation",
        "Generic Painted Metal"
      ],
      "type": "OpaqueConstructionAbridged",
      "user_data": null
    }
  ],
  "wall_set": {
    "exterior_construction": "Generic Exterior Wall",
    "ground_construction": "Generic Underground Wall",
    "interior_construction": "Generic Interior Wall",
    "type": "WallConstructionSetAbridged"
  },
  "floor_set": {
    "exterior_construction": "Generic Exposed Floor",
    "ground_construction": "Generic Ground Slab",
    "interior_construction": "Generic Interior Floor",
    "type": "FloorConstructionSetAbridged"
  },
  "roof_ceiling_set": {
    "exterior_construction": "Generic Roof",
    "ground_construction": "Generic Underground Roof",
    "interior_construction": "Generic Interior Ceiling",
    "type": "RoofCeilingConstructionSetAbridged"
  },
  "aperture_set": {
    "interior_construction": "Generic Single Pane",
    "operable_construction": "Generic Double Pane",
    "skylight_construction": "Generic Double Pane",
    "type": "ApertureConstructionSetAbridged",
    "window_construction": "Generic Double Pane"
  },
  "door_set": {
    "exterior_construction": "Generic Exterior Door",
    "exterior_glass_construction": "Generic Double Pane",
    "interior_construction": "Generic Interior Door",
    "interior_glass_construction": "Generic Single Pane",
    "overhead_construction": "Generic Exterior Door",
    "type": "DoorConstructionSetAbridged"
  },
  "shade_construction": "Generic Shade",
  "context_construction": "Generic Context",
  "air_boundary_construction": "Generic Air Boundary"
});
        data["construction_sets"] = this.constructionSets;
        data["constructions"] = this.constructions;
        data["materials"] = this.materials;
        data["hvacs"] = this.hvacs;
        data["shws"] = this.shws;
        data["program_types"] = this.programTypes;
        data["schedules"] = this.schedules;
        data["schedule_type_limits"] = this.scheduleTypeLimits;
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
