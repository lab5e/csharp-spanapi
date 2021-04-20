/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.8 adopted-kali
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
    /// DumpedCollection
    /// </summary>
    [DataContract(Name = "DumpedCollection")]
    public partial class DumpedCollection : IEquatable<DumpedCollection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DumpedCollection" /> class.
        /// </summary>
        /// <param name="collection">collection.</param>
        /// <param name="devices">devices.</param>
        /// <param name="outputs">outputs.</param>
        public DumpedCollection(Collection collection = default(Collection), List<DumpedDevice> devices = default(List<DumpedDevice>), List<Output> outputs = default(List<Output>))
        {
            this.Collection = collection;
            this.Devices = devices;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Gets or Sets Collection
        /// </summary>
        [DataMember(Name = "collection", EmitDefaultValue = false)]
        public Collection Collection { get; set; }

        /// <summary>
        /// Gets or Sets Devices
        /// </summary>
        [DataMember(Name = "devices", EmitDefaultValue = false)]
        public List<DumpedDevice> Devices { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        public List<Output> Outputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DumpedCollection {\n");
            sb.Append("  Collection: ").Append(Collection).Append("\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return this.Equals(input as DumpedCollection);
        }

        /// <summary>
        /// Returns true if DumpedCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of DumpedCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DumpedCollection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Collection == input.Collection ||
                    (this.Collection != null &&
                    this.Collection.Equals(input.Collection))
                ) && 
                (
                    this.Devices == input.Devices ||
                    this.Devices != null &&
                    input.Devices != null &&
                    this.Devices.SequenceEqual(input.Devices)
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
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
                if (this.Collection != null)
                    hashCode = hashCode * 59 + this.Collection.GetHashCode();
                if (this.Devices != null)
                    hashCode = hashCode * 59 + this.Devices.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
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
