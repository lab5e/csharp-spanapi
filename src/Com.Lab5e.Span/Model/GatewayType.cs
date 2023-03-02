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
    /// Defines GatewayType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GatewayType
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Ciot for value: ciot
        /// </summary>
        [EnumMember(Value = "ciot")]
        Ciot = 2,

        /// <summary>
        /// Enum Inet for value: inet
        /// </summary>
        [EnumMember(Value = "inet")]
        Inet = 3,

        /// <summary>
        /// Enum Lora for value: lora
        /// </summary>
        [EnumMember(Value = "lora")]
        Lora = 4,

        /// <summary>
        /// Enum Openthread for value: openthread
        /// </summary>
        [EnumMember(Value = "openthread")]
        Openthread = 5,

        /// <summary>
        /// Enum Zigbee for value: zigbee
        /// </summary>
        [EnumMember(Value = "zigbee")]
        Zigbee = 6,

        /// <summary>
        /// Enum Matter for value: matter
        /// </summary>
        [EnumMember(Value = "matter")]
        Matter = 7,

        /// <summary>
        /// Enum Custom for value: custom
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom = 8

    }

}
