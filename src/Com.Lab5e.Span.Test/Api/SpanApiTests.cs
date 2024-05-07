/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.9.6 authoritarian-betty
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
    ///  Class for testing SpanApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SpanApiTests : IDisposable
    {
        private SpanApi instance;

        public SpanApiTests()
        {
            instance = new SpanApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SpanApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SpanApi
            //Assert.IsType<SpanApi>(instance);
        }

        /// <summary>
        /// Test GetSystemInfo
        /// </summary>
        [Fact]
        public void GetSystemInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSystemInfo();
            //Assert.IsType<SystemInfoResponse>(response);
        }
    }
}
