
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
    /// TransactionPending model.
    /// </summary>
    [DataContract]
    public partial class TransactionPending :  IEquatable<TransactionPending>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPending" /> class.
        /// </summary>
        /// <param name="AcceptHeader">AcceptHeader</param>
        /// <param name="AllowedPaymentMethodBrands">AllowedPaymentMethodBrands</param>
        /// <param name="AllowedPaymentMethodConfigurations">AllowedPaymentMethodConfigurations</param>
        /// <param name="AuthorizationAmount">AuthorizationAmount</param>
        /// <param name="AuthorizedOn">AuthorizedOn</param>
        /// <param name="BillingAddress">BillingAddress</param>
        /// <param name="ChargeRetryEnabled">When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.</param>
        /// <param name="CompletedOn">CompletedOn</param>
        /// <param name="CompletionTimeoutOn">CompletionTimeoutOn</param>
        /// <param name="ConfirmedBy">ConfirmedBy</param>
        /// <param name="ConfirmedOn">ConfirmedOn</param>
        /// <param name="CreatedBy">CreatedBy</param>
        /// <param name="CreatedOn">The created on date indicates the date on which the entity was stored into the database.</param>
        /// <param name="Currency">Currency</param>
        /// <param name="CustomerEmailAddress">The customer email address is the email address of the customer. If no email address is used provided on the shipping or billing address this address is used.</param>
        /// <param name="CustomerId">CustomerId</param>
        /// <param name="CustomersPresence">CustomersPresence</param>
        /// <param name="EndOfLife">The transaction&#39;s end of life indicates the date from which on no operation can be carried out anymore.</param>
        /// <param name="FailedOn">FailedOn</param>
        /// <param name="FailedUrl">The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</param>
        /// <param name="Group">Group</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="InternetProtocolAddress">InternetProtocolAddress</param>
        /// <param name="InternetProtocolAddressCountry">InternetProtocolAddressCountry</param>
        /// <param name="InvoiceMerchantReference">InvoiceMerchantReference</param>
        /// <param name="Language">Language</param>
        /// <param name="LineItems">LineItems</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="MerchantReference">MerchantReference</param>
        /// <param name="MetaData">Meta data allow to store additional data along the object.</param>
        /// <param name="PaymentConnectorConfiguration">PaymentConnectorConfiguration</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="ProcessingOn">ProcessingOn</param>
        /// <param name="RefundedAmount">The refunded amount is the total amount which has been refunded so far.</param>
        /// <param name="ShippingAddress">ShippingAddress</param>
        /// <param name="ShippingMethod">ShippingMethod</param>
        /// <param name="SpaceViewId">SpaceViewId</param>
        /// <param name="State">State</param>
        /// <param name="SuccessUrl">The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</param>
        /// <param name="Token">Token</param>
        /// <param name="UserAgentHeader">UserAgentHeader</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public TransactionPending(string AcceptHeader = default(string), List<PaymentMethodBrand> AllowedPaymentMethodBrands = default(List<PaymentMethodBrand>), List<long?> AllowedPaymentMethodConfigurations = default(List<long?>), decimal? AuthorizationAmount = default(decimal?), DateTime? AuthorizedOn = default(DateTime?), AddressCreate BillingAddress = default(AddressCreate), bool? ChargeRetryEnabled = default(bool?), DateTime? CompletedOn = default(DateTime?), DateTime? CompletionTimeoutOn = default(DateTime?), long? ConfirmedBy = default(long?), DateTime? ConfirmedOn = default(DateTime?), long? CreatedBy = default(long?), DateTime? CreatedOn = default(DateTime?), string Currency = default(string), string CustomerEmailAddress = default(string), string CustomerId = default(string), CustomersPresence CustomersPresence = default(CustomersPresence), DateTime? EndOfLife = default(DateTime?), DateTime? FailedOn = default(DateTime?), string FailedUrl = default(string), TransactionGroup Group = default(TransactionGroup), long? Id = default(long?), string InternetProtocolAddress = default(string), string InternetProtocolAddressCountry = default(string), string InvoiceMerchantReference = default(string), string Language = default(string), List<LineItemCreate> LineItems = default(List<LineItemCreate>), long? LinkedSpaceId = default(long?), string MerchantReference = default(string), Dictionary<string, string> MetaData = default(Dictionary<string, string>), PaymentConnectorConfiguration PaymentConnectorConfiguration = default(PaymentConnectorConfiguration), DateTime? PlannedPurgeDate = default(DateTime?), DateTime? ProcessingOn = default(DateTime?), decimal? RefundedAmount = default(decimal?), AddressCreate ShippingAddress = default(AddressCreate), string ShippingMethod = default(string), long? SpaceViewId = default(long?), TransactionState State = default(TransactionState), string SuccessUrl = default(string), long? Token = default(long?), string UserAgentHeader = default(string), long? Version = default(long?))
        {
            this.AcceptHeader = AcceptHeader;
            this.AllowedPaymentMethodBrands = AllowedPaymentMethodBrands;
            this.AllowedPaymentMethodConfigurations = AllowedPaymentMethodConfigurations;
            this.AuthorizationAmount = AuthorizationAmount;
            this.AuthorizedOn = AuthorizedOn;
            this.BillingAddress = BillingAddress;
            this.ChargeRetryEnabled = ChargeRetryEnabled;
            this.CompletedOn = CompletedOn;
            this.CompletionTimeoutOn = CompletionTimeoutOn;
            this.ConfirmedBy = ConfirmedBy;
            this.ConfirmedOn = ConfirmedOn;
            this.CreatedBy = CreatedBy;
            this.CreatedOn = CreatedOn;
            this.Currency = Currency;
            this.CustomerEmailAddress = CustomerEmailAddress;
            this.CustomerId = CustomerId;
            this.CustomersPresence = CustomersPresence;
            this.EndOfLife = EndOfLife;
            this.FailedOn = FailedOn;
            this.FailedUrl = FailedUrl;
            this.Group = Group;
            this.Id = Id;
            this.InternetProtocolAddress = InternetProtocolAddress;
            this.InternetProtocolAddressCountry = InternetProtocolAddressCountry;
            this.InvoiceMerchantReference = InvoiceMerchantReference;
            this.Language = Language;
            this.LineItems = LineItems;
            this.LinkedSpaceId = LinkedSpaceId;
            this.MerchantReference = MerchantReference;
            this.MetaData = MetaData;
            this.PaymentConnectorConfiguration = PaymentConnectorConfiguration;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.ProcessingOn = ProcessingOn;
            this.RefundedAmount = RefundedAmount;
            this.ShippingAddress = ShippingAddress;
            this.ShippingMethod = ShippingMethod;
            this.SpaceViewId = SpaceViewId;
            this.State = State;
            this.SuccessUrl = SuccessUrl;
            this.Token = Token;
            this.UserAgentHeader = UserAgentHeader;
            this.Version = Version;
        }

        /// <summary>
        /// AcceptHeader
        /// </summary>
        /// <value>AcceptHeader</value>
        [DataMember(Name="acceptHeader", EmitDefaultValue=false)]
        public string AcceptHeader { get; set; }

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
        /// AuthorizationAmount
        /// </summary>
        /// <value>AuthorizationAmount</value>
        [DataMember(Name="authorizationAmount", EmitDefaultValue=false)]
        public decimal? AuthorizationAmount { get; set; }

        /// <summary>
        /// AuthorizedOn
        /// </summary>
        /// <value>AuthorizedOn</value>
        [DataMember(Name="authorizedOn", EmitDefaultValue=false)]
        public DateTime? AuthorizedOn { get; set; }

        /// <summary>
        /// BillingAddress
        /// </summary>
        /// <value>BillingAddress</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.
        /// </summary>
        /// <value>When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.</value>
        [DataMember(Name="chargeRetryEnabled", EmitDefaultValue=false)]
        public bool? ChargeRetryEnabled { get; set; }

        /// <summary>
        /// CompletedOn
        /// </summary>
        /// <value>CompletedOn</value>
        [DataMember(Name="completedOn", EmitDefaultValue=false)]
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// CompletionTimeoutOn
        /// </summary>
        /// <value>CompletionTimeoutOn</value>
        [DataMember(Name="completionTimeoutOn", EmitDefaultValue=false)]
        public DateTime? CompletionTimeoutOn { get; set; }

        /// <summary>
        /// ConfirmedBy
        /// </summary>
        /// <value>ConfirmedBy</value>
        [DataMember(Name="confirmedBy", EmitDefaultValue=false)]
        public long? ConfirmedBy { get; set; }

        /// <summary>
        /// ConfirmedOn
        /// </summary>
        /// <value>ConfirmedOn</value>
        [DataMember(Name="confirmedOn", EmitDefaultValue=false)]
        public DateTime? ConfirmedOn { get; set; }

        /// <summary>
        /// CreatedBy
        /// </summary>
        /// <value>CreatedBy</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        /// <value>Currency</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// The customer email address is the email address of the customer. If no email address is used provided on the shipping or billing address this address is used.
        /// </summary>
        /// <value>The customer email address is the email address of the customer. If no email address is used provided on the shipping or billing address this address is used.</value>
        [DataMember(Name="customerEmailAddress", EmitDefaultValue=false)]
        public string CustomerEmailAddress { get; set; }

        /// <summary>
        /// CustomerId
        /// </summary>
        /// <value>CustomerId</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// CustomersPresence
        /// </summary>
        /// <value>CustomersPresence</value>
        [DataMember(Name="customersPresence", EmitDefaultValue=false)]
        public CustomersPresence CustomersPresence { get; set; }

        /// <summary>
        /// The transaction&#39;s end of life indicates the date from which on no operation can be carried out anymore.
        /// </summary>
        /// <value>The transaction&#39;s end of life indicates the date from which on no operation can be carried out anymore.</value>
        [DataMember(Name="endOfLife", EmitDefaultValue=false)]
        public DateTime? EndOfLife { get; set; }

        /// <summary>
        /// FailedOn
        /// </summary>
        /// <value>FailedOn</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; set; }

        /// <summary>
        /// The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// Group
        /// </summary>
        /// <value>Group</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public TransactionGroup Group { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// InternetProtocolAddress
        /// </summary>
        /// <value>InternetProtocolAddress</value>
        [DataMember(Name="internetProtocolAddress", EmitDefaultValue=false)]
        public string InternetProtocolAddress { get; set; }

        /// <summary>
        /// InternetProtocolAddressCountry
        /// </summary>
        /// <value>InternetProtocolAddressCountry</value>
        [DataMember(Name="internetProtocolAddressCountry", EmitDefaultValue=false)]
        public string InternetProtocolAddressCountry { get; set; }

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
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

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
        /// PaymentConnectorConfiguration
        /// </summary>
        /// <value>PaymentConnectorConfiguration</value>
        [DataMember(Name="paymentConnectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// ProcessingOn
        /// </summary>
        /// <value>ProcessingOn</value>
        [DataMember(Name="processingOn", EmitDefaultValue=false)]
        public DateTime? ProcessingOn { get; set; }

        /// <summary>
        /// The refunded amount is the total amount which has been refunded so far.
        /// </summary>
        /// <value>The refunded amount is the total amount which has been refunded so far.</value>
        [DataMember(Name="refundedAmount", EmitDefaultValue=false)]
        public decimal? RefundedAmount { get; set; }

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
        /// SpaceViewId
        /// </summary>
        /// <value>SpaceViewId</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public TransactionState State { get; set; }

        /// <summary>
        /// The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        /// <value>Token</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public long? Token { get; set; }

        /// <summary>
        /// UserAgentHeader
        /// </summary>
        /// <value>UserAgentHeader</value>
        [DataMember(Name="userAgentHeader", EmitDefaultValue=false)]
        public string UserAgentHeader { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionPending {\n");
            sb.Append("  AcceptHeader: ").Append(AcceptHeader).Append("\n");
            sb.Append("  AllowedPaymentMethodBrands: ").Append(AllowedPaymentMethodBrands).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  AuthorizationAmount: ").Append(AuthorizationAmount).Append("\n");
            sb.Append("  AuthorizedOn: ").Append(AuthorizedOn).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ChargeRetryEnabled: ").Append(ChargeRetryEnabled).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  CompletionTimeoutOn: ").Append(CompletionTimeoutOn).Append("\n");
            sb.Append("  ConfirmedBy: ").Append(ConfirmedBy).Append("\n");
            sb.Append("  ConfirmedOn: ").Append(ConfirmedOn).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerEmailAddress: ").Append(CustomerEmailAddress).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomersPresence: ").Append(CustomersPresence).Append("\n");
            sb.Append("  EndOfLife: ").Append(EndOfLife).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InternetProtocolAddress: ").Append(InternetProtocolAddress).Append("\n");
            sb.Append("  InternetProtocolAddressCountry: ").Append(InternetProtocolAddressCountry).Append("\n");
            sb.Append("  InvoiceMerchantReference: ").Append(InvoiceMerchantReference).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  PaymentConnectorConfiguration: ").Append(PaymentConnectorConfiguration).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProcessingOn: ").Append(ProcessingOn).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UserAgentHeader: ").Append(UserAgentHeader).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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
            return this.Equals(obj as TransactionPending);
        }

        /// <summary>
        /// Returns true if TransactionPending instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionPending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionPending other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AcceptHeader == other.AcceptHeader ||
                    this.AcceptHeader != null &&
                    this.AcceptHeader.Equals(other.AcceptHeader)
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
                    this.AuthorizationAmount == other.AuthorizationAmount ||
                    this.AuthorizationAmount != null &&
                    this.AuthorizationAmount.Equals(other.AuthorizationAmount)
                ) && 
                (
                    this.AuthorizedOn == other.AuthorizedOn ||
                    this.AuthorizedOn != null &&
                    this.AuthorizedOn.Equals(other.AuthorizedOn)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.ChargeRetryEnabled == other.ChargeRetryEnabled ||
                    this.ChargeRetryEnabled != null &&
                    this.ChargeRetryEnabled.Equals(other.ChargeRetryEnabled)
                ) && 
                (
                    this.CompletedOn == other.CompletedOn ||
                    this.CompletedOn != null &&
                    this.CompletedOn.Equals(other.CompletedOn)
                ) && 
                (
                    this.CompletionTimeoutOn == other.CompletionTimeoutOn ||
                    this.CompletionTimeoutOn != null &&
                    this.CompletionTimeoutOn.Equals(other.CompletionTimeoutOn)
                ) && 
                (
                    this.ConfirmedBy == other.ConfirmedBy ||
                    this.ConfirmedBy != null &&
                    this.ConfirmedBy.Equals(other.ConfirmedBy)
                ) && 
                (
                    this.ConfirmedOn == other.ConfirmedOn ||
                    this.ConfirmedOn != null &&
                    this.ConfirmedOn.Equals(other.ConfirmedOn)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
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
                    this.CustomersPresence == other.CustomersPresence ||
                    this.CustomersPresence != null &&
                    this.CustomersPresence.Equals(other.CustomersPresence)
                ) && 
                (
                    this.EndOfLife == other.EndOfLife ||
                    this.EndOfLife != null &&
                    this.EndOfLife.Equals(other.EndOfLife)
                ) && 
                (
                    this.FailedOn == other.FailedOn ||
                    this.FailedOn != null &&
                    this.FailedOn.Equals(other.FailedOn)
                ) && 
                (
                    this.FailedUrl == other.FailedUrl ||
                    this.FailedUrl != null &&
                    this.FailedUrl.Equals(other.FailedUrl)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InternetProtocolAddress == other.InternetProtocolAddress ||
                    this.InternetProtocolAddress != null &&
                    this.InternetProtocolAddress.Equals(other.InternetProtocolAddress)
                ) && 
                (
                    this.InternetProtocolAddressCountry == other.InternetProtocolAddressCountry ||
                    this.InternetProtocolAddressCountry != null &&
                    this.InternetProtocolAddressCountry.Equals(other.InternetProtocolAddressCountry)
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
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
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
                    this.PaymentConnectorConfiguration == other.PaymentConnectorConfiguration ||
                    this.PaymentConnectorConfiguration != null &&
                    this.PaymentConnectorConfiguration.Equals(other.PaymentConnectorConfiguration)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.ProcessingOn == other.ProcessingOn ||
                    this.ProcessingOn != null &&
                    this.ProcessingOn.Equals(other.ProcessingOn)
                ) && 
                (
                    this.RefundedAmount == other.RefundedAmount ||
                    this.RefundedAmount != null &&
                    this.RefundedAmount.Equals(other.RefundedAmount)
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
                    this.SpaceViewId == other.SpaceViewId ||
                    this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(other.SpaceViewId)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SuccessUrl == other.SuccessUrl ||
                    this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(other.SuccessUrl)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.UserAgentHeader == other.UserAgentHeader ||
                    this.UserAgentHeader != null &&
                    this.UserAgentHeader.Equals(other.UserAgentHeader)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                // Suitable nullity checks etc, of course :)
                if (this.AcceptHeader != null)
                    hash = hash * 59 + this.AcceptHeader.GetHashCode();
                if (this.AllowedPaymentMethodBrands != null)
                    hash = hash * 59 + this.AllowedPaymentMethodBrands.GetHashCode();
                if (this.AllowedPaymentMethodConfigurations != null)
                    hash = hash * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                if (this.AuthorizationAmount != null)
                    hash = hash * 59 + this.AuthorizationAmount.GetHashCode();
                if (this.AuthorizedOn != null)
                    hash = hash * 59 + this.AuthorizedOn.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.ChargeRetryEnabled != null)
                    hash = hash * 59 + this.ChargeRetryEnabled.GetHashCode();
                if (this.CompletedOn != null)
                    hash = hash * 59 + this.CompletedOn.GetHashCode();
                if (this.CompletionTimeoutOn != null)
                    hash = hash * 59 + this.CompletionTimeoutOn.GetHashCode();
                if (this.ConfirmedBy != null)
                    hash = hash * 59 + this.ConfirmedBy.GetHashCode();
                if (this.ConfirmedOn != null)
                    hash = hash * 59 + this.ConfirmedOn.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.CustomerEmailAddress != null)
                    hash = hash * 59 + this.CustomerEmailAddress.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.CustomersPresence != null)
                    hash = hash * 59 + this.CustomersPresence.GetHashCode();
                if (this.EndOfLife != null)
                    hash = hash * 59 + this.EndOfLife.GetHashCode();
                if (this.FailedOn != null)
                    hash = hash * 59 + this.FailedOn.GetHashCode();
                if (this.FailedUrl != null)
                    hash = hash * 59 + this.FailedUrl.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InternetProtocolAddress != null)
                    hash = hash * 59 + this.InternetProtocolAddress.GetHashCode();
                if (this.InternetProtocolAddressCountry != null)
                    hash = hash * 59 + this.InternetProtocolAddressCountry.GetHashCode();
                if (this.InvoiceMerchantReference != null)
                    hash = hash * 59 + this.InvoiceMerchantReference.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MerchantReference != null)
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                if (this.MetaData != null)
                    hash = hash * 59 + this.MetaData.GetHashCode();
                if (this.PaymentConnectorConfiguration != null)
                    hash = hash * 59 + this.PaymentConnectorConfiguration.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProcessingOn != null)
                    hash = hash * 59 + this.ProcessingOn.GetHashCode();
                if (this.RefundedAmount != null)
                    hash = hash * 59 + this.RefundedAmount.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.ShippingMethod != null)
                    hash = hash * 59 + this.ShippingMethod.GetHashCode();
                if (this.SpaceViewId != null)
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SuccessUrl != null)
                    hash = hash * 59 + this.SuccessUrl.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.UserAgentHeader != null)
                    hash = hash * 59 + this.UserAgentHeader.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
