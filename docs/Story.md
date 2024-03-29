
# DragonflySchema.Model.Story

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. | 
**DisplayName** | **string** | Display name of the object with no character restrictions. | [optional] 
**UserData** | **Object** | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 
**Room2ds** | [**List&lt;Room2D&gt;**](Room2D.md) | An array of dragonfly Room2D objects that together form an entire story of a building. | 
**Properties** | [**StoryPropertiesAbridged**](StoryPropertiesAbridged.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**Type** | **string** |  | [optional] [readonly] [default to "Story"]
**FloorToFloorHeight** | [**AnyOfAutocalculatenumber**](AnyOfAutocalculatenumber.md) | A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If Autocalculate, this value will be the maximum floor_to_ceiling_height of the input room_2ds. | [optional] 
**FloorHeight** | [**AnyOfAutocalculatenumber**](AnyOfAutocalculatenumber.md) | A number to indicate the height of the floor plane in the Z axis.If Autocalculate, this will be the minimum floor height of all the room_2ds, which is suitable for cases where there are no floor plenums. | [optional] 
**Multiplier** | **int** | An integer that denotes the number of times that this Story is repeated over the height of the building. | [optional] [default to 1]
**Roof** | [**RoofSpecification**](RoofSpecification.md) | An optional RoofSpecification object containing geometry for generating sloped roofs over the Story. The RoofSpecification will only affect the child Room2Ds that have a True is_top_exposed property and it will only be utilized in translation to Honeybee when the Story multiplier is 1. If None, all Room2D ceilings will be flat. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

