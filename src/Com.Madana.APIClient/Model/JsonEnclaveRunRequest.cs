/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.56
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
    /// JsonEnclaveRunRequest
    /// </summary>
    [DataContract]
    public partial class JsonEnclaveRunRequest :  IEquatable<JsonEnclaveRunRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonEnclaveRunRequest" /> class.
        /// </summary>
        /// <param name="environmentUUID">environmentUUID.</param>
        /// <param name="enclaveExecutionType">enclaveExecutionType.</param>
        /// <param name="usingDefaultRunConfig">usingDefaultRunConfig.</param>
        /// <param name="ports">ports.</param>
        /// <param name="wireguardPublicKey">wireguardPublicKey.</param>
        public JsonEnclaveRunRequest(string environmentUUID = default(string), string enclaveExecutionType = default(string), bool usingDefaultRunConfig = default(bool), List<JsonEnclavePort> ports = default(List<JsonEnclavePort>), string wireguardPublicKey = default(string))
        {
            this.EnvironmentUUID = environmentUUID;
            this.EnclaveExecutionType = enclaveExecutionType;
            this.UsingDefaultRunConfig = usingDefaultRunConfig;
            this.Ports = ports;
            this.WireguardPublicKey = wireguardPublicKey;
        }
        
        /// <summary>
        /// Gets or Sets EnvironmentUUID
        /// </summary>
        [DataMember(Name="environmentUUID", EmitDefaultValue=false)]
        public string EnvironmentUUID { get; set; }

        /// <summary>
        /// Gets or Sets EnclaveExecutionType
        /// </summary>
        [DataMember(Name="enclaveExecutionType", EmitDefaultValue=false)]
        public string EnclaveExecutionType { get; set; }

        /// <summary>
        /// Gets or Sets UsingDefaultRunConfig
        /// </summary>
        [DataMember(Name="usingDefaultRunConfig", EmitDefaultValue=false)]
        public bool UsingDefaultRunConfig { get; set; }

        /// <summary>
        /// Gets or Sets Ports
        /// </summary>
        [DataMember(Name="ports", EmitDefaultValue=false)]
        public List<JsonEnclavePort> Ports { get; set; }

        /// <summary>
        /// Gets or Sets WireguardPublicKey
        /// </summary>
        [DataMember(Name="wireguardPublicKey", EmitDefaultValue=false)]
        public string WireguardPublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonEnclaveRunRequest {\n");
            sb.Append("  EnvironmentUUID: ").Append(EnvironmentUUID).Append("\n");
            sb.Append("  EnclaveExecutionType: ").Append(EnclaveExecutionType).Append("\n");
            sb.Append("  UsingDefaultRunConfig: ").Append(UsingDefaultRunConfig).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  WireguardPublicKey: ").Append(WireguardPublicKey).Append("\n");
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
            return this.Equals(input as JsonEnclaveRunRequest);
        }

        /// <summary>
        /// Returns true if JsonEnclaveRunRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonEnclaveRunRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonEnclaveRunRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnvironmentUUID == input.EnvironmentUUID ||
                    (this.EnvironmentUUID != null &&
                    this.EnvironmentUUID.Equals(input.EnvironmentUUID))
                ) && 
                (
                    this.EnclaveExecutionType == input.EnclaveExecutionType ||
                    (this.EnclaveExecutionType != null &&
                    this.EnclaveExecutionType.Equals(input.EnclaveExecutionType))
                ) && 
                (
                    this.UsingDefaultRunConfig == input.UsingDefaultRunConfig ||
                    (this.UsingDefaultRunConfig != null &&
                    this.UsingDefaultRunConfig.Equals(input.UsingDefaultRunConfig))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.WireguardPublicKey == input.WireguardPublicKey ||
                    (this.WireguardPublicKey != null &&
                    this.WireguardPublicKey.Equals(input.WireguardPublicKey))
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
                if (this.EnvironmentUUID != null)
                    hashCode = hashCode * 59 + this.EnvironmentUUID.GetHashCode();
                if (this.EnclaveExecutionType != null)
                    hashCode = hashCode * 59 + this.EnclaveExecutionType.GetHashCode();
                if (this.UsingDefaultRunConfig != null)
                    hashCode = hashCode * 59 + this.UsingDefaultRunConfig.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.WireguardPublicKey != null)
                    hashCode = hashCode * 59 + this.WireguardPublicKey.GetHashCode();
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
