/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.0 convulsive-launa
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
    /// GatewayConfig
    /// </summary>
    [DataContract(Name = "GatewayConfig")]
    public partial class GatewayConfig : IEquatable<GatewayConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayConfig" /> class.
        /// </summary>
        /// <param name="ciot">ciot.</param>
        /// <param name="inet">inet.</param>
        /// <param name="user">user.</param>
        public GatewayConfig(GatewayCIoTConfig ciot = default(GatewayCIoTConfig), GatewayInetConfig inet = default(GatewayInetConfig), GatewayCustomConfig user = default(GatewayCustomConfig))
        {
            this.Ciot = ciot;
            this.Inet = inet;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Ciot
        /// </summary>
        [DataMember(Name = "ciot", EmitDefaultValue = false)]
        public GatewayCIoTConfig Ciot { get; set; }

        /// <summary>
        /// Gets or Sets Inet
        /// </summary>
        [DataMember(Name = "inet", EmitDefaultValue = false)]
        public GatewayInetConfig Inet { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public GatewayCustomConfig User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GatewayConfig {\n");
            sb.Append("  Ciot: ").Append(Ciot).Append("\n");
            sb.Append("  Inet: ").Append(Inet).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as GatewayConfig);
        }

        /// <summary>
        /// Returns true if GatewayConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ciot == input.Ciot ||
                    (this.Ciot != null &&
                    this.Ciot.Equals(input.Ciot))
                ) && 
                (
                    this.Inet == input.Inet ||
                    (this.Inet != null &&
                    this.Inet.Equals(input.Inet))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Ciot != null)
                {
                    hashCode = (hashCode * 59) + this.Ciot.GetHashCode();
                }
                if (this.Inet != null)
                {
                    hashCode = (hashCode * 59) + this.Inet.GetHashCode();
                }
                if (this.User != null)
                {
                    hashCode = (hashCode * 59) + this.User.GetHashCode();
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
