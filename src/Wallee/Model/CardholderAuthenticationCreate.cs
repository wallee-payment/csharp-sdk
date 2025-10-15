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
    /// CardholderAuthenticationCreate
    /// </summary>
    [DataContract]
    public partial class CardholderAuthenticationCreate :  IEquatable<CardholderAuthenticationCreate>
    {
        /// <summary>
        /// The result of the authentication process.
        /// </summary>
        /// <value>The result of the authentication process.</value>
        [DataMember(Name="authenticationResponse", EmitDefaultValue=true)]
        public CardAuthenticationResponse AuthenticationResponse { get; set; }
        /// <summary>
        /// The version of the authentication protocol (e.g., 3D Secure 1.0 or 2.0) used for the transaction.
        /// </summary>
        /// <value>The version of the authentication protocol (e.g., 3D Secure 1.0 or 2.0) used for the transaction.</value>
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
        /// <param name="authenticationResponse">The result of the authentication process. (required).</param>
        /// <param name="version">The version of the authentication protocol (e.g., 3D Secure 1.0 or 2.0) used for the transaction. (required).</param>
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
        /// The identifier (e.g., XID or DSTransactionID) assigned by the authentication system for tracking and verification.
        /// </summary>
        /// <value>The identifier (e.g., XID or DSTransactionID) assigned by the authentication system for tracking and verification.</value>
        [DataMember(Name="authenticationIdentifier", EmitDefaultValue=false)]
        public string AuthenticationIdentifier { get; set; }


        /// <summary>
        /// The cryptographic token (CAVV/AAV) generated during the authentication process to validate the cardholder&#39;s identity.
        /// </summary>
        /// <value>The cryptographic token (CAVV/AAV) generated during the authentication process to validate the cardholder&#39;s identity.</value>
        [DataMember(Name="authenticationValue", EmitDefaultValue=false)]
        public string AuthenticationValue { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions.
        /// </summary>
        /// <value>The Electronic Commerce Indicator (ECI) represents the authentication level and indicates liability shift during online or card-not-present transactions.</value>
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
