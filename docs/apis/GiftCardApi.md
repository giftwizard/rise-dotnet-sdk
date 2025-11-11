# Org.OpenAPITools.Api.GiftCardApi

All URIs are relative to *https://platform.rise.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CountGiftCards**](GiftCardApi.md#countgiftcards) | **POST** /v1/rise/gift-cards/count |  |
| [**CreateGiftCard**](GiftCardApi.md#creategiftcard) | **POST** /v1/rise/gift-cards |  |
| [**DecreaseBalance**](GiftCardApi.md#decreasebalance) | **POST** /v1/rise/gift-cards/{transactionGiftCardId}/decrease |  |
| [**DisableGiftCard**](GiftCardApi.md#disablegiftcard) | **POST** /v1/rise/gift-cards/{giftCardId}/disable |  |
| [**GetGiftCard**](GiftCardApi.md#getgiftcard) | **GET** /v1/rise/gift-cards/{giftCardId} |  |
| [**IncreaseBalance**](GiftCardApi.md#increasebalance) | **POST** /v1/rise/gift-cards/{transactionGiftCardId}/increase |  |
| [**QueryGiftCards**](GiftCardApi.md#querygiftcards) | **POST** /v1/rise/gift-cards/query |  |
| [**SearchGiftCards**](GiftCardApi.md#searchgiftcards) | **POST** /v1/rise/gift-cards/search |  |
| [**UpdateGiftCard**](GiftCardApi.md#updategiftcard) | **PATCH** /v1/rise/gift-cards/{giftCardId} |  |

<a id="countgiftcards"></a>
# **CountGiftCards**
> CountGiftCardsResponse1 CountGiftCards (GiftCardGiftCardServiceV1RiseGiftCardsCountPostCountGiftCardsRequestBody giftCardGiftCardServiceV1RiseGiftCardsCountPostCountGiftCardsRequestBody)



TODO: change to Rise domain when it's ready Count GiftCards that match the given [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language) filter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardGiftCardServiceV1RiseGiftCardsCountPostCountGiftCardsRequestBody** | [**GiftCardGiftCardServiceV1RiseGiftCardsCountPostCountGiftCardsRequestBody**](GiftCardGiftCardServiceV1RiseGiftCardsCountPostCountGiftCardsRequestBody.md) |  |  |

### Return type

[**CountGiftCardsResponse1**](CountGiftCardsResponse1.md)

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

<a id="creategiftcard"></a>
# **CreateGiftCard**
> CreateGiftCardResponse1 CreateGiftCard (GiftCardGiftCardServiceV1RiseGiftCardsPostCreateGiftCardRequestBody giftCardGiftCardServiceV1RiseGiftCardsPostCreateGiftCardRequestBody)



Creates a new GiftCard.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardGiftCardServiceV1RiseGiftCardsPostCreateGiftCardRequestBody** | [**GiftCardGiftCardServiceV1RiseGiftCardsPostCreateGiftCardRequestBody**](GiftCardGiftCardServiceV1RiseGiftCardsPostCreateGiftCardRequestBody.md) |  |  |

### Return type

[**CreateGiftCardResponse1**](CreateGiftCardResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;INVALID_CODE&#x60;, &#x60;INVALID_EXPIRATION_DATE&#x60;, &#x60;EXISTING_IDEMPOTENCY_KEY&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="decreasebalance"></a>
# **DecreaseBalance**
> DecreaseBalanceResponse1 DecreaseBalance (string transactionGiftCardId, GiftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdDecreasePostDecreaseBalanceRequestBody giftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdDecreasePostDecreaseBalanceRequestBody)



Subtracts from the GiftCard balance and creates a balance Transaction.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionGiftCardId** | **string** | Unique ID of the gift card associated with this transaction. |  |
| **giftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdDecreasePostDecreaseBalanceRequestBody** | [**GiftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdDecreasePostDecreaseBalanceRequestBody**](GiftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdDecreasePostDecreaseBalanceRequestBody.md) |  |  |

### Return type

[**DecreaseBalanceResponse1**](DecreaseBalanceResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;EXISTING_IDEMPOTENCY_KEY&#x60;, &#x60;INSUFFICIENT_FUNDS&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="disablegiftcard"></a>
# **DisableGiftCard**
> DisableGiftCardResponse1 DisableGiftCard (string giftCardId, Object body)



Disable a GiftCard. It cannot be re-enabled.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardId** | **string** | The ID of the GiftCard to disable. |  |
| **body** | **Object** |  |  |

### Return type

[**DisableGiftCardResponse1**](DisableGiftCardResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **404** | Not Found - Resource not found  Possible error codes: &#x60;GIFT_CARD_NOT_FOUND&#x60; |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;GIFT_CARD_DISABLED&#x60;, &#x60;GIFT_CARD_EXPIRED&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getgiftcard"></a>
# **GetGiftCard**
> GetGiftCardResponse1 GetGiftCard (string giftCardId)



Get a GiftCard by ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardId** | **string** | The ID of the GiftCard to retrieve. |  |

### Return type

[**GetGiftCardResponse1**](GetGiftCardResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **404** | Not Found - Resource not found  Possible error codes: &#x60;GIFT_CARD_NOT_FOUND&#x60; |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;GIFT_CARD_DISABLED&#x60;, &#x60;GIFT_CARD_EXPIRED&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="increasebalance"></a>
# **IncreaseBalance**
> IncreaseBalanceResponse1 IncreaseBalance (string transactionGiftCardId, GiftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdIncreasePostIncreaseBalanceRequestBody giftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdIncreasePostIncreaseBalanceRequestBody)



Adds to the GiftCard balance and creates a balance Transaction.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionGiftCardId** | **string** | Unique ID of the gift card associated with this transaction. |  |
| **giftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdIncreasePostIncreaseBalanceRequestBody** | [**GiftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdIncreasePostIncreaseBalanceRequestBody**](GiftCardGiftCardServiceV1RiseGiftCardsTransactionGiftCardIdIncreasePostIncreaseBalanceRequestBody.md) |  |  |

### Return type

[**IncreaseBalanceResponse1**](IncreaseBalanceResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;EXISTING_IDEMPOTENCY_KEY&#x60;, &#x60;INVALID_GIFT_CARD_BALANCE&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="querygiftcards"></a>
# **QueryGiftCards**
> QueryGiftCardsResponse1 QueryGiftCards (GiftCardGiftCardServiceV1RiseGiftCardsQueryPostQueryGiftCardsRequestBody giftCardGiftCardServiceV1RiseGiftCardsQueryPostQueryGiftCardsRequestBody)



Query GiftCards using [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardGiftCardServiceV1RiseGiftCardsQueryPostQueryGiftCardsRequestBody** | [**GiftCardGiftCardServiceV1RiseGiftCardsQueryPostQueryGiftCardsRequestBody**](GiftCardGiftCardServiceV1RiseGiftCardsQueryPostQueryGiftCardsRequestBody.md) |  |  |

### Return type

[**QueryGiftCardsResponse1**](QueryGiftCardsResponse1.md)

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

<a id="searchgiftcards"></a>
# **SearchGiftCards**
> SearchGiftCardsResponse1 SearchGiftCards (GiftCardGiftCardServiceV1RiseGiftCardsSearchPostSearchGiftCardsRequestBody giftCardGiftCardServiceV1RiseGiftCardsSearchPostSearchGiftCardsRequestBody)



Search for GiftCards by field.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardGiftCardServiceV1RiseGiftCardsSearchPostSearchGiftCardsRequestBody** | [**GiftCardGiftCardServiceV1RiseGiftCardsSearchPostSearchGiftCardsRequestBody**](GiftCardGiftCardServiceV1RiseGiftCardsSearchPostSearchGiftCardsRequestBody.md) |  |  |

### Return type

[**SearchGiftCardsResponse1**](SearchGiftCardsResponse1.md)

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

<a id="updategiftcard"></a>
# **UpdateGiftCard**
> UpdateGiftCardResponse1 UpdateGiftCard (string giftCardId, GiftCardGiftCardServiceV1RiseGiftCardsGiftCardIdPatchUpdateGiftCardRequestBody giftCardGiftCardServiceV1RiseGiftCardsGiftCardIdPatchUpdateGiftCardRequestBody)



Update a GiftCard, supports partial update. Pass the latest `revision` for a successful update.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **giftCardId** | **string** | The ID of the GiftCard to update. |  |
| **giftCardGiftCardServiceV1RiseGiftCardsGiftCardIdPatchUpdateGiftCardRequestBody** | [**GiftCardGiftCardServiceV1RiseGiftCardsGiftCardIdPatchUpdateGiftCardRequestBody**](GiftCardGiftCardServiceV1RiseGiftCardsGiftCardIdPatchUpdateGiftCardRequestBody.md) |  |  |

### Return type

[**UpdateGiftCardResponse1**](UpdateGiftCardResponse1.md)

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

