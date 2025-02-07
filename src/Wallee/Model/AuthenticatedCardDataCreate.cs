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
    /// This model holds the card data and optional cardholder authentication details.
    /// </summary>
    [DataContract]
    public partial class AuthenticatedCardDataCreate :  IEquatable<AuthenticatedCardDataCreate>
    {
        /// <summary>
        /// Gets or Sets PanType
        /// </summary>
        [DataMember(Name="panType", EmitDefaultValue=false)]
        public PanType? PanType { get; set; }
        /// <summary>
        /// Gets or Sets RecurringIndicator
        /// </summary>
        [DataMember(Name="recurringIndicator", EmitDefaultValue=false)]
        public RecurringIndicator? RecurringIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedCardDataCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthenticatedCardDataCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticatedCardDataCreate" /> class.
        /// </summary>
        /// <param name="primaryAccountNumber">The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card. (required).</param>
        public AuthenticatedCardDataCreate(string primaryAccountNumber)
        {
            // to ensure "primaryAccountNumber" is required (not null)
            if (primaryAccountNumber == null)
            {
                throw new InvalidDataException("primaryAccountNumber is a required property for AuthenticatedCardDataCreate and cannot be null");
            }
            this.PrimaryAccountNumber = primaryAccountNumber;
        }

        /// <summary>
        /// The card holder name is the name printed onto the card. It identifies the person who owns the card.
        /// </summary>
        /// <value>The card holder name is the name printed onto the card. It identifies the person who owns the card.</value>
        [DataMember(Name="cardHolderName", EmitDefaultValue=false)]
        public string CardHolderName { get; set; }

        /// <summary>
        /// The card verification code (CVC) is a 3 to 4 digit code typically printed on the back of the card. It helps to ensure that the card holder is authorizing the transaction. For card not-present transactions this field is optional.
        /// </summary>
        /// <value>The card verification code (CVC) is a 3 to 4 digit code typically printed on the back of the card. It helps to ensure that the card holder is authorizing the transaction. For card not-present transactions this field is optional.</value>
        [DataMember(Name="cardVerificationCode", EmitDefaultValue=false)]
        public string CardVerificationCode { get; set; }

        /// <summary>
        /// The cardholder authentication information. The authentication is optional and can be provided if the cardholder has been already authenticated (e.g. in 3-D Secure system).
        /// </summary>
        /// <value>The cardholder authentication information. The authentication is optional and can be provided if the cardholder has been already authenticated (e.g. in 3-D Secure system).</value>
        [DataMember(Name="cardholderAuthentication", EmitDefaultValue=false)]
        public CardholderAuthenticationCreate CardholderAuthentication { get; set; }

        /// <summary>
        /// The additional authentication value used to secure the tokenized card transactions.
        /// </summary>
        /// <value>The additional authentication value used to secure the tokenized card transactions.</value>
        [DataMember(Name="cryptogram", EmitDefaultValue=false)]
        public CardCryptogramCreate Cryptogram { get; set; }

        /// <summary>
        /// The card expiry date indicates when the card expires. The format is the format yyyy-mm where yyyy is the year (e.g. 2019) and the mm is the month (e.g. 09).
        /// </summary>
        /// <value>The card expiry date indicates when the card expires. The format is the format yyyy-mm where yyyy is the year (e.g. 2019) and the mm is the month (e.g. 09).</value>
        [DataMember(Name="expiryDate", EmitDefaultValue=false)]
        public string ExpiryDate { get; set; }


        /// <summary>
        /// The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card.
        /// </summary>
        /// <value>The primary account number (PAN) identifies the card. The number is numeric and typically printed on the front of the card.</value>
        [DataMember(Name="primaryAccountNumber", EmitDefaultValue=false)]
        public string PrimaryAccountNumber { get; set; }


        /// <summary>
        /// Gets or Sets SchemeTransactionReference
        /// </summary>
        [DataMember(Name="schemeTransactionReference", EmitDefaultValue=false)]
        public string SchemeTransactionReference { get; set; }

        /// <summary>
        /// Gets or Sets TokenRequestorId
        /// </summary>
        [DataMember(Name="tokenRequestorId", EmitDefaultValue=false)]
        public string TokenRequestorId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthenticatedCardDataCreate {\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  CardVerificationCode: ").Append(CardVerificationCode).Append("\n");
            sb.Append("  CardholderAuthentication: ").Append(CardholderAuthentication).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  PanType: ").Append(PanType).Append("\n");
            sb.Append("  PrimaryAccountNumber: ").Append(PrimaryAccountNumber).Append("\n");
            sb.Append("  RecurringIndicator: ").Append(RecurringIndicator).Append("\n");
            sb.Append("  SchemeTransactionReference: ").Append(SchemeTransactionReference).Append("\n");
            sb.Append("  TokenRequestorId: ").Append(TokenRequestorId).Append("\n");
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
            return this.Equals(input as AuthenticatedCardDataCreate);
        }

        /// <summary>
        /// Returns true if AuthenticatedCardDataCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthenticatedCardDataCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthenticatedCardDataCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CardHolderName == input.CardHolderName ||
                    (this.CardHolderName != null &&
                    this.CardHolderName.Equals(input.CardHolderName))
                ) && 
                (
                    this.CardVerificationCode == input.CardVerificationCode ||
                    (this.CardVerificationCode != null &&
                    this.CardVerificationCode.Equals(input.CardVerificationCode))
                ) && 
                (
                    this.CardholderAuthentication == input.CardholderAuthentication ||
                    (this.CardholderAuthentication != null &&
                    this.CardholderAuthentication.Equals(input.CardholderAuthentication))
                ) && 
                (
                    this.Cryptogram == input.Cryptogram ||
                    (this.Cryptogram != null &&
                    this.Cryptogram.Equals(input.Cryptogram))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.PanType == input.PanType ||
                    (this.PanType != null &&
                    this.PanType.Equals(input.PanType))
                ) && 
                (
                    this.PrimaryAccountNumber == input.PrimaryAccountNumber ||
                    (this.PrimaryAccountNumber != null &&
                    this.PrimaryAccountNumber.Equals(input.PrimaryAccountNumber))
                ) && 
                (
                    this.RecurringIndicator == input.RecurringIndicator ||
                    (this.RecurringIndicator != null &&
                    this.RecurringIndicator.Equals(input.RecurringIndicator))
                ) && 
                (
                    this.SchemeTransactionReference == input.SchemeTransactionReference ||
                    (this.SchemeTransactionReference != null &&
                    this.SchemeTransactionReference.Equals(input.SchemeTransactionReference))
                ) && 
                (
                    this.TokenRequestorId == input.TokenRequestorId ||
                    (this.TokenRequestorId != null &&
                    this.TokenRequestorId.Equals(input.TokenRequestorId))
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
                if (this.CardHolderName != null)
                    hashCode = hashCode * 59 + this.CardHolderName.GetHashCode();
                if (this.CardVerificationCode != null)
                    hashCode = hashCode * 59 + this.CardVerificationCode.GetHashCode();
                if (this.CardholderAuthentication != null)
                    hashCode = hashCode * 59 + this.CardholderAuthentication.GetHashCode();
                if (this.Cryptogram != null)
                    hashCode = hashCode * 59 + this.Cryptogram.GetHashCode();
                if (this.ExpiryDate != null)
                    hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.PanType != null)
                    hashCode = hashCode * 59 + this.PanType.GetHashCode();
                if (this.PrimaryAccountNumber != null)
                    hashCode = hashCode * 59 + this.PrimaryAccountNumber.GetHashCode();
                if (this.RecurringIndicator != null)
                    hashCode = hashCode * 59 + this.RecurringIndicator.GetHashCode();
                if (this.SchemeTransactionReference != null)
                    hashCode = hashCode * 59 + this.SchemeTransactionReference.GetHashCode();
                if (this.TokenRequestorId != null)
                    hashCode = hashCode * 59 + this.TokenRequestorId.GetHashCode();
                return hashCode;
            }
        }

    }

}
