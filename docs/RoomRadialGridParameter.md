
# DragonflySchema.Model.RoomRadialGridParameter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Offset** | **double** | A number for how far to offset the grid from the Room2D floors. (Default: 1.0, suitable for Models in Meters). | [optional] [default to 1.0D]
**WallOffset** | **double** | A number for the distance at which sensors close to walls should be removed. Note that this option has no effect unless the value is more than half of the dimension. | [optional] [default to 0D]
**DirCount** | **int** | A positive integer for the number of radial directions to be generated around each position. | [optional] [default to 8]
**StartVector** | **List&lt;double&gt;** | A vector as 3 (x, y, z) values to set the start direction of the generated directions. This can be used to orient the resulting sensors to specific parts of the scene. It can also change the elevation of the resulting directions since this start vector will always be rotated in the XY plane to generate the resulting directions. | [optional] 
**MeshRadius** | [**AnyOfAutocalculatenumber**](AnyOfAutocalculatenumber.md) | An optional number to override the radius of the meshes generated around each sensor. If Autocalculate, it will be equal to 45 percent of the grid dimension. | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "RoomRadialGridParameter"]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

