# Org.OpenAPITools.Model.Trigger

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppId** | **string** | ID of the app that defines the trigger. | [optional] 
**TriggerKey** | **string** | Trigger key. | [optional] 
**Filters** | **List&lt;Object&gt;** | List of filters on schema fields. In order for the automation to run, all filter expressions must evaluate to &#x60;true&#x60; for a given payload. | [optional] 
**ScheduledEventOffset** | **Object** | Defines the time offset between the trigger date and when the automation runs. | [optional] 
**RateLimit** | **Object** | Limits the number of times an automation can be triggered. | [optional] 
**AutomationConfigMapping** | **Object** | An optional configuration, per automation, of a schema that is optionally offered by the trigger provider to affect the behavior of the trigger. For example, a trigger provider may offer a schema that allows the user to configure the trigger to happen at a certain time of day, He would define a schema with a field called \&quot;startDate\&quot; and using this parameter the user can define his preferred startDate, per automation. | [optional] 
**OverrideSchema** | **Object** | Optional schema of the trigger. It will be used instead the trigger schema in case it&#39;s provided. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

