/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.9 receding-glennis
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
    /// Defines OutputDataMessageOutputMessageType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OutputDataMessageOutputMessageType
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Keepalive for value: keepalive
        /// </summary>
        [EnumMember(Value = "keepalive")]
        Keepalive = 2,

        /// <summary>
        /// Enum Data for value: data
        /// </summary>
        [EnumMember(Value = "data")]
        Data = 3

    }

}
