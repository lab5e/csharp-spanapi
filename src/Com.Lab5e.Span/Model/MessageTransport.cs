/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.2.3 lower-elian
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
    /// The message transport can be UDP or CoAP.
    /// </summary>
    /// <value>The message transport can be UDP or CoAP.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MessageTransport
    {
        /// <summary>
        /// Enum Unspecified for value: unspecified
        /// </summary>
        [EnumMember(Value = "unspecified")]
        Unspecified = 1,

        /// <summary>
        /// Enum Udp for value: udp
        /// </summary>
        [EnumMember(Value = "udp")]
        Udp = 2,

        /// <summary>
        /// Enum Coap for value: coap
        /// </summary>
        [EnumMember(Value = "coap")]
        Coap = 3

    }

}
