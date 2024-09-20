/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.2 subversive-jamila
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
    /// This a device
    /// </summary>
    [DataContract(Name = "Device")]
    public partial class Device : IEquatable<Device>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LastTransport
        /// </summary>
        [DataMember(Name = "lastTransport", EmitDefaultValue = false)]
        public MessageTransport? LastTransport { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        /// <param name="deviceId">The device ID is assigned by the backend..</param>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="tags">Tags are metadata for the device that you can set. These are just strings..</param>
        /// <param name="firmware">firmware.</param>
        /// <param name="config">config.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="lastGatewayId">lastGatewayId.</param>
        /// <param name="lastTransport">lastTransport.</param>
        /// <param name="lastReceived">lastReceived.</param>
        /// <param name="lastPayload">lastPayload.</param>
        /// <param name="enabled">enabled.</param>
        public Device(string deviceId = default(string), string collectionId = default(string), Dictionary<string, string> tags = default(Dictionary<string, string>), FirmwareMetadata firmware = default(FirmwareMetadata), DeviceConfig config = default(DeviceConfig), DeviceMetadata metadata = default(DeviceMetadata), string lastGatewayId = default(string), MessageTransport? lastTransport = default(MessageTransport?), string lastReceived = default(string), byte[] lastPayload = default(byte[]), bool enabled = default(bool))
        {
            this.DeviceId = deviceId;
            this.CollectionId = collectionId;
            this.Tags = tags;
            this.Firmware = firmware;
            this.Config = config;
            this.Metadata = metadata;
            this.LastGatewayId = lastGatewayId;
            this.LastTransport = lastTransport;
            this.LastReceived = lastReceived;
            this.LastPayload = lastPayload;
            this.Enabled = enabled;
        }

        /// <summary>
        /// The device ID is assigned by the backend.
        /// </summary>
        /// <value>The device ID is assigned by the backend.</value>
        [DataMember(Name = "deviceId", EmitDefaultValue = false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

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
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public DeviceConfig Config { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public DeviceMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets LastGatewayId
        /// </summary>
        [DataMember(Name = "lastGatewayId", EmitDefaultValue = false)]
        public string LastGatewayId { get; set; }

        /// <summary>
        /// Gets or Sets LastReceived
        /// </summary>
        [DataMember(Name = "lastReceived", EmitDefaultValue = false)]
        public string LastReceived { get; set; }

        /// <summary>
        /// Gets or Sets LastPayload
        /// </summary>
        [DataMember(Name = "lastPayload", EmitDefaultValue = false)]
        public byte[] LastPayload { get; set; }

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
            sb.Append("class Device {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Firmware: ").Append(Firmware).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  LastGatewayId: ").Append(LastGatewayId).Append("\n");
            sb.Append("  LastTransport: ").Append(LastTransport).Append("\n");
            sb.Append("  LastReceived: ").Append(LastReceived).Append("\n");
            sb.Append("  LastPayload: ").Append(LastPayload).Append("\n");
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
            return this.Equals(input as Device);
        }

        /// <summary>
        /// Returns true if Device instances are equal
        /// </summary>
        /// <param name="input">Instance of Device to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Device input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Firmware == input.Firmware ||
                    (this.Firmware != null &&
                    this.Firmware.Equals(input.Firmware))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.LastGatewayId == input.LastGatewayId ||
                    (this.LastGatewayId != null &&
                    this.LastGatewayId.Equals(input.LastGatewayId))
                ) && 
                (
                    this.LastTransport == input.LastTransport ||
                    this.LastTransport.Equals(input.LastTransport)
                ) && 
                (
                    this.LastReceived == input.LastReceived ||
                    (this.LastReceived != null &&
                    this.LastReceived.Equals(input.LastReceived))
                ) && 
                (
                    this.LastPayload == input.LastPayload ||
                    (this.LastPayload != null &&
                    this.LastPayload.Equals(input.LastPayload))
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
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Firmware != null)
                {
                    hashCode = (hashCode * 59) + this.Firmware.GetHashCode();
                }
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.LastGatewayId != null)
                {
                    hashCode = (hashCode * 59) + this.LastGatewayId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastTransport.GetHashCode();
                if (this.LastReceived != null)
                {
                    hashCode = (hashCode * 59) + this.LastReceived.GetHashCode();
                }
                if (this.LastPayload != null)
                {
                    hashCode = (hashCode * 59) + this.LastPayload.GetHashCode();
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
