# Com.Lab5e.Span.Model.Output
Output resource. The configuration depends on the kind of output type. There are five outputs: Webhooks, UDP forwarding, IFTTT events, MQTT client and MQTT broker. The MQTT broker output is just used to configure the built-in MQTT broker in Span.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutputId** | **string** |  | [optional] 
**CollectionId** | **string** |  | [optional] 
**Type** | **OutputType** |  | [optional] 
**Config** | [**OutputConfig**](OutputConfig.md) |  | [optional] 
**Enabled** | **bool** |  | [optional] 
**Tags** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

