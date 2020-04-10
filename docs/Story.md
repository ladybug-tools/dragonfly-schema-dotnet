
# DragonflySchema.Model.Story

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. | 
**Room2ds** | [**List&lt;Room2D&gt;**](Room2D.md) | An array of dragonfly Room2D objects that together form an entire story of a building. | 
**Properties** | [**StoryPropertiesAbridged**](StoryPropertiesAbridged.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**DisplayName** | **string** | Display name of the object with no character restrictions. | [optional] 
**UserData** | [**Object**](.md) | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 
**Type** | **string** |  | [optional] [default to "Story"]
**FloorToFloorHeight** | **double** | A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If None, this value will be the maximum floor_to_ceiling_height of the input room_2ds. | [optional] 
**Multiplier** | **int** | An integer that denotes the number of times that this Story is repeated over the height of the building. | [optional] [default to 1]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

