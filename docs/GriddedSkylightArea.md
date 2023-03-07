
# DragonflySchema.Model.GriddedSkylightArea

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SkylightArea** | **double** | A number for the skylight area in current model units. If this area is larger than the area of the roof that it is applied to, the skylight will fill the parent roof at a 99 percent ratio. | 
**Type** | **string** |  | [optional] [readonly] [default to "GriddedSkylightArea"]
**Spacing** | [**AnyOfAutocalculatenumber**](AnyOfAutocalculatenumber.md) | A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

