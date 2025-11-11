# Org.OpenAPITools.Model.Tags
Common object for tags. Should be use as in this example: message Foo { option (.wix.api.decomposite_of) = \"wix.commons.v2.tags.Foo\"; string id = 1; ... Tags tags = 5 }  example of taggable entity { id: \"123\" tags: { public_tags: { tag_ids:[\"11\",\"22\"] }, private_tags: { tag_ids: [\"33\", \"44\"] } } }

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrivateTags** | **Object** | Tags that require an additional permission in order to access them, typically restricted from site members and visitors. | [optional] 
**PublicTags** | **Object** | Tags that are exposed to anyone with access to the entity, including site members and visitors. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

