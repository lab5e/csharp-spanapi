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
    /// Collection
    /// </summary>
    [DataContract(Name = "Collection")]
    public partial class Collection : IEquatable<Collection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Collection" /> class.
        /// </summary>
        /// <param name="collectionId">The ID of the collection. This is assigned by the backend..</param>
        /// <param name="teamId">The team ID that owns the collection. This field is required. When you create new collections the default is to use your private team ID..</param>
        /// <param name="fieldMask">fieldMask.</param>
        /// <param name="firmware">firmware.</param>
        /// <param name="tags">Tags for the collection. Tags are metadata fields that you can assign to the collection..</param>
        public Collection(string collectionId = default(string), string teamId = default(string), FieldMask fieldMask = default(FieldMask), CollectionFirmware firmware = default(CollectionFirmware), Dictionary<string, string> tags = default(Dictionary<string, string>))
        {
            this.CollectionId = collectionId;
            this.TeamId = teamId;
            this.FieldMask = fieldMask;
            this.Firmware = firmware;
            this.Tags = tags;
        }

        /// <summary>
        /// The ID of the collection. This is assigned by the backend.
        /// </summary>
        /// <value>The ID of the collection. This is assigned by the backend.</value>
        [DataMember(Name = "collectionId", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// The team ID that owns the collection. This field is required. When you create new collections the default is to use your private team ID.
        /// </summary>
        /// <value>The team ID that owns the collection. This field is required. When you create new collections the default is to use your private team ID.</value>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets FieldMask
        /// </summary>
        [DataMember(Name = "fieldMask", EmitDefaultValue = false)]
        public FieldMask FieldMask { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class Collection {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  FieldMask: ").Append(FieldMask).Append("\n");
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
            return this.Equals(input as Collection);
        }

        /// <summary>
        /// Returns true if Collection instances are equal
        /// </summary>
        /// <param name="input">Instance of Collection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Collection input)
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
                    this.TeamId == input.TeamId ||
                    (this.TeamId != null &&
                    this.TeamId.Equals(input.TeamId))
                ) && 
                (
                    this.FieldMask == input.FieldMask ||
                    (this.FieldMask != null &&
                    this.FieldMask.Equals(input.FieldMask))
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
                if (this.CollectionId != null)
                    hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.TeamId != null)
                    hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                if (this.FieldMask != null)
                    hashCode = hashCode * 59 + this.FieldMask.GetHashCode();
                if (this.Firmware != null)
                    hashCode = hashCode * 59 + this.Firmware.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
