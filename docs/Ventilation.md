
# DragonflySchema.Model.Ventilation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserData** | **Object** | Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list). | [optional] 
**Type** | **string** |  | [optional] [readonly] [default to "Ventilation"]
**FlowPerPerson** | **double** | Intensity of ventilation in[] m3/s per person]. Note that setting this value does not mean that ventilation is varied based on real-time occupancy but rather that the design level of ventilation is determined using this value and the People object of the Room. | [optional] [default to 0D]
**FlowPerArea** | **double** | Intensity of ventilation in [m3/s per m2 of floor area]. | [optional] [default to 0D]
**AirChangesPerHour** | **double** | Intensity of ventilation in air changes per hour (ACH) for the entire Room. | [optional] [default to 0D]
**FlowPerZone** | **double** | Intensity of ventilation in m3/s for the entire Room. | [optional] [default to 0D]
**Schedule** | [**AnyOfScheduleRulesetScheduleFixedInterval**](AnyOfScheduleRulesetScheduleFixedInterval.md) | Schedule for the ventilation over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the total design flow rate (determined from the sum of the other 4 fields) to yield a complete ventilation profile. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

