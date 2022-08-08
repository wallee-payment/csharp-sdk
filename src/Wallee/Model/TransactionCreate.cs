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
    /// TransactionCreate
    /// </summary>
    [DataContract]
    public partial class TransactionCreate : AbstractTransactionPending,  IEquatable<TransactionCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCreate" /> class.
        /// </summary>
        /// <param name="lineItems">lineItems (required).</param>
        public TransactionCreate(List<LineItemCreate> lineItems)
        {
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new InvalidDataException("lineItems is a required property for TransactionCreate and cannot be null");
            }
            this.LineItems = lineItems;
        }




















        /// <summary>
        /// When auto confirmation is enabled the transaction can be confirmed by the user and does not require an explicit confirmation through the web service API.
        /// </summary>
        /// <value>When auto confirmation is enabled the transaction can be confirmed by the user and does not require an explicit confirmation through the web service API.</value>
        [DataMember(Name="autoConfirmationEnabled", EmitDefaultValue=false)]
        public bool? AutoConfirmationEnabled { get; set; }

        /// <summary>
        /// When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.
        /// </summary>
        /// <value>When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.</value>
        [DataMember(Name="chargeRetryEnabled", EmitDefaultValue=false)]
        public bool? ChargeRetryEnabled { get; set; }

        /// <summary>
        /// The customer&#39;s presence indicates what kind of authentication method was finally used during authorization of the transaction. If no value is provided, &#39;Virtually Present&#39; is used by default.
        /// </summary>
        /// <value>The customer&#39;s presence indicates what kind of authentication method was finally used during authorization of the transaction. If no value is provided, &#39;Virtually Present&#39; is used by default.</value>
        [DataMember(Name="customersPresence", EmitDefaultValue=false)]
        public CustomersPresence CustomersPresence { get; set; }

        /// <summary>
        /// The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.
        /// </summary>
        /// <value>The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.</value>
        [DataMember(Name="deviceSessionIdentifier", EmitDefaultValue=false)]
        public string DeviceSessionIdentifier { get; set; }

        /// <summary>
        /// Flag indicating whether email sending is disabled for this particular transaction. Defaults to false.
        /// </summary>
        /// <value>Flag indicating whether email sending is disabled for this particular transaction. Defaults to false.</value>
        [DataMember(Name="emailsDisabled", EmitDefaultValue=false)]
        public bool? EmailsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Environment Environment { get; set; }

        /// <summary>
        /// The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.
        /// </summary>
        /// <value>The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.</value>
        [DataMember(Name="environmentSelectionStrategy", EmitDefaultValue=false)]
        public TransactionEnvironmentSelectionStrategy EnvironmentSelectionStrategy { get; set; }

        /// <summary>
        /// Gets or Sets SpaceViewId
        /// </summary>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
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
            sb.Append("  AutoConfirmationEnabled: ").Append(AutoConfirmationEnabled).Append("\n");
            sb.Append("  ChargeRetryEnabled: ").Append(ChargeRetryEnabled).Append("\n");
            sb.Append("  CustomersPresence: ").Append(CustomersPresence).Append("\n");
            sb.Append("  DeviceSessionIdentifier: ").Append(DeviceSessionIdentifier).Append("\n");
            sb.Append("  EmailsDisabled: ").Append(EmailsDisabled).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  EnvironmentSelectionStrategy: ").Append(EnvironmentSelectionStrategy).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as TransactionCreate);
        }

        /// <summary>
        /// Returns true if TransactionCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AllowedPaymentMethodBrands == input.AllowedPaymentMethodBrands ||
                    this.AllowedPaymentMethodBrands != null &&
                    input.AllowedPaymentMethodBrands != null &&
                    this.AllowedPaymentMethodBrands.SequenceEqual(input.AllowedPaymentMethodBrands)
                ) && base.Equals(input) && 
                (
                    this.AllowedPaymentMethodConfigurations == input.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    input.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(input.AllowedPaymentMethodConfigurations)
                ) && base.Equals(input) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && base.Equals(input) && 
                (
                    this.CompletionBehavior == input.CompletionBehavior ||
                    (this.CompletionBehavior != null &&
                    this.CompletionBehavior.Equals(input.CompletionBehavior))
                ) && base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.CustomerEmailAddress == input.CustomerEmailAddress ||
                    (this.CustomerEmailAddress != null &&
                    this.CustomerEmailAddress.Equals(input.CustomerEmailAddress))
                ) && base.Equals(input) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && base.Equals(input) && 
                (
                    this.FailedUrl == input.FailedUrl ||
                    (this.FailedUrl != null &&
                    this.FailedUrl.Equals(input.FailedUrl))
                ) && base.Equals(input) && 
                (
                    this.InvoiceMerchantReference == input.InvoiceMerchantReference ||
                    (this.InvoiceMerchantReference != null &&
                    this.InvoiceMerchantReference.Equals(input.InvoiceMerchantReference))
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && base.Equals(input) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && base.Equals(input) && 
                (
                    this.MetaData == input.MetaData ||
                    this.MetaData != null &&
                    input.MetaData != null &&
                    this.MetaData.SequenceEqual(input.MetaData)
                ) && base.Equals(input) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && base.Equals(input) && 
                (
                    this.ShippingMethod == input.ShippingMethod ||
                    (this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(input.ShippingMethod))
                ) && base.Equals(input) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
                ) && base.Equals(input) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && base.Equals(input) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && base.Equals(input) && 
                (
                    this.TokenizationMode == input.TokenizationMode ||
                    (this.TokenizationMode != null &&
                    this.TokenizationMode.Equals(input.TokenizationMode))
                ) && base.Equals(input) && 
                (
                    this.AutoConfirmationEnabled == input.AutoConfirmationEnabled ||
                    (this.AutoConfirmationEnabled != null &&
                    this.AutoConfirmationEnabled.Equals(input.AutoConfirmationEnabled))
                ) && base.Equals(input) && 
                (
                    this.ChargeRetryEnabled == input.ChargeRetryEnabled ||
                    (this.ChargeRetryEnabled != null &&
                    this.ChargeRetryEnabled.Equals(input.ChargeRetryEnabled))
                ) && base.Equals(input) && 
                (
                    this.CustomersPresence == input.CustomersPresence ||
                    (this.CustomersPresence != null &&
                    this.CustomersPresence.Equals(input.CustomersPresence))
                ) && base.Equals(input) && 
                (
                    this.DeviceSessionIdentifier == input.DeviceSessionIdentifier ||
                    (this.DeviceSessionIdentifier != null &&
                    this.DeviceSessionIdentifier.Equals(input.DeviceSessionIdentifier))
                ) && base.Equals(input) && 
                (
                    this.EmailsDisabled == input.EmailsDisabled ||
                    (this.EmailsDisabled != null &&
                    this.EmailsDisabled.Equals(input.EmailsDisabled))
                ) && base.Equals(input) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && base.Equals(input) && 
                (
                    this.EnvironmentSelectionStrategy == input.EnvironmentSelectionStrategy ||
                    (this.EnvironmentSelectionStrategy != null &&
                    this.EnvironmentSelectionStrategy.Equals(input.EnvironmentSelectionStrategy))
                ) && base.Equals(input) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
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
                int hashCode = base.GetHashCode();
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
                if (this.AutoConfirmationEnabled != null)
                    hashCode = hashCode * 59 + this.AutoConfirmationEnabled.GetHashCode();
                if (this.ChargeRetryEnabled != null)
                    hashCode = hashCode * 59 + this.ChargeRetryEnabled.GetHashCode();
                if (this.CustomersPresence != null)
                    hashCode = hashCode * 59 + this.CustomersPresence.GetHashCode();
                if (this.DeviceSessionIdentifier != null)
                    hashCode = hashCode * 59 + this.DeviceSessionIdentifier.GetHashCode();
                if (this.EmailsDisabled != null)
                    hashCode = hashCode * 59 + this.EmailsDisabled.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.EnvironmentSelectionStrategy != null)
                    hashCode = hashCode * 59 + this.EnvironmentSelectionStrategy.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                return hashCode;
            }
        }

    }

}
