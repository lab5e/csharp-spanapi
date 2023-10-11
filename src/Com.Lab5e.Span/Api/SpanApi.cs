/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.7.0 actionable-aryanna
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
    public interface ISpanApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// System information
        /// </summary>
        /// <remarks>
        /// Get system information. This will show the current version of the API that you are using.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SystemInfoResponse</returns>
        SystemInfoResponse GetSystemInfo(int operationIndex = 0);

        /// <summary>
        /// System information
        /// </summary>
        /// <remarks>
        /// Get system information. This will show the current version of the API that you are using.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SystemInfoResponse</returns>
        ApiResponse<SystemInfoResponse> GetSystemInfoWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISpanApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// System information
        /// </summary>
        /// <remarks>
        /// Get system information. This will show the current version of the API that you are using.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SystemInfoResponse</returns>
        System.Threading.Tasks.Task<SystemInfoResponse> GetSystemInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// System information
        /// </summary>
        /// <remarks>
        /// Get system information. This will show the current version of the API that you are using.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SystemInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SystemInfoResponse>> GetSystemInfoWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISpanApi : ISpanApiSync, ISpanApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SpanApi : ISpanApi
    {
        private Com.Lab5e.Span.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SpanApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpanApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SpanApi(string basePath)
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
        /// Initializes a new instance of the <see cref="SpanApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SpanApi(Com.Lab5e.Span.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SpanApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SpanApi(Com.Lab5e.Span.Client.ISynchronousClient client, Com.Lab5e.Span.Client.IAsynchronousClient asyncClient, Com.Lab5e.Span.Client.IReadableConfiguration configuration)
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
        /// System information Get system information. This will show the current version of the API that you are using.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>SystemInfoResponse</returns>
        public SystemInfoResponse GetSystemInfo(int operationIndex = 0)
        {
            Com.Lab5e.Span.Client.ApiResponse<SystemInfoResponse> localVarResponse = GetSystemInfoWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// System information Get system information. This will show the current version of the API that you are using.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of SystemInfoResponse</returns>
        public Com.Lab5e.Span.Client.ApiResponse<SystemInfoResponse> GetSystemInfoWithHttpInfo(int operationIndex = 0)
        {
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


            localVarRequestOptions.Operation = "SpanApi.GetSystemInfo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (APIToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SystemInfoResponse>("/span/system", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSystemInfo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// System information Get system information. This will show the current version of the API that you are using.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SystemInfoResponse</returns>
        public async System.Threading.Tasks.Task<SystemInfoResponse> GetSystemInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Lab5e.Span.Client.ApiResponse<SystemInfoResponse> localVarResponse = await GetSystemInfoWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// System information Get system information. This will show the current version of the API that you are using.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SystemInfoResponse)</returns>
        public async System.Threading.Tasks.Task<Com.Lab5e.Span.Client.ApiResponse<SystemInfoResponse>> GetSystemInfoWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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


            localVarRequestOptions.Operation = "SpanApi.GetSystemInfo";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (APIToken) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<SystemInfoResponse>("/span/system", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetSystemInfo", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
