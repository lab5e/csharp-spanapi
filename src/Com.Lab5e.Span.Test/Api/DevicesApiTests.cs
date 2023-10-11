/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.7.0 actionable-aryanna
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
    ///  Class for testing DevicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DevicesApiTests : IDisposable
    {
        private DevicesApi instance;

        public DevicesApiTests()
        {
            instance = new DevicesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DevicesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DevicesApi
            //Assert.IsType<DevicesApi>(instance);
        }

        /// <summary>
        /// Test AddDownstreamMessage
        /// </summary>
        [Fact]
        public void AddDownstreamMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //AddDownstreamMessageRequest body = null;
            //var response = instance.AddDownstreamMessage(collectionId, deviceId, body);
            //Assert.IsType<MessageDownstream>(response);
        }

        /// <summary>
        /// Test CreateDevice
        /// </summary>
        [Fact]
        public void CreateDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //CreateDeviceRequest body = null;
            //var response = instance.CreateDevice(collectionId, body);
            //Assert.IsType<Device>(response);
        }

        /// <summary>
        /// Test DeleteDevice
        /// </summary>
        [Fact]
        public void DeleteDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //var response = instance.DeleteDevice(collectionId, deviceId);
            //Assert.IsType<Device>(response);
        }

        /// <summary>
        /// Test DeleteDownstreamMessage
        /// </summary>
        [Fact]
        public void DeleteDownstreamMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //string messageId = null;
            //var response = instance.DeleteDownstreamMessage(collectionId, deviceId, messageId);
            //Assert.IsType<DeleteDownstreamMessageResponse>(response);
        }

        /// <summary>
        /// Test DeviceCertificate
        /// </summary>
        [Fact]
        public void DeviceCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //var response = instance.DeviceCertificate(collectionId, deviceId);
            //Assert.IsType<DeviceCertificateResponse>(response);
        }

        /// <summary>
        /// Test ListDeviceData
        /// </summary>
        [Fact]
        public void ListDeviceDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //int? limit = null;
            //string? start = null;
            //string? end = null;
            //string? offset = null;
            //var response = instance.ListDeviceData(collectionId, deviceId, limit, start, end, offset);
            //Assert.IsType<ListDataResponse>(response);
        }

        /// <summary>
        /// Test ListDevices
        /// </summary>
        [Fact]
        public void ListDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //var response = instance.ListDevices(collectionId);
            //Assert.IsType<ListDevicesResponse>(response);
        }

        /// <summary>
        /// Test ListDownstreamMessages
        /// </summary>
        [Fact]
        public void ListDownstreamMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //int? limit = null;
            //string? start = null;
            //string? end = null;
            //string? offset = null;
            //var response = instance.ListDownstreamMessages(collectionId, deviceId, limit, start, end, offset);
            //Assert.IsType<ListDownstreamMessagesResponse>(response);
        }

        /// <summary>
        /// Test ListUpstreamMessages
        /// </summary>
        [Fact]
        public void ListUpstreamMessagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //int? limit = null;
            //string? start = null;
            //string? end = null;
            //string? offset = null;
            //var response = instance.ListUpstreamMessages(collectionId, deviceId, limit, start, end, offset);
            //Assert.IsType<ListUpstreamMessagesResponse>(response);
        }

        /// <summary>
        /// Test RetrieveDevice
        /// </summary>
        [Fact]
        public void RetrieveDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //var response = instance.RetrieveDevice(collectionId, deviceId);
            //Assert.IsType<Device>(response);
        }

        /// <summary>
        /// Test RetrieveDeviceStats
        /// </summary>
        [Fact]
        public void RetrieveDeviceStatsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionId = null;
            //string deviceId = null;
            //var response = instance.RetrieveDeviceStats(collectionId, deviceId);
            //Assert.IsType<DeviceStats>(response);
        }

        /// <summary>
        /// Test UpdateDevice
        /// </summary>
        [Fact]
        public void UpdateDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string existingCollectionId = null;
            //string deviceId = null;
            //UpdateDeviceRequest body = null;
            //var response = instance.UpdateDevice(existingCollectionId, deviceId, body);
            //Assert.IsType<Device>(response);
        }
    }
}
