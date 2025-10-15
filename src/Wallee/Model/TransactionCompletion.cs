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
    /// TransactionCompletion
    /// </summary>
    [DataContract]
    public partial class TransactionCompletion :  IEquatable<TransactionCompletion>
    {
        /// <summary>
        /// The mode of transaction completion, such as online or offline, determining how the completion process is executed.
        /// </summary>
        /// <value>The mode of transaction completion, such as online or offline, determining how the completion process is executed.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public TransactionCompletionMode? Mode { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public TransactionCompletionState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCompletion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransactionCompletion()
        {
        }

        /// <summary>
        /// The total amount to be captured in this completion, including taxes.
        /// </summary>
        /// <value>The total amount to be captured in this completion, including taxes.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The original line items from the transaction that serve as the baseline for this completion.
        /// </summary>
        /// <value>The original line items from the transaction that serve as the baseline for this completion.</value>
        [DataMember(Name="baseLineItems", EmitDefaultValue=false)]
        public List<LineItem> BaseLineItems { get; private set; }

        /// <summary>
        /// The ID of the user the transaction completion was created by.
        /// </summary>
        /// <value>The ID of the user the transaction completion was created by.</value>
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
        /// The date and time when the transaction completion failed.
        /// </summary>
        /// <value>The date and time when the transaction completion failed.</value>
        [DataMember(Name="failedOn", EmitDefaultValue=false)]
        public DateTime? FailedOn { get; private set; }

        /// <summary>
        /// The reason for the failure of the transaction completion.
        /// </summary>
        /// <value>The reason for the failure of the transaction completion.</value>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public FailureReason FailureReason { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name="invoiceMerchantReference", EmitDefaultValue=false)]
        public string InvoiceMerchantReference { get; private set; }

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
        /// Whether this is the final completion for the transaction. After the last completion is successfully created, the transaction enters its final state, and no further completions can occur.
        /// </summary>
        /// <value>Whether this is the final completion for the transaction. After the last completion is successfully created, the transaction enters its final state, and no further completions can occur.</value>
        [DataMember(Name="lastCompletion", EmitDefaultValue=false)]
        public bool? LastCompletion { get; private set; }

        /// <summary>
        /// The specific version of the line items that are being used for this completion.
        /// </summary>
        /// <value>The specific version of the line items that are being used for this completion.</value>
        [DataMember(Name="lineItemVersion", EmitDefaultValue=false)]
        public TransactionLineItemVersion LineItemVersion { get; private set; }

        /// <summary>
        /// The line items captured in this transaction completion.
        /// </summary>
        /// <value>The line items captured in this transaction completion.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name="linkedTransaction", EmitDefaultValue=false)]
        public long? LinkedTransaction { get; private set; }


        /// <summary>
        /// The date and time when the next update of the object&#39;s state is planned.
        /// </summary>
        /// <value>The date and time when the next update of the object&#39;s state is planned.</value>
        [DataMember(Name="nextUpdateOn", EmitDefaultValue=false)]
        public DateTime? NextUpdateOn { get; private set; }

        /// <summary>
        /// Payment-specific details related to this transaction completion such as payment instructions or references needed for processing.
        /// </summary>
        /// <value>Payment-specific details related to this transaction completion such as payment instructions or references needed for processing.</value>
        [DataMember(Name="paymentInformation", EmitDefaultValue=false)]
        public string PaymentInformation { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The date and time when the processing of the transaction completion was started.
        /// </summary>
        /// <value>The date and time when the processing of the transaction completion was started.</value>
        [DataMember(Name="processingOn", EmitDefaultValue=false)]
        public DateTime? ProcessingOn { get; private set; }

        /// <summary>
        /// The reference ID provided by the payment processor, used to trace the completion through the external payment system.
        /// </summary>
        /// <value>The reference ID provided by the payment processor, used to trace the completion through the external payment system.</value>
        [DataMember(Name="processorReference", EmitDefaultValue=false)]
        public string ProcessorReference { get; private set; }

        /// <summary>
        /// The line items yet to be captured in the transaction.
        /// </summary>
        /// <value>The line items yet to be captured in the transaction.</value>
        [DataMember(Name="remainingLineItems", EmitDefaultValue=false)]
        public List<LineItem> RemainingLineItems { get; private set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }


        /// <summary>
        /// The statement descriptor that appears on a customer&#39;s bank statement, providing an explanation for charges or payments, helping customers identify the transaction.
        /// </summary>
        /// <value>The statement descriptor that appears on a customer&#39;s bank statement, providing an explanation for charges or payments, helping customers identify the transaction.</value>
        [DataMember(Name="statementDescriptor", EmitDefaultValue=false)]
        public string StatementDescriptor { get; private set; }

        /// <summary>
        /// The date and time when the transaction completion succeeded.
        /// </summary>
        /// <value>The date and time when the transaction completion succeeded.</value>
        [DataMember(Name="succeededOn", EmitDefaultValue=false)]
        public DateTime? SucceededOn { get; private set; }

        /// <summary>
        /// The portion of the captured amount that corresponds to taxes.
        /// </summary>
        /// <value>The portion of the captured amount that corresponds to taxes.</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; private set; }

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
            sb.Append("class TransactionCompletion {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BaseLineItems: ").Append(BaseLineItems).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InvoiceMerchantReference: ").Append(InvoiceMerchantReference).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LastCompletion: ").Append(LastCompletion).Append("\n");
            sb.Append("  LineItemVersion: ").Append(LineItemVersion).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  NextUpdateOn: ").Append(NextUpdateOn).Append("\n");
            sb.Append("  PaymentInformation: ").Append(PaymentInformation).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProcessingOn: ").Append(ProcessingOn).Append("\n");
            sb.Append("  ProcessorReference: ").Append(ProcessorReference).Append("\n");
            sb.Append("  RemainingLineItems: ").Append(RemainingLineItems).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
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
            return this.Equals(input as TransactionCompletion);
        }

        /// <summary>
        /// Returns true if TransactionCompletion instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionCompletion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionCompletion input)
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
                    this.InvoiceMerchantReference == input.InvoiceMerchantReference ||
                    (this.InvoiceMerchantReference != null &&
                    this.InvoiceMerchantReference.Equals(input.InvoiceMerchantReference))
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
                    this.LastCompletion == input.LastCompletion ||
                    (this.LastCompletion != null &&
                    this.LastCompletion.Equals(input.LastCompletion))
                ) && 
                (
                    this.LineItemVersion == input.LineItemVersion ||
                    (this.LineItemVersion != null &&
                    this.LineItemVersion.Equals(input.LineItemVersion))
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
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.NextUpdateOn == input.NextUpdateOn ||
                    (this.NextUpdateOn != null &&
                    this.NextUpdateOn.Equals(input.NextUpdateOn))
                ) && 
                (
                    this.PaymentInformation == input.PaymentInformation ||
                    (this.PaymentInformation != null &&
                    this.PaymentInformation.Equals(input.PaymentInformation))
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
                    this.RemainingLineItems == input.RemainingLineItems ||
                    this.RemainingLineItems != null &&
                    input.RemainingLineItems != null &&
                    this.RemainingLineItems.SequenceEqual(input.RemainingLineItems)
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
                    this.StatementDescriptor == input.StatementDescriptor ||
                    (this.StatementDescriptor != null &&
                    this.StatementDescriptor.Equals(input.StatementDescriptor))
                ) && 
                (
                    this.SucceededOn == input.SucceededOn ||
                    (this.SucceededOn != null &&
                    this.SucceededOn.Equals(input.SucceededOn))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
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
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FailedOn != null)
                    hashCode = hashCode * 59 + this.FailedOn.GetHashCode();
                if (this.FailureReason != null)
                    hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InvoiceMerchantReference != null)
                    hashCode = hashCode * 59 + this.InvoiceMerchantReference.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LastCompletion != null)
                    hashCode = hashCode * 59 + this.LastCompletion.GetHashCode();
                if (this.LineItemVersion != null)
                    hashCode = hashCode * 59 + this.LineItemVersion.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.NextUpdateOn != null)
                    hashCode = hashCode * 59 + this.NextUpdateOn.GetHashCode();
                if (this.PaymentInformation != null)
                    hashCode = hashCode * 59 + this.PaymentInformation.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProcessingOn != null)
                    hashCode = hashCode * 59 + this.ProcessingOn.GetHashCode();
                if (this.ProcessorReference != null)
                    hashCode = hashCode * 59 + this.ProcessorReference.GetHashCode();
                if (this.RemainingLineItems != null)
                    hashCode = hashCode * 59 + this.RemainingLineItems.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StatementDescriptor != null)
                    hashCode = hashCode * 59 + this.StatementDescriptor.GetHashCode();
                if (this.SucceededOn != null)
                    hashCode = hashCode * 59 + this.SucceededOn.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.TimeoutOn != null)
                    hashCode = hashCode * 59 + this.TimeoutOn.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
