
# DragonflySchema.Model.LouversByCount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "LouversByCount"]
**Depth** | **double** | A number for the depth to extrude the louvers. | 
**Offset** | **double** | A number for the distance to louvers from the wall. | [optional] [default to 0D]
**Angle** | **double** | A number between -90 and 90 for the for an angle to rotate the louvers in degrees. 0 indicates louvers perpendicular to the wall. Positive values indicate a downward rotation. Negative values indicate an upward rotation. | [optional] [default to 0D]
**ContourVector** | **List&lt;double&gt;** | A list of two float values representing the (x, y) of a 2D vector for the direction along which contours are generated. (0, 1) will generate horizontal contours, (1, 0) will generate vertical contours, and (1, 1) will generate diagonal contours. | [optional] 
**FlipStartSide** | **bool** | Boolean to note whether the side the louvers start from should be flipped. Default is False to have contours on top or right. Setting to True will start contours on the bottom or left. | [optional] [default to false]
**LouverCount** | **int** | A positive integer for the number of louvers to generate. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

