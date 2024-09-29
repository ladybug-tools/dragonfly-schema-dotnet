// import { ProjectInfo } from 'honeybee-schema';
import { sum } from './sum';
import { Room2D, Room2DPropertiesAbridged } from 'dragonfly-schema';

test('adds 1 + 2 to equal 3', () => {
  expect(sum(1, 2)).toBe(3);
});

// test('tt', () => {
//     const obj = new ProjectInfo();
//     obj.north = 10;
//     const jsonObj = obj.toJSON();
//     expect(jsonObj.north).toBe(10);
//   });
  

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