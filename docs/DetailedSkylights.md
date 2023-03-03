
# DragonflySchema.Model.DetailedSkylights

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Polygons** | **List&lt;List&lt;List&lt;double&gt;&gt;&gt;** | An array of arrays with each sub-array representing a polygonal boundary of a skylight. Each sub-array should consist of arrays representing points, which contain 2 values for 2D coordinates in the world XY system. These coordinate values should lie within the parent Room2D Polygon. | 
**Type** | **string** |  | [optional] [readonly] [default to "DetailedSkylights"]
**AreDoors** | **List&lt;bool&gt;** | An array of booleans that align with the polygons and note whether each of the polygons represents an overhead door (True) or a skylight (False). If None, it will be assumed that all polygons represent skylights and they will be translated to Apertures in any resulting Honeybee model. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

