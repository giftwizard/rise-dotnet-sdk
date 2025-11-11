# Org.OpenAPITools.Model.WalletAction4
WalletAction is the main entity of WalletActionService. It represents a Store Credit that adds to the balance of a customer's wallet. It contains information about the amount and expiration date (if applicable) of the Store Credit, the context of its source (e.g. refund, workflow, etc.), and its status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | WalletAction ID. | [optional] [readonly] 
**Revision** | **string** | Represents the current state of an item. Each time the item is modified, its &#x60;revision&#x60; changes. For an update operation to succeed, you MUST pass the latest revision. | [optional] [readonly] 
**CreatedDate** | **DateTime** | Represents the time this WalletAction was created. | [optional] [readonly] 
**UpdatedDate** | **DateTime** | Represents the time this WalletAction was last updated. | [optional] [readonly] 
**StartDate** | **DateTime** | Represents the time at which the WalletAction&#39;s amount will be added to the account. Defaults to immediately. | [optional] 
**ExpirationDate** | **DateTime** | Represents the time at which the unused balance of the WalletAction will be deducted from the account. Defaults to never. | [optional] 
**DisableDate** | **DateTime** | Represents the time at which the WalletAction was manually disabled, if applicable. | [optional] [readonly] 
**Amount** | **string** | The amount to be added to the Wallet. | [optional] 
**Note** | **string** | Free text comment regarding the WalletAction context (**Deprecated**: Use &#x60;note&#x60; instead.) | [optional] 
**Type** | **string** | Indicates the kind of the specific WalletAction (**Deprecated**) | [optional] 
**WalletActionStarted** | [**WalletActionExecutionDetails1**](WalletActionExecutionDetails1.md) |  | [optional] 
**WalletActionEnded** | [**WalletActionExecutionDetails2**](WalletActionExecutionDetails2.md) |  | [optional] 
**Status** | **string** | The current status of the WalletAction. Set to PENDING when the WalletAction is created and updated to ACTIVE when the amount is added to the wallet. | [optional] [readonly] 
**Source** | [**ActionInitiator2**](ActionInitiator2.md) |  | [optional] 
**Notifications** | [**Notifications1**](Notifications1.md) |  | [optional] 
**Liability** | **bool** | Indicates whether the WalletAction is a liability. The default is false. | [optional] 
**StoreCreditContext** | [**StoreCreditContext2**](StoreCreditContext2.md) |  | [optional] 
**ExternalEvent** | [**ExternalEvent2**](ExternalEvent2.md) |  | [optional] 
**WalletId** | **string** | ID of the wallet to which the WalletAction belongs. | [optional] 
**IdempotencyKey** | **string** | Unique key to identify the WalletAction, used to prevent duplicate WalletActions from being created in case of retries or network issues. The key should be unique for each WalletAction and should not be reused. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

