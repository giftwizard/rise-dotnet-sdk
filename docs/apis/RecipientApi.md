# Org.OpenAPITools.Api.RecipientApi

All URIs are relative to *https://platform.rise.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRecipient**](RecipientApi.md#createrecipient) | **POST** /v1/rise/recipients |  |
| [**DeleteRecipient**](RecipientApi.md#deleterecipient) | **DELETE** /v1/rise/recipients/{recipientId} |  |
| [**GetRecipient**](RecipientApi.md#getrecipient) | **GET** /v1/rise/recipients/{recipientId} |  |
| [**QueryRecipients**](RecipientApi.md#queryrecipients) | **POST** /v1/rise/recipients/query |  |

<a id="createrecipient"></a>
# **CreateRecipient**
> CreateRecipientResponse1 CreateRecipient (RecipientGiftCardRecipientServiceV1RiseRecipientsPostCreateRecipientRequestBody recipientGiftCardRecipientServiceV1RiseRecipientsPostCreateRecipientRequestBody)



Creates a Recipient. Note: This method is already called by GiftCardOrderService when an order is fulfilled.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipientGiftCardRecipientServiceV1RiseRecipientsPostCreateRecipientRequestBody** | [**RecipientGiftCardRecipientServiceV1RiseRecipientsPostCreateRecipientRequestBody**](RecipientGiftCardRecipientServiceV1RiseRecipientsPostCreateRecipientRequestBody.md) |  |  |

### Return type

[**CreateRecipientResponse1**](CreateRecipientResponse1.md)

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

<a id="deleterecipient"></a>
# **DeleteRecipient**
> void DeleteRecipient (string recipientId)



Deletes a Recipient by ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipientId** | **string** | Id of the Recipient to delete. |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns an empty object. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getrecipient"></a>
# **GetRecipient**
> GetRecipientResponse1 GetRecipient (string recipientId)



Retrieves a Recipient by ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipientId** | **string** | ID of the Recipient to retrieve. |  |

### Return type

[**GetRecipientResponse1**](GetRecipientResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="queryrecipients"></a>
# **QueryRecipients**
> QueryRecipientsResponse1 QueryRecipients (RecipientGiftCardRecipientServiceV1RiseRecipientsQueryPostQueryRecipientsRequestBody recipientGiftCardRecipientServiceV1RiseRecipientsQueryPostQueryRecipientsRequestBody)



Retrieves a list of Recipients, given the provided paging, filtering, and sorting. To learn how to query Recipients, see [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **recipientGiftCardRecipientServiceV1RiseRecipientsQueryPostQueryRecipientsRequestBody** | [**RecipientGiftCardRecipientServiceV1RiseRecipientsQueryPostQueryRecipientsRequestBody**](RecipientGiftCardRecipientServiceV1RiseRecipientsQueryPostQueryRecipientsRequestBody.md) |  |  |

### Return type

[**QueryRecipientsResponse1**](QueryRecipientsResponse1.md)

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

