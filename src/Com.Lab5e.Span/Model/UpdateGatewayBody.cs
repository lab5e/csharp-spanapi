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
    /// UpdateGatewayBody
    /// </summary>
    [DataContract(Name = "UpdateGatewayBody")]
    public partial class UpdateGatewayBody : IEquatable<UpdateGatewayBody>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public GatewayType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGatewayBody" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="collectionId">collectionId.</param>
        /// <param name="type">type.</param>
        /// <param name="config">config.</param>
        /// <param name="tags">tags.</param>
        /// <param name="enabled">enabled.</param>
        public UpdateGatewayBody(string name = default(string), string collectionId = default(string), GatewayType? type = default(GatewayType?), GatewayConfig config = default(GatewayConfig), Dictionary<string, string> tags = default(Dictionary<string, string>), bool enabled = default(bool))
        {
            this.Name = name;
            this.CollectionId = collectionId;
            this.Type = type;
            this.Config = config;
            this.Tags = tags;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CollectionId
        /// </summary>
        [DataMember(Name = "collectionId", EmitDefaultValue = false)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public GatewayConfig Config { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
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
            sb.Append("class UpdateGatewayBody {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CollectionId: ").Append(CollectionId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
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
            return this.Equals(input as UpdateGatewayBody);
        }

        /// <summary>
        /// Returns true if UpdateGatewayBody instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateGatewayBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateGatewayBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CollectionId == input.CollectionId ||
                    (this.CollectionId != null &&
                    this.CollectionId.Equals(input.CollectionId))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.CollectionId != null)
                {
                    hashCode = (hashCode * 59) + this.CollectionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
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
