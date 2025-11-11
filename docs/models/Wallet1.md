# Org.OpenAPITools.Model.Wallet1
The wallet to which the wallet action was added.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Wallet ID. | [optional] [readonly] 
**Revision** | **string** | Represents the current state of an item. Each time the item is modified, its &#x60;revision&#x60; changes. for an update operation to succeed, you MUST pass the latest revision. | [optional] [readonly] 
**GiftCardId** | **string** | ID of the Gift Card associated with this Wallet. | [optional] [readonly] 
**CustomerReferences** | [**List&lt;CustomerReference1&gt;**](CustomerReference1.md) | List of references to the customer in specific source channels. See definition below. | [optional] [readonly] 
**CreatedDate** | **DateTime** | The time this Wallet was created. | [optional] [readonly] 
**UpdatedDate** | **DateTime** | The time this Wallet was last updated. | [optional] [readonly] 
**GiftCardInfo** | [**GiftCardInfo1**](GiftCardInfo1.md) |  | [optional] 
**PrimaryContactDetails** | [**ContactDetails1**](ContactDetails1.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

