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
    /// This is the metadata for a Cellular IoT device connected via an APN.
    /// </summary>
    [DataContract(Name = "CellularIoTMetadata")]
    public partial class CellularIoTMetadata : IEquatable<CellularIoTMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CellularIoTMetadata" /> class.
        /// </summary>
        /// <param name="gatewayId">gatewayId.</param>
        /// <param name="allocatedIp">Allocated IP address..</param>
        /// <param name="allocatedAt">allocatedAt.</param>
        /// <param name="cellId">cellId.</param>
        /// <param name="mcc">the provider in use.  The Mobile Country Code for the operator..</param>
        /// <param name="mnc">mnc.</param>
        /// <param name="country">country.</param>
        /// <param name="network">network.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="lastUpdate">lastUpdate.</param>
        public CellularIoTMetadata(string gatewayId = default(string), string allocatedIp = default(string), string allocatedAt = default(string), string cellId = default(string), int mcc = default(int), int mnc = default(int), string country = default(string), string network = default(string), string countryCode = default(string), string lastUpdate = default(string))
        {
            this.GatewayId = gatewayId;
            this.AllocatedIp = allocatedIp;
            this.AllocatedAt = allocatedAt;
            this.CellId = cellId;
            this.Mcc = mcc;
            this.Mnc = mnc;
            this.Country = country;
            this.Network = network;
            this.CountryCode = countryCode;
            this.LastUpdate = lastUpdate;
        }

        /// <summary>
        /// Gets or Sets GatewayId
        /// </summary>
        [DataMember(Name = "gatewayId", EmitDefaultValue = false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Allocated IP address.
        /// </summary>
        /// <value>Allocated IP address.</value>
        [DataMember(Name = "allocatedIp", EmitDefaultValue = false)]
        public string AllocatedIp { get; set; }

        /// <summary>
        /// Gets or Sets AllocatedAt
        /// </summary>
        [DataMember(Name = "allocatedAt", EmitDefaultValue = false)]
        public string AllocatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CellId
        /// </summary>
        [DataMember(Name = "cellId", EmitDefaultValue = false)]
        public string CellId { get; set; }

        /// <summary>
        /// the provider in use.  The Mobile Country Code for the operator.
        /// </summary>
        /// <value>the provider in use.  The Mobile Country Code for the operator.</value>
        [DataMember(Name = "mcc", EmitDefaultValue = false)]
        public int Mcc { get; set; }

        /// <summary>
        /// Gets or Sets Mnc
        /// </summary>
        [DataMember(Name = "mnc", EmitDefaultValue = false)]
        public int Mnc { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public string LastUpdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CellularIoTMetadata {\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  AllocatedIp: ").Append(AllocatedIp).Append("\n");
            sb.Append("  AllocatedAt: ").Append(AllocatedAt).Append("\n");
            sb.Append("  CellId: ").Append(CellId).Append("\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  Mnc: ").Append(Mnc).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
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
            return this.Equals(input as CellularIoTMetadata);
        }

        /// <summary>
        /// Returns true if CellularIoTMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of CellularIoTMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CellularIoTMetadata input)
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
                    this.AllocatedIp == input.AllocatedIp ||
                    (this.AllocatedIp != null &&
                    this.AllocatedIp.Equals(input.AllocatedIp))
                ) && 
                (
                    this.AllocatedAt == input.AllocatedAt ||
                    (this.AllocatedAt != null &&
                    this.AllocatedAt.Equals(input.AllocatedAt))
                ) && 
                (
                    this.CellId == input.CellId ||
                    (this.CellId != null &&
                    this.CellId.Equals(input.CellId))
                ) && 
                (
                    this.Mcc == input.Mcc ||
                    this.Mcc.Equals(input.Mcc)
                ) && 
                (
                    this.Mnc == input.Mnc ||
                    this.Mnc.Equals(input.Mnc)
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.LastUpdate == input.LastUpdate ||
                    (this.LastUpdate != null &&
                    this.LastUpdate.Equals(input.LastUpdate))
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
                if (this.AllocatedIp != null)
                {
                    hashCode = (hashCode * 59) + this.AllocatedIp.GetHashCode();
                }
                if (this.AllocatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.AllocatedAt.GetHashCode();
                }
                if (this.CellId != null)
                {
                    hashCode = (hashCode * 59) + this.CellId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Mcc.GetHashCode();
                hashCode = (hashCode * 59) + this.Mnc.GetHashCode();
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.LastUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdate.GetHashCode();
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
