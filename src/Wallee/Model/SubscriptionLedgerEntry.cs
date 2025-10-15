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
    /// The subscription ledger entry represents a single change on the subscription balance.
    /// </summary>
    [DataContract]
    public partial class SubscriptionLedgerEntry :  IEquatable<SubscriptionLedgerEntry>
    {
        /// <summary>
        /// Gets or Sets FeeType
        /// </summary>
        [DataMember(Name="feeType", EmitDefaultValue=false)]
        public ProductFeeType? FeeType { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionLedgerEntryState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionLedgerEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionLedgerEntry()
        {
        }

        /// <summary>
        /// The total tax rate applied to the ledger entry, calculated from the rates of all tax lines.
        /// </summary>
        /// <value>The total tax rate applied to the ledger entry, calculated from the rates of all tax lines.</value>
        [DataMember(Name="aggregatedTaxRate", EmitDefaultValue=false)]
        public decimal? AggregatedTaxRate { get; private set; }

        /// <summary>
        /// The leger entry&#39;s amount with discounts applied, excluding taxes.
        /// </summary>
        /// <value>The leger entry&#39;s amount with discounts applied, excluding taxes.</value>
        [DataMember(Name="amountExcludingTax", EmitDefaultValue=false)]
        public decimal? AmountExcludingTax { get; private set; }

        /// <summary>
        /// The leger entry&#39;s amount with discounts applied, including taxes.
        /// </summary>
        /// <value>The leger entry&#39;s amount with discounts applied, including taxes.</value>
        [DataMember(Name="amountIncludingTax", EmitDefaultValue=false)]
        public decimal? AmountIncludingTax { get; private set; }

        /// <summary>
        /// Gets or Sets ComponentReferenceName
        /// </summary>
        [DataMember(Name="componentReferenceName", EmitDefaultValue=false)]
        public string ComponentReferenceName { get; private set; }

        /// <summary>
        /// Gets or Sets ComponentReferenceSku
        /// </summary>
        [DataMember(Name="componentReferenceSku", EmitDefaultValue=false)]
        public string ComponentReferenceSku { get; private set; }

        /// <summary>
        /// The ID of the user the ledger entry was created by.
        /// </summary>
        /// <value>The ID of the user the ledger entry was created by.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The discount allocated to the ledger entry, including taxes.
        /// </summary>
        /// <value>The discount allocated to the ledger entry, including taxes.</value>
        [DataMember(Name="discountIncludingTax", EmitDefaultValue=false)]
        public decimal? DiscountIncludingTax { get; private set; }

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
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets ProRataCalculated
        /// </summary>
        [DataMember(Name="proRataCalculated", EmitDefaultValue=false)]
        public bool? ProRataCalculated { get; private set; }

        /// <summary>
        /// The number of items that were consumed.
        /// </summary>
        /// <value>The number of items that were consumed.</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public decimal? Quantity { get; private set; }


        /// <summary>
        /// Gets or Sets SubscriptionMetricId
        /// </summary>
        [DataMember(Name="subscriptionMetricId", EmitDefaultValue=false)]
        public long? SubscriptionMetricId { get; private set; }

        /// <summary>
        /// The subscription version that the ledger entry belongs to.
        /// </summary>
        /// <value>The subscription version that the ledger entry belongs to.</value>
        [DataMember(Name="subscriptionVersion", EmitDefaultValue=false)]
        public long? SubscriptionVersion { get; private set; }

        /// <summary>
        /// The sum of all taxes applied to the ledger entry.
        /// </summary>
        /// <value>The sum of all taxes applied to the ledger entry.</value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; private set; }

        /// <summary>
        /// A set of tax lines, each of which specifies a tax applied to the ledger entry.
        /// </summary>
        /// <value>A set of tax lines, each of which specifies a tax applied to the ledger entry.</value>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<Tax> Taxes { get; private set; }

        /// <summary>
        /// The title that indicates what the ledger entry is about.
        /// </summary>
        /// <value>The title that indicates what the ledger entry is about.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; private set; }

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
            sb.Append("class SubscriptionLedgerEntry {\n");
            sb.Append("  AggregatedTaxRate: ").Append(AggregatedTaxRate).Append("\n");
            sb.Append("  AmountExcludingTax: ").Append(AmountExcludingTax).Append("\n");
            sb.Append("  AmountIncludingTax: ").Append(AmountIncludingTax).Append("\n");
            sb.Append("  ComponentReferenceName: ").Append(ComponentReferenceName).Append("\n");
            sb.Append("  ComponentReferenceSku: ").Append(ComponentReferenceSku).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DiscountIncludingTax: ").Append(DiscountIncludingTax).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProRataCalculated: ").Append(ProRataCalculated).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubscriptionMetricId: ").Append(SubscriptionMetricId).Append("\n");
            sb.Append("  SubscriptionVersion: ").Append(SubscriptionVersion).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as SubscriptionLedgerEntry);
        }

        /// <summary>
        /// Returns true if SubscriptionLedgerEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionLedgerEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionLedgerEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AggregatedTaxRate == input.AggregatedTaxRate ||
                    (this.AggregatedTaxRate != null &&
                    this.AggregatedTaxRate.Equals(input.AggregatedTaxRate))
                ) && 
                (
                    this.AmountExcludingTax == input.AmountExcludingTax ||
                    (this.AmountExcludingTax != null &&
                    this.AmountExcludingTax.Equals(input.AmountExcludingTax))
                ) && 
                (
                    this.AmountIncludingTax == input.AmountIncludingTax ||
                    (this.AmountIncludingTax != null &&
                    this.AmountIncludingTax.Equals(input.AmountIncludingTax))
                ) && 
                (
                    this.ComponentReferenceName == input.ComponentReferenceName ||
                    (this.ComponentReferenceName != null &&
                    this.ComponentReferenceName.Equals(input.ComponentReferenceName))
                ) && 
                (
                    this.ComponentReferenceSku == input.ComponentReferenceSku ||
                    (this.ComponentReferenceSku != null &&
                    this.ComponentReferenceSku.Equals(input.ComponentReferenceSku))
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
                    this.DiscountIncludingTax == input.DiscountIncludingTax ||
                    (this.DiscountIncludingTax != null &&
                    this.DiscountIncludingTax.Equals(input.DiscountIncludingTax))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.FeeType == input.FeeType ||
                    (this.FeeType != null &&
                    this.FeeType.Equals(input.FeeType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.ProRataCalculated == input.ProRataCalculated ||
                    (this.ProRataCalculated != null &&
                    this.ProRataCalculated.Equals(input.ProRataCalculated))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.SubscriptionMetricId == input.SubscriptionMetricId ||
                    (this.SubscriptionMetricId != null &&
                    this.SubscriptionMetricId.Equals(input.SubscriptionMetricId))
                ) && 
                (
                    this.SubscriptionVersion == input.SubscriptionVersion ||
                    (this.SubscriptionVersion != null &&
                    this.SubscriptionVersion.Equals(input.SubscriptionVersion))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.AggregatedTaxRate != null)
                    hashCode = hashCode * 59 + this.AggregatedTaxRate.GetHashCode();
                if (this.AmountExcludingTax != null)
                    hashCode = hashCode * 59 + this.AmountExcludingTax.GetHashCode();
                if (this.AmountIncludingTax != null)
                    hashCode = hashCode * 59 + this.AmountIncludingTax.GetHashCode();
                if (this.ComponentReferenceName != null)
                    hashCode = hashCode * 59 + this.ComponentReferenceName.GetHashCode();
                if (this.ComponentReferenceSku != null)
                    hashCode = hashCode * 59 + this.ComponentReferenceSku.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DiscountIncludingTax != null)
                    hashCode = hashCode * 59 + this.DiscountIncludingTax.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.FeeType != null)
                    hashCode = hashCode * 59 + this.FeeType.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProRataCalculated != null)
                    hashCode = hashCode * 59 + this.ProRataCalculated.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubscriptionMetricId != null)
                    hashCode = hashCode * 59 + this.SubscriptionMetricId.GetHashCode();
                if (this.SubscriptionVersion != null)
                    hashCode = hashCode * 59 + this.SubscriptionVersion.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
