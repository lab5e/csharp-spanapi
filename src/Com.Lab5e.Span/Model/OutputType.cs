/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.13 interdependent-karson
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
    /// Defines OutputType
    /// </summary>
    
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
        /// Enum Udp for value: udp
        /// </summary>
        [EnumMember(Value = "udp")]
        Udp = 3,

        /// <summary>
        /// Enum Mqtt for value: mqtt
        /// </summary>
        [EnumMember(Value = "mqtt")]
        Mqtt = 4,

        /// <summary>
        /// Enum Ifttt for value: ifttt
        /// </summary>
        [EnumMember(Value = "ifttt")]
        Ifttt = 5

    }

}
