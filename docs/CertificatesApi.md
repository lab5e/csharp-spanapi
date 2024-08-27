# Com.Lab5e.Span.Api.CertificatesApi

All URIs are relative to *https://api.lab5e.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCertificate**](CertificatesApi.md#createcertificate) | **POST** /span/collections/{collectionId}/certificates/create | Create certificate |
| [**RetrieveCertificateChain**](CertificatesApi.md#retrievecertificatechain) | **GET** /span/collections/{collectionId}/certificates | Get certificate chain |
| [**SignCertificate**](CertificatesApi.md#signcertificate) | **POST** /span/collections/{collectionId}/certificates/sign | Sign certificate |
| [**VerifyCertificate**](CertificatesApi.md#verifycertificate) | **POST** /span/collections/{collectionId}/certificates/verify | Verify certificate |

<a name="createcertificate"></a>
# **CreateCertificate**
> CreateCertificateResponse CreateCertificate (string collectionId, CreateCertificateBody body)

Create certificate

Create a new device or gateway (client) certificate for an internet-connected device. The devices will use this client certificate to authenticate when sending data via the Internet endpoint. This will create a X509 client certificate with an ECC public key. The key is not stored by the service so keep it in a secure place once it is downloaded. The returned certificate will be valid for 14 days. The key for the certificate is your own responsibility. The client certificate is used in both the TLS, DTLS and gRPC service endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class CreateCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var body = new CreateCertificateBody(); // CreateCertificateBody | 

            try
            {
                // Create certificate
                CreateCertificateResponse result = apiInstance.CreateCertificate(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.CreateCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create certificate
    ApiResponse<CreateCertificateResponse> response = apiInstance.CreateCertificateWithHttpInfo(collectionId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.CreateCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |
| **body** | [**CreateCertificateBody**](CreateCertificateBody.md) |  |  |

### Return type

[**CreateCertificateResponse**](CreateCertificateResponse.md)

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

<a name="retrievecertificatechain"></a>
# **RetrieveCertificateChain**
> CertificateChainResponse RetrieveCertificateChain (string collectionId, string? gatewayId = null, string? deviceId = null)

Get certificate chain

Get the certificate chain for the root CA and intermediate certificates used by the device, gateway and server certificates. It is highly recommended to verify the server certificate when sending data to avoid any man-in-the-middle attacks. This chain will contain all required certificates needed to verify the client certificate.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class RetrieveCertificateChainExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var gatewayId = "gatewayId_example";  // string? |  (optional) 
            var deviceId = "deviceId_example";  // string? |  (optional) 

            try
            {
                // Get certificate chain
                CertificateChainResponse result = apiInstance.RetrieveCertificateChain(collectionId, gatewayId, deviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.RetrieveCertificateChain: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveCertificateChainWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get certificate chain
    ApiResponse<CertificateChainResponse> response = apiInstance.RetrieveCertificateChainWithHttpInfo(collectionId, gatewayId, deviceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.RetrieveCertificateChainWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |
| **gatewayId** | **string?** |  | [optional]  |
| **deviceId** | **string?** |  | [optional]  |

### Return type

[**CertificateChainResponse**](CertificateChainResponse.md)

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

<a name="signcertificate"></a>
# **SignCertificate**
> SignCertificateResponse SignCertificate (string collectionId, SignCertificateBody body)

Sign certificate

Sign a device or gateway (aka client) certificate. The certificate is a X509 Certificate signing request PEM encoded. The certificate will be valid for 14 days and must be renewed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class SignCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var body = new SignCertificateBody(); // SignCertificateBody | 

            try
            {
                // Sign certificate
                SignCertificateResponse result = apiInstance.SignCertificate(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.SignCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SignCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Sign certificate
    ApiResponse<SignCertificateResponse> response = apiInstance.SignCertificateWithHttpInfo(collectionId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.SignCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |
| **body** | [**SignCertificateBody**](SignCertificateBody.md) |  |  |

### Return type

[**SignCertificateResponse**](SignCertificateResponse.md)

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

<a name="verifycertificate"></a>
# **VerifyCertificate**
> VerifyCertificateResponse VerifyCertificate (string collectionId, VerifyCertificateBody body)

Verify certificate

Verify client certificate. If a client certificate fails it can be tricky to pinpoint exactly *why* the certificate isn't accepted. This resource validates the client certificate and returns the error in plain text.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Example
{
    public class VerifyCertificateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new CertificatesApi(config);
            var collectionId = "collectionId_example";  // string | 
            var body = new VerifyCertificateBody(); // VerifyCertificateBody | 

            try
            {
                // Verify certificate
                VerifyCertificateResponse result = apiInstance.VerifyCertificate(collectionId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CertificatesApi.VerifyCertificate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyCertificateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify certificate
    ApiResponse<VerifyCertificateResponse> response = apiInstance.VerifyCertificateWithHttpInfo(collectionId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CertificatesApi.VerifyCertificateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionId** | **string** |  |  |
| **body** | [**VerifyCertificateBody**](VerifyCertificateBody.md) |  |  |

### Return type

[**VerifyCertificateResponse**](VerifyCertificateResponse.md)

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

