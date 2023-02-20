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
    ///  Class for testing SignCertificateRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SignCertificateRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SignCertificateRequest
        //private SignCertificateRequest instance;

        public SignCertificateRequestTests()
        {
            // TODO uncomment below to create an instance of SignCertificateRequest
            //instance = new SignCertificateRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SignCertificateRequest
        /// </summary>
        [Fact]
        public void SignCertificateRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" SignCertificateRequest
            //Assert.IsType<SignCertificateRequest>(instance);
        }


        /// <summary>
        /// Test the property 'GatewayId'
        /// </summary>
        [Fact]
        public void GatewayIdTest()
        {
            // TODO unit test for the property 'GatewayId'
        }
        /// <summary>
        /// Test the property 'DeviceId'
        /// </summary>
        [Fact]
        public void DeviceIdTest()
        {
            // TODO unit test for the property 'DeviceId'
        }
        /// <summary>
        /// Test the property 'Csr'
        /// </summary>
        [Fact]
        public void CsrTest()
        {
            // TODO unit test for the property 'Csr'
        }

    }

}
