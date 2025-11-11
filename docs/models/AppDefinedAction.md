# Org.OpenAPITools.Model.AppDefinedAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppId** | **string** | ID of the app that defines the action. | [optional] 
**ActionKey** | **string** | Action key. | [optional] 
**InputMapping** | **Object** | Action input mapping. | [optional] 
**SkipConditionOrExpressionGroups** | **List&lt;Object&gt;** | Array of conditions determining whether to skip the action in the automation flow. The action will be skipped if any of the expression groups evaluate to &#x60;true&#x60;. Actions following a skipped action will still run. | [optional] 
**PostActionIds** | **List&lt;string&gt;** | List of IDs of actions to run in parallel once the action completes. | [optional] 
**OverrideOutputSchema** | **Object** | Optional output schema of the action. It will be used instead the action schema in case it&#39;s provided. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

