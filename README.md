# Com.Lab5e.Span - the C# library for the The Span API

API for device, collection, output and firmware management

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 4.1.8 adopted-kali
- SDK version: 4.1.8
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://lab5e.com/span](https://lab5e.com/span)

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Com.Lab5e.Span.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.ApiKey.Add("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("X-API-Token", "Bearer");

            var apiInstance = new CollectionsApi(config);
            var collectionId = collectionId_example;  // string | 
            var body = new BroadcastMessageRequest(); // BroadcastMessageRequest | 

            try
            {
                // Broadcast message
                MultiSendMessageResponse result = apiInstance.BroadcastMessage(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CollectionsApi.BroadcastMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.lab5e.com/span*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CollectionsApi* | [**BroadcastMessage**](docs/CollectionsApi.md#broadcastmessage) | **POST** /collections/{collectionId}/to | Broadcast message
*CollectionsApi* | [**CreateCollection**](docs/CollectionsApi.md#createcollection) | **POST** /collections | Create collection
*CollectionsApi* | [**DeleteCollection**](docs/CollectionsApi.md#deletecollection) | **DELETE** /collections/{collectionId} | Delete collection
*CollectionsApi* | [**ListCollectionData**](docs/CollectionsApi.md#listcollectiondata) | **GET** /collections/{collectionId}/data | Get payloads
*CollectionsApi* | [**ListCollections**](docs/CollectionsApi.md#listcollections) | **GET** /collections | List collections
*CollectionsApi* | [**RetrieveCollection**](docs/CollectionsApi.md#retrievecollection) | **GET** /collections/{collectionId} | Retrieve collection
*CollectionsApi* | [**UpdateCollection**](docs/CollectionsApi.md#updatecollection) | **PATCH** /collections/{collectionId} | Update collection
*DatadumpApi* | [**DataDump**](docs/DatadumpApi.md#datadump) | **POST** /datadump | Data dump
*DevicesApi* | [**CreateDevice**](docs/DevicesApi.md#createdevice) | **POST** /collections/{collectionId}/devices | Create device
*DevicesApi* | [**DeleteDevice**](docs/DevicesApi.md#deletedevice) | **DELETE** /collections/{collectionId}/devices/{deviceId} | Remove device
*DevicesApi* | [**ListDeviceData**](docs/DevicesApi.md#listdevicedata) | **GET** /collections/{collectionId}/devices/{deviceId}/data | Get payloads
*DevicesApi* | [**ListDevices**](docs/DevicesApi.md#listdevices) | **GET** /collections/{collectionId}/devices | List devices
*DevicesApi* | [**RetrieveDevice**](docs/DevicesApi.md#retrievedevice) | **GET** /collections/{collectionId}/devices/{deviceId} | Retrieve device
*DevicesApi* | [**SendMessage**](docs/DevicesApi.md#sendmessage) | **POST** /collections/{collectionId}/devices/{deviceId}/to | Send message
*DevicesApi* | [**UpdateDevice**](docs/DevicesApi.md#updatedevice) | **PATCH** /collections/{existingCollectionId}/devices/{deviceId} | Update device
*FotaApi* | [**ClearFirmwareError**](docs/FotaApi.md#clearfirmwareerror) | **DELETE** /collections/{collectionId}/devices/{deviceId}/fwerror | Clear FOTA error
*FotaApi* | [**CreateFirmware**](docs/FotaApi.md#createfirmware) | **POST** /collections/{collectionId}/firmware | Create firmware
*FotaApi* | [**DeleteFirmware**](docs/FotaApi.md#deletefirmware) | **DELETE** /collections/{collectionId}/firmware/{imageId} | Delete firmware
*FotaApi* | [**FirmwareUsage**](docs/FotaApi.md#firmwareusage) | **PATCH** /collections/{collectionId}/firmware/{imageId}/usage | Firmware usage
*FotaApi* | [**ListFirmware**](docs/FotaApi.md#listfirmware) | **GET** /collections/{collectionId}/firmware | List firmware
*FotaApi* | [**RetrieveFirmware**](docs/FotaApi.md#retrievefirmware) | **GET** /collections/{collectionId}/firmware/{imageId} | Retrieve firmware
*FotaApi* | [**UpdateFirmware**](docs/FotaApi.md#updatefirmware) | **PATCH** /collections/{collectionId}/firmware/{imageId} | Update firmware
*OutputsApi* | [**CreateOutput**](docs/OutputsApi.md#createoutput) | **POST** /collections/{collectionId}/outputs | Create output
*OutputsApi* | [**DeleteOutput**](docs/OutputsApi.md#deleteoutput) | **DELETE** /collections/{collectionId}/outputs/{outputId} | Delete output
*OutputsApi* | [**ListOutputs**](docs/OutputsApi.md#listoutputs) | **GET** /collections/{collectionId}/outputs | List outputs
*OutputsApi* | [**Logs**](docs/OutputsApi.md#logs) | **GET** /collections/{collectionId}/outputs/{outputId}/logs | Output logs
*OutputsApi* | [**RetrieveOutput**](docs/OutputsApi.md#retrieveoutput) | **GET** /collections/{collectionId}/outputs/{outputId} | Retrieve output
*OutputsApi* | [**Status**](docs/OutputsApi.md#status) | **GET** /collections/{collectionId}/outputs/{outputId}/status | Output status
*OutputsApi* | [**UpdateOutput**](docs/OutputsApi.md#updateoutput) | **PATCH** /collections/{collectionId}/outputs/{outputId} | Update output
*SystemApi* | [**GetSystemInfo**](docs/SystemApi.md#getsysteminfo) | **GET** /system | System information


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BroadcastMessageRequest](docs/BroadcastMessageRequest.md)
 - [Model.ClearFirmwareErrorResponse](docs/ClearFirmwareErrorResponse.md)
 - [Model.CoAPMetadata](docs/CoAPMetadata.md)
 - [Model.Collection](docs/Collection.md)
 - [Model.CollectionFirmware](docs/CollectionFirmware.md)
 - [Model.CollectionFirmwareFirmwareManagement](docs/CollectionFirmwareFirmwareManagement.md)
 - [Model.CreateFirmwareRequest](docs/CreateFirmwareRequest.md)
 - [Model.DataDumpRequest](docs/DataDumpRequest.md)
 - [Model.DataDumpResponse](docs/DataDumpResponse.md)
 - [Model.Device](docs/Device.md)
 - [Model.DumpedCollection](docs/DumpedCollection.md)
 - [Model.DumpedDevice](docs/DumpedDevice.md)
 - [Model.FieldMask](docs/FieldMask.md)
 - [Model.Firmware](docs/Firmware.md)
 - [Model.FirmwareMetadata](docs/FirmwareMetadata.md)
 - [Model.FirmwareUsageResponse](docs/FirmwareUsageResponse.md)
 - [Model.ListCollectionResponse](docs/ListCollectionResponse.md)
 - [Model.ListDataResponse](docs/ListDataResponse.md)
 - [Model.ListDevicesResponse](docs/ListDevicesResponse.md)
 - [Model.ListFirmwareResponse](docs/ListFirmwareResponse.md)
 - [Model.ListOutputResponse](docs/ListOutputResponse.md)
 - [Model.MessageSendResult](docs/MessageSendResult.md)
 - [Model.MultiSendMessageResponse](docs/MultiSendMessageResponse.md)
 - [Model.NetworkMetadata](docs/NetworkMetadata.md)
 - [Model.Output](docs/Output.md)
 - [Model.OutputConfig](docs/OutputConfig.md)
 - [Model.OutputDataMessage](docs/OutputDataMessage.md)
 - [Model.OutputDataMessageOutputMessageType](docs/OutputDataMessageOutputMessageType.md)
 - [Model.OutputLogEntry](docs/OutputLogEntry.md)
 - [Model.OutputLogResponse](docs/OutputLogResponse.md)
 - [Model.OutputStatusResponse](docs/OutputStatusResponse.md)
 - [Model.OutputType](docs/OutputType.md)
 - [Model.ProtobufAny](docs/ProtobufAny.md)
 - [Model.RpcStatus](docs/RpcStatus.md)
 - [Model.SendMessageRequest](docs/SendMessageRequest.md)
 - [Model.SendMessageResponse](docs/SendMessageResponse.md)
 - [Model.SystemInfoResponse](docs/SystemInfoResponse.md)
 - [Model.UDPMetadata](docs/UDPMetadata.md)
 - [Model.UpdateDeviceRequest](docs/UpdateDeviceRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="APIToken"></a>
### APIToken

- **Type**: API key
- **API key parameter name**: X-API-Token
- **Location**: HTTP header

