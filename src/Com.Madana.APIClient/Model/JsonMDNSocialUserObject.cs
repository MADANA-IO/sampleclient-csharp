/* 
 * madana-api
 *
 * <h1>Using the madana-api</h1>        <p>This documentation contains a Quickstart Guide, relating client functionality and information about the available         endpoints and used datamodels.   </p>       <p> The madana-api and its implementations are still in heavy development. This means that there may be problems in our protocols, or there may be mistakes in our implementations. We take security vulnerabilities very seriously. If you discover a security issue, please bring it to our attention right away! If you find a vulnerability that may affect live deployments - - for example, by exposing a remote execution exploit - - please send your report privately to info@madana.io. Please DO NOT file a public issue. If the issue is a protocol weakness that cannot be immediately exploited or something not yet deployed, just discuss it openly   </p>   <br>   <p> Note: Not all functionality might be acessible without having accquired and api-license token. For more information visit <a href=\"https://www.madana.io\">www.madana.io</a> </p>       <br>
 *
 * The version of the OpenAPI document: 0.4.14-master.22
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
    /// JsonMDNSocialUserObject
    /// </summary>
    [DataContract]
    public partial class JsonMDNSocialUserObject :  IEquatable<JsonMDNSocialUserObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JsonMDNSocialUserObject" /> class.
        /// </summary>
        /// <param name="platform">platform.</param>
        /// <param name="image">image.</param>
        /// <param name="ident">ident.</param>
        public JsonMDNSocialUserObject(string platform = default(string), string image = default(string), string ident = default(string))
        {
            this.Platform = platform;
            this.Image = image;
            this.Ident = ident;
        }
        
        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Ident
        /// </summary>
        [DataMember(Name="ident", EmitDefaultValue=false)]
        public string Ident { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonMDNSocialUserObject {\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Ident: ").Append(Ident).Append("\n");
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
            return this.Equals(input as JsonMDNSocialUserObject);
        }

        /// <summary>
        /// Returns true if JsonMDNSocialUserObject instances are equal
        /// </summary>
        /// <param name="input">Instance of JsonMDNSocialUserObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonMDNSocialUserObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Ident == input.Ident ||
                    (this.Ident != null &&
                    this.Ident.Equals(input.Ident))
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
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Ident != null)
                    hashCode = hashCode * 59 + this.Ident.GetHashCode();
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
