# Org.OpenAPITools.Model.AccessTokenRequest
Once a user has completed the installation process and given your app permission to access their data, use the authorization code we sent you, together with your secret key, to request an access token and a refresh token. (The access token is only valid for 5 minutes.).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GrantType** | **string** | Value must be set to \&quot;authorization_code\&quot; | [optional] 
**ClientId** | **string** | The App ID as defined | [optional] 
**ClientSecret** | **string** | The Secret Key for your app | [optional] 
**Code** | **string** | The authorization code received from us. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

