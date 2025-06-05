import { plainToClass } from "class-transformer";
import { } from "dragonfly-schema";
import { Model, ModelRadianceProperties, DoorModifierSetAbridged, Face3D, GlobalModifierSet, ModelProperties, Plastic, WallConstructionSetAbridged, WallModifierSetAbridged } from "honeybee-schema";
import * as fs from 'fs';
import * as path from 'path';

test('test model', () => {
    const dir = path.dirname(path.dirname(path.dirname(__dirname)));
    const sampleDir = path.join(dir, 'samples');
    console.log(sampleDir);

    const filePath = path.join(sampleDir, 'Room_with_complex_skylights.dfjson');
    const jsonData = fs.readFileSync(filePath, 'utf8');
    // console.log(jsonData);

    const json = JSON.parse(jsonData);
    const model = Model.fromJS(json);
    expect(model.identifier).toBe("unnamed_cb67f62e");
    //   const 
    expect(model.validate()).resolves.toBe(true);

}
);

test('test wallSet', () => {
    const data = {
        interior_construction: "Generic Interior Wall",
        exterior_construction: "Generic Exterior Wall",
        type: "WallConstructionSetAbridged",
    };
    const obj = WallConstructionSetAbridged.fromJS(data);
    expect(obj.validate()).resolves.toBe(true);

    const jsonObj = obj.toJSON();
    expect(jsonObj.type).toBe("WallConstructionSetAbridged");
    expect(jsonObj).toHaveProperty("interior_construction");
    expect(jsonObj.hasOwnProperty("ground_construction")).toBe(false);

}
);

const GlobalModifierSetData = {
    "shade_set": {
        "type": "ShadeModifierSetAbridged",
        "interior_modifier": "generic_interior_shade_0.50",
        "exterior_modifier": "generic_exterior_shade_0.35"
    },
    "roof_ceiling_set": {
        "type": "RoofCeilingModifierSetAbridged",
        "interior_modifier": "generic_ceiling_0.80",
        "exterior_modifier": "generic_ceiling_0.80"
    },
    "context_modifier": "generic_context_0.20",
    "modifiers": [
        {
            "dependencies": [],
            "modifier": null,
            "g_reflectance": 0.5,
            "identifier": "generic_wall_0.50",
            "specularity": 0,
            "b_reflectance": 0.5,
            "r_reflectance": 0.5,
            "type": "Plastic",
            "roughness": 0
        },
        {
            "b_transmissivity": 0.9584154328610596,
            "r_transmissivity": 0.9584154328610596,
            "modifier": null,
            "identifier": "generic_interior_window_vis_0.88",
            "refraction_index": null,
            "type": "Glass",
            "dependencies": [],
            "g_transmissivity": 0.9584154328610596
        },
        {
            "dependencies": [],
            "modifier": null,
            "g_reflectance": 0.5,
            "identifier": "generic_interior_shade_0.50",
            "specularity": 0,
            "b_reflectance": 0.5,
            "r_reflectance": 0.5,
            "type": "Plastic",
            "roughness": 0
        },
        {
            "dependencies": [],
            "modifier": null,
            "g_reflectance": 0.2,
            "identifier": "generic_floor_0.20",
            "specularity": 0,
            "b_reflectance": 0.2,
            "r_reflectance": 0.2,
            "type": "Plastic",
            "roughness": 0
        },
        {
            "dependencies": [],
            "modifier": null,
            "g_reflectance": 0.8,
            "identifier": "generic_ceiling_0.80",
            "specularity": 0,
            "b_reflectance": 0.8,
            "r_reflectance": 0.8,
            "type": "Plastic",
            "roughness": 0
        },
        {
            "b_transmissivity": 0.6975761815384331,
            "r_transmissivity": 0.6975761815384331,
            "modifier": null,
            "identifier": "generic_exterior_window_vis_0.64",
            "refraction_index": null,
            "type": "Glass",
            "dependencies": [],
            "g_transmissivity": 0.6975761815384331
        },
        {
            "r_reflectance": 1,
            "b_reflectance": 1,
            "roughness": 0,
            "identifier": "air_boundary",
            "type": "Trans",
            "dependencies": [],
            "g_reflectance": 1,
            "specularity": 0,
            "transmitted_diff": 1,
            "transmitted_spec": 1,
            "modifier": null
        },
        {
            "dependencies": [],
            "modifier": null,
            "g_reflectance": 0.35,
            "identifier": "generic_exterior_shade_0.35",
            "specularity": 0,
            "b_reflectance": 0.35,
            "r_reflectance": 0.35,
            "type": "Plastic",
            "roughness": 0
        },
        {
            "dependencies": [],
            "modifier": null,
            "g_reflectance": 0.5,
            "identifier": "generic_opaque_door_0.50",
            "specularity": 0,
            "b_reflectance": 0.5,
            "r_reflectance": 0.5,
            "type": "Plastic",
            "roughness": 0
        },
        {
            "dependencies": [],
            "modifier": null,
            "g_reflectance": 0.2,
            "identifier": "generic_context_0.20",
            "specularity": 0,
            "b_reflectance": 0.2,
            "r_reflectance": 0.2,
            "type": "Plastic",
            "roughness": 0
        }
    ],
    "wall_set": {
        "type": "WallModifierSetAbridged",
        "interior_modifier": "generic_wall_0.50",
        "exterior_modifier": "generic_wall_0.50"
    },
    "door_set": {
        "exterior_glass_modifier": "generic_exterior_window_vis_0.64",
        "interior_glass_modifier": "generic_interior_window_vis_0.88",
        "overhead_modifier": "generic_opaque_door_0.50",
        "exterior_modifier": "generic_opaque_door_0.50",
        "interior_modifier": "generic_opaque_door_0.50",
        "type": "DoorModifierSetAbridged"
    },
    "floor_set": {
        "type": "FloorModifierSetAbridged",
        "interior_modifier": "generic_floor_0.20",
        "exterior_modifier": "generic_floor_0.20"
    },
    "type": "GlobalModifierSet",
    "aperture_set": {
        "interior_modifier": "generic_interior_window_vis_0.88",
        "window_modifier": "generic_exterior_window_vis_0.64",
        "skylight_modifier": "generic_exterior_window_vis_0.64",
        "type": "ApertureModifierSetAbridged",
        "operable_modifier": "generic_exterior_window_vis_0.64"
    },
    "air_boundary_modifier": "air_boundary"
};

