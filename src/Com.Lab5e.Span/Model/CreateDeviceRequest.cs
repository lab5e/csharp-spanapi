/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.2.4 curable-andres
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
    /// Request object to create new devices
    /// </summary>
    [DataContract(Name = "CreateDeviceRequest")]
    public partial class CreateDeviceRequest : IEquatable<CreateDeviceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceRequest" /> class.
        /// </summary>
        /// <param name="tags">Tags are metadata for the device that you can set. These are just strings..</param>
        /// <param name="firmware">firmware.</param>
        /// <param name="config">config.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="imsi">The IMSI is the unique ID for the (e|nu|whatever)SIM card on your device. This is the primary identifier for your device on the network.  Deprecated: The IMSI is replaced by CellularIoTMetadata.</param>
        /// <param name="imei">The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things.  Deprecated: The IMEI is replaced by CellularIoTMetadata.</param>
        /// <param name="network">network.</param>
        public CreateDeviceRequest(Dictionary<string, string> tags = default(Dictionary<string, string>), FirmwareMetadata firmware = default(FirmwareMetadata), DeviceConfig config = default(DeviceConfig), DeviceMetadata metadata = default(DeviceMetadata), string imsi = default(string), string imei = default(string), NetworkMetadata network = default(NetworkMetadata))
        {
            this.Tags = tags;
            this.Firmware = firmware;
            this.Config = config;
            this.Metadata = metadata;
            this.Imsi = imsi;
            this.Imei = imei;
            this.Network = network;
        }

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
        /// The IMSI is the unique ID for the (e|nu|whatever)SIM card on your device. This is the primary identifier for your device on the network.  Deprecated: The IMSI is replaced by CellularIoTMetadata
        /// </summary>
        /// <value>The IMSI is the unique ID for the (e|nu|whatever)SIM card on your device. This is the primary identifier for your device on the network.  Deprecated: The IMSI is replaced by CellularIoTMetadata</value>
        [DataMember(Name = "imsi", EmitDefaultValue = false)]
        public string Imsi { get; set; }

        /// <summary>
        /// The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things.  Deprecated: The IMEI is replaced by CellularIoTMetadata
        /// </summary>
        /// <value>The IMEI number is the unique ID for your hardware as seen by the network. Obviously you might have a completely different view on things.  Deprecated: The IMEI is replaced by CellularIoTMetadata</value>
        [DataMember(Name = "imei", EmitDefaultValue = false)]
        public string Imei { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public NetworkMetadata Network { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateDeviceRequest {\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Firmware: ").Append(Firmware).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Imsi: ").Append(Imsi).Append("\n");
            sb.Append("  Imei: ").Append(Imei).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
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
            return this.Equals(input as CreateDeviceRequest);
        }

        /// <summary>
        /// Returns true if CreateDeviceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDeviceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDeviceRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
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
                if (this.Imsi != null)
                {
                    hashCode = (hashCode * 59) + this.Imsi.GetHashCode();
                }
                if (this.Imei != null)
                {
                    hashCode = (hashCode * 59) + this.Imei.GetHashCode();
                }
                if (this.Network != null)
                {
                    hashCode = (hashCode * 59) + this.Network.GetHashCode();
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
