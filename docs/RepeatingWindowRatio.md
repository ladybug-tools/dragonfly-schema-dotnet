
# DragonflySchema.Model.RepeatingWindowRatio

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WindowRatio** | **double** | A number between 0 and 1 for the ratio between the window area and the parent wall surface area. | 
**WindowHeight** | **double** | A number for the target height of the windows. Note that, if the window ratio is too large for the height, the ratio will take precedence and the actual window_height will be larger than this value. | 
**SillHeight** | **double** | A number for the target height above the bottom edge of the wall to start the windows. Note that, if the ratio is too large for the height, the ratio will take precedence and the sill_height will be smaller than this value. | 
**HorizontalSeparation** | **double** | A number for the target separation between individual window centerlines.  If this number is larger than the parent rectangle base, only one window will be produced. | 
**Type** | **string** |  | [optional] [default to "RepeatingWindowRatio"]
**VerticalSeparation** | **double** | An optional number to create a single vertical separation between top and bottom windows. | [optional] [default to 0M]

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

