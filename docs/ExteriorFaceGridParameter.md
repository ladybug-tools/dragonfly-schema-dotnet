
# DragonflySchema.Model.ExteriorFaceGridParameter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "ExteriorFaceGridParameter"]
**Offset** | **double** | A number for how far to offset the grid from the Faces. (Default: 0.1, suitable for Models in Meters). | [optional] [default to 0.1D]
**FaceType** | **ExteriorFaceType** | Text to specify the type of face that will be used to generate grids. Note that only Faces with Outdoors boundary conditions will be used, meaning that most Floors will typically be excluded unless they represent the underside of a cantilever. | [optional] 
**PunchedGeometry** | **bool** | A boolean to note whether the punched_geometry of the faces should be used (True) with the areas of sub-faces removed from the grid or the full geometry should be used (False). | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

