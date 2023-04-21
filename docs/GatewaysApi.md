# Com.Lab5e.Span.Api.GatewaysApi

All URIs are relative to *https://api.lab5e.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGateway**](GatewaysApi.md#creategateway) | **POST** /span/collections/{collectionId}/gateways | Create gateway
[**DeleteGateway**](GatewaysApi.md#deletegateway) | **DELETE** /span/collections/{collectionId}/gateways/{gatewayId} | Delete gateway
[**GatewayCertificates**](GatewaysApi.md#gatewaycertificates) | **GET** /span/collections/{collectionId}/gateways/{gatewayId}/certs | Get issued certificate(s) for gateway
[**ListGateways**](GatewaysApi.md#listgateways) | **GET** /span/collections/{collectionId}/gateways | List gateways
[**RetrieveGateway**](GatewaysApi.md#retrievegateway) | **GET** /span/collections/{collectionId}/gateways/{gatewayId} | Retrieve gateway
[**UpdateGateway**](GatewaysApi.md#updategateway) | **PATCH** /span/collections/{existingCollectionId}/gateways/{gatewayId} | Update gateway


<a name="creategateway"></a>
# **CreateGateway**
> Gateway CreateGateway (string collectionId, InlineObject body)

Create gateway

Create a new gateway.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class CreateGatewayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GatewaysApi(config);
            var collectionId = "collectionId_example";  // string | 
            var body = new InlineObject(); // InlineObject | 

            try
            {
                // Create gateway
                Gateway result = apiInstance.CreateGateway(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewaysApi.CreateGateway: " + e.Message );
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
 **body** | [**InlineObject**](InlineObject.md)|  | 

### Return type

[**Gateway**](Gateway.md)

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

<a name="deletegateway"></a>
# **DeleteGateway**
> Gateway DeleteGateway (string collectionId, string gatewayId)

Delete gateway

Remove a gateway from Span.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class DeleteGatewayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GatewaysApi(config);
            var collectionId = "collectionId_example";  // string | 
            var gatewayId = "gatewayId_example";  // string | 

            try
            {
                // Delete gateway
                Gateway result = apiInstance.DeleteGateway(collectionId, gatewayId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewaysApi.DeleteGateway: " + e.Message );
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
 **gatewayId** | **string**|  | 

### Return type

[**Gateway**](Gateway.md)

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

<a name="gatewaycertificates"></a>
# **GatewayCertificates**
> GatewayCertificateResponse GatewayCertificates (string collectionId, string gatewayId)

Get issued certificate(s) for gateway

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class GatewayCertificatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GatewaysApi(config);
            var collectionId = "collectionId_example";  // string | 
            var gatewayId = "gatewayId_example";  // string | 

            try
            {
                // Get issued certificate(s) for gateway
                GatewayCertificateResponse result = apiInstance.GatewayCertificates(collectionId, gatewayId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewaysApi.GatewayCertificates: " + e.Message );
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
 **gatewayId** | **string**|  | 

### Return type

[**GatewayCertificateResponse**](GatewayCertificateResponse.md)

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

<a name="listgateways"></a>
# **ListGateways**
> ListGatewayResponse ListGateways (string collectionId)

List gateways

List the user's gatways, including built-in gateways.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class ListGatewaysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GatewaysApi(config);
            var collectionId = "collectionId_example";  // string | 

            try
            {
                // List gateways
                ListGatewayResponse result = apiInstance.ListGateways(collectionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewaysApi.ListGateways: " + e.Message );
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

[**ListGatewayResponse**](ListGatewayResponse.md)

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

<a name="retrievegateway"></a>
# **RetrieveGateway**
> Gateway RetrieveGateway (string collectionId, string gatewayId)

Retrieve gateway

Get gateway information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class RetrieveGatewayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GatewaysApi(config);
            var collectionId = "collectionId_example";  // string | 
            var gatewayId = "gatewayId_example";  // string | 

            try
            {
                // Retrieve gateway
                Gateway result = apiInstance.RetrieveGateway(collectionId, gatewayId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewaysApi.RetrieveGateway: " + e.Message );
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
 **gatewayId** | **string**|  | 

### Return type

[**Gateway**](Gateway.md)

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

<a name="updategateway"></a>
# **UpdateGateway**
> Gateway UpdateGateway (string existingCollectionId, string gatewayId, InlineObject1 body)

Update gateway

Update a gateway in Span

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class UpdateGatewayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new GatewaysApi(config);
            var existingCollectionId = "existingCollectionId_example";  // string | 
            var gatewayId = "gatewayId_example";  // string | 
            var body = new InlineObject1(); // InlineObject1 | 

            try
            {
                // Update gateway
                Gateway result = apiInstance.UpdateGateway(existingCollectionId, gatewayId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GatewaysApi.UpdateGateway: " + e.Message );
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
 **gatewayId** | **string**|  | 
 **body** | [**InlineObject1**](InlineObject1.md)|  | 

### Return type

[**Gateway**](Gateway.md)

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
