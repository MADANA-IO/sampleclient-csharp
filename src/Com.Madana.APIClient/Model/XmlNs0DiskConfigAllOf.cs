/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.4.14-master.23
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
    /// XmlNs0DiskConfigAllOf
    /// </summary>
    [DataContract]
    public partial class XmlNs0DiskConfigAllOf :  IEquatable<XmlNs0DiskConfigAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlNs0DiskConfigAllOf" /> class.
        /// </summary>
        /// <param name="disk">disk.</param>
        /// <param name="_readonly">_readonly.</param>
        /// <param name="roothash">roothash.</param>
        /// <param name="roothashOffset">roothashOffset.</param>
        public XmlNs0DiskConfigAllOf(string disk = default(string), bool _readonly = default(bool), string roothash = default(string), int roothashOffset = default(int))
        {
            this.Disk = disk;
            this.Readonly = _readonly;
            this.Roothash = roothash;
            this.RoothashOffset = roothashOffset;
        }
        
        /// <summary>
        /// Gets or Sets Disk
        /// </summary>
        [DataMember(Name="disk", EmitDefaultValue=false)]
        public string Disk { get; set; }

        /// <summary>
        /// Gets or Sets Readonly
        /// </summary>
        [DataMember(Name="readonly", EmitDefaultValue=false)]
        public bool Readonly { get; set; }

        /// <summary>
        /// Gets or Sets Roothash
        /// </summary>
        [DataMember(Name="roothash", EmitDefaultValue=false)]
        public string Roothash { get; set; }

        /// <summary>
        /// Gets or Sets RoothashOffset
        /// </summary>
        [DataMember(Name="roothash_offset", EmitDefaultValue=false)]
        public int RoothashOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmlNs0DiskConfigAllOf {\n");
            sb.Append("  Disk: ").Append(Disk).Append("\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("  Roothash: ").Append(Roothash).Append("\n");
            sb.Append("  RoothashOffset: ").Append(RoothashOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as XmlNs0DiskConfigAllOf);
        }

        /// <summary>
        /// Returns true if XmlNs0DiskConfigAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of XmlNs0DiskConfigAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XmlNs0DiskConfigAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Disk == input.Disk ||
                    (this.Disk != null &&
                    this.Disk.Equals(input.Disk))
                ) && 
                (
                    this.Readonly == input.Readonly ||
                    (this.Readonly != null &&
                    this.Readonly.Equals(input.Readonly))
                ) && 
                (
                    this.Roothash == input.Roothash ||
                    (this.Roothash != null &&
                    this.Roothash.Equals(input.Roothash))
                ) && 
                (
                    this.RoothashOffset == input.RoothashOffset ||
                    (this.RoothashOffset != null &&
                    this.RoothashOffset.Equals(input.RoothashOffset))
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
                if (this.Disk != null)
                    hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.Readonly != null)
                    hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                if (this.Roothash != null)
                    hashCode = hashCode * 59 + this.Roothash.GetHashCode();
                if (this.RoothashOffset != null)
                    hashCode = hashCode * 59 + this.RoothashOffset.GetHashCode();
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
