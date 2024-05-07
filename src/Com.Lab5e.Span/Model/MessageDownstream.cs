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
    /// Downstream messages are sent from the backend to the devices.
    /// </summary>
    [DataContract(Name = "MessageDownstream")]
    public partial class MessageDownstream : IEquatable<MessageDownstream>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Transport
        /// </summary>
        [DataMember(Name = "transport", EmitDefaultValue = false)]
        public MessageTransport? Transport { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public MessageState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDownstream" /> class.
        /// </summary>
        /// <param name="messageId">messageId.</param>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="gatewayId">gatewayId.</param>
        /// <param name="createdTime">createdTime.</param>
        /// <param name="sentTime">sentTime.</param>
        /// <param name="transport">transport.</param>
        /// <param name="state">state.</param>
        /// <param name="payload">payload.</param>
        public MessageDownstream(string messageId = default(string), string collectionId = default(string), string deviceId = default(string), string gatewayId = default(string), string createdTime = default(string), string sentTime = default(string), MessageTransport? transport = default(MessageTransport?), MessageState? state = default(MessageState?), byte[] payload = default(byte[]))
        {
            this.MessageId = messageId;
            this.CollectionId = collectionId;
            this.DeviceId = deviceId;
            this.GatewayId = gatewayId;
            this.CreatedTime = createdTime;
            this.SentTime = sentTime;
            this.Transport = transport;
            this.State = state;
            this.Payload = payload;
        }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

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
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name = "createdTime", EmitDefaultValue = false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets SentTime
        /// </summary>
        [DataMember(Name = "sentTime", EmitDefaultValue = false)]
        public string SentTime { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public byte[] Payload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MessageDownstream {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  SentTime: ").Append(SentTime).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
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
            return this.Equals(input as MessageDownstream);
        }

        /// <summary>
        /// Returns true if MessageDownstream instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageDownstream to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageDownstream input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
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
                    this.CreatedTime == input.CreatedTime ||
                    (this.CreatedTime != null &&
                    this.CreatedTime.Equals(input.CreatedTime))
                ) && 
                (
                    this.SentTime == input.SentTime ||
                    (this.SentTime != null &&
                    this.SentTime.Equals(input.SentTime))
                ) && 
                (
                    this.Transport == input.Transport ||
                    this.Transport.Equals(input.Transport)
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
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
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
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
                if (this.CreatedTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedTime.GetHashCode();
                }
                if (this.SentTime != null)
                {
                    hashCode = (hashCode * 59) + this.SentTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Transport.GetHashCode();
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.Payload != null)
                {
                    hashCode = (hashCode * 59) + this.Payload.GetHashCode();
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
