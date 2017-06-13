
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
    /// The subscription charge represents a single charge carried out for a particular subscription.
    /// </summary>
    [DataContract]
    public partial class SubscriptionChargeCreate :  IEquatable<SubscriptionChargeCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionChargeCreate" /> class.
        /// </summary>
        /// <param name="CreatedOn">CreatedOn</param>
        /// <param name="DiscardedBy">DiscardedBy</param>
        /// <param name="DiscardedOn">DiscardedOn</param>
        /// <param name="ExternalId">The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</param>
        /// <param name="FailedOn">FailedOn</param>
        /// <param name="FailedUrl">The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LedgerEntries">LedgerEntries</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="PlannedExecutionDate">PlannedExecutionDate</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="ProcessingType">ProcessingType</param>
        /// <param name="Reference">Reference</param>
        /// <param name="State">State</param>
        /// <param name="Subscription">The field subscription indicates the subscription to which the charge belongs to.</param>
        /// <param name="SucceedOn">SucceedOn</param>
        /// <param name="SuccessUrl">The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</param>
        /// <param name="Transaction">Transaction</param>
        /// <param name="Type">Type</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public SubscriptionChargeCreate(DateTime? CreatedOn = default(DateTime?), long? DiscardedBy = default(long?), DateTime? DiscardedOn = default(DateTime?), string ExternalId = default(string), DateTime? FailedOn = default(DateTime?), string FailedUrl = default(string), long? Id = default(long?), List<SubscriptionLedgerEntry> LedgerEntries = default(List<SubscriptionLedgerEntry>), long? LinkedSpaceId = default(long?), DateTime? PlannedExecutionDate = default(DateTime?), DateTime? PlannedPurgeDate = default(DateTime?), SubscriptionChargeProcessingType ProcessingType = default(SubscriptionChargeProcessingType), string Reference = default(string), SubscriptionChargeState State = default(SubscriptionChargeState), long? Subscription = default(long?), DateTime? SucceedOn = default(DateTime?), string SuccessUrl = default(string), Transaction Transaction = default(Transaction), SubscriptionChargeType Type = default(SubscriptionChargeType), int? Version = default(int?))
        {
            this.CreatedOn = CreatedOn;
            this.DiscardedBy = DiscardedBy;
            this.DiscardedOn = DiscardedOn;
            this.ExternalId = ExternalId;
            this.FailedOn = FailedOn;
            this.FailedUrl = FailedUrl;
            this.Id = Id;
            this.LedgerEntries = LedgerEntries;
            this.LinkedSpaceId = LinkedSpaceId;
            this.PlannedExecutionDate = PlannedExecutionDate;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.ProcessingType = ProcessingType;
            this.Reference = Reference;
            this.State = State;
            this.Subscription = Subscription;
            this.SucceedOn = SucceedOn;
            this.SuccessUrl = SuccessUrl;
            this.Transaction = Transaction;
            this.Type = Type;
            this.Version = Version;
        }

        /// <summary>
        /// CreatedOn
        /// </summary>
        /// <value>CreatedOn</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// DiscardedBy
        /// </summary>
        /// <value>DiscardedBy</value>
        [DataMember(Name="discardedBy", EmitDefaultValue=false)]
        public long? DiscardedBy { get; set; }

        /// <summary>
        /// DiscardedOn
        /// </summary>
        /// <value>DiscardedOn</value>
        [DataMember(Name="discardedOn", EmitDefaultValue=false)]
        public DateTime? DiscardedOn { get; set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// FailedOn
        /// </summary>
        /// <value>FailedOn</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; set; }

        /// <summary>
        /// The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to failed URL when the transaction could not be authorized or completed. In case no failed URL is specified a default failed page will be displayed.</value>
        [DataMember(Name="failedUrl", EmitDefaultValue=false)]
        public string FailedUrl { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// LedgerEntries
        /// </summary>
        /// <value>LedgerEntries</value>
        [DataMember(Name="ledgerEntries", EmitDefaultValue=false)]
        public List<SubscriptionLedgerEntry> LedgerEntries { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// PlannedExecutionDate
        /// </summary>
        /// <value>PlannedExecutionDate</value>
        [DataMember(Name="plannedExecutionDate", EmitDefaultValue=false)]
        public DateTime? PlannedExecutionDate { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// ProcessingType
        /// </summary>
        /// <value>ProcessingType</value>
        [DataMember(Name="processingType", EmitDefaultValue=false)]
        public SubscriptionChargeProcessingType ProcessingType { get; set; }

        /// <summary>
        /// Reference
        /// </summary>
        /// <value>Reference</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionChargeState State { get; set; }

        /// <summary>
        /// The field subscription indicates the subscription to which the charge belongs to.
        /// </summary>
        /// <value>The field subscription indicates the subscription to which the charge belongs to.</value>
        [DataMember(Name="subscription", EmitDefaultValue=false)]
        public long? Subscription { get; set; }

        /// <summary>
        /// SucceedOn
        /// </summary>
        /// <value>SucceedOn</value>
        [DataMember(Name="succeedOn", EmitDefaultValue=false)]
        public DateTime? SucceedOn { get; set; }

        /// <summary>
        /// The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.
        /// </summary>
        /// <value>The user will be redirected to success URL when the transaction could be authorized or completed. In case no success URL is specified a default success page will be displayed.</value>
        [DataMember(Name="successUrl", EmitDefaultValue=false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Transaction
        /// </summary>
        /// <value>Transaction</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public SubscriptionChargeType Type { get; set; }

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
            sb.Append("class SubscriptionChargeCreate {\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DiscardedBy: ").Append(DiscardedBy).Append("\n");
            sb.Append("  DiscardedOn: ").Append(DiscardedOn).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  FailedUrl: ").Append(FailedUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LedgerEntries: ").Append(LedgerEntries).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PlannedExecutionDate: ").Append(PlannedExecutionDate).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProcessingType: ").Append(ProcessingType).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  SucceedOn: ").Append(SucceedOn).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as SubscriptionChargeCreate);
        }

        /// <summary>
        /// Returns true if SubscriptionChargeCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionChargeCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionChargeCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.DiscardedBy == other.DiscardedBy ||
                    this.DiscardedBy != null &&
                    this.DiscardedBy.Equals(other.DiscardedBy)
                ) && 
                (
                    this.DiscardedOn == other.DiscardedOn ||
                    this.DiscardedOn != null &&
                    this.DiscardedOn.Equals(other.DiscardedOn)
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
                    this.FailedUrl == other.FailedUrl ||
                    this.FailedUrl != null &&
                    this.FailedUrl.Equals(other.FailedUrl)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LedgerEntries == other.LedgerEntries ||
                    this.LedgerEntries != null &&
                    this.LedgerEntries.SequenceEqual(other.LedgerEntries)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.PlannedExecutionDate == other.PlannedExecutionDate ||
                    this.PlannedExecutionDate != null &&
                    this.PlannedExecutionDate.Equals(other.PlannedExecutionDate)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.ProcessingType == other.ProcessingType ||
                    this.ProcessingType != null &&
                    this.ProcessingType.Equals(other.ProcessingType)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Subscription == other.Subscription ||
                    this.Subscription != null &&
                    this.Subscription.Equals(other.Subscription)
                ) && 
                (
                    this.SucceedOn == other.SucceedOn ||
                    this.SucceedOn != null &&
                    this.SucceedOn.Equals(other.SucceedOn)
                ) && 
                (
                    this.SuccessUrl == other.SuccessUrl ||
                    this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(other.SuccessUrl)
                ) && 
                (
                    this.Transaction == other.Transaction ||
                    this.Transaction != null &&
                    this.Transaction.Equals(other.Transaction)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.DiscardedBy != null)
                    hash = hash * 59 + this.DiscardedBy.GetHashCode();
                if (this.DiscardedOn != null)
                    hash = hash * 59 + this.DiscardedOn.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.FailedOn != null)
                    hash = hash * 59 + this.FailedOn.GetHashCode();
                if (this.FailedUrl != null)
                    hash = hash * 59 + this.FailedUrl.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LedgerEntries != null)
                    hash = hash * 59 + this.LedgerEntries.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PlannedExecutionDate != null)
                    hash = hash * 59 + this.PlannedExecutionDate.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProcessingType != null)
                    hash = hash * 59 + this.ProcessingType.GetHashCode();
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Subscription != null)
                    hash = hash * 59 + this.Subscription.GetHashCode();
                if (this.SucceedOn != null)
                    hash = hash * 59 + this.SucceedOn.GetHashCode();
                if (this.SuccessUrl != null)
                    hash = hash * 59 + this.SuccessUrl.GetHashCode();
                if (this.Transaction != null)
                    hash = hash * 59 + this.Transaction.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
