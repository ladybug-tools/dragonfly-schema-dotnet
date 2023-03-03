
# DragonflySchema.Model.DetailedWindows

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Polygons** | **List&lt;List&lt;List&lt;double&gt;&gt;&gt;** | An array of arrays with each sub-array representing a polygonal boundary of a window. Each sub-array should consist of arrays representing points, which can either contain 2 values (indicating they are 2D vertices within the plane of a parent wall segment) or they can contain 3 values (indicating they are 3D world coordinates). For 2D points, the wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each point in the polygon should always be positive. Some sample code to convert from 2D vertices to 2D vertices in the plane of the wall can be found here: https://www.ladybug.tools/dragonfly-core/docs/dragonfly.windowparameter.html#dragonfly.windowparameter.DetailedWindows | 
**Type** | **string** |  | [optional] [readonly] [default to "DetailedWindows"]
**AreDoors** | **List&lt;bool&gt;** | An array of booleans that align with the polygons and note whether each of the polygons represents a door (True) or a window (False). If None, it will be assumed that all polygons represent windows and they will be translated to Apertures in any resulting Honeybee model. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

