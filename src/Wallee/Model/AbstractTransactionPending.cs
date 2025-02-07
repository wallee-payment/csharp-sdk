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
    /// AbstractTransactionPending
    /// </summary>
    [DataContract]
    public partial class AbstractTransactionPending :  IEquatable<AbstractTransactionPending>
    {
        /// <summary>
        /// The behavior that controls when the transaction is completed.
        /// </summary>
        /// <value>The behavior that controls when the transaction is completed.</value>
        [DataMember(Name="completionBehavior", EmitDefaultValue=false)]
        public TransactionCompletionBehavior? CompletionBehavior { get; set; }
        /// <summary>
        /// The tokenization mode specifies whether and how the tokenization of payment information is applied to the transaction.
        /// </summary>
        /// <value>The tokenization mode specifies whether and how the tokenization of payment information is applied to the transaction.</value>
        [DataMember(Name="tokenizationMode", EmitDefaultValue=false)]
        public TokenizationMode? TokenizationMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractTransactionPending" /> class.
        /// </summary>
        public AbstractTransactionPending()
        {
        }

        /// <summary>
        /// The payment method brands that can be used to authorize the transaction.
        /// </summary>
        /// <value>The payment method brands that can be used to authorize the transaction.</value>
        [DataMember(Name="allowedPaymentMethodBrands", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodBrands { get; set; }

        /// <summary>
        /// The payment method configurations that can be used to authorize the transaction.
        /// </summary>
        /// <value>The payment method configurations that can be used to authorize the transaction.</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// The address associated with the payment method for invoicing and transaction processing purposes.
        /// </summary>
        /// <value>The address associated with the payment method for invoicing and transaction processing purposes.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AddressCreate BillingAddress { get; set; }


        /// <summary>
        /// The three-letter code (ISO 4217 format) of the transaction&#39;s currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the transaction&#39;s currency.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The customer&#39;s email address.
        /// </summary>
        /// <value>The customer&#39;s email address.</value>
        [DataMember(Name="customerEmailAddress", EmitDefaultValue=false)]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// The unique identifier of the customer in the external system.
        /// </summary>
        /// <value>The unique identifier of the customer in the external system.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// The URL to redirect the customer back to after they canceled or failed to authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they canceled or failed to authenticated their payment.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name="invoiceMerchantReference", EmitDefaultValue=false)]
        public string InvoiceMerchantReference { get; set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// The line items purchased by the customer.
        /// </summary>
        /// <value>The line items purchased by the customer.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the transaction.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the transaction.</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// Allow to store additional information about the object.
        /// </summary>
        /// <value>Allow to store additional information about the object.</value>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// The address to where the order will be shipped.
        /// </summary>
        /// <value>The address to where the order will be shipped.</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public AddressCreate ShippingAddress { get; set; }

        /// <summary>
        /// The name of the shipping method used to ship the products.
        /// </summary>
        /// <value>The name of the shipping method used to ship the products.</value>
        [DataMember(Name="shippingMethod", EmitDefaultValue=false)]
        public string ShippingMethod { get; set; }

        /// <summary>
        /// The URL to redirect the customer back to after they successfully authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they successfully authenticated their payment.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.
        /// </summary>
        /// <value>The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// The payment token that should be used to charge the customer.
        /// </summary>
        /// <value>The payment token that should be used to charge the customer.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public long? Token { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractTransactionPending {\n");
            sb.Append("  AllowedPaymentMethodBrands: ").Append(AllowedPaymentMethodBrands).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  CompletionBehavior: ").Append(CompletionBehavior).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerEmailAddress: ").Append(CustomerEmailAddress).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
            sb.Append("  InvoiceMerchantReference: ").Append(InvoiceMerchantReference).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenizationMode: ").Append(TokenizationMode).Append("\n");
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
            return this.Equals(input as AbstractTransactionPending);
        }

        /// <summary>
        /// Returns true if AbstractTransactionPending instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractTransactionPending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractTransactionPending input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedPaymentMethodBrands == input.AllowedPaymentMethodBrands ||
                    this.AllowedPaymentMethodBrands != null &&
                    input.AllowedPaymentMethodBrands != null &&
                    this.AllowedPaymentMethodBrands.SequenceEqual(input.AllowedPaymentMethodBrands)
                ) && 
                (
                    this.AllowedPaymentMethodConfigurations == input.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    input.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(input.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.CompletionBehavior == input.CompletionBehavior ||
                    (this.CompletionBehavior != null &&
                    this.CompletionBehavior.Equals(input.CompletionBehavior))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
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
                    this.FailedUrl == input.FailedUrl ||
                    (this.FailedUrl != null &&
                    this.FailedUrl.Equals(input.FailedUrl))
                ) && 
                (
                    this.InvoiceMerchantReference == input.InvoiceMerchantReference ||
                    (this.InvoiceMerchantReference != null &&
                    this.InvoiceMerchantReference.Equals(input.InvoiceMerchantReference))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    this.MetaData != null &&
                    input.MetaData != null &&
                    this.MetaData.SequenceEqual(input.MetaData)
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.ShippingMethod == input.ShippingMethod ||
                    (this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(input.ShippingMethod))
                ) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokenizationMode == input.TokenizationMode ||
                    (this.TokenizationMode != null &&
                    this.TokenizationMode.Equals(input.TokenizationMode))
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
                if (this.AllowedPaymentMethodBrands != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethodBrands.GetHashCode();
                if (this.AllowedPaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.CompletionBehavior != null)
                    hashCode = hashCode * 59 + this.CompletionBehavior.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CustomerEmailAddress != null)
                    hashCode = hashCode * 59 + this.CustomerEmailAddress.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.FailedUrl != null)
                    hashCode = hashCode * 59 + this.FailedUrl.GetHashCode();
                if (this.InvoiceMerchantReference != null)
                    hashCode = hashCode * 59 + this.InvoiceMerchantReference.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.ShippingMethod != null)
                    hashCode = hashCode * 59 + this.ShippingMethod.GetHashCode();
                if (this.SuccessUrl != null)
                    hashCode = hashCode * 59 + this.SuccessUrl.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenizationMode != null)
                    hashCode = hashCode * 59 + this.TokenizationMode.GetHashCode();
                return hashCode;
            }
        }

    }

}
