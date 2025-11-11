# Org.OpenAPITools.Model.GiftCardOrder3
A Gift Card Order is a reflection of an order in a Sales Channel that includes a Gift Card.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Order ID. | [optional] [readonly] 
**Revision** | **string** | Revision number, which increments by 1 each time the Order is updated. To prevent conflicting changes, the current revision must be passed when updating the Order.  Ignored when creating a Order. | [optional] [readonly] 
**CreatedDate** | **DateTime** | Date and time the Order was created. | [optional] [readonly] 
**UpdatedDate** | **DateTime** | Date and time the Order was last updated. | [optional] [readonly] 
**SourceChannelId** | **string** | Source sales channel, i.e. Shopify. | [optional] 
**SourceTenantId** | **string** | Tenant ID in source sales channel, i.e. shop ID. | [optional] 
**SourceOrderId** | **string** | Order ID in source sales channel. | [optional] 
**SourceOrderNumber** | **string** | The order number in source sales channel. | [optional] 
**TotalAmount** | **string** | The total amount of the order that contains the Gift Card. | [optional] 
**Currency** | **string** | The order&#39;s currency. | [optional] 
**Note** | **string** | Note to be added to the order. | [optional] 
**PaymentStatus** | **string** | The payment status of the order. | [optional] 
**FulfillmentStatus** | **string** | Fulfillment status of the order in Rise. | [optional] 
**Status** | **string** | Status of the order in Rise. | [optional] 
**BuyerInfo** | [**BuyerInfo1**](BuyerInfo1.md) |  | [optional] 
**ScheduleFulfillAt** | **DateTime** | Date and time to fulfill the order by creating Gift Cards. Default is now. | [optional] 
**RiseFulfilledAt** | **DateTime** | Date and time the order was fulfilled in Rise by creating Gift Cards. | [optional] [readonly] 
**SourceFulfilledAt** | **DateTime** | Date and time the order was marked fulfilled in the Source sales channel. | [optional] 
**LineItems** | [**List&lt;GiftCardLineItem1&gt;**](GiftCardLineItem1.md) | The line items in the order that are Gift Cards. | [optional] 
**FraudMessage** | **string** | The fraud message. | [optional] 
**FraudType** | **string** | The fraud logic type. | [optional] 
**SourceLocationId** | **string** | Location ID in Source. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

