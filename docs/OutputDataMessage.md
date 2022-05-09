# Com.Lab5e.Span.Model.OutputDataMessage
The output data message contains payload plus metadata for a payload received from a device.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **OutputMessageType** |  | [optional] 
**Device** | [**Device**](Device.md) |  | [optional] 
**Payload** | **byte[]** |  | [optional] 
**Received** | **string** | Received time for message. Value is ms since epoch. | [optional] 
**Transport** | **string** |  | [optional] 
**UdpMetaData** | [**UDPMetadata**](UDPMetadata.md) |  | [optional] 
**CoapMetaData** | [**CoAPMetadata**](CoAPMetadata.md) |  | [optional] 
**MessageId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

