/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.6.1 squirming-codi
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
    /// This is the firmware configuration for a collection.
    /// </summary>
    [DataContract(Name = "CollectionFirmware")]
    public partial class CollectionFirmware : IEquatable<CollectionFirmware>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Management
        /// </summary>
        [DataMember(Name = "management", EmitDefaultValue = false)]
        public FirmwareManagement? Management { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionFirmware" /> class.
        /// </summary>
        /// <param name="currentFirmwareId">The current firmware is the firmware that the devices are currently using..</param>
        /// <param name="targetFirmwareId">The target firmware is set to the desired firmware image for the devices in this collection. If the management is set to \&quot;device\&quot; this will only be used if the target firmware isn&#39;t set on the device itself..</param>
        /// <param name="management">management.</param>
        public CollectionFirmware(string currentFirmwareId = default(string), string targetFirmwareId = default(string), FirmwareManagement? management = default(FirmwareManagement?))
        {
            this.CurrentFirmwareId = currentFirmwareId;
            this.TargetFirmwareId = targetFirmwareId;
            this.Management = management;
        }

        /// <summary>
        /// The current firmware is the firmware that the devices are currently using.
        /// </summary>
        /// <value>The current firmware is the firmware that the devices are currently using.</value>
        [DataMember(Name = "currentFirmwareId", EmitDefaultValue = false)]
        public string CurrentFirmwareId { get; set; }

        /// <summary>
        /// The target firmware is set to the desired firmware image for the devices in this collection. If the management is set to \&quot;device\&quot; this will only be used if the target firmware isn&#39;t set on the device itself.
        /// </summary>
        /// <value>The target firmware is set to the desired firmware image for the devices in this collection. If the management is set to \&quot;device\&quot; this will only be used if the target firmware isn&#39;t set on the device itself.</value>
        [DataMember(Name = "targetFirmwareId", EmitDefaultValue = false)]
        public string TargetFirmwareId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionFirmware {\n");
            sb.Append("  CurrentFirmwareId: ").Append(CurrentFirmwareId).Append("\n");
            sb.Append("  TargetFirmwareId: ").Append(TargetFirmwareId).Append("\n");
            sb.Append("  Management: ").Append(Management).Append("\n");
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
            return this.Equals(input as CollectionFirmware);
        }

        /// <summary>
        /// Returns true if CollectionFirmware instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectionFirmware to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionFirmware input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentFirmwareId == input.CurrentFirmwareId ||
                    (this.CurrentFirmwareId != null &&
                    this.CurrentFirmwareId.Equals(input.CurrentFirmwareId))
                ) && 
                (
                    this.TargetFirmwareId == input.TargetFirmwareId ||
                    (this.TargetFirmwareId != null &&
                    this.TargetFirmwareId.Equals(input.TargetFirmwareId))
                ) && 
                (
                    this.Management == input.Management ||
                    this.Management.Equals(input.Management)
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
                if (this.CurrentFirmwareId != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentFirmwareId.GetHashCode();
                }
                if (this.TargetFirmwareId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetFirmwareId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Management.GetHashCode();
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
