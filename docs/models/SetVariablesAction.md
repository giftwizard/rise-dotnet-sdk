# Org.OpenAPITools.Model.SetVariablesAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutputMapping** | **Object** | output mapping for example: {\&quot;someField\&quot;: \&quot;{{10}}\&quot;, \&quot;someOtherField\&quot;: \&quot;{{multiply( var(&#39;account.points.balance&#39;) ;2 )}}\&quot; } | [optional] 
**OutputSchema** | **Object** | output json schema representation could be string instead of Struct (and introduce some compression to minimize the size of it) | [optional] 
**PostActionIds** | **List&lt;string&gt;** | List of IDs of actions to run in parallel after variable initialization. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

