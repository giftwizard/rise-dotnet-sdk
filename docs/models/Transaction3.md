# Org.OpenAPITools.Model.Transaction3
The Transaction to be created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of transaction. | 
**GiftCardId** | **string** | Unique ID of the gift card associated with this transaction. | 
**Amount** | **string** | Transaction amount. | 
**Id** | **string** | Transaction unique id. | [optional] [readonly] 
**CreatedDate** | **DateTime** | Transaction creation date. | [optional] [readonly] 
**OperationType** | **string** | Indicates whether the transaction adds or subtracts from the GiftCard balance. | [optional] [readonly] 
**IdempotencyKey** | **string** | Idempotency key, to prevent duplicate creation. | [optional] 
**UpdatedBalance** | **string** | Gift card Balance after this transaction operation. | [optional] [readonly] 
**SourceInfo** | [**TransactionSourceInfo1**](TransactionSourceInfo1.md) |  | [optional] 
**ExternalEvent** | [**ExternalEvent1**](ExternalEvent1.md) |  | [optional] 
**ExternalId** | **string** | ID of the transaction in a 3rd party system if created there. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

