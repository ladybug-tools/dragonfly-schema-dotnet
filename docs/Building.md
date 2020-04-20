
# DragonflySchema.Model.Building

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. | 
**UniqueStories** | [**List&lt;Story&gt;**](Story.md) | An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor. Note that, if a given Story is repeated several times over the height of the building, the unique story included in this list should be the first (lowest) story of the repeated floors. | 
**Properties** | [**BuildingPropertiesAbridged**](BuildingPropertiesAbridged.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**DisplayName** | **string** | Display name of the object with no character restrictions. | [optional] 
**UserData** | [**Object**](.md) | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "Building"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

