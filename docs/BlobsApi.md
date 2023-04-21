# Com.Lab5e.Span.Api.BlobsApi

All URIs are relative to *https://api.lab5e.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteBlob**](BlobsApi.md#deleteblob) | **DELETE** /span/collections/{collectionId}/blobs/{blobId} | Remove a blob stored on a collection |
| [**ListBlobs**](BlobsApi.md#listblobs) | **GET** /span/collections/{collectionId}/blobs | List the blobs for a collection |

<a name="deleteblob"></a>
# **DeleteBlob**
> Object DeleteBlob (string collectionId, string blobId)

Remove a blob stored on a collection

Remove a blob stored on the collection.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class DeleteBlobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BlobsApi(config);
            var collectionId = "collectionId_example";  // string | 
            var blobId = "blobId_example";  // string | 

            try
            {
                // Remove a blob stored on a collection
                Object result = apiInstance.DeleteBlob(collectionId, blobId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlobsApi.DeleteBlob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBlobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a blob stored on a collection
    ApiResponse<Object> response = apiInstance.DeleteBlobWithHttpInfo(collectionId, blobId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlobsApi.DeleteBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |
| **blobId** | **string** |  |  |

### Return type

**Object**

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

<a name="listblobs"></a>
# **ListBlobs**
> ListBlobResponse ListBlobs (string collectionId, int? limit = null)

List the blobs for a collection

Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class ListBlobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new BlobsApi(config);
            var collectionId = "collectionId_example";  // string | 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List the blobs for a collection
                ListBlobResponse result = apiInstance.ListBlobs(collectionId, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BlobsApi.ListBlobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBlobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the blobs for a collection
    ApiResponse<ListBlobResponse> response = apiInstance.ListBlobsWithHttpInfo(collectionId, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BlobsApi.ListBlobsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**ListBlobResponse**](ListBlobResponse.md)

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

