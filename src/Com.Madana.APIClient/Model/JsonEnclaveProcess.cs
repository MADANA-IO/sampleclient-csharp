/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.41
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
    /// JsonEnclaveProcess
    /// </summary>
    [DataContract]
    public partial class JsonEnclaveProcess :  IEquatable<JsonEnclaveProcess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonEnclaveProcess" /> class.
        /// </summary>
        /// <param name="wgInterface">wgInterface.</param>
        /// <param name="environment">environment.</param>
        /// <param name="endingTime">endingTime.</param>
        /// <param name="enclaveInputstream">enclaveInputstream.</param>
        /// <param name="enclaveIdent">enclaveIdent.</param>
        /// <param name="internalIdent">internalIdent.</param>
        /// <param name="kubernetesEnclave">kubernetesEnclave.</param>
        /// <param name="publicIdent">publicIdent.</param>
        /// <param name="portMapping">portMapping.</param>
        /// <param name="internalRemoteControlServer">internalRemoteControlServer.</param>
        /// <param name="status">status.</param>
        /// <param name="remoteControlServer">remoteControlServer.</param>
        /// <param name="wireguardServer">wireguardServer.</param>
        /// <param name="startupTime">startupTime.</param>
        /// <param name="consoleOutput">consoleOutput.</param>
        /// <param name="internalAttesationServer">internalAttesationServer.</param>
        /// <param name="internalWireguardServer">internalWireguardServer.</param>
        /// <param name="ports">ports.</param>
        /// <param name="process">process.</param>
        /// <param name="startupCMD">startupCMD.</param>
        /// <param name="wireguardPublicKey">wireguardPublicKey.</param>
        /// <param name="attestationServer">attestationServer.</param>
        /// <param name="signerIdent">signerIdent.</param>
        public JsonEnclaveProcess(JsonWireguardInterface wgInterface = default(JsonWireguardInterface), JsonEnvironment environment = default(JsonEnvironment), string endingTime = default(string), Object enclaveInputstream = default(Object), string enclaveIdent = default(string), string internalIdent = default(string), JsonKubernetesEnclave kubernetesEnclave = default(JsonKubernetesEnclave), string publicIdent = default(string), Dictionary<string, string> portMapping = default(Dictionary<string, string>), string internalRemoteControlServer = default(string), string status = default(string), string remoteControlServer = default(string), string wireguardServer = default(string), string startupTime = default(string), string consoleOutput = default(string), string internalAttesationServer = default(string), string internalWireguardServer = default(string), List<JsonEnclavePort> ports = default(List<JsonEnclavePort>), JsonProcess process = default(JsonProcess), string startupCMD = default(string), string wireguardPublicKey = default(string), string attestationServer = default(string), string signerIdent = default(string))
        {
            this.WgInterface = wgInterface;
            this.Environment = environment;
            this.EndingTime = endingTime;
            this.EnclaveInputstream = enclaveInputstream;
            this.EnclaveIdent = enclaveIdent;
            this.InternalIdent = internalIdent;
            this.KubernetesEnclave = kubernetesEnclave;
            this.PublicIdent = publicIdent;
            this.PortMapping = portMapping;
            this.InternalRemoteControlServer = internalRemoteControlServer;
            this.Status = status;
            this.RemoteControlServer = remoteControlServer;
            this.WireguardServer = wireguardServer;
            this.StartupTime = startupTime;
            this.ConsoleOutput = consoleOutput;
            this.InternalAttesationServer = internalAttesationServer;
            this.InternalWireguardServer = internalWireguardServer;
            this.Ports = ports;
            this.Process = process;
            this.StartupCMD = startupCMD;
            this.WireguardPublicKey = wireguardPublicKey;
            this.AttestationServer = attestationServer;
            this.SignerIdent = signerIdent;
        }
        
        /// <summary>
        /// Gets or Sets WgInterface
        /// </summary>
        [DataMember(Name="wgInterface", EmitDefaultValue=false)]
        public JsonWireguardInterface WgInterface { get; set; }

        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public JsonEnvironment Environment { get; set; }

        /// <summary>
        /// Gets or Sets EndingTime
        /// </summary>
        [DataMember(Name="endingTime", EmitDefaultValue=false)]
        public string EndingTime { get; set; }

        /// <summary>
        /// Gets or Sets EnclaveInputstream
        /// </summary>
        [DataMember(Name="enclaveInputstream", EmitDefaultValue=false)]
        public Object EnclaveInputstream { get; set; }

        /// <summary>
        /// Gets or Sets EnclaveIdent
        /// </summary>
        [DataMember(Name="enclaveIdent", EmitDefaultValue=false)]
        public string EnclaveIdent { get; set; }

        /// <summary>
        /// Gets or Sets InternalIdent
        /// </summary>
        [DataMember(Name="internalIdent", EmitDefaultValue=false)]
        public string InternalIdent { get; set; }

        /// <summary>
        /// Gets or Sets KubernetesEnclave
        /// </summary>
        [DataMember(Name="kubernetesEnclave", EmitDefaultValue=false)]
        public JsonKubernetesEnclave KubernetesEnclave { get; set; }

        /// <summary>
        /// Gets or Sets PublicIdent
        /// </summary>
        [DataMember(Name="publicIdent", EmitDefaultValue=false)]
        public string PublicIdent { get; set; }

        /// <summary>
        /// Gets or Sets PortMapping
        /// </summary>
        [DataMember(Name="portMapping", EmitDefaultValue=false)]
        public Dictionary<string, string> PortMapping { get; set; }

        /// <summary>
        /// Gets or Sets InternalRemoteControlServer
        /// </summary>
        [DataMember(Name="internalRemoteControlServer", EmitDefaultValue=false)]
        public string InternalRemoteControlServer { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets RemoteControlServer
        /// </summary>
        [DataMember(Name="remoteControlServer", EmitDefaultValue=false)]
        public string RemoteControlServer { get; set; }

        /// <summary>
        /// Gets or Sets WireguardServer
        /// </summary>
        [DataMember(Name="wireguardServer", EmitDefaultValue=false)]
        public string WireguardServer { get; set; }

        /// <summary>
        /// Gets or Sets StartupTime
        /// </summary>
        [DataMember(Name="startupTime", EmitDefaultValue=false)]
        public string StartupTime { get; set; }

        /// <summary>
        /// Gets or Sets ConsoleOutput
        /// </summary>
        [DataMember(Name="consoleOutput", EmitDefaultValue=false)]
        public string ConsoleOutput { get; set; }

        /// <summary>
        /// Gets or Sets InternalAttesationServer
        /// </summary>
        [DataMember(Name="internalAttesationServer", EmitDefaultValue=false)]
        public string InternalAttesationServer { get; set; }

        /// <summary>
        /// Gets or Sets InternalWireguardServer
        /// </summary>
        [DataMember(Name="internalWireguardServer", EmitDefaultValue=false)]
        public string InternalWireguardServer { get; set; }

        /// <summary>
        /// Gets or Sets Ports
        /// </summary>
        [DataMember(Name="ports", EmitDefaultValue=false)]
        public List<JsonEnclavePort> Ports { get; set; }

        /// <summary>
        /// Gets or Sets Process
        /// </summary>
        [DataMember(Name="process", EmitDefaultValue=false)]
        public JsonProcess Process { get; set; }

        /// <summary>
        /// Gets or Sets StartupCMD
        /// </summary>
        [DataMember(Name="startupCMD", EmitDefaultValue=false)]
        public string StartupCMD { get; set; }

        /// <summary>
        /// Gets or Sets WireguardPublicKey
        /// </summary>
        [DataMember(Name="wireguardPublicKey", EmitDefaultValue=false)]
        public string WireguardPublicKey { get; set; }

        /// <summary>
        /// Gets or Sets AttestationServer
        /// </summary>
        [DataMember(Name="attestationServer", EmitDefaultValue=false)]
        public string AttestationServer { get; set; }

        /// <summary>
        /// Gets or Sets SignerIdent
        /// </summary>
        [DataMember(Name="signerIdent", EmitDefaultValue=false)]
        public string SignerIdent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonEnclaveProcess {\n");
            sb.Append("  WgInterface: ").Append(WgInterface).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  EndingTime: ").Append(EndingTime).Append("\n");
            sb.Append("  EnclaveInputstream: ").Append(EnclaveInputstream).Append("\n");
            sb.Append("  EnclaveIdent: ").Append(EnclaveIdent).Append("\n");
            sb.Append("  InternalIdent: ").Append(InternalIdent).Append("\n");
            sb.Append("  KubernetesEnclave: ").Append(KubernetesEnclave).Append("\n");
            sb.Append("  PublicIdent: ").Append(PublicIdent).Append("\n");
            sb.Append("  PortMapping: ").Append(PortMapping).Append("\n");
            sb.Append("  InternalRemoteControlServer: ").Append(InternalRemoteControlServer).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RemoteControlServer: ").Append(RemoteControlServer).Append("\n");
            sb.Append("  WireguardServer: ").Append(WireguardServer).Append("\n");
            sb.Append("  StartupTime: ").Append(StartupTime).Append("\n");
            sb.Append("  ConsoleOutput: ").Append(ConsoleOutput).Append("\n");
            sb.Append("  InternalAttesationServer: ").Append(InternalAttesationServer).Append("\n");
            sb.Append("  InternalWireguardServer: ").Append(InternalWireguardServer).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  Process: ").Append(Process).Append("\n");
            sb.Append("  StartupCMD: ").Append(StartupCMD).Append("\n");
            sb.Append("  WireguardPublicKey: ").Append(WireguardPublicKey).Append("\n");
            sb.Append("  AttestationServer: ").Append(AttestationServer).Append("\n");
            sb.Append("  SignerIdent: ").Append(SignerIdent).Append("\n");
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
            return this.Equals(input as JsonEnclaveProcess);
        }

        /// <summary>
        /// Returns true if JsonEnclaveProcess instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonEnclaveProcess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonEnclaveProcess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WgInterface == input.WgInterface ||
                    (this.WgInterface != null &&
                    this.WgInterface.Equals(input.WgInterface))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.EndingTime == input.EndingTime ||
                    (this.EndingTime != null &&
                    this.EndingTime.Equals(input.EndingTime))
                ) && 
                (
                    this.EnclaveInputstream == input.EnclaveInputstream ||
                    (this.EnclaveInputstream != null &&
                    this.EnclaveInputstream.Equals(input.EnclaveInputstream))
                ) && 
                (
                    this.EnclaveIdent == input.EnclaveIdent ||
                    (this.EnclaveIdent != null &&
                    this.EnclaveIdent.Equals(input.EnclaveIdent))
                ) && 
                (
                    this.InternalIdent == input.InternalIdent ||
                    (this.InternalIdent != null &&
                    this.InternalIdent.Equals(input.InternalIdent))
                ) && 
                (
                    this.KubernetesEnclave == input.KubernetesEnclave ||
                    (this.KubernetesEnclave != null &&
                    this.KubernetesEnclave.Equals(input.KubernetesEnclave))
                ) && 
                (
                    this.PublicIdent == input.PublicIdent ||
                    (this.PublicIdent != null &&
                    this.PublicIdent.Equals(input.PublicIdent))
                ) && 
                (
                    this.PortMapping == input.PortMapping ||
                    this.PortMapping != null &&
                    input.PortMapping != null &&
                    this.PortMapping.SequenceEqual(input.PortMapping)
                ) && 
                (
                    this.InternalRemoteControlServer == input.InternalRemoteControlServer ||
                    (this.InternalRemoteControlServer != null &&
                    this.InternalRemoteControlServer.Equals(input.InternalRemoteControlServer))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.RemoteControlServer == input.RemoteControlServer ||
                    (this.RemoteControlServer != null &&
                    this.RemoteControlServer.Equals(input.RemoteControlServer))
                ) && 
                (
                    this.WireguardServer == input.WireguardServer ||
                    (this.WireguardServer != null &&
                    this.WireguardServer.Equals(input.WireguardServer))
                ) && 
                (
                    this.StartupTime == input.StartupTime ||
                    (this.StartupTime != null &&
                    this.StartupTime.Equals(input.StartupTime))
                ) && 
                (
                    this.ConsoleOutput == input.ConsoleOutput ||
                    (this.ConsoleOutput != null &&
                    this.ConsoleOutput.Equals(input.ConsoleOutput))
                ) && 
                (
                    this.InternalAttesationServer == input.InternalAttesationServer ||
                    (this.InternalAttesationServer != null &&
                    this.InternalAttesationServer.Equals(input.InternalAttesationServer))
                ) && 
                (
                    this.InternalWireguardServer == input.InternalWireguardServer ||
                    (this.InternalWireguardServer != null &&
                    this.InternalWireguardServer.Equals(input.InternalWireguardServer))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.Process == input.Process ||
                    (this.Process != null &&
                    this.Process.Equals(input.Process))
                ) && 
                (
                    this.StartupCMD == input.StartupCMD ||
                    (this.StartupCMD != null &&
                    this.StartupCMD.Equals(input.StartupCMD))
                ) && 
                (
                    this.WireguardPublicKey == input.WireguardPublicKey ||
                    (this.WireguardPublicKey != null &&
                    this.WireguardPublicKey.Equals(input.WireguardPublicKey))
                ) && 
                (
                    this.AttestationServer == input.AttestationServer ||
                    (this.AttestationServer != null &&
                    this.AttestationServer.Equals(input.AttestationServer))
                ) && 
                (
                    this.SignerIdent == input.SignerIdent ||
                    (this.SignerIdent != null &&
                    this.SignerIdent.Equals(input.SignerIdent))
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
                if (this.WgInterface != null)
                    hashCode = hashCode * 59 + this.WgInterface.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.EndingTime != null)
                    hashCode = hashCode * 59 + this.EndingTime.GetHashCode();
                if (this.EnclaveInputstream != null)
                    hashCode = hashCode * 59 + this.EnclaveInputstream.GetHashCode();
                if (this.EnclaveIdent != null)
                    hashCode = hashCode * 59 + this.EnclaveIdent.GetHashCode();
                if (this.InternalIdent != null)
                    hashCode = hashCode * 59 + this.InternalIdent.GetHashCode();
                if (this.KubernetesEnclave != null)
                    hashCode = hashCode * 59 + this.KubernetesEnclave.GetHashCode();
                if (this.PublicIdent != null)
                    hashCode = hashCode * 59 + this.PublicIdent.GetHashCode();
                if (this.PortMapping != null)
                    hashCode = hashCode * 59 + this.PortMapping.GetHashCode();
                if (this.InternalRemoteControlServer != null)
                    hashCode = hashCode * 59 + this.InternalRemoteControlServer.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RemoteControlServer != null)
                    hashCode = hashCode * 59 + this.RemoteControlServer.GetHashCode();
                if (this.WireguardServer != null)
                    hashCode = hashCode * 59 + this.WireguardServer.GetHashCode();
                if (this.StartupTime != null)
                    hashCode = hashCode * 59 + this.StartupTime.GetHashCode();
                if (this.ConsoleOutput != null)
                    hashCode = hashCode * 59 + this.ConsoleOutput.GetHashCode();
                if (this.InternalAttesationServer != null)
                    hashCode = hashCode * 59 + this.InternalAttesationServer.GetHashCode();
                if (this.InternalWireguardServer != null)
                    hashCode = hashCode * 59 + this.InternalWireguardServer.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.Process != null)
                    hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.StartupCMD != null)
                    hashCode = hashCode * 59 + this.StartupCMD.GetHashCode();
                if (this.WireguardPublicKey != null)
                    hashCode = hashCode * 59 + this.WireguardPublicKey.GetHashCode();
                if (this.AttestationServer != null)
                    hashCode = hashCode * 59 + this.AttestationServer.GetHashCode();
                if (this.SignerIdent != null)
                    hashCode = hashCode * 59 + this.SignerIdent.GetHashCode();
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
