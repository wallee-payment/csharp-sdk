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
    /// The refund represents a credit back to the customer. It can be issued by the merchant or by the customer (reversal).
    /// </summary>
    [DataContract]
    public partial class Refund :  IEquatable<Refund>
    {
        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name="environment", EmitDefaultValue=true)]
        public Environment? Environment { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public RefundState? State { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public RefundType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Refund()
        {
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// Gets or Sets BaseLineItems
        /// </summary>
        [DataMember(Name="baseLineItems", EmitDefaultValue=true)]
        public List<LineItem> BaseLineItems { get; private set; }

        /// <summary>
        /// Gets or Sets Completion
        /// </summary>
        [DataMember(Name="completion", EmitDefaultValue=true)]
        public long? Completion { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=true)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public DateTime? CreatedOn { get; private set; }


        /// <summary>
        /// The external id helps to identify duplicate calls to the refund service. As such the external ID has to be unique per transaction.
        /// </summary>
        /// <value>The external id helps to identify duplicate calls to the refund service. As such the external ID has to be unique per transaction.</value>
        [DataMember(Name="externalId", EmitDefaultValue=true)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// Gets or Sets FailedOn
        /// </summary>
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
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; private set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=true)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets MerchantReference
        /// </summary>
        [DataMember(Name="merchantReference", EmitDefaultValue=true)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// Gets or Sets NextUpdateOn
        /// </summary>
        [DataMember(Name="nextUpdateOn", EmitDefaultValue=true)]
        public DateTime? NextUpdateOn { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessingOn
        /// </summary>
        [DataMember(Name="processingOn", EmitDefaultValue=true)]
        public DateTime? ProcessingOn { get; private set; }

        /// <summary>
        /// Gets or Sets ProcessorReference
        /// </summary>
        [DataMember(Name="processorReference", EmitDefaultValue=true)]
        public string ProcessorReference { get; private set; }

        /// <summary>
        /// Gets or Sets ReducedLineItems
        /// </summary>
        [DataMember(Name="reducedLineItems", EmitDefaultValue=true)]
        public List<LineItem> ReducedLineItems { get; private set; }

        /// <summary>
        /// Gets or Sets Reductions
        /// </summary>
        [DataMember(Name="reductions", EmitDefaultValue=true)]
        public List<LineItemReduction> Reductions { get; private set; }


        /// <summary>
        /// Gets or Sets SucceededOn
        /// </summary>
        [DataMember(Name="succeededOn", EmitDefaultValue=true)]
        public DateTime? SucceededOn { get; private set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name="taxes", EmitDefaultValue=true)]
        public List<Tax> Taxes { get; private set; }

        /// <summary>
        /// Gets or Sets TimeZone
        /// </summary>
        [DataMember(Name="timeZone", EmitDefaultValue=true)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// Gets or Sets TimeoutOn
        /// </summary>
        [DataMember(Name="timeoutOn", EmitDefaultValue=true)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// The total applied fees is the sum of all fees that have been applied so far.
        /// </summary>
        /// <value>The total applied fees is the sum of all fees that have been applied so far.</value>
        [DataMember(Name="totalAppliedFees", EmitDefaultValue=true)]
        public decimal? TotalAppliedFees { get; private set; }

        /// <summary>
        /// The total settled amount is the total amount which has been settled so far.
        /// </summary>
        /// <value>The total settled amount is the total amount which has been settled so far.</value>
        [DataMember(Name="totalSettledAmount", EmitDefaultValue=true)]
        public decimal? TotalSettledAmount { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=true)]
        public Transaction Transaction { get; private set; }


        /// <summary>
        /// Gets or Sets UpdatedInvoice
        /// </summary>
        [DataMember(Name="updatedInvoice", EmitDefaultValue=true)]
        public long? UpdatedInvoice { get; private set; }

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
            sb.Append("class Refund {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BaseLineItems: ").Append(BaseLineItems).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  NextUpdateOn: ").Append(NextUpdateOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProcessingOn: ").Append(ProcessingOn).Append("\n");
            sb.Append("  ProcessorReference: ").Append(ProcessorReference).Append("\n");
            sb.Append("  ReducedLineItems: ").Append(ReducedLineItems).Append("\n");
            sb.Append("  Reductions: ").Append(Reductions).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  TotalAppliedFees: ").Append(TotalAppliedFees).Append("\n");
            sb.Append("  TotalSettledAmount: ").Append(TotalSettledAmount).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdatedInvoice: ").Append(UpdatedInvoice).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Refund);
        }

        /// <summary>
        /// Returns true if Refund instances are equal
        /// </summary>
        /// <param name="input">Instance of Refund to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Refund input)
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
                    this.BaseLineItems == input.BaseLineItems ||
                    this.BaseLineItems != null &&
                    this.BaseLineItems.SequenceEqual(input.BaseLineItems)
                ) && 
                (
                    this.Completion == input.Completion ||
                    (this.Completion != null &&
                    this.Completion.Equals(input.Completion))
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
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.NextUpdateOn == input.NextUpdateOn ||
                    (this.NextUpdateOn != null &&
                    this.NextUpdateOn.Equals(input.NextUpdateOn))
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
                    this.ProcessorReference == input.ProcessorReference ||
                    (this.ProcessorReference != null &&
                    this.ProcessorReference.Equals(input.ProcessorReference))
                ) && 
                (
                    this.ReducedLineItems == input.ReducedLineItems ||
                    this.ReducedLineItems != null &&
                    this.ReducedLineItems.SequenceEqual(input.ReducedLineItems)
                ) && 
                (
                    this.Reductions == input.Reductions ||
                    this.Reductions != null &&
                    this.Reductions.SequenceEqual(input.Reductions)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.SucceededOn == input.SucceededOn ||
                    (this.SucceededOn != null &&
                    this.SucceededOn.Equals(input.SucceededOn))
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.TimeZone == input.TimeZone ||
                    (this.TimeZone != null &&
                    this.TimeZone.Equals(input.TimeZone))
                ) && 
                (
                    this.TimeoutOn == input.TimeoutOn ||
                    (this.TimeoutOn != null &&
                    this.TimeoutOn.Equals(input.TimeoutOn))
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
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UpdatedInvoice == input.UpdatedInvoice ||
                    (this.UpdatedInvoice != null &&
                    this.UpdatedInvoice.Equals(input.UpdatedInvoice))
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
                if (this.BaseLineItems != null)
                    hashCode = hashCode * 59 + this.BaseLineItems.GetHashCode();
                if (this.Completion != null)
                    hashCode = hashCode * 59 + this.Completion.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
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
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.NextUpdateOn != null)
                    hashCode = hashCode * 59 + this.NextUpdateOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProcessingOn != null)
                    hashCode = hashCode * 59 + this.ProcessingOn.GetHashCode();
                if (this.ProcessorReference != null)
                    hashCode = hashCode * 59 + this.ProcessorReference.GetHashCode();
                if (this.ReducedLineItems != null)
                    hashCode = hashCode * 59 + this.ReducedLineItems.GetHashCode();
                if (this.Reductions != null)
                    hashCode = hashCode * 59 + this.Reductions.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SucceededOn != null)
                    hashCode = hashCode * 59 + this.SucceededOn.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TimeoutOn != null)
                    hashCode = hashCode * 59 + this.TimeoutOn.GetHashCode();
                if (this.TotalAppliedFees != null)
                    hashCode = hashCode * 59 + this.TotalAppliedFees.GetHashCode();
                if (this.TotalSettledAmount != null)
                    hashCode = hashCode * 59 + this.TotalSettledAmount.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdatedInvoice != null)
                    hashCode = hashCode * 59 + this.UpdatedInvoice.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
