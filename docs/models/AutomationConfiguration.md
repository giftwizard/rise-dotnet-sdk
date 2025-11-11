# Org.OpenAPITools.Model.AutomationConfiguration
Automation runtime configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | Status of the automation on the site. | [optional] 
**Trigger** | **Object** | Automation trigger configuration. | [optional] 
**RootActionIds** | **List&lt;string&gt;** | List of IDs of root actions. Root actions are the first actions to run after the trigger. The actions in the list run in parallel. | [optional] 
**Actions** | [**Actions**](Actions.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

