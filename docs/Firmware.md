# Com.Lab5e.Span.Model.Firmware
Firmware images aren't served back out through the API, only the metadata.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ImageId** | **string** |  | [optional] 
**_Version** | **string** | Make sure that the firmware image reports this version. If the version reported by this image is different the FOTA process won&#39;t be reported as successful since the device will report a version different from this. | [optional] 
**Filename** | **string** | This is just for internal house keeping, making it potentially easier to identify the firmware image. | [optional] 
**Sha256** | **string** | To ensure each image is unique the SHA-256 hash for all images in a collection must be unqique | [optional] 
**Length** | **int** |  | [optional] 
**CollectionId** | **string** | Collection ID for the collection owning the firmware image. | [optional] 
**Created** | **string** |  | [optional] 
**Tags** | **Dictionary&lt;string, string&gt;** | Tags for firmware image. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

