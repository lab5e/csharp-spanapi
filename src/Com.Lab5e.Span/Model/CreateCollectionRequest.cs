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
    /// Request object when creating a collection. The collect ID is assigned by the service.
    /// </summary>
    [DataContract(Name = "CreateCollectionRequest")]
    public partial class CreateCollectionRequest : IEquatable<CreateCollectionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionRequest" /> class.
        /// </summary>
        /// <param name="teamId">The team ID that owns the collection. This field is required. When you create new collections the default is to use your private team ID..</param>
        /// <param name="firmware">firmware.</param>
        /// <param name="tags">Tags for the collection. Tags are metadata fields that you can assign to the collection..</param>
        public CreateCollectionRequest(string teamId = default(string), CollectionFirmware firmware = default(CollectionFirmware), Dictionary<string, string> tags = default(Dictionary<string, string>))
        {
            this.TeamId = teamId;
            this.Firmware = firmware;
            this.Tags = tags;
        }

        /// <summary>
        /// The team ID that owns the collection. This field is required. When you create new collections the default is to use your private team ID.
        /// </summary>
        /// <value>The team ID that owns the collection. This field is required. When you create new collections the default is to use your private team ID.</value>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets Firmware
        /// </summary>
        [DataMember(Name = "firmware", EmitDefaultValue = false)]
        public CollectionFirmware Firmware { get; set; }

        /// <summary>
        /// Tags for the collection. Tags are metadata fields that you can assign to the collection.
        /// </summary>
        /// <value>Tags for the collection. Tags are metadata fields that you can assign to the collection.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCollectionRequest {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Firmware: ").Append(Firmware).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as CreateCollectionRequest);
        }

        /// <summary>
        /// Returns true if CreateCollectionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCollectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCollectionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.Firmware == input.Firmware ||
                    (this.Firmware != null &&
                    this.Firmware.Equals(input.Firmware))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.TeamId != null)
                {
                    hashCode = (hashCode * 59) + this.TeamId.GetHashCode();
                }
                if (this.Firmware != null)
                {
                    hashCode = (hashCode * 59) + this.Firmware.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
