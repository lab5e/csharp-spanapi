/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.4.1 busy-janay
 * Contact: dev@lab5e.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Model;

namespace Com.Lab5e.Span.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBlobsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Remove a blob stored on a collection
        /// </summary>
        /// <remarks>
        /// Remove a blob stored on the collection.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="blobId"></param>
        /// <returns>Object</returns>
        Object DeleteBlob(string collectionId, string blobId);

        /// <summary>
        /// Remove a blob stored on a collection
        /// </summary>
        /// <remarks>
        /// Remove a blob stored on the collection.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="blobId"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteBlobWithHttpInfo(string collectionId, string blobId);
        /// <summary>
        /// List the blobs for a collection
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ListBlobResponse</returns>
        ListBlobResponse ListBlobs(string collectionId, int? limit = default(int?));

        /// <summary>
        /// List the blobs for a collection
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ApiResponse of ListBlobResponse</returns>
        ApiResponse<ListBlobResponse> ListBlobsWithHttpInfo(string collectionId, int? limit = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBlobsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Remove a blob stored on a collection
        /// </summary>
        /// <remarks>
        /// Remove a blob stored on the collection.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="blobId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeleteBlobAsync(string collectionId, string blobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Remove a blob stored on a collection
        /// </summary>
        /// <remarks>
        /// Remove a blob stored on the collection.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="blobId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBlobWithHttpInfoAsync(string collectionId, string blobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List the blobs for a collection
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListBlobResponse</returns>
        System.Threading.Tasks.Task<ListBlobResponse> ListBlobsAsync(string collectionId, int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List the blobs for a collection
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListBlobResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ListBlobResponse>> ListBlobsWithHttpInfoAsync(string collectionId, int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBlobsApi : IBlobsApiSync, IBlobsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BlobsApi : IBlobsApi
    {
        private Com.Lab5e.Span.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BlobsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BlobsApi(string basePath)
        {
            this.Configuration = Com.Lab5e.Span.Client.Configuration.MergeConfigurations(
                Com.Lab5e.Span.Client.GlobalConfiguration.Instance,
                new Com.Lab5e.Span.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Com.Lab5e.Span.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Lab5e.Span.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Com.Lab5e.Span.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BlobsApi(Com.Lab5e.Span.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Com.Lab5e.Span.Client.Configuration.MergeConfigurations(
                Com.Lab5e.Span.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Com.Lab5e.Span.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Lab5e.Span.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Com.Lab5e.Span.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BlobsApi(Com.Lab5e.Span.Client.ISynchronousClient client, Com.Lab5e.Span.Client.IAsynchronousClient asyncClient, Com.Lab5e.Span.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Com.Lab5e.Span.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Com.Lab5e.Span.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Com.Lab5e.Span.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Com.Lab5e.Span.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.Lab5e.Span.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Remove a blob stored on a collection Remove a blob stored on the collection.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="blobId"></param>
        /// <returns>Object</returns>
        public Object DeleteBlob(string collectionId, string blobId)
        {
            Com.Lab5e.Span.Client.ApiResponse<Object> localVarResponse = DeleteBlobWithHttpInfo(collectionId, blobId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a blob stored on a collection Remove a blob stored on the collection.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="blobId"></param>
        /// <returns>ApiResponse of Object</returns>
        public Com.Lab5e.Span.Client.ApiResponse<Object> DeleteBlobWithHttpInfo(string collectionId, string blobId)
        {
            // verify the required parameter 'collectionId' is set
            if (collectionId == null)
            {
                throw new Com.Lab5e.Span.Client.ApiException(400, "Missing required parameter 'collectionId' when calling BlobsApi->DeleteBlob");
            }

            // verify the required parameter 'blobId' is set
            if (blobId == null)
            {
                throw new Com.Lab5e.Span.Client.ApiException(400, "Missing required parameter 'blobId' when calling BlobsApi->DeleteBlob");
            }

            Com.Lab5e.Span.Client.RequestOptions localVarRequestOptions = new Com.Lab5e.Span.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("collectionId", Com.Lab5e.Span.Client.ClientUtils.ParameterToString(collectionId)); // path parameter
            localVarRequestOptions.PathParameters.Add("blobId", Com.Lab5e.Span.Client.ClientUtils.ParameterToString(blobId)); // path parameter

            // authentication (APIToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/span/collections/{collectionId}/blobs/{blobId}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteBlob", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a blob stored on a collection Remove a blob stored on the collection.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="blobId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteBlobAsync(string collectionId, string blobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Lab5e.Span.Client.ApiResponse<Object> localVarResponse = await DeleteBlobWithHttpInfoAsync(collectionId, blobId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Remove a blob stored on a collection Remove a blob stored on the collection.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="blobId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<Com.Lab5e.Span.Client.ApiResponse<Object>> DeleteBlobWithHttpInfoAsync(string collectionId, string blobId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'collectionId' is set
            if (collectionId == null)
            {
                throw new Com.Lab5e.Span.Client.ApiException(400, "Missing required parameter 'collectionId' when calling BlobsApi->DeleteBlob");
            }

            // verify the required parameter 'blobId' is set
            if (blobId == null)
            {
                throw new Com.Lab5e.Span.Client.ApiException(400, "Missing required parameter 'blobId' when calling BlobsApi->DeleteBlob");
            }


            Com.Lab5e.Span.Client.RequestOptions localVarRequestOptions = new Com.Lab5e.Span.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("collectionId", Com.Lab5e.Span.Client.ClientUtils.ParameterToString(collectionId)); // path parameter
            localVarRequestOptions.PathParameters.Add("blobId", Com.Lab5e.Span.Client.ClientUtils.ParameterToString(blobId)); // path parameter

            // authentication (APIToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/span/collections/{collectionId}/blobs/{blobId}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteBlob", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List the blobs for a collection Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ListBlobResponse</returns>
        public ListBlobResponse ListBlobs(string collectionId, int? limit = default(int?))
        {
            Com.Lab5e.Span.Client.ApiResponse<ListBlobResponse> localVarResponse = ListBlobsWithHttpInfo(collectionId, limit);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List the blobs for a collection Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="limit"> (optional)</param>
        /// <returns>ApiResponse of ListBlobResponse</returns>
        public Com.Lab5e.Span.Client.ApiResponse<ListBlobResponse> ListBlobsWithHttpInfo(string collectionId, int? limit = default(int?))
        {
            // verify the required parameter 'collectionId' is set
            if (collectionId == null)
            {
                throw new Com.Lab5e.Span.Client.ApiException(400, "Missing required parameter 'collectionId' when calling BlobsApi->ListBlobs");
            }

            Com.Lab5e.Span.Client.RequestOptions localVarRequestOptions = new Com.Lab5e.Span.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("collectionId", Com.Lab5e.Span.Client.ClientUtils.ParameterToString(collectionId)); // path parameter
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Com.Lab5e.Span.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            // authentication (APIToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ListBlobResponse>("/span/collections/{collectionId}/blobs", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListBlobs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List the blobs for a collection Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ListBlobResponse</returns>
        public async System.Threading.Tasks.Task<ListBlobResponse> ListBlobsAsync(string collectionId, int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Lab5e.Span.Client.ApiResponse<ListBlobResponse> localVarResponse = await ListBlobsWithHttpInfoAsync(collectionId, limit, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List the blobs for a collection Retrieve a list of all the blobs stored on this collection. Blobs are uploaded by the devices through one of the blob endpoints.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="collectionId"></param>
        /// <param name="limit"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ListBlobResponse)</returns>
        public async System.Threading.Tasks.Task<Com.Lab5e.Span.Client.ApiResponse<ListBlobResponse>> ListBlobsWithHttpInfoAsync(string collectionId, int? limit = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'collectionId' is set
            if (collectionId == null)
            {
                throw new Com.Lab5e.Span.Client.ApiException(400, "Missing required parameter 'collectionId' when calling BlobsApi->ListBlobs");
            }


            Com.Lab5e.Span.Client.RequestOptions localVarRequestOptions = new Com.Lab5e.Span.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("collectionId", Com.Lab5e.Span.Client.ClientUtils.ParameterToString(collectionId)); // path parameter
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Com.Lab5e.Span.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }

            // authentication (APIToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ListBlobResponse>("/span/collections/{collectionId}/blobs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListBlobs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
