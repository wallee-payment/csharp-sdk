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
    /// Transaction
    /// </summary>
    [DataContract]
    public partial class TransactionCreate : AbstractTransactionPending,  IEquatable<TransactionCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCreate" /> class.
        /// </summary>
        /// <param name="AutoConfirmationEnabled">When auto confirmation is enabled the transaction can be confirmed by the user and does not require an explicit confirmation through the web service API.</param>
        /// <param name="ChargeRetryEnabled">When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.</param>
        /// <param name="CustomersPresence">The customer&#39;s presence indicates what kind of authentication methods can be used during the authorization of the transaction. If no value is provided, &#39;Virtually Present&#39; is used by default.</param>
        /// <param name="DeviceSessionIdentifier">The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.</param>
        /// <param name="Environment">Environment</param>
        /// <param name="EnvironmentSelectionStrategy">The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.</param>
        /// <param name="SpaceViewId">SpaceViewId</param>
        public TransactionCreate(string InvoiceMerchantReference = default(string), string Language = default(string), string Currency = default(string), Dictionary<string, string> MetaData = default(Dictionary<string, string>), string CustomerId = default(string), List<long?> AllowedPaymentMethodConfigurations = default(List<long?>), long? SpaceViewId = default(long?), long? Token = default(long?), string ShippingMethod = default(string), List<PaymentMethodBrand> AllowedPaymentMethodBrands = default(List<PaymentMethodBrand>), string DeviceSessionIdentifier = default(string), string TimeZone = default(string), TransactionEnvironmentSelectionStrategy? EnvironmentSelectionStrategy = default(TransactionEnvironmentSelectionStrategy?), string SuccessUrl = default(string), List<LineItemCreate> LineItems = default(List<LineItemCreate>), CustomersPresence? CustomersPresence = default(CustomersPresence?), Environment? Environment = default(Environment?), string CustomerEmailAddress = default(string), string FailedUrl = default(string), TokenizationnMode? TokenizationMode = default(TokenizationnMode?), bool? ChargeRetryEnabled = default(bool?), string MerchantReference = default(string), AddressCreate ShippingAddress = default(AddressCreate), bool? AutoConfirmationEnabled = default(bool?), AddressCreate BillingAddress = default(AddressCreate))
        {
            this.AutoConfirmationEnabled = AutoConfirmationEnabled;
            this.ChargeRetryEnabled = ChargeRetryEnabled;
            this.CustomersPresence = CustomersPresence;
            this.DeviceSessionIdentifier = DeviceSessionIdentifier;
            this.Environment = Environment;
            this.EnvironmentSelectionStrategy = EnvironmentSelectionStrategy;
            this.SpaceViewId = SpaceViewId;
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
            this.TokenizationMode = TokenizationMode;
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
        /// The customer's presence indicates what kind of authentication methods can be used during the authorization of the transaction. If no value is provided, 'Virtually Present' is used by default.
        /// </summary>
        /// <value>The customer's presence indicates what kind of authentication methods can be used during the authorization of the transaction. If no value is provided, 'Virtually Present' is used by default.</value>
        [DataMember(Name="customersPresence", EmitDefaultValue=false)]
        public CustomersPresence? CustomersPresence { get; set; }

        /// <summary>
        /// The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.
        /// </summary>
        /// <value>The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.</value>
        [DataMember(Name="deviceSessionIdentifier", EmitDefaultValue=false)]
        public string DeviceSessionIdentifier { get; set; }

        /// <summary>
        /// Environment
        /// </summary>
        /// <value>Environment</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Environment? Environment { get; set; }

        /// <summary>
        /// The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.
        /// </summary>
        /// <value>The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.</value>
        [DataMember(Name="environmentSelectionStrategy", EmitDefaultValue=false)]
        public TransactionEnvironmentSelectionStrategy? EnvironmentSelectionStrategy { get; set; }

        /// <summary>
        /// SpaceViewId
        /// </summary>
        /// <value>SpaceViewId</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; set; }

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
        public new string ToJson()
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
            return this.Equals(obj as TransactionCreate);
        }

        /// <summary>
        /// Returns true if TransactionCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AutoConfirmationEnabled == other.AutoConfirmationEnabled ||
                    this.AutoConfirmationEnabled != null &&
                    this.AutoConfirmationEnabled.Equals(other.AutoConfirmationEnabled)
                ) && 
                (
                    this.ChargeRetryEnabled == other.ChargeRetryEnabled ||
                    this.ChargeRetryEnabled != null &&
                    this.ChargeRetryEnabled.Equals(other.ChargeRetryEnabled)
                ) && 
                (
                    this.CustomersPresence == other.CustomersPresence ||
                    this.CustomersPresence != null &&
                    this.CustomersPresence.Equals(other.CustomersPresence)
                ) && 
                (
                    this.DeviceSessionIdentifier == other.DeviceSessionIdentifier ||
                    this.DeviceSessionIdentifier != null &&
                    this.DeviceSessionIdentifier.Equals(other.DeviceSessionIdentifier)
                ) && 
                (
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) && 
                (
                    this.EnvironmentSelectionStrategy == other.EnvironmentSelectionStrategy ||
                    this.EnvironmentSelectionStrategy != null &&
                    this.EnvironmentSelectionStrategy.Equals(other.EnvironmentSelectionStrategy)
                ) && 
                (
                    this.SpaceViewId == other.SpaceViewId ||
                    this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(other.SpaceViewId)
                ) && 
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
                ) && 
                (
                    this.TokenizationMode == other.TokenizationMode ||
                    this.TokenizationMode != null &&
                    this.TokenizationMode.Equals(other.TokenizationMode)
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
                if (this.AutoConfirmationEnabled != null)
                {
                    hash = hash * 59 + this.AutoConfirmationEnabled.GetHashCode();
                }
                if (this.ChargeRetryEnabled != null)
                {
                    hash = hash * 59 + this.ChargeRetryEnabled.GetHashCode();
                }
                if (this.CustomersPresence != null)
                {
                    hash = hash * 59 + this.CustomersPresence.GetHashCode();
                }
                if (this.DeviceSessionIdentifier != null)
                {
                    hash = hash * 59 + this.DeviceSessionIdentifier.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hash = hash * 59 + this.Environment.GetHashCode();
                }
                if (this.EnvironmentSelectionStrategy != null)
                {
                    hash = hash * 59 + this.EnvironmentSelectionStrategy.GetHashCode();
                }
                if (this.SpaceViewId != null)
                {
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                }
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
                if (this.TokenizationMode != null)
                {
                    hash = hash * 59 + this.TokenizationMode.GetHashCode();
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
