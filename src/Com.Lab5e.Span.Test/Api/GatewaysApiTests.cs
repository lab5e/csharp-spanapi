/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.4.0 lean-joline
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
    ///  Class for testing GatewaysApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GatewaysApiTests : IDisposable
    {
        private GatewaysApi instance;

        public GatewaysApiTests()
        {
            instance = new GatewaysApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GatewaysApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GatewaysApi
            //Assert.IsType<GatewaysApi>(instance);
        }

        /// <summary>
        /// Test CreateGateway
        /// </summary>
        [Fact]
        public void CreateGatewayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //InlineObject body = null;
            //var response = instance.CreateGateway(collectionId, body);
            //Assert.IsType<Gateway>(response);
        }

        /// <summary>
        /// Test DeleteGateway
        /// </summary>
        [Fact]
        public void DeleteGatewayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string gatewayId = null;
            //var response = instance.DeleteGateway(collectionId, gatewayId);
            //Assert.IsType<Gateway>(response);
        }

        /// <summary>
        /// Test GatewayCertificates
        /// </summary>
        [Fact]
        public void GatewayCertificatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string gatewayId = null;
            //var response = instance.GatewayCertificates(collectionId, gatewayId);
            //Assert.IsType<GatewayCertificateResponse>(response);
        }

        /// <summary>
        /// Test ListGateways
        /// </summary>
        [Fact]
        public void ListGatewaysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.ListGateways(collectionId);
            //Assert.IsType<ListGatewayResponse>(response);
        }

        /// <summary>
        /// Test RetrieveGateway
        /// </summary>
        [Fact]
        public void RetrieveGatewayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string gatewayId = null;
            //var response = instance.RetrieveGateway(collectionId, gatewayId);
            //Assert.IsType<Gateway>(response);
        }

        /// <summary>
        /// Test UpdateGateway
        /// </summary>
        [Fact]
        public void UpdateGatewayTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string existingCollectionId = null;
            //string gatewayId = null;
            //InlineObject1 body = null;
            //var response = instance.UpdateGateway(existingCollectionId, gatewayId, body);
            //Assert.IsType<Gateway>(response);
        }
    }
}
