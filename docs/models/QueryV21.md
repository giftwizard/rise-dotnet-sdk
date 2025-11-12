# Org.OpenAPITools.Model.QueryV21
WQL expression.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filter** | [**Filter**](Filter.md) |  | [optional] 
**Sort** | [**List&lt;Sorting1&gt;**](Sorting1.md) | Sort object.  Learn more about [sorting](https://dev.wix.com/docs/rest/articles/getting-started/api-query-language#sorting). | [optional] 
**Fields** | **List&lt;string&gt;** | Array of projected fields. A list of specific field names to return. If &#x60;fieldsets&#x60; are also specified, the union of &#x60;fieldsets&#x60; and &#x60;fields&#x60; is returned. | [optional] 
**Fieldsets** | **List&lt;string&gt;** | Array of named, predefined sets of projected fields. A array of predefined named sets of fields to be returned. Specifying multiple &#x60;fieldsets&#x60; will return the union of fields from all sets. If &#x60;fields&#x60; are also specified, the union of &#x60;fieldsets&#x60; and &#x60;fields&#x60; is returned. | [optional] 
**Paging** | [**PagingPaging**](PagingPaging.md) |  | [optional] 
**CursorPaging** | [**PagingMethodCursorPaging**](PagingMethodCursorPaging.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

