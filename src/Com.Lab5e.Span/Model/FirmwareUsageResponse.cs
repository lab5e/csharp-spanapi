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
    /// Firmware usage report
    /// </summary>
    [DataContract(Name = "FirmwareUsageResponse")]
    public partial class FirmwareUsageResponse : IEquatable<FirmwareUsageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUsageResponse" /> class.
        /// </summary>
        /// <param name="imageId">imageId.</param>
        /// <param name="targeted">targeted.</param>
        /// <param name="current">current.</param>
        public FirmwareUsageResponse(string imageId = default(string), List<string> targeted = default(List<string>), List<string> current = default(List<string>))
        {
            this.ImageId = imageId;
            this.Targeted = targeted;
            this.Current = current;
        }

        /// <summary>
        /// Gets or Sets ImageId
        /// </summary>
        [DataMember(Name = "imageId", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// Gets or Sets Targeted
        /// </summary>
        [DataMember(Name = "targeted", EmitDefaultValue = false)]
        public List<string> Targeted { get; set; }

        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name = "current", EmitDefaultValue = false)]
        public List<string> Current { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FirmwareUsageResponse {\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  Targeted: ").Append(Targeted).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
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
            return this.Equals(input as FirmwareUsageResponse);
        }

        /// <summary>
        /// Returns true if FirmwareUsageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FirmwareUsageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareUsageResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.Targeted == input.Targeted ||
                    this.Targeted != null &&
                    input.Targeted != null &&
                    this.Targeted.SequenceEqual(input.Targeted)
                ) && 
                (
                    this.Current == input.Current ||
                    this.Current != null &&
                    input.Current != null &&
                    this.Current.SequenceEqual(input.Current)
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
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                if (this.Targeted != null)
                {
                    hashCode = (hashCode * 59) + this.Targeted.GetHashCode();
                }
                if (this.Current != null)
                {
                    hashCode = (hashCode * 59) + this.Current.GetHashCode();
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
