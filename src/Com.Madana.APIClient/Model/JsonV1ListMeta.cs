/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.17
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Madana.APIClient.Client.OpenAPIDateConverter;

namespace Com.Madana.APIClient.Model
{
    /// <summary>
    /// JsonV1ListMeta
    /// </summary>
    [DataContract]
    public partial class JsonV1ListMeta :  IEquatable<JsonV1ListMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonV1ListMeta" /> class.
        /// </summary>
        /// <param name="remainingItemCount">remainingItemCount.</param>
        /// <param name="resourceVersion">resourceVersion.</param>
        /// <param name="selfLink">selfLink.</param>
        /// <param name="_continue">_continue.</param>
        public JsonV1ListMeta(decimal remainingItemCount = default(decimal), string resourceVersion = default(string), string selfLink = default(string), string _continue = default(string))
        {
            this.RemainingItemCount = remainingItemCount;
            this.ResourceVersion = resourceVersion;
            this.SelfLink = selfLink;
            this.Continue = _continue;
        }
        
        /// <summary>
        /// Gets or Sets RemainingItemCount
        /// </summary>
        [DataMember(Name="remainingItemCount", EmitDefaultValue=false)]
        public decimal RemainingItemCount { get; set; }

        /// <summary>
        /// Gets or Sets ResourceVersion
        /// </summary>
        [DataMember(Name="resourceVersion", EmitDefaultValue=false)]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// Gets or Sets SelfLink
        /// </summary>
        [DataMember(Name="selfLink", EmitDefaultValue=false)]
        public string SelfLink { get; set; }

        /// <summary>
        /// Gets or Sets Continue
        /// </summary>
        [DataMember(Name="continue", EmitDefaultValue=false)]
        public string Continue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonV1ListMeta {\n");
            sb.Append("  RemainingItemCount: ").Append(RemainingItemCount).Append("\n");
            sb.Append("  ResourceVersion: ").Append(ResourceVersion).Append("\n");
            sb.Append("  SelfLink: ").Append(SelfLink).Append("\n");
            sb.Append("  Continue: ").Append(Continue).Append("\n");
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
            return this.Equals(input as JsonV1ListMeta);
        }

        /// <summary>
        /// Returns true if JsonV1ListMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonV1ListMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonV1ListMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemainingItemCount == input.RemainingItemCount ||
                    (this.RemainingItemCount != null &&
                    this.RemainingItemCount.Equals(input.RemainingItemCount))
                ) && 
                (
                    this.ResourceVersion == input.ResourceVersion ||
                    (this.ResourceVersion != null &&
                    this.ResourceVersion.Equals(input.ResourceVersion))
                ) && 
                (
                    this.SelfLink == input.SelfLink ||
                    (this.SelfLink != null &&
                    this.SelfLink.Equals(input.SelfLink))
                ) && 
                (
                    this.Continue == input.Continue ||
                    (this.Continue != null &&
                    this.Continue.Equals(input.Continue))
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
                if (this.RemainingItemCount != null)
                    hashCode = hashCode * 59 + this.RemainingItemCount.GetHashCode();
                if (this.ResourceVersion != null)
                    hashCode = hashCode * 59 + this.ResourceVersion.GetHashCode();
                if (this.SelfLink != null)
                    hashCode = hashCode * 59 + this.SelfLink.GetHashCode();
                if (this.Continue != null)
                    hashCode = hashCode * 59 + this.Continue.GetHashCode();
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
