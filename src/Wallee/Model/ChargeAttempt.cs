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
    /// ChargeAttempt
    /// </summary>
    [DataContract(Name = "ChargeAttempt")]
    public partial class ChargeAttempt : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public ChargeAttemptState? State { get; set; }

        /// <summary>
        /// Gets or Sets CompletionBehavior
        /// </summary>
        [DataMember(Name = "completionBehavior", EmitDefaultValue = false)]
        public TransactionCompletionBehavior? CompletionBehavior { get; set; }

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public ChargeAttemptEnvironment? VarEnvironment { get; set; }

        /// <summary>
        /// Gets or Sets CustomersPresence
        /// </summary>
        [DataMember(Name = "customersPresence", EmitDefaultValue = false)]
        public CustomersPresence? CustomersPresence { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeAttempt" /> class.
        /// </summary>
        /// <param name="tokenVersion">tokenVersion.</param>
        /// <param name="state">state.</param>
        /// <param name="charge">charge.</param>
        /// <param name="wallet">wallet.</param>
        /// <param name="terminal">terminal.</param>
        /// <param name="completionBehavior">completionBehavior.</param>
        /// <param name="varEnvironment">varEnvironment.</param>
        /// <param name="invocation">invocation.</param>
        /// <param name="connectorConfiguration">connectorConfiguration.</param>
        /// <param name="failureReason">failureReason.</param>
        /// <param name="customersPresence">customersPresence.</param>
        public ChargeAttempt(TokenVersion tokenVersion = default(TokenVersion), ChargeAttemptState? state = default(ChargeAttemptState?), Charge charge = default(Charge), WalletType wallet = default(WalletType), PaymentTerminal terminal = default(PaymentTerminal), TransactionCompletionBehavior? completionBehavior = default(TransactionCompletionBehavior?), ChargeAttemptEnvironment? varEnvironment = default(ChargeAttemptEnvironment?), ConnectorInvocation invocation = default(ConnectorInvocation), PaymentConnectorConfiguration connectorConfiguration = default(PaymentConnectorConfiguration), FailureReason failureReason = default(FailureReason), CustomersPresence? customersPresence = default(CustomersPresence?))
        {
            this.TokenVersion = tokenVersion;
            this.State = state;
            this.Charge = charge;
            this.Wallet = wallet;
            this.Terminal = terminal;
            this.CompletionBehavior = completionBehavior;
            this.VarEnvironment = varEnvironment;
            this.Invocation = invocation;
            this.ConnectorConfiguration = connectorConfiguration;
            this.FailureReason = failureReason;
            this.CustomersPresence = customersPresence;
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
        /// The sales channel through which the charge attempt was made.
        /// </summary>
        /// <value>The sales channel through which the charge attempt was made.</value>
        [DataMember(Name = "salesChannel", EmitDefaultValue = false)]
        public long SalesChannel { get; private set; }

        /// <summary>
        /// Returns false as SalesChannel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSalesChannel()
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
        /// Whether a new token version is being initialized.
        /// </summary>
        /// <value>Whether a new token version is being initialized.</value>
        [DataMember(Name = "initializingTokenVersion", EmitDefaultValue = true)]
        public bool InitializingTokenVersion { get; private set; }

        /// <summary>
        /// Returns false as InitializingTokenVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInitializingTokenVersion()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TokenVersion
        /// </summary>
        [DataMember(Name = "tokenVersion", EmitDefaultValue = false)]
        public TokenVersion TokenVersion { get; set; }

        /// <summary>
        /// The date and time when the charge attempt succeeded.
        /// </summary>
        /// <value>The date and time when the charge attempt succeeded.</value>
        [DataMember(Name = "succeededOn", EmitDefaultValue = false)]
        public DateTime SucceededOn { get; private set; }

        /// <summary>
        /// Returns false as SucceededOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSucceededOn()
        {
            return false;
        }
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
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name = "linkedTransaction", EmitDefaultValue = false)]
        public long LinkedTransaction { get; private set; }

        /// <summary>
        /// Returns false as LinkedTransaction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedTransaction()
        {
            return false;
        }
        /// <summary>
        /// The URL to redirect the customer to after payment processing.
        /// </summary>
        /// <value>The URL to redirect the customer to after payment processing.</value>
        [DataMember(Name = "redirectionUrl", EmitDefaultValue = false)]
        public string RedirectionUrl { get; private set; }

        /// <summary>
        /// Returns false as RedirectionUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRedirectionUrl()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Charge
        /// </summary>
        [DataMember(Name = "charge", EmitDefaultValue = false)]
        public Charge Charge { get; set; }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name = "wallet", EmitDefaultValue = false)]
        public WalletType Wallet { get; set; }

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
        /// The time zone that this object is associated with.
        /// </summary>
        /// <value>The time zone that this object is associated with.</value>
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
        /// Gets or Sets Terminal
        /// </summary>
        [DataMember(Name = "terminal", EmitDefaultValue = false)]
        public PaymentTerminal Terminal { get; set; }

        /// <summary>
        /// The message that can be displayed to the customer explaining why the charge attempt failed, in the customer&#39;s language.
        /// </summary>
        /// <value>The message that can be displayed to the customer explaining why the charge attempt failed, in the customer&#39;s language.</value>
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
        /// The labels providing additional information about the object.
        /// </summary>
        /// <value>The labels providing additional information about the object.</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// Returns false as Labels should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLabels()
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
        /// The date and time when the object will expire.
        /// </summary>
        /// <value>The date and time when the object will expire.</value>
        [DataMember(Name = "timeoutOn", EmitDefaultValue = false)]
        public DateTime TimeoutOn { get; private set; }

        /// <summary>
        /// Returns false as TimeoutOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTimeoutOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Invocation
        /// </summary>
        [DataMember(Name = "invocation", EmitDefaultValue = false)]
        public ConnectorInvocation Invocation { get; set; }

        /// <summary>
        /// Gets or Sets ConnectorConfiguration
        /// </summary>
        [DataMember(Name = "connectorConfiguration", EmitDefaultValue = false)]
        public PaymentConnectorConfiguration ConnectorConfiguration { get; set; }

        /// <summary>
        /// The date and time when the next update of the object&#39;s state is planned.
        /// </summary>
        /// <value>The date and time when the next update of the object&#39;s state is planned.</value>
        [DataMember(Name = "nextUpdateOn", EmitDefaultValue = false)]
        public DateTime NextUpdateOn { get; private set; }

        /// <summary>
        /// Returns false as NextUpdateOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNextUpdateOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failureReason", EmitDefaultValue = false)]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// The date and time when the charge attempt failed.
        /// </summary>
        /// <value>The date and time when the charge attempt failed.</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeAttempt {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SalesChannel: ").Append(SalesChannel).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  InitializingTokenVersion: ").Append(InitializingTokenVersion).Append("\n");
            sb.Append("  TokenVersion: ").Append(TokenVersion).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  RedirectionUrl: ").Append(RedirectionUrl).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  UserFailureMessage: ").Append(UserFailureMessage).Append("\n");
            sb.Append("  CompletionBehavior: ").Append(CompletionBehavior).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  Invocation: ").Append(Invocation).Append("\n");
            sb.Append("  ConnectorConfiguration: ").Append(ConnectorConfiguration).Append("\n");
            sb.Append("  NextUpdateOn: ").Append(NextUpdateOn).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  CustomersPresence: ").Append(CustomersPresence).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
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
            // UserFailureMessage (string) maxLength
            if (this.UserFailureMessage != null && this.UserFailureMessage.Length > 2000)
            {
                yield return new ValidationResult("Invalid value for UserFailureMessage, length must be less than 2000.", new [] { "UserFailureMessage" });
            }

            yield break;
        }
    }

}
