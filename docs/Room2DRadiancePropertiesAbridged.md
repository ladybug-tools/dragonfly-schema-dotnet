
# DragonflySchema.Model.Room2DRadiancePropertiesAbridged

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "Room2DRadiancePropertiesAbridged"]
**ModifierSet** | **string** | Identifier of a ModifierSet to specify all modifiers for the Room2D. If None, the Room2D will use the Story or Building modifier_set or the Model global_modifier_set. Any ModifierSet assigned here will override those assigned to the parent objects. | [optional] 
**GridParameters** | [**List&lt;AnyOfRoomGridParameterRoomRadialGridParameterExteriorFaceGridParameterExteriorApertureGridParameter&gt;**](AnyOfRoomGridParameterRoomRadialGridParameterExteriorFaceGridParameterExteriorApertureGridParameter.md) | An optional list of GridParameter objects to describe how sensor grids should be generated for the Room2D. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

