/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.5.0 overwrought-dorla
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
    /// UDP metadata for messages receveied through one of the UDP endpoints
    /// </summary>
    [DataContract(Name = "UDPMetadata")]
    public partial class UDPMetadata : IEquatable<UDPMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UDPMetadata" /> class.
        /// </summary>
        /// <param name="localPort">localPort.</param>
        /// <param name="remotePort">remotePort.</param>
        public UDPMetadata(int localPort = default(int), int remotePort = default(int))
        {
            this.LocalPort = localPort;
            this.RemotePort = remotePort;
        }

        /// <summary>
        /// Gets or Sets LocalPort
        /// </summary>
        [DataMember(Name = "localPort", EmitDefaultValue = false)]
        public int LocalPort { get; set; }

        /// <summary>
        /// Gets or Sets RemotePort
        /// </summary>
        [DataMember(Name = "remotePort", EmitDefaultValue = false)]
        public int RemotePort { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UDPMetadata {\n");
            sb.Append("  LocalPort: ").Append(LocalPort).Append("\n");
            sb.Append("  RemotePort: ").Append(RemotePort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UDPMetadata);
        }

        /// <summary>
        /// Returns true if UDPMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of UDPMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UDPMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LocalPort == input.LocalPort ||
                    this.LocalPort.Equals(input.LocalPort)
                ) && 
                (
                    this.RemotePort == input.RemotePort ||
                    this.RemotePort.Equals(input.RemotePort)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.LocalPort.GetHashCode();
                hashCode = (hashCode * 59) + this.RemotePort.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
