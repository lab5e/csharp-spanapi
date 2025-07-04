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
    /// Firmware images aren&#39;t served back out through the API, only the metadata.
    /// </summary>
    [DataContract(Name = "Firmware")]
    public partial class Firmware : IEquatable<Firmware>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Firmware" /> class.
        /// </summary>
        /// <param name="imageId">imageId.</param>
        /// <param name="version">Make sure that the firmware image reports this version. If the version reported by this image is different the FOTA process won&#39;t be reported as successful since the device will report a version different from this..</param>
        /// <param name="filename">This is just for internal house keeping, making it potentially easier to identify the firmware image..</param>
        /// <param name="sha256">To ensure each image is unique the SHA-256 hash for all images in a collection must be unqique.</param>
        /// <param name="length">length.</param>
        /// <param name="collectionId">Collection ID for the collection owning the firmware image..</param>
        /// <param name="created">created.</param>
        /// <param name="tags">Tags for firmware image..</param>
        /// <param name="enabled">enabled.</param>
        public Firmware(string imageId = default(string), string version = default(string), string filename = default(string), string sha256 = default(string), int length = default(int), string collectionId = default(string), string created = default(string), Dictionary<string, string> tags = default(Dictionary<string, string>), bool enabled = default(bool))
        {
            this.ImageId = imageId;
            this._Version = version;
            this.Filename = filename;
            this.Sha256 = sha256;
            this.Length = length;
            this.CollectionId = collectionId;
            this.Created = created;
            this.Tags = tags;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        [DataMember(Name = "imageId", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// Make sure that the firmware image reports this version. If the version reported by this image is different the FOTA process won&#39;t be reported as successful since the device will report a version different from this.
        /// </summary>
        /// <value>Make sure that the firmware image reports this version. If the version reported by this image is different the FOTA process won&#39;t be reported as successful since the device will report a version different from this.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// This is just for internal house keeping, making it potentially easier to identify the firmware image.
        /// </summary>
        /// <value>This is just for internal house keeping, making it potentially easier to identify the firmware image.</value>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        public string Filename { get; set; }

        /// <summary>
        /// To ensure each image is unique the SHA-256 hash for all images in a collection must be unqique
        /// </summary>
        /// <value>To ensure each image is unique the SHA-256 hash for all images in a collection must be unqique</value>
        [DataMember(Name = "sha256", EmitDefaultValue = false)]
        public string Sha256 { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name = "length", EmitDefaultValue = false)]
        public int Length { get; set; }

        /// <summary>
        /// Collection ID for the collection owning the firmware image.
        /// </summary>
        /// <value>Collection ID for the collection owning the firmware image.</value>
        [DataMember(Name = "collectionId", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public string Created { get; set; }

        /// <summary>
        /// Tags for firmware image.
        /// </summary>
        /// <value>Tags for firmware image.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Firmware {\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Sha256: ").Append(Sha256).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as Firmware);
        }

        /// <summary>
        /// Returns true if Firmware instances are equal
        /// </summary>
        /// <param name="input">Instance of Firmware to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Firmware input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.Sha256 == input.Sha256 ||
                    (this.Sha256 != null &&
                    this.Sha256.Equals(input.Sha256))
                ) && 
                (
                    this.Length == input.Length ||
                    this.Length.Equals(input.Length)
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Filename != null)
                {
                    hashCode = (hashCode * 59) + this.Filename.GetHashCode();
                }
                if (this.Sha256 != null)
                {
                    hashCode = (hashCode * 59) + this.Sha256.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Length.GetHashCode();
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
