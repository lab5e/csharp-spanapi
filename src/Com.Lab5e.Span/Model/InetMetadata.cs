/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.5 contented-jamila
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
    /// Metadata for devices connected via the internet gateway. This metadata shows the configuration for the last message transmission.
    /// </summary>
    [DataContract(Name = "InetMetadata")]
    public partial class InetMetadata : IEquatable<InetMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InetMetadata" /> class.
        /// </summary>
        /// <param name="gatewayId">gatewayId.</param>
        /// <param name="lastUpdate">lastUpdate.</param>
        /// <param name="remoteAddress">remoteAddress.</param>
        /// <param name="certificateSerial">certificateSerial.</param>
        public InetMetadata(string gatewayId = default(string), string lastUpdate = default(string), string remoteAddress = default(string), string certificateSerial = default(string))
        {
            this.GatewayId = gatewayId;
            this.LastUpdate = lastUpdate;
            this.RemoteAddress = remoteAddress;
            this.CertificateSerial = certificateSerial;
        }

        /// <summary>
        /// Gets or Sets GatewayId
        /// </summary>
        [DataMember(Name = "gatewayId", EmitDefaultValue = false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public string LastUpdate { get; set; }

        /// <summary>
        /// Gets or Sets RemoteAddress
        /// </summary>
        [DataMember(Name = "remoteAddress", EmitDefaultValue = false)]
        public string RemoteAddress { get; set; }

        /// <summary>
        /// Gets or Sets CertificateSerial
        /// </summary>
        [DataMember(Name = "certificateSerial", EmitDefaultValue = false)]
        public string CertificateSerial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InetMetadata {\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  RemoteAddress: ").Append(RemoteAddress).Append("\n");
            sb.Append("  CertificateSerial: ").Append(CertificateSerial).Append("\n");
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
            return this.Equals(input as InetMetadata);
        }

        /// <summary>
        /// Returns true if InetMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of InetMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InetMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GatewayId == input.GatewayId ||
                    (this.GatewayId != null &&
                    this.GatewayId.Equals(input.GatewayId))
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
                ) && 
                (
                    this.RemoteAddress == input.RemoteAddress ||
                    (this.RemoteAddress != null &&
                    this.RemoteAddress.Equals(input.RemoteAddress))
                ) && 
                (
                    this.CertificateSerial == input.CertificateSerial ||
                    (this.CertificateSerial != null &&
                    this.CertificateSerial.Equals(input.CertificateSerial))
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
                if (this.GatewayId != null)
                {
                    hashCode = (hashCode * 59) + this.GatewayId.GetHashCode();
                }
                if (this.LastUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdate.GetHashCode();
                }
                if (this.RemoteAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RemoteAddress.GetHashCode();
                }
                if (this.CertificateSerial != null)
                {
                    hashCode = (hashCode * 59) + this.CertificateSerial.GetHashCode();
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
