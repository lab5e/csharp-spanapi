/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.6.1 squirming-codi
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
    /// Statistics for a single data router
    /// </summary>
    [DataContract(Name = "OutputStats")]
    public partial class OutputStats : IEquatable<OutputStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputStats" /> class.
        /// </summary>
        /// <param name="forwardErrors">forwardErrors.</param>
        /// <param name="messagesForwarded">messagesForwarded.</param>
        /// <param name="bytesForwardedMb">bytesForwardedMb.</param>
        public OutputStats(int forwardErrors = default(int), int messagesForwarded = default(int), float bytesForwardedMb = default(float))
        {
            this.ForwardErrors = forwardErrors;
            this.MessagesForwarded = messagesForwarded;
            this.BytesForwardedMb = bytesForwardedMb;
        }

        /// <summary>
        /// Gets or Sets ForwardErrors
        /// </summary>
        [DataMember(Name = "forwardErrors", EmitDefaultValue = false)]
        public int ForwardErrors { get; set; }

        /// <summary>
        /// Gets or Sets MessagesForwarded
        /// </summary>
        [DataMember(Name = "messagesForwarded", EmitDefaultValue = false)]
        public int MessagesForwarded { get; set; }

        /// <summary>
        /// Gets or Sets BytesForwardedMb
        /// </summary>
        [DataMember(Name = "bytesForwardedMb", EmitDefaultValue = false)]
        public float BytesForwardedMb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutputStats {\n");
            sb.Append("  ForwardErrors: ").Append(ForwardErrors).Append("\n");
            sb.Append("  MessagesForwarded: ").Append(MessagesForwarded).Append("\n");
            sb.Append("  BytesForwardedMb: ").Append(BytesForwardedMb).Append("\n");
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
            return this.Equals(input as OutputStats);
        }

        /// <summary>
        /// Returns true if OutputStats instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputStats input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ForwardErrors == input.ForwardErrors ||
                    this.ForwardErrors.Equals(input.ForwardErrors)
                ) && 
                (
                    this.MessagesForwarded == input.MessagesForwarded ||
                    this.MessagesForwarded.Equals(input.MessagesForwarded)
                ) && 
                (
                    this.BytesForwardedMb == input.BytesForwardedMb ||
                    this.BytesForwardedMb.Equals(input.BytesForwardedMb)
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
                hashCode = (hashCode * 59) + this.ForwardErrors.GetHashCode();
                hashCode = (hashCode * 59) + this.MessagesForwarded.GetHashCode();
                hashCode = (hashCode * 59) + this.BytesForwardedMb.GetHashCode();
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