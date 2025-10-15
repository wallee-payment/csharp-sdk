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
        /// The environment in which the case is processed.
        /// </summary>
        /// <value>The environment in which the case is processed.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public DebtCollectionEnvironment? Environment { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public DebtCollectionCaseState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public DebtCollectionCase()
        {
        }

        /// <summary>
        /// The sum of all unpaid item prices in the case&#39;s currency. The amount can no longer be changed once the case has been reviewed.
        /// </summary>
        /// <value>The sum of all unpaid item prices in the case&#39;s currency. The amount can no longer be changed once the case has been reviewed.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The billing address that identifies the debtor.
        /// </summary>
        /// <value>The billing address that identifies the debtor.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// The date and time when the case was closed.
        /// </summary>
        /// <value>The date and time when the case was closed.</value>
        [DataMember(Name="closedOn", EmitDefaultValue=false)]
        public DateTime? ClosedOn { get; private set; }

        /// <summary>
        /// The configuration that the case is processed with.
        /// </summary>
        /// <value>The configuration that the case is processed with.</value>
        [DataMember(Name="collectorConfiguration", EmitDefaultValue=false)]
        public DebtCollectorConfiguration CollectorConfiguration { get; private set; }

        /// <summary>
        /// The date and time when the contract with the debtor was signed.
        /// </summary>
        /// <value>The date and time when the contract with the debtor was signed.</value>
        [DataMember(Name="contractDate", EmitDefaultValue=false)]
        public DateTime? ContractDate { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The ID of the user the case was created by.
        /// </summary>
        /// <value>The ID of the user the case was created by.</value>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public long? Creator { get; private set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the case&#39;s currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the case&#39;s currency.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// The date and time when the claim was due.
        /// </summary>
        /// <value>The date and time when the claim was due.</value>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; private set; }


        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The date and time when the case failed.
        /// </summary>
        /// <value>The date and time when the case failed.</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// The reason for the failure of the case.
        /// </summary>
        /// <value>The reason for the failure of the case.</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

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
        /// The line items that are subject of this debt collection case.
        /// </summary>
        /// <value>The line items that are subject of this debt collection case.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The date and time when the next attempt at processing the case will be made.
        /// </summary>
        /// <value>The date and time when the next attempt at processing the case will be made.</value>
        [DataMember(Name="nextAttemptOn", EmitDefaultValue=false)]
        public DateTime? NextAttemptOn { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The date and time when the processing of the case was started.
        /// </summary>
        /// <value>The date and time when the processing of the case was started.</value>
        [DataMember(Name="processingStartedOn", EmitDefaultValue=false)]
        public DateTime? ProcessingStartedOn { get; private set; }

        /// <summary>
        /// The date and time when the processing of the case times out.
        /// </summary>
        /// <value>The date and time when the processing of the case times out.</value>
        [DataMember(Name="processingTimeoutOn", EmitDefaultValue=false)]
        public DateTime? ProcessingTimeoutOn { get; private set; }

        /// <summary>
        /// A unique reference to identify the debt collection case in communication with the debtor.
        /// </summary>
        /// <value>A unique reference to identify the debt collection case in communication with the debtor.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; private set; }

        /// <summary>
        /// The date and time when the review of the case was started.
        /// </summary>
        /// <value>The date and time when the review of the case was started.</value>
        [DataMember(Name="reviewStartedOn", EmitDefaultValue=false)]
        public DateTime? ReviewStartedOn { get; private set; }

        /// <summary>
        /// The date and time when the case was reviewed.
        /// </summary>
        /// <value>The date and time when the case was reviewed.</value>
        [DataMember(Name="reviewedOn", EmitDefaultValue=false)]
        public DateTime? ReviewedOn { get; private set; }

        /// <summary>
        /// The ID of the user the case was reviewed by.
        /// </summary>
        /// <value>The ID of the user the case was reviewed by.</value>
        [DataMember(Name="reviewer", EmitDefaultValue=false)]
        public long? Reviewer { get; private set; }

        /// <summary>
        /// The source of the case stating the origin of the claim.
        /// </summary>
        /// <value>The source of the case stating the origin of the claim.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public DebtCollectionCaseSource Source { get; private set; }

        /// <summary>
        /// The ID of the object that is the source of the case. Only defined if the case was created by an internal process.
        /// </summary>
        /// <value>The ID of the object that is the source of the case. Only defined if the case was created by an internal process.</value>
        [DataMember(Name="sourceEntityId", EmitDefaultValue=false)]
        public long? SourceEntityId { get; private set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }


        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
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
                    input.Labels != null &&
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
                    input.LineItems != null &&
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
