/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.9.5 spattered-kelvin
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
    ///  Class for testing OutputStats
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class OutputStatsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for OutputStats
        //private OutputStats instance;

        public OutputStatsTests()
        {
            // TODO uncomment below to create an instance of OutputStats
            //instance = new OutputStats();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OutputStats
        /// </summary>
        [Fact]
        public void OutputStatsInstanceTest()
        {
            // TODO uncomment below to test "IsType" OutputStats
            //Assert.IsType<OutputStats>(instance);
        }


        /// <summary>
        /// Test the property 'ForwardErrors'
        /// </summary>
        [Fact]
        public void ForwardErrorsTest()
        {
            // TODO unit test for the property 'ForwardErrors'
        }
        /// <summary>
        /// Test the property 'MessagesForwarded'
        /// </summary>
        [Fact]
        public void MessagesForwardedTest()
        {
            // TODO unit test for the property 'MessagesForwarded'
        }
        /// <summary>
        /// Test the property 'BytesForwarded'
        /// </summary>
        [Fact]
        public void BytesForwardedTest()
        {
            // TODO unit test for the property 'BytesForwarded'
        }

    }

}
