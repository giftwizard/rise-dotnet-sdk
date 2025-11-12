# Org.OpenAPITools.Model.ActivationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivationId** | **string** | Activation&#39;s ID. | [optional] 
**ConfigurationId** | **string** | Configuration&#39;s ID. | [optional] 
**ConfigurationCorrelationId** | **string** |  | [optional] 
**EventName** | **string** | Received event name. | [optional] 
**EventSlug** | **string** | Received event slug. | [optional] 
**EventPayload** | **string** | Received event payload. | [optional] 
**Actions** | **List&lt;Object&gt;** | List of action data. | [optional] 
**ExternalId** | **string** | External ID. | [optional] 
**Source** | **Object** | The source of this activation | [optional] 
**ActionsMap** | **Object** | Actions tree | [optional] 
**Automation** | **Object** | Automation V2. Used for reporting domain event until activation request will be deprecated. | [optional] 
**TriggerSchema** | **Object** | Trigger entity for the activation, available for v2 and v3 automations only | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

