/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.7 prized-adelbert
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
    /// BroadcastMessageRequest
    /// </summary>
    [DataContract(Name = "BroadcastMessageRequest")]
    public partial class BroadcastMessageRequest : IEquatable<BroadcastMessageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BroadcastMessageRequest" /> class.
        /// </summary>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="port">port.</param>
        /// <param name="payload">payload.</param>
        /// <param name="transport">Valid transports are \&quot;udp\&quot;, \&quot;coap\&quot;, \&quot;coap-pull\&quot;, \&quot;udp-pull\&quot;, \&quot;coap-push\&quot;, \&quot;udp-push\&quot;. \&quot;udp\&quot; is equivalent to \&quot;udp-push\&quot; and \&quot;coap\&quot; is equivalent to \&quot;coap-push\&quot;. Push messages are sent unsolicited to the device wheil pull messages are sent whenever the device wither sends data upstream (for UDP) or does a CoAP request to the CoAP service in span..</param>
        /// <param name="coapPath">coapPath.</param>
        public BroadcastMessageRequest(string collectionId = default(string), int port = default(int), byte[] payload = default(byte[]), string transport = default(string), string coapPath = default(string))
        {
            this.CollectionId = collectionId;
            this.Port = port;
            this.Payload = payload;
            this.Transport = transport;
            this.CoapPath = coapPath;
        }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public byte[] Payload { get; set; }

        /// <summary>
        /// Valid transports are \&quot;udp\&quot;, \&quot;coap\&quot;, \&quot;coap-pull\&quot;, \&quot;udp-pull\&quot;, \&quot;coap-push\&quot;, \&quot;udp-push\&quot;. \&quot;udp\&quot; is equivalent to \&quot;udp-push\&quot; and \&quot;coap\&quot; is equivalent to \&quot;coap-push\&quot;. Push messages are sent unsolicited to the device wheil pull messages are sent whenever the device wither sends data upstream (for UDP) or does a CoAP request to the CoAP service in span.
        /// </summary>
        /// <value>Valid transports are \&quot;udp\&quot;, \&quot;coap\&quot;, \&quot;coap-pull\&quot;, \&quot;udp-pull\&quot;, \&quot;coap-push\&quot;, \&quot;udp-push\&quot;. \&quot;udp\&quot; is equivalent to \&quot;udp-push\&quot; and \&quot;coap\&quot; is equivalent to \&quot;coap-push\&quot;. Push messages are sent unsolicited to the device wheil pull messages are sent whenever the device wither sends data upstream (for UDP) or does a CoAP request to the CoAP service in span.</value>
        [DataMember(Name = "transport", EmitDefaultValue = false)]
        public string Transport { get; set; }

        /// <summary>
        /// Gets or Sets CoapPath
        /// </summary>
        [DataMember(Name = "coapPath", EmitDefaultValue = false)]
        public string CoapPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BroadcastMessageRequest {\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Transport: ").Append(Transport).Append("\n");
            sb.Append("  CoapPath: ").Append(CoapPath).Append("\n");
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
            return this.Equals(input as BroadcastMessageRequest);
        }

        /// <summary>
        /// Returns true if BroadcastMessageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BroadcastMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BroadcastMessageRequest input)
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
                    this.Port == input.Port ||
                    this.Port.Equals(input.Port)
                ) && 
                (
                    this.Payload == input.Payload ||
                    (this.Payload != null &&
                    this.Payload.Equals(input.Payload))
                ) && 
                (
                    this.Transport == input.Transport ||
                    (this.Transport != null &&
                    this.Transport.Equals(input.Transport))
                ) && 
                (
                    this.CoapPath == input.CoapPath ||
                    (this.CoapPath != null &&
                    this.CoapPath.Equals(input.CoapPath))
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
                hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Payload != null)
                    hashCode = hashCode * 59 + this.Payload.GetHashCode();
                if (this.Transport != null)
                    hashCode = hashCode * 59 + this.Transport.GetHashCode();
                if (this.CoapPath != null)
                    hashCode = hashCode * 59 + this.CoapPath.GetHashCode();
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
