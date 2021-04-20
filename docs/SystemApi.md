# Com.Lab5e.Span.Api.SystemApi

All URIs are relative to *https://api.lab5e.com/span*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSystemInfo**](SystemApi.md#getsysteminfo) | **GET** /system | System information


<a name="getsysteminfo"></a>
# **GetSystemInfo**
> SystemInfoResponse GetSystemInfo ()

System information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class GetSystemInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com/span";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new SystemApi(config);

            try
            {
                // System information
                SystemInfoResponse result = apiInstance.GetSystemInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemInfo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SystemInfoResponse**](SystemInfoResponse.md)

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

