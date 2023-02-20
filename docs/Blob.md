# Com.Lab5e.Span.Model.Blob
This is a blob (binary large object) that the devices might upload to the service. This is messages that are typically too large to handle like regular status and sensor values, typically media files. The content type might be derived from the first few bytes of the blob and could possibly be incorrect.  Download the blob by accessing the blob URL field. This will work like a regular HTTP request for your client. Authentication is required as always.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlobId** | **string** |  | [optional] 
**BlobPath** | **string** |  | [optional] 
**ContentType** | **string** |  | [optional] 
**Size** | **string** |  | [optional] 
**Created** | **string** |  | [optional] 
**CollectionId** | **string** |  | [optional] 
**DeviceId** | **string** |  | [optional] 
**GatewayId** | **string** |  | [optional] 
**Properties** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

