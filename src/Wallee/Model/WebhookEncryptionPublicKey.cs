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
    /// The webhook encryption public key is used to verify the webhook content signature.
    /// </summary>
    [DataContract]
    public partial class WebhookEncryptionPublicKey :  IEquatable<WebhookEncryptionPublicKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEncryptionPublicKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public WebhookEncryptionPublicKey()
        {
        }

        /// <summary>
        /// The ID of encryption key
        /// </summary>
        /// <value>The ID of encryption key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// The BASE64 encoded public key
        /// </summary>
        /// <value>The BASE64 encoded public key</value>
        [DataMember(Name="publicKey", EmitDefaultValue=false)]
        public string PublicKey { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEncryptionPublicKey {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as WebhookEncryptionPublicKey);
        }

        /// <summary>
        /// Returns true if WebhookEncryptionPublicKey instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEncryptionPublicKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEncryptionPublicKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                return hashCode;
            }
        }

    }

}
