
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
    /// The transaction invoice represents the invoice document for a particular transaction.
    /// </summary>
    [DataContract]
    public partial class TransactionInvoice :  IEquatable<TransactionInvoice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoice" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="LinkedTransaction">LinkedTransaction</param>
        /// <param name="Amount">Amount</param>
        /// <param name="Completion">Completion</param>
        /// <param name="CreatedOn">The date on which the invoice is created on.</param>
        /// <param name="DerecognizedOn">The date on which the invoice is marked as derecognized.</param>
        /// <param name="DueOn">The date on which the invoice should be paid on.</param>
        /// <param name="ExternalId">ExternalId</param>
        /// <param name="Language">Language</param>
        /// <param name="LineItems">LineItems</param>
        /// <param name="MerchantReference">MerchantReference</param>
        /// <param name="PaidOn">The date on which the invoice is marked as paid. Eventually this date lags behind of the actual paid date.</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="SpaceViewId">SpaceViewId</param>
        /// <param name="State">State</param>
        /// <param name="TaxAmount">TaxAmount</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public TransactionInvoice(long? Id = default(long?), long? LinkedSpaceId = default(long?), long? LinkedTransaction = default(long?), decimal? Amount = default(decimal?), TransactionCompletion Completion = default(TransactionCompletion), DateTime? CreatedOn = default(DateTime?), DateTime? DerecognizedOn = default(DateTime?), DateTime? DueOn = default(DateTime?), string ExternalId = default(string), string Language = default(string), List<LineItem> LineItems = default(List<LineItem>), string MerchantReference = default(string), DateTime? PaidOn = default(DateTime?), DateTime? PlannedPurgeDate = default(DateTime?), long? SpaceViewId = default(long?), TransactionInvoiceState State = default(TransactionInvoiceState), decimal? TaxAmount = default(decimal?), int? Version = default(int?))
        {
            this.Id = Id;
            this.LinkedSpaceId = LinkedSpaceId;
            this.LinkedTransaction = LinkedTransaction;
            this.Amount = Amount;
            this.Completion = Completion;
            this.CreatedOn = CreatedOn;
            this.DerecognizedOn = DerecognizedOn;
            this.DueOn = DueOn;
            this.ExternalId = ExternalId;
            this.Language = Language;
            this.LineItems = LineItems;
            this.MerchantReference = MerchantReference;
            this.PaidOn = PaidOn;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.SpaceViewId = SpaceViewId;
            this.State = State;
            this.TaxAmount = TaxAmount;
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
        /// Amount
        /// </summary>
        /// <value>Amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Completion
        /// </summary>
        /// <value>Completion</value>
        [DataMember(Name="completion", EmitDefaultValue=false)]
        public TransactionCompletion Completion { get; set; }

        /// <summary>
        /// The date on which the invoice is created on.
        /// </summary>
        /// <value>The date on which the invoice is created on.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// The date on which the invoice is marked as derecognized.
        /// </summary>
        /// <value>The date on which the invoice is marked as derecognized.</value>
        [DataMember(Name="derecognizedOn", EmitDefaultValue=false)]
        public DateTime? DerecognizedOn { get; set; }

        /// <summary>
        /// The date on which the invoice should be paid on.
        /// </summary>
        /// <value>The date on which the invoice should be paid on.</value>
        [DataMember(Name="dueOn", EmitDefaultValue=false)]
        public DateTime? DueOn { get; set; }

        /// <summary>
        /// ExternalId
        /// </summary>
        /// <value>ExternalId</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// LineItems
        /// </summary>
        /// <value>LineItems</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// MerchantReference
        /// </summary>
        /// <value>MerchantReference</value>
        [DataMember(Name="merchantReference", EmitDefaultValue=false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The date on which the invoice is marked as paid. Eventually this date lags behind of the actual paid date.
        /// </summary>
        /// <value>The date on which the invoice is marked as paid. Eventually this date lags behind of the actual paid date.</value>
        [DataMember(Name="paidOn", EmitDefaultValue=false)]
        public DateTime? PaidOn { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

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
        public TransactionInvoiceState State { get; set; }

        /// <summary>
        /// TaxAmount
        /// </summary>
        /// <value>TaxAmount</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; set; }

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
            sb.Append("class TransactionInvoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DerecognizedOn: ").Append(DerecognizedOn).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  PaidOn: ").Append(PaidOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
            return this.Equals(obj as TransactionInvoice);
        }

        /// <summary>
        /// Returns true if TransactionInvoice instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInvoice other)
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
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Completion == other.Completion ||
                    this.Completion != null &&
                    this.Completion.Equals(other.Completion)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.DerecognizedOn == other.DerecognizedOn ||
                    this.DerecognizedOn != null &&
                    this.DerecognizedOn.Equals(other.DerecognizedOn)
                ) && 
                (
                    this.DueOn == other.DueOn ||
                    this.DueOn != null &&
                    this.DueOn.Equals(other.DueOn)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
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
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.PaidOn == other.PaidOn ||
                    this.PaidOn != null &&
                    this.PaidOn.Equals(other.PaidOn)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
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
                    this.TaxAmount == other.TaxAmount ||
                    this.TaxAmount != null &&
                    this.TaxAmount.Equals(other.TaxAmount)
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
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Completion != null)
                    hash = hash * 59 + this.Completion.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.DerecognizedOn != null)
                    hash = hash * 59 + this.DerecognizedOn.GetHashCode();
                if (this.DueOn != null)
                    hash = hash * 59 + this.DueOn.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.MerchantReference != null)
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                if (this.PaidOn != null)
                    hash = hash * 59 + this.PaidOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.SpaceViewId != null)
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.TaxAmount != null)
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
