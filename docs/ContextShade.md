
# DragonflyDotNet.Model.ContextShade

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters. | 
**Geometry** | [**List&lt;Face3D&gt;**](Face3D.md) | An array of planar Face3Ds that together represent the context shade. | 
**Properties** | [**ContextShadePropertiesAbridged**](ContextShadePropertiesAbridged.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**DisplayName** | **string** | Display name of the object with no restrictions. | [optional] 
**Type** | **string** |  | [optional] [default to "ContextShade"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

