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
    /// Response object for system information. This contains system-level information.
    /// </summary>
    [DataContract(Name = "SystemInfoResponse")]
    public partial class SystemInfoResponse : IEquatable<SystemInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoResponse" /> class.
        /// </summary>
        /// <param name="version">This is the system version.</param>
        /// <param name="buildDate">The build time for this version..</param>
        /// <param name="releaseName">Human-readable code name for this release. This can be easier to remember than the version number..</param>
        public SystemInfoResponse(string version = default(string), string buildDate = default(string), string releaseName = default(string))
        {
            this._Version = version;
            this.BuildDate = buildDate;
            this.ReleaseName = releaseName;
        }

        /// <summary>
        /// This is the system version
        /// </summary>
        /// <value>This is the system version</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string _Version { get; set; }

        /// <summary>
        /// The build time for this version.
        /// </summary>
        /// <value>The build time for this version.</value>
        [DataMember(Name = "buildDate", EmitDefaultValue = false)]
        public string BuildDate { get; set; }

        /// <summary>
        /// Human-readable code name for this release. This can be easier to remember than the version number.
        /// </summary>
        /// <value>Human-readable code name for this release. This can be easier to remember than the version number.</value>
        [DataMember(Name = "releaseName", EmitDefaultValue = false)]
        public string ReleaseName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SystemInfoResponse {\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  BuildDate: ").Append(BuildDate).Append("\n");
            sb.Append("  ReleaseName: ").Append(ReleaseName).Append("\n");
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
            {
                return false;
            }
            return 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.BuildDate != null)
                {
                    hashCode = (hashCode * 59) + this.BuildDate.GetHashCode();
                }
                if (this.ReleaseName != null)
                {
                    hashCode = (hashCode * 59) + this.ReleaseName.GetHashCode();
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
