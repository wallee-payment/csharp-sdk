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
    /// SubscriptionProductVersion
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductVersion :  IEquatable<SubscriptionProductVersion>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionProductVersionState? State { get; set; }
        /// <summary>
        /// Strategy that is used for tax calculation in fees.
        /// </summary>
        /// <value>Strategy that is used for tax calculation in fees.</value>
        [DataMember(Name="taxCalculation", EmitDefaultValue=false)]
        public TaxCalculation? TaxCalculation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SubscriptionProductVersion()
        {
        }

        /// <summary>
        /// Gets or Sets ActivatedOn
        /// </summary>
        [DataMember(Name="activatedOn", EmitDefaultValue=false)]
        public DateTime? ActivatedOn { get; private set; }

        /// <summary>
        /// The billing cycle determines the rhythm with which the subscriber is billed. The charging may have different rhythm.
        /// </summary>
        /// <value>The billing cycle determines the rhythm with which the subscriber is billed. The charging may have different rhythm.</value>
        [DataMember(Name="billingCycle", EmitDefaultValue=false)]
        public string BillingCycle { get; private set; }

        /// <summary>
        /// The comment allows to provide a internal comment for the version. It helps to document why a product was changed. The comment is not disclosed to the subscriber.
        /// </summary>
        /// <value>The comment allows to provide a internal comment for the version. It helps to document why a product was changed. The comment is not disclosed to the subscriber.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// The default currency has to be used in all fees.
        /// </summary>
        /// <value>The default currency has to be used in all fees.</value>
        [DataMember(Name="defaultCurrency", EmitDefaultValue=false)]
        public string DefaultCurrency { get; private set; }

        /// <summary>
        /// The currencies which are enabled can be selected to define component fees. Currencies which are not enabled cannot be used to define fees.
        /// </summary>
        /// <value>The currencies which are enabled can be selected to define component fees. Currencies which are not enabled cannot be used to define fees.</value>
        [DataMember(Name="enabledCurrencies", EmitDefaultValue=false)]
        public List<string> EnabledCurrencies { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The increment number represents the version number incremented whenever a new version is activated.
        /// </summary>
        /// <value>The increment number represents the version number incremented whenever a new version is activated.</value>
        [DataMember(Name="incrementNumber", EmitDefaultValue=false)]
        public int? IncrementNumber { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The minimal number of periods determines how long the subscription has to run before the subscription can be terminated.
        /// </summary>
        /// <value>The minimal number of periods determines how long the subscription has to run before the subscription can be terminated.</value>
        [DataMember(Name="minimalNumberOfPeriods", EmitDefaultValue=false)]
        public int? MinimalNumberOfPeriods { get; private set; }

        /// <summary>
        /// The product version name is the name of the product which is shown to the user for the version. When the visible product name should be changed for a particular product a new version has to be created which contains the new name of the product.
        /// </summary>
        /// <value>The product version name is the name of the product which is shown to the user for the version. When the visible product name should be changed for a particular product a new version has to be created which contains the new name of the product.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedString Name { get; private set; }

        /// <summary>
        /// The number of notice periods determines the number of periods which need to be paid between the request to terminate the subscription and the final period.
        /// </summary>
        /// <value>The number of notice periods determines the number of periods which need to be paid between the request to terminate the subscription and the final period.</value>
        [DataMember(Name="numberOfNoticePeriods", EmitDefaultValue=false)]
        public int? NumberOfNoticePeriods { get; private set; }

        /// <summary>
        /// Gets or Sets ObsoletedOn
        /// </summary>
        [DataMember(Name="obsoletedOn", EmitDefaultValue=false)]
        public DateTime? ObsoletedOn { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Each product version is linked to a product.
        /// </summary>
        /// <value>Each product version is linked to a product.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public SubscriptionProduct Product { get; private set; }

        /// <summary>
        /// The product version reference helps to identify the version. The reference is generated out of the product reference.
        /// </summary>
        /// <value>The product version reference helps to identify the version. The reference is generated out of the product reference.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; private set; }

        /// <summary>
        /// Gets or Sets RetiringFinishedOn
        /// </summary>
        [DataMember(Name="retiringFinishedOn", EmitDefaultValue=false)]
        public DateTime? RetiringFinishedOn { get; private set; }

        /// <summary>
        /// Gets or Sets RetiringStartedOn
        /// </summary>
        [DataMember(Name="retiringStartedOn", EmitDefaultValue=false)]
        public DateTime? RetiringStartedOn { get; private set; }



        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductVersion {\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  BillingCycle: ").Append(BillingCycle).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  EnabledCurrencies: ").Append(EnabledCurrencies).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncrementNumber: ").Append(IncrementNumber).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MinimalNumberOfPeriods: ").Append(MinimalNumberOfPeriods).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfNoticePeriods: ").Append(NumberOfNoticePeriods).Append("\n");
            sb.Append("  ObsoletedOn: ").Append(ObsoletedOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  RetiringFinishedOn: ").Append(RetiringFinishedOn).Append("\n");
            sb.Append("  RetiringStartedOn: ").Append(RetiringStartedOn).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxCalculation: ").Append(TaxCalculation).Append("\n");
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
            return this.Equals(input as SubscriptionProductVersion);
        }

        /// <summary>
        /// Returns true if SubscriptionProductVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivatedOn == input.ActivatedOn ||
                    (this.ActivatedOn != null &&
                    this.ActivatedOn.Equals(input.ActivatedOn))
                ) && 
                (
                    this.BillingCycle == input.BillingCycle ||
                    (this.BillingCycle != null &&
                    this.BillingCycle.Equals(input.BillingCycle))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DefaultCurrency == input.DefaultCurrency ||
                    (this.DefaultCurrency != null &&
                    this.DefaultCurrency.Equals(input.DefaultCurrency))
                ) && 
                (
                    this.EnabledCurrencies == input.EnabledCurrencies ||
                    this.EnabledCurrencies != null &&
                    input.EnabledCurrencies != null &&
                    this.EnabledCurrencies.SequenceEqual(input.EnabledCurrencies)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IncrementNumber == input.IncrementNumber ||
                    (this.IncrementNumber != null &&
                    this.IncrementNumber.Equals(input.IncrementNumber))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.MinimalNumberOfPeriods == input.MinimalNumberOfPeriods ||
                    (this.MinimalNumberOfPeriods != null &&
                    this.MinimalNumberOfPeriods.Equals(input.MinimalNumberOfPeriods))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumberOfNoticePeriods == input.NumberOfNoticePeriods ||
                    (this.NumberOfNoticePeriods != null &&
                    this.NumberOfNoticePeriods.Equals(input.NumberOfNoticePeriods))
                ) && 
                (
                    this.ObsoletedOn == input.ObsoletedOn ||
                    (this.ObsoletedOn != null &&
                    this.ObsoletedOn.Equals(input.ObsoletedOn))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.RetiringFinishedOn == input.RetiringFinishedOn ||
                    (this.RetiringFinishedOn != null &&
                    this.RetiringFinishedOn.Equals(input.RetiringFinishedOn))
                ) && 
                (
                    this.RetiringStartedOn == input.RetiringStartedOn ||
                    (this.RetiringStartedOn != null &&
                    this.RetiringStartedOn.Equals(input.RetiringStartedOn))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TaxCalculation == input.TaxCalculation ||
                    (this.TaxCalculation != null &&
                    this.TaxCalculation.Equals(input.TaxCalculation))
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
                if (this.ActivatedOn != null)
                    hashCode = hashCode * 59 + this.ActivatedOn.GetHashCode();
                if (this.BillingCycle != null)
                    hashCode = hashCode * 59 + this.BillingCycle.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DefaultCurrency != null)
                    hashCode = hashCode * 59 + this.DefaultCurrency.GetHashCode();
                if (this.EnabledCurrencies != null)
                    hashCode = hashCode * 59 + this.EnabledCurrencies.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncrementNumber != null)
                    hashCode = hashCode * 59 + this.IncrementNumber.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MinimalNumberOfPeriods != null)
                    hashCode = hashCode * 59 + this.MinimalNumberOfPeriods.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumberOfNoticePeriods != null)
                    hashCode = hashCode * 59 + this.NumberOfNoticePeriods.GetHashCode();
                if (this.ObsoletedOn != null)
                    hashCode = hashCode * 59 + this.ObsoletedOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.RetiringFinishedOn != null)
                    hashCode = hashCode * 59 + this.RetiringFinishedOn.GetHashCode();
                if (this.RetiringStartedOn != null)
                    hashCode = hashCode * 59 + this.RetiringStartedOn.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TaxCalculation != null)
                    hashCode = hashCode * 59 + this.TaxCalculation.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
