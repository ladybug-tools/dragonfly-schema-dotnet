
# DragonflySchema.Model.Story

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters. | 
**Room2ds** | [**List&lt;Room2D&gt;**](Room2D.md) | An array of dragonfly Room2D objects that together form an entire story of a building. | 
**Properties** | [**StoryPropertiesAbridged**](StoryPropertiesAbridged.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**DisplayName** | **string** | Display name of the object with no restrictions. | [optional] 
**Type** | **string** |  | [optional] [default to "Story"]
**FloorToFloorHeight** | **double** | A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If None, this value will be the maximum floor_to_ceiling_height of the input room_2ds. | [optional] 
**Multiplier** | **int** | An integer that denotes the number of times that this Story is repeated over the height of the building. | [optional] [default to 1]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

