# Org.OpenAPITools.Model.SetVariables

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutputMapping** | **string** | Action&#39;s output mapping. Jsonata expressions to set variables for example: { \&quot;var1\&quot;: \&quot;$average([10,20])\&quot;, \&quot;var2\&quot;: \&quot;$number($lookup($, $decodeUrlComponent(\\\&quot;var1\\\&quot;))) &gt;&#x3D; $number(8)\&quot;\&quot; } | [optional] 
**PostActions** | **List&lt;Object&gt;** | Action&#39;s post actions. | [optional] 
**PostActionsIds** | **List&lt;string&gt;** | Action&#39;s post actions ids. | [optional] 
**Namespace** | **string** | The namespace of the action | [optional] 
**OutputSchema** | **Object** | Json Schema for the output mapping | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

