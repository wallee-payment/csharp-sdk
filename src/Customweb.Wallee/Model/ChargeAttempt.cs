
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
    /// ChargeAttempt model.
    /// </summary>
    [DataContract]
    public partial class ChargeAttempt :  IEquatable<ChargeAttempt>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeAttempt" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="LinkedTransaction">LinkedTransaction</param>
        /// <param name="Charge">Charge</param>
        /// <param name="ConnectorConfiguration">ConnectorConfiguration</param>
        /// <param name="CreatedOn">The created on date indicates the date on which the entity was stored into the database.</param>
        /// <param name="Environment">Environment</param>
        /// <param name="FailedOn">FailedOn</param>
        /// <param name="FailureReason">FailureReason</param>
        /// <param name="InitializingTokenVersion">InitializingTokenVersion</param>
        /// <param name="Invocation">Invocation</param>
        /// <param name="Labels">Labels</param>
        /// <param name="Language">Language</param>
        /// <param name="NextUpdateOn">NextUpdateOn</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="RedirectionUrl">RedirectionUrl</param>
        /// <param name="SpaceViewId">SpaceViewId</param>
        /// <param name="State">State</param>
        /// <param name="SucceededOn">SucceededOn</param>
        /// <param name="TimeoutOn">TimeoutOn</param>
        /// <param name="TokenVersion">TokenVersion</param>
        /// <param name="UserFailureMessage">The user failure message contains the message for the user in case the attempt failed. The message is localized into the language specified on the transaction.</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public ChargeAttempt(long? Id = default(long?), long? LinkedSpaceId = default(long?), long? LinkedTransaction = default(long?), Charge Charge = default(Charge), PaymentConnectorConfiguration ConnectorConfiguration = default(PaymentConnectorConfiguration), DateTime? CreatedOn = default(DateTime?), ChargeAttemptEnvironment Environment = default(ChargeAttemptEnvironment), DateTime? FailedOn = default(DateTime?), FailureReason FailureReason = default(FailureReason), bool? InitializingTokenVersion = default(bool?), ConnectorInvocation Invocation = default(ConnectorInvocation), List<Label> Labels = default(List<Label>), string Language = default(string), DateTime? NextUpdateOn = default(DateTime?), DateTime? PlannedPurgeDate = default(DateTime?), string RedirectionUrl = default(string), long? SpaceViewId = default(long?), ChargeAttemptState State = default(ChargeAttemptState), DateTime? SucceededOn = default(DateTime?), DateTime? TimeoutOn = default(DateTime?), TokenVersion TokenVersion = default(TokenVersion), string UserFailureMessage = default(string), int? Version = default(int?))
        {
            this.Id = Id;
            this.LinkedSpaceId = LinkedSpaceId;
            this.LinkedTransaction = LinkedTransaction;
            this.Charge = Charge;
            this.ConnectorConfiguration = ConnectorConfiguration;
            this.CreatedOn = CreatedOn;
            this.Environment = Environment;
            this.FailedOn = FailedOn;
            this.FailureReason = FailureReason;
            this.InitializingTokenVersion = InitializingTokenVersion;
            this.Invocation = Invocation;
            this.Labels = Labels;
            this.Language = Language;
            this.NextUpdateOn = NextUpdateOn;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.RedirectionUrl = RedirectionUrl;
            this.SpaceViewId = SpaceViewId;
            this.State = State;
            this.SucceededOn = SucceededOn;
            this.TimeoutOn = TimeoutOn;
            this.TokenVersion = TokenVersion;
            this.UserFailureMessage = UserFailureMessage;
            this.Version = Version;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// LinkedTransaction
        /// </summary>
        /// <value>LinkedTransaction</value>
        [DataMember(Name="linkedTransaction", EmitDefaultValue=false)]
        public long? LinkedTransaction { get; set; }

        /// <summary>
        /// Charge
        /// </summary>
        /// <value>Charge</value>
        [DataMember(Name="charge", EmitDefaultValue=false)]
        public Charge Charge { get; set; }

        /// <summary>
        /// ConnectorConfiguration
        /// </summary>
        /// <value>ConnectorConfiguration</value>
        [DataMember(Name="connectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration ConnectorConfiguration { get; set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Environment
        /// </summary>
        /// <value>Environment</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment Environment { get; set; }

        /// <summary>
        /// FailedOn
        /// </summary>
        /// <value>FailedOn</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; set; }

        /// <summary>
        /// FailureReason
        /// </summary>
        /// <value>FailureReason</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// InitializingTokenVersion
        /// </summary>
        /// <value>InitializingTokenVersion</value>
        [DataMember(Name="initializingTokenVersion", EmitDefaultValue=false)]
        public bool? InitializingTokenVersion { get; set; }

        /// <summary>
        /// Invocation
        /// </summary>
        /// <value>Invocation</value>
        [DataMember(Name="invocation", EmitDefaultValue=false)]
        public ConnectorInvocation Invocation { get; set; }

        /// <summary>
        /// Labels
        /// </summary>
        /// <value>Labels</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// NextUpdateOn
        /// </summary>
        /// <value>NextUpdateOn</value>
        [DataMember(Name="nextUpdateOn", EmitDefaultValue=false)]
        public DateTime? NextUpdateOn { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// RedirectionUrl
        /// </summary>
        /// <value>RedirectionUrl</value>
        [DataMember(Name="redirectionUrl", EmitDefaultValue=false)]
        public string RedirectionUrl { get; set; }

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
        public ChargeAttemptState State { get; set; }

        /// <summary>
        /// SucceededOn
        /// </summary>
        /// <value>SucceededOn</value>
        [DataMember(Name="succeededOn", EmitDefaultValue=false)]
        public DateTime? SucceededOn { get; set; }

        /// <summary>
        /// TimeoutOn
        /// </summary>
        /// <value>TimeoutOn</value>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; set; }

        /// <summary>
        /// TokenVersion
        /// </summary>
        /// <value>TokenVersion</value>
        [DataMember(Name="tokenVersion", EmitDefaultValue=false)]
        public TokenVersion TokenVersion { get; set; }

        /// <summary>
        /// The user failure message contains the message for the user in case the attempt failed. The message is localized into the language specified on the transaction.
        /// </summary>
        /// <value>The user failure message contains the message for the user in case the attempt failed. The message is localized into the language specified on the transaction.</value>
        [DataMember(Name="userFailureMessage", EmitDefaultValue=false)]
        public string UserFailureMessage { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeAttempt {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  ConnectorConfiguration: ").Append(ConnectorConfiguration).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
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
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  TokenVersion: ").Append(TokenVersion).Append("\n");
            sb.Append("  UserFailureMessage: ").Append(UserFailureMessage).Append("\n");
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
            return this.Equals(obj as ChargeAttempt);
        }

        /// <summary>
        /// Returns true if ChargeAttempt instances are equal
        /// </summary>
        /// <param name="other">Instance of ChargeAttempt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeAttempt other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.LinkedTransaction == other.LinkedTransaction ||
                    this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(other.LinkedTransaction)
                ) && 
                (
                    this.Charge == other.Charge ||
                    this.Charge != null &&
                    this.Charge.Equals(other.Charge)
                ) && 
                (
                    this.ConnectorConfiguration == other.ConnectorConfiguration ||
                    this.ConnectorConfiguration != null &&
                    this.ConnectorConfiguration.Equals(other.ConnectorConfiguration)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) && 
                (
                    this.FailedOn == other.FailedOn ||
                    this.FailedOn != null &&
                    this.FailedOn.Equals(other.FailedOn)
                ) && 
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
                ) && 
                (
                    this.InitializingTokenVersion == other.InitializingTokenVersion ||
                    this.InitializingTokenVersion != null &&
                    this.InitializingTokenVersion.Equals(other.InitializingTokenVersion)
                ) && 
                (
                    this.Invocation == other.Invocation ||
                    this.Invocation != null &&
                    this.Invocation.Equals(other.Invocation)
                ) && 
                (
                    this.Labels == other.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(other.Labels)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.NextUpdateOn == other.NextUpdateOn ||
                    this.NextUpdateOn != null &&
                    this.NextUpdateOn.Equals(other.NextUpdateOn)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.RedirectionUrl == other.RedirectionUrl ||
                    this.RedirectionUrl != null &&
                    this.RedirectionUrl.Equals(other.RedirectionUrl)
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
                    this.SucceededOn == other.SucceededOn ||
                    this.SucceededOn != null &&
                    this.SucceededOn.Equals(other.SucceededOn)
                ) && 
                (
                    this.TimeoutOn == other.TimeoutOn ||
                    this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(other.TimeoutOn)
                ) && 
                (
                    this.TokenVersion == other.TokenVersion ||
                    this.TokenVersion != null &&
                    this.TokenVersion.Equals(other.TokenVersion)
                ) && 
                (
                    this.UserFailureMessage == other.UserFailureMessage ||
                    this.UserFailureMessage != null &&
                    this.UserFailureMessage.Equals(other.UserFailureMessage)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hash = hash * 59 + this.LinkedTransaction.GetHashCode();
                if (this.Charge != null)
                    hash = hash * 59 + this.Charge.GetHashCode();
                if (this.ConnectorConfiguration != null)
                    hash = hash * 59 + this.ConnectorConfiguration.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.Environment != null)
                    hash = hash * 59 + this.Environment.GetHashCode();
                if (this.FailedOn != null)
                    hash = hash * 59 + this.FailedOn.GetHashCode();
                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                if (this.InitializingTokenVersion != null)
                    hash = hash * 59 + this.InitializingTokenVersion.GetHashCode();
                if (this.Invocation != null)
                    hash = hash * 59 + this.Invocation.GetHashCode();
                if (this.Labels != null)
                    hash = hash * 59 + this.Labels.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.NextUpdateOn != null)
                    hash = hash * 59 + this.NextUpdateOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.RedirectionUrl != null)
                    hash = hash * 59 + this.RedirectionUrl.GetHashCode();
                if (this.SpaceViewId != null)
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SucceededOn != null)
                    hash = hash * 59 + this.SucceededOn.GetHashCode();
                if (this.TimeoutOn != null)
                    hash = hash * 59 + this.TimeoutOn.GetHashCode();
                if (this.TokenVersion != null)
                    hash = hash * 59 + this.TokenVersion.GetHashCode();
                if (this.UserFailureMessage != null)
                    hash = hash * 59 + this.UserFailureMessage.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
