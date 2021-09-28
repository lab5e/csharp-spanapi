/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.17 enhanced-allie
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
    /// ProtobufAny
    /// </summary>
    [DataContract(Name = "protobufAny")]
    public partial class ProtobufAny : IEquatable<ProtobufAny>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtobufAny" /> class.
        /// </summary>
        /// <param name="typeUrl">typeUrl.</param>
        /// <param name="value">value.</param>
        public ProtobufAny(string typeUrl = default(string), byte[] value = default(byte[]))
        {
            this.TypeUrl = typeUrl;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets TypeUrl
        /// </summary>
        [DataMember(Name = "typeUrl", EmitDefaultValue = false)]
        public string TypeUrl { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public byte[] Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtobufAny {\n");
            sb.Append("  TypeUrl: ").Append(TypeUrl).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ProtobufAny);
        }

        /// <summary>
        /// Returns true if ProtobufAny instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtobufAny to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtobufAny input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TypeUrl == input.TypeUrl ||
                    (this.TypeUrl != null &&
                    this.TypeUrl.Equals(input.TypeUrl))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.TypeUrl != null)
                    hashCode = hashCode * 59 + this.TypeUrl.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
