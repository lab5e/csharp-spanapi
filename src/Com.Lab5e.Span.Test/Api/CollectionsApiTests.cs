/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.5.0 overwrought-dorla
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
    ///  Class for testing CollectionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CollectionsApiTests : IDisposable
    {
        private CollectionsApi instance;

        public CollectionsApiTests()
        {
            instance = new CollectionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CollectionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CollectionsApi
            //Assert.IsType<CollectionsApi>(instance);
        }

        /// <summary>
        /// Test CreateCollection
        /// </summary>
        [Fact]
        public void CreateCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateCollectionRequest body = null;
            //var response = instance.CreateCollection(body);
            //Assert.IsType<Collection>(response);
        }

        /// <summary>
        /// Test DeleteCollection
        /// </summary>
        [Fact]
        public void DeleteCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.DeleteCollection(collectionId);
            //Assert.IsType<Collection>(response);
        }

        /// <summary>
        /// Test ListCollectionData
        /// </summary>
        [Fact]
        public void ListCollectionDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //int? limit = null;
            //string? start = null;
            //string? end = null;
            //string? offset = null;
            //var response = instance.ListCollectionData(collectionId, limit, start, end, offset);
            //Assert.IsType<ListDataResponse>(response);
        }

        /// <summary>
        /// Test ListCollections
        /// </summary>
        [Fact]
        public void ListCollectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListCollections();
            //Assert.IsType<ListCollectionResponse>(response);
        }

        /// <summary>
        /// Test RetrieveCollection
        /// </summary>
        [Fact]
        public void RetrieveCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //bool? upstream = null;
            //bool? downstream = null;
            //var response = instance.RetrieveCollection(collectionId, upstream, downstream);
            //Assert.IsType<Collection>(response);
        }

        /// <summary>
        /// Test UpdateCollection
        /// </summary>
        [Fact]
        public void UpdateCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //UpdateCollectionRequest body = null;
            //var response = instance.UpdateCollection(collectionId, body);
            //Assert.IsType<Collection>(response);
        }
    }
}
