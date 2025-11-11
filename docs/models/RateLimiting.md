# Org.OpenAPITools.Model.RateLimiting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MaxNumOfActivations** | **decimal** | The maximum number of activations allowed in the given time frame | [optional] 
**MaxNumOfActivationsExpression** | **string** | Optional, used if provided: A jsonata expression that evaluates to the maximum number of activations allowed in the given time frame | [optional] 
**TimeFrameInMinutes** | **int** | If given - the time frame in minutes, otherwise, for life | [optional] 
**TimeFrameInMinutesExpression** | **string** | Optional, used if provided - A jsonata expression that evaluates to the time frame in minutes, otherwise, for life | [optional] 
**KeyJsonata** | **string** | The jsonata to use to extract the entity/resource key from the enriched event payload | [optional] 
**PostActions** | **List&lt;Object&gt;** | The actions to perform if this rate limiting action succeeded - meaning we are still in the allowed number of activations in the given time frame | [optional] 
**PostActionsIds** | **List&lt;string&gt;** | The ids of actions to perform if this rate limiting action succeeded - meaning we are still in the allowed number of activations in the given time frame | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

