
# DragonflySchema.Model.ModelEnergyProperties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] [default to "ModelEnergyProperties"]
**GlobalConstructionSet** | [**GlobalConstructionSet**](GlobalConstructionSet.md) | Global Energy construction set. | [optional] [readonly] 
**ConstructionSets** | [**List&lt;AnyOfConstructionSetAbridgedConstructionSet&gt;**](AnyOfConstructionSetAbridgedConstructionSet.md) | List of all ConstructionSets in the Model. | [optional] 
**Constructions** | [**List&lt;AnyOfOpaqueConstructionAbridgedWindowConstructionAbridgedShadeConstructionAirBoundaryConstructionAbridgedOpaqueConstructionWindowConstructionAirBoundaryConstruction&gt;**](AnyOfOpaqueConstructionAbridgedWindowConstructionAbridgedShadeConstructionAirBoundaryConstructionAbridgedOpaqueConstructionWindowConstructionAirBoundaryConstruction.md) | A list of all unique constructions in the model. This includes constructions across all the Model construction_sets. | [optional] 
**Materials** | [**List&lt;AnyOfEnergyMaterialEnergyMaterialNoMassEnergyMaterialVegetationEnergyWindowMaterialGlazingEnergyWindowMaterialSimpleGlazSysEnergyWindowMaterialGasEnergyWindowMaterialGasMixtureEnergyWindowMaterialGasCustomEnergyWindowMaterialBlindEnergyWindowMaterialShade&gt;**](AnyOfEnergyMaterialEnergyMaterialNoMassEnergyMaterialVegetationEnergyWindowMaterialGlazingEnergyWindowMaterialSimpleGlazSysEnergyWindowMaterialGasEnergyWindowMaterialGasMixtureEnergyWindowMaterialGasCustomEnergyWindowMaterialBlindEnergyWindowMaterialShade.md) | A list of all unique materials in the model. This includes materials needed to make the Model constructions. | [optional] 
**Hvacs** | [**List&lt;AnyOfIdealAirSystemAbridgedVAVPVAVPSZPTACForcedAirFurnaceFCUwithDOASAbridgedWSHPwithDOASAbridgedVRFwithDOASAbridgedRadiantwithDOASAbridgedFCUWSHPVRFBaseboardEvaporativeCoolerResidentialWindowACGasUnitHeaterRadiant&gt;**](AnyOfIdealAirSystemAbridgedVAVPVAVPSZPTACForcedAirFurnaceFCUwithDOASAbridgedWSHPwithDOASAbridgedVRFwithDOASAbridgedRadiantwithDOASAbridgedFCUWSHPVRFBaseboardEvaporativeCoolerResidentialWindowACGasUnitHeaterRadiant.md) | List of all HVAC systems in the Model. | [optional] 
**Shws** | [**List&lt;SHWSystem&gt;**](SHWSystem.md) | List of all Service Hot Water (SHW) systems in the Model. | [optional] 
**ProgramTypes** | [**List&lt;AnyOfProgramTypeAbridgedProgramType&gt;**](AnyOfProgramTypeAbridgedProgramType.md) | List of all ProgramTypes in the Model. | [optional] 
**Schedules** | [**List&lt;AnyOfScheduleRulesetAbridgedScheduleFixedIntervalAbridgedScheduleRulesetScheduleFixedInterval&gt;**](AnyOfScheduleRulesetAbridgedScheduleFixedIntervalAbridgedScheduleRulesetScheduleFixedInterval.md) | A list of all unique schedules in the model. This includes schedules across all HVAC systems, ProgramTypes and ContextShades. | [optional] 
**ScheduleTypeLimits** | [**List&lt;ScheduleTypeLimit&gt;**](ScheduleTypeLimit.md) | A list of all unique ScheduleTypeLimits in the model. This all ScheduleTypeLimits needed to make the Model schedules. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

