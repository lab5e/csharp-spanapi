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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Lab5e.Span.Client.OpenAPIDateConverter;

namespace Com.Lab5e.Span.Model
{
    /// <summary>
    /// Output types available   - undefined: The undefined output type is an invalid type
    /// </summary>
    /// <value>Output types available   - undefined: The undefined output type is an invalid type</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OutputType
    {
        /// <summary>
        /// Enum Undefined for value: undefined
        /// </summary>
        [EnumMember(Value = "undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum Webhook for value: webhook
        /// </summary>
        [EnumMember(Value = "webhook")]
        Webhook = 2,

        /// <summary>
        /// Enum Udpout for value: udpout
        /// </summary>
        [EnumMember(Value = "udpout")]
        Udpout = 3,

        /// <summary>
        /// Enum Mqttclient for value: mqttclient
        /// </summary>
        [EnumMember(Value = "mqttclient")]
        Mqttclient = 4,

        /// <summary>
        /// Enum Ifttt for value: ifttt
        /// </summary>
        [EnumMember(Value = "ifttt")]
        Ifttt = 5,

        /// <summary>
        /// Enum Mqttbroker for value: mqttbroker
        /// </summary>
        [EnumMember(Value = "mqttbroker")]
        Mqttbroker = 6

    }

}
