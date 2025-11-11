# Org.OpenAPITools.Api.WalletActionApi

All URIs are relative to *https://platform.rise.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateWalletAction**](WalletActionApi.md#createwalletaction) | **POST** /v1/rise/wallet_actions |  |
| [**CreateWalletActionByCustomerReference**](WalletActionApi.md#createwalletactionbycustomerreference) | **POST** /v1/rise/wallet_actions/by_customer_reference |  |
| [**DisableWalletAction**](WalletActionApi.md#disablewalletaction) | **POST** /v1/rise/wallet_actions/{walletActionId}/disable |  |
| [**GetRefundableAmounts**](WalletActionApi.md#getrefundableamounts) | **GET** /v1/rise/wallet_actions/refund/amounts |  |
| [**QueryUnredeemedWalletActions**](WalletActionApi.md#queryunredeemedwalletactions) | **POST** /v1/rise/wallet_actions/query/unredeemed |  |
| [**QueryWalletActions**](WalletActionApi.md#querywalletactions) | **POST** /v1/rise/wallet_actions/query |  |
| [**QueryWalletActionsBalances**](WalletActionApi.md#querywalletactionsbalances) | **POST** /v1/rise/wallet_actions/query/balances |  |
| [**UpdateWalletAction**](WalletActionApi.md#updatewalletaction) | **PATCH** /v1/rise/wallet_actions/{walletActionId} |  |

<a id="createwalletaction"></a>
# **CreateWalletAction**
> CreateWalletActionResponse1 CreateWalletAction (WalletActionWalletActionServiceV1RiseWalletActionsPostCreateWalletActionRequestBody walletActionWalletActionServiceV1RiseWalletActionsPostCreateWalletActionRequestBody)



Creates a new WalletAction.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletActionWalletActionServiceV1RiseWalletActionsPostCreateWalletActionRequestBody** | [**WalletActionWalletActionServiceV1RiseWalletActionsPostCreateWalletActionRequestBody**](WalletActionWalletActionServiceV1RiseWalletActionsPostCreateWalletActionRequestBody.md) |  |  |

### Return type

[**CreateWalletActionResponse1**](CreateWalletActionResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **400** | Bad Request - Invalid input or parameters  Possible error codes: &#x60;EXPIRATION_DATE_IN_THE_PAST&#x60;, &#x60;START_LATER_THAN_EXPIRATION&#x60;, &#x60;DISABLED_AT_DATE_SET&#x60; |  -  |
| **409** | Conflict - Request conflicts with current state  Possible error codes: &#x60;EXISTING_IDEMPOTENCY_KEY&#x60; |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;WALLET_ACTION_EXCEEDS_MAXIMUM_BALANCE&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createwalletactionbycustomerreference"></a>
# **CreateWalletActionByCustomerReference**
> CreateWalletActionByCustomerReferenceResponse1 CreateWalletActionByCustomerReference (WalletActionWalletActionServiceV1RiseWalletActionsByCustomerReferencePostCreateWalletActionByCustomerReferenceRequestBody walletActionWalletActionServiceV1RiseWalletActionsByCustomerReferencePostCreateWalletActionByCustomerReferenceRequestBody)



Creates a new WalletAction by customer reference instead of wallet ID. If the customer already has a wallet, the action will be created on that wallet. If the customer does not have a wallet, a new wallet will be created for them.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletActionWalletActionServiceV1RiseWalletActionsByCustomerReferencePostCreateWalletActionByCustomerReferenceRequestBody** | [**WalletActionWalletActionServiceV1RiseWalletActionsByCustomerReferencePostCreateWalletActionByCustomerReferenceRequestBody**](WalletActionWalletActionServiceV1RiseWalletActionsByCustomerReferencePostCreateWalletActionByCustomerReferenceRequestBody.md) |  |  |

### Return type

[**CreateWalletActionByCustomerReferenceResponse1**](CreateWalletActionByCustomerReferenceResponse1.md)

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

<a id="disablewalletaction"></a>
# **DisableWalletAction**
> DisableWalletActionResponse1 DisableWalletAction (string walletActionId, WalletActionWalletActionServiceV1RiseWalletActionsWalletActionIdDisablePostDisableWalletActionRequestBody walletActionWalletActionServiceV1RiseWalletActionsWalletActionIdDisablePostDisableWalletActionRequestBody)



Disable a WalletAction immediately and deduct the remaining balance from the wallet.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletActionId** | **string** | ID of the WalletAction to delete. |  |
| **walletActionWalletActionServiceV1RiseWalletActionsWalletActionIdDisablePostDisableWalletActionRequestBody** | [**WalletActionWalletActionServiceV1RiseWalletActionsWalletActionIdDisablePostDisableWalletActionRequestBody**](WalletActionWalletActionServiceV1RiseWalletActionsWalletActionIdDisablePostDisableWalletActionRequestBody.md) |  |  |

### Return type

[**DisableWalletActionResponse1**](DisableWalletActionResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;WALLET_ACTION_ALREADY_EXPIRED&#x60;, &#x60;WALLET_ACTION_NOT_ACTIVE&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getrefundableamounts"></a>
# **GetRefundableAmounts**
> GetRefundableAmountsResponse1 GetRefundableAmounts (string transactionId)




### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** | ID of the transaction to get refundable amounts for |  |

### Return type

[**GetRefundableAmountsResponse1**](GetRefundableAmountsResponse1.md)

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

<a id="queryunredeemedwalletactions"></a>
# **QueryUnredeemedWalletActions**
> QueryUnredeemedWalletActionsResponse1 QueryUnredeemedWalletActions (WalletActionWalletActionServiceV1RiseWalletActionsQueryUnredeemedPostQueryUnredeemedWalletActionsRequestBody walletActionWalletActionServiceV1RiseWalletActionsQueryUnredeemedPostQueryUnredeemedWalletActionsRequestBody)



Query wallet actions that have not been entirely redeemed using [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language). Results are enriched with the remaining balance of each wallet action. Note: The returned result may contain fewer items than the requested page limit—or even be empty—while still providing a next cursor, because of in memory filtering. Always check the next cursor to determine if there are more items to fetch.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletActionWalletActionServiceV1RiseWalletActionsQueryUnredeemedPostQueryUnredeemedWalletActionsRequestBody** | [**WalletActionWalletActionServiceV1RiseWalletActionsQueryUnredeemedPostQueryUnredeemedWalletActionsRequestBody**](WalletActionWalletActionServiceV1RiseWalletActionsQueryUnredeemedPostQueryUnredeemedWalletActionsRequestBody.md) |  |  |

### Return type

[**QueryUnredeemedWalletActionsResponse1**](QueryUnredeemedWalletActionsResponse1.md)

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

<a id="querywalletactions"></a>
# **QueryWalletActions**
> QueryWalletActionResponse1 QueryWalletActions (WalletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody walletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody)



Query WalletActions using [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody** | [**WalletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody**](WalletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody.md) |  |  |

### Return type

[**QueryWalletActionResponse1**](QueryWalletActionResponse1.md)

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

<a id="querywalletactionsbalances"></a>
# **QueryWalletActionsBalances**
> QueryWalletActionBalancesResponse1 QueryWalletActionsBalances (WalletActionWalletActionServiceV1RiseWalletActionsQueryBalancesPostQueryWalletActionsBalancesRequestBody walletActionWalletActionServiceV1RiseWalletActionsQueryBalancesPostQueryWalletActionsBalancesRequestBody)



Query all WalletActions using [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language). Results are enriched with the remaining balance of each WalletAction.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletActionWalletActionServiceV1RiseWalletActionsQueryBalancesPostQueryWalletActionsBalancesRequestBody** | [**WalletActionWalletActionServiceV1RiseWalletActionsQueryBalancesPostQueryWalletActionsBalancesRequestBody**](WalletActionWalletActionServiceV1RiseWalletActionsQueryBalancesPostQueryWalletActionsBalancesRequestBody.md) |  |  |

### Return type

[**QueryWalletActionBalancesResponse1**](QueryWalletActionBalancesResponse1.md)

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

<a id="updatewalletaction"></a>
# **UpdateWalletAction**
> UpdateWalletActionResponse1 UpdateWalletAction (string walletActionId, WalletActionWalletActionServiceV1RiseWalletActionsWalletActionIdPatchUpdateWalletActionRequestBody walletActionWalletActionServiceV1RiseWalletActionsWalletActionIdPatchUpdateWalletActionRequestBody)



Update a WalletAction, supports partial update. Pass the latest `revision` for a successful update.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletActionId** | **string** | WalletAction ID. |  |
| **walletActionWalletActionServiceV1RiseWalletActionsWalletActionIdPatchUpdateWalletActionRequestBody** | [**WalletActionWalletActionServiceV1RiseWalletActionsWalletActionIdPatchUpdateWalletActionRequestBody**](WalletActionWalletActionServiceV1RiseWalletActionsWalletActionIdPatchUpdateWalletActionRequestBody.md) |  |  |

### Return type

[**UpdateWalletActionResponse1**](UpdateWalletActionResponse1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK - The request was successful |  -  |
| **400** | Bad Request - Invalid input or parameters  Possible error codes: &#x60;START_DATE_IN_THE_PAST&#x60;, &#x60;EXPIRATION_DATE_IN_THE_PAST&#x60;, &#x60;START_LATER_THAN_EXPIRATION&#x60; |  -  |
| **428** | Precondition Required - Precondition failed  Possible error codes: &#x60;WALLET_ACTION_ALREADY_ACTIVE&#x60;, &#x60;WALLET_ACTION_ALREADY_EXPIRED&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

