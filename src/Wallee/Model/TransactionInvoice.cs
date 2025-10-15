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
    /// TransactionInvoice
    /// </summary>
    [DataContract]
    public partial class TransactionInvoice :  IEquatable<TransactionInvoice>
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
        public TransactionInvoiceState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TransactionInvoice()
        {
        }

        /// <summary>
        /// The total sum of all line items on the invoice, including taxes.
        /// </summary>
        /// <value>The total sum of all line items on the invoice, including taxes.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The address associated with the invoice, used for billing purposes.
        /// </summary>
        /// <value>The address associated with the invoice, used for billing purposes.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// The transaction completion this object is linked to.
        /// </summary>
        /// <value>The transaction completion this object is linked to.</value>
        [DataMember(Name="completion", EmitDefaultValue=false)]
        public TransactionCompletion Completion { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The ID of the user the invoice was derecognized by.
        /// </summary>
        /// <value>The ID of the user the invoice was derecognized by.</value>
        [DataMember(Name="derecognizedBy", EmitDefaultValue=false)]
        public long? DerecognizedBy { get; private set; }

        /// <summary>
        /// The date and time when the invoice was derecognized, meaning it is no longer considered outstanding or valid in the system.
        /// </summary>
        /// <value>The date and time when the invoice was derecognized, meaning it is no longer considered outstanding or valid in the system.</value>
        [DataMember(Name="derecognizedOn", EmitDefaultValue=false)]
        public DateTime? DerecognizedOn { get; private set; }

        /// <summary>
        /// The due date for payment of the invoice.
        /// </summary>
        /// <value>The due date for payment of the invoice.</value>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; private set; }


        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The invoiced line items that will appear on the invoice document.
        /// </summary>
        /// <value>The invoiced line items that will appear on the invoice document.</value>
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
        /// The merchant&#39;s reference used to identify the invoice.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the invoice.</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; private set; }

        /// <summary>
        /// The remaining amount the buyer owes to the merchant. A negative value indicates the invoice has been overpaid.
        /// </summary>
        /// <value>The remaining amount the buyer owes to the merchant. A negative value indicates the invoice has been overpaid.</value>
        [DataMember(Name="outstandingAmount", EmitDefaultValue=false)]
        public decimal? OutstandingAmount { get; private set; }

        /// <summary>
        /// The date and time when the invoice was recorded as paid. May differ from the actual payment date due to processing delays.
        /// </summary>
        /// <value>The date and time when the invoice was recorded as paid. May differ from the actual payment date due to processing delays.</value>
        [DataMember(Name="paidOn", EmitDefaultValue=false)]
        public DateTime? PaidOn { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }


        /// <summary>
        /// The portion of the invoiced amount that corresponds to taxes.
        /// </summary>
        /// <value>The portion of the invoiced amount that corresponds to taxes.</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; private set; }

        /// <summary>
        /// The time zone that this object is associated with.
        /// </summary>
        /// <value>The time zone that this object is associated with.</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; private set; }

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
            sb.Append("class TransactionInvoice {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DerecognizedBy: ").Append(DerecognizedBy).Append("\n");
            sb.Append("  DerecognizedOn: ").Append(DerecognizedOn).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  OutstandingAmount: ").Append(OutstandingAmount).Append("\n");
            sb.Append("  PaidOn: ").Append(PaidOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
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
            return this.Equals(input as TransactionInvoice);
        }

        /// <summary>
        /// Returns true if TransactionInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInvoice input)
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
                    this.Completion == input.Completion ||
                    (this.Completion != null &&
                    this.Completion.Equals(input.Completion))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DerecognizedBy == input.DerecognizedBy ||
                    (this.DerecognizedBy != null &&
                    this.DerecognizedBy.Equals(input.DerecognizedBy))
                ) && 
                (
                    this.DerecognizedOn == input.DerecognizedOn ||
                    (this.DerecognizedOn != null &&
                    this.DerecognizedOn.Equals(input.DerecognizedOn))
                ) && 
                (
                    this.DueOn == input.DueOn ||
                    (this.DueOn != null &&
                    this.DueOn.Equals(input.DueOn))
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.LinkedTransaction == input.LinkedTransaction ||
                    (this.LinkedTransaction != null &&
                    this.LinkedTransaction.Equals(input.LinkedTransaction))
                ) && 
                (
                    this.MerchantReference == input.MerchantReference ||
                    (this.MerchantReference != null &&
                    this.MerchantReference.Equals(input.MerchantReference))
                ) && 
                (
                    this.OutstandingAmount == input.OutstandingAmount ||
                    (this.OutstandingAmount != null &&
                    this.OutstandingAmount.Equals(input.OutstandingAmount))
                ) && 
                (
                    this.PaidOn == input.PaidOn ||
                    (this.PaidOn != null &&
                    this.PaidOn.Equals(input.PaidOn))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
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
                if (this.Completion != null)
                    hashCode = hashCode * 59 + this.Completion.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DerecognizedBy != null)
                    hashCode = hashCode * 59 + this.DerecognizedBy.GetHashCode();
                if (this.DerecognizedOn != null)
                    hashCode = hashCode * 59 + this.DerecognizedOn.GetHashCode();
                if (this.DueOn != null)
                    hashCode = hashCode * 59 + this.DueOn.GetHashCode();
                if (this.Environment != null)
                    hashCode = hashCode * 59 + this.Environment.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.LinkedTransaction != null)
                    hashCode = hashCode * 59 + this.LinkedTransaction.GetHashCode();
                if (this.MerchantReference != null)
                    hashCode = hashCode * 59 + this.MerchantReference.GetHashCode();
                if (this.OutstandingAmount != null)
                    hashCode = hashCode * 59 + this.OutstandingAmount.GetHashCode();
                if (this.PaidOn != null)
                    hashCode = hashCode * 59 + this.PaidOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TimeZone != null)
                    hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
