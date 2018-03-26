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
    /// Abstract Transaction
    /// </summary>
    [DataContract]
    public partial class AbstractTransactionPending :  IEquatable<AbstractTransactionPending>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractTransactionPending" /> class.
        /// </summary>
        /// <param name="AllowedPaymentMethodBrands">AllowedPaymentMethodBrands</param>
        /// <param name="AllowedPaymentMethodConfigurations">AllowedPaymentMethodConfigurations</param>
        /// <param name="BillingAddress">BillingAddress</param>
        /// <param name="Currency">Currency</param>
        /// <param name="CustomerEmailAddress">The customer email address is the email address of the customer. If no email address is provided on the shipping or billing address this address is used.</param>
        /// <param name="CustomerId">CustomerId</param>
        /// <param name="FailedUrl">The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</param>
        /// <param name="InvoiceMerchantReference">InvoiceMerchantReference</param>
        /// <param name="Language">Language</param>
        /// <param name="LineItems">LineItems</param>
        /// <param name="MerchantReference">MerchantReference</param>
        /// <param name="MetaData">Meta data allow to store additional data along the object.</param>
        /// <param name="ShippingAddress">ShippingAddress</param>
        /// <param name="ShippingMethod">ShippingMethod</param>
        /// <param name="SuccessUrl">The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</param>
        /// <param name="TimeZone">The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.</param>
        /// <param name="Token">Token</param>
        public AbstractTransactionPending(List<PaymentMethodBrand> AllowedPaymentMethodBrands = default(List<PaymentMethodBrand>), string SuccessUrl = default(string), string InvoiceMerchantReference = default(string), string Currency = default(string), long? Token = default(long?), AddressCreate BillingAddress = default(AddressCreate), List<long?> AllowedPaymentMethodConfigurations = default(List<long?>), string CustomerEmailAddress = default(string), string FailedUrl = default(string), Dictionary<string, string> MetaData = default(Dictionary<string, string>), string ShippingMethod = default(string), string CustomerId = default(string), List<LineItemCreate> LineItems = default(List<LineItemCreate>), AddressCreate ShippingAddress = default(AddressCreate), string Language = default(string), string MerchantReference = default(string), string TimeZone = default(string))
        {
            this.AllowedPaymentMethodBrands = AllowedPaymentMethodBrands;
            this.AllowedPaymentMethodConfigurations = AllowedPaymentMethodConfigurations;
            this.BillingAddress = BillingAddress;
            this.Currency = Currency;
            this.CustomerEmailAddress = CustomerEmailAddress;
            this.CustomerId = CustomerId;
            this.FailedUrl = FailedUrl;
            this.InvoiceMerchantReference = InvoiceMerchantReference;
            this.Language = Language;
            this.LineItems = LineItems;
            this.MerchantReference = MerchantReference;
            this.MetaData = MetaData;
            this.ShippingAddress = ShippingAddress;
            this.ShippingMethod = ShippingMethod;
            this.SuccessUrl = SuccessUrl;
            this.TimeZone = TimeZone;
            this.Token = Token;
        }

        /// <summary>
        /// AllowedPaymentMethodBrands
        /// </summary>
        /// <value>AllowedPaymentMethodBrands</value>
        [DataMember(Name="allowedPaymentMethodBrands", EmitDefaultValue=false)]
        public List<PaymentMethodBrand> AllowedPaymentMethodBrands { get; set; }

        /// <summary>
        /// AllowedPaymentMethodConfigurations
        /// </summary>
        /// <value>AllowedPaymentMethodConfigurations</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// BillingAddress
        /// </summary>
        /// <value>BillingAddress</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The customer email address is the email address of the customer. If no email address is provided on the shipping or billing address this address is used.
        /// </summary>
        /// <value>The customer email address is the email address of the customer. If no email address is provided on the shipping or billing address this address is used.</value>
        [DataMember(Name="customerEmailAddress", EmitDefaultValue=false)]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// CustomerId
        /// </summary>
        /// <value>CustomerId</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// InvoiceMerchantReference
        /// </summary>
        /// <value>InvoiceMerchantReference</value>
        [DataMember(Name="invoiceMerchantReference", EmitDefaultValue=false)]
        public string InvoiceMerchantReference { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// LineItems
        /// </summary>
        /// <value>LineItems</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// MerchantReference
        /// </summary>
        /// <value>MerchantReference</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Meta data allow to store additional data along the object.
        /// </summary>
        /// <value>Meta data allow to store additional data along the object.</value>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// ShippingAddress
        /// </summary>
        /// <value>ShippingAddress</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public AddressCreate ShippingAddress { get; set; }

        /// <summary>
        /// ShippingMethod
        /// </summary>
        /// <value>ShippingMethod</value>
        [DataMember(Name="shippingMethod", EmitDefaultValue=false)]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.
        /// </summary>
        /// <value>The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        /// <value>Token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public long? Token { get; set; }

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
            return this.Equals(obj as AbstractTransactionPending);
        }

        /// <summary>
        /// Returns true if AbstractTransactionPending instances are equal
        /// </summary>
        /// <param name="other">Instance of AbstractTransactionPending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractTransactionPending other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AllowedPaymentMethodBrands == other.AllowedPaymentMethodBrands ||
                    this.AllowedPaymentMethodBrands != null &&
                    this.AllowedPaymentMethodBrands.SequenceEqual(other.AllowedPaymentMethodBrands)
                ) && 
                (
                    this.AllowedPaymentMethodConfigurations == other.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(other.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
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
                    this.FailedUrl == other.FailedUrl ||
                    this.FailedUrl != null &&
                    this.FailedUrl.Equals(other.FailedUrl)
                ) && 
                (
                    this.InvoiceMerchantReference == other.InvoiceMerchantReference ||
                    this.InvoiceMerchantReference != null &&
                    this.InvoiceMerchantReference.Equals(other.InvoiceMerchantReference)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.SequenceEqual(other.MetaData)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.ShippingMethod == other.ShippingMethod ||
                    this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(other.ShippingMethod)
                ) && 
                (
                    this.SuccessUrl == other.SuccessUrl ||
                    this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(other.SuccessUrl)
                ) && 
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                if (this.AllowedPaymentMethodBrands != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodBrands.GetHashCode();
                }
                if (this.AllowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hash = hash * 59 + this.Currency.GetHashCode();
                }
                if (this.CustomerEmailAddress != null)
                {
                    hash = hash * 59 + this.CustomerEmailAddress.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                }
                if (this.FailedUrl != null)
                {
                    hash = hash * 59 + this.FailedUrl.GetHashCode();
                }
                if (this.InvoiceMerchantReference != null)
                {
                    hash = hash * 59 + this.InvoiceMerchantReference.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                }
                if (this.MetaData != null)
                {
                    hash = hash * 59 + this.MetaData.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                }
                if (this.ShippingMethod != null)
                {
                    hash = hash * 59 + this.ShippingMethod.GetHashCode();
                }
                if (this.SuccessUrl != null)
                {
                    hash = hash * 59 + this.SuccessUrl.GetHashCode();
                }
                if (this.TimeZone != null)
                {
                    hash = hash * 59 + this.TimeZone.GetHashCode();
                }
                if (this.Token != null)
                {
                    hash = hash * 59 + this.Token.GetHashCode();
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
