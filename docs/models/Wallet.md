# Org.OpenAPITools.Model.Wallet
A wallet represents a customer who has Store Credits. It contains information about the Gift Card associated with this wallet. It also contains a list of references to the customer in specific source channels (see CustomerReference object definition below).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Wallet ID. | [optional] [readonly] 
**Revision** | **string** | Represents the current state of an item. Each time the item is modified, its &#x60;revision&#x60; changes. for an update operation to succeed, you MUST pass the latest revision. | [optional] [readonly] 
**GiftCardId** | **string** | ID of the Gift Card associated with this Wallet. | [optional] [readonly] 
**CustomerReferences** | **List&lt;Object&gt;** | List of references to the customer in specific source channels. See definition below. | [optional] [readonly] 
**CreatedDate** | **DateTime** | The time this Wallet was created. | [optional] [readonly] 
**UpdatedDate** | **DateTime** | The time this Wallet was last updated. | [optional] [readonly] 
**GiftCardInfo** | **Object** | Information about the Gift Card associated with this Wallet. | [optional] [readonly] 
**PrimaryContactDetails** | **Object** |  | [optional] [readonly] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

