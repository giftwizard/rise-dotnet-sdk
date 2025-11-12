# Org.OpenAPITools.Model.RefreshTokenResponse
Once a user has completed the installation process and given your app permission to access their data, use the authorization code we sent you, together with your secret key, to request an access token and a refresh token. (The access token is only valid for 5 minutes.) You can find your secret key in the Wix Developers Center.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RefreshToken** | **string** | Your app instance’s refresh token that never expires. Identical to the one that you’ve sent in the request. | [optional] 
**AccessToken** | **string** | Created access token that you can use to make Wix API calls. It expires after 5 minutes. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

