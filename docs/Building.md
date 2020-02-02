
# DragonflyDotNet.Model.Building

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters. | 
**UniqueStories** | [**List&lt;Story&gt;**](Story.md) | An array of unique dragonfly Story objects that together form the entire building. Stories should generally be ordered from lowest floor to highest floor. Note that, if a given Story is repeated several times over the height of the building, the unique story included in this list should be the first (lowest) story of the repeated floors. | 
**DisplayName** | **string** | Display name of the object with no restrictions. | [optional] 
**Type** | **string** |  | [optional] [default to "Building"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

