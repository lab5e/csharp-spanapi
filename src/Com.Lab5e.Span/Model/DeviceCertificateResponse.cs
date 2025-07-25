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
    /// Response object for certificate info resource
    /// </summary>
    [DataContract(Name = "DeviceCertificateResponse")]
    public partial class DeviceCertificateResponse : IEquatable<DeviceCertificateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCertificateResponse" /> class.
        /// </summary>
        /// <param name="certificates">certificates.</param>
        public DeviceCertificateResponse(List<CertificateInfo> certificates = default(List<CertificateInfo>))
        {
            this.Certificates = certificates;
        }

        /// <summary>
        /// Gets or Sets Certificates
        /// </summary>
        [DataMember(Name = "certificates", EmitDefaultValue = false)]
        public List<CertificateInfo> Certificates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceCertificateResponse {\n");
            sb.Append("  Certificates: ").Append(Certificates).Append("\n");
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
            return this.Equals(input as DeviceCertificateResponse);
        }

        /// <summary>
        /// Returns true if DeviceCertificateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceCertificateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceCertificateResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Certificates == input.Certificates ||
                    this.Certificates != null &&
                    input.Certificates != null &&
                    this.Certificates.SequenceEqual(input.Certificates)
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
                if (this.Certificates != null)
                {
                    hashCode = (hashCode * 59) + this.Certificates.GetHashCode();
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
