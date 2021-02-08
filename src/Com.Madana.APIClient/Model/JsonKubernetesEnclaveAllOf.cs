/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.51
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
    /// JsonKubernetesEnclaveAllOf
    /// </summary>
    [DataContract]
    public partial class JsonKubernetesEnclaveAllOf :  IEquatable<JsonKubernetesEnclaveAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonKubernetesEnclaveAllOf" /> class.
        /// </summary>
        /// <param name="remoteControlIP">remoteControlIP.</param>
        /// <param name="enclaveReplicaSetEvents">enclaveReplicaSetEvents.</param>
        /// <param name="enclavePodEvents">enclavePodEvents.</param>
        /// <param name="podPhase">podPhase.</param>
        /// <param name="wireguardPort">wireguardPort.</param>
        /// <param name="isUsingInitContainer">isUsingInitContainer.</param>
        /// <param name="debugInfo">debugInfo.</param>
        /// <param name="attestationPort">attestationPort.</param>
        /// <param name="enclaveDeploymentEvents">enclaveDeploymentEvents.</param>
        public JsonKubernetesEnclaveAllOf(string remoteControlIP = default(string), JsonV1EventList enclaveReplicaSetEvents = default(JsonV1EventList), JsonV1EventList enclavePodEvents = default(JsonV1EventList), string podPhase = default(string), int wireguardPort = default(int), bool isUsingInitContainer = default(bool), string debugInfo = default(string), int attestationPort = default(int), JsonV1EventList enclaveDeploymentEvents = default(JsonV1EventList))
        {
            this.RemoteControlIP = remoteControlIP;
            this.EnclaveReplicaSetEvents = enclaveReplicaSetEvents;
            this.EnclavePodEvents = enclavePodEvents;
            this.PodPhase = podPhase;
            this.WireguardPort = wireguardPort;
            this.IsUsingInitContainer = isUsingInitContainer;
            this.DebugInfo = debugInfo;
            this.AttestationPort = attestationPort;
            this.EnclaveDeploymentEvents = enclaveDeploymentEvents;
        }
        
        /// <summary>
        /// Gets or Sets RemoteControlIP
        /// </summary>
        [DataMember(Name="remoteControlIP", EmitDefaultValue=false)]
        public string RemoteControlIP { get; set; }

        /// <summary>
        /// Gets or Sets EnclaveReplicaSetEvents
        /// </summary>
        [DataMember(Name="enclaveReplicaSetEvents", EmitDefaultValue=false)]
        public JsonV1EventList EnclaveReplicaSetEvents { get; set; }

        /// <summary>
        /// Gets or Sets EnclavePodEvents
        /// </summary>
        [DataMember(Name="enclavePodEvents", EmitDefaultValue=false)]
        public JsonV1EventList EnclavePodEvents { get; set; }

        /// <summary>
        /// Gets or Sets PodPhase
        /// </summary>
        [DataMember(Name="podPhase", EmitDefaultValue=false)]
        public string PodPhase { get; set; }

        /// <summary>
        /// Gets or Sets WireguardPort
        /// </summary>
        [DataMember(Name="wireguardPort", EmitDefaultValue=false)]
        public int WireguardPort { get; set; }

        /// <summary>
        /// Gets or Sets IsUsingInitContainer
        /// </summary>
        [DataMember(Name="isUsingInitContainer", EmitDefaultValue=false)]
        public bool IsUsingInitContainer { get; set; }

        /// <summary>
        /// Gets or Sets DebugInfo
        /// </summary>
        [DataMember(Name="debugInfo", EmitDefaultValue=false)]
        public string DebugInfo { get; set; }

        /// <summary>
        /// Gets or Sets AttestationPort
        /// </summary>
        [DataMember(Name="attestationPort", EmitDefaultValue=false)]
        public int AttestationPort { get; set; }

        /// <summary>
        /// Gets or Sets EnclaveDeploymentEvents
        /// </summary>
        [DataMember(Name="enclaveDeploymentEvents", EmitDefaultValue=false)]
        public JsonV1EventList EnclaveDeploymentEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonKubernetesEnclaveAllOf {\n");
            sb.Append("  RemoteControlIP: ").Append(RemoteControlIP).Append("\n");
            sb.Append("  EnclaveReplicaSetEvents: ").Append(EnclaveReplicaSetEvents).Append("\n");
            sb.Append("  EnclavePodEvents: ").Append(EnclavePodEvents).Append("\n");
            sb.Append("  PodPhase: ").Append(PodPhase).Append("\n");
            sb.Append("  WireguardPort: ").Append(WireguardPort).Append("\n");
            sb.Append("  IsUsingInitContainer: ").Append(IsUsingInitContainer).Append("\n");
            sb.Append("  DebugInfo: ").Append(DebugInfo).Append("\n");
            sb.Append("  AttestationPort: ").Append(AttestationPort).Append("\n");
            sb.Append("  EnclaveDeploymentEvents: ").Append(EnclaveDeploymentEvents).Append("\n");
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
            return this.Equals(input as JsonKubernetesEnclaveAllOf);
        }

        /// <summary>
        /// Returns true if JsonKubernetesEnclaveAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonKubernetesEnclaveAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonKubernetesEnclaveAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoteControlIP == input.RemoteControlIP ||
                    (this.RemoteControlIP != null &&
                    this.RemoteControlIP.Equals(input.RemoteControlIP))
                ) && 
                (
                    this.EnclaveReplicaSetEvents == input.EnclaveReplicaSetEvents ||
                    (this.EnclaveReplicaSetEvents != null &&
                    this.EnclaveReplicaSetEvents.Equals(input.EnclaveReplicaSetEvents))
                ) && 
                (
                    this.EnclavePodEvents == input.EnclavePodEvents ||
                    (this.EnclavePodEvents != null &&
                    this.EnclavePodEvents.Equals(input.EnclavePodEvents))
                ) && 
                (
                    this.PodPhase == input.PodPhase ||
                    (this.PodPhase != null &&
                    this.PodPhase.Equals(input.PodPhase))
                ) && 
                (
                    this.WireguardPort == input.WireguardPort ||
                    (this.WireguardPort != null &&
                    this.WireguardPort.Equals(input.WireguardPort))
                ) && 
                (
                    this.IsUsingInitContainer == input.IsUsingInitContainer ||
                    (this.IsUsingInitContainer != null &&
                    this.IsUsingInitContainer.Equals(input.IsUsingInitContainer))
                ) && 
                (
                    this.DebugInfo == input.DebugInfo ||
                    (this.DebugInfo != null &&
                    this.DebugInfo.Equals(input.DebugInfo))
                ) && 
                (
                    this.AttestationPort == input.AttestationPort ||
                    (this.AttestationPort != null &&
                    this.AttestationPort.Equals(input.AttestationPort))
                ) && 
                (
                    this.EnclaveDeploymentEvents == input.EnclaveDeploymentEvents ||
                    (this.EnclaveDeploymentEvents != null &&
                    this.EnclaveDeploymentEvents.Equals(input.EnclaveDeploymentEvents))
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
                if (this.RemoteControlIP != null)
                    hashCode = hashCode * 59 + this.RemoteControlIP.GetHashCode();
                if (this.EnclaveReplicaSetEvents != null)
                    hashCode = hashCode * 59 + this.EnclaveReplicaSetEvents.GetHashCode();
                if (this.EnclavePodEvents != null)
                    hashCode = hashCode * 59 + this.EnclavePodEvents.GetHashCode();
                if (this.PodPhase != null)
                    hashCode = hashCode * 59 + this.PodPhase.GetHashCode();
                if (this.WireguardPort != null)
                    hashCode = hashCode * 59 + this.WireguardPort.GetHashCode();
                if (this.IsUsingInitContainer != null)
                    hashCode = hashCode * 59 + this.IsUsingInitContainer.GetHashCode();
                if (this.DebugInfo != null)
                    hashCode = hashCode * 59 + this.DebugInfo.GetHashCode();
                if (this.AttestationPort != null)
                    hashCode = hashCode * 59 + this.AttestationPort.GetHashCode();
                if (this.EnclaveDeploymentEvents != null)
                    hashCode = hashCode * 59 + this.EnclaveDeploymentEvents.GetHashCode();
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
