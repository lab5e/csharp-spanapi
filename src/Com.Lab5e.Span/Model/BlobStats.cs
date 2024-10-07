/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.3 pitch-dark-elza
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
    /// Statistics for a single blob
    /// </summary>
    [DataContract(Name = "BlobStats")]
    public partial class BlobStats : IEquatable<BlobStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlobStats" /> class.
        /// </summary>
        /// <param name="blobBytes">blobBytes.</param>
        public BlobStats(string blobBytes = default(string))
        {
            this.BlobBytes = blobBytes;
        }

        /// <summary>
        /// Gets or Sets BlobBytes
        /// </summary>
        [DataMember(Name = "blobBytes", EmitDefaultValue = false)]
        public string BlobBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BlobStats {\n");
            sb.Append("  BlobBytes: ").Append(BlobBytes).Append("\n");
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
            return this.Equals(input as BlobStats);
        }

        /// <summary>
        /// Returns true if BlobStats instances are equal
        /// </summary>
        /// <param name="input">Instance of BlobStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlobStats input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlobBytes == input.BlobBytes ||
                    (this.BlobBytes != null &&
                    this.BlobBytes.Equals(input.BlobBytes))
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
                if (this.BlobBytes != null)
                {
                    hashCode = (hashCode * 59) + this.BlobBytes.GetHashCode();
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
