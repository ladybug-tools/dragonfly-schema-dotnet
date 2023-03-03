
# DragonflySchema.Model.ModelRadianceProperties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "ModelRadianceProperties"]
**GlobalModifierSet** | [**GlobalModifierSet**](GlobalModifierSet.md) | Global Radiance modifier set. | [optional] [readonly] 
**ModifierSets** | [**List&lt;AnyOfModifierSetModifierSetAbridged&gt;**](AnyOfModifierSetModifierSetAbridged.md) | List of all ModifierSets in the Model. | [optional] 
**Modifiers** | [**List&lt;AnyOfPlasticGlassBSDFGlowLightTransMetalVoidMirror&gt;**](AnyOfPlasticGlassBSDFGlowLightTransMetalVoidMirror.md) | A list of all unique modifiers in the model. This includes modifiers across all the Model modifier_sets. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

