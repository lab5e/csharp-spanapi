/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.13 interdependent-karson
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
    public interface IDatadumpApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Data dump
        /// </summary>
        /// <remarks>
        /// Do a complete data dump of your data, devices, outputs and collections.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DataDumpResponse</returns>
        DataDumpResponse DataDump(DataDumpRequest body);

        /// <summary>
        /// Data dump
        /// </summary>
        /// <remarks>
        /// Do a complete data dump of your data, devices, outputs and collections.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DataDumpResponse</returns>
        ApiResponse<DataDumpResponse> DataDumpWithHttpInfo(DataDumpRequest body);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDatadumpApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Data dump
        /// </summary>
        /// <remarks>
        /// Do a complete data dump of your data, devices, outputs and collections.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataDumpResponse</returns>
        System.Threading.Tasks.Task<DataDumpResponse> DataDumpAsync(DataDumpRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Data dump
        /// </summary>
        /// <remarks>
        /// Do a complete data dump of your data, devices, outputs and collections.
        /// </remarks>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataDumpResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DataDumpResponse>> DataDumpWithHttpInfoAsync(DataDumpRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDatadumpApi : IDatadumpApiSync, IDatadumpApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DatadumpApi : IDatadumpApi
    {
        private Com.Lab5e.Span.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatadumpApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DatadumpApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatadumpApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DatadumpApi(String basePath)
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
        /// Initializes a new instance of the <see cref="DatadumpApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DatadumpApi(Com.Lab5e.Span.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="DatadumpApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public DatadumpApi(Com.Lab5e.Span.Client.ISynchronousClient client, Com.Lab5e.Span.Client.IAsynchronousClient asyncClient, Com.Lab5e.Span.Client.IReadableConfiguration configuration)
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
        public String GetBasePath()
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
        /// Data dump Do a complete data dump of your data, devices, outputs and collections.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>DataDumpResponse</returns>
        public DataDumpResponse DataDump(DataDumpRequest body)
        {
            Com.Lab5e.Span.Client.ApiResponse<DataDumpResponse> localVarResponse = DataDumpWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Data dump Do a complete data dump of your data, devices, outputs and collections.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of DataDumpResponse</returns>
        public Com.Lab5e.Span.Client.ApiResponse<DataDumpResponse> DataDumpWithHttpInfo(DataDumpRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new Com.Lab5e.Span.Client.ApiException(400, "Missing required parameter 'body' when calling DatadumpApi->DataDump");

            Com.Lab5e.Span.Client.RequestOptions localVarRequestOptions = new Com.Lab5e.Span.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

            // authentication (APIToken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<DataDumpResponse>("/datadump", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DataDump", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Data dump Do a complete data dump of your data, devices, outputs and collections.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DataDumpResponse</returns>
        public async System.Threading.Tasks.Task<DataDumpResponse> DataDumpAsync(DataDumpRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Lab5e.Span.Client.ApiResponse<DataDumpResponse> localVarResponse = await DataDumpWithHttpInfoAsync(body, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Data dump Do a complete data dump of your data, devices, outputs and collections.
        /// </summary>
        /// <exception cref="Com.Lab5e.Span.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DataDumpResponse)</returns>
        public async System.Threading.Tasks.Task<Com.Lab5e.Span.Client.ApiResponse<DataDumpResponse>> DataDumpWithHttpInfoAsync(DataDumpRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new Com.Lab5e.Span.Client.ApiException(400, "Missing required parameter 'body' when calling DatadumpApi->DataDump");


            Com.Lab5e.Span.Client.RequestOptions localVarRequestOptions = new Com.Lab5e.Span.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Lab5e.Span.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = body;

            // authentication (APIToken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<DataDumpResponse>("/datadump", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DataDump", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
