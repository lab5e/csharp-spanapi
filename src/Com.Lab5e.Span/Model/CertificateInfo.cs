/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.2 subversive-jamila
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
    /// Certificate information
    /// </summary>
    [DataContract(Name = "CertificateInfo")]
    public partial class CertificateInfo : IEquatable<CertificateInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateInfo" /> class.
        /// </summary>
        /// <param name="certificateSerial">certificateSerial.</param>
        /// <param name="expires">expires.</param>
        public CertificateInfo(string certificateSerial = default(string), string expires = default(string))
        {
            this.CertificateSerial = certificateSerial;
            this.Expires = expires;
        }

        /// <summary>
        /// Gets or Sets CertificateSerial
        /// </summary>
        [DataMember(Name = "certificateSerial", EmitDefaultValue = false)]
        public string CertificateSerial { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = false)]
        public string Expires { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificateInfo {\n");
            sb.Append("  CertificateSerial: ").Append(CertificateSerial).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
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
            return this.Equals(input as CertificateInfo);
        }

        /// <summary>
        /// Returns true if CertificateInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CertificateSerial == input.CertificateSerial ||
                    (this.CertificateSerial != null &&
                    this.CertificateSerial.Equals(input.CertificateSerial))
                ) && 
                (
                    this.Expires == input.Expires ||
                    (this.Expires != null &&
                    this.Expires.Equals(input.Expires))
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
                if (this.CertificateSerial != null)
                {
                    hashCode = (hashCode * 59) + this.CertificateSerial.GetHashCode();
                }
                if (this.Expires != null)
                {
                    hashCode = (hashCode * 59) + this.Expires.GetHashCode();
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
