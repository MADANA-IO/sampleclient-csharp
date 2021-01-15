/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.5.0-master.28
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
    /// JsonMDNUser
    /// </summary>
    [DataContract]
    public partial class JsonMDNUser :  IEquatable<JsonMDNUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonMDNUser" /> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="activated">activated.</param>
        /// <param name="lastActive">lastActive.</param>
        /// <param name="userName">userName.</param>
        /// <param name="image">image.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="settings">settings.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="socialAccounts">socialAccounts.</param>
        /// <param name="guid">guid.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="mail">mail.</param>
        public JsonMDNUser(string created = default(string), string activated = default(string), string lastActive = default(string), string userName = default(string), string image = default(string), string lastName = default(string), List<JsonMDNUserSetting> settings = default(List<JsonMDNUserSetting>), JsonMDNUserCredentials credentials = default(JsonMDNUserCredentials), List<JsonMDNSocialUserObject> socialAccounts = default(List<JsonMDNSocialUserObject>), string guid = default(string), string firstName = default(string), string mail = default(string))
        {
            this.Created = created;
            this.Activated = activated;
            this.LastActive = lastActive;
            this.UserName = userName;
            this.Image = image;
            this.LastName = lastName;
            this.Settings = settings;
            this.Credentials = credentials;
            this.SocialAccounts = socialAccounts;
            this.Guid = guid;
            this.FirstName = firstName;
            this.Mail = mail;
        }
        
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Activated
        /// </summary>
        [DataMember(Name="activated", EmitDefaultValue=false)]
        public string Activated { get; set; }

        /// <summary>
        /// Gets or Sets LastActive
        /// </summary>
        [DataMember(Name="lastActive", EmitDefaultValue=false)]
        public string LastActive { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public List<JsonMDNUserSetting> Settings { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public JsonMDNUserCredentials Credentials { get; set; }

        /// <summary>
        /// Gets or Sets SocialAccounts
        /// </summary>
        [DataMember(Name="socialAccounts", EmitDefaultValue=false)]
        public List<JsonMDNSocialUserObject> SocialAccounts { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Mail
        /// </summary>
        [DataMember(Name="mail", EmitDefaultValue=false)]
        public string Mail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonMDNUser {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Activated: ").Append(Activated).Append("\n");
            sb.Append("  LastActive: ").Append(LastActive).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  SocialAccounts: ").Append(SocialAccounts).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
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
            return this.Equals(input as JsonMDNUser);
        }

        /// <summary>
        /// Returns true if JsonMDNUser instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonMDNUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonMDNUser input)
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
                    this.Activated == input.Activated ||
                    (this.Activated != null &&
                    this.Activated.Equals(input.Activated))
                ) && 
                (
                    this.LastActive == input.LastActive ||
                    (this.LastActive != null &&
                    this.LastActive.Equals(input.LastActive))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Settings == input.Settings ||
                    this.Settings != null &&
                    input.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings)
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    (this.Credentials != null &&
                    this.Credentials.Equals(input.Credentials))
                ) && 
                (
                    this.SocialAccounts == input.SocialAccounts ||
                    this.SocialAccounts != null &&
                    input.SocialAccounts != null &&
                    this.SocialAccounts.SequenceEqual(input.SocialAccounts)
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
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
                if (this.Activated != null)
                    hashCode = hashCode * 59 + this.Activated.GetHashCode();
                if (this.LastActive != null)
                    hashCode = hashCode * 59 + this.LastActive.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.SocialAccounts != null)
                    hashCode = hashCode * 59 + this.SocialAccounts.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Mail != null)
                    hashCode = hashCode * 59 + this.Mail.GetHashCode();
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
