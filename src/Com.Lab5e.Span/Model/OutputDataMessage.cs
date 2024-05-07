/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.9.6 authoritarian-betty
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
    /// The output data message contains payload plus metadata for a payload received from a device.
    /// </summary>
    [DataContract(Name = "OutputDataMessage")]
    public partial class OutputDataMessage : IEquatable<OutputDataMessage>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public OutputMessageType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputDataMessage" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="device">device.</param>
        /// <param name="payload">payload.</param>
        /// <param name="received">Received time for message. Value is ms since epoch..</param>
        /// <param name="transport">transport.</param>
        /// <param name="udpMetaData">udpMetaData.</param>
        /// <param name="coapMetaData">coapMetaData.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="mqttMetaData">mqttMetaData.</param>
        /// <param name="gatewayMetaData">gatewayMetaData.</param>
        /// <param name="gatewayId">gatewayId.</param>
        public OutputDataMessage(OutputMessageType? type = default(OutputMessageType?), Device device = default(Device), byte[] payload = default(byte[]), string received = default(string), string transport = default(string), UDPMetadata udpMetaData = default(UDPMetadata), CoAPMetadata coapMetaData = default(CoAPMetadata), string messageId = default(string), MQTTMetadata mqttMetaData = default(MQTTMetadata), GatewayMetadata gatewayMetaData = default(GatewayMetadata), string gatewayId = default(string))
        {
            this.Type = type;
            this.Device = device;
            this.Payload = payload;
            this.Received = received;
            this.Transport = transport;
            this.UdpMetaData = udpMetaData;
            this.CoapMetaData = coapMetaData;
            this.MessageId = messageId;
            this.MqttMetaData = mqttMetaData;
            this.GatewayMetaData = gatewayMetaData;
            this.GatewayId = gatewayId;
        }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public Device Device { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public byte[] Payload { get; set; }

        /// <summary>
        /// Received time for message. Value is ms since epoch.
        /// </summary>
        /// <value>Received time for message. Value is ms since epoch.</value>
        [DataMember(Name = "received", EmitDefaultValue = false)]
        public string Received { get; set; }

        /// <summary>
        /// Gets or Sets Transport
        /// </summary>
        [DataMember(Name = "transport", EmitDefaultValue = false)]
        public string Transport { get; set; }

        /// <summary>
        /// Gets or Sets UdpMetaData
        /// </summary>
        [DataMember(Name = "udpMetaData", EmitDefaultValue = false)]
        public UDPMetadata UdpMetaData { get; set; }

        /// <summary>
        /// Gets or Sets CoapMetaData
        /// </summary>
        [DataMember(Name = "coapMetaData", EmitDefaultValue = false)]
        public CoAPMetadata CoapMetaData { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets MqttMetaData
        /// </summary>
        [DataMember(Name = "mqttMetaData", EmitDefaultValue = false)]
        public MQTTMetadata MqttMetaData { get; set; }

        /// <summary>
        /// Gets or Sets GatewayMetaData
        /// </summary>
        [DataMember(Name = "gatewayMetaData", EmitDefaultValue = false)]
        public GatewayMetadata GatewayMetaData { get; set; }

        /// <summary>
        /// Gets or Sets GatewayId
        /// </summary>
        [DataMember(Name = "gatewayId", EmitDefaultValue = false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutputDataMessage {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Received: ").Append(Received).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  UdpMetaData: ").Append(UdpMetaData).Append("\n");
            sb.Append("  CoapMetaData: ").Append(CoapMetaData).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MqttMetaData: ").Append(MqttMetaData).Append("\n");
            sb.Append("  GatewayMetaData: ").Append(GatewayMetaData).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
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
            return this.Equals(input as OutputDataMessage);
        }

        /// <summary>
        /// Returns true if OutputDataMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputDataMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputDataMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Received == input.Received ||
                    (this.Received != null &&
                    this.Received.Equals(input.Received))
                ) && 
                (
                    this.Transport == input.Transport ||
                    (this.Transport != null &&
                    this.Transport.Equals(input.Transport))
                ) && 
                (
                    this.UdpMetaData == input.UdpMetaData ||
                    (this.UdpMetaData != null &&
                    this.UdpMetaData.Equals(input.UdpMetaData))
                ) && 
                (
                    this.CoapMetaData == input.CoapMetaData ||
                    (this.CoapMetaData != null &&
                    this.CoapMetaData.Equals(input.CoapMetaData))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.MqttMetaData == input.MqttMetaData ||
                    (this.MqttMetaData != null &&
                    this.MqttMetaData.Equals(input.MqttMetaData))
                ) && 
                (
                    this.GatewayMetaData == input.GatewayMetaData ||
                    (this.GatewayMetaData != null &&
                    this.GatewayMetaData.Equals(input.GatewayMetaData))
                ) && 
                (
                    this.GatewayId == input.GatewayId ||
                    (this.GatewayId != null &&
                    this.GatewayId.Equals(input.GatewayId))
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Device != null)
                {
                    hashCode = (hashCode * 59) + this.Device.GetHashCode();
                }
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
                }
                if (this.Received != null)
                {
                    hashCode = (hashCode * 59) + this.Received.GetHashCode();
                }
                if (this.Transport != null)
                {
                    hashCode = (hashCode * 59) + this.Transport.GetHashCode();
                }
                if (this.UdpMetaData != null)
                {
                    hashCode = (hashCode * 59) + this.UdpMetaData.GetHashCode();
                }
                if (this.CoapMetaData != null)
                {
                    hashCode = (hashCode * 59) + this.CoapMetaData.GetHashCode();
                }
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.MqttMetaData != null)
                {
                    hashCode = (hashCode * 59) + this.MqttMetaData.GetHashCode();
                }
                if (this.GatewayMetaData != null)
                {
                    hashCode = (hashCode * 59) + this.GatewayMetaData.GetHashCode();
                }
                if (this.GatewayId != null)
                {
                    hashCode = (hashCode * 59) + this.GatewayId.GetHashCode();
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
