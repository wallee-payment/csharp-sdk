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
    /// This model holds the cardholder authentication data (e.g. 3-D Secure authentication).
    /// </summary>
    [DataContract]
    public partial class CardholderAuthenticationCreate :  IEquatable<CardholderAuthenticationCreate>
    {
        /// <summary>
        /// Gets or Sets AuthenticationResponse
        /// </summary>
        [DataMember(Name="authenticationResponse", EmitDefaultValue=true)]
        public CardAuthenticationResponse AuthenticationResponse { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public CardAuthenticationVersion Version { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardholderAuthenticationCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardholderAuthenticationCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardholderAuthenticationCreate" /> class.
        /// </summary>
        /// <param name="authenticationResponse">authenticationResponse (required).</param>
        /// <param name="version">version (required).</param>
        public CardholderAuthenticationCreate(CardAuthenticationResponse authenticationResponse, CardAuthenticationVersion version)
        {
            // to ensure "authenticationResponse" is required (not null)
            if (authenticationResponse == null)
            {
                throw new InvalidDataException("authenticationResponse is a required property for CardholderAuthenticationCreate and cannot be null");
            }
            this.AuthenticationResponse = authenticationResponse;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for CardholderAuthenticationCreate and cannot be null");
            }
            this.Version = version;
        }

        /// <summary>
        /// The authentication identifier as assigned by authentication system (e.g. XID or DSTransactionID).
        /// </summary>
        /// <value>The authentication identifier as assigned by authentication system (e.g. XID or DSTransactionID).</value>
        [DataMember(Name="authenticationIdentifier", EmitDefaultValue=false)]
        public string AuthenticationIdentifier { get; set; }


        /// <summary>
        /// The cardholder authentication value. Also known as Cardholder Authentication Verification Value (CAVV).
        /// </summary>
        /// <value>The cardholder authentication value. Also known as Cardholder Authentication Verification Value (CAVV).</value>
        [DataMember(Name="authenticationValue", EmitDefaultValue=false)]
        public string AuthenticationValue { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI) value. The ECI is returned by authentication system and indicates the outcome/status of authentication.
        /// </summary>
        /// <value>The Electronic Commerce Indicator (ECI) value. The ECI is returned by authentication system and indicates the outcome/status of authentication.</value>
        [DataMember(Name="electronicCommerceIndicator", EmitDefaultValue=false)]
        public string ElectronicCommerceIndicator { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardholderAuthenticationCreate {\n");
            sb.Append("  AuthenticationIdentifier: ").Append(AuthenticationIdentifier).Append("\n");
            sb.Append("  AuthenticationResponse: ").Append(AuthenticationResponse).Append("\n");
            sb.Append("  AuthenticationValue: ").Append(AuthenticationValue).Append("\n");
            sb.Append("  ElectronicCommerceIndicator: ").Append(ElectronicCommerceIndicator).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as CardholderAuthenticationCreate);
        }

        /// <summary>
        /// Returns true if CardholderAuthenticationCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of CardholderAuthenticationCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardholderAuthenticationCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthenticationIdentifier == input.AuthenticationIdentifier ||
                    (this.AuthenticationIdentifier != null &&
                    this.AuthenticationIdentifier.Equals(input.AuthenticationIdentifier))
                ) && 
                (
                    this.AuthenticationResponse == input.AuthenticationResponse ||
                    (this.AuthenticationResponse != null &&
                    this.AuthenticationResponse.Equals(input.AuthenticationResponse))
                ) && 
                (
                    this.AuthenticationValue == input.AuthenticationValue ||
                    (this.AuthenticationValue != null &&
                    this.AuthenticationValue.Equals(input.AuthenticationValue))
                ) && 
                (
                    this.ElectronicCommerceIndicator == input.ElectronicCommerceIndicator ||
                    (this.ElectronicCommerceIndicator != null &&
                    this.ElectronicCommerceIndicator.Equals(input.ElectronicCommerceIndicator))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.AuthenticationIdentifier != null)
                    hashCode = hashCode * 59 + this.AuthenticationIdentifier.GetHashCode();
                if (this.AuthenticationResponse != null)
                    hashCode = hashCode * 59 + this.AuthenticationResponse.GetHashCode();
                if (this.AuthenticationValue != null)
                    hashCode = hashCode * 59 + this.AuthenticationValue.GetHashCode();
                if (this.ElectronicCommerceIndicator != null)
                    hashCode = hashCode * 59 + this.ElectronicCommerceIndicator.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
