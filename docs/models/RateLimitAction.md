# Org.OpenAPITools.Model.RateLimitAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxActivationsExpression** | **string** | The maximum number of activations allowed for the action. | [optional] 
**RateLimitDurationExpression** | **string** | Duration of the rate limiting window, expressed in selected time unit. If no value is set, then there is no time limit on the rate limiter. | [optional] 
**RateLimitDurationTimeUnit** | **string** | Time unit for the rate limit duration. | [optional] 
**UniqueIdentifierExpression** | **string** | Unique identifier of each activation by which rate limiter counts activations. | [optional] 
**PostActionIds** | **List&lt;string&gt;** | List of IDs of actions to run in parallel once the action completes. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

