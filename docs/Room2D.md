
# DragonflySchema.Model.Room2D

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **string** | Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. | 
**DisplayName** | **string** | Display name of the object with no character restrictions. | [optional] 
**UserData** | [**Object**](.md) | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 
**FloorBoundary** | **List&lt;List&lt;double&gt;&gt;** | A list of 2D points representing the outer boundary vertices of the Room2D. The list should include at least 3 points and each point should be a list of 2 (x, y) values. | 
**FloorHeight** | **double** | A number to indicate the height of the floor plane in the Z axis. | 
**FloorToCeilingHeight** | **double** | A number for the distance between the floor and the ceiling. | 
**Properties** | [**Room2DPropertiesAbridged**](Room2DPropertiesAbridged.md) | Extension properties for particular simulation engines (Radiance, EnergyPlus). | 
**Type** | **string** |  | [optional] [readonly] [default to "Room2D"]
**FloorHoles** | **List&lt;List&lt;List&lt;double&gt;&gt;&gt;** | Optional list of lists with one list for each hole in the floor plate. Each hole should be a list of at least 2 points and each point a list of 2 (x, y) values. If None, it will be assumed that there are no holes in the floor plate. | [optional] 
**IsGroundContact** | **bool** | A boolean noting whether this Room2D has its floor in contact with the ground. | [optional] [default to false]
**IsTopExposed** | **bool** | A boolean noting whether this Room2D has its ceiling exposed to the outdoors. | [optional] [default to false]
**BoundaryConditions** | [**List&lt;AnyOfGroundOutdoorsAdiabaticSurface&gt;**](AnyOfGroundOutdoorsAdiabaticSurface.md) | A list of boundary conditions that match the number of segments in the input floor_geometry + floor_holes. These will be used to assign boundary conditions to each of the walls of the Room in the resulting model. Their order should align with the order of segments in the floor_boundary and then with each hole segment. If None, all boundary conditions will be Outdoors or Ground depending on whether ceiling height of the room is at or below 0 (the assumed ground plane). | [optional] 
**WindowParameters** | [**List&lt;AnyOfSingleWindowSimpleWindowRatioRepeatingWindowRatioRectangularWindowsDetailedWindows&gt;**](AnyOfSingleWindowSimpleWindowRatioRepeatingWindowRatioRectangularWindowsDetailedWindows.md) | A list of WindowParameter objects that dictate how the window geometries will be generated for each of the walls. If None, no windows will exist over the entire Room2D. | [optional] 
**ShadingParameters** | [**List&lt;AnyOfExtrudedBorderOverhangLouversByDistanceLouversByCount&gt;**](AnyOfExtrudedBorderOverhangLouversByDistanceLouversByCount.md) | A list of ShadingParameter objects that dictate how the shade geometries will be generated for each of the walls. If None, no shades will exist over the entire Room2D. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

