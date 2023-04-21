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
    /// GatewayCIoTConfig
    /// </summary>
    [DataContract(Name = "GatewayCIoTConfig")]
    public partial class GatewayCIoTConfig : IEquatable<GatewayCIoTConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCIoTConfig" /> class.
        /// </summary>
        /// <param name="apn">apn.</param>
        /// <param name="udpEndpoint">udpEndpoint.</param>
        /// <param name="coapEndpoint">coapEndpoint.</param>
        public GatewayCIoTConfig(string apn = default(string), string udpEndpoint = default(string), string coapEndpoint = default(string))
        {
            this.Apn = apn;
            this.UdpEndpoint = udpEndpoint;
            this.CoapEndpoint = coapEndpoint;
        }

        /// <summary>
        /// Gets or Sets Apn
        /// </summary>
        [DataMember(Name = "apn", EmitDefaultValue = false)]
        public string Apn { get; set; }

        /// <summary>
        /// Gets or Sets UdpEndpoint
        /// </summary>
        [DataMember(Name = "udpEndpoint", EmitDefaultValue = false)]
        public string UdpEndpoint { get; set; }

        /// <summary>
        /// Gets or Sets CoapEndpoint
        /// </summary>
        [DataMember(Name = "coapEndpoint", EmitDefaultValue = false)]
        public string CoapEndpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GatewayCIoTConfig {\n");
            sb.Append("  Apn: ").Append(Apn).Append("\n");
            sb.Append("  UdpEndpoint: ").Append(UdpEndpoint).Append("\n");
            sb.Append("  CoapEndpoint: ").Append(CoapEndpoint).Append("\n");
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
            return this.Equals(input as GatewayCIoTConfig);
        }

        /// <summary>
        /// Returns true if GatewayCIoTConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayCIoTConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayCIoTConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Apn == input.Apn ||
                    (this.Apn != null &&
                    this.Apn.Equals(input.Apn))
                ) && 
                (
                    this.UdpEndpoint == input.UdpEndpoint ||
                    (this.UdpEndpoint != null &&
                    this.UdpEndpoint.Equals(input.UdpEndpoint))
                ) && 
                (
                    this.CoapEndpoint == input.CoapEndpoint ||
                    (this.CoapEndpoint != null &&
                    this.CoapEndpoint.Equals(input.CoapEndpoint))
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
                if (this.Apn != null)
                {
                    hashCode = (hashCode * 59) + this.Apn.GetHashCode();
                }
                if (this.UdpEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.UdpEndpoint.GetHashCode();
                }
                if (this.CoapEndpoint != null)
                {
                    hashCode = (hashCode * 59) + this.CoapEndpoint.GetHashCode();
                }
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