test('test GlobalModifierSet', () => {
    const data = GlobalModifierSetData;
    const obj = GlobalModifierSet.fromJS(data);
    expect(obj.validate()).resolves.toBe(true);
    expect(obj.modifiers?.at(0)).toBeInstanceOf(Plastic);
    expect(obj.doorSet).toBeInstanceOf(DoorModifierSetAbridged);

    const jsonObj = obj.toJSON();
    expect(jsonObj.type).toBe("GlobalModifierSet");
    expect(jsonObj).toHaveProperty("wall_set");
    expect(jsonObj.wall_set).toHaveProperty("interior_modifier");
    expect(jsonObj.wall_set.hasOwnProperty("ground_construction")).toBe(false);

}
);

test('test ModelProperties', () => {
    const data = {
        "radiance":
        {
            "global_modifier_set": GlobalModifierSetData
        }
    };
    const obj = ModelProperties.fromJS(data);
    // expect(obj.validate()).resolves.toBe(true);
    expect(obj.radiance?.globalModifierSet?.wallSet).toBeInstanceOf(WallModifierSetAbridged);

}
);

test('test global wall set instance', () => {
    const data = {
        "properties":
        {
            "radiance":
            {
                "global_modifier_set": GlobalModifierSetData
            }
        }
    };

    // const model = plainToClass(Model, data, { enableImplicitConversion: true });
    const obj = Model.fromJS(data);
    const radProp = obj.properties.radiance;
    expect(radProp).toBeInstanceOf(ModelRadianceProperties);

    const wallset = obj.properties.radiance?.globalModifierSet?.wallSet;
    expect(wallset).toBeInstanceOf(WallModifierSetAbridged);
    // expect(obj.validate()).resolves.toBe(true);

}
);


