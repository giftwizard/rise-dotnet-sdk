# Org.OpenAPITools.Model.GiftCard3
The updated GiftCard.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID of the Gift Card. | [optional] [readonly] 
**Code** | **string** | Gift Card code for redemption. | [optional] 
**InitialValue** | **string** | Initial value of the Gift Card. | [optional] 
**Balance** | **string** | Current balance of the Gift Card. | [optional] [readonly] 
**SourceInfo** | [**GiftCardSourceInfo1**](GiftCardSourceInfo1.md) |  | [optional] 
**Revision** | **string** | Gift Card revision. | [optional] [readonly] 
**Currency** | **string** | Gift Card currency. | [optional] 
**ExpirationDate** | **DateTime** | Gift Card expiration date. | [optional] 
**CreatedDate** | **DateTime** | Gift Card creation date. | [optional] [readonly] 
**UpdatedDate** | **DateTime** | Gift Card last update date. | [optional] [readonly] 
**LastTransactionId** | **string** | ID of the last transaction that modified the gift card balance. (**Deprecated**: Use &#x60;id&#x60; instead.) | [optional] [readonly] 
**DisableDate** | **DateTime** | Gift Card disable date, if the gift card was disabled. | [optional] [readonly] 
**IdempotencyKey** | **string** | Gift Card idempotency key, to prevent duplicate creation. | [optional] 
**CodeSuffix** | **string** | Last 4 characters of the gift card code for easier reference and searching. | [optional] [readonly] 
**TransactionDetails** | [**TransactionDetails1**](TransactionDetails1.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

