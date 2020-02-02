
# DragonflyDotNet.Model.ModelEnergyProperties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Constructions** | [**List&lt;AnyOfOpaqueConstructionAbridgedWindowConstructionAbridgedShadeConstruction&gt;**](AnyOfOpaqueConstructionAbridgedWindowConstructionAbridgedShadeConstruction.md) | A list of all unique constructions in the model. This includes constructions across all the Model construction_sets. | 
**Materials** | [**List&lt;AnyOfEnergyMaterialEnergyMaterialNoMassEnergyWindowMaterialGasEnergyWindowMaterialGasCustomEnergyWindowMaterialGasMixtureEnergyWindowMaterialSimpleGlazSysEnergyWindowMaterialBlindEnergyWindowMaterialGlazingEnergyWindowMaterialShade&gt;**](AnyOfEnergyMaterialEnergyMaterialNoMassEnergyWindowMaterialGasEnergyWindowMaterialGasCustomEnergyWindowMaterialGasMixtureEnergyWindowMaterialSimpleGlazSysEnergyWindowMaterialBlindEnergyWindowMaterialGlazingEnergyWindowMaterialShade.md) | A list of all unique materials in the model. This includes materials needed to make the Model constructions. | 
**Type** | **string** |  | [optional] [default to "ModelEnergyProperties"]
**TerrainType** | **string** | Text for the terrain in which the model sits. This is used to determine the wind profile over the height of the buildings. | [optional] [default to TerrainTypeEnum.City]
**GlobalConstructionSet** | **string** | Name for the ConstructionSet to be used for all objects lacking their own construction or a parent construction_set. This ConstructionSet must appear under the Model construction_sets. | [optional] 
**ConstructionSets** | [**List&lt;ConstructionSetAbridged&gt;**](ConstructionSetAbridged.md) | List of all ConstructionSets in the Model. | [optional] 
**Hvacs** | [**List&lt;IdealAirSystemAbridged&gt;**](IdealAirSystemAbridged.md) | List of all HVAC systems in the Model. | [optional] 
**ProgramTypes** | [**List&lt;ProgramTypeAbridged&gt;**](ProgramTypeAbridged.md) | List of all ProgramTypes in the Model. | [optional] 
**Schedules** | [**List&lt;AnyOfScheduleRulesetAbridgedScheduleFixedIntervalAbridged&gt;**](AnyOfScheduleRulesetAbridgedScheduleFixedIntervalAbridged.md) | A list of all unique schedules in the model. This includes schedules across all HVAC systems, ProgramTypes and ContextShades. | [optional] 
**ScheduleTypeLimits** | [**List&lt;ScheduleTypeLimit&gt;**](ScheduleTypeLimit.md) | A list of all unique ScheduleTypeLimits in the model. This all ScheduleTypeLimits needed to make the Model schedules. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

