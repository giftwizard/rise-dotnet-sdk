# Org.OpenAPITools.Api.GiftCardOrderApi

All URIs are relative to *https://platform.rise.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrder**](GiftCardOrderApi.md#createorder) | **POST** /v1/rise/orders |  |
| [**FulfillOrder**](GiftCardOrderApi.md#fulfillorder) | **POST** /v1/rise/orders/fulfill |  |
| [**QueryOrders**](GiftCardOrderApi.md#queryorders) | **POST** /v1/rise/orders/query |  |
| [**UpdateOrder**](GiftCardOrderApi.md#updateorder) | **PATCH** /v1/rise/orders/{orderId} |  |
| [**UpdateOrderStatus**](GiftCardOrderApi.md#updateorderstatus) | **POST** /v1/rise/orders/status |  |

<a id="createorder"></a>
# **CreateOrder**
> CreateOrderResponse CreateOrder (GiftCardOrderGiftCardOrderServiceV1RiseOrdersPostCreateOrderRequestBody giftCardOrderGiftCardOrderServiceV1RiseOrdersPostCreateOrderRequestBody)



Creates an Order for a Rise Gift Card.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardOrderGiftCardOrderServiceV1RiseOrdersPostCreateOrderRequestBody** | [**GiftCardOrderGiftCardOrderServiceV1RiseOrdersPostCreateOrderRequestBody**](GiftCardOrderGiftCardOrderServiceV1RiseOrdersPostCreateOrderRequestBody.md) |  |  |

### Return type

[**CreateOrderResponse**](CreateOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="fulfillorder"></a>
# **FulfillOrder**
> void FulfillOrder (GiftCardOrderGiftCardOrderServiceV1RiseOrdersFulfillPostFulfillOrderRequestBody giftCardOrderGiftCardOrderServiceV1RiseOrdersFulfillPostFulfillOrderRequestBody)



Fulfills an order in an async manner.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardOrderGiftCardOrderServiceV1RiseOrdersFulfillPostFulfillOrderRequestBody** | [**GiftCardOrderGiftCardOrderServiceV1RiseOrdersFulfillPostFulfillOrderRequestBody**](GiftCardOrderGiftCardOrderServiceV1RiseOrdersFulfillPostFulfillOrderRequestBody.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an empty object. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="queryorders"></a>
# **QueryOrders**
> QueryOrdersResponse1 QueryOrders (GiftCardOrderGiftCardOrderServiceV1RiseOrdersQueryPostQueryOrdersRequestBody giftCardOrderGiftCardOrderServiceV1RiseOrdersQueryPostQueryOrdersRequestBody)



Retrieves a list of Orders, given the provided paging, filtering, and sorting]. Up to 1,000 Orders can be returned per request. To learn how to query Orders, see [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardOrderGiftCardOrderServiceV1RiseOrdersQueryPostQueryOrdersRequestBody** | [**GiftCardOrderGiftCardOrderServiceV1RiseOrdersQueryPostQueryOrdersRequestBody**](GiftCardOrderGiftCardOrderServiceV1RiseOrdersQueryPostQueryOrdersRequestBody.md) |  |  |

### Return type

[**QueryOrdersResponse1**](QueryOrdersResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateorder"></a>
# **UpdateOrder**
> UpdateOrderResponse UpdateOrder (string orderId, GiftCardOrderGiftCardOrderServiceV1RiseOrdersOrderIdPatchUpdateOrderRequestBody giftCardOrderGiftCardOrderServiceV1RiseOrdersOrderIdPatchUpdateOrderRequestBody)



Updates a Rise Gift Card Order.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **orderId** | **string** | Order ID. |  |
| **giftCardOrderGiftCardOrderServiceV1RiseOrdersOrderIdPatchUpdateOrderRequestBody** | [**GiftCardOrderGiftCardOrderServiceV1RiseOrdersOrderIdPatchUpdateOrderRequestBody**](GiftCardOrderGiftCardOrderServiceV1RiseOrdersOrderIdPatchUpdateOrderRequestBody.md) |  |  |

### Return type

[**UpdateOrderResponse**](UpdateOrderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updateorderstatus"></a>
# **UpdateOrderStatus**
> void UpdateOrderStatus (GiftCardOrderGiftCardOrderServiceV1RiseOrdersStatusPostUpdateOrderStatusRequestBody giftCardOrderGiftCardOrderServiceV1RiseOrdersStatusPostUpdateOrderStatusRequestBody)



Updates order payment status and fulfills it accordingly, in an async manner.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardOrderGiftCardOrderServiceV1RiseOrdersStatusPostUpdateOrderStatusRequestBody** | [**GiftCardOrderGiftCardOrderServiceV1RiseOrdersStatusPostUpdateOrderStatusRequestBody**](GiftCardOrderGiftCardOrderServiceV1RiseOrdersStatusPostUpdateOrderStatusRequestBody.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an empty object. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

