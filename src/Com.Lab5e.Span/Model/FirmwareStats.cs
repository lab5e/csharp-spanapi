/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 5.0.5 contented-jamila
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
    /// Statistics for a single firmware image
    /// </summary>
    [DataContract(Name = "FirmwareStats")]
    public partial class FirmwareStats : IEquatable<FirmwareStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareStats" /> class.
        /// </summary>
        /// <param name="firmwareImageSize">firmwareImageSize.</param>
        public FirmwareStats(int firmwareImageSize = default(int))
        {
            this.FirmwareImageSize = firmwareImageSize;
        }

        /// <summary>
        /// Gets or Sets FirmwareImageSize
        /// </summary>
        [DataMember(Name = "firmwareImageSize", EmitDefaultValue = false)]
        public int FirmwareImageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirmwareStats {\n");
            sb.Append("  FirmwareImageSize: ").Append(FirmwareImageSize).Append("\n");
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
            return this.Equals(input as FirmwareStats);
        }

        /// <summary>
        /// Returns true if FirmwareStats instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmwareStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareStats input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FirmwareImageSize == input.FirmwareImageSize ||
                    this.FirmwareImageSize.Equals(input.FirmwareImageSize)
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
                hashCode = (hashCode * 59) + this.FirmwareImageSize.GetHashCode();
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
