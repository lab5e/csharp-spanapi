/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.8.0 indecipherable-ferman
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
    /// Response object when listing blobs for a collection
    /// </summary>
    [DataContract(Name = "ListBlobResponse")]
    public partial class ListBlobResponse : IEquatable<ListBlobResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListBlobResponse" /> class.
        /// </summary>
        /// <param name="blobs">blobs.</param>
        public ListBlobResponse(List<Blob> blobs = default(List<Blob>))
        {
            this.Blobs = blobs;
        }

        /// <summary>
        /// Gets or Sets Blobs
        /// </summary>
        [DataMember(Name = "blobs", EmitDefaultValue = false)]
        public List<Blob> Blobs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListBlobResponse {\n");
            sb.Append("  Blobs: ").Append(Blobs).Append("\n");
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
            return this.Equals(input as ListBlobResponse);
        }

        /// <summary>
        /// Returns true if ListBlobResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListBlobResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListBlobResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Blobs == input.Blobs ||
                    this.Blobs != null &&
                    input.Blobs != null &&
                    this.Blobs.SequenceEqual(input.Blobs)
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
                if (this.Blobs != null)
                {
                    hashCode = (hashCode * 59) + this.Blobs.GetHashCode();
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
