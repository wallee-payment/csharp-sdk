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
    /// The debt collection case represents a try to collect the money from the debtor.
    /// </summary>
    [DataContract]
    public partial class DebtCollectionCase :  IEquatable<DebtCollectionCase>
    {
        /// <summary>
        /// The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.
        /// </summary>
        /// <value>The environment in which this case will be processed. There must be a debt collector configuration present which supports the chosen environment.</value>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public DebtCollectionEnvironment? Environment { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public DebtCollectionCaseState? State { get; set; }
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
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The billing address of the case identifies the debtor.
        /// </summary>
        /// <value>The billing address of the case identifies the debtor.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=true)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// The closed on date indicates when the case is closed on.
        /// </summary>
        /// <value>The closed on date indicates when the case is closed on.</value>
        [DataMember(Name="closedOn", EmitDefaultValue=true)]
        public DateTime? ClosedOn { get; private set; }

        /// <summary>
        /// The collector configuration determines how the debt collection case is processed.
        /// </summary>
        /// <value>The collector configuration determines how the debt collection case is processed.</value>
        [DataMember(Name="collectorConfiguration", EmitDefaultValue=true)]
        public DebtCollectorConfiguration CollectorConfiguration { get; private set; }

        /// <summary>
        /// The contract date is the date on which the contract with the debtor was signed on.
        /// </summary>
        /// <value>The contract date is the date on which the contract with the debtor was signed on.</value>
        [DataMember(Name="contractDate", EmitDefaultValue=true)]
        public DateTime? ContractDate { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The creator references the user which has created the debt collection case.
        /// </summary>
        /// <value>The creator references the user which has created the debt collection case.</value>
        [DataMember(Name="creator", EmitDefaultValue=true)]
        public long? Creator { get; private set; }

        /// <summary>
        /// The currency defines the billing currency of the debt collection case.
        /// </summary>
        /// <value>The currency defines the billing currency of the debt collection case.</value>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; private set; }

        /// <summary>
        /// The due date indicates the date on which the amount receivable was due. This date has to be always in the past.
        /// </summary>
        /// <value>The due date indicates the date on which the amount receivable was due. This date has to be always in the past.</value>
        [DataMember(Name="dueDate", EmitDefaultValue=true)]
        public DateTime? DueDate { get; private set; }


        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The failed on date indicates when the case is failed on.
        /// </summary>
        /// <value>The failed on date indicates when the case is failed on.</value>
        [DataMember(Name="failedOn", EmitDefaultValue=true)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name="failureReason", EmitDefaultValue=true)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=true)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// The language indicates the language to be used in the communication with the debtor.
        /// </summary>
        /// <value>The language indicates the language to be used in the communication with the debtor.</value>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; private set; }

        /// <summary>
        /// The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.
        /// </summary>
        /// <value>The line items of the debt collection case will be shown on documents sent to the debtor and the total of them makes up total amount to collect.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=true)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets NextAttemptOn
        /// </summary>
        [DataMember(Name="nextAttemptOn", EmitDefaultValue=true)]
        public DateTime? NextAttemptOn { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The processing started on date indicates the date on which the processing of the case started on.
        /// </summary>
        /// <value>The processing started on date indicates the date on which the processing of the case started on.</value>
        [DataMember(Name="processingStartedOn", EmitDefaultValue=true)]
        public DateTime? ProcessingStartedOn { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessingTimeoutOn
        /// </summary>
        [DataMember(Name="processingTimeoutOn", EmitDefaultValue=true)]
        public DateTime? ProcessingTimeoutOn { get; private set; }

        /// <summary>
        /// The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case.
        /// </summary>
        /// <value>The case reference is used in the communication with the debtor. It should be unique and it should be linkable with the source of the debt collection case.</value>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; private set; }

        /// <summary>
        /// Gets or Sets ReviewStartedOn
        /// </summary>
        [DataMember(Name="reviewStartedOn", EmitDefaultValue=true)]
        public DateTime? ReviewStartedOn { get; private set; }

        /// <summary>
        /// The reviewed on date indicates when the review of the case was conducted on.
        /// </summary>
        /// <value>The reviewed on date indicates when the review of the case was conducted on.</value>
        [DataMember(Name="reviewedOn", EmitDefaultValue=true)]
        public DateTime? ReviewedOn { get; private set; }

        /// <summary>
        /// The reviewer references the user which has reviewed the case.
        /// </summary>
        /// <value>The reviewer references the user which has reviewed the case.</value>
        [DataMember(Name="reviewer", EmitDefaultValue=true)]
        public long? Reviewer { get; private set; }

        /// <summary>
        /// The source of the debt collection case indicates the origin of the amount receivable.
        /// </summary>
        /// <value>The source of the debt collection case indicates the origin of the amount receivable.</value>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public DebtCollectionCaseSource Source { get; private set; }

        /// <summary>
        /// The source entity ID points to the object which is the origin of the debt collection case. This ID is only set when the case was triggered by an internal process.
        /// </summary>
        /// <value>The source entity ID points to the object which is the origin of the debt collection case. This ID is only set when the case was triggered by an internal process.</value>
        [DataMember(Name="sourceEntityId", EmitDefaultValue=true)]
        public long? SourceEntityId { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceViewId
        /// </summary>
        [DataMember(Name="spaceViewId", EmitDefaultValue=true)]
        public long? SpaceViewId { get; private set; }


        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=true)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebtCollectionCase {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ClosedOn: ").Append(ClosedOn).Append("\n");
            sb.Append("  CollectorConfiguration: ").Append(CollectorConfiguration).Append("\n");
            sb.Append("  ContractDate: ").Append(ContractDate).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  NextAttemptOn: ").Append(NextAttemptOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProcessingStartedOn: ").Append(ProcessingStartedOn).Append("\n");
            sb.Append("  ProcessingTimeoutOn: ").Append(ProcessingTimeoutOn).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ReviewStartedOn: ").Append(ReviewStartedOn).Append("\n");
            sb.Append("  ReviewedOn: ").Append(ReviewedOn).Append("\n");
            sb.Append("  Reviewer: ").Append(Reviewer).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SourceEntityId: ").Append(SourceEntityId).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as DebtCollectionCase);
        }

        /// <summary>
        /// Returns true if DebtCollectionCase instances are equal
        /// </summary>
        /// <param name="input">Instance of DebtCollectionCase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtCollectionCase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.ClosedOn == input.ClosedOn ||
                    (this.ClosedOn != null &&
                    this.ClosedOn.Equals(input.ClosedOn))
                ) && 
                (
                    this.CollectorConfiguration == input.CollectorConfiguration ||
                    (this.CollectorConfiguration != null &&
                    this.CollectorConfiguration.Equals(input.CollectorConfiguration))
                ) && 
                (
                    this.ContractDate == input.ContractDate ||
                    (this.ContractDate != null &&
                    this.ContractDate.Equals(input.ContractDate))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.DueDate == input.DueDate ||
                    (this.DueDate != null &&
                    this.DueDate.Equals(input.DueDate))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.FailedOn == input.FailedOn ||
                    (this.FailedOn != null &&
                    this.FailedOn.Equals(input.FailedOn))
                ) && 
                (
                    this.FailureReason == input.FailureReason ||
                    (this.FailureReason != null &&
                    this.FailureReason.Equals(input.FailureReason))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.NextAttemptOn == input.NextAttemptOn ||
                    (this.NextAttemptOn != null &&
                    this.NextAttemptOn.Equals(input.NextAttemptOn))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.ProcessingStartedOn == input.ProcessingStartedOn ||
                    (this.ProcessingStartedOn != null &&
                    this.ProcessingStartedOn.Equals(input.ProcessingStartedOn))
                ) && 
                (
                    this.ProcessingTimeoutOn == input.ProcessingTimeoutOn ||
                    (this.ProcessingTimeoutOn != null &&
                    this.ProcessingTimeoutOn.Equals(input.ProcessingTimeoutOn))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ReviewStartedOn == input.ReviewStartedOn ||
                    (this.ReviewStartedOn != null &&
                    this.ReviewStartedOn.Equals(input.ReviewStartedOn))
                ) && 
                (
                    this.ReviewedOn == input.ReviewedOn ||
                    (this.ReviewedOn != null &&
                    this.ReviewedOn.Equals(input.ReviewedOn))
                ) && 
                (
                    this.Reviewer == input.Reviewer ||
                    (this.Reviewer != null &&
                    this.Reviewer.Equals(input.Reviewer))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SourceEntityId == input.SourceEntityId ||
                    (this.SourceEntityId != null &&
                    this.SourceEntityId.Equals(input.SourceEntityId))
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
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.ClosedOn != null)
                    hashCode = hashCode * 59 + this.ClosedOn.GetHashCode();
                if (this.CollectorConfiguration != null)
                    hashCode = hashCode * 59 + this.CollectorConfiguration.GetHashCode();
                if (this.ContractDate != null)
                    hashCode = hashCode * 59 + this.ContractDate.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Creator != null)
                    hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DueDate != null)
                    hashCode = hashCode * 59 + this.DueDate.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FailedOn != null)
                    hashCode = hashCode * 59 + this.FailedOn.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.NextAttemptOn != null)
                    hashCode = hashCode * 59 + this.NextAttemptOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProcessingStartedOn != null)
                    hashCode = hashCode * 59 + this.ProcessingStartedOn.GetHashCode();
                if (this.ProcessingTimeoutOn != null)
                    hashCode = hashCode * 59 + this.ProcessingTimeoutOn.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.ReviewStartedOn != null)
                    hashCode = hashCode * 59 + this.ReviewStartedOn.GetHashCode();
                if (this.ReviewedOn != null)
                    hashCode = hashCode * 59 + this.ReviewedOn.GetHashCode();
                if (this.Reviewer != null)
                    hashCode = hashCode * 59 + this.Reviewer.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SourceEntityId != null)
                    hashCode = hashCode * 59 + this.SourceEntityId.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
