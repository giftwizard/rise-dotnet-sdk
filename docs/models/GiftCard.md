# Org.OpenAPITools.Model.GiftCard
GiftCard is the main entity of GiftCardService. It contains basic information such as gift card code, balance, and expiration date, as well as information about the source of the gift card (e.g., purchase, migration, etc.).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID of the Gift Card. | [optional] [readonly] 
**Code** | **string** | Gift Card code for redemption. | [optional] 
**InitialValue** | **string** | Initial value of the Gift Card. | [optional] 
**Balance** | **string** | Current balance of the Gift Card. | [optional] [readonly] 
**SourceInfo** | **Object** | Information about the source of the gift card. | [optional] 
**Revision** | **string** | Gift Card revision. | [optional] [readonly] 
**Currency** | **string** | Gift Card currency. | [optional] 
**ExpirationDate** | **DateTime** | Gift Card expiration date. | [optional] 
**CreatedDate** | **DateTime** | Gift Card creation date. | [optional] [readonly] 
**UpdatedDate** | **DateTime** | Gift Card last update date. | [optional] [readonly] 
**LastTransactionId** | **string** | ID of the last transaction that modified the gift card balance. | [optional] [readonly] 
**DisableDate** | **DateTime** | Gift Card disable date, if the gift card was disabled. | [optional] [readonly] 
**IdempotencyKey** | **string** | Gift Card idempotency key, to prevent duplicate creation. | [optional] 
**CodeSuffix** | **string** | Last 4 characters of the gift card code for easier reference and searching. | [optional] [readonly] 
**TransactionDetails** | **Object** | Transaction details related to the gift card. | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

