# Org.OpenAPITools.Model.ItemMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Item ID. Should always be available, unless it&#39;s impossible (for example, when failing to create an item). | [optional] 
**OriginalIndex** | **int** | Index of the item within the request array. Allows for correlation between request and response items. | [optional] 
**Success** | **bool** | Whether the requested action was successful for this item. When &#x60;false&#x60;, the &#x60;error&#x60; field is populated. | [optional] 
**Error** | **Object** | Details about the error in case of failure. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

