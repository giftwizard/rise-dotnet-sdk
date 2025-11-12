# Org.OpenAPITools.Model.TokenInfoResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether the token is active. | [optional] 
**SubjectType** | **string** | Type of subject to which the token is issued. | [optional] 
**SubjectId** | **string** | ID of the subject to which the token is issued. | [optional] 
**Exp** | **decimal** | Token expiration timestamp. | [optional] 
**Iat** | **decimal** | Token issue timestamp. | [optional] 
**ClientId** | **decimal** | ID of the app that [created](https://dev.wix.com/docs/rest/app-management/oauth-2/create-access-token) the token, as defined in the [Wix Dev Center](https://dev.wix.com). | [optional] 
**AccountId** | **decimal** | ID of the account that [created](https://dev.wix.com/docs/rest/app-management/oauth-2/create-access-token) the token, as defined in the [Wix Dev Center](https://dev.wix.com/apps/my-apps). | [optional] 
**SiteId** | **decimal** | ID of the site to which the token is issued. | [optional] 
**InstanceId** | **decimal** | The [instance ID](https://dev.wix.com/docs/rest/app-management/app-instance/introduction) of the app that the access token was created for. Subscribe to the [Instance App Installed](https://dev.wix.com/docs/rest/app-management/app-instance/app-instance-installed) webhook to receive a notification including the new app instance ID whenever a version of your app is installed on a Wix site. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

