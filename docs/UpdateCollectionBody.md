# Com.Lab5e.Span.Model.UpdateCollectionBody
Request object when updating a collection

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TeamId** | **string** | The team ID that owns the collection. This field is required. When you create new collections the default is to use your private team ID. | [optional] 
**Firmware** | [**CollectionFirmware**](CollectionFirmware.md) |  | [optional] 
**Tags** | **Dictionary&lt;string, string&gt;** | Tags for the collection. Tags are metadata fields that you can assign to the collection. | [optional] 
**Enabled** | **bool** | Enabled flag for the collection. A collection may be disabled or enabled to save time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

