
# DragonflySchema.Model.GriddedSkylightRatio

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WindowRatio** | **double** | A number between 0 and 0.75 for the ratio between the skylight area and the total Roof face area. | 
**Type** | **string** |  | [optional] [readonly] [default to "GriddedSkylightRatio"]
**Spacing** | [**AnyOfAutocalculatenumber**](AnyOfAutocalculatenumber.md) | A number for the spacing between the centers of each grid cell. This should be less than a third of the dimension of the Roof geometry if multiple, evenly-spaced skylights are desired. If Autocalculate, a spacing of one third the smaller dimension of the parent Roof will be automatically assumed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

