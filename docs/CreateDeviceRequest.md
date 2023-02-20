# Com.Lab5e.Span.Model.CreateDeviceRequest
Request object to create new devices

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tags** | **Dictionary&lt;string, string&gt;** | Tags are metadata for the device that you can set. These are just strings. | [optional] 
**Firmware** | [**FirmwareMetadata**](FirmwareMetadata.md) |  | [optional] 
**Config** | [**DeviceConfig**](DeviceConfig.md) |  | [optional] 
**Metadata** | [**DeviceMetadata**](DeviceMetadata.md) |  | [optional] 
**Imsi** | **string** | Deprecated: The IMSI is replaced by CellularIoTMetadata | [optional] 
**Imei** | **string** | The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things. This field is deprecated.  Deprecated: The IMEI is replaced by CellularIoTMetadata | [optional] 
**Network** | [**NetworkMetadata**](NetworkMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

