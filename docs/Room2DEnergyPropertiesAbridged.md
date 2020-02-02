
# DragonflyDotNet.Model.Room2DEnergyPropertiesAbridged

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [default to "Room2DEnergyPropertiesAbridged"]
**ConstructionSet** | **string** | Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects. | [optional] 
**ProgramType** | **string** | Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints. | [optional] 
**Hvac** | **string** | An optional name of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

