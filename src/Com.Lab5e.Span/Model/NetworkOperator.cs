/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.2.4 curable-andres
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
    /// Operator holds information on the network operator. There might be several operators involved; one operator is running the network your devices are connected to and the SIM card in your device belongs to a different operator.  Deprecated: Replaced by CellularIoTMetadata
    /// </summary>
    [DataContract(Name = "NetworkOperator")]
    public partial class NetworkOperator : IEquatable<NetworkOperator>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkOperator" /> class.
        /// </summary>
        /// <param name="mcc">The Mobile Country Code for the operator..</param>
        /// <param name="mnc">mnc.</param>
        /// <param name="country">country.</param>
        /// <param name="network">network.</param>
        /// <param name="countryCode">countryCode.</param>
        public NetworkOperator(int mcc = default(int), int mnc = default(int), string country = default(string), string network = default(string), string countryCode = default(string))
        {
            this.Mcc = mcc;
            this.Mnc = mnc;
            this.Country = country;
            this.Network = network;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// The Mobile Country Code for the operator.
        /// </summary>
        /// <value>The Mobile Country Code for the operator.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkOperator {\n");
            sb.Append("  Mcc: ").Append(Mcc).Append("\n");
            sb.Append("  Mnc: ").Append(Mnc).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as NetworkOperator);
        }

        /// <summary>
        /// Returns true if NetworkOperator instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkOperator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkOperator input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
