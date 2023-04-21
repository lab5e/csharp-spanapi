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
    /// Response when retrieving a certificate chain
    /// </summary>
    [DataContract(Name = "CertificateChainResponse")]
    public partial class CertificateChainResponse : IEquatable<CertificateChainResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateChainResponse" /> class.
        /// </summary>
        /// <param name="chain">chain.</param>
        public CertificateChainResponse(byte[] chain = default(byte[]))
        {
            this.Chain = chain;
        }

        /// <summary>
        /// Gets or Sets Chain
        /// </summary>
        [DataMember(Name = "chain", EmitDefaultValue = false)]
        public byte[] Chain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificateChainResponse {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
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
            return this.Equals(input as CertificateChainResponse);
        }

        /// <summary>
        /// Returns true if CertificateChainResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateChainResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateChainResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
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
                if (this.Chain != null)
                {
                    hashCode = (hashCode * 59) + this.Chain.GetHashCode();
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
