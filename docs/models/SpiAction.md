# Org.OpenAPITools.Model.SpiAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppDefId** | **string** | The App Def Id of the action provider | [optional] 
**ActionKey** | **string** | Identifier for this action - human readable action key - unique per app def id | [optional] 
**UserActionConfig** | **string** | The configuration of the user for this action, can include params that are taken from the trigger event payload | [optional] 
**PostActions** | **List&lt;Object&gt;** | The post action to execute after this action | [optional] 
**UserOutputActionConfig** | **string** | The output configuration of the user for this action, can include params that are taken from the trigger event payload | [optional] 
**SkipConditionExpression** | **string** | optional skip condition expression for current action decides whether to skip the action before executing it&#39;s post actions | [optional] 
**PostActionsIds** | **List&lt;string&gt;** | Action&#39;s post actions ids. | [optional] 
**Namespace** | **string** | The namespace of the action | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

