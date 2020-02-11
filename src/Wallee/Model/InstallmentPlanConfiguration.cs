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
    /// The installment plan allows to setup a template for an installment.
    /// </summary>
    [DataContract]
    public partial class InstallmentPlanConfiguration :  IEquatable<InstallmentPlanConfiguration>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPlanConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InstallmentPlanConfiguration()
        {
        }

        /// <summary>
        /// The base currency in which the installment fee and minimal amount are defined.
        /// </summary>
        /// <value>The base currency in which the installment fee and minimal amount are defined.</value>
        [DataMember(Name="baseCurrency", EmitDefaultValue=true)]
        public string BaseCurrency { get; private set; }

        /// <summary>
        /// If a transaction meets all selected conditions the installment plan will be available to the customer to be selected.
        /// </summary>
        /// <value>If a transaction meets all selected conditions the installment plan will be available to the customer to be selected.</value>
        [DataMember(Name="conditions", EmitDefaultValue=true)]
        public List<long?> Conditions { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The installment fee is a fixed amount that is charged additionally when applying this installment plan.
        /// </summary>
        /// <value>The installment fee is a fixed amount that is charged additionally when applying this installment plan.</value>
        [DataMember(Name="installmentFee", EmitDefaultValue=true)]
        public decimal? InstallmentFee { get; private set; }

        /// <summary>
        /// The interest rate is a percentage of the total amount that is charged additionally when applying this installment plan.
        /// </summary>
        /// <value>The interest rate is a percentage of the total amount that is charged additionally when applying this installment plan.</value>
        [DataMember(Name="interestRate", EmitDefaultValue=true)]
        public decimal? InterestRate { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The installment plan can only be applied if the orders total is at least the defined minimal amount.
        /// </summary>
        /// <value>The installment plan can only be applied if the orders total is at least the defined minimal amount.</value>
        [DataMember(Name="minimalAmount", EmitDefaultValue=true)]
        public decimal? MinimalAmount { get; private set; }

        /// <summary>
        /// The installment plan name is used internally to identify the plan in administrative interfaces.For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The installment plan name is used internally to identify the plan in administrative interfaces.For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }

        /// <summary>
        /// A installment plan can be enabled only for specific payment method configurations. Other payment methods will not be selectable by the buyer.
        /// </summary>
        /// <value>A installment plan can be enabled only for specific payment method configurations. Other payment methods will not be selectable by the buyer.</value>
        [DataMember(Name="paymentMethodConfigurations", EmitDefaultValue=true)]
        public List<long?> PaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The sort order controls in which order the installation plans are listed. The sort order is used to order the plans in ascending order.
        /// </summary>
        /// <value>The sort order controls in which order the installation plans are listed. The sort order is used to order the plans in ascending order.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=true)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceReference
        /// </summary>
        [DataMember(Name="spaceReference", EmitDefaultValue=true)]
        public SpaceReference SpaceReference { get; private set; }


        /// <summary>
        /// The tax class determines the taxes which are applicable on all fees linked to the installment plan.
        /// </summary>
        /// <value>The tax class determines the taxes which are applicable on all fees linked to the installment plan.</value>
        [DataMember(Name="taxClass", EmitDefaultValue=true)]
        public TaxClass TaxClass { get; private set; }

        /// <summary>
        /// The terms and conditions will be displayed to the customer when he or she selects this installment plan.
        /// </summary>
        /// <value>The terms and conditions will be displayed to the customer when he or she selects this installment plan.</value>
        [DataMember(Name="termsAndConditions", EmitDefaultValue=true)]
        public ResourcePath TermsAndConditions { get; private set; }

        /// <summary>
        /// The title of the installment plan is used within the payment process. The title is visible to the buyer.
        /// </summary>
        /// <value>The title of the installment plan is used within the payment process. The title is visible to the buyer.</value>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public DatabaseTranslatedString Title { get; private set; }

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
            sb.Append("class InstallmentPlanConfiguration {\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstallmentFee: ").Append(InstallmentFee).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MinimalAmount: ").Append(MinimalAmount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethodConfigurations: ").Append(PaymentMethodConfigurations).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SpaceReference: ").Append(SpaceReference).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxClass: ").Append(TaxClass).Append("\n");
            sb.Append("  TermsAndConditions: ").Append(TermsAndConditions).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstallmentPlanConfiguration);
        }

        /// <summary>
        /// Returns true if InstallmentPlanConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of InstallmentPlanConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentPlanConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    (this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(input.BaseCurrency))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InstallmentFee == input.InstallmentFee ||
                    (this.InstallmentFee != null &&
                    this.InstallmentFee.Equals(input.InstallmentFee))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.MinimalAmount == input.MinimalAmount ||
                    (this.MinimalAmount != null &&
                    this.MinimalAmount.Equals(input.MinimalAmount))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PaymentMethodConfigurations == input.PaymentMethodConfigurations ||
                    this.PaymentMethodConfigurations != null &&
                    this.PaymentMethodConfigurations.SequenceEqual(input.PaymentMethodConfigurations)
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.SpaceReference == input.SpaceReference ||
                    (this.SpaceReference != null &&
                    this.SpaceReference.Equals(input.SpaceReference))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TaxClass == input.TaxClass ||
                    (this.TaxClass != null &&
                    this.TaxClass.Equals(input.TaxClass))
                ) && 
                (
                    this.TermsAndConditions == input.TermsAndConditions ||
                    (this.TermsAndConditions != null &&
                    this.TermsAndConditions.Equals(input.TermsAndConditions))
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
                if (this.BaseCurrency != null)
                    hashCode = hashCode * 59 + this.BaseCurrency.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstallmentFee != null)
                    hashCode = hashCode * 59 + this.InstallmentFee.GetHashCode();
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MinimalAmount != null)
                    hashCode = hashCode * 59 + this.MinimalAmount.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.PaymentMethodConfigurations.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.SpaceReference != null)
                    hashCode = hashCode * 59 + this.SpaceReference.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TaxClass != null)
                    hashCode = hashCode * 59 + this.TaxClass.GetHashCode();
                if (this.TermsAndConditions != null)
                    hashCode = hashCode * 59 + this.TermsAndConditions.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
