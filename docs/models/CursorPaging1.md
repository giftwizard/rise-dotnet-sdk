# Org.OpenAPITools.Model.CursorPaging1
Cursor token pointing to a page of results. Not used in the first request. Following requests use the cursor token and not `filter` or `sort`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Limit** | **int** | Number of items to load. | [optional] 
**Cursor** | **string** | Pointer to the next or previous page in the list of results.  You can get the relevant cursor token from the &#x60;pagingMetadata&#x60; object in the previous call&#39;s response. Not relevant for the first request. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

