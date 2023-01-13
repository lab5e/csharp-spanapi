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
    /// This is the configuration for the device via the various gateways.
    /// </summary>
    [DataContract(Name = "DeviceConfig")]
    public partial class DeviceConfig : IEquatable<DeviceConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceConfig" /> class.
        /// </summary>
        /// <param name="ciot">ciot.</param>
        public DeviceConfig(CellularIoTConfig ciot = default(CellularIoTConfig))
        {
            this.Ciot = ciot;
        }

        /// <summary>
        /// Gets or Sets Ciot
        /// </summary>
        [DataMember(Name = "ciot", EmitDefaultValue = false)]
        public CellularIoTConfig Ciot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceConfig {\n");
            sb.Append("  Ciot: ").Append(Ciot).Append("\n");
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
            return this.Equals(input as DeviceConfig);
        }

        /// <summary>
        /// Returns true if DeviceConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceConfig input)
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
