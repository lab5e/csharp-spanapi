# Com.Lab5e.Span.Model.DeviceConfig
This is the configuration for the device via the various gateways.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Ciot** | [**CellularIoTConfig**](CellularIoTConfig.md) |  | [optional] 
**Inet** | **Object** | This is the configuration for an internet-connected device. There are currently no configuration options for internet devices; the device is identified via the clientcertificate.  This is empty since there&#39;s no configuration required for the internet  gateway | [optional] 
**Gateway** | [**Dictionary&lt;string, GatewayDeviceConfig&gt;**](GatewayDeviceConfig.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

