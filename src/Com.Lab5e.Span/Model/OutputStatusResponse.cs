/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.8 adopted-kali
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
    /// OutputStatusResponse
    /// </summary>
    [DataContract(Name = "OutputStatusResponse")]
    public partial class OutputStatusResponse : IEquatable<OutputStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputStatusResponse" /> class.
        /// </summary>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="outputId">outputId.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="errorCount">errorCount.</param>
        /// <param name="forwarded">forwarded.</param>
        /// <param name="received">received.</param>
        /// <param name="retransmits">retransmits.</param>
        public OutputStatusResponse(string collectionId = default(string), string outputId = default(string), bool enabled = default(bool), int errorCount = default(int), int forwarded = default(int), int received = default(int), int retransmits = default(int))
        {
            this.CollectionId = collectionId;
            this.OutputId = outputId;
            this.Enabled = enabled;
            this.ErrorCount = errorCount;
            this.Forwarded = forwarded;
            this.Received = received;
            this.Retransmits = retransmits;
        }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets OutputId
        /// </summary>
        [DataMember(Name = "outputId", EmitDefaultValue = false)]
        public string OutputId { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets ErrorCount
        /// </summary>
        [DataMember(Name = "errorCount", EmitDefaultValue = false)]
        public int ErrorCount { get; set; }

        /// <summary>
        /// Gets or Sets Forwarded
        /// </summary>
        [DataMember(Name = "forwarded", EmitDefaultValue = false)]
        public int Forwarded { get; set; }

        /// <summary>
        /// Gets or Sets Received
        /// </summary>
        [DataMember(Name = "received", EmitDefaultValue = false)]
        public int Received { get; set; }

        /// <summary>
        /// Gets or Sets Retransmits
        /// </summary>
        [DataMember(Name = "retransmits", EmitDefaultValue = false)]
        public int Retransmits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutputStatusResponse {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  OutputId: ").Append(OutputId).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  Forwarded: ").Append(Forwarded).Append("\n");
            sb.Append("  Received: ").Append(Received).Append("\n");
            sb.Append("  Retransmits: ").Append(Retransmits).Append("\n");
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
            return this.Equals(input as OutputStatusResponse);
        }

        /// <summary>
        /// Returns true if OutputStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.OutputId == input.OutputId ||
                    (this.OutputId != null &&
                    this.OutputId.Equals(input.OutputId))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.ErrorCount == input.ErrorCount ||
                    this.ErrorCount.Equals(input.ErrorCount)
                ) && 
                (
                    this.Forwarded == input.Forwarded ||
                    this.Forwarded.Equals(input.Forwarded)
                ) && 
                (
                    this.Received == input.Received ||
                    this.Received.Equals(input.Received)
                ) && 
                (
                    this.Retransmits == input.Retransmits ||
                    this.Retransmits.Equals(input.Retransmits)
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
                if (this.CollectionId != null)
                    hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.OutputId != null)
                    hashCode = hashCode * 59 + this.OutputId.GetHashCode();
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                hashCode = hashCode * 59 + this.Forwarded.GetHashCode();
                hashCode = hashCode * 59 + this.Received.GetHashCode();
                hashCode = hashCode * 59 + this.Retransmits.GetHashCode();
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