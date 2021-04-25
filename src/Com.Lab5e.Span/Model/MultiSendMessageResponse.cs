/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.10 hulking-betty
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
    /// Broadcast message result. The errors array contains the list of errors ocurred when sending a message.
    /// </summary>
    [DataContract(Name = "MultiSendMessageResponse")]
    public partial class MultiSendMessageResponse : IEquatable<MultiSendMessageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiSendMessageResponse" /> class.
        /// </summary>
        /// <param name="errors">errors.</param>
        /// <param name="sent">sent.</param>
        /// <param name="failed">failed.</param>
        public MultiSendMessageResponse(List<MessageSendResult> errors = default(List<MessageSendResult>), int sent = default(int), int failed = default(int))
        {
            this.Errors = errors;
            this.Sent = sent;
            this.Failed = failed;
        }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public List<MessageSendResult> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Sent
        /// </summary>
        [DataMember(Name = "sent", EmitDefaultValue = false)]
        public int Sent { get; set; }

        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name = "failed", EmitDefaultValue = false)]
        public int Failed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiSendMessageResponse {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
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
            return this.Equals(input as MultiSendMessageResponse);
        }

        /// <summary>
        /// Returns true if MultiSendMessageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiSendMessageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiSendMessageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Sent == input.Sent ||
                    this.Sent.Equals(input.Sent)
                ) && 
                (
                    this.Failed == input.Failed ||
                    this.Failed.Equals(input.Failed)
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                hashCode = hashCode * 59 + this.Sent.GetHashCode();
                hashCode = hashCode * 59 + this.Failed.GetHashCode();
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
