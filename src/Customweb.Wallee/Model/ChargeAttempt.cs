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
    /// Charge Attempt
    /// </summary>
    [DataContract]
    public partial class ChargeAttempt : TransactionAwareEntity,  IEquatable<ChargeAttempt>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeAttempt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ChargeAttempt()
        {
        }

        /// <summary>
        /// Charge
        /// </summary>
        /// <value>Charge</value>
        [DataMember(Name="charge", EmitDefaultValue=false)]
        public Charge Charge { get; private set; }

        /// <summary>
        /// ConnectorConfiguration
        /// </summary>
        /// <value>ConnectorConfiguration</value>
        [DataMember(Name="connectorConfiguration", EmitDefaultValue=false)]
        public PaymentConnectorConfiguration ConnectorConfiguration { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Environment
        /// </summary>
        /// <value>Environment</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment? Environment { get; private set; }

        /// <summary>
        /// FailedOn
        /// </summary>
        /// <value>FailedOn</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// FailureReason
        /// </summary>
        /// <value>FailureReason</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// InitializingTokenVersion
        /// </summary>
        /// <value>InitializingTokenVersion</value>
        [DataMember(Name="initializingTokenVersion", EmitDefaultValue=false)]
        public bool? InitializingTokenVersion { get; private set; }

        /// <summary>
        /// Invocation
        /// </summary>
        /// <value>Invocation</value>
        [DataMember(Name="invocation", EmitDefaultValue=false)]
        public ConnectorInvocation Invocation { get; private set; }

        /// <summary>
        /// Labels
        /// </summary>
        /// <value>Labels</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// NextUpdateOn
        /// </summary>
        /// <value>NextUpdateOn</value>
        [DataMember(Name="nextUpdateOn", EmitDefaultValue=false)]
        public DateTime? NextUpdateOn { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// RedirectionUrl
        /// </summary>
        /// <value>RedirectionUrl</value>
        [DataMember(Name="redirectionUrl", EmitDefaultValue=false)]
        public string RedirectionUrl { get; private set; }

        /// <summary>
        /// SpaceViewId
        /// </summary>
        /// <value>SpaceViewId</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ChargeAttemptState? State { get; private set; }

        /// <summary>
        /// SucceededOn
        /// </summary>
        /// <value>SucceededOn</value>
        [DataMember(Name="succeededOn", EmitDefaultValue=false)]
        public DateTime? SucceededOn { get; private set; }

        /// <summary>
        /// TimeoutOn
        /// </summary>
        /// <value>TimeoutOn</value>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// TokenVersion
        /// </summary>
        /// <value>TokenVersion</value>
        [DataMember(Name="tokenVersion", EmitDefaultValue=false)]
        public TokenVersion TokenVersion { get; private set; }

        /// <summary>
        /// The user failure message contains the message for the user in case the attempt failed. The message is localized into the language specified on the transaction.
        /// </summary>
        /// <value>The user failure message contains the message for the user in case the attempt failed. The message is localized into the language specified on the transaction.</value>
        [DataMember(Name="userFailureMessage", EmitDefaultValue=false)]
        public string UserFailureMessage { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

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
                ) && 
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
                if (this.Charge != null)
                {
                    hash = hash * 59 + this.Charge.GetHashCode();
                }
                if (this.ConnectorConfiguration != null)
                {
                    hash = hash * 59 + this.ConnectorConfiguration.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hash = hash * 59 + this.Environment.GetHashCode();
                }
                if (this.FailedOn != null)
                {
                    hash = hash * 59 + this.FailedOn.GetHashCode();
                }
                if (this.FailureReason != null)
                {
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                }
                if (this.InitializingTokenVersion != null)
                {
                    hash = hash * 59 + this.InitializingTokenVersion.GetHashCode();
                }
                if (this.Invocation != null)
                {
                    hash = hash * 59 + this.Invocation.GetHashCode();
                }
                if (this.Labels != null)
                {
                    hash = hash * 59 + this.Labels.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.NextUpdateOn != null)
                {
                    hash = hash * 59 + this.NextUpdateOn.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.RedirectionUrl != null)
                {
                    hash = hash * 59 + this.RedirectionUrl.GetHashCode();
                }
                if (this.SpaceViewId != null)
                {
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.SucceededOn != null)
                {
                    hash = hash * 59 + this.SucceededOn.GetHashCode();
                }
                if (this.TimeoutOn != null)
                {
                    hash = hash * 59 + this.TimeoutOn.GetHashCode();
                }
                if (this.TokenVersion != null)
                {
                    hash = hash * 59 + this.TokenVersion.GetHashCode();
                }
                if (this.UserFailureMessage != null)
                {
                    hash = hash * 59 + this.UserFailureMessage.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.LinkedTransaction != null)
                {
                    hash = hash * 59 + this.LinkedTransaction.GetHashCode();
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
