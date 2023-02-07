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
    /// AbstractTokenUpdate
    /// </summary>
    [DataContract]
    public partial class AbstractTokenUpdate :  IEquatable<AbstractTokenUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractTokenUpdate" /> class.
        /// </summary>
        public AbstractTokenUpdate()
        {
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
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
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
            var sb = new StringBuilder();
            sb.Append("class AbstractTokenUpdate {\n");
            sb.Append("  CustomerEmailAddress: ").Append(CustomerEmailAddress).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  EnabledForOneClickPayment: ").Append(EnabledForOneClickPayment).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  TokenReference: ").Append(TokenReference).Append("\n");
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
            return this.Equals(input as AbstractTokenUpdate);
        }

        /// <summary>
        /// Returns true if AbstractTokenUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractTokenUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractTokenUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerEmailAddress == input.CustomerEmailAddress ||
                    (this.CustomerEmailAddress != null &&
                    this.CustomerEmailAddress.Equals(input.CustomerEmailAddress))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.EnabledForOneClickPayment == input.EnabledForOneClickPayment ||
                    (this.EnabledForOneClickPayment != null &&
                    this.EnabledForOneClickPayment.Equals(input.EnabledForOneClickPayment))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.TokenReference == input.TokenReference ||
                    (this.TokenReference != null &&
                    this.TokenReference.Equals(input.TokenReference))
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
                if (this.CustomerEmailAddress != null)
                    hashCode = hashCode * 59 + this.CustomerEmailAddress.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.EnabledForOneClickPayment != null)
                    hashCode = hashCode * 59 + this.EnabledForOneClickPayment.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TokenReference != null)
                    hashCode = hashCode * 59 + this.TokenReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
