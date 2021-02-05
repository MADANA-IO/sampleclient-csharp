/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.48
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
    /// JsonV1Event
    /// </summary>
    [DataContract]
    public partial class JsonV1Event :  IEquatable<JsonV1Event>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonV1Event" /> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        /// <param name="type">type.</param>
        /// <param name="reportingComponent">reportingComponent.</param>
        /// <param name="firstTimestamp">firstTimestamp.</param>
        /// <param name="kind">kind.</param>
        /// <param name="involvedObject">involvedObject.</param>
        /// <param name="apiVersion">apiVersion.</param>
        /// <param name="series">series.</param>
        /// <param name="lastTimestamp">lastTimestamp.</param>
        /// <param name="count">count.</param>
        /// <param name="message">message.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="action">action.</param>
        /// <param name="related">related.</param>
        /// <param name="source">source.</param>
        /// <param name="eventTime">eventTime.</param>
        /// <param name="reportingInstance">reportingInstance.</param>
        public JsonV1Event(string reason = default(string), string type = default(string), string reportingComponent = default(string), decimal firstTimestamp = default(decimal), string kind = default(string), JsonV1ObjectReference involvedObject = default(JsonV1ObjectReference), string apiVersion = default(string), JsonV1EventSeries series = default(JsonV1EventSeries), decimal lastTimestamp = default(decimal), decimal count = default(decimal), string message = default(string), JsonV1ObjectMeta metadata = default(JsonV1ObjectMeta), string action = default(string), JsonV1ObjectReference related = default(JsonV1ObjectReference), JsonV1EventSource source = default(JsonV1EventSource), decimal eventTime = default(decimal), string reportingInstance = default(string))
        {
            this.Reason = reason;
            this.Type = type;
            this.ReportingComponent = reportingComponent;
            this.FirstTimestamp = firstTimestamp;
            this.Kind = kind;
            this.InvolvedObject = involvedObject;
            this.ApiVersion = apiVersion;
            this.Series = series;
            this.LastTimestamp = lastTimestamp;
            this.Count = count;
            this.Message = message;
            this.Metadata = metadata;
            this.Action = action;
            this.Related = related;
            this.Source = source;
            this.EventTime = eventTime;
            this.ReportingInstance = reportingInstance;
        }
        
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ReportingComponent
        /// </summary>
        [DataMember(Name="reportingComponent", EmitDefaultValue=false)]
        public string ReportingComponent { get; set; }

        /// <summary>
        /// Gets or Sets FirstTimestamp
        /// </summary>
        [DataMember(Name="firstTimestamp", EmitDefaultValue=false)]
        public decimal FirstTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets InvolvedObject
        /// </summary>
        [DataMember(Name="involvedObject", EmitDefaultValue=false)]
        public JsonV1ObjectReference InvolvedObject { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name="series", EmitDefaultValue=false)]
        public JsonV1EventSeries Series { get; set; }

        /// <summary>
        /// Gets or Sets LastTimestamp
        /// </summary>
        [DataMember(Name="lastTimestamp", EmitDefaultValue=false)]
        public decimal LastTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public decimal Count { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public JsonV1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Related
        /// </summary>
        [DataMember(Name="related", EmitDefaultValue=false)]
        public JsonV1ObjectReference Related { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public JsonV1EventSource Source { get; set; }

        /// <summary>
        /// Gets or Sets EventTime
        /// </summary>
        [DataMember(Name="eventTime", EmitDefaultValue=false)]
        public decimal EventTime { get; set; }

        /// <summary>
        /// Gets or Sets ReportingInstance
        /// </summary>
        [DataMember(Name="reportingInstance", EmitDefaultValue=false)]
        public string ReportingInstance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonV1Event {\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReportingComponent: ").Append(ReportingComponent).Append("\n");
            sb.Append("  FirstTimestamp: ").Append(FirstTimestamp).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  InvolvedObject: ").Append(InvolvedObject).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Related: ").Append(Related).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  EventTime: ").Append(EventTime).Append("\n");
            sb.Append("  ReportingInstance: ").Append(ReportingInstance).Append("\n");
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
            return this.Equals(input as JsonV1Event);
        }

        /// <summary>
        /// Returns true if JsonV1Event instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonV1Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonV1Event input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ReportingComponent == input.ReportingComponent ||
                    (this.ReportingComponent != null &&
                    this.ReportingComponent.Equals(input.ReportingComponent))
                ) && 
                (
                    this.FirstTimestamp == input.FirstTimestamp ||
                    (this.FirstTimestamp != null &&
                    this.FirstTimestamp.Equals(input.FirstTimestamp))
                ) && 
                (
                    this.Kind == input.Kind ||
                    (this.Kind != null &&
                    this.Kind.Equals(input.Kind))
                ) && 
                (
                    this.InvolvedObject == input.InvolvedObject ||
                    (this.InvolvedObject != null &&
                    this.InvolvedObject.Equals(input.InvolvedObject))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.Series == input.Series ||
                    (this.Series != null &&
                    this.Series.Equals(input.Series))
                ) && 
                (
                    this.LastTimestamp == input.LastTimestamp ||
                    (this.LastTimestamp != null &&
                    this.LastTimestamp.Equals(input.LastTimestamp))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Related == input.Related ||
                    (this.Related != null &&
                    this.Related.Equals(input.Related))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.EventTime == input.EventTime ||
                    (this.EventTime != null &&
                    this.EventTime.Equals(input.EventTime))
                ) && 
                (
                    this.ReportingInstance == input.ReportingInstance ||
                    (this.ReportingInstance != null &&
                    this.ReportingInstance.Equals(input.ReportingInstance))
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
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ReportingComponent != null)
                    hashCode = hashCode * 59 + this.ReportingComponent.GetHashCode();
                if (this.FirstTimestamp != null)
                    hashCode = hashCode * 59 + this.FirstTimestamp.GetHashCode();
                if (this.Kind != null)
                    hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.InvolvedObject != null)
                    hashCode = hashCode * 59 + this.InvolvedObject.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Series != null)
                    hashCode = hashCode * 59 + this.Series.GetHashCode();
                if (this.LastTimestamp != null)
                    hashCode = hashCode * 59 + this.LastTimestamp.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Related != null)
                    hashCode = hashCode * 59 + this.Related.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.EventTime != null)
                    hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.ReportingInstance != null)
                    hashCode = hashCode * 59 + this.ReportingInstance.GetHashCode();
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
