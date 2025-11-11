# Org.OpenAPITools.Model.Recipient1
The created Recipient.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Recipient ID. | [optional] [readonly] 
**Revision** | **string** | Revision number, which increments by 1 each time the Recipient is updated. To prevent conflicting changes, the current revision must be passed when updating the Recipient.  Ignored when creating a Recipient. | [optional] [readonly] 
**CreatedDate** | **DateTime** | Date and time the Recipient was created. | [optional] [readonly] 
**UpdatedDate** | **DateTime** | Date and time the Recipient was last updated. | [optional] [readonly] 
**Name** | **string** | The name of the recipient. | [optional] 
**Email** | **string** | The email of the recipient. | [optional] 
**GiftCardId** | **string** | The ID of the gift card that was sent to the recipient. | [optional] 
**GiftingDetails** | [**GiftingDetails1**](GiftingDetails1.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

