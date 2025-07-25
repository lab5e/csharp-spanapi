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
    /// This is a blob (binary large object) that the devices might upload to the service. This is messages that are typically too large to handle like regular status and sensor values, typically media files. The content type might be derived from the first few bytes of the blob and could possibly be incorrect.  Download the blob by accessing the blob URL field. This will work like a regular HTTP request for your client. Authentication is required as always.
    /// </summary>
    [DataContract(Name = "Blob")]
    public partial class Blob : IEquatable<Blob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Blob" /> class.
        /// </summary>
        /// <param name="blobId">blobId.</param>
        /// <param name="blobPath">blobPath.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="size">size.</param>
        /// <param name="created">created.</param>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="gatewayId">gatewayId.</param>
        /// <param name="properties">properties.</param>
        public Blob(string blobId = default(string), string blobPath = default(string), string contentType = default(string), string size = default(string), string created = default(string), string collectionId = default(string), string deviceId = default(string), string gatewayId = default(string), Dictionary<string, string> properties = default(Dictionary<string, string>))
        {
            this.BlobId = blobId;
            this.BlobPath = blobPath;
            this.ContentType = contentType;
            this.Size = size;
            this.Created = created;
            this.CollectionId = collectionId;
            this.DeviceId = deviceId;
            this.GatewayId = gatewayId;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets BlobId
        /// </summary>
        [DataMember(Name = "blobId", EmitDefaultValue = false)]
        public string BlobId { get; set; }

        /// <summary>
        /// Gets or Sets BlobPath
        /// </summary>
        [DataMember(Name = "blobPath", EmitDefaultValue = false)]
        public string BlobPath { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets GatewayId
        /// </summary>
        [DataMember(Name = "gatewayId", EmitDefaultValue = false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = false)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Blob {\n");
            sb.Append("  BlobId: ").Append(BlobId).Append("\n");
            sb.Append("  BlobPath: ").Append(BlobPath).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as Blob);
        }

        /// <summary>
        /// Returns true if Blob instances are equal
        /// </summary>
        /// <param name="input">Instance of Blob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Blob input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlobId == input.BlobId ||
                    (this.BlobId != null &&
                    this.BlobId.Equals(input.BlobId))
                ) && 
                (
                    this.BlobPath == input.BlobPath ||
                    (this.BlobPath != null &&
                    this.BlobPath.Equals(input.BlobPath))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.GatewayId == input.GatewayId ||
                    (this.GatewayId != null &&
                    this.GatewayId.Equals(input.GatewayId))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.BlobId != null)
                {
                    hashCode = (hashCode * 59) + this.BlobId.GetHashCode();
                }
                if (this.BlobPath != null)
                {
                    hashCode = (hashCode * 59) + this.BlobPath.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
                }
                if (this.GatewayId != null)
                {
                    hashCode = (hashCode * 59) + this.GatewayId.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
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
