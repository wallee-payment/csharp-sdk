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

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Abstract Token
    /// </summary>
    [DataContract]
    public partial class AbstractTokenUpdate :  IEquatable<AbstractTokenUpdate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractTokenUpdate" /> class.
        /// </summary>
        /// <param name="CustomerEmailAddress">The customer email address is the email address of the customer.</param>
        /// <param name="CustomerId">The customer ID identifies the customer in the merchant system. In case the customer ID has been provided it has to correspond with the customer ID provided on the transaction. The customer ID will not be changed automatically. The merchant system has to provide it.</param>
        /// <param name="EnabledForOneClickPayment">When a token is enabled for one-click payments the buyer will be able to select the token within the iFrame or on the payment page to pay with the token. The usage of the token will reduce the number of steps the buyer has to go through. The buyer is linked via the customer ID on the transaction with the token. Means the token will be visible for buyers with the same customer ID. Additionally the payment method has to be configured to allow the one-click payments.</param>
        /// <param name="Language">Language</param>
        /// <param name="TimeZone">The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.</param>
        /// <param name="TokenReference">Use something that it is easy to identify and may help you find the token (e.g. customer id, email address).</param>
        public AbstractTokenUpdate(string CustomerEmailAddress = default(string), bool? EnabledForOneClickPayment = default(bool?), string Language = default(string), string TokenReference = default(string), string CustomerId = default(string), string TimeZone = default(string))
        {
            this.CustomerEmailAddress = CustomerEmailAddress;
            this.CustomerId = CustomerId;
            this.EnabledForOneClickPayment = EnabledForOneClickPayment;
            this.Language = Language;
            this.TimeZone = TimeZone;
            this.TokenReference = TokenReference;
        }

        /// <summary>
        /// The customer email address is the email address of the customer.
        /// </summary>
        /// <value>The customer email address is the email address of the customer.</value>
        [DataMember(Name="customerEmailAddress", EmitDefaultValue=false)]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// The customer ID identifies the customer in the merchant system. In case the customer ID has been provided it has to correspond with the customer ID provided on the transaction. The customer ID will not be changed automatically. The merchant system has to provide it.
        /// </summary>
        /// <value>The customer ID identifies the customer in the merchant system. In case the customer ID has been provided it has to correspond with the customer ID provided on the transaction. The customer ID will not be changed automatically. The merchant system has to provide it.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// When a token is enabled for one-click payments the buyer will be able to select the token within the iFrame or on the payment page to pay with the token. The usage of the token will reduce the number of steps the buyer has to go through. The buyer is linked via the customer ID on the transaction with the token. Means the token will be visible for buyers with the same customer ID. Additionally the payment method has to be configured to allow the one-click payments.
        /// </summary>
        /// <value>When a token is enabled for one-click payments the buyer will be able to select the token within the iFrame or on the payment page to pay with the token. The usage of the token will reduce the number of steps the buyer has to go through. The buyer is linked via the customer ID on the transaction with the token. Means the token will be visible for buyers with the same customer ID. Additionally the payment method has to be configured to allow the one-click payments.</value>
        [DataMember(Name="enabledForOneClickPayment", EmitDefaultValue=false)]
        public bool? EnabledForOneClickPayment { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.
        /// </summary>
        /// <value>The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Use something that it is easy to identify and may help you find the token (e.g. customer id, email address).
        /// </summary>
        /// <value>Use something that it is easy to identify and may help you find the token (e.g. customer id, email address).</value>
        [DataMember(Name="tokenReference", EmitDefaultValue=false)]
        public string TokenReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as AbstractTokenUpdate);
        }

        /// <summary>
        /// Returns true if AbstractTokenUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractTokenUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractTokenUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CustomerEmailAddress == other.CustomerEmailAddress ||
                    this.CustomerEmailAddress != null &&
                    this.CustomerEmailAddress.Equals(other.CustomerEmailAddress)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.EnabledForOneClickPayment == other.EnabledForOneClickPayment ||
                    this.EnabledForOneClickPayment != null &&
                    this.EnabledForOneClickPayment.Equals(other.EnabledForOneClickPayment)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.TokenReference == other.TokenReference ||
                    this.TokenReference != null &&
                    this.TokenReference.Equals(other.TokenReference)
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
                int hash = 41;
                if (this.CustomerEmailAddress != null)
                {
                    hash = hash * 59 + this.CustomerEmailAddress.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                }
                if (this.EnabledForOneClickPayment != null)
                {
                    hash = hash * 59 + this.EnabledForOneClickPayment.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                }
                if (this.TokenReference != null)
                {
                    hash = hash * 59 + this.TokenReference.GetHashCode();
                }
                return hash;
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
