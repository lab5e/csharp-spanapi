/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.4.0 lean-joline
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
    /// List firmware response
    /// </summary>
    [DataContract(Name = "ListFirmwareResponse")]
    public partial class ListFirmwareResponse : IEquatable<ListFirmwareResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListFirmwareResponse" /> class.
        /// </summary>
        /// <param name="images">images.</param>
        public ListFirmwareResponse(List<Firmware> images = default(List<Firmware>))
        {
            this.Images = images;
        }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<Firmware> Images { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListFirmwareResponse {\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
            return this.Equals(input as ListFirmwareResponse);
        }

        /// <summary>
        /// Returns true if ListFirmwareResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListFirmwareResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListFirmwareResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
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
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
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
