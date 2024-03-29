
# DragonflySchema.Model.RectangularWindows

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Origins** | **List&lt;List&lt;double&gt;&gt;** | An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive. | 
**Widths** | **List&lt;double&gt;** | An array of positive numbers for the window widths. The length of this list must match the length of the origins. | 
**Heights** | **List&lt;double&gt;** | An array of positive numbers for the window heights. The length of this list must match the length of the origins. | 
**Type** | **string** |  | [optional] [readonly] [default to "RectangularWindows"]
**AreDoors** | **List&lt;bool&gt;** | An array of booleans that align with the origins and note whether each of the geometries represents a door (True) or a window (False). If None, it will be assumed that all geometries represent windows and they will be translated to Apertures in any resulting Honeybee model. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

