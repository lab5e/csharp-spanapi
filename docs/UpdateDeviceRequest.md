# Com.Lab5e.Span.Model.UpdateDeviceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExistingCollectionId** | **string** |  | [optional] 
**DeviceId** | **string** |  | [optional] 
**CollectionId** | **string** | The collection id for the device. This field is optional and can be omitted if the collection id isn&#39;t changed. When changing to a new collection you must be an owner of the other collection, ie an administrator of the team that owns the new collection. | [optional] 
**Imsi** | **string** | The IMSI is the unique ID for the (e|nu|whatever)SIM card on your device. This is the primary identifier for your device on the network. | [optional] 
**Imei** | **string** | The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things. | [optional] 
**Tags** | **Dictionary&lt;string, string&gt;** | Tags are metadata for the device that you can set. These are just strings. | [optional] 
**Firmware** | [**FirmwareMetadata**](FirmwareMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

