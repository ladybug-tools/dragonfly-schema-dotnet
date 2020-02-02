
# DragonflyDotNet.Model.Model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters. | 
**Buildings** | [**List&lt;Building&gt;**](Building.md) | A list of Buildings in the model. | 
**Properties** | [**ModelProperties**](ModelProperties.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**DisplayName** | **string** | Display name of the object with no restrictions. | [optional] 
**Type** | **string** |  | [optional] [default to "Model"]
**ContextShades** | [**List&lt;ContextShade&gt;**](ContextShade.md) | A list of ContextShades in the model. | [optional] 
**NorthAngle** | **double** | The clockwise north direction in degrees. | [optional] [default to 0M]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

