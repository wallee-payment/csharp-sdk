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
        /// The environment in which the transaction was authorized.
        /// </summary>
        /// <value>The environment in which the transaction was authorized.</value>
        [DataMember(Name="authorizationEnvironment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment? AuthorizationEnvironment { get; private set; }
        /// <summary>
        /// The behavior that controls when the transaction is completed.
        /// </summary>
        /// <value>The behavior that controls when the transaction is completed.</value>
        [DataMember(Name="completionBehavior", EmitDefaultValue=false)]
        public TransactionCompletionBehavior? CompletionBehavior { get; private set; }
        /// <summary>
        /// The customer&#39;s presence indicates whether and in what way the transaction&#39;s customer is present. Default is VIRTUAL_PRESENT.
        /// </summary>
        /// <value>The customer&#39;s presence indicates whether and in what way the transaction&#39;s customer is present. Default is VIRTUAL_PRESENT.</value>
        [DataMember(Name="customersPresence", EmitDefaultValue=false)]
        public CustomersPresence? CustomersPresence { get; private set; }
        /// <summary>
        /// The environment used when rendering resources.
        /// </summary>
        /// <value>The environment used when rendering resources.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Environment? Environment { get; private set; }
        /// <summary>
        /// The strategy for determining whether the transaction is to be processed in the test or production environment.
        /// </summary>
        /// <value>The strategy for determining whether the transaction is to be processed in the test or production environment.</value>
        [DataMember(Name="environmentSelectionStrategy", EmitDefaultValue=false)]
        public TransactionEnvironmentSelectionStrategy? EnvironmentSelectionStrategy { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public TransactionState? State { get; private set; }
        /// <summary>
        /// The tokenization mode specifies whether and how the tokenization of payment information is applied to the transaction.
        /// </summary>
        /// <value>The tokenization mode specifies whether and how the tokenization of payment information is applied to the transaction.</value>
        [DataMember(Name="tokenizationMode", EmitDefaultValue=false)]
        public TokenizationMode? TokenizationMode { get; private set; }
        /// <summary>
        /// The type of user interface the customer used to provide the payment information.
        /// </summary>
        /// <value>The type of user interface the customer used to provide the payment information.</value>
        [DataMember(Name="userInterfaceType", EmitDefaultValue=false)]
        public TransactionUserInterfaceType? UserInterfaceType { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Transaction()
        {
        }

        /// <summary>
        /// The &#39;Accept&#39; header of the customer&#39;s web browser.
        /// </summary>
        /// <value>The &#39;Accept&#39; header of the customer&#39;s web browser.</value>
        [DataMember(Name="acceptHeader", EmitDefaultValue=false)]
        public string AcceptHeader { get; private set; }

        /// <summary>
        /// The &#39;Accept Language&#39; header of the customer&#39;s web browser.
        /// </summary>
        /// <value>The &#39;Accept Language&#39; header of the customer&#39;s web browser.</value>
        [DataMember(Name="acceptLanguageHeader", EmitDefaultValue=false)]
        public string AcceptLanguageHeader { get; private set; }

        /// <summary>
        /// The payment method brands that can be used to authorize the transaction.
        /// </summary>
        /// <value>The payment method brands that can be used to authorize the transaction.</value>
        [DataMember(Name="allowedPaymentMethodBrands", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodBrands { get; private set; }

        /// <summary>
        /// The payment method configurations that can be used to authorize the transaction.
        /// </summary>
        /// <value>The payment method configurations that can be used to authorize the transaction.</value>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// The sum of all line item prices including taxes in the transaction&#39;s currency.
        /// </summary>
        /// <value>The sum of all line item prices including taxes in the transaction&#39;s currency.</value>
        [DataMember(Name="authorizationAmount", EmitDefaultValue=false)]
        public decimal? AuthorizationAmount { get; private set; }


        /// <summary>
        /// The sales channel through which the transaction was placed.
        /// </summary>
        /// <value>The sales channel through which the transaction was placed.</value>
        [DataMember(Name="authorizationSalesChannel", EmitDefaultValue=false)]
        public long? AuthorizationSalesChannel { get; private set; }

        /// <summary>
        /// The date and time when the transaction must be authorized, otherwise it will canceled.
        /// </summary>
        /// <value>The date and time when the transaction must be authorized, otherwise it will canceled.</value>
        [DataMember(Name="authorizationTimeoutOn", EmitDefaultValue=false)]
        public DateTime? AuthorizationTimeoutOn { get; private set; }

        /// <summary>
        /// The date and time when the transaction was authorized.
        /// </summary>
        /// <value>The date and time when the transaction was authorized.</value>
        [DataMember(Name="authorizedOn", EmitDefaultValue=false)]
        public DateTime? AuthorizedOn { get; private set; }

        /// <summary>
        /// Whether the transaction can be confirmed automatically or whether this must be done explicitly via the API. Default is true.
        /// </summary>
        /// <value>Whether the transaction can be confirmed automatically or whether this must be done explicitly via the API. Default is true.</value>
        [DataMember(Name="autoConfirmationEnabled", EmitDefaultValue=false)]
        public bool? AutoConfirmationEnabled { get; private set; }

        /// <summary>
        /// The address associated with the payment method for invoicing and transaction processing purposes.
        /// </summary>
        /// <value>The address associated with the payment method for invoicing and transaction processing purposes.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// Whether the customer can make further payment attempts if the first one has failed. Default is true.
        /// </summary>
        /// <value>Whether the customer can make further payment attempts if the first one has failed. Default is true.</value>
        [DataMember(Name="chargeRetryEnabled", EmitDefaultValue=false)]
        public bool? ChargeRetryEnabled { get; private set; }

        /// <summary>
        /// The total amount that was completed, in the transaction&#39;s currency.
        /// </summary>
        /// <value>The total amount that was completed, in the transaction&#39;s currency.</value>
        [DataMember(Name="completedAmount", EmitDefaultValue=false)]
        public decimal? CompletedAmount { get; private set; }

        /// <summary>
        /// The date and time when the transaction was completed.
        /// </summary>
        /// <value>The date and time when the transaction was completed.</value>
        [DataMember(Name="completedOn", EmitDefaultValue=false)]
        public DateTime? CompletedOn { get; private set; }


        /// <summary>
        /// The date and time when the transaction is completed automatically.
        /// </summary>
        /// <value>The date and time when the transaction is completed automatically.</value>
        [DataMember(Name="completionTimeoutOn", EmitDefaultValue=false)]
        public DateTime? CompletionTimeoutOn { get; private set; }

        /// <summary>
        /// The ID of the user the transaction was confirmed by.
        /// </summary>
        /// <value>The ID of the user the transaction was confirmed by.</value>
        [DataMember(Name="confirmedBy", EmitDefaultValue=false)]
        public long? ConfirmedBy { get; private set; }

        /// <summary>
        /// The date and time when the transaction was created.
        /// </summary>
        /// <value>The date and time when the transaction was created.</value>
        [DataMember(Name="confirmedOn", EmitDefaultValue=false)]
        public DateTime? ConfirmedOn { get; private set; }

        /// <summary>
        /// The ID of the user the transaction was created by.
        /// </summary>
        /// <value>The ID of the user the transaction was created by.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the transaction&#39;s currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the transaction&#39;s currency.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// The customer&#39;s email address.
        /// </summary>
        /// <value>The customer&#39;s email address.</value>
        [DataMember(Name="customerEmailAddress", EmitDefaultValue=false)]
        public string CustomerEmailAddress { get; private set; }

        /// <summary>
        /// The unique identifier of the customer in the external system.
        /// </summary>
        /// <value>The unique identifier of the customer in the external system.</value>
        [DataMember(Name="customerId", EmitDefaultValue=false)]
        public string CustomerId { get; private set; }


        /// <summary>
        /// This date and time when the decision was made as to whether the order should be shipped.
        /// </summary>
        /// <value>This date and time when the decision was made as to whether the order should be shipped.</value>
        [DataMember(Name="deliveryDecisionMadeOn", EmitDefaultValue=false)]
        public DateTime? DeliveryDecisionMadeOn { get; private set; }

        /// <summary>
        /// Allows to link the transaction to the data collected from the customer&#39;s device.
        /// </summary>
        /// <value>Allows to link the transaction to the data collected from the customer&#39;s device.</value>
        [DataMember(Name="deviceSessionIdentifier", EmitDefaultValue=false)]
        public string DeviceSessionIdentifier { get; private set; }

        /// <summary>
        /// Whether email sending is deactivated for the transaction. Default is false.
        /// </summary>
        /// <value>Whether email sending is deactivated for the transaction. Default is false.</value>
        [DataMember(Name="emailsDisabled", EmitDefaultValue=false)]
        public bool? EmailsDisabled { get; private set; }

        /// <summary>
        /// The date and time when the transaction reaches its end of live. No further actions can be carried out at this time.
        /// </summary>
        /// <value>The date and time when the transaction reaches its end of live. No further actions can be carried out at this time.</value>
        [DataMember(Name="endOfLife", EmitDefaultValue=false)]
        public DateTime? EndOfLife { get; private set; }



        /// <summary>
        /// The date and time when the transaction failed.
        /// </summary>
        /// <value>The date and time when the transaction failed.</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// The URL to redirect the customer back to after they canceled or failed to authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they canceled or failed to authenticated their payment.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; private set; }

        /// <summary>
        /// The reason for the failure of the transaction.
        /// </summary>
        /// <value>The reason for the failure of the transaction.</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// The group that the transaction belongs to.
        /// </summary>
        /// <value>The group that the transaction belongs to.</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public TransactionGroup Group { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The IP address of the customer&#39;s device.
        /// </summary>
        /// <value>The IP address of the customer&#39;s device.</value>
        [DataMember(Name="internetProtocolAddress", EmitDefaultValue=false)]
        public string InternetProtocolAddress { get; private set; }

        /// <summary>
        /// The country determined from the IP address of the customer&#39;s device.
        /// </summary>
        /// <value>The country determined from the IP address of the customer&#39;s device.</value>
        [DataMember(Name="internetProtocolAddressCountry", EmitDefaultValue=false)]
        public string InternetProtocolAddressCountry { get; private set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name="invoiceMerchantReference", EmitDefaultValue=false)]
        public string InvoiceMerchantReference { get; private set; }

        /// <summary>
        /// Whether Java is enabled on the customer&#39;s web browser.
        /// </summary>
        /// <value>Whether Java is enabled on the customer&#39;s web browser.</value>
        [DataMember(Name="javaEnabled", EmitDefaultValue=false)]
        public bool? JavaEnabled { get; private set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The line items purchased by the customer.
        /// </summary>
        /// <value>The line items purchased by the customer.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the transaction.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the transaction.</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// Allow to store additional information about the object.
        /// </summary>
        /// <value>Allow to store additional information about the object.</value>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public Dictionary<string, string> MetaData { get; private set; }

        /// <summary>
        /// The parent transaction which was (partially) replaced by this transaction.
        /// </summary>
        /// <value>The parent transaction which was (partially) replaced by this transaction.</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public long? Parent { get; private set; }

        /// <summary>
        /// The payment connector configuration that was used to authorize the transaction.
        /// </summary>
        /// <value>The payment connector configuration that was used to authorize the transaction.</value>
        [DataMember(Name="paymentConnectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The date and time when the processing of the transaction was started.
        /// </summary>
        /// <value>The date and time when the processing of the transaction was started.</value>
        [DataMember(Name="processingOn", EmitDefaultValue=false)]
        public DateTime? ProcessingOn { get; private set; }

        /// <summary>
        /// The total amount that was refunded, in the transaction&#39;s currency.
        /// </summary>
        /// <value>The total amount that was refunded, in the transaction&#39;s currency.</value>
        [DataMember(Name="refundedAmount", EmitDefaultValue=false)]
        public decimal? RefundedAmount { get; private set; }

        /// <summary>
        /// The screen color depth of the customer&#39;s web browser.
        /// </summary>
        /// <value>The screen color depth of the customer&#39;s web browser.</value>
        [DataMember(Name="screenColorDepth", EmitDefaultValue=false)]
        public string ScreenColorDepth { get; private set; }

        /// <summary>
        /// The screen height of the customer&#39;s web browser.
        /// </summary>
        /// <value>The screen height of the customer&#39;s web browser.</value>
        [DataMember(Name="screenHeight", EmitDefaultValue=false)]
        public string ScreenHeight { get; private set; }

        /// <summary>
        /// The screen width of the customer&#39;s web browser.
        /// </summary>
        /// <value>The screen width of the customer&#39;s web browser.</value>
        [DataMember(Name="screenWidth", EmitDefaultValue=false)]
        public string ScreenWidth { get; private set; }

        /// <summary>
        /// The address to where the order will be shipped.
        /// </summary>
        /// <value>The address to where the order will be shipped.</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public Address ShippingAddress { get; private set; }

        /// <summary>
        /// The name of the shipping method used to ship the products.
        /// </summary>
        /// <value>The name of the shipping method used to ship the products.</value>
        [DataMember(Name="shippingMethod", EmitDefaultValue=false)]
        public string ShippingMethod { get; private set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }


        /// <summary>
        /// The URL to redirect the customer back to after they successfully authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they successfully authenticated their payment.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; private set; }

        /// <summary>
        /// The payment terminal through which the payment was processed.
        /// </summary>
        /// <value>The payment terminal through which the payment was processed.</value>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public PaymentTerminal Terminal { get; private set; }

        /// <summary>
        /// The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.
        /// </summary>
        /// <value>The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// The payment token that should be used to charge the customer.
        /// </summary>
        /// <value>The payment token that should be used to charge the customer.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public Token Token { get; private set; }


        /// <summary>
        /// The total of all fees charged, in the transaction&#39;s currency.
        /// </summary>
        /// <value>The total of all fees charged, in the transaction&#39;s currency.</value>
        [DataMember(Name="totalAppliedFees", EmitDefaultValue=false)]
        public decimal? TotalAppliedFees { get; private set; }

        /// <summary>
        /// The total amount that was settled, in the transaction&#39;s currency.
        /// </summary>
        /// <value>The total amount that was settled, in the transaction&#39;s currency.</value>
        [DataMember(Name="totalSettledAmount", EmitDefaultValue=false)]
        public decimal? TotalSettledAmount { get; private set; }

        /// <summary>
        /// The &#39;User Agent&#39; header of the customer&#39;s web browser.
        /// </summary>
        /// <value>The &#39;User Agent&#39; header of the customer&#39;s web browser.</value>
        [DataMember(Name="userAgentHeader", EmitDefaultValue=false)]
        public string UserAgentHeader { get; private set; }

        /// <summary>
        /// The message that can be displayed to the customer explaining why the transaction failed, in the customer&#39;s language.
        /// </summary>
        /// <value>The message that can be displayed to the customer explaining why the transaction failed, in the customer&#39;s language.</value>
        [DataMember(Name="userFailureMessage", EmitDefaultValue=false)]
        public string UserFailureMessage { get; private set; }


        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// The window height of the customer&#39;s web browser.
        /// </summary>
        /// <value>The window height of the customer&#39;s web browser.</value>
        [DataMember(Name="windowHeight", EmitDefaultValue=false)]
        public string WindowHeight { get; private set; }

        /// <summary>
        /// The window width of the customer&#39;s web browser.
        /// </summary>
        /// <value>The window width of the customer&#39;s web browser.</value>
        [DataMember(Name="windowWidth", EmitDefaultValue=false)]
        public string WindowWidth { get; private set; }

        /// <summary>
        /// The number of years the transaction is kept after its authorization.
        /// </summary>
        /// <value>The number of years the transaction is kept after its authorization.</value>
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
