
# DragonflySchema.Model.Room2DEnergyPropertiesAbridged

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "Room2DEnergyPropertiesAbridged"]
**ConstructionSet** | **string** | Name of a ConstructionSet to specify all constructions for the Room2D. If None, the Room2D will use the Story or Building construction_set or the Model global_construction_set. Any ConstructionSet assigned here will override those assigned to these objects. | [optional] 
**ProgramType** | **string** | Name of a ProgramType to specify all schedules and loads for the Room2D. If None, the Room2D will have no loads or setpoints. | [optional] 
**Hvac** | **string** | An optional identifier of a HVAC system (such as an IdealAirSystem) that specifies how the Room2D is conditioned. If None, it will be assumed that the Room2D is not conditioned. | [optional] 
**Shw** | **string** | An optional identifier of a Service Hot Water (SHW) system that specifies how the hot water load of the Room is met. If None, the hot water load will be met with a generic system that only measures thermal loadand does not account for system efficiencies. | [optional] 
**WindowVentControl** | [**VentilationControlAbridged**](VentilationControlAbridged.md) | An optional VentilationControl object to dictate the opening of windows. If None, the windows will never open. | [optional] 
**WindowVentOpening** | [**VentilationOpening**](VentilationOpening.md) | An optional VentilationOpening to specify the operable portion of all windows of the Room2D. If None, the windows will never open. | [optional] 
**ProcessLoads** | [**List&lt;ProcessAbridged&gt;**](ProcessAbridged.md) | An optional list of Process objects for process loads within the room. These can represent wood burning fireplaces, kilns, manufacturing equipment, and various industrial processes. They can also be used to represent certain pieces of equipment to be separated from the other end uses, such as MRI machines, theatrical lighting, and elevators. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

