import { Room2D, Room2DPropertiesAbridged } from "dragonfly-schema";
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
test('test room2d simple', () => {
  const room2d = new Room2D();

  const jsonObj = room2d.toJSON();
  const obj = Room2D.fromJS(jsonObj);
  obj.validate().catch(error => {
    expect(error.message.startsWith("Validation failed: floorBoundary should not be null or undefined,")).toBe(true);
  });
});

test('test room2d', () => {
  const roomData = {
    "type": "Room2D",
    "identifier": "Room_e6ac360b-aaed-4c3b-a130-36b4c2ac9d13-000d1467",
    "display_name": "Master Bedroom-206",
    "properties": {
      "type": "Room2DPropertiesAbridged",
      "energy": { "type": "Room2DEnergyPropertiesAbridged" }
    },
    "floor_boundary": [
      [1.061931517437636, 2.8994060214182706],
      [-4.888068482562394, 2.899406021418289],
      [-4.8880684825623835, -3.302593978581498],
      [-1.378068482562382, -3.302593978581509],
      [-1.3780684825623764, 0.038406021418214205],
      [-0.18806848256237596, 0.03840602141821037],
      [1.0619315174376316, 0.03840602141820621],
      [1.0619315174376338, 1.358406021418206]
    ],
    "floor_height": 3.0000000000000004,
    "floor_to_ceiling_height": 6.000000000000001,
    "is_ground_contact": false,
    "is_top_exposed": true,
    "boundary_conditions": [
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      }
    ],
    "window_parameters": [
      {
        "type": "DetailedWindows",
        "polygons": [
          [
            [3.0000000000000084, 2.6999999999999935],
            [4.500000000000007, 2.6999999999999926],
            [4.500000000000007, 0.0009143999999994932],
            [3.0000000000000084, 0.0009144000000000347]
          ]
        ],
        "are_doors": [false],
        "user_data": {}
      },
      {
        "type": "DetailedWindows",
        "polygons": [
          [
            [1.620999999999999, 0.04000000000000011],
            [1.620999999999999, 2.0800000000000005],
            [3.0809999999999995, 2.0800000000000005],
            [3.0809999999999995, 0.04000000000000011]
          ],
          [
            [3.120999999999999, 0.04000000000000011],
            [3.120999999999999, 2.0800000000000005],
            [4.581, 2.0800000000000005],
            [4.581, 0.04000000000000011]
          ],
          [
            [4.620999999999893, 0.04000000000000011],
            [4.620999999999893, 2.0800000000000005],
            [6.060999999999892, 2.0800000000000005],
            [6.060999999999892, 0.04000000000000011]
          ],
          [
            [0.25884214488802365, 3.02],
            [1.5809999999999995, 4.39435106696338],
            [1.5809999999999995, 3.02]
          ],
          [
            [1.620999999999999, 4.435930098140318],
            [2.9876230980831053, 5.856501708198367],
            [3.080999999999999, 5.766670945649302],
            [3.080999999999999, 3.02],
            [1.6209999999999998, 3.02]
          ],
          [
            [3.121, 3.02],
            [3.121, 5.728190010555089],
            [4.581, 4.323635879616347],
            [4.581, 3.02]
          ],
          [
            [4.6209999999999996, 3.02],
            [4.6209999999999996, 4.285154944522135],
            [5.9360979220485985, 3.02]
          ],
          [
            [0.14099999999999935, 2.12],
            [0.14099999999999935, 2.897505944593588],
            [0.22036120979381166, 2.9800000000000004],
            [1.5809999999999993, 2.9800000000000004],
            [1.5809999999999993, 2.12]
          ],
          [
            [1.6209999999999993, 2.12],
            [1.6209999999999993, 2.9800000000000004],
            [3.080999999999999, 2.9800000000000004],
            [3.080999999999999, 2.12]
          ],
          [
            [3.121, 2.12],
            [3.121, 2.9800000000000004],
            [4.5809999999999995, 2.9800000000000004],
            [4.5809999999999995, 2.12]
          ],
          [
            [4.620999999999999, 2.12],
            [4.620999999999999, 2.9800000000000004],
            [5.977676953225537, 2.9800000000000004],
            [6.060999999999788, 2.899841281130703],
            [6.060999999999788, 2.12]
          ]
        ],
        "are_doors": [
          false,
          false,
          false,
          false,
          false,
          false,
          false,
          false,
          false,
          false,
          false
        ],
        "user_data": {}
      },
      {
        "type": "DetailedWindows",
        "polygons": [
          [
            [1.4500000000000255, 0.0009143999999994932],
            [1.4500000000000255, 2.6999999999999926],
            [2.950000000000024, 2.6999999999999935],
            [2.950000000000024, 0.0009144000000000347]
          ]
        ],
        "are_doors": [false],
        "user_data": {}
      },
      null,
      null,
      null,
      null,
      null
    ],
    "user_data": {}
  };
  const obj = Room2D.fromJS(roomData);
  expect(obj.identifier).toBe("Room_e6ac360b-aaed-4c3b-a130-36b4c2ac9d13-000d1467");
  expect(obj.validate()).resolves.toBe(true);


  const jsonObj = obj.toJSON();
  const prop = jsonObj["properties"];
  expect(prop["energy"].hasOwnProperty("hvac")).toBe(false);
  expect(prop.hasOwnProperty("radiance")).toBe(false);


});

test('test room2d2', () => {
  const roomData = {
    "type": "Room2D",
    "identifier": "Room_e6ac360b-aaed-4c3b-a130-36b4c2ac9d13-000d14cc",
    "display_name": "Laundry-104",
    "properties": {
      "type": "Room2DPropertiesAbridged",
      "energy": { "type": "Room2DEnergyPropertiesAbridged" },
      "radiance": { "type": "Room2DRadiancePropertiesAbridged" }
    },
    "floor_boundary": [
      [10.001931517437631, -0.7441439785816385],
      [8.290021124356155, -0.744143978581633],
      [7.6424815174376315, -0.744143978581631],
      [7.642481517437627, -3.3415939785816904],
      [10.001931517437628, -3.3415939785816975],
      [10.001931517437628, -2.5035939785815233]
    ],
    "floor_height": 0,
    "floor_to_ceiling_height": 3,
    "is_ground_contact": true,
    "is_top_exposed": false,
    "boundary_conditions": [
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      },
      {
        "type": "Outdoors",
        "sun_exposure": true,
        "wind_exposure": true,
        "view_factor": { "type": "Autocalculate" }
      }
    ],
    "user_data": {}
  };
  const obj = Room2D.fromJS(roomData);
  expect(obj.identifier).toBe("Room_e6ac360b-aaed-4c3b-a130-36b4c2ac9d13-000d14cc");
  expect(obj.validate()).resolves.toBe(true);

  const jsonObj = obj.toJSON();
  const prop = jsonObj["properties"];
  expect(prop["energy"].hasOwnProperty("hvac")).toBe(false);
  expect(prop.hasOwnProperty("radiance")).toBe(true);

});

test('test roomProperty', () => {
  const roomData = {
    "type": "Room2DPropertiesAbridged",
    "energy": { "type": "Room2DEnergyPropertiesAbridged" }
  };
  const obj = Room2DPropertiesAbridged.fromJS(roomData);
  expect(obj.validate()).resolves.toBe(true);

  const jsonObj = obj.toJSON();
  expect(jsonObj.type).toBe("Room2DPropertiesAbridged");
  expect(jsonObj).toHaveProperty("energy");
  expect(jsonObj.hasOwnProperty("radiance")).toBe(false);

});

