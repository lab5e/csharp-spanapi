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
    /// The firmware management settings for a collection can either be \&quot;disabled\&quot;, ie there is no firmware management for this collection, \&quot;collection\&quot;; devices are managed through the settings on the collection or \&quot;device\&quot; where each device is configured individual.
    /// </summary>
    /// <value>The firmware management settings for a collection can either be \&quot;disabled\&quot;, ie there is no firmware management for this collection, \&quot;collection\&quot;; devices are managed through the settings on the collection or \&quot;device\&quot; where each device is configured individual.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FirmwareManagement
    {
        /// <summary>
        /// Enum Unspecified for value: unspecified
        /// </summary>
        [EnumMember(Value = "unspecified")]
        Unspecified = 1,

        /// <summary>
        /// Enum Disabled for value: disabled
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled = 2,

        /// <summary>
        /// Enum Collection for value: collection
        /// </summary>
        [EnumMember(Value = "collection")]
        Collection = 3,

        /// <summary>
        /// Enum Device for value: device
        /// </summary>
        [EnumMember(Value = "device")]
        Device = 4

    }

}
