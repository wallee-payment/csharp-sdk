
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
    /// SubscriptionProductVersion model.
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductVersion :  IEquatable<SubscriptionProductVersion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersion" /> class.
        /// </summary>
        /// <param name="ActivatedOn">ActivatedOn</param>
        /// <param name="BillingCycle">The billing cycle determines the rhythm with which the subscriber is billed. The charging may have different rhythm.</param>
        /// <param name="Comment">The comment allows to provide a internal comment for the version. It helps to document why a product was changed. The comment is not disclosed to the subscriber.</param>
        /// <param name="CreatedOn">CreatedOn</param>
        /// <param name="DefaultCurrency">The default currency has to be used in all fees.</param>
        /// <param name="EnabledCurrencies">The currencies which are enabled can be selected to define component fees. Currencies which are not enabled cannot be used to define fees.</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="IncrementNumber">The increment number represents the version number incremented whenever a new version is activated.</param>
        /// <param name="LinkedSpaceId">The linked space id holds the ID of the space to which the entity belongs to.</param>
        /// <param name="MinimalNumberOfPeriods">The minimal number of periods determines how long the subscription has to run before the subscription can be terminated.</param>
        /// <param name="Name">The product version name is the name of the product which is shown to the user for the version. When the visible product name should be changed for a particular product a new version has to be created which contains the new name of the product.</param>
        /// <param name="NumberOfNoticePeriods">The number of notice periods determines the number of periods which need to be paid between the request to terminate the subscription and the final period.</param>
        /// <param name="ObsoletedOn">ObsoletedOn</param>
        /// <param name="PlannedPurgeDate">The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</param>
        /// <param name="Product">Each product version is linked to a product.</param>
        /// <param name="Reference">The product version reference helps to identify the version. The reference is generated out of the product reference.</param>
        /// <param name="RetiringFinishedOn">RetiringFinishedOn</param>
        /// <param name="RetiringStartedOn">RetiringStartedOn</param>
        /// <param name="State">State</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public SubscriptionProductVersion(DateTime? ActivatedOn = default(DateTime?), string BillingCycle = default(string), string Comment = default(string), DateTime? CreatedOn = default(DateTime?), string DefaultCurrency = default(string), List<string> EnabledCurrencies = default(List<string>), long? Id = default(long?), int? IncrementNumber = default(int?), long? LinkedSpaceId = default(long?), int? MinimalNumberOfPeriods = default(int?), DatabaseTranslatedString Name = default(DatabaseTranslatedString), int? NumberOfNoticePeriods = default(int?), DateTime? ObsoletedOn = default(DateTime?), DateTime? PlannedPurgeDate = default(DateTime?), SubscriptionProduct Product = default(SubscriptionProduct), string Reference = default(string), DateTime? RetiringFinishedOn = default(DateTime?), DateTime? RetiringStartedOn = default(DateTime?), SubscriptionProductVersionState State = default(SubscriptionProductVersionState), int? Version = default(int?))
        {
            this.ActivatedOn = ActivatedOn;
            this.BillingCycle = BillingCycle;
            this.Comment = Comment;
            this.CreatedOn = CreatedOn;
            this.DefaultCurrency = DefaultCurrency;
            this.EnabledCurrencies = EnabledCurrencies;
            this.Id = Id;
            this.IncrementNumber = IncrementNumber;
            this.LinkedSpaceId = LinkedSpaceId;
            this.MinimalNumberOfPeriods = MinimalNumberOfPeriods;
            this.Name = Name;
            this.NumberOfNoticePeriods = NumberOfNoticePeriods;
            this.ObsoletedOn = ObsoletedOn;
            this.PlannedPurgeDate = PlannedPurgeDate;
            this.Product = Product;
            this.Reference = Reference;
            this.RetiringFinishedOn = RetiringFinishedOn;
            this.RetiringStartedOn = RetiringStartedOn;
            this.State = State;
            this.Version = Version;
        }

        /// <summary>
        /// ActivatedOn
        /// </summary>
        /// <value>ActivatedOn</value>
        [DataMember(Name="activatedOn", EmitDefaultValue=false)]
        public DateTime? ActivatedOn { get; set; }

        /// <summary>
        /// The billing cycle determines the rhythm with which the subscriber is billed. The charging may have different rhythm.
        /// </summary>
        /// <value>The billing cycle determines the rhythm with which the subscriber is billed. The charging may have different rhythm.</value>
        [DataMember(Name="billingCycle", EmitDefaultValue=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// The comment allows to provide a internal comment for the version. It helps to document why a product was changed. The comment is not disclosed to the subscriber.
        /// </summary>
        /// <value>The comment allows to provide a internal comment for the version. It helps to document why a product was changed. The comment is not disclosed to the subscriber.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// CreatedOn
        /// </summary>
        /// <value>CreatedOn</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// The default currency has to be used in all fees.
        /// </summary>
        /// <value>The default currency has to be used in all fees.</value>
        [DataMember(Name="defaultCurrency", EmitDefaultValue=false)]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// The currencies which are enabled can be selected to define component fees. Currencies which are not enabled cannot be used to define fees.
        /// </summary>
        /// <value>The currencies which are enabled can be selected to define component fees. Currencies which are not enabled cannot be used to define fees.</value>
        [DataMember(Name="enabledCurrencies", EmitDefaultValue=false)]
        public List<string> EnabledCurrencies { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The increment number represents the version number incremented whenever a new version is activated.
        /// </summary>
        /// <value>The increment number represents the version number incremented whenever a new version is activated.</value>
        [DataMember(Name="incrementNumber", EmitDefaultValue=false)]
        public int? IncrementNumber { get; set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; set; }

        /// <summary>
        /// The minimal number of periods determines how long the subscription has to run before the subscription can be terminated.
        /// </summary>
        /// <value>The minimal number of periods determines how long the subscription has to run before the subscription can be terminated.</value>
        [DataMember(Name="minimalNumberOfPeriods", EmitDefaultValue=false)]
        public int? MinimalNumberOfPeriods { get; set; }

        /// <summary>
        /// The product version name is the name of the product which is shown to the user for the version. When the visible product name should be changed for a particular product a new version has to be created which contains the new name of the product.
        /// </summary>
        /// <value>The product version name is the name of the product which is shown to the user for the version. When the visible product name should be changed for a particular product a new version has to be created which contains the new name of the product.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedString Name { get; set; }

        /// <summary>
        /// The number of notice periods determines the number of periods which need to be paid between the request to terminate the subscription and the final period.
        /// </summary>
        /// <value>The number of notice periods determines the number of periods which need to be paid between the request to terminate the subscription and the final period.</value>
        [DataMember(Name="numberOfNoticePeriods", EmitDefaultValue=false)]
        public int? NumberOfNoticePeriods { get; set; }

        /// <summary>
        /// ObsoletedOn
        /// </summary>
        /// <value>ObsoletedOn</value>
        [DataMember(Name="obsoletedOn", EmitDefaultValue=false)]
        public DateTime? ObsoletedOn { get; set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; set; }

        /// <summary>
        /// Each product version is linked to a product.
        /// </summary>
        /// <value>Each product version is linked to a product.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public SubscriptionProduct Product { get; set; }

        /// <summary>
        /// The product version reference helps to identify the version. The reference is generated out of the product reference.
        /// </summary>
        /// <value>The product version reference helps to identify the version. The reference is generated out of the product reference.</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// RetiringFinishedOn
        /// </summary>
        /// <value>RetiringFinishedOn</value>
        [DataMember(Name="retiringFinishedOn", EmitDefaultValue=false)]
        public DateTime? RetiringFinishedOn { get; set; }

        /// <summary>
        /// RetiringStartedOn
        /// </summary>
        /// <value>RetiringStartedOn</value>
        [DataMember(Name="retiringStartedOn", EmitDefaultValue=false)]
        public DateTime? RetiringStartedOn { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionProductVersionState State { get; set; }

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
            return this.Equals(obj as SubscriptionProductVersion);
        }

        /// <summary>
        /// Returns true if SubscriptionProductVersion instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductVersion other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ActivatedOn == other.ActivatedOn ||
                    this.ActivatedOn != null &&
                    this.ActivatedOn.Equals(other.ActivatedOn)
                ) && 
                (
                    this.BillingCycle == other.BillingCycle ||
                    this.BillingCycle != null &&
                    this.BillingCycle.Equals(other.BillingCycle)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.DefaultCurrency == other.DefaultCurrency ||
                    this.DefaultCurrency != null &&
                    this.DefaultCurrency.Equals(other.DefaultCurrency)
                ) && 
                (
                    this.EnabledCurrencies == other.EnabledCurrencies ||
                    this.EnabledCurrencies != null &&
                    this.EnabledCurrencies.SequenceEqual(other.EnabledCurrencies)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IncrementNumber == other.IncrementNumber ||
                    this.IncrementNumber != null &&
                    this.IncrementNumber.Equals(other.IncrementNumber)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.MinimalNumberOfPeriods == other.MinimalNumberOfPeriods ||
                    this.MinimalNumberOfPeriods != null &&
                    this.MinimalNumberOfPeriods.Equals(other.MinimalNumberOfPeriods)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NumberOfNoticePeriods == other.NumberOfNoticePeriods ||
                    this.NumberOfNoticePeriods != null &&
                    this.NumberOfNoticePeriods.Equals(other.NumberOfNoticePeriods)
                ) && 
                (
                    this.ObsoletedOn == other.ObsoletedOn ||
                    this.ObsoletedOn != null &&
                    this.ObsoletedOn.Equals(other.ObsoletedOn)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.RetiringFinishedOn == other.RetiringFinishedOn ||
                    this.RetiringFinishedOn != null &&
                    this.RetiringFinishedOn.Equals(other.RetiringFinishedOn)
                ) && 
                (
                    this.RetiringStartedOn == other.RetiringStartedOn ||
                    this.RetiringStartedOn != null &&
                    this.RetiringStartedOn.Equals(other.RetiringStartedOn)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.ActivatedOn != null)
                    hash = hash * 59 + this.ActivatedOn.GetHashCode();
                if (this.BillingCycle != null)
                    hash = hash * 59 + this.BillingCycle.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.DefaultCurrency != null)
                    hash = hash * 59 + this.DefaultCurrency.GetHashCode();
                if (this.EnabledCurrencies != null)
                    hash = hash * 59 + this.EnabledCurrencies.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IncrementNumber != null)
                    hash = hash * 59 + this.IncrementNumber.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MinimalNumberOfPeriods != null)
                    hash = hash * 59 + this.MinimalNumberOfPeriods.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NumberOfNoticePeriods != null)
                    hash = hash * 59 + this.NumberOfNoticePeriods.GetHashCode();
                if (this.ObsoletedOn != null)
                    hash = hash * 59 + this.ObsoletedOn.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                if (this.Reference != null)
                    hash = hash * 59 + this.Reference.GetHashCode();
                if (this.RetiringFinishedOn != null)
                    hash = hash * 59 + this.RetiringFinishedOn.GetHashCode();
                if (this.RetiringStartedOn != null)
                    hash = hash * 59 + this.RetiringStartedOn.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
