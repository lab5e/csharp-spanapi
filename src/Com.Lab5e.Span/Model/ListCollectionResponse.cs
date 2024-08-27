/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.0 convulsive-launa
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
    /// Collection list. The list contains all the collections you have access to.
    /// </summary>
    [DataContract(Name = "ListCollectionResponse")]
    public partial class ListCollectionResponse : IEquatable<ListCollectionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCollectionResponse" /> class.
        /// </summary>
        /// <param name="collections">collections.</param>
        public ListCollectionResponse(List<Collection> collections = default(List<Collection>))
        {
            this.Collections = collections;
        }

        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name = "collections", EmitDefaultValue = false)]
        public List<Collection> Collections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListCollectionResponse {\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
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
            return this.Equals(input as ListCollectionResponse);
        }

        /// <summary>
        /// Returns true if ListCollectionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListCollectionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListCollectionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Collections == input.Collections ||
                    this.Collections != null &&
                    input.Collections != null &&
                    this.Collections.SequenceEqual(input.Collections)
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
                if (this.Collections != null)
                {
                    hashCode = (hashCode * 59) + this.Collections.GetHashCode();
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
