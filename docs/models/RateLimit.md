# Org.OpenAPITools.Model.RateLimit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxActivationsExpression** | **string** | Value expressing the maximum number of times the trigger can be activated. | [optional] 
**DurationExpression** | **string** | Duration of the rate limiting window in the selected time unit. If no value is set, the rate limit is permanent. | [optional] 
**DurationTimeUnit** | **string** | Time unit for the rate limit duration. | [optional] 
**UniqueIdentifierExpression** | **string** | Unique identifier of each activation, by which rate limiter will count activations. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

