# Org.OpenAPITools.Model.EntityUpdatedEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CurrentEntityAsJson** | **string** | Since platformized APIs only expose PATCH and not PUT we can&#39;t assume that the fields sent from the client are the actual diff. This means that to generate a list of changed fields (as opposed to sent fields) one needs to traverse both objects. We don&#39;t want to impose this on all developers and so we leave this traversal to the notification recipients which need it. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

