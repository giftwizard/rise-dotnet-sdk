# Org.OpenAPITools.Model.OAuthOauth2TokenPostSomeOperationRequestBody
The endpoint accepts raw HTTP requests. You must pass the request\\'s body parameters formatted as bytes in the raw HTTP request\\'s `body` field, following this template: `{\"grantType\": \"client_credentials\", \"client_id\": \"<appId>\", \"client_secret\": \"<appSecretKey>\", \"instance_id\": \"<instanceId>\"}`. The access token is valid for 4 hours.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrantType** | **string** | Request type. You must pass &#x60;\&quot;client_credentials\&quot;&#x60; to request a new access token when using basic OAuth. | [optional] 
**ClientId** | **string** | Your app ID | [optional] 
**ClientSecret** | **string** | Your app&#39;s secret key ID | [optional] 
**InstanceId** | **string** | The instance ID of your app for which you want to create the access token. Instance id represents a unique installation of your app on a specific Rise account.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

