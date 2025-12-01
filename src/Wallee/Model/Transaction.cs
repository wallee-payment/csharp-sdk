/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// Transaction
    /// </summary>
    [DataContract(Name = "Transaction")]
    public partial class Transaction : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public TransactionState? State { get; set; }

        /// <summary>
        /// Gets or Sets CompletionBehavior
        /// </summary>
        [DataMember(Name = "completionBehavior", EmitDefaultValue = false)]
        public TransactionCompletionBehavior? CompletionBehavior { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationEnvironment
        /// </summary>
        [DataMember(Name = "authorizationEnvironment", EmitDefaultValue = false)]
        public ChargeAttemptEnvironment? AuthorizationEnvironment { get; set; }

        /// <summary>
        /// Gets or Sets CustomersPresence
        /// </summary>
        [DataMember(Name = "customersPresence", EmitDefaultValue = false)]
        public CustomersPresence? CustomersPresence { get; set; }

        /// <summary>
        /// Gets or Sets EnvironmentSelectionStrategy
        /// </summary>
        [DataMember(Name = "environmentSelectionStrategy", EmitDefaultValue = false)]
        public TransactionEnvironmentSelectionStrategy? EnvironmentSelectionStrategy { get; set; }

        /// <summary>
        /// Gets or Sets TokenizationMode
        /// </summary>
        [DataMember(Name = "tokenizationMode", EmitDefaultValue = false)]
        public TokenizationMode? TokenizationMode { get; set; }

        /// <summary>
        /// Gets or Sets UserInterfaceType
        /// </summary>
        [DataMember(Name = "userInterfaceType", EmitDefaultValue = false)]
        public TransactionUserInterfaceType? UserInterfaceType { get; set; }

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public ModelEnvironment? VarEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="parent">parent.</param>
        /// <param name="paymentConnectorConfiguration">paymentConnectorConfiguration.</param>
        /// <param name="state">state.</param>
        /// <param name="group">group.</param>
        /// <param name="completionBehavior">completionBehavior.</param>
        /// <param name="authorizationEnvironment">authorizationEnvironment.</param>
        /// <param name="failureReason">failureReason.</param>
        /// <param name="customersPresence">customersPresence.</param>
        /// <param name="environmentSelectionStrategy">environmentSelectionStrategy.</param>
        /// <param name="tokenizationMode">tokenizationMode.</param>
        /// <param name="userInterfaceType">userInterfaceType.</param>
        /// <param name="terminal">terminal.</param>
        /// <param name="token">token.</param>
        /// <param name="varEnvironment">varEnvironment.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="billingAddress">billingAddress.</param>
        public Transaction(Transaction parent = default, PaymentConnectorConfiguration paymentConnectorConfiguration = default, TransactionState? state = default, TransactionGroup group = default, TransactionCompletionBehavior? completionBehavior = default, ChargeAttemptEnvironment? authorizationEnvironment = default, FailureReason failureReason = default, CustomersPresence? customersPresence = default, TransactionEnvironmentSelectionStrategy? environmentSelectionStrategy = default, TokenizationMode? tokenizationMode = default, TransactionUserInterfaceType? userInterfaceType = default, PaymentTerminal terminal = default, Token token = default, ModelEnvironment? varEnvironment = default, Address shippingAddress = default, Address billingAddress = default)
        {
            this.Parent = parent;
            this.PaymentConnectorConfiguration = paymentConnectorConfiguration;
            this.State = state;
            this.Group = group;
            this.CompletionBehavior = completionBehavior;
            this.AuthorizationEnvironment = authorizationEnvironment;
            this.FailureReason = failureReason;
            this.CustomersPresence = customersPresence;
            this.EnvironmentSelectionStrategy = environmentSelectionStrategy;
            this.TokenizationMode = tokenizationMode;
            this.UserInterfaceType = userInterfaceType;
            this.Terminal = terminal;
            this.Token = token;
            this.VarEnvironment = varEnvironment;
            this.ShippingAddress = shippingAddress;
            this.BillingAddress = billingAddress;
        }

        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public Transaction Parent { get; set; }

        /// <summary>
        /// The total amount that was settled, in the transaction&#39;s currency.
        /// </summary>
        /// <value>The total amount that was settled, in the transaction&#39;s currency.</value>
        [DataMember(Name = "totalSettledAmount", EmitDefaultValue = false)]
        public decimal TotalSettledAmount { get; private set; }

        /// <summary>
        /// Returns false as TotalSettledAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalSettledAmount()
        {
            return false;
        }
        /// <summary>
        /// Allows to link the transaction to the data collected from the customer&#39;s device.
        /// </summary>
        /// <value>Allows to link the transaction to the data collected from the customer&#39;s device.</value>
        [DataMember(Name = "deviceSessionIdentifier", EmitDefaultValue = false)]
        public string DeviceSessionIdentifier { get; private set; }

        /// <summary>
        /// Returns false as DeviceSessionIdentifier should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeviceSessionIdentifier()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the processing of the transaction was started.
        /// </summary>
        /// <value>The date and time when the processing of the transaction was started.</value>
        [DataMember(Name = "processingOn", EmitDefaultValue = false)]
        public DateTime ProcessingOn { get; private set; }

        /// <summary>
        /// Returns false as ProcessingOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessingOn()
        {
            return false;
        }
        /// <summary>
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name = "invoiceMerchantReference", EmitDefaultValue = false)]
        public string InvoiceMerchantReference { get; private set; }

        /// <summary>
        /// Returns false as InvoiceMerchantReference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvoiceMerchantReference()
        {
            return false;
        }
        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; private set; }

        /// <summary>
        /// Returns false as Language should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLanguage()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the transaction was created.
        /// </summary>
        /// <value>The date and time when the transaction was created.</value>
        [DataMember(Name = "confirmedOn", EmitDefaultValue = false)]
        public DateTime ConfirmedOn { get; private set; }

        /// <summary>
        /// Returns false as ConfirmedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConfirmedOn()
        {
            return false;
        }
        /// <summary>
        /// The line items purchased by the customer.
        /// </summary>
        /// <value>The line items purchased by the customer.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// Returns false as LineItems should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLineItems()
        {
            return false;
        }
        /// <summary>
        /// The &#39;Accept Language&#39; header of the customer&#39;s web browser.
        /// </summary>
        /// <value>The &#39;Accept Language&#39; header of the customer&#39;s web browser.</value>
        [DataMember(Name = "acceptLanguageHeader", EmitDefaultValue = false)]
        public string AcceptLanguageHeader { get; private set; }

        /// <summary>
        /// Returns false as AcceptLanguageHeader should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAcceptLanguageHeader()
        {
            return false;
        }
        /// <summary>
        /// Whether Java is enabled on the customer&#39;s web browser.
        /// </summary>
        /// <value>Whether Java is enabled on the customer&#39;s web browser.</value>
        [DataMember(Name = "javaEnabled", EmitDefaultValue = true)]
        public bool JavaEnabled { get; private set; }

        /// <summary>
        /// Returns false as JavaEnabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeJavaEnabled()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the transaction was confirmed by.
        /// </summary>
        /// <value>The ID of the user the transaction was confirmed by.</value>
        [DataMember(Name = "confirmedBy", EmitDefaultValue = false)]
        public long ConfirmedBy { get; private set; }

        /// <summary>
        /// Returns false as ConfirmedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeConfirmedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentConnectorConfiguration
        /// </summary>
        [DataMember(Name = "paymentConnectorConfiguration", EmitDefaultValue = false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The window width of the customer&#39;s web browser.
        /// </summary>
        /// <value>The window width of the customer&#39;s web browser.</value>
        [DataMember(Name = "windowWidth", EmitDefaultValue = false)]
        public string WindowWidth { get; private set; }

        /// <summary>
        /// Returns false as WindowWidth should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWindowWidth()
        {
            return false;
        }
        /// <summary>
        /// The payment method configurations that can be used to authorize the transaction.
        /// </summary>
        /// <value>The payment method configurations that can be used to authorize the transaction.</value>
        [DataMember(Name = "allowedPaymentMethodConfigurations", EmitDefaultValue = false)]
        public List<long> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// Returns false as AllowedPaymentMethodConfigurations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllowedPaymentMethodConfigurations()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public TransactionGroup Group { get; set; }

        /// <summary>
        /// Whether the customer can make further payment attempts if the first one has failed. Default is true.
        /// </summary>
        /// <value>Whether the customer can make further payment attempts if the first one has failed. Default is true.</value>
        [DataMember(Name = "chargeRetryEnabled", EmitDefaultValue = true)]
        public bool ChargeRetryEnabled { get; private set; }

        /// <summary>
        /// Returns false as ChargeRetryEnabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChargeRetryEnabled()
        {
            return false;
        }
        /// <summary>
        /// The &#39;Accept&#39; header of the customer&#39;s web browser.
        /// </summary>
        /// <value>The &#39;Accept&#39; header of the customer&#39;s web browser.</value>
        [DataMember(Name = "acceptHeader", EmitDefaultValue = false)]
        public string AcceptHeader { get; private set; }

        /// <summary>
        /// Returns false as AcceptHeader should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAcceptHeader()
        {
            return false;
        }
        /// <summary>
        /// The &#39;User Agent&#39; header of the customer&#39;s web browser.
        /// </summary>
        /// <value>The &#39;User Agent&#39; header of the customer&#39;s web browser.</value>
        [DataMember(Name = "userAgentHeader", EmitDefaultValue = false)]
        public string UserAgentHeader { get; private set; }

        /// <summary>
        /// Returns false as UserAgentHeader should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUserAgentHeader()
        {
            return false;
        }
        /// <summary>
        /// The name of the shipping method used to ship the products.
        /// </summary>
        /// <value>The name of the shipping method used to ship the products.</value>
        [DataMember(Name = "shippingMethod", EmitDefaultValue = false)]
        public string ShippingMethod { get; private set; }

        /// <summary>
        /// Returns false as ShippingMethod should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeShippingMethod()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name = "plannedPurgeDate", EmitDefaultValue = false)]
        public DateTime PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedPurgeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedPurgeDate()
        {
            return false;
        }
        /// <summary>
        /// The URL to redirect the customer back to after they successfully authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they successfully authenticated their payment.</value>
        [DataMember(Name = "successUrl", EmitDefaultValue = false)]
        public string SuccessUrl { get; private set; }

        /// <summary>
        /// Returns false as SuccessUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSuccessUrl()
        {
            return false;
        }
        /// <summary>
        /// The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.
        /// </summary>
        /// <value>The customer&#39;s time zone, which affects how dates and times are formatted when communicating with the customer.</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; private set; }

        /// <summary>
        /// Returns false as VarTimeZone should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarTimeZone()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name = "spaceViewId", EmitDefaultValue = false)]
        public long SpaceViewId { get; private set; }

        /// <summary>
        /// Returns false as SpaceViewId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpaceViewId()
        {
            return false;
        }
        /// <summary>
        /// The message that can be displayed to the customer explaining why the transaction failed, in the customer&#39;s language.
        /// </summary>
        /// <value>The message that can be displayed to the customer explaining why the transaction failed, in the customer&#39;s language.</value>
        [DataMember(Name = "userFailureMessage", EmitDefaultValue = false)]
        public string UserFailureMessage { get; private set; }

        /// <summary>
        /// Returns false as UserFailureMessage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUserFailureMessage()
        {
            return false;
        }
        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
        {
            return false;
        }
        /// <summary>
        /// The country determined from the IP address of the customer&#39;s device.
        /// </summary>
        /// <value>The country determined from the IP address of the customer&#39;s device.</value>
        [DataMember(Name = "internetProtocolAddressCountry", EmitDefaultValue = false)]
        public string InternetProtocolAddressCountry { get; private set; }

        /// <summary>
        /// Returns false as InternetProtocolAddressCountry should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInternetProtocolAddressCountry()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "linkedSpaceId", EmitDefaultValue = false)]
        public long LinkedSpaceId { get; private set; }

        /// <summary>
        /// Returns false as LinkedSpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedSpaceId()
        {
            return false;
        }
        /// <summary>
        /// This date and time when the decision was made as to whether the order should be shipped.
        /// </summary>
        /// <value>This date and time when the decision was made as to whether the order should be shipped.</value>
        [DataMember(Name = "deliveryDecisionMadeOn", EmitDefaultValue = false)]
        public DateTime DeliveryDecisionMadeOn { get; private set; }

        /// <summary>
        /// Returns false as DeliveryDecisionMadeOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeliveryDecisionMadeOn()
        {
            return false;
        }
        /// <summary>
        /// Whether the transaction can be confirmed automatically or whether this must be done explicitly via the API. Default is true.
        /// </summary>
        /// <value>Whether the transaction can be confirmed automatically or whether this must be done explicitly via the API. Default is true.</value>
        [DataMember(Name = "autoConfirmationEnabled", EmitDefaultValue = true)]
        public bool AutoConfirmationEnabled { get; private set; }

        /// <summary>
        /// Returns false as AutoConfirmationEnabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAutoConfirmationEnabled()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failureReason", EmitDefaultValue = false)]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// The total of all fees charged, in the transaction&#39;s currency.
        /// </summary>
        /// <value>The total of all fees charged, in the transaction&#39;s currency.</value>
        [DataMember(Name = "totalAppliedFees", EmitDefaultValue = false)]
        public decimal TotalAppliedFees { get; private set; }

        /// <summary>
        /// Returns false as TotalAppliedFees should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalAppliedFees()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the transaction failed.
        /// </summary>
        /// <value>The date and time when the transaction failed.</value>
        [DataMember(Name = "failedOn", EmitDefaultValue = false)]
        public DateTime FailedOn { get; private set; }

        /// <summary>
        /// Returns false as FailedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailedOn()
        {
            return false;
        }
        /// <summary>
        /// The total amount that was refunded, in the transaction&#39;s currency.
        /// </summary>
        /// <value>The total amount that was refunded, in the transaction&#39;s currency.</value>
        [DataMember(Name = "refundedAmount", EmitDefaultValue = false)]
        public decimal RefundedAmount { get; private set; }

        /// <summary>
        /// Returns false as RefundedAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRefundedAmount()
        {
            return false;
        }
        /// <summary>
        /// The sum of all line item prices including taxes in the transaction&#39;s currency.
        /// </summary>
        /// <value>The sum of all line item prices including taxes in the transaction&#39;s currency.</value>
        [DataMember(Name = "authorizationAmount", EmitDefaultValue = false)]
        public decimal AuthorizationAmount { get; private set; }

        /// <summary>
        /// Returns false as AuthorizationAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthorizationAmount()
        {
            return false;
        }
        /// <summary>
        /// The screen width of the customer&#39;s web browser.
        /// </summary>
        /// <value>The screen width of the customer&#39;s web browser.</value>
        [DataMember(Name = "screenWidth", EmitDefaultValue = false)]
        public string ScreenWidth { get; private set; }

        /// <summary>
        /// Returns false as ScreenWidth should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScreenWidth()
        {
            return false;
        }
        /// <summary>
        /// The customer&#39;s email address.
        /// </summary>
        /// <value>The customer&#39;s email address.</value>
        [DataMember(Name = "customerEmailAddress", EmitDefaultValue = false)]
        public string CustomerEmailAddress { get; private set; }

        /// <summary>
        /// Returns false as CustomerEmailAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomerEmailAddress()
        {
            return false;
        }
        /// <summary>
        /// The window height of the customer&#39;s web browser.
        /// </summary>
        /// <value>The window height of the customer&#39;s web browser.</value>
        [DataMember(Name = "windowHeight", EmitDefaultValue = false)]
        public string WindowHeight { get; private set; }

        /// <summary>
        /// Returns false as WindowHeight should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWindowHeight()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the transaction must be authorized, otherwise it will canceled.
        /// </summary>
        /// <value>The date and time when the transaction must be authorized, otherwise it will canceled.</value>
        [DataMember(Name = "authorizationTimeoutOn", EmitDefaultValue = false)]
        public DateTime AuthorizationTimeoutOn { get; private set; }

        /// <summary>
        /// Returns false as AuthorizationTimeoutOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthorizationTimeoutOn()
        {
            return false;
        }
        /// <summary>
        /// The payment method brands that can be used to authorize the transaction.
        /// </summary>
        /// <value>The payment method brands that can be used to authorize the transaction.</value>
        [DataMember(Name = "allowedPaymentMethodBrands", EmitDefaultValue = false)]
        public List<long> AllowedPaymentMethodBrands { get; private set; }

        /// <summary>
        /// Returns false as AllowedPaymentMethodBrands should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllowedPaymentMethodBrands()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Returns false as CreatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedOn()
        {
            return false;
        }
        /// <summary>
        /// Allow to store additional information about the object.
        /// </summary>
        /// <value>Allow to store additional information about the object.</value>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        public Dictionary<string, string> MetaData { get; private set; }

        /// <summary>
        /// Returns false as MetaData should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetaData()
        {
            return false;
        }
        /// <summary>
        /// Whether email sending is deactivated for the transaction. Default is false.
        /// </summary>
        /// <value>Whether email sending is deactivated for the transaction. Default is false.</value>
        [DataMember(Name = "emailsDisabled", EmitDefaultValue = true)]
        public bool EmailsDisabled { get; private set; }

        /// <summary>
        /// Returns false as EmailsDisabled should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEmailsDisabled()
        {
            return false;
        }
        /// <summary>
        /// The unique identifier of the customer in the external system.
        /// </summary>
        /// <value>The unique identifier of the customer in the external system.</value>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public string CustomerId { get; private set; }

        /// <summary>
        /// Returns false as CustomerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCustomerId()
        {
            return false;
        }
        /// <summary>
        /// The three-letter code (ISO 4217 format) of the transaction&#39;s currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the transaction&#39;s currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; private set; }

        /// <summary>
        /// Returns false as Currency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrency()
        {
            return false;
        }
        /// <summary>
        /// The merchant&#39;s reference used to identify the transaction.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the transaction.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// Returns false as MerchantReference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMerchantReference()
        {
            return false;
        }
        /// <summary>
        /// The sales channel through which the transaction was placed.
        /// </summary>
        /// <value>The sales channel through which the transaction was placed.</value>
        [DataMember(Name = "authorizationSalesChannel", EmitDefaultValue = false)]
        public long AuthorizationSalesChannel { get; private set; }

        /// <summary>
        /// Returns false as AuthorizationSalesChannel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthorizationSalesChannel()
        {
            return false;
        }
        /// <summary>
        /// The number of years the transaction is kept after its authorization.
        /// </summary>
        /// <value>The number of years the transaction is kept after its authorization.</value>
        [DataMember(Name = "yearsToKeep", EmitDefaultValue = false)]
        public int YearsToKeep { get; private set; }

        /// <summary>
        /// Returns false as YearsToKeep should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeYearsToKeep()
        {
            return false;
        }
        /// <summary>
        /// The total amount that was completed, in the transaction&#39;s currency.
        /// </summary>
        /// <value>The total amount that was completed, in the transaction&#39;s currency.</value>
        [DataMember(Name = "completedAmount", EmitDefaultValue = false)]
        public decimal CompletedAmount { get; private set; }

        /// <summary>
        /// Returns false as CompletedAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompletedAmount()
        {
            return false;
        }
        /// <summary>
        /// The screen height of the customer&#39;s web browser.
        /// </summary>
        /// <value>The screen height of the customer&#39;s web browser.</value>
        [DataMember(Name = "screenHeight", EmitDefaultValue = false)]
        public string ScreenHeight { get; private set; }

        /// <summary>
        /// Returns false as ScreenHeight should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScreenHeight()
        {
            return false;
        }
        /// <summary>
        /// The IP address of the customer&#39;s device.
        /// </summary>
        /// <value>The IP address of the customer&#39;s device.</value>
        [DataMember(Name = "internetProtocolAddress", EmitDefaultValue = false)]
        public string InternetProtocolAddress { get; private set; }

        /// <summary>
        /// Returns false as InternetProtocolAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInternetProtocolAddress()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Terminal
        /// </summary>
        [DataMember(Name = "terminal", EmitDefaultValue = false)]
        public PaymentTerminal Terminal { get; set; }

        /// <summary>
        /// The date and time when the transaction reaches its end of live. No further actions can be carried out at this time.
        /// </summary>
        /// <value>The date and time when the transaction reaches its end of live. No further actions can be carried out at this time.</value>
        [DataMember(Name = "endOfLife", EmitDefaultValue = false)]
        public DateTime EndOfLife { get; private set; }

        /// <summary>
        /// Returns false as EndOfLife should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEndOfLife()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public Token Token { get; set; }

        /// <summary>
        /// The screen color depth of the customer&#39;s web browser.
        /// </summary>
        /// <value>The screen color depth of the customer&#39;s web browser.</value>
        [DataMember(Name = "screenColorDepth", EmitDefaultValue = false)]
        public string ScreenColorDepth { get; private set; }

        /// <summary>
        /// Returns false as ScreenColorDepth should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeScreenColorDepth()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the transaction was created by.
        /// </summary>
        /// <value>The ID of the user the transaction was created by.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public long CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the transaction was completed.
        /// </summary>
        /// <value>The date and time when the transaction was completed.</value>
        [DataMember(Name = "completedOn", EmitDefaultValue = false)]
        public DateTime CompletedOn { get; private set; }

        /// <summary>
        /// Returns false as CompletedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompletedOn()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the transaction is completed automatically.
        /// </summary>
        /// <value>The date and time when the transaction is completed automatically.</value>
        [DataMember(Name = "completionTimeoutOn", EmitDefaultValue = false)]
        public DateTime CompletionTimeoutOn { get; private set; }

        /// <summary>
        /// Returns false as CompletionTimeoutOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompletionTimeoutOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// The date and time when the transaction was authorized.
        /// </summary>
        /// <value>The date and time when the transaction was authorized.</value>
        [DataMember(Name = "authorizedOn", EmitDefaultValue = false)]
        public DateTime AuthorizedOn { get; private set; }

        /// <summary>
        /// Returns false as AuthorizedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthorizedOn()
        {
            return false;
        }
        /// <summary>
        /// The URL to redirect the customer back to after they canceled or failed to authenticated their payment.
        /// </summary>
        /// <value>The URL to redirect the customer back to after they canceled or failed to authenticated their payment.</value>
        [DataMember(Name = "failedUrl", EmitDefaultValue = false)]
        public string FailedUrl { get; private set; }

        /// <summary>
        /// Returns false as FailedUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailedUrl()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  TotalSettledAmount: ").Append(TotalSettledAmount).Append("\n");
            sb.Append("  DeviceSessionIdentifier: ").Append(DeviceSessionIdentifier).Append("\n");
            sb.Append("  ProcessingOn: ").Append(ProcessingOn).Append("\n");
            sb.Append("  InvoiceMerchantReference: ").Append(InvoiceMerchantReference).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ConfirmedOn: ").Append(ConfirmedOn).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  AcceptLanguageHeader: ").Append(AcceptLanguageHeader).Append("\n");
            sb.Append("  JavaEnabled: ").Append(JavaEnabled).Append("\n");
            sb.Append("  ConfirmedBy: ").Append(ConfirmedBy).Append("\n");
            sb.Append("  PaymentConnectorConfiguration: ").Append(PaymentConnectorConfiguration).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  WindowWidth: ").Append(WindowWidth).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  ChargeRetryEnabled: ").Append(ChargeRetryEnabled).Append("\n");
            sb.Append("  AcceptHeader: ").Append(AcceptHeader).Append("\n");
            sb.Append("  UserAgentHeader: ").Append(UserAgentHeader).Append("\n");
            sb.Append("  ShippingMethod: ").Append(ShippingMethod).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  UserFailureMessage: ").Append(UserFailureMessage).Append("\n");
            sb.Append("  CompletionBehavior: ").Append(CompletionBehavior).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  InternetProtocolAddressCountry: ").Append(InternetProtocolAddressCountry).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  DeliveryDecisionMadeOn: ").Append(DeliveryDecisionMadeOn).Append("\n");
            sb.Append("  AuthorizationEnvironment: ").Append(AuthorizationEnvironment).Append("\n");
            sb.Append("  AutoConfirmationEnabled: ").Append(AutoConfirmationEnabled).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  TotalAppliedFees: ").Append(TotalAppliedFees).Append("\n");
            sb.Append("  CustomersPresence: ").Append(CustomersPresence).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  AuthorizationAmount: ").Append(AuthorizationAmount).Append("\n");
            sb.Append("  ScreenWidth: ").Append(ScreenWidth).Append("\n");
            sb.Append("  EnvironmentSelectionStrategy: ").Append(EnvironmentSelectionStrategy).Append("\n");
            sb.Append("  CustomerEmailAddress: ").Append(CustomerEmailAddress).Append("\n");
            sb.Append("  WindowHeight: ").Append(WindowHeight).Append("\n");
            sb.Append("  TokenizationMode: ").Append(TokenizationMode).Append("\n");
            sb.Append("  AuthorizationTimeoutOn: ").Append(AuthorizationTimeoutOn).Append("\n");
            sb.Append("  AllowedPaymentMethodBrands: ").Append(AllowedPaymentMethodBrands).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  EmailsDisabled: ").Append(EmailsDisabled).Append("\n");
            sb.Append("  UserInterfaceType: ").Append(UserInterfaceType).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  AuthorizationSalesChannel: ").Append(AuthorizationSalesChannel).Append("\n");
            sb.Append("  YearsToKeep: ").Append(YearsToKeep).Append("\n");
            sb.Append("  CompletedAmount: ").Append(CompletedAmount).Append("\n");
            sb.Append("  ScreenHeight: ").Append(ScreenHeight).Append("\n");
            sb.Append("  InternetProtocolAddress: ").Append(InternetProtocolAddress).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  EndOfLife: ").Append(EndOfLife).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  ScreenColorDepth: ").Append(ScreenColorDepth).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CompletedOn: ").Append(CompletedOn).Append("\n");
            sb.Append("  CompletionTimeoutOn: ").Append(CompletionTimeoutOn).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  AuthorizedOn: ").Append(AuthorizedOn).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // DeviceSessionIdentifier (string) maxLength
            if (this.DeviceSessionIdentifier != null && this.DeviceSessionIdentifier.Length > 40)
            {
                yield return new ValidationResult("Invalid value for DeviceSessionIdentifier, length must be less than 40.", new [] { "DeviceSessionIdentifier" });
            }

            // DeviceSessionIdentifier (string) minLength
            if (this.DeviceSessionIdentifier != null && this.DeviceSessionIdentifier.Length < 10)
            {
                yield return new ValidationResult("Invalid value for DeviceSessionIdentifier, length must be greater than 10.", new [] { "DeviceSessionIdentifier" });
            }

            if (this.DeviceSessionIdentifier != null) {
                // DeviceSessionIdentifier (string) pattern
                Regex regexDeviceSessionIdentifier = new Regex(@"([a-zA-Z0-9_-])*", RegexOptions.CultureInvariant);
                if (!regexDeviceSessionIdentifier.Match(this.DeviceSessionIdentifier).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeviceSessionIdentifier, must match a pattern of " + regexDeviceSessionIdentifier, new [] { "DeviceSessionIdentifier" });
                }
            }

            // InvoiceMerchantReference (string) maxLength
            if (this.InvoiceMerchantReference != null && this.InvoiceMerchantReference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for InvoiceMerchantReference, length must be less than 100.", new [] { "InvoiceMerchantReference" });
            }

            if (this.InvoiceMerchantReference != null) {
                // InvoiceMerchantReference (string) pattern
                Regex regexInvoiceMerchantReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexInvoiceMerchantReference.Match(this.InvoiceMerchantReference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InvoiceMerchantReference, must match a pattern of " + regexInvoiceMerchantReference, new [] { "InvoiceMerchantReference" });
                }
            }

            // ShippingMethod (string) maxLength
            if (this.ShippingMethod != null && this.ShippingMethod.Length > 200)
            {
                yield return new ValidationResult("Invalid value for ShippingMethod, length must be less than 200.", new [] { "ShippingMethod" });
            }

            // SuccessUrl (string) maxLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for SuccessUrl, length must be less than 2000.", new [] { "SuccessUrl" });
            }

            // SuccessUrl (string) minLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length < 9)
            {
                yield return new ValidationResult("Invalid value for SuccessUrl, length must be greater than 9.", new [] { "SuccessUrl" });
            }

            // CustomerEmailAddress (string) maxLength
            if (this.CustomerEmailAddress != null && this.CustomerEmailAddress.Length > 254)
            {
                yield return new ValidationResult("Invalid value for CustomerEmailAddress, length must be less than 254.", new [] { "CustomerEmailAddress" });
            }

            // MerchantReference (string) maxLength
            if (this.MerchantReference != null && this.MerchantReference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for MerchantReference, length must be less than 100.", new [] { "MerchantReference" });
            }

            if (this.MerchantReference != null) {
                // MerchantReference (string) pattern
                Regex regexMerchantReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexMerchantReference.Match(this.MerchantReference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantReference, must match a pattern of " + regexMerchantReference, new [] { "MerchantReference" });
                }
            }

            // FailedUrl (string) maxLength
            if (this.FailedUrl != null && this.FailedUrl.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for FailedUrl, length must be less than 2000.", new [] { "FailedUrl" });
            }

            // FailedUrl (string) minLength
            if (this.FailedUrl != null && this.FailedUrl.Length < 9)
            {
                yield return new ValidationResult("Invalid value for FailedUrl, length must be greater than 9.", new [] { "FailedUrl" });
            }

            yield break;
        }
    }

}
