/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.4.2 nonviolent-adelbert
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
    ///  Class for testing CertificatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CertificatesApiTests : IDisposable
    {
        private CertificatesApi instance;

        public CertificatesApiTests()
        {
            instance = new CertificatesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CertificatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CertificatesApi
            //Assert.IsType<CertificatesApi>(instance);
        }

        /// <summary>
        /// Test CreateCertificate
        /// </summary>
        [Fact]
        public void CreateCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //CreateCertificateRequest body = null;
            //var response = instance.CreateCertificate(collectionId, body);
            //Assert.IsType<CreateCertificateResponse>(response);
        }

        /// <summary>
        /// Test RetrieveCertificateChain
        /// </summary>
        [Fact]
        public void RetrieveCertificateChainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string gatewayId = null;
            //string deviceId = null;
            //var response = instance.RetrieveCertificateChain(collectionId, gatewayId, deviceId);
            //Assert.IsType<CertificateChainResponse>(response);
        }

        /// <summary>
        /// Test SignCertificate
        /// </summary>
        [Fact]
        public void SignCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //SignCertificateRequest body = null;
            //var response = instance.SignCertificate(collectionId, body);
            //Assert.IsType<SignCertificateResponse>(response);
        }

        /// <summary>
        /// Test VerifyCertificate
        /// </summary>
        [Fact]
        public void VerifyCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //VerifyCertificateRequest body = null;
            //var response = instance.VerifyCertificate(collectionId, body);
            //Assert.IsType<VerifyCertificateResponse>(response);
        }
    }
}
