# Com.Lab5e.Span.Model.Device
This a device

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeviceId** | **string** | The device ID is assigned by the backend. | [optional] 
**CollectionId** | **string** |  | [optional] 
**Tags** | **Dictionary&lt;string, string&gt;** | Tags are metadata for the device that you can set. These are just strings. | [optional] 
**Firmware** | [**FirmwareMetadata**](FirmwareMetadata.md) |  | [optional] 
**Config** | [**DeviceConfig**](DeviceConfig.md) |  | [optional] 
**Metadata** | [**DeviceMetadata**](DeviceMetadata.md) |  | [optional] 
**Imsi** | **string** | The IMSI is the unique ID for the (e|nu|whatever)SIM card on your device. This is the primary identifier for your device on the network.  Deprecated: The IMSI is replaced by CellularIoTMetadata | [optional] 
**Imei** | **string** | The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things.  Deprecated: The IMEI is replaced by CellularIoTMetadata | [optional] 
**Network** | [**NetworkMetadata**](NetworkMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

