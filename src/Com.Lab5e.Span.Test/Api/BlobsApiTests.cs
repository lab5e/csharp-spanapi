/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.1 humorous-jaron
 * Contact: dev@lab5e.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Com.Lab5e.Span.Client;
using Com.Lab5e.Span.Api;
// uncomment below to import models
//using Com.Lab5e.Span.Model;

namespace Com.Lab5e.Span.Test.Api
{
    /// <summary>
    ///  Class for testing BlobsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BlobsApiTests : IDisposable
    {
        private BlobsApi instance;

        public BlobsApiTests()
        {
            instance = new BlobsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BlobsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BlobsApi
            //Assert.IsType<BlobsApi>(instance);
        }

        /// <summary>
        /// Test DeleteBlob
        /// </summary>
        [Fact]
        public void DeleteBlobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string blobId = null;
            //var response = instance.DeleteBlob(collectionId, blobId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ListBlobs
        /// </summary>
        [Fact]
        public void ListBlobsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //int? limit = null;
            //var response = instance.ListBlobs(collectionId, limit);
            //Assert.IsType<ListBlobResponse>(response);
        }
    }
}
