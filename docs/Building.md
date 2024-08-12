
# DragonflySchema.Model.Building

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. | 
**DisplayName** | **string** | Display name of the object with no character restrictions. | [optional] 
**UserData** | **Object** | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 
**Properties** | [**BuildingPropertiesAbridged**](BuildingPropertiesAbridged.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**Type** | **string** |  | [optional] [readonly] [default to "Building"]
**UniqueStories** | [**List&lt;Story&gt;**](Story.md) | An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor, though this is not required. Note that, if a given Story is repeated several times over the height of the building and this is represented by the multiplier, the unique story included in this list should be the first (lowest) story of the repeated floors. | [optional] 
**Room3ds** | [**List&lt;Room&gt;**](Room.md) | An optional array of 3D Honeybee Room objects for additional Rooms that are a part of the Building but are not represented within the unique_stories. This is useful when there are parts of the Building geometry that cannot easily be represented with the extruded floor plate and sloped roof assumptions that underlie Dragonfly Room2Ds and RoofSpecification. Cases where this input is most useful include sloped walls and certain types of domed roofs that become tedious to implement with RoofSpecification. Matching the Honeybee Room.story property to the Dragonfly Story.display_name of an object within the unique_stories will effectively place the Honeybee Room on that Story for the purposes of floor_area, exterior_wall_area, etc. However, note that the Honeybee Room.multiplier property takes precedence over whatever multiplier is assigned to the Dragonfly Story that the Room.story may reference. (Default: None). | [optional] 
**Roof** | [**RoofSpecification**](RoofSpecification.md) | An optional RoofSpecification object that provides an alternative way to describe roof geometry over rooms (instead of specifying roofs on each story). If trying to decide between the two, specifying geometry on each story is closer to how dragonfly natively works with roof geometry as it relates to rooms. However, when it is unknown which roof geometries correspond to which stories, this Building-level attribute may be used and each roof geometry will automatically be added to the best Story in the Building upon serialization to Python. This automatic assignment will happen by checking for overlaps between the Story Room2Ds and the Roof geometry in plan. When a given roof geometry overlaps with several Stories, the top-most Story will get the roof geometry assigned to it unless this top Story has a floor_height above the roof geometry, in which case the next highest story will be checked until a compatible one is found. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

