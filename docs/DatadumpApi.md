# Com.Lab5e.Span.Api.DatadumpApi

All URIs are relative to *https://api.lab5e.com/span*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DataDump**](DatadumpApi.md#datadump) | **POST** /datadump | Data dump


<a name="datadump"></a>
# **DataDump**
> DataDumpResponse DataDump (DataDumpRequest body)

Data dump

Do a complete data dump of your data, devices, outputs and collections.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class DataDumpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new DatadumpApi(config);
            var body = new DataDumpRequest(); // DataDumpRequest | 

            try
            {
                // Data dump
                DataDumpResponse result = apiInstance.DataDump(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatadumpApi.DataDump: " + e.Message );
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
 **body** | [**DataDumpRequest**](DataDumpRequest.md)|  | 

### Return type

[**DataDumpResponse**](DataDumpResponse.md)

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

