/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.22
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
    /// JsonRunConfig
    /// </summary>
    [DataContract]
    public partial class JsonRunConfig :  IEquatable<JsonRunConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonRunConfig" /> class.
        /// </summary>
        /// <param name="environment">environment.</param>
        /// <param name="args">args.</param>
        /// <param name="run">run.</param>
        /// <param name="diskConfig">diskConfig.</param>
        public JsonRunConfig(Dictionary<string, string> environment = default(Dictionary<string, string>), List<string> args = default(List<string>), string run = default(string), List<JsonDiskConfig> diskConfig = default(List<JsonDiskConfig>))
        {
            this.Environment = environment;
            this.Args = args;
            this.Run = run;
            this.DiskConfig = diskConfig;
        }
        
        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Dictionary<string, string> Environment { get; set; }

        /// <summary>
        /// Gets or Sets Args
        /// </summary>
        [DataMember(Name="args", EmitDefaultValue=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// Gets or Sets Run
        /// </summary>
        [DataMember(Name="run", EmitDefaultValue=false)]
        public string Run { get; set; }

        /// <summary>
        /// Gets or Sets DiskConfig
        /// </summary>
        [DataMember(Name="disk_config", EmitDefaultValue=false)]
        public List<JsonDiskConfig> DiskConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonRunConfig {\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Run: ").Append(Run).Append("\n");
            sb.Append("  DiskConfig: ").Append(DiskConfig).Append("\n");
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
            return this.Equals(input as JsonRunConfig);
        }

        /// <summary>
        /// Returns true if JsonRunConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonRunConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonRunConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Environment == input.Environment ||
                    this.Environment != null &&
                    input.Environment != null &&
                    this.Environment.SequenceEqual(input.Environment)
                ) && 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
                ) && 
                (
                    this.Run == input.Run ||
                    (this.Run != null &&
                    this.Run.Equals(input.Run))
                ) && 
                (
                    this.DiskConfig == input.DiskConfig ||
                    this.DiskConfig != null &&
                    input.DiskConfig != null &&
                    this.DiskConfig.SequenceEqual(input.DiskConfig)
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
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.Args != null)
                    hashCode = hashCode * 59 + this.Args.GetHashCode();
                if (this.Run != null)
                    hashCode = hashCode * 59 + this.Run.GetHashCode();
                if (this.DiskConfig != null)
                    hashCode = hashCode * 59 + this.DiskConfig.GetHashCode();
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
