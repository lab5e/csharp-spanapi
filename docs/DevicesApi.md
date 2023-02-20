# Com.Lab5e.Span.Api.DevicesApi

All URIs are relative to *https://api.lab5e.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDownstreamMessage**](DevicesApi.md#adddownstreammessage) | **POST** /span/collections/{collectionId}/devices/{deviceId}/outbox | Add message to oubox
[**CreateDevice**](DevicesApi.md#createdevice) | **POST** /span/collections/{collectionId}/devices | Create device
[**DeleteDevice**](DevicesApi.md#deletedevice) | **DELETE** /span/collections/{collectionId}/devices/{deviceId} | Remove device.
[**DeleteDownstreamMessage**](DevicesApi.md#deletedownstreammessage) | **DELETE** /span/collections/{collectionId}/devices/{deviceId}/outbox/{messageId} | Delete outgoing message
[**DeviceCertificate**](DevicesApi.md#devicecertificate) | **GET** /span/collections/{collectionId}/devices/{deviceId}/certs | Get issued certificate(s) for device
[**ListDeviceData**](DevicesApi.md#listdevicedata) | **GET** /span/collections/{collectionId}/devices/{deviceId}/data | Retrieve data from device
[**ListDevices**](DevicesApi.md#listdevices) | **GET** /span/collections/{collectionId}/devices | List devices in collection.
[**ListDownstreamMessages**](DevicesApi.md#listdownstreammessages) | **GET** /span/collections/{collectionId}/devices/{deviceId}/outbox | List the messages in the outbox
[**ListUpstreamMessages**](DevicesApi.md#listupstreammessages) | **GET** /span/collections/{collectionId}/devices/{deviceId}/inbox | List incoming messages
[**RetrieveDevice**](DevicesApi.md#retrievedevice) | **GET** /span/collections/{collectionId}/devices/{deviceId} | Retrieve device
[**UpdateDevice**](DevicesApi.md#updatedevice) | **PATCH** /span/collections/{existingCollectionId}/devices/{deviceId} | Update device


<a name="adddownstreammessage"></a>
# **AddDownstreamMessage**
> MessageDownstream AddDownstreamMessage (string collectionId, string deviceId, AddDownstreamMessageRequest body)

Add message to oubox

Add a new message in the outgoing queue to the device. If there is other messages in the outbox these messages will be sent first.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class AddDownstreamMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var deviceId = "deviceId_example";  // string | 
            var body = new AddDownstreamMessageRequest(); // AddDownstreamMessageRequest | 

            try
            {
                // Add message to oubox
                MessageDownstream result = apiInstance.AddDownstreamMessage(collectionId, deviceId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.AddDownstreamMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **deviceId** | **string**|  | 
 **body** | [**AddDownstreamMessageRequest**](AddDownstreamMessageRequest.md)|  | 

### Return type

[**MessageDownstream**](MessageDownstream.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdevice"></a>
# **CreateDevice**
> Device CreateDevice (string collectionId, CreateDeviceRequest body)

Create device

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class CreateDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | This is the containing collection
            var body = new CreateDeviceRequest(); // CreateDeviceRequest | 

            try
            {
                // Create device
                Device result = apiInstance.CreateDevice(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.CreateDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| This is the containing collection | 
 **body** | [**CreateDeviceRequest**](CreateDeviceRequest.md)|  | 

### Return type

[**Device**](Device.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedevice"></a>
# **DeleteDevice**
> Device DeleteDevice (string collectionId, string deviceId)

Remove device.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class DeleteDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | This is the containing collection
            var deviceId = "deviceId_example";  // string | The device ID is assigned by the backend.

            try
            {
                // Remove device.
                Device result = apiInstance.DeleteDevice(collectionId, deviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| This is the containing collection | 
 **deviceId** | **string**| The device ID is assigned by the backend. | 

### Return type

[**Device**](Device.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedownstreammessage"></a>
# **DeleteDownstreamMessage**
> DeleteDownstreamMessageResponse DeleteDownstreamMessage (string collectionId, string deviceId, string messageId)

Delete outgoing message

Delete an outgoing (ie downstream) message from the outbox.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class DeleteDownstreamMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var deviceId = "deviceId_example";  // string | 
            var messageId = "messageId_example";  // string | 

            try
            {
                // Delete outgoing message
                DeleteDownstreamMessageResponse result = apiInstance.DeleteDownstreamMessage(collectionId, deviceId, messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.DeleteDownstreamMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **deviceId** | **string**|  | 
 **messageId** | **string**|  | 

### Return type

[**DeleteDownstreamMessageResponse**](DeleteDownstreamMessageResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="devicecertificate"></a>
# **DeviceCertificate**
> DeviceCertificateResponse DeviceCertificate (string collectionId, string deviceId)

Get issued certificate(s) for device

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class DeviceCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var deviceId = "deviceId_example";  // string | 

            try
            {
                // Get issued certificate(s) for device
                DeviceCertificateResponse result = apiInstance.DeviceCertificate(collectionId, deviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.DeviceCertificate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **deviceId** | **string**|  | 

### Return type

[**DeviceCertificateResponse**](DeviceCertificateResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdevicedata"></a>
# **ListDeviceData**
> ListDataResponse ListDeviceData (string collectionId, string deviceId, int? limit = null, string start = null, string end = null, string offset = null)

Retrieve data from device

List the data received from the device. Use the query parameters to control what data you retrieve. The maximum number of data points is 100.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class ListDeviceDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | The collection ID. This is included in the request path.
            var deviceId = "deviceId_example";  // string | The device ID. This is included in the request path.
            var limit = 56;  // int? | Limit the number of payloads to return. The default is 512. (optional) 
            var start = "start_example";  // string | Start of time range. The default is 24 hours ago. Value is in milliseconds since epoch. (optional) 
            var end = "end_example";  // string | End of time range. The default is the current time stamp. Value is in milliseconds since epoch. (optional) 
            var offset = "offset_example";  // string | The message offset based on the message ID. This parameter can't be combined with the start and end parameters. If no parameter is set the first N messages will be returned. If this parameter is set the next N messages (from newest to oldest) with message ID less than the offset will be returned. (optional) 

            try
            {
                // Retrieve data from device
                ListDataResponse result = apiInstance.ListDeviceData(collectionId, deviceId, limit, start, end, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.ListDeviceData: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| The collection ID. This is included in the request path. | 
 **deviceId** | **string**| The device ID. This is included in the request path. | 
 **limit** | **int?**| Limit the number of payloads to return. The default is 512. | [optional] 
 **start** | **string**| Start of time range. The default is 24 hours ago. Value is in milliseconds since epoch. | [optional] 
 **end** | **string**| End of time range. The default is the current time stamp. Value is in milliseconds since epoch. | [optional] 
 **offset** | **string**| The message offset based on the message ID. This parameter can&#39;t be combined with the start and end parameters. If no parameter is set the first N messages will be returned. If this parameter is set the next N messages (from newest to oldest) with message ID less than the offset will be returned. | [optional] 

### Return type

[**ListDataResponse**](ListDataResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdevices"></a>
# **ListDevices**
> ListDevicesResponse ListDevices (string collectionId)

List devices in collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class ListDevicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | 

            try
            {
                // List devices in collection.
                ListDevicesResponse result = apiInstance.ListDevices(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.ListDevices: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 

### Return type

[**ListDevicesResponse**](ListDevicesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdownstreammessages"></a>
# **ListDownstreamMessages**
> ListDownstreamMessagesResponse ListDownstreamMessages (string collectionId, string deviceId, int? limit = null, string start = null, string end = null, string offset = null)

List the messages in the outbox

List messages that should be sent to the device when it connects to the service. The messages are sent to the device when it connects to the service and either sends a message (via UDP or CoAP) or requests a message via CoAP GET request.option

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class ListDownstreamMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var deviceId = "deviceId_example";  // string | 
            var limit = 56;  // int? |  (optional) 
            var start = "start_example";  // string | Start of time range. The default is 24 hours ago. Value is in milliseconds since epoch. (optional) 
            var end = "end_example";  // string | End of time range. The default is the current time stamp. Value is in milliseconds since epoch. (optional) 
            var offset = "offset_example";  // string | The message offset based on the message ID. This parameter can't be combined with the start and end parameters. If no parameter is set the first N messages will be returned. If this parameter is set the next N messages (from newest to oldest) with message ID less than the offset will be returned. (optional) 

            try
            {
                // List the messages in the outbox
                ListDownstreamMessagesResponse result = apiInstance.ListDownstreamMessages(collectionId, deviceId, limit, start, end, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.ListDownstreamMessages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **deviceId** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **start** | **string**| Start of time range. The default is 24 hours ago. Value is in milliseconds since epoch. | [optional] 
 **end** | **string**| End of time range. The default is the current time stamp. Value is in milliseconds since epoch. | [optional] 
 **offset** | **string**| The message offset based on the message ID. This parameter can&#39;t be combined with the start and end parameters. If no parameter is set the first N messages will be returned. If this parameter is set the next N messages (from newest to oldest) with message ID less than the offset will be returned. | [optional] 

### Return type

[**ListDownstreamMessagesResponse**](ListDownstreamMessagesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listupstreammessages"></a>
# **ListUpstreamMessages**
> ListUpstreamMessagesResponse ListUpstreamMessages (string collectionId, string deviceId, int? limit = null, string start = null, string end = null, string offset = null)

List incoming messages

Retrieve a list of incoming (ie upstream) messages, ie messages sent from the device to the service. These messages are buffered in the service until they expire.  Use the query parameters to limit the number of messages to return. If no limit is specified the default limit of 250 is used.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class ListUpstreamMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var deviceId = "deviceId_example";  // string | 
            var limit = 56;  // int? |  (optional) 
            var start = "start_example";  // string | Start of time range. The default is 24 hours ago. Value is in milliseconds since epoch. (optional) 
            var end = "end_example";  // string | End of time range. The default is the current time stamp. Value is in milliseconds since epoch. (optional) 
            var offset = "offset_example";  // string | The message offset based on the message ID. This parameter can't be combined with the start and end parameters. If no parameter is set the first N messages will be returned. If this parameter is set the next N messages (from newest to oldest) with message ID less than the offset will be returned. (optional) 

            try
            {
                // List incoming messages
                ListUpstreamMessagesResponse result = apiInstance.ListUpstreamMessages(collectionId, deviceId, limit, start, end, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.ListUpstreamMessages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**|  | 
 **deviceId** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **start** | **string**| Start of time range. The default is 24 hours ago. Value is in milliseconds since epoch. | [optional] 
 **end** | **string**| End of time range. The default is the current time stamp. Value is in milliseconds since epoch. | [optional] 
 **offset** | **string**| The message offset based on the message ID. This parameter can&#39;t be combined with the start and end parameters. If no parameter is set the first N messages will be returned. If this parameter is set the next N messages (from newest to oldest) with message ID less than the offset will be returned. | [optional] 

### Return type

[**ListUpstreamMessagesResponse**](ListUpstreamMessagesResponse.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrievedevice"></a>
# **RetrieveDevice**
> Device RetrieveDevice (string collectionId, string deviceId)

Retrieve device

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class RetrieveDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var collectionId = "collectionId_example";  // string | This is the containing collection
            var deviceId = "deviceId_example";  // string | The device ID is assigned by the backend.

            try
            {
                // Retrieve device
                Device result = apiInstance.RetrieveDevice(collectionId, deviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.RetrieveDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **collectionId** | **string**| This is the containing collection | 
 **deviceId** | **string**| The device ID is assigned by the backend. | 

### Return type

[**Device**](Device.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedevice"></a>
# **UpdateDevice**
> Device UpdateDevice (string existingCollectionId, string deviceId, UpdateDeviceRequest body)

Update device

The device can be moved from one collection to another by setting the collection ID field to the new collection. You must have administrative access to both collections. A note on gateway configurations: Empty gateway configuration blocks are deleted. If the configuration block contains a gateway ID it will be updated  with the new values. All values must be submitted in the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class UpdateDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DevicesApi(config);
            var existingCollectionId = "existingCollectionId_example";  // string | 
            var deviceId = "deviceId_example";  // string | 
            var body = new UpdateDeviceRequest(); // UpdateDeviceRequest | 

            try
            {
                // Update device
                Device result = apiInstance.UpdateDevice(existingCollectionId, deviceId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DevicesApi.UpdateDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **existingCollectionId** | **string**|  | 
 **deviceId** | **string**|  | 
 **body** | [**UpdateDeviceRequest**](UpdateDeviceRequest.md)|  | 

### Return type

[**Device**](Device.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

