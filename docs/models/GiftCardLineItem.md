# Org.OpenAPITools.Model.GiftCardLineItem
The details of an order line item that is a Gift Card.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Line Item ID in Rise. | [optional] [readonly] 
**SourceLineItemId** | **string** | Line Item ID in Source Channel. | [optional] 
**SourceVariantId** | **string** | Product Variant ID in Source Channel. | [optional] 
**GiftingInfo** | **Object** | The line Item&#39;s Gifting Information. | [optional] 
**Quantity** | **int** | Number of Gift Cards to create for this Line Item. | [optional] 
**FulfilledQuantity** | **int** | Number of Gift Cards that were already fulfilled for this Line Item. | [optional] [readonly] 
**Price** | **string** | Price of the Line Item. | [optional] 
**GiftCardInitialValue** | **string** | The initial value to apply to the Gift Card. | [optional] 
**UpdatedDate** | **DateTime** | Date and time the Line Item was last updated. | [optional] [readonly] 
**FulfilledData** | **Object** | Data about the gift cards that were already fulfilled for this Line Item. | [optional] [readonly] 
**GiftCardExpiration** | **Object** | The expiration date to apply to the Gift Card. | [optional] 
**SideEffects** | **Object** | Side effect for the gift card creation flow. | [optional] 
**GiftCardEncryptedCode** | **string** | The encrypted code to create the Gift Card with. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

