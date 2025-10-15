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
    /// A refund is a credit issued to the customer, which can be initiated either by the merchant or by the customer as a reversal.
    /// </summary>
    [DataContract]
    public partial class Refund :  IEquatable<Refund>
    {
        /// <summary>
        /// The environment used when rendering resources.
        /// </summary>
        /// <value>The environment used when rendering resources.</value>
        [DataMember(Name="environment", EmitDefaultValue=false)]
        public Environment? Environment { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public RefundState? State { get; private set; }
        /// <summary>
        /// The type specifying the method and origin of the refund (e.g., initiated by the customer or merchant).
        /// </summary>
        /// <value>The type specifying the method and origin of the refund (e.g., initiated by the customer or merchant).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public RefundType? Type { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Refund" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Refund()
        {
        }

        /// <summary>
        /// The total monetary amount of the refund, representing the exact credit issued to the customer.
        /// </summary>
        /// <value>The total monetary amount of the refund, representing the exact credit issued to the customer.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The original base line items from the transaction prior to the refund, serving as a reference for the refunded amounts.
        /// </summary>
        /// <value>The original base line items from the transaction prior to the refund, serving as a reference for the refunded amounts.</value>
        [DataMember(Name="baseLineItems", EmitDefaultValue=false)]
        public List<LineItem> BaseLineItems { get; private set; }

        /// <summary>
        /// The transaction completion that the refund belongs to.
        /// </summary>
        /// <value>The transaction completion that the refund belongs to.</value>
        [DataMember(Name="completion", EmitDefaultValue=false)]
        public long? Completion { get; private set; }

        /// <summary>
        /// The ID of the user the refund was created by.
        /// </summary>
        /// <value>The ID of the user the refund was created by.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }


        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The date and time when the refund failed.
        /// </summary>
        /// <value>The date and time when the refund failed.</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// The reason for the failure of the refund.
        /// </summary>
        /// <value>The reason for the failure of the refund.</value>
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
        /// The line items included in the refund, representing the reductions.
        /// </summary>
        /// <value>The line items included in the refund, representing the reductions.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the refund.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the refund.</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// The date and time when the next update of the object&#39;s state is planned.
        /// </summary>
        /// <value>The date and time when the next update of the object&#39;s state is planned.</value>
        [DataMember(Name="nextUpdateOn", EmitDefaultValue=false)]
        public DateTime? NextUpdateOn { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The date and time when the processing of the refund was started.
        /// </summary>
        /// <value>The date and time when the processing of the refund was started.</value>
        [DataMember(Name="processingOn", EmitDefaultValue=false)]
        public DateTime? ProcessingOn { get; private set; }

        /// <summary>
        /// The reference ID provided by the payment processor, used to trace the refund through the external payment system.
        /// </summary>
        /// <value>The reference ID provided by the payment processor, used to trace the refund through the external payment system.</value>
        [DataMember(Name="processorReference", EmitDefaultValue=false)]
        public string ProcessorReference { get; private set; }

        /// <summary>
        /// The line items from the original transaction, adjusted to reflect any reductions applied during the refund process.
        /// </summary>
        /// <value>The line items from the original transaction, adjusted to reflect any reductions applied during the refund process.</value>
        [DataMember(Name="reducedLineItems", EmitDefaultValue=false)]
        public List<LineItem> ReducedLineItems { get; private set; }

        /// <summary>
        /// The reductions applied on the original transaction items, detailing specific adjustments associated with the refund.
        /// </summary>
        /// <value>The reductions applied on the original transaction items, detailing specific adjustments associated with the refund.</value>
        [DataMember(Name="reductions", EmitDefaultValue=false)]
        public List<LineItemReduction> Reductions { get; private set; }


        /// <summary>
        /// The date and time when the refund succeeded.
        /// </summary>
        /// <value>The date and time when the refund succeeded.</value>
        [DataMember(Name="succeededOn", EmitDefaultValue=false)]
        public DateTime? SucceededOn { get; private set; }

        /// <summary>
        /// The tax breakdown applied to the refund amount, helping with tax calculations or reporting.
        /// </summary>
        /// <value>The tax breakdown applied to the refund amount, helping with tax calculations or reporting.</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<Tax> Taxes { get; private set; }

        /// <summary>
        /// The time zone that this object is associated with.
        /// </summary>
        /// <value>The time zone that this object is associated with.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

        /// <summary>
        /// The date and time when the object will expire.
        /// </summary>
        /// <value>The date and time when the object will expire.</value>
        [DataMember(Name="timeoutOn", EmitDefaultValue=false)]
        public DateTime? TimeoutOn { get; private set; }

        /// <summary>
        /// The sum of fees applied to the refund transaction, such as processing or service charges.
        /// </summary>
        /// <value>The sum of fees applied to the refund transaction, such as processing or service charges.</value>
        [DataMember(Name="totalAppliedFees", EmitDefaultValue=false)]
        public decimal? TotalAppliedFees { get; private set; }

        /// <summary>
        /// The total amount settled for the refund, factoring in reductions, taxes, and any additional applied fees.
        /// </summary>
        /// <value>The total amount settled for the refund, factoring in reductions, taxes, and any additional applied fees.</value>
        [DataMember(Name="totalSettledAmount", EmitDefaultValue=false)]
        public decimal? TotalSettledAmount { get; private set; }

        /// <summary>
        /// The transaction that the refund belongs to.
        /// </summary>
        /// <value>The transaction that the refund belongs to.</value>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public Transaction Transaction { get; private set; }


        /// <summary>
        /// An updated invoice reflecting adjustments made by the refund.
        /// </summary>
        /// <value>An updated invoice reflecting adjustments made by the refund.</value>
        [DataMember(Name="updatedInvoice", EmitDefaultValue=false)]
        public long? UpdatedInvoice { get; private set; }

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
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
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
                    input.BaseLineItems != null &&
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
                    input.ReducedLineItems != null &&
                    this.ReducedLineItems.SequenceEqual(input.ReducedLineItems)
                ) && 
                (
                    this.Reductions == input.Reductions ||
                    this.Reductions != null &&
                    input.Reductions != null &&
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
                    input.Taxes != null &&
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
