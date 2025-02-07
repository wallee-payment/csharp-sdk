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
    /// ChargeAttempt
    /// </summary>
    [DataContract]
    public partial class ChargeAttempt : TransactionAwareEntity,  IEquatable<ChargeAttempt>
    {
        /// <summary>
        /// Gets or Sets CompletionBehavior
        /// </summary>
        [DataMember(Name="completionBehavior", EmitDefaultValue=false)]
        public TransactionCompletionBehavior? CompletionBehavior { get; private set; }
        /// <summary>
        /// The customer&#39;s presence indicates which kind of customer interaction was used during the charge attempt.
        /// </summary>
        /// <value>The customer&#39;s presence indicates which kind of customer interaction was used during the charge attempt.</value>
        [DataMember(Name="customersPresence", EmitDefaultValue=false)]
        public CustomersPresence? CustomersPresence { get; private set; }
        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment? Environment { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ChargeAttemptState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeAttempt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ChargeAttempt()
        {
        }




        /// <summary>
        /// Gets or Sets Charge
        /// </summary>
        [DataMember(Name="charge", EmitDefaultValue=false)]
        public Charge Charge { get; private set; }


        /// <summary>
        /// Gets or Sets ConnectorConfiguration
        /// </summary>
        [DataMember(Name="connectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration ConnectorConfiguration { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }



        /// <summary>
        /// Gets or Sets FailedOn
        /// </summary>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// Gets or Sets InitializingTokenVersion
        /// </summary>
        [DataMember(Name="initializingTokenVersion", EmitDefaultValue=false)]
        public bool? InitializingTokenVersion { get; private set; }

        /// <summary>
        /// Gets or Sets Invocation
        /// </summary>
        [DataMember(Name="invocation", EmitDefaultValue=false)]
        public ConnectorInvocation Invocation { get; private set; }

        /// <summary>
        /// The labels providing additional information about the object.
        /// </summary>
        /// <value>The labels providing additional information about the object.</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// Gets or Sets NextUpdateOn
        /// </summary>
        [DataMember(Name="nextUpdateOn", EmitDefaultValue=false)]
        public DateTime? NextUpdateOn { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets RedirectionUrl
        /// </summary>
        [DataMember(Name="redirectionUrl", EmitDefaultValue=false)]
        public string RedirectionUrl { get; private set; }

        /// <summary>
        /// Gets or Sets SalesChannel
        /// </summary>
        [DataMember(Name="salesChannel", EmitDefaultValue=false)]
        public long? SalesChannel { get; private set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }


        /// <summary>
        /// Gets or Sets SucceededOn
        /// </summary>
        [DataMember(Name="succeededOn", EmitDefaultValue=false)]
        public DateTime? SucceededOn { get; private set; }

        /// <summary>
        /// Gets or Sets Terminal
        /// </summary>
        [DataMember(Name="terminal", EmitDefaultValue=false)]
        public PaymentTerminal Terminal { get; private set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// Gets or Sets TimeoutOn
        /// </summary>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// Gets or Sets TokenVersion
        /// </summary>
        [DataMember(Name="tokenVersion", EmitDefaultValue=false)]
        public TokenVersion TokenVersion { get; private set; }

        /// <summary>
        /// The user failure message contains the message for the user in case the attempt failed. The message is localized into the language specified on the transaction.
        /// </summary>
        /// <value>The user failure message contains the message for the user in case the attempt failed. The message is localized into the language specified on the transaction.</value>
        [DataMember(Name="userFailureMessage", EmitDefaultValue=false)]
        public string UserFailureMessage { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Gets or Sets Wallet
        /// </summary>
        [DataMember(Name="wallet", EmitDefaultValue=false)]
        public WalletType Wallet { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeAttempt {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  CompletionBehavior: ").Append(CompletionBehavior).Append("\n");
            sb.Append("  ConnectorConfiguration: ").Append(ConnectorConfiguration).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  CustomersPresence: ").Append(CustomersPresence).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  InitializingTokenVersion: ").Append(InitializingTokenVersion).Append("\n");
            sb.Append("  Invocation: ").Append(Invocation).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  NextUpdateOn: ").Append(NextUpdateOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  RedirectionUrl: ").Append(RedirectionUrl).Append("\n");
            sb.Append("  SalesChannel: ").Append(SalesChannel).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  Terminal: ").Append(Terminal).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  TokenVersion: ").Append(TokenVersion).Append("\n");
            sb.Append("  UserFailureMessage: ").Append(UserFailureMessage).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Wallet: ").Append(Wallet).Append("\n");
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
            return this.Equals(input as ChargeAttempt);
        }

        /// <summary>
        /// Returns true if ChargeAttempt instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeAttempt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeAttempt input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && base.Equals(input) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && base.Equals(input) && 
                (
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && base.Equals(input) && 
                (
                    this.Charge == input.Charge ||
                    (this.Charge != null &&
                    this.Charge.Equals(input.Charge))
                ) && base.Equals(input) && 
                (
                    this.CompletionBehavior == input.CompletionBehavior ||
                    (this.CompletionBehavior != null &&
                    this.CompletionBehavior.Equals(input.CompletionBehavior))
                ) && base.Equals(input) && 
                (
                    this.ConnectorConfiguration == input.ConnectorConfiguration ||
                    (this.ConnectorConfiguration != null &&
                    this.ConnectorConfiguration.Equals(input.ConnectorConfiguration))
                ) && base.Equals(input) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && base.Equals(input) && 
                (
                    this.CustomersPresence == input.CustomersPresence ||
                    (this.CustomersPresence != null &&
                    this.CustomersPresence.Equals(input.CustomersPresence))
                ) && base.Equals(input) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && base.Equals(input) && 
                (
                    this.FailedOn == input.FailedOn ||
                    (this.FailedOn != null &&
                    this.FailedOn.Equals(input.FailedOn))
                ) && base.Equals(input) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && base.Equals(input) && 
                (
                    this.InitializingTokenVersion == input.InitializingTokenVersion ||
                    (this.InitializingTokenVersion != null &&
                    this.InitializingTokenVersion.Equals(input.InitializingTokenVersion))
                ) && base.Equals(input) && 
                (
                    this.Invocation == input.Invocation ||
                    (this.Invocation != null &&
                    this.Invocation.Equals(input.Invocation))
                ) && base.Equals(input) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && base.Equals(input) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && base.Equals(input) && 
                (
                    this.NextUpdateOn == input.NextUpdateOn ||
                    (this.NextUpdateOn != null &&
                    this.NextUpdateOn.Equals(input.NextUpdateOn))
                ) && base.Equals(input) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && base.Equals(input) && 
                (
                    this.RedirectionUrl == input.RedirectionUrl ||
                    (this.RedirectionUrl != null &&
                    this.RedirectionUrl.Equals(input.RedirectionUrl))
                ) && base.Equals(input) && 
                (
                    this.SalesChannel == input.SalesChannel ||
                    (this.SalesChannel != null &&
                    this.SalesChannel.Equals(input.SalesChannel))
                ) && base.Equals(input) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
                ) && base.Equals(input) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && base.Equals(input) && 
                (
                    this.SucceededOn == input.SucceededOn ||
                    (this.SucceededOn != null &&
                    this.SucceededOn.Equals(input.SucceededOn))
                ) && base.Equals(input) && 
                (
                    this.Terminal == input.Terminal ||
                    (this.Terminal != null &&
                    this.Terminal.Equals(input.Terminal))
                ) && base.Equals(input) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && base.Equals(input) && 
                (
                    this.TimeoutOn == input.TimeoutOn ||
                    (this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(input.TimeoutOn))
                ) && base.Equals(input) && 
                (
                    this.TokenVersion == input.TokenVersion ||
                    (this.TokenVersion != null &&
                    this.TokenVersion.Equals(input.TokenVersion))
                ) && base.Equals(input) && 
                (
                    this.UserFailureMessage == input.UserFailureMessage ||
                    (this.UserFailureMessage != null &&
                    this.UserFailureMessage.Equals(input.UserFailureMessage))
                ) && base.Equals(input) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && base.Equals(input) && 
                (
                    this.Wallet == input.Wallet ||
                    (this.Wallet != null &&
                    this.Wallet.Equals(input.Wallet))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.Charge != null)
                    hashCode = hashCode * 59 + this.Charge.GetHashCode();
                if (this.CompletionBehavior != null)
                    hashCode = hashCode * 59 + this.CompletionBehavior.GetHashCode();
                if (this.ConnectorConfiguration != null)
                    hashCode = hashCode * 59 + this.ConnectorConfiguration.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.CustomersPresence != null)
                    hashCode = hashCode * 59 + this.CustomersPresence.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.FailedOn != null)
                    hashCode = hashCode * 59 + this.FailedOn.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.InitializingTokenVersion != null)
                    hashCode = hashCode * 59 + this.InitializingTokenVersion.GetHashCode();
                if (this.Invocation != null)
                    hashCode = hashCode * 59 + this.Invocation.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.NextUpdateOn != null)
                    hashCode = hashCode * 59 + this.NextUpdateOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.RedirectionUrl != null)
                    hashCode = hashCode * 59 + this.RedirectionUrl.GetHashCode();
                if (this.SalesChannel != null)
                    hashCode = hashCode * 59 + this.SalesChannel.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SucceededOn != null)
                    hashCode = hashCode * 59 + this.SucceededOn.GetHashCode();
                if (this.Terminal != null)
                    hashCode = hashCode * 59 + this.Terminal.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TimeoutOn != null)
                    hashCode = hashCode * 59 + this.TimeoutOn.GetHashCode();
                if (this.TokenVersion != null)
                    hashCode = hashCode * 59 + this.TokenVersion.GetHashCode();
                if (this.UserFailureMessage != null)
                    hashCode = hashCode * 59 + this.UserFailureMessage.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Wallet != null)
                    hashCode = hashCode * 59 + this.Wallet.GetHashCode();
                return hashCode;
            }
        }

    }

}
