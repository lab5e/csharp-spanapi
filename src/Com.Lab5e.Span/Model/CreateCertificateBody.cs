/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.1 humorous-jaron
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
    /// Request object to create a new certificate.
    /// </summary>
    [DataContract(Name = "CreateCertificateBody")]
    public partial class CreateCertificateBody : IEquatable<CreateCertificateBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCertificateBody" /> class.
        /// </summary>
        /// <param name="gatewayId">gatewayId.</param>
        /// <param name="deviceId">deviceId.</param>
        public CreateCertificateBody(string gatewayId = default(string), string deviceId = default(string))
        {
            this.GatewayId = gatewayId;
            this.DeviceId = deviceId;
        }

        /// <summary>
        /// Gets or Sets GatewayId
        /// </summary>
        [DataMember(Name = "gatewayId", EmitDefaultValue = false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCertificateBody {\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
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
            return this.Equals(input as CreateCertificateBody);
        }

        /// <summary>
        /// Returns true if CreateCertificateBody instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCertificateBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCertificateBody input)
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
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
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
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
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