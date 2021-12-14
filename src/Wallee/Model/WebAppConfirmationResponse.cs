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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// The confirmation response provides the details about the installation of the web app.
    /// </summary>
    [DataContract]
    public partial class WebAppConfirmationResponse :  IEquatable<WebAppConfirmationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebAppConfirmationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public WebAppConfirmationResponse()
        {
        }

        /// <summary>
        /// The access code grants permissions to the web service API according to the OAuth standard.
        /// </summary>
        /// <value>The access code grants permissions to the web service API according to the OAuth standard.</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string AccessToken { get; private set; }

        /// <summary>
        /// The scope contains the permissions granted to the web app within the space.
        /// </summary>
        /// <value>The scope contains the permissions granted to the web app within the space.</value>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; private set; }

        /// <summary>
        /// This is the space into which the web app is installed into.
        /// </summary>
        /// <value>This is the space into which the web app is installed into.</value>
        [DataMember(Name="space", EmitDefaultValue=false)]
        public Space Space { get; private set; }

        /// <summary>
        /// The state contains the state parameter content provided when initiating the app installation.
        /// </summary>
        /// <value>The state contains the state parameter content provided when initiating the app installation.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; private set; }

        /// <summary>
        /// The token type indicates the type of the access token. The type determines the authentication mechanism to use for accessing the web service API.
        /// </summary>
        /// <value>The token type indicates the type of the access token. The type determines the authentication mechanism to use for accessing the web service API.</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebAppConfirmationResponse {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Space: ").Append(Space).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebAppConfirmationResponse);
        }

        /// <summary>
        /// Returns true if WebAppConfirmationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebAppConfirmationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebAppConfirmationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Space == input.Space ||
                    (this.Space != null &&
                    this.Space.Equals(input.Space))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
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
                if (this.AccessToken != null)
                    hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Space != null)
                    hashCode = hashCode * 59 + this.Space.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                return hashCode;
            }
        }

    }

}
