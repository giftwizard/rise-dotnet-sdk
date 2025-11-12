# Org.OpenAPITools.Model.DelayAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OffsetExpression** | **string** | Value expressing the amount of time to wait from a specific date or from the time the action is executed. | [optional] 
**OffsetTimeUnit** | **string** | Time unit for delay offset. | [optional] 
**DueDateEpochExpression** | **string** | The action due date. If defined without an offset, the automation will wait until this date to execute the next step. If an offset is defined, it&#39;s calculated from this date. The date is expressed in the number of milliseconds since the Unix Epoch (1 January, 1970 UTC). | [optional] 
**PostActionIds** | **List&lt;string&gt;** | List of IDs of actions to run in parallel after the delay. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

