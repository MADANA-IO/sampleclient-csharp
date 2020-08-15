/* 
 * madana-api
 *
 * <h1>API Quickstart Guide</h1>        <p>This documentation contains a Quickstart Guide, a few <a href=\"downloads.html\">sample clients</a>  for download and information about the available  <a href=\"resources.html\">endpoints</a>  and  <a href=\"data.html\">DataTypes</a>  </p>     <p>The <a target=\"_blank\" href=\"http://madana-explorer-staging.eu-central-1.elasticbeanstalk.com/login\">  MADANA Explorer</a> can be used to verify the interactions with the API</p>           <p>Internal use only. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a></p>         <br> <br>
 *
 * The version of the OpenAPI document: 0.4.12
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
using OpenAPIDateConverter = Com.MadanaSampleclient.Client.OpenAPIDateConverter;

namespace Com.MadanaSampleclient.Model
{
    /// <summary>
    /// JsonAnalysisAllOf
    /// </summary>
    [DataContract]
    public partial class JsonAnalysisAllOf :  IEquatable<JsonAnalysisAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonAnalysisAllOf" /> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="uuid">uuid.</param>
        /// <param name="status">status.</param>
        /// <param name="agent">agent.</param>
        /// <param name="datasets">datasets.</param>
        /// <param name="participants">participants.</param>
        /// <param name="views">views.</param>
        /// <param name="actions">actions.</param>
        /// <param name="creator">creator.</param>
        /// <param name="datasetCount">datasetCount.</param>
        public JsonAnalysisAllOf(string created = default(string), string uuid = default(string), string status = default(string), string agent = default(string), List<JsonDatasetInfo> datasets = default(List<JsonDatasetInfo>), List<string> participants = default(List<string>), string views = default(string), List<JsonAnalysisRequestAction> actions = default(List<JsonAnalysisRequestAction>), string creator = default(string), string datasetCount = default(string))
        {
            this.Created = created;
            this.Uuid = uuid;
            this.Status = status;
            this.Agent = agent;
            this.Datasets = datasets;
            this.Participants = participants;
            this.Views = views;
            this.Actions = actions;
            this.Creator = creator;
            this.DatasetCount = datasetCount;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Agent
        /// </summary>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public string Agent { get; set; }

        /// <summary>
        /// Gets or Sets Datasets
        /// </summary>
        [DataMember(Name="datasets", EmitDefaultValue=false)]
        public List<JsonDatasetInfo> Datasets { get; set; }

        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<string> Participants { get; set; }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public string Views { get; set; }

        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<JsonAnalysisRequestAction> Actions { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or Sets DatasetCount
        /// </summary>
        [DataMember(Name="datasetCount", EmitDefaultValue=false)]
        public string DatasetCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonAnalysisAllOf {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Datasets: ").Append(Datasets).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  DatasetCount: ").Append(DatasetCount).Append("\n");
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
            return this.Equals(input as JsonAnalysisAllOf);
        }

        /// <summary>
        /// Returns true if JsonAnalysisAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonAnalysisAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonAnalysisAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Agent == input.Agent ||
                    (this.Agent != null &&
                    this.Agent.Equals(input.Agent))
                ) && 
                (
                    this.Datasets == input.Datasets ||
                    this.Datasets != null &&
                    input.Datasets != null &&
                    this.Datasets.SequenceEqual(input.Datasets)
                ) && 
                (
                    this.Participants == input.Participants ||
                    this.Participants != null &&
                    input.Participants != null &&
                    this.Participants.SequenceEqual(input.Participants)
                ) && 
                (
                    this.Views == input.Views ||
                    (this.Views != null &&
                    this.Views.Equals(input.Views))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.DatasetCount == input.DatasetCount ||
                    (this.DatasetCount != null &&
                    this.DatasetCount.Equals(input.DatasetCount))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Agent != null)
                    hashCode = hashCode * 59 + this.Agent.GetHashCode();
                if (this.Datasets != null)
                    hashCode = hashCode * 59 + this.Datasets.GetHashCode();
                if (this.Participants != null)
                    hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.DatasetCount != null)
                    hashCode = hashCode * 59 + this.DatasetCount.GetHashCode();
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
