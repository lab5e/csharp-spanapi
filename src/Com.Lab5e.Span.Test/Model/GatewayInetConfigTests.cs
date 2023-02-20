/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.4.0 lean-joline
 * Contact: dev@lab5e.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Com.Lab5e.Span.Api;
using Com.Lab5e.Span.Model;
using Com.Lab5e.Span.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Com.Lab5e.Span.Test.Model
{
    /// <summary>
    ///  Class for testing GatewayInetConfig
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GatewayInetConfigTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GatewayInetConfig
        //private GatewayInetConfig instance;

        public GatewayInetConfigTests()
        {
            // TODO uncomment below to create an instance of GatewayInetConfig
            //instance = new GatewayInetConfig();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GatewayInetConfig
        /// </summary>
        [Fact]
        public void GatewayInetConfigInstanceTest()
        {
            // TODO uncomment below to test "IsType" GatewayInetConfig
            //Assert.IsType<GatewayInetConfig>(instance);
        }


        /// <summary>
        /// Test the property 'DtlsEndpoint'
        /// </summary>
        [Fact]
        public void DtlsEndpointTest()
        {
            // TODO unit test for the property 'DtlsEndpoint'
        }
        /// <summary>
        /// Test the property 'CoapEndpoint'
        /// </summary>
        [Fact]
        public void CoapEndpointTest()
        {
            // TODO unit test for the property 'CoapEndpoint'
        }
        /// <summary>
        /// Test the property 'MqttEndpoint'
        /// </summary>
        [Fact]
        public void MqttEndpointTest()
        {
            // TODO unit test for the property 'MqttEndpoint'
        }

    }

}
