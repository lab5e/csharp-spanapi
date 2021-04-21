/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.9 receding-glennis
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
    ///  Class for testing MultiSendMessageResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MultiSendMessageResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MultiSendMessageResponse
        //private MultiSendMessageResponse instance;

        public MultiSendMessageResponseTests()
        {
            // TODO uncomment below to create an instance of MultiSendMessageResponse
            //instance = new MultiSendMessageResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MultiSendMessageResponse
        /// </summary>
        [Fact]
        public void MultiSendMessageResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" MultiSendMessageResponse
            //Assert.IsType<MultiSendMessageResponse>(instance);
        }


        /// <summary>
        /// Test the property 'Errors'
        /// </summary>
        [Fact]
        public void ErrorsTest()
        {
            // TODO unit test for the property 'Errors'
        }
        /// <summary>
        /// Test the property 'Sent'
        /// </summary>
        [Fact]
        public void SentTest()
        {
            // TODO unit test for the property 'Sent'
        }
        /// <summary>
        /// Test the property 'Failed'
        /// </summary>
        [Fact]
        public void FailedTest()
        {
            // TODO unit test for the property 'Failed'
        }

    }

}
