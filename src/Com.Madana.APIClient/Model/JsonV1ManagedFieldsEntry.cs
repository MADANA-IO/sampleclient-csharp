/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.37
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
    /// JsonV1ManagedFieldsEntry
    /// </summary>
    [DataContract]
    public partial class JsonV1ManagedFieldsEntry :  IEquatable<JsonV1ManagedFieldsEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonV1ManagedFieldsEntry" /> class.
        /// </summary>
        /// <param name="manager">manager.</param>
        /// <param name="fieldsV1">fieldsV1.</param>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="fieldsType">fieldsType.</param>
        /// <param name="operation">operation.</param>
        /// <param name="time">time.</param>
        public JsonV1ManagedFieldsEntry(string manager = default(string), Object fieldsV1 = default(Object), string apiVersion = default(string), string fieldsType = default(string), string operation = default(string), decimal time = default(decimal))
        {
            this.Manager = manager;
            this.FieldsV1 = fieldsV1;
            this.ApiVersion = apiVersion;
            this.FieldsType = fieldsType;
            this.Operation = operation;
            this.Time = time;
        }
        
        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name="manager", EmitDefaultValue=false)]
        public string Manager { get; set; }

        /// <summary>
        /// Gets or Sets FieldsV1
        /// </summary>
        [DataMember(Name="fieldsV1", EmitDefaultValue=false)]
        public Object FieldsV1 { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets FieldsType
        /// </summary>
        [DataMember(Name="fieldsType", EmitDefaultValue=false)]
        public string FieldsType { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name="operation", EmitDefaultValue=false)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public decimal Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonV1ManagedFieldsEntry {\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  FieldsV1: ").Append(FieldsV1).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  FieldsType: ").Append(FieldsType).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as JsonV1ManagedFieldsEntry);
        }

        /// <summary>
        /// Returns true if JsonV1ManagedFieldsEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonV1ManagedFieldsEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonV1ManagedFieldsEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.FieldsV1 == input.FieldsV1 ||
                    (this.FieldsV1 != null &&
                    this.FieldsV1.Equals(input.FieldsV1))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.FieldsType == input.FieldsType ||
                    (this.FieldsType != null &&
                    this.FieldsType.Equals(input.FieldsType))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.FieldsV1 != null)
                    hashCode = hashCode * 59 + this.FieldsV1.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.FieldsType != null)
                    hashCode = hashCode * 59 + this.FieldsType.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
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
