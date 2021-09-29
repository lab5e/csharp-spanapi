/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.18 disgruntled-jerald
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
    /// DeviceMetadata
    /// </summary>
    [DataContract(Name = "DeviceMetadata")]
    public partial class DeviceMetadata : IEquatable<DeviceMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceMetadata" /> class.
        /// </summary>
        /// <param name="simOperator">simOperator.</param>
        public DeviceMetadata(NetworkOperator simOperator = default(NetworkOperator))
        {
            this.SimOperator = simOperator;
        }

        /// <summary>
        /// Gets or Sets SimOperator
        /// </summary>
        [DataMember(Name = "simOperator", EmitDefaultValue = false)]
        public NetworkOperator SimOperator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceMetadata {\n");
            sb.Append("  SimOperator: ").Append(SimOperator).Append("\n");
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
            return this.Equals(input as DeviceMetadata);
        }

        /// <summary>
        /// Returns true if DeviceMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SimOperator == input.SimOperator ||
                    (this.SimOperator != null &&
                    this.SimOperator.Equals(input.SimOperator))
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
                if (this.SimOperator != null)
                    hashCode = hashCode * 59 + this.SimOperator.GetHashCode();
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
