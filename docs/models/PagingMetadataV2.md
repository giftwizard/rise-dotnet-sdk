# Org.OpenAPITools.Model.PagingMetadataV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Count** | **int** | Number of items returned in the response. | [optional] 
**Offset** | **int** | Offset that was requested. | [optional] 
**Total** | **int** | Total number of items that match the query. Returned if offset paging is used and the &#x60;tooManyToCount&#x60; flag is not set. | [optional] 
**TooManyToCount** | **bool** | Flag that indicates the server failed to calculate the &#x60;total&#x60; field. | [optional] 
**Cursors** | **Object** | Cursors to navigate through the result pages using &#x60;next&#x60; and &#x60;prev&#x60;. Returned if cursor paging is used. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

