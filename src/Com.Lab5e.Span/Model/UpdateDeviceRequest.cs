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
    /// UpdateDeviceRequest
    /// </summary>
    [DataContract(Name = "UpdateDeviceRequest")]
    public partial class UpdateDeviceRequest : IEquatable<UpdateDeviceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDeviceRequest" /> class.
        /// </summary>
        /// <param name="existingCollectionId">existingCollectionId.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="collectionId">The collection id for the device. This field is optional and can be omitted if the collection id isn&#39;t changed. When changing to a new collection you must be an owner of the other collection, ie an administrator of the team that owns the new collection..</param>
        /// <param name="imsi">The IMSI is the unique ID for the (e|nu|whatever)SIM card on your device. This is the primary identifier for your device on the network..</param>
        /// <param name="imei">The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things..</param>
        /// <param name="tags">Tags are metadata for the device that you can set. These are just strings..</param>
        /// <param name="firmware">firmware.</param>
        public UpdateDeviceRequest(string existingCollectionId = default(string), string deviceId = default(string), string collectionId = default(string), string imsi = default(string), string imei = default(string), Dictionary<string, string> tags = default(Dictionary<string, string>), FirmwareMetadata firmware = default(FirmwareMetadata))
        {
            this.ExistingCollectionId = existingCollectionId;
            this.DeviceId = deviceId;
            this.CollectionId = collectionId;
            this.Imsi = imsi;
            this.Imei = imei;
            this.Tags = tags;
            this.Firmware = firmware;
        }

        /// <summary>
        /// Gets or Sets ExistingCollectionId
        /// </summary>
        [DataMember(Name = "existingCollectionId", EmitDefaultValue = false)]
        public string ExistingCollectionId { get; set; }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// The collection id for the device. This field is optional and can be omitted if the collection id isn&#39;t changed. When changing to a new collection you must be an owner of the other collection, ie an administrator of the team that owns the new collection.
        /// </summary>
        /// <value>The collection id for the device. This field is optional and can be omitted if the collection id isn&#39;t changed. When changing to a new collection you must be an owner of the other collection, ie an administrator of the team that owns the new collection.</value>
        [DataMember(Name = "collectionId", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// The IMSI is the unique ID for the (e|nu|whatever)SIM card on your device. This is the primary identifier for your device on the network.
        /// </summary>
        /// <value>The IMSI is the unique ID for the (e|nu|whatever)SIM card on your device. This is the primary identifier for your device on the network.</value>
        [DataMember(Name = "imsi", EmitDefaultValue = false)]
        public string Imsi { get; set; }

        /// <summary>
        /// The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things.
        /// </summary>
        /// <value>The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things.</value>
        [DataMember(Name = "imei", EmitDefaultValue = false)]
        public string Imei { get; set; }

        /// <summary>
        /// Tags are metadata for the device that you can set. These are just strings.
        /// </summary>
        /// <value>Tags are metadata for the device that you can set. These are just strings.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Firmware
        /// </summary>
        [DataMember(Name = "firmware", EmitDefaultValue = false)]
        public FirmwareMetadata Firmware { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDeviceRequest {\n");
            sb.Append("  ExistingCollectionId: ").Append(ExistingCollectionId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Imsi: ").Append(Imsi).Append("\n");
            sb.Append("  Imei: ").Append(Imei).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Firmware: ").Append(Firmware).Append("\n");
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
            return this.Equals(input as UpdateDeviceRequest);
        }

        /// <summary>
        /// Returns true if UpdateDeviceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateDeviceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDeviceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExistingCollectionId == input.ExistingCollectionId ||
                    (this.ExistingCollectionId != null &&
                    this.ExistingCollectionId.Equals(input.ExistingCollectionId))
                ) && 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.Imsi == input.Imsi ||
                    (this.Imsi != null &&
                    this.Imsi.Equals(input.Imsi))
                ) && 
                (
                    this.Imei == input.Imei ||
                    (this.Imei != null &&
                    this.Imei.Equals(input.Imei))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Firmware == input.Firmware ||
                    (this.Firmware != null &&
                    this.Firmware.Equals(input.Firmware))
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
                if (this.ExistingCollectionId != null)
                    hashCode = hashCode * 59 + this.ExistingCollectionId.GetHashCode();
                if (this.DeviceId != null)
                    hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.CollectionId != null)
                    hashCode = hashCode * 59 + this.CollectionId.GetHashCode();
                if (this.Imsi != null)
                    hashCode = hashCode * 59 + this.Imsi.GetHashCode();
                if (this.Imei != null)
                    hashCode = hashCode * 59 + this.Imei.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Firmware != null)
                    hashCode = hashCode * 59 + this.Firmware.GetHashCode();
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
