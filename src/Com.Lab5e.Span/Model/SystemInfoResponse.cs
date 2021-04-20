/*
 * The Span API
 *
 * API for device, collection, output and firmware management
 *
 * The version of the OpenAPI document: 4.1.7 prized-adelbert
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
    /// SystemInfoResponse
    /// </summary>
    [DataContract(Name = "SystemInfoResponse")]
    public partial class SystemInfoResponse : IEquatable<SystemInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoResponse" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="buildDate">buildDate.</param>
        /// <param name="releaseName">releaseName.</param>
        /// <param name="defaultFieldMask">defaultFieldMask.</param>
        /// <param name="forcedFieldMask">forcedFieldMask.</param>
        public SystemInfoResponse(string version = default(string), string buildDate = default(string), string releaseName = default(string), FieldMask defaultFieldMask = default(FieldMask), FieldMask forcedFieldMask = default(FieldMask))
        {
            this.Version = version;
            this.BuildDate = buildDate;
            this.ReleaseName = releaseName;
            this.DefaultFieldMask = defaultFieldMask;
            this.ForcedFieldMask = forcedFieldMask;
        }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets BuildDate
        /// </summary>
        [DataMember(Name = "buildDate", EmitDefaultValue = false)]
        public string BuildDate { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseName
        /// </summary>
        [DataMember(Name = "releaseName", EmitDefaultValue = false)]
        public string ReleaseName { get; set; }

        /// <summary>
        /// Gets or Sets DefaultFieldMask
        /// </summary>
        [DataMember(Name = "defaultFieldMask", EmitDefaultValue = false)]
        public FieldMask DefaultFieldMask { get; set; }

        /// <summary>
        /// Gets or Sets ForcedFieldMask
        /// </summary>
        [DataMember(Name = "forcedFieldMask", EmitDefaultValue = false)]
        public FieldMask ForcedFieldMask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemInfoResponse {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
            sb.Append("  ReleaseName: ").Append(ReleaseName).Append("\n");
            sb.Append("  DefaultFieldMask: ").Append(DefaultFieldMask).Append("\n");
            sb.Append("  ForcedFieldMask: ").Append(ForcedFieldMask).Append("\n");
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
            return this.Equals(input as SystemInfoResponse);
        }

        /// <summary>
        /// Returns true if SystemInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfoResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.BuildDate == input.BuildDate ||
                    (this.BuildDate != null &&
                    this.BuildDate.Equals(input.BuildDate))
                ) && 
                (
                    this.ReleaseName == input.ReleaseName ||
                    (this.ReleaseName != null &&
                    this.ReleaseName.Equals(input.ReleaseName))
                ) && 
                (
                    this.DefaultFieldMask == input.DefaultFieldMask ||
                    (this.DefaultFieldMask != null &&
                    this.DefaultFieldMask.Equals(input.DefaultFieldMask))
                ) && 
                (
                    this.ForcedFieldMask == input.ForcedFieldMask ||
                    (this.ForcedFieldMask != null &&
                    this.ForcedFieldMask.Equals(input.ForcedFieldMask))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.BuildDate != null)
                    hashCode = hashCode * 59 + this.BuildDate.GetHashCode();
                if (this.ReleaseName != null)
                    hashCode = hashCode * 59 + this.ReleaseName.GetHashCode();
                if (this.DefaultFieldMask != null)
                    hashCode = hashCode * 59 + this.DefaultFieldMask.GetHashCode();
                if (this.ForcedFieldMask != null)
                    hashCode = hashCode * 59 + this.ForcedFieldMask.GetHashCode();
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
