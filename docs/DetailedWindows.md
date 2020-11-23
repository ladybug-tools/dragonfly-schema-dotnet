
# DragonflySchema.Model.DetailedWindows

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "DetailedWindows"]
**Polygons** | **List&lt;List&lt;List&lt;double&gt;&gt;&gt;** | An array of arrays with each sub-array representing a polygonal boundary of a window within the plane of the wall. Each sub-array should consist of at least three 2D points and each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Note that, if you are starting from 3D vertices of windows, you can use these window parameters to represent them. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

