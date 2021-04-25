/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.11 evasive-governor
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
    ///  Class for testing FotaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FotaApiTests : IDisposable
    {
        private FotaApi instance;

        public FotaApiTests()
        {
            instance = new FotaApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FotaApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FotaApi
            //Assert.IsType<FotaApi>(instance);
        }

        /// <summary>
        /// Test ClearFirmwareError
        /// </summary>
        [Fact]
        public void ClearFirmwareErrorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //var response = instance.ClearFirmwareError(collectionId, deviceId);
            //Assert.IsType<ClearFirmwareErrorResponse>(response);
        }

        /// <summary>
        /// Test CreateFirmware
        /// </summary>
        [Fact]
        public void CreateFirmwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //CreateFirmwareRequest body = null;
            //var response = instance.CreateFirmware(collectionId, body);
            //Assert.IsType<Firmware>(response);
        }

        /// <summary>
        /// Test DeleteFirmware
        /// </summary>
        [Fact]
        public void DeleteFirmwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string imageId = null;
            //var response = instance.DeleteFirmware(collectionId, imageId);
            //Assert.IsType<Firmware>(response);
        }

        /// <summary>
        /// Test FirmwareUsage
        /// </summary>
        [Fact]
        public void FirmwareUsageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string imageId = null;
            //var response = instance.FirmwareUsage(collectionId, imageId);
            //Assert.IsType<FirmwareUsageResponse>(response);
        }

        /// <summary>
        /// Test ListFirmware
        /// </summary>
        [Fact]
        public void ListFirmwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.ListFirmware(collectionId);
            //Assert.IsType<ListFirmwareResponse>(response);
        }

        /// <summary>
        /// Test RetrieveFirmware
        /// </summary>
        [Fact]
        public void RetrieveFirmwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string imageId = null;
            //var response = instance.RetrieveFirmware(collectionId, imageId);
            //Assert.IsType<Firmware>(response);
        }

        /// <summary>
        /// Test UpdateFirmware
        /// </summary>
        [Fact]
        public void UpdateFirmwareTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string imageId = null;
            //Firmware body = null;
            //var response = instance.UpdateFirmware(collectionId, imageId, body);
            //Assert.IsType<Firmware>(response);
        }
    }
}
