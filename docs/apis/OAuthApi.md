# Org.OpenAPITools.Api.OAuthApi

All URIs are relative to *https://platform.rise.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SomeOperation**](OAuthApi.md#someoperation) | **POST** /oauth2/token |  |

<a id="someoperation"></a>
# **SomeOperation**
> CreateAccessTokenResponse SomeOperation (OAuthOauth2TokenPostSomeOperationRequestBody oAuthOauth2TokenPostSomeOperationRequestBody = null)



Creates an access token.  Use this access token as Authorization header to call any other Rise api.  The token is valid for 4 hours.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **oAuthOauth2TokenPostSomeOperationRequestBody** | [**OAuthOauth2TokenPostSomeOperationRequestBody**](OAuthOauth2TokenPostSomeOperationRequestBody.md) |  | [optional]  |

### Return type

[**CreateAccessTokenResponse**](CreateAccessTokenResponse.md)

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

