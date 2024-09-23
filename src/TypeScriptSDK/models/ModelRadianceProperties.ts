import { IsString, IsOptional, Matches, IsInstance, ValidateNested, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { BSDF } from "honeybee-schema";
import { Glass } from "honeybee-schema";
import { GlobalModifierSet } from "honeybee-schema";
import { Glow } from "honeybee-schema";
import { Light } from "honeybee-schema";
import { Metal } from "honeybee-schema";
import { Mirror } from "honeybee-schema";
import { ModifierSet } from "honeybee-schema";
import { ModifierSetAbridged } from "honeybee-schema";
import { Plastic } from "honeybee-schema";
import { Trans } from "honeybee-schema";
import { Void } from "honeybee-schema";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class ModelRadianceProperties extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^ModelRadianceProperties$/)
    type?: string;
	
    @IsInstance(GlobalModifierSet)
    @Type(() => GlobalModifierSet)
    @ValidateNested()
    @IsOptional()
    /** Global Radiance modifier set. */
    global_modifier_set?: GlobalModifierSet;
	
    @IsArray()
    @IsOptional()
    /** List of all ModifierSets in the Model. */
    modifier_sets?: (ModifierSet | ModifierSetAbridged) [];
	
    @IsArray()
    @IsOptional()
    /** A list of all unique modifiers in the model. This includes modifiers across all the Model modifier_sets. */
    modifiers?: (Plastic | Glass | BSDF | Glow | Light | Trans | Metal | Void | Mirror) [];
	

    constructor() {
        super();
        this.type = "ModelRadianceProperties";
        this.global_modifier_set = GlobalModifierSet.fromJS({
  "type": "GlobalModifierSet",
  "modifiers": [
    {
      "identifier": "generic_floor_0.20",
      "display_name": null,
      "type": "Plastic",
      "modifier": null,
      "dependencies": [],
      "r_reflectance": 0.2,
      "g_reflectance": 0.2,
      "b_reflectance": 0.2,
      "specularity": 0.0,
      "roughness": 0.0
    },
    {
      "identifier": "generic_wall_0.50",
      "display_name": null,
      "type": "Plastic",
      "modifier": null,
      "dependencies": [],
      "r_reflectance": 0.5,
      "g_reflectance": 0.5,
      "b_reflectance": 0.5,
      "specularity": 0.0,
      "roughness": 0.0
    },
    {
      "identifier": "generic_ceiling_0.80",
      "display_name": null,
      "type": "Plastic",
      "modifier": null,
      "dependencies": [],
      "r_reflectance": 0.8,
      "g_reflectance": 0.8,
      "b_reflectance": 0.8,
      "specularity": 0.0,
      "roughness": 0.0
    },
    {
      "identifier": "generic_opaque_door_0.50",
      "display_name": null,
      "type": "Plastic",
      "modifier": null,
      "dependencies": [],
      "r_reflectance": 0.5,
      "g_reflectance": 0.5,
      "b_reflectance": 0.5,
      "specularity": 0.0,
      "roughness": 0.0
    },
    {
      "identifier": "generic_interior_shade_0.50",
      "display_name": null,
      "type": "Plastic",
      "modifier": null,
      "dependencies": [],
      "r_reflectance": 0.5,
      "g_reflectance": 0.5,
      "b_reflectance": 0.5,
      "specularity": 0.0,
      "roughness": 0.0
    },
    {
      "identifier": "generic_exterior_shade_0.35",
      "display_name": null,
      "type": "Plastic",
      "modifier": null,
      "dependencies": [],
      "r_reflectance": 0.35,
      "g_reflectance": 0.35,
      "b_reflectance": 0.35,
      "specularity": 0.0,
      "roughness": 0.0
    },
    {
      "identifier": "generic_context_0.20",
      "display_name": null,
      "type": "Plastic",
      "modifier": null,
      "dependencies": [],
      "r_reflectance": 0.2,
      "g_reflectance": 0.2,
      "b_reflectance": 0.2,
      "specularity": 0.0,
      "roughness": 0.0
    },
    {
      "identifier": "generic_interior_window_vis_0.88",
      "display_name": null,
      "type": "Glass",
      "modifier": null,
      "dependencies": [],
      "r_transmissivity": 0.9584154328610596,
      "g_transmissivity": 0.9584154328610596,
      "b_transmissivity": 0.9584154328610596,
      "refraction_index": null
    },
    {
      "identifier": "generic_exterior_window_vis_0.64",
      "display_name": null,
      "type": "Glass",
      "modifier": null,
      "dependencies": [],
      "r_transmissivity": 0.6975761815384331,
      "g_transmissivity": 0.6975761815384331,
      "b_transmissivity": 0.6975761815384331,
      "refraction_index": null
    },
    {
      "identifier": "air_boundary",
      "display_name": null,
      "type": "Trans",
      "modifier": null,
      "dependencies": [],
      "r_reflectance": 1.0,
      "g_reflectance": 1.0,
      "b_reflectance": 1.0,
      "specularity": 0.0,
      "roughness": 0.0,
      "transmitted_diff": 1.0,
      "transmitted_spec": 1.0
    }
  ],
  "wall_set": {
    "exterior_modifier": "generic_wall_0.50",
    "interior_modifier": "generic_wall_0.50",
    "type": "WallModifierSetAbridged"
  },
  "floor_set": {
    "exterior_modifier": "generic_floor_0.20",
    "interior_modifier": "generic_floor_0.20",
    "type": "FloorModifierSetAbridged"
  },
  "roof_ceiling_set": {
    "exterior_modifier": "generic_ceiling_0.80",
    "interior_modifier": "generic_ceiling_0.80",
    "type": "RoofCeilingModifierSetAbridged"
  },
  "aperture_set": {
    "type": "ApertureModifierSetAbridged",
    "window_modifier": "generic_exterior_window_vis_0.64",
    "interior_modifier": "generic_interior_window_vis_0.88",
    "skylight_modifier": "generic_exterior_window_vis_0.64",
    "operable_modifier": "generic_exterior_window_vis_0.64"
  },
  "door_set": {
    "exterior_modifier": "generic_opaque_door_0.50",
    "interior_modifier": "generic_opaque_door_0.50",
    "type": "DoorModifierSetAbridged",
    "interior_glass_modifier": "generic_interior_window_vis_0.88",
    "exterior_glass_modifier": "generic_exterior_window_vis_0.64",
    "overhead_modifier": "generic_opaque_door_0.50"
  },
  "shade_set": {
    "exterior_modifier": "generic_exterior_shade_0.35",
    "interior_modifier": "generic_interior_shade_0.50",
    "type": "ShadeModifierSetAbridged"
  },
  "air_boundary_modifier": "air_boundary",
  "context_modifier": "generic_context_0.20"
});
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ModelRadianceProperties, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.global_modifier_set = obj.global_modifier_set;
            this.modifier_sets = obj.modifier_sets;
            this.modifiers = obj.modifiers;
        }
    }


    static override fromJS(data: any): ModelRadianceProperties {
        data = typeof data === 'object' ? data : {};

        let result = new ModelRadianceProperties();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["global_modifier_set"] = this.global_modifier_set;
        data["modifier_sets"] = this.modifier_sets;
        data["modifiers"] = this.modifiers;
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

