
# DragonflySchema.Model.ShadeEnergyPropertiesAbridged

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "ShadeEnergyPropertiesAbridged"]
**Construction** | **string** | Identifier of a ShadeConstruction to set the reflectance and specularity of the Shade. If None, the construction is set by theparent Room construction_set, the Model global_construction_set or (in the case fo an orphaned shade) the EnergyPlus default of 0.2 diffuse reflectance. | [optional] 
**TransmittanceSchedule** | **string** | Identifier of a schedule to set the transmittance of the shade, which can vary throughout the simulation. If None, the shade will be completely opaque. | [optional] 
**PvProperties** | [**PVProperties**](PVProperties.md) | An optional PVProperties object to specify photovoltaic behavior of the Shade. If None, the Shade will have no Photovoltaic properties. Note that the normal of the Shade is important in determining the performance of the shade as a PV geometry. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

