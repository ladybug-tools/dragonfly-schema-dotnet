import { IsString, IsOptional, Equals, IsInstance, ValidateNested, IsArray, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, instanceToPlain, Expose, Transform } from 'class-transformer';
import { deepTransform } from '../deepTransform';
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

export class ModelRadianceProperties extends _OpenAPIGenBaseModel {
    @Type(() => String)
    @IsString()
    @IsOptional()
    @Equals("ModelRadianceProperties")
    @Expose({ name: "type" })
    /** type */
    type: string = "ModelRadianceProperties";
	
    @Type(() => GlobalModifierSet)
    @IsInstance(GlobalModifierSet)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "global_modifier_set" })
    /** Global Radiance modifier set. */
    globalModifierSet: GlobalModifierSet = GlobalModifierSet.fromJS({
  "type": "GlobalModifierSet",
  "modifiers": [
    {
      "b_reflectance": 0.2,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.2,
      "identifier": "generic_floor_0.20",
      "modifier": null,
      "r_reflectance": 0.2,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_wall_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.8,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.8,
      "identifier": "generic_ceiling_0.80",
      "modifier": null,
      "r_reflectance": 0.8,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_opaque_door_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_interior_shade_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.35,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.35,
      "identifier": "generic_exterior_shade_0.35",
      "modifier": null,
      "r_reflectance": 0.35,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.2,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.2,
      "identifier": "generic_context_0.20",
      "modifier": null,
      "r_reflectance": 0.2,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_transmissivity": 0.9584154328610596,
      "dependencies": [],
      "display_name": null,
      "g_transmissivity": 0.9584154328610596,
      "identifier": "generic_interior_window_vis_0.88",
      "modifier": null,
      "r_transmissivity": 0.9584154328610596,
      "refraction_index": null,
      "type": "Glass"
    },
    {
      "b_transmissivity": 0.6975761815384331,
      "dependencies": [],
      "display_name": null,
      "g_transmissivity": 0.6975761815384331,
      "identifier": "generic_exterior_window_vis_0.64",
      "modifier": null,
      "r_transmissivity": 0.6975761815384331,
      "refraction_index": null,
      "type": "Glass"
    },
    {
      "b_reflectance": 1.0,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 1.0,
      "identifier": "air_boundary",
      "modifier": null,
      "r_reflectance": 1.0,
      "roughness": 0.0,
      "specularity": 0.0,
      "transmitted_diff": 1.0,
      "transmitted_spec": 1.0,
      "type": "Trans"
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
    "interior_modifier": "generic_interior_window_vis_0.88",
    "operable_modifier": "generic_exterior_window_vis_0.64",
    "skylight_modifier": "generic_exterior_window_vis_0.64",
    "type": "ApertureModifierSetAbridged",
    "window_modifier": "generic_exterior_window_vis_0.64"
  },
  "door_set": {
    "exterior_glass_modifier": "generic_exterior_window_vis_0.64",
    "exterior_modifier": "generic_opaque_door_0.50",
    "interior_glass_modifier": "generic_interior_window_vis_0.88",
    "interior_modifier": "generic_opaque_door_0.50",
    "overhead_modifier": "generic_opaque_door_0.50",
    "type": "DoorModifierSetAbridged"
  },
  "shade_set": {
    "exterior_modifier": "generic_exterior_shade_0.35",
    "interior_modifier": "generic_interior_shade_0.50",
    "type": "ShadeModifierSetAbridged"
  },
  "air_boundary_modifier": "air_boundary",
  "context_modifier": "generic_context_0.20"
});
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "modifier_sets" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'ModifierSet') return ModifierSet.fromJS(item);
      else if (item?.type === 'ModifierSetAbridged') return ModifierSetAbridged.fromJS(item);
      else return item;
    }))
    /** List of all ModifierSets in the Model. */
    modifierSets?: (ModifierSet | ModifierSetAbridged)[];
	
    @IsArray()
    @IsOptional()
    @Expose({ name: "modifiers" })
    @Transform(({ value }) => value?.map((item: any) => {
      if (item?.type === 'Plastic') return Plastic.fromJS(item);
      else if (item?.type === 'Glass') return Glass.fromJS(item);
      else if (item?.type === 'BSDF') return BSDF.fromJS(item);
      else if (item?.type === 'Glow') return Glow.fromJS(item);
      else if (item?.type === 'Light') return Light.fromJS(item);
      else if (item?.type === 'Trans') return Trans.fromJS(item);
      else if (item?.type === 'Metal') return Metal.fromJS(item);
      else if (item?.type === 'Void') return Void.fromJS(item);
      else if (item?.type === 'Mirror') return Mirror.fromJS(item);
      else return item;
    }))
    /** A list of all unique modifiers in the model. This includes modifiers across all the Model modifier_sets. */
    modifiers?: (Plastic | Glass | BSDF | Glow | Light | Trans | Metal | Void | Mirror)[];
	

    constructor() {
        super();
        this.type = "ModelRadianceProperties";
        this.globalModifierSet = GlobalModifierSet.fromJS({
  "type": "GlobalModifierSet",
  "modifiers": [
    {
      "b_reflectance": 0.2,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.2,
      "identifier": "generic_floor_0.20",
      "modifier": null,
      "r_reflectance": 0.2,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_wall_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.8,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.8,
      "identifier": "generic_ceiling_0.80",
      "modifier": null,
      "r_reflectance": 0.8,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_opaque_door_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_interior_shade_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.35,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.35,
      "identifier": "generic_exterior_shade_0.35",
      "modifier": null,
      "r_reflectance": 0.35,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.2,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.2,
      "identifier": "generic_context_0.20",
      "modifier": null,
      "r_reflectance": 0.2,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_transmissivity": 0.9584154328610596,
      "dependencies": [],
      "display_name": null,
      "g_transmissivity": 0.9584154328610596,
      "identifier": "generic_interior_window_vis_0.88",
      "modifier": null,
      "r_transmissivity": 0.9584154328610596,
      "refraction_index": null,
      "type": "Glass"
    },
    {
      "b_transmissivity": 0.6975761815384331,
      "dependencies": [],
      "display_name": null,
      "g_transmissivity": 0.6975761815384331,
      "identifier": "generic_exterior_window_vis_0.64",
      "modifier": null,
      "r_transmissivity": 0.6975761815384331,
      "refraction_index": null,
      "type": "Glass"
    },
    {
      "b_reflectance": 1.0,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 1.0,
      "identifier": "air_boundary",
      "modifier": null,
      "r_reflectance": 1.0,
      "roughness": 0.0,
      "specularity": 0.0,
      "transmitted_diff": 1.0,
      "transmitted_spec": 1.0,
      "type": "Trans"
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
    "interior_modifier": "generic_interior_window_vis_0.88",
    "operable_modifier": "generic_exterior_window_vis_0.64",
    "skylight_modifier": "generic_exterior_window_vis_0.64",
    "type": "ApertureModifierSetAbridged",
    "window_modifier": "generic_exterior_window_vis_0.64"
  },
  "door_set": {
    "exterior_glass_modifier": "generic_exterior_window_vis_0.64",
    "exterior_modifier": "generic_opaque_door_0.50",
    "interior_glass_modifier": "generic_interior_window_vis_0.88",
    "interior_modifier": "generic_opaque_door_0.50",
    "overhead_modifier": "generic_opaque_door_0.50",
    "type": "DoorModifierSetAbridged"
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

        if (_data) {
            const obj = deepTransform(ModelRadianceProperties, _data);
            this.type = obj.type ?? "ModelRadianceProperties";
            this.globalModifierSet = obj.globalModifierSet ?? GlobalModifierSet.fromJS({
  "type": "GlobalModifierSet",
  "modifiers": [
    {
      "b_reflectance": 0.2,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.2,
      "identifier": "generic_floor_0.20",
      "modifier": null,
      "r_reflectance": 0.2,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_wall_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.8,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.8,
      "identifier": "generic_ceiling_0.80",
      "modifier": null,
      "r_reflectance": 0.8,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_opaque_door_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_interior_shade_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.35,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.35,
      "identifier": "generic_exterior_shade_0.35",
      "modifier": null,
      "r_reflectance": 0.35,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.2,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.2,
      "identifier": "generic_context_0.20",
      "modifier": null,
      "r_reflectance": 0.2,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_transmissivity": 0.9584154328610596,
      "dependencies": [],
      "display_name": null,
      "g_transmissivity": 0.9584154328610596,
      "identifier": "generic_interior_window_vis_0.88",
      "modifier": null,
      "r_transmissivity": 0.9584154328610596,
      "refraction_index": null,
      "type": "Glass"
    },
    {
      "b_transmissivity": 0.6975761815384331,
      "dependencies": [],
      "display_name": null,
      "g_transmissivity": 0.6975761815384331,
      "identifier": "generic_exterior_window_vis_0.64",
      "modifier": null,
      "r_transmissivity": 0.6975761815384331,
      "refraction_index": null,
      "type": "Glass"
    },
    {
      "b_reflectance": 1.0,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 1.0,
      "identifier": "air_boundary",
      "modifier": null,
      "r_reflectance": 1.0,
      "roughness": 0.0,
      "specularity": 0.0,
      "transmitted_diff": 1.0,
      "transmitted_spec": 1.0,
      "type": "Trans"
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
    "interior_modifier": "generic_interior_window_vis_0.88",
    "operable_modifier": "generic_exterior_window_vis_0.64",
    "skylight_modifier": "generic_exterior_window_vis_0.64",
    "type": "ApertureModifierSetAbridged",
    "window_modifier": "generic_exterior_window_vis_0.64"
  },
  "door_set": {
    "exterior_glass_modifier": "generic_exterior_window_vis_0.64",
    "exterior_modifier": "generic_opaque_door_0.50",
    "interior_glass_modifier": "generic_interior_window_vis_0.88",
    "interior_modifier": "generic_opaque_door_0.50",
    "overhead_modifier": "generic_opaque_door_0.50",
    "type": "DoorModifierSetAbridged"
  },
  "shade_set": {
    "exterior_modifier": "generic_exterior_shade_0.35",
    "interior_modifier": "generic_interior_shade_0.50",
    "type": "ShadeModifierSetAbridged"
  },
  "air_boundary_modifier": "air_boundary",
  "context_modifier": "generic_context_0.20"
});
            this.modifierSets = obj.modifierSets;
            this.modifiers = obj.modifiers;
        }
    }


    static override fromJS(data: any): ModelRadianceProperties {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ModelRadianceProperties();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "ModelRadianceProperties";
        data["global_modifier_set"] = this.globalModifierSet ?? GlobalModifierSet.fromJS({
  "type": "GlobalModifierSet",
  "modifiers": [
    {
      "b_reflectance": 0.2,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.2,
      "identifier": "generic_floor_0.20",
      "modifier": null,
      "r_reflectance": 0.2,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_wall_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.8,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.8,
      "identifier": "generic_ceiling_0.80",
      "modifier": null,
      "r_reflectance": 0.8,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_opaque_door_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.5,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.5,
      "identifier": "generic_interior_shade_0.50",
      "modifier": null,
      "r_reflectance": 0.5,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.35,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.35,
      "identifier": "generic_exterior_shade_0.35",
      "modifier": null,
      "r_reflectance": 0.35,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_reflectance": 0.2,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 0.2,
      "identifier": "generic_context_0.20",
      "modifier": null,
      "r_reflectance": 0.2,
      "roughness": 0.0,
      "specularity": 0.0,
      "type": "Plastic"
    },
    {
      "b_transmissivity": 0.9584154328610596,
      "dependencies": [],
      "display_name": null,
      "g_transmissivity": 0.9584154328610596,
      "identifier": "generic_interior_window_vis_0.88",
      "modifier": null,
      "r_transmissivity": 0.9584154328610596,
      "refraction_index": null,
      "type": "Glass"
    },
    {
      "b_transmissivity": 0.6975761815384331,
      "dependencies": [],
      "display_name": null,
      "g_transmissivity": 0.6975761815384331,
      "identifier": "generic_exterior_window_vis_0.64",
      "modifier": null,
      "r_transmissivity": 0.6975761815384331,
      "refraction_index": null,
      "type": "Glass"
    },
    {
      "b_reflectance": 1.0,
      "dependencies": [],
      "display_name": null,
      "g_reflectance": 1.0,
      "identifier": "air_boundary",
      "modifier": null,
      "r_reflectance": 1.0,
      "roughness": 0.0,
      "specularity": 0.0,
      "transmitted_diff": 1.0,
      "transmitted_spec": 1.0,
      "type": "Trans"
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
    "interior_modifier": "generic_interior_window_vis_0.88",
    "operable_modifier": "generic_exterior_window_vis_0.64",
    "skylight_modifier": "generic_exterior_window_vis_0.64",
    "type": "ApertureModifierSetAbridged",
    "window_modifier": "generic_exterior_window_vis_0.64"
  },
  "door_set": {
    "exterior_glass_modifier": "generic_exterior_window_vis_0.64",
    "exterior_modifier": "generic_opaque_door_0.50",
    "interior_glass_modifier": "generic_interior_window_vis_0.88",
    "interior_modifier": "generic_opaque_door_0.50",
    "overhead_modifier": "generic_opaque_door_0.50",
    "type": "DoorModifierSetAbridged"
  },
  "shade_set": {
    "exterior_modifier": "generic_exterior_shade_0.35",
    "interior_modifier": "generic_interior_shade_0.50",
    "type": "ShadeModifierSetAbridged"
  },
  "air_boundary_modifier": "air_boundary",
  "context_modifier": "generic_context_0.20"
});
        data["modifier_sets"] = this.modifierSets;
        data["modifiers"] = this.modifiers;
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
