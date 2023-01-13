/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.3.0 grouchy-aloysius
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
    /// Configuration for outputs.
    /// </summary>
    [DataContract(Name = "OutputConfig")]
    public partial class OutputConfig : IEquatable<OutputConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutputConfig" /> class.
        /// </summary>
        /// <param name="url">URL for the webhook..</param>
        /// <param name="basicAuthUser">basicAuthUser.</param>
        /// <param name="basicAuthPass">basicAuthPass.</param>
        /// <param name="customHeaderName">customHeaderName.</param>
        /// <param name="customHeaderValue">customHeaderValue.</param>
        /// <param name="host">host.</param>
        /// <param name="port">port.</param>
        /// <param name="key">key.</param>
        /// <param name="eventName">eventName.</param>
        /// <param name="asIsPayload">asIsPayload.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="disableCertCheck">MQTT configuration: Disable certificate checks. Default is off..</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="topicName">topicName.</param>
        /// <param name="topicTemplate">topicTemplate.</param>
        /// <param name="payloadFormat">payloadFormat.</param>
        /// <param name="payloadTemplate">payloadTemplate.</param>
        public OutputConfig(string url = default(string), string basicAuthUser = default(string), string basicAuthPass = default(string), string customHeaderName = default(string), string customHeaderValue = default(string), string host = default(string), int port = default(int), string key = default(string), string eventName = default(string), bool asIsPayload = default(bool), string endpoint = default(string), bool disableCertCheck = default(bool), string username = default(string), string password = default(string), string clientId = default(string), string topicName = default(string), byte[] topicTemplate = default(byte[]), string payloadFormat = default(string), byte[] payloadTemplate = default(byte[]))
        {
            this.Url = url;
            this.BasicAuthUser = basicAuthUser;
            this.BasicAuthPass = basicAuthPass;
            this.CustomHeaderName = customHeaderName;
            this.CustomHeaderValue = customHeaderValue;
            this.Host = host;
            this.Port = port;
            this.Key = key;
            this.EventName = eventName;
            this.AsIsPayload = asIsPayload;
            this.Endpoint = endpoint;
            this.DisableCertCheck = disableCertCheck;
            this.Username = username;
            this.Password = password;
            this.ClientId = clientId;
            this.TopicName = topicName;
            this.TopicTemplate = topicTemplate;
            this.PayloadFormat = payloadFormat;
            this.PayloadTemplate = payloadTemplate;
        }

        /// <summary>
        /// URL for the webhook.
        /// </summary>
        /// <value>URL for the webhook.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets BasicAuthUser
        /// </summary>
        [DataMember(Name = "basicAuthUser", EmitDefaultValue = false)]
        public string BasicAuthUser { get; set; }

        /// <summary>
        /// Gets or Sets BasicAuthPass
        /// </summary>
        [DataMember(Name = "basicAuthPass", EmitDefaultValue = false)]
        public string BasicAuthPass { get; set; }

        /// <summary>
        /// Gets or Sets CustomHeaderName
        /// </summary>
        [DataMember(Name = "customHeaderName", EmitDefaultValue = false)]
        public string CustomHeaderName { get; set; }

        /// <summary>
        /// Gets or Sets CustomHeaderValue
        /// </summary>
        [DataMember(Name = "customHeaderValue", EmitDefaultValue = false)]
        public string CustomHeaderValue { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name = "eventName", EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets AsIsPayload
        /// </summary>
        [DataMember(Name = "asIsPayload", EmitDefaultValue = true)]
        public bool AsIsPayload { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// MQTT configuration: Disable certificate checks. Default is off.
        /// </summary>
        /// <value>MQTT configuration: Disable certificate checks. Default is off.</value>
        [DataMember(Name = "disableCertCheck", EmitDefaultValue = true)]
        public bool DisableCertCheck { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name = "clientId", EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets TopicName
        /// </summary>
        [DataMember(Name = "topicName", EmitDefaultValue = false)]
        public string TopicName { get; set; }

        /// <summary>
        /// Gets or Sets TopicTemplate
        /// </summary>
        [DataMember(Name = "topicTemplate", EmitDefaultValue = false)]
        public byte[] TopicTemplate { get; set; }

        /// <summary>
        /// Gets or Sets PayloadFormat
        /// </summary>
        [DataMember(Name = "payloadFormat", EmitDefaultValue = false)]
        public string PayloadFormat { get; set; }

        /// <summary>
        /// Gets or Sets PayloadTemplate
        /// </summary>
        [DataMember(Name = "payloadTemplate", EmitDefaultValue = false)]
        public byte[] PayloadTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OutputConfig {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  BasicAuthUser: ").Append(BasicAuthUser).Append("\n");
            sb.Append("  BasicAuthPass: ").Append(BasicAuthPass).Append("\n");
            sb.Append("  CustomHeaderName: ").Append(CustomHeaderName).Append("\n");
            sb.Append("  CustomHeaderValue: ").Append(CustomHeaderValue).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  AsIsPayload: ").Append(AsIsPayload).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  DisableCertCheck: ").Append(DisableCertCheck).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  TopicName: ").Append(TopicName).Append("\n");
            sb.Append("  TopicTemplate: ").Append(TopicTemplate).Append("\n");
            sb.Append("  PayloadFormat: ").Append(PayloadFormat).Append("\n");
            sb.Append("  PayloadTemplate: ").Append(PayloadTemplate).Append("\n");
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
            return this.Equals(input as OutputConfig);
        }

        /// <summary>
        /// Returns true if OutputConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of OutputConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutputConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.BasicAuthUser == input.BasicAuthUser ||
                    (this.BasicAuthUser != null &&
                    this.BasicAuthUser.Equals(input.BasicAuthUser))
                ) && 
                (
                    this.BasicAuthPass == input.BasicAuthPass ||
                    (this.BasicAuthPass != null &&
                    this.BasicAuthPass.Equals(input.BasicAuthPass))
                ) && 
                (
                    this.CustomHeaderName == input.CustomHeaderName ||
                    (this.CustomHeaderName != null &&
                    this.CustomHeaderName.Equals(input.CustomHeaderName))
                ) && 
                (
                    this.CustomHeaderValue == input.CustomHeaderValue ||
                    (this.CustomHeaderValue != null &&
                    this.CustomHeaderValue.Equals(input.CustomHeaderValue))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Port == input.Port ||
                    this.Port.Equals(input.Port)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.EventName == input.EventName ||
                    (this.EventName != null &&
                    this.EventName.Equals(input.EventName))
                ) && 
                (
                    this.AsIsPayload == input.AsIsPayload ||
                    this.AsIsPayload.Equals(input.AsIsPayload)
                ) && 
                (
                    this.Endpoint == input.Endpoint ||
                    (this.Endpoint != null &&
                    this.Endpoint.Equals(input.Endpoint))
                ) && 
                (
                    this.DisableCertCheck == input.DisableCertCheck ||
                    this.DisableCertCheck.Equals(input.DisableCertCheck)
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.TopicName == input.TopicName ||
                    (this.TopicName != null &&
                    this.TopicName.Equals(input.TopicName))
                ) && 
                (
                    this.TopicTemplate == input.TopicTemplate ||
                    (this.TopicTemplate != null &&
                    this.TopicTemplate.Equals(input.TopicTemplate))
                ) && 
                (
                    this.PayloadFormat == input.PayloadFormat ||
                    (this.PayloadFormat != null &&
                    this.PayloadFormat.Equals(input.PayloadFormat))
                ) && 
                (
                    this.PayloadTemplate == input.PayloadTemplate ||
                    (this.PayloadTemplate != null &&
                    this.PayloadTemplate.Equals(input.PayloadTemplate))
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.BasicAuthUser != null)
                {
                    hashCode = (hashCode * 59) + this.BasicAuthUser.GetHashCode();
                }
                if (this.BasicAuthPass != null)
                {
                    hashCode = (hashCode * 59) + this.BasicAuthPass.GetHashCode();
                }
                if (this.CustomHeaderName != null)
                {
                    hashCode = (hashCode * 59) + this.CustomHeaderName.GetHashCode();
                }
                if (this.CustomHeaderValue != null)
                {
                    hashCode = (hashCode * 59) + this.CustomHeaderValue.GetHashCode();
                }
                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Port.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.EventName != null)
                {
                    hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AsIsPayload.GetHashCode();
                if (this.Endpoint != null)
                {
                    hashCode = (hashCode * 59) + this.Endpoint.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisableCertCheck.GetHashCode();
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.TopicName != null)
                {
                    hashCode = (hashCode * 59) + this.TopicName.GetHashCode();
                }
                if (this.TopicTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.TopicTemplate.GetHashCode();
                }
                if (this.PayloadFormat != null)
                {
                    hashCode = (hashCode * 59) + this.PayloadFormat.GetHashCode();
                }
                if (this.PayloadTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.PayloadTemplate.GetHashCode();
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
