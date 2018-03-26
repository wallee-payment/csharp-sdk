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
    /// The debt collection case represents a try to collect the money from the debtor.
    /// </summary>
    [DataContract]
    public partial class DebtCollectionCase :  IEquatable<DebtCollectionCase>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DebtCollectionCase()
        {
        }

        /// <summary>
        /// The amount is the total amount of the not paid items. The amount cannot be change once the case is reviewed.
        /// </summary>
        /// <value>The amount is the total amount of the not paid items. The amount cannot be change once the case is reviewed.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The billing address of the case identifies the debtor.
        /// </summary>
        /// <value>The billing address of the case identifies the debtor.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// The closed on date indicates when the case is closed on.
        /// </summary>
        /// <value>The closed on date indicates when the case is closed on.</value>
        [DataMember(Name="closedOn", EmitDefaultValue=false)]
        public DateTime? ClosedOn { get; private set; }

        /// <summary>
        /// The collector configuration determines how the debt collection case is processed.
        /// </summary>
        /// <value>The collector configuration determines how the debt collection case is processed.</value>
        [DataMember(Name="collectorConfiguration", EmitDefaultValue=false)]
        public DebtCollectorConfiguration CollectorConfiguration { get; private set; }

        /// <summary>
        /// The contract date is the date on which the contract with the debtor was signed on.
        /// </summary>
        /// <value>The contract date is the date on which the contract with the debtor was signed on.</value>
        [DataMember(Name="contractDate", EmitDefaultValue=false)]
        public DateTime? ContractDate { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The creator references the user which has created the debt collection case.
        /// </summary>
        /// <value>The creator references the user which has created the debt collection case.</value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public long? Creator { get; private set; }

        /// <summary>
        /// The currency defines the billing currency of the debt collection case.
        /// </summary>
        /// <value>The currency defines the billing currency of the debt collection case.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// The due date indicates the date on which the amount receivable was due. This date has to be always in the past.
        /// </summary>
        /// <value>The due date indicates the date on which the amount receivable was due. This date has to be always in the past.</value>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; private set; }

        /// <summary>
        /// The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.
        /// </summary>
        /// <value>The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public DebtCollectionEnvironment? Environment { get; private set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The failed on date indicates when the case is failed on.
        /// </summary>
        /// <value>The failed on date indicates when the case is failed on.</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// FailureReason
        /// </summary>
        /// <value>FailureReason</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Labels
        /// </summary>
        /// <value>Labels</value>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// The language indicates the language to be used in the communication with the debtor.
        /// </summary>
        /// <value>The language indicates the language to be used in the communication with the debtor.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.
        /// </summary>
        /// <value>The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// NextAttemptOn
        /// </summary>
        /// <value>NextAttemptOn</value>
        [DataMember(Name="nextAttemptOn", EmitDefaultValue=false)]
        public DateTime? NextAttemptOn { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The processing started on date indicates the date on which the processing of the case started on.
        /// </summary>
        /// <value>The processing started on date indicates the date on which the processing of the case started on.</value>
        [DataMember(Name="processingStartedOn", EmitDefaultValue=false)]
        public DateTime? ProcessingStartedOn { get; private set; }

        /// <summary>
        /// ProcessingTimeoutOn
        /// </summary>
        /// <value>ProcessingTimeoutOn</value>
        [DataMember(Name="processingTimeoutOn", EmitDefaultValue=false)]
        public DateTime? ProcessingTimeoutOn { get; private set; }

        /// <summary>
        /// The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case.
        /// </summary>
        /// <value>The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; private set; }

        /// <summary>
        /// ReviewStartedOn
        /// </summary>
        /// <value>ReviewStartedOn</value>
        [DataMember(Name="reviewStartedOn", EmitDefaultValue=false)]
        public DateTime? ReviewStartedOn { get; private set; }

        /// <summary>
        /// The reviewed on date indicates when the review of the case was conducted on.
        /// </summary>
        /// <value>The reviewed on date indicates when the review of the case was conducted on.</value>
        [DataMember(Name="reviewedOn", EmitDefaultValue=false)]
        public DateTime? ReviewedOn { get; private set; }

        /// <summary>
        /// The reviewer references the user which has reviewed the case.
        /// </summary>
        /// <value>The reviewer references the user which has reviewed the case.</value>
        [DataMember(Name="reviewer", EmitDefaultValue=false)]
        public long? Reviewer { get; private set; }

        /// <summary>
        /// The source of the debt collection case indicates the origin of the amount receivable.
        /// </summary>
        /// <value>The source of the debt collection case indicates the origin of the amount receivable.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public DebtCollectionCaseSource Source { get; private set; }

        /// <summary>
        /// The source entity ID points to the object which is the origin of the debt collection case. This ID is only set when the case was triggered by an internal process.
        /// </summary>
        /// <value>The source entity ID points to the object which is the origin of the debt collection case. This ID is only set when the case was triggered by an internal process.</value>
        [DataMember(Name="sourceEntityId", EmitDefaultValue=false)]
        public long? SourceEntityId { get; private set; }

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
        public DebtCollectionCaseState? State { get; private set; }

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
            return this.Equals(obj as DebtCollectionCase);
        }

        /// <summary>
        /// Returns true if DebtCollectionCase instances are equal
        /// </summary>
        /// <param name="other">Instance of DebtCollectionCase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectionCase other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.ClosedOn == other.ClosedOn ||
                    this.ClosedOn != null &&
                    this.ClosedOn.Equals(other.ClosedOn)
                ) && 
                (
                    this.CollectorConfiguration == other.CollectorConfiguration ||
                    this.CollectorConfiguration != null &&
                    this.CollectorConfiguration.Equals(other.CollectorConfiguration)
                ) && 
                (
                    this.ContractDate == other.ContractDate ||
                    this.ContractDate != null &&
                    this.ContractDate.Equals(other.ContractDate)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.Creator == other.Creator ||
                    this.Creator != null &&
                    this.Creator.Equals(other.Creator)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.DueDate == other.DueDate ||
                    this.DueDate != null &&
                    this.DueDate.Equals(other.DueDate)
                ) && 
                (
                    this.Environment == other.Environment ||
                    this.Environment != null &&
                    this.Environment.Equals(other.Environment)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                    this.NextAttemptOn == other.NextAttemptOn ||
                    this.NextAttemptOn != null &&
                    this.NextAttemptOn.Equals(other.NextAttemptOn)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.ProcessingStartedOn == other.ProcessingStartedOn ||
                    this.ProcessingStartedOn != null &&
                    this.ProcessingStartedOn.Equals(other.ProcessingStartedOn)
                ) && 
                (
                    this.ProcessingTimeoutOn == other.ProcessingTimeoutOn ||
                    this.ProcessingTimeoutOn != null &&
                    this.ProcessingTimeoutOn.Equals(other.ProcessingTimeoutOn)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.ReviewStartedOn == other.ReviewStartedOn ||
                    this.ReviewStartedOn != null &&
                    this.ReviewStartedOn.Equals(other.ReviewStartedOn)
                ) && 
                (
                    this.ReviewedOn == other.ReviewedOn ||
                    this.ReviewedOn != null &&
                    this.ReviewedOn.Equals(other.ReviewedOn)
                ) && 
                (
                    this.Reviewer == other.Reviewer ||
                    this.Reviewer != null &&
                    this.Reviewer.Equals(other.Reviewer)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.SourceEntityId == other.SourceEntityId ||
                    this.SourceEntityId != null &&
                    this.SourceEntityId.Equals(other.SourceEntityId)
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
                if (this.Amount != null)
                {
                    hash = hash * 59 + this.Amount.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                }
                if (this.ClosedOn != null)
                {
                    hash = hash * 59 + this.ClosedOn.GetHashCode();
                }
                if (this.CollectorConfiguration != null)
                {
                    hash = hash * 59 + this.CollectorConfiguration.GetHashCode();
                }
                if (this.ContractDate != null)
                {
                    hash = hash * 59 + this.ContractDate.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                }
                if (this.Creator != null)
                {
                    hash = hash * 59 + this.Creator.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hash = hash * 59 + this.Currency.GetHashCode();
                }
                if (this.DueDate != null)
                {
                    hash = hash * 59 + this.DueDate.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hash = hash * 59 + this.Environment.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.FailedOn != null)
                {
                    hash = hash * 59 + this.FailedOn.GetHashCode();
                }
                if (this.FailureReason != null)
                {
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Labels != null)
                {
                    hash = hash * 59 + this.Labels.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.NextAttemptOn != null)
                {
                    hash = hash * 59 + this.NextAttemptOn.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.ProcessingStartedOn != null)
                {
                    hash = hash * 59 + this.ProcessingStartedOn.GetHashCode();
                }
                if (this.ProcessingTimeoutOn != null)
                {
                    hash = hash * 59 + this.ProcessingTimeoutOn.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hash = hash * 59 + this.Reference.GetHashCode();
                }
                if (this.ReviewStartedOn != null)
                {
                    hash = hash * 59 + this.ReviewStartedOn.GetHashCode();
                }
                if (this.ReviewedOn != null)
                {
                    hash = hash * 59 + this.ReviewedOn.GetHashCode();
                }
                if (this.Reviewer != null)
                {
                    hash = hash * 59 + this.Reviewer.GetHashCode();
                }
                if (this.Source != null)
                {
                    hash = hash * 59 + this.Source.GetHashCode();
                }
                if (this.SourceEntityId != null)
                {
                    hash = hash * 59 + this.SourceEntityId.GetHashCode();
                }
                if (this.SpaceViewId != null)
                {
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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
