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
    /// Transaction
    /// </summary>
    [DataContract]
    public partial class Transaction :  IEquatable<Transaction>
    {
        /// <summary>
        /// The environment in which this transaction was successfully authorized.
        /// </summary>
        /// <value>The environment in which this transaction was successfully authorized.</value>
        [DataMember(Name="authorizationEnvironment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment? AuthorizationEnvironment { get; set; }
        /// <summary>
        /// The completion behavior controls when the transaction is completed.
        /// </summary>
        /// <value>The completion behavior controls when the transaction is completed.</value>
        [DataMember(Name="completionBehavior", EmitDefaultValue=false)]
        public TransactionCompletionBehavior? CompletionBehavior { get; set; }
        /// <summary>
        /// The customer&#39;s presence indicates what kind of authentication method was finally used during authorization of the transaction. If no value is provided, &#39;Virtually Present&#39; is used by default.
        /// </summary>
        /// <value>The customer&#39;s presence indicates what kind of authentication method was finally used during authorization of the transaction. If no value is provided, &#39;Virtually Present&#39; is used by default.</value>
        [DataMember(Name="customersPresence", EmitDefaultValue=false)]
        public CustomersPresence? CustomersPresence { get; set; }
        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Environment? Environment { get; set; }
        /// <summary>
        /// The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.
        /// </summary>
        /// <value>The environment selection strategy determines how the environment (test or production) for processing the transaction is selected.</value>
        [DataMember(Name="environmentSelectionStrategy", EmitDefaultValue=false)]
        public TransactionEnvironmentSelectionStrategy? EnvironmentSelectionStrategy { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public TransactionState? State { get; set; }
        /// <summary>
        /// The tokenization mode controls if and how the tokenization of payment information is applied to the transaction.
        /// </summary>
        /// <value>The tokenization mode controls if and how the tokenization of payment information is applied to the transaction.</value>
        [DataMember(Name="tokenizationMode", EmitDefaultValue=false)]
        public TokenizationMode? TokenizationMode { get; set; }
        /// <summary>
        /// The user interface type defines through which user interface the transaction has been processed resp. created.
        /// </summary>
        /// <value>The user interface type defines through which user interface the transaction has been processed resp. created.</value>
        [DataMember(Name="userInterfaceType", EmitDefaultValue=false)]
        public TransactionUserInterfaceType? UserInterfaceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Transaction()
        {
        }

        /// <summary>
        /// Gets or Sets AcceptHeader
        /// </summary>
        [DataMember(Name="acceptHeader", EmitDefaultValue=false)]
        public string AcceptHeader { get; private set; }

        /// <summary>
        /// The accept language contains the header which indicates the language preferences of the buyer.
        /// </summary>
        /// <value>The accept language contains the header which indicates the language preferences of the buyer.</value>
        [DataMember(Name="acceptLanguageHeader", EmitDefaultValue=false)]
        public string AcceptLanguageHeader { get; private set; }

        /// <summary>
        /// Gets or Sets AllowedPaymentMethodBrands
        /// </summary>
        [DataMember(Name="allowedPaymentMethodBrands", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodBrands { get; private set; }

        /// <summary>
        /// Gets or Sets AllowedPaymentMethodConfigurations
        /// </summary>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// Gets or Sets AuthorizationAmount
        /// </summary>
        [DataMember(Name="authorizationAmount", EmitDefaultValue=false)]
        public decimal? AuthorizationAmount { get; private set; }


        /// <summary>
        /// The sales channel through which the transaction was placed.
        /// </summary>
        /// <value>The sales channel through which the transaction was placed.</value>
        [DataMember(Name="authorizationSalesChannel", EmitDefaultValue=false)]
        public long? AuthorizationSalesChannel { get; private set; }

        /// <summary>
        /// This is the time on which the transaction will be timed out when it is not at least authorized. The timeout time may change over time.
        /// </summary>
        /// <value>This is the time on which the transaction will be timed out when it is not at least authorized. The timeout time may change over time.</value>
        [DataMember(Name="authorizationTimeoutOn", EmitDefaultValue=false)]
        public DateTime? AuthorizationTimeoutOn { get; private set; }

        /// <summary>
        /// Gets or Sets AuthorizedOn
        /// </summary>
        [DataMember(Name="authorizedOn", EmitDefaultValue=false)]
        public DateTime? AuthorizedOn { get; private set; }

        /// <summary>
        /// When auto confirmation is enabled the transaction can be confirmed by the user and does not require an explicit confirmation through the web service API.
        /// </summary>
        /// <value>When auto confirmation is enabled the transaction can be confirmed by the user and does not require an explicit confirmation through the web service API.</value>
        [DataMember(Name="autoConfirmationEnabled", EmitDefaultValue=false)]
        public bool? AutoConfirmationEnabled { get; private set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.
        /// </summary>
        /// <value>When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.</value>
        [DataMember(Name="chargeRetryEnabled", EmitDefaultValue=false)]
        public bool? ChargeRetryEnabled { get; private set; }

        /// <summary>
        /// The completed amount is the total amount which has been captured so far.
        /// </summary>
        /// <value>The completed amount is the total amount which has been captured so far.</value>
        [DataMember(Name="completedAmount", EmitDefaultValue=false)]
        public decimal? CompletedAmount { get; private set; }

        /// <summary>
        /// Gets or Sets CompletedOn
        /// </summary>
        [DataMember(Name="completedOn", EmitDefaultValue=false)]
        public DateTime? CompletedOn { get; private set; }


        /// <summary>
        /// Gets or Sets CompletionTimeoutOn
        /// </summary>
        [DataMember(Name="completionTimeoutOn", EmitDefaultValue=false)]
        public DateTime? CompletionTimeoutOn { get; private set; }

        /// <summary>
        /// Gets or Sets ConfirmedBy
        /// </summary>
        [DataMember(Name="confirmedBy", EmitDefaultValue=false)]
        public long? ConfirmedBy { get; private set; }

        /// <summary>
        /// Gets or Sets ConfirmedOn
        /// </summary>
        [DataMember(Name="confirmedOn", EmitDefaultValue=false)]
        public DateTime? ConfirmedOn { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// The customer email address is the email address of the customer. If no email address is provided on the shipping or billing address this address is used.
        /// </summary>
        /// <value>The customer email address is the email address of the customer. If no email address is provided on the shipping or billing address this address is used.</value>
        [DataMember(Name="customerEmailAddress", EmitDefaultValue=false)]
        public string CustomerEmailAddress { get; private set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; private set; }


        /// <summary>
        /// This date indicates when the decision has been made if a transaction should be delivered or not.
        /// </summary>
        /// <value>This date indicates when the decision has been made if a transaction should be delivered or not.</value>
        [DataMember(Name="deliveryDecisionMadeOn", EmitDefaultValue=false)]
        public DateTime? DeliveryDecisionMadeOn { get; private set; }

        /// <summary>
        /// The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.
        /// </summary>
        /// <value>The device session identifier links the transaction with the session identifier provided in the URL of the device data JavaScript. This allows to link the transaction with the collected device data of the buyer.</value>
        [DataMember(Name="deviceSessionIdentifier", EmitDefaultValue=false)]
        public string DeviceSessionIdentifier { get; private set; }

        /// <summary>
        /// Flag indicating whether email sending is disabled for this particular transaction. Defaults to false.
        /// </summary>
        /// <value>Flag indicating whether email sending is disabled for this particular transaction. Defaults to false.</value>
        [DataMember(Name="emailsDisabled", EmitDefaultValue=false)]
        public bool? EmailsDisabled { get; private set; }

        /// <summary>
        /// The transaction&#39;s end of life indicates the date from which on no operation can be carried out anymore.
        /// </summary>
        /// <value>The transaction&#39;s end of life indicates the date from which on no operation can be carried out anymore.</value>
        [DataMember(Name="endOfLife", EmitDefaultValue=false)]
        public DateTime? EndOfLife { get; private set; }



        /// <summary>
        /// Gets or Sets FailedOn
        /// </summary>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; private set; }

        /// <summary>
        /// The failure reason describes why the transaction failed. This is only provided when the transaction is marked as failed.
        /// </summary>
        /// <value>The failure reason describes why the transaction failed. This is only provided when the transaction is marked as failed.</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public TransactionGroup Group { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The Internet Protocol (IP) address identifies the device of the buyer.
        /// </summary>
        /// <value>The Internet Protocol (IP) address identifies the device of the buyer.</value>
        [DataMember(Name="internetProtocolAddress", EmitDefaultValue=false)]
        public string InternetProtocolAddress { get; private set; }

        /// <summary>
        /// Gets or Sets InternetProtocolAddressCountry
        /// </summary>
        [DataMember(Name="internetProtocolAddressCountry", EmitDefaultValue=false)]
        public string InternetProtocolAddressCountry { get; private set; }

        /// <summary>
        /// Gets or Sets InvoiceMerchantReference
        /// </summary>
        [DataMember(Name="invoiceMerchantReference", EmitDefaultValue=false)]
        public string InvoiceMerchantReference { get; private set; }

        /// <summary>
        /// Gets or Sets JavaEnabled
        /// </summary>
        [DataMember(Name="javaEnabled", EmitDefaultValue=false)]
        public bool? JavaEnabled { get; private set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets MerchantReference
        /// </summary>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// Meta data allow to store additional data along the object.
        /// </summary>
        /// <value>Meta data allow to store additional data along the object.</value>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public Dictionary<string, string> MetaData { get; private set; }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public long? Parent { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentConnectorConfiguration
        /// </summary>
        [DataMember(Name="paymentConnectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessingOn
        /// </summary>
        [DataMember(Name="processingOn", EmitDefaultValue=false)]
        public DateTime? ProcessingOn { get; private set; }

        /// <summary>
        /// The refunded amount is the total amount which has been refunded so far.
        /// </summary>
        /// <value>The refunded amount is the total amount which has been refunded so far.</value>
        [DataMember(Name="refundedAmount", EmitDefaultValue=false)]
        public decimal? RefundedAmount { get; private set; }

        /// <summary>
        /// Gets or Sets ScreenColorDepth
        /// </summary>
        [DataMember(Name="screenColorDepth", EmitDefaultValue=false)]
        public string ScreenColorDepth { get; private set; }

        /// <summary>
        /// Gets or Sets ScreenHeight
        /// </summary>
        [DataMember(Name="screenHeight", EmitDefaultValue=false)]
        public string ScreenHeight { get; private set; }

        /// <summary>
        /// Gets or Sets ScreenWidth
        /// </summary>
        [DataMember(Name="screenWidth", EmitDefaultValue=false)]
        public string ScreenWidth { get; private set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public Address ShippingAddress { get; private set; }

        /// <summary>
        /// Gets or Sets ShippingMethod
        /// </summary>
        [DataMember(Name="shippingMethod", EmitDefaultValue=false)]
        public string ShippingMethod { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceViewId
        /// </summary>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }


        /// <summary>
        /// The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; private set; }

        /// <summary>
        /// The terminal on which the payment was processed.
        /// </summary>
        /// <value>The terminal on which the payment was processed.</value>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public PaymentTerminal Terminal { get; private set; }

        /// <summary>
        /// The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.
        /// </summary>
        /// <value>The time zone defines in which time zone the customer is located in. The time zone may affects how dates are formatted when interacting with the customer.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public Token Token { get; private set; }


        /// <summary>
        /// The total applied fees is the sum of all fees that have been applied so far.
        /// </summary>
        /// <value>The total applied fees is the sum of all fees that have been applied so far.</value>
        [DataMember(Name="totalAppliedFees", EmitDefaultValue=false)]
        public decimal? TotalAppliedFees { get; private set; }

        /// <summary>
        /// The total settled amount is the total amount which has been settled so far.
        /// </summary>
        /// <value>The total settled amount is the total amount which has been settled so far.</value>
        [DataMember(Name="totalSettledAmount", EmitDefaultValue=false)]
        public decimal? TotalSettledAmount { get; private set; }

        /// <summary>
        /// The user agent header provides the exact string which contains the user agent of the buyer.
        /// </summary>
        /// <value>The user agent header provides the exact string which contains the user agent of the buyer.</value>
        [DataMember(Name="userAgentHeader", EmitDefaultValue=false)]
        public string UserAgentHeader { get; private set; }

        /// <summary>
        /// The failure message describes for an end user why the transaction is failed in the language of the user. This is only provided when the transaction is marked as failed.
        /// </summary>
        /// <value>The failure message describes for an end user why the transaction is failed in the language of the user. This is only provided when the transaction is marked as failed.</value>
        [DataMember(Name="userFailureMessage", EmitDefaultValue=false)]
        public string UserFailureMessage { get; private set; }


        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Gets or Sets WindowHeight
        /// </summary>
        [DataMember(Name="windowHeight", EmitDefaultValue=false)]
        public string WindowHeight { get; private set; }

        /// <summary>
        /// Gets or Sets WindowWidth
        /// </summary>
        [DataMember(Name="windowWidth", EmitDefaultValue=false)]
        public string WindowWidth { get; private set; }

        /// <summary>
        /// The number of years the transaction will be stored after it has been authorized.
        /// </summary>
        /// <value>The number of years the transaction will be stored after it has been authorized.</value>
        [DataMember(Name="yearsToKeep", EmitDefaultValue=false)]
        public int? YearsToKeep { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  AcceptHeader: ").Append(AcceptHeader).Append("\n");
            sb.Append("  AcceptLanguageHeader: ").Append(AcceptLanguageHeader).Append("\n");
            sb.Append("  AllowedPaymentMethodBrands: ").Append(AllowedPaymentMethodBrands).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  AuthorizationAmount: ").Append(AuthorizationAmount).Append("\n");
            sb.Append("  AuthorizationEnvironment: ").Append(AuthorizationEnvironment).Append("\n");
            sb.Append("  AuthorizationSalesChannel: ").Append(AuthorizationSalesChannel).Append("\n");
            sb.Append("  AuthorizationTimeoutOn: ").Append(AuthorizationTimeoutOn).Append("\n");
            sb.Append("  AuthorizedOn: ").Append(AuthorizedOn).Append("\n");
            sb.Append("  AutoConfirmationEnabled: ").Append(AutoConfirmationEnabled).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ChargeRetryEnabled: ").Append(ChargeRetryEnabled).Append("\n");
            sb.Append("  CompletedAmount: ").Append(CompletedAmount).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  CompletionBehavior: ").Append(CompletionBehavior).Append("\n");
            sb.Append("  CompletionTimeoutOn: ").Append(CompletionTimeoutOn).Append("\n");
            sb.Append("  ConfirmedBy: ").Append(ConfirmedBy).Append("\n");
            sb.Append("  ConfirmedOn: ").Append(ConfirmedOn).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerEmailAddress: ").Append(CustomerEmailAddress).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  CustomersPresence: ").Append(CustomersPresence).Append("\n");
            sb.Append("  DeliveryDecisionMadeOn: ").Append(DeliveryDecisionMadeOn).Append("\n");
            sb.Append("  DeviceSessionIdentifier: ").Append(DeviceSessionIdentifier).Append("\n");
            sb.Append("  EmailsDisabled: ").Append(EmailsDisabled).Append("\n");
            sb.Append("  EndOfLife: ").Append(EndOfLife).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  EnvironmentSelectionStrategy: ").Append(EnvironmentSelectionStrategy).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InternetProtocolAddress: ").Append(InternetProtocolAddress).Append("\n");
            sb.Append("  InternetProtocolAddressCountry: ").Append(InternetProtocolAddressCountry).Append("\n");
            sb.Append("  InvoiceMerchantReference: ").Append(InvoiceMerchantReference).Append("\n");
            sb.Append("  JavaEnabled: ").Append(JavaEnabled).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  PaymentConnectorConfiguration: ").Append(PaymentConnectorConfiguration).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProcessingOn: ").Append(ProcessingOn).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  ScreenColorDepth: ").Append(ScreenColorDepth).Append("\n");
            sb.Append("  ScreenHeight: ").Append(ScreenHeight).Append("\n");
            sb.Append("  ScreenWidth: ").Append(ScreenWidth).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenizationMode: ").Append(TokenizationMode).Append("\n");
            sb.Append("  TotalAppliedFees: ").Append(TotalAppliedFees).Append("\n");
            sb.Append("  TotalSettledAmount: ").Append(TotalSettledAmount).Append("\n");
            sb.Append("  UserAgentHeader: ").Append(UserAgentHeader).Append("\n");
            sb.Append("  UserFailureMessage: ").Append(UserFailureMessage).Append("\n");
            sb.Append("  UserInterfaceType: ").Append(UserInterfaceType).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  WindowHeight: ").Append(WindowHeight).Append("\n");
            sb.Append("  WindowWidth: ").Append(WindowWidth).Append("\n");
            sb.Append("  YearsToKeep: ").Append(YearsToKeep).Append("\n");
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
            return this.Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AcceptHeader == input.AcceptHeader ||
                    (this.AcceptHeader != null &&
                    this.AcceptHeader.Equals(input.AcceptHeader))
                ) && 
                (
                    this.AcceptLanguageHeader == input.AcceptLanguageHeader ||
                    (this.AcceptLanguageHeader != null &&
                    this.AcceptLanguageHeader.Equals(input.AcceptLanguageHeader))
                ) && 
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
                    this.AuthorizationAmount == input.AuthorizationAmount ||
                    (this.AuthorizationAmount != null &&
                    this.AuthorizationAmount.Equals(input.AuthorizationAmount))
                ) && 
                (
                    this.AuthorizationEnvironment == input.AuthorizationEnvironment ||
                    (this.AuthorizationEnvironment != null &&
                    this.AuthorizationEnvironment.Equals(input.AuthorizationEnvironment))
                ) && 
                (
                    this.AuthorizationSalesChannel == input.AuthorizationSalesChannel ||
                    (this.AuthorizationSalesChannel != null &&
                    this.AuthorizationSalesChannel.Equals(input.AuthorizationSalesChannel))
                ) && 
                (
                    this.AuthorizationTimeoutOn == input.AuthorizationTimeoutOn ||
                    (this.AuthorizationTimeoutOn != null &&
                    this.AuthorizationTimeoutOn.Equals(input.AuthorizationTimeoutOn))
                ) && 
                (
                    this.AuthorizedOn == input.AuthorizedOn ||
                    (this.AuthorizedOn != null &&
                    this.AuthorizedOn.Equals(input.AuthorizedOn))
                ) && 
                (
                    this.AutoConfirmationEnabled == input.AutoConfirmationEnabled ||
                    (this.AutoConfirmationEnabled != null &&
                    this.AutoConfirmationEnabled.Equals(input.AutoConfirmationEnabled))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.ChargeRetryEnabled == input.ChargeRetryEnabled ||
                    (this.ChargeRetryEnabled != null &&
                    this.ChargeRetryEnabled.Equals(input.ChargeRetryEnabled))
                ) && 
                (
                    this.CompletedAmount == input.CompletedAmount ||
                    (this.CompletedAmount != null &&
                    this.CompletedAmount.Equals(input.CompletedAmount))
                ) && 
                (
                    this.CompletedOn == input.CompletedOn ||
                    (this.CompletedOn != null &&
                    this.CompletedOn.Equals(input.CompletedOn))
                ) && 
                (
                    this.CompletionBehavior == input.CompletionBehavior ||
                    (this.CompletionBehavior != null &&
                    this.CompletionBehavior.Equals(input.CompletionBehavior))
                ) && 
                (
                    this.CompletionTimeoutOn == input.CompletionTimeoutOn ||
                    (this.CompletionTimeoutOn != null &&
                    this.CompletionTimeoutOn.Equals(input.CompletionTimeoutOn))
                ) && 
                (
                    this.ConfirmedBy == input.ConfirmedBy ||
                    (this.ConfirmedBy != null &&
                    this.ConfirmedBy.Equals(input.ConfirmedBy))
                ) && 
                (
                    this.ConfirmedOn == input.ConfirmedOn ||
                    (this.ConfirmedOn != null &&
                    this.ConfirmedOn.Equals(input.ConfirmedOn))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
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
                    this.CustomersPresence == input.CustomersPresence ||
                    (this.CustomersPresence != null &&
                    this.CustomersPresence.Equals(input.CustomersPresence))
                ) && 
                (
                    this.DeliveryDecisionMadeOn == input.DeliveryDecisionMadeOn ||
                    (this.DeliveryDecisionMadeOn != null &&
                    this.DeliveryDecisionMadeOn.Equals(input.DeliveryDecisionMadeOn))
                ) && 
                (
                    this.DeviceSessionIdentifier == input.DeviceSessionIdentifier ||
                    (this.DeviceSessionIdentifier != null &&
                    this.DeviceSessionIdentifier.Equals(input.DeviceSessionIdentifier))
                ) && 
                (
                    this.EmailsDisabled == input.EmailsDisabled ||
                    (this.EmailsDisabled != null &&
                    this.EmailsDisabled.Equals(input.EmailsDisabled))
                ) && 
                (
                    this.EndOfLife == input.EndOfLife ||
                    (this.EndOfLife != null &&
                    this.EndOfLife.Equals(input.EndOfLife))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.EnvironmentSelectionStrategy == input.EnvironmentSelectionStrategy ||
                    (this.EnvironmentSelectionStrategy != null &&
                    this.EnvironmentSelectionStrategy.Equals(input.EnvironmentSelectionStrategy))
                ) && 
                (
                    this.FailedOn == input.FailedOn ||
                    (this.FailedOn != null &&
                    this.FailedOn.Equals(input.FailedOn))
                ) && 
                (
                    this.FailedUrl == input.FailedUrl ||
                    (this.FailedUrl != null &&
                    this.FailedUrl.Equals(input.FailedUrl))
                ) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InternetProtocolAddress == input.InternetProtocolAddress ||
                    (this.InternetProtocolAddress != null &&
                    this.InternetProtocolAddress.Equals(input.InternetProtocolAddress))
                ) && 
                (
                    this.InternetProtocolAddressCountry == input.InternetProtocolAddressCountry ||
                    (this.InternetProtocolAddressCountry != null &&
                    this.InternetProtocolAddressCountry.Equals(input.InternetProtocolAddressCountry))
                ) && 
                (
                    this.InvoiceMerchantReference == input.InvoiceMerchantReference ||
                    (this.InvoiceMerchantReference != null &&
                    this.InvoiceMerchantReference.Equals(input.InvoiceMerchantReference))
                ) && 
                (
                    this.JavaEnabled == input.JavaEnabled ||
                    (this.JavaEnabled != null &&
                    this.JavaEnabled.Equals(input.JavaEnabled))
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
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
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
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.PaymentConnectorConfiguration == input.PaymentConnectorConfiguration ||
                    (this.PaymentConnectorConfiguration != null &&
                    this.PaymentConnectorConfiguration.Equals(input.PaymentConnectorConfiguration))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.ProcessingOn == input.ProcessingOn ||
                    (this.ProcessingOn != null &&
                    this.ProcessingOn.Equals(input.ProcessingOn))
                ) && 
                (
                    this.RefundedAmount == input.RefundedAmount ||
                    (this.RefundedAmount != null &&
                    this.RefundedAmount.Equals(input.RefundedAmount))
                ) && 
                (
                    this.ScreenColorDepth == input.ScreenColorDepth ||
                    (this.ScreenColorDepth != null &&
                    this.ScreenColorDepth.Equals(input.ScreenColorDepth))
                ) && 
                (
                    this.ScreenHeight == input.ScreenHeight ||
                    (this.ScreenHeight != null &&
                    this.ScreenHeight.Equals(input.ScreenHeight))
                ) && 
                (
                    this.ScreenWidth == input.ScreenWidth ||
                    (this.ScreenWidth != null &&
                    this.ScreenWidth.Equals(input.ScreenWidth))
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
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
                ) && 
                (
                    this.Terminal == input.Terminal ||
                    (this.Terminal != null &&
                    this.Terminal.Equals(input.Terminal))
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
                ) && 
                (
                    this.TotalAppliedFees == input.TotalAppliedFees ||
                    (this.TotalAppliedFees != null &&
                    this.TotalAppliedFees.Equals(input.TotalAppliedFees))
                ) && 
                (
                    this.TotalSettledAmount == input.TotalSettledAmount ||
                    (this.TotalSettledAmount != null &&
                    this.TotalSettledAmount.Equals(input.TotalSettledAmount))
                ) && 
                (
                    this.UserAgentHeader == input.UserAgentHeader ||
                    (this.UserAgentHeader != null &&
                    this.UserAgentHeader.Equals(input.UserAgentHeader))
                ) && 
                (
                    this.UserFailureMessage == input.UserFailureMessage ||
                    (this.UserFailureMessage != null &&
                    this.UserFailureMessage.Equals(input.UserFailureMessage))
                ) && 
                (
                    this.UserInterfaceType == input.UserInterfaceType ||
                    (this.UserInterfaceType != null &&
                    this.UserInterfaceType.Equals(input.UserInterfaceType))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.WindowHeight == input.WindowHeight ||
                    (this.WindowHeight != null &&
                    this.WindowHeight.Equals(input.WindowHeight))
                ) && 
                (
                    this.WindowWidth == input.WindowWidth ||
                    (this.WindowWidth != null &&
                    this.WindowWidth.Equals(input.WindowWidth))
                ) && 
                (
                    this.YearsToKeep == input.YearsToKeep ||
                    (this.YearsToKeep != null &&
                    this.YearsToKeep.Equals(input.YearsToKeep))
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
                if (this.AcceptHeader != null)
                    hashCode = hashCode * 59 + this.AcceptHeader.GetHashCode();
                if (this.AcceptLanguageHeader != null)
                    hashCode = hashCode * 59 + this.AcceptLanguageHeader.GetHashCode();
                if (this.AllowedPaymentMethodBrands != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethodBrands.GetHashCode();
                if (this.AllowedPaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                if (this.AuthorizationAmount != null)
                    hashCode = hashCode * 59 + this.AuthorizationAmount.GetHashCode();
                if (this.AuthorizationEnvironment != null)
                    hashCode = hashCode * 59 + this.AuthorizationEnvironment.GetHashCode();
                if (this.AuthorizationSalesChannel != null)
                    hashCode = hashCode * 59 + this.AuthorizationSalesChannel.GetHashCode();
                if (this.AuthorizationTimeoutOn != null)
                    hashCode = hashCode * 59 + this.AuthorizationTimeoutOn.GetHashCode();
                if (this.AuthorizedOn != null)
                    hashCode = hashCode * 59 + this.AuthorizedOn.GetHashCode();
                if (this.AutoConfirmationEnabled != null)
                    hashCode = hashCode * 59 + this.AutoConfirmationEnabled.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.ChargeRetryEnabled != null)
                    hashCode = hashCode * 59 + this.ChargeRetryEnabled.GetHashCode();
                if (this.CompletedAmount != null)
                    hashCode = hashCode * 59 + this.CompletedAmount.GetHashCode();
                if (this.CompletedOn != null)
                    hashCode = hashCode * 59 + this.CompletedOn.GetHashCode();
                if (this.CompletionBehavior != null)
                    hashCode = hashCode * 59 + this.CompletionBehavior.GetHashCode();
                if (this.CompletionTimeoutOn != null)
                    hashCode = hashCode * 59 + this.CompletionTimeoutOn.GetHashCode();
                if (this.ConfirmedBy != null)
                    hashCode = hashCode * 59 + this.ConfirmedBy.GetHashCode();
                if (this.ConfirmedOn != null)
                    hashCode = hashCode * 59 + this.ConfirmedOn.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CustomerEmailAddress != null)
                    hashCode = hashCode * 59 + this.CustomerEmailAddress.GetHashCode();
                if (this.CustomerId != null)
                    hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.CustomersPresence != null)
                    hashCode = hashCode * 59 + this.CustomersPresence.GetHashCode();
                if (this.DeliveryDecisionMadeOn != null)
                    hashCode = hashCode * 59 + this.DeliveryDecisionMadeOn.GetHashCode();
                if (this.DeviceSessionIdentifier != null)
                    hashCode = hashCode * 59 + this.DeviceSessionIdentifier.GetHashCode();
                if (this.EmailsDisabled != null)
                    hashCode = hashCode * 59 + this.EmailsDisabled.GetHashCode();
                if (this.EndOfLife != null)
                    hashCode = hashCode * 59 + this.EndOfLife.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.EnvironmentSelectionStrategy != null)
                    hashCode = hashCode * 59 + this.EnvironmentSelectionStrategy.GetHashCode();
                if (this.FailedOn != null)
                    hashCode = hashCode * 59 + this.FailedOn.GetHashCode();
                if (this.FailedUrl != null)
                    hashCode = hashCode * 59 + this.FailedUrl.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InternetProtocolAddress != null)
                    hashCode = hashCode * 59 + this.InternetProtocolAddress.GetHashCode();
                if (this.InternetProtocolAddressCountry != null)
                    hashCode = hashCode * 59 + this.InternetProtocolAddressCountry.GetHashCode();
                if (this.InvoiceMerchantReference != null)
                    hashCode = hashCode * 59 + this.InvoiceMerchantReference.GetHashCode();
                if (this.JavaEnabled != null)
                    hashCode = hashCode * 59 + this.JavaEnabled.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.PaymentConnectorConfiguration != null)
                    hashCode = hashCode * 59 + this.PaymentConnectorConfiguration.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProcessingOn != null)
                    hashCode = hashCode * 59 + this.ProcessingOn.GetHashCode();
                if (this.RefundedAmount != null)
                    hashCode = hashCode * 59 + this.RefundedAmount.GetHashCode();
                if (this.ScreenColorDepth != null)
                    hashCode = hashCode * 59 + this.ScreenColorDepth.GetHashCode();
                if (this.ScreenHeight != null)
                    hashCode = hashCode * 59 + this.ScreenHeight.GetHashCode();
                if (this.ScreenWidth != null)
                    hashCode = hashCode * 59 + this.ScreenWidth.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.ShippingMethod != null)
                    hashCode = hashCode * 59 + this.ShippingMethod.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SuccessUrl != null)
                    hashCode = hashCode * 59 + this.SuccessUrl.GetHashCode();
                if (this.Terminal != null)
                    hashCode = hashCode * 59 + this.Terminal.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenizationMode != null)
                    hashCode = hashCode * 59 + this.TokenizationMode.GetHashCode();
                if (this.TotalAppliedFees != null)
                    hashCode = hashCode * 59 + this.TotalAppliedFees.GetHashCode();
                if (this.TotalSettledAmount != null)
                    hashCode = hashCode * 59 + this.TotalSettledAmount.GetHashCode();
                if (this.UserAgentHeader != null)
                    hashCode = hashCode * 59 + this.UserAgentHeader.GetHashCode();
                if (this.UserFailureMessage != null)
                    hashCode = hashCode * 59 + this.UserFailureMessage.GetHashCode();
                if (this.UserInterfaceType != null)
                    hashCode = hashCode * 59 + this.UserInterfaceType.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.WindowHeight != null)
                    hashCode = hashCode * 59 + this.WindowHeight.GetHashCode();
                if (this.WindowWidth != null)
                    hashCode = hashCode * 59 + this.WindowWidth.GetHashCode();
                if (this.YearsToKeep != null)
                    hashCode = hashCode * 59 + this.YearsToKeep.GetHashCode();
                return hashCode;
            }
        }

    }

}
