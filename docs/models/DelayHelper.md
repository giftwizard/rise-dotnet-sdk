# Org.OpenAPITools.Model.DelayHelper

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleIdentifier** | **string** | jsonata expression, for example: triggerName + eventId | [optional] 
**Delay** | **Object** | decide how long we should wait | [optional] 
**PostActions** | **List&lt;Object&gt;** | Delay&#39;s post actions. | [optional] 
**Overrideable** | **bool** | Optional: if true, any new schedule with the same schedule identifier will override the existing one. If false, the new schedule will be ignored. | [optional] 
**PostActionsIds** | **List&lt;string&gt;** | Delay&#39;s post actions ids. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

