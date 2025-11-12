# Org.OpenAPITools.Api.WalletApi

All URIs are relative to *https://platform.rise.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CountWallets**](WalletApi.md#countwallets) | **POST** /v1/rise/wallets/count |  |
| [**CreateWallet**](WalletApi.md#createwallet) | **POST** /v1/rise/wallets |  |
| [**GetCustomerReference**](WalletApi.md#getcustomerreference) | **GET** /v1/rise/customers |  |
| [**GetOrCreateWallet**](WalletApi.md#getorcreatewallet) | **POST** /v1/rise/wallets/issue |  |
| [**GetWallet**](WalletApi.md#getwallet) | **GET** /v1/rise/wallets |  |
| [**QueryWallets**](WalletApi.md#querywallets) | **POST** /v1/rise/wallets/query |  |
| [**QueryWalletsByContact**](WalletApi.md#querywalletsbycontact) | **POST** /v1/rise/wallets/query_by_contact |  |

<a id="countwallets"></a>
# **CountWallets**
> CountWalletsResponse CountWallets (WalletWalletServiceV1RiseWalletsCountPostCountWalletsRequestBody walletWalletServiceV1RiseWalletsCountPostCountWalletsRequestBody)



Count wallets based on the given filter.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletWalletServiceV1RiseWalletsCountPostCountWalletsRequestBody** | [**WalletWalletServiceV1RiseWalletsCountPostCountWalletsRequestBody**](WalletWalletServiceV1RiseWalletsCountPostCountWalletsRequestBody.md) |  |  |

### Return type

[**CountWalletsResponse**](CountWalletsResponse.md)

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

<a id="createwallet"></a>
# **CreateWallet**
> CreateWalletResponse1 CreateWallet (WalletWalletServiceV1RiseWalletsPostCreateWalletRequestBody walletWalletServiceV1RiseWalletsPostCreateWalletRequestBody)



Creates a new Wallet.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletWalletServiceV1RiseWalletsPostCreateWalletRequestBody** | [**WalletWalletServiceV1RiseWalletsPostCreateWalletRequestBody**](WalletWalletServiceV1RiseWalletsPostCreateWalletRequestBody.md) |  |  |

### Return type

[**CreateWalletResponse1**](CreateWalletResponse1.md)

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

<a id="getcustomerreference"></a>
# **GetCustomerReference**
> GetCustomerReferenceResponse GetCustomerReference (CustomerReferenceQuery query)



Get a CustomerReference by source (i.e. source channel, tenant, and customer IDs).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**CustomerReferenceQuery**](CustomerReferenceQuery.md) | Customer Reference query object. |  |

### Return type

[**GetCustomerReferenceResponse**](GetCustomerReferenceResponse.md)

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

<a id="getorcreatewallet"></a>
# **GetOrCreateWallet**
> GetOrCreateWalletResponse GetOrCreateWallet (WalletWalletServiceV1RiseWalletsIssuePostGetOrCreateWalletRequestBody walletWalletServiceV1RiseWalletsIssuePostGetOrCreateWalletRequestBody)



Retrieves or creates a Wallet for the provided customer reference.  - In case the Wallet doesn't exist - creates a new Wallet with the provided customer reference. - In case the Wallet already exists - returns the existing Wallet. - If the provided customer reference doesn't exist yet - adds it to the wallet. - If the provided customer reference already exists - doesn't update anything.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletWalletServiceV1RiseWalletsIssuePostGetOrCreateWalletRequestBody** | [**WalletWalletServiceV1RiseWalletsIssuePostGetOrCreateWalletRequestBody**](WalletWalletServiceV1RiseWalletsIssuePostGetOrCreateWalletRequestBody.md) |  |  |

### Return type

[**GetOrCreateWalletResponse**](GetOrCreateWalletResponse.md)

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

<a id="getwallet"></a>
# **GetWallet**
> GetWalletResponse GetWallet (Object query)



Get a Wallet by ID, email, or a customer reference in the wallet.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**Object**](Object.md) | Query object. |  |

### Return type

[**GetWalletResponse**](GetWalletResponse.md)

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

<a id="querywallets"></a>
# **QueryWallets**
> QueryWalletsResponse1 QueryWallets (WalletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody walletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody)



Query wallets enriched with gift card and contact information. See [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language).


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody** | [**WalletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody**](WalletActionWalletActionServiceV1RiseWalletActionsQueryPostQueryWalletActionsRequestBody.md) |  |  |

### Return type

[**QueryWalletsResponse1**](QueryWalletsResponse1.md)

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

<a id="querywalletsbycontact"></a>
# **QueryWalletsByContact**
> QueryWalletsByContactResponse1 QueryWalletsByContact (WalletWalletServiceV1RiseWalletsQueryByContactPostQueryWalletsByContactRequestBody walletWalletServiceV1RiseWalletsQueryByContactPostQueryWalletsByContactRequestBody)



Query wallets by contact using [API Query Language](https://platform.rise.ai/docs/#tag/About-API-Query-Language). The result is a list of wallets with gift card and contact information.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **walletWalletServiceV1RiseWalletsQueryByContactPostQueryWalletsByContactRequestBody** | [**WalletWalletServiceV1RiseWalletsQueryByContactPostQueryWalletsByContactRequestBody**](WalletWalletServiceV1RiseWalletsQueryByContactPostQueryWalletsByContactRequestBody.md) |  |  |

### Return type

[**QueryWalletsByContactResponse1**](QueryWalletsByContactResponse1.md)

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

