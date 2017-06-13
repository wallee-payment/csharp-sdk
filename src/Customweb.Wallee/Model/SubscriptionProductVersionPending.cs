
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
    /// SubscriptionProductVersionPending model.
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductVersionPending :  IEquatable<SubscriptionProductVersionPending>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionPending" /> class.
        /// </summary>
        /// <param name="BillingCycle">The billing cycle determines the rhythm with which the subscriber is billed. The charging may have different rhythm.</param>
        /// <param name="Comment">The comment allows to provide a internal comment for the version. It helps to document why a product was changed. The comment is not disclosed to the subscriber.</param>
        /// <param name="DefaultCurrency">The default currency has to be used in all fees.</param>
        /// <param name="EnabledCurrencies">The currencies which are enabled can be selected to define component fees. Currencies which are not enabled cannot be used to define fees.</param>
        /// <param name="MinimalNumberOfPeriods">The minimal number of periods determines how long the subscription has to run before the subscription can be terminated.</param>
        /// <param name="Name">The product version name is the name of the product which is shown to the user for the version. When the visible product name should be changed for a particular product a new version has to be created which contains the new name of the product.</param>
        /// <param name="NumberOfNoticePeriods">The number of notice periods determines the number of periods which need to be paid between the request to terminate the subscription and the final period.</param>
        /// <param name="Product">Each product version is linked to a product.</param>
        /// <param name="State">State</param>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely.</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</param>
        public SubscriptionProductVersionPending(string BillingCycle = default(string), string Comment = default(string), string DefaultCurrency = default(string), List<string> EnabledCurrencies = default(List<string>), int? MinimalNumberOfPeriods = default(int?), long? Name = default(long?), int? NumberOfNoticePeriods = default(int?), long? Product = default(long?), SubscriptionProductVersionState State = default(SubscriptionProductVersionState), long? Id = default(long?), long? Version = default(long?))
        {
            this.BillingCycle = BillingCycle;
            this.Comment = Comment;
            this.DefaultCurrency = DefaultCurrency;
            this.EnabledCurrencies = EnabledCurrencies;
            this.MinimalNumberOfPeriods = MinimalNumberOfPeriods;
            this.Name = Name;
            this.NumberOfNoticePeriods = NumberOfNoticePeriods;
            this.Product = Product;
            this.State = State;
            this.Id = Id;
            this.Version = Version;
        }

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
        public long? Name { get; set; }

        /// <summary>
        /// The number of notice periods determines the number of periods which need to be paid between the request to terminate the subscription and the final period.
        /// </summary>
        /// <value>The number of notice periods determines the number of periods which need to be paid between the request to terminate the subscription and the final period.</value>
        [DataMember(Name="numberOfNoticePeriods", EmitDefaultValue=false)]
        public int? NumberOfNoticePeriods { get; set; }

        /// <summary>
        /// Each product version is linked to a product.
        /// </summary>
        /// <value>Each product version is linked to a product.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public long? Product { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionProductVersionState State { get; set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductVersionPending {\n");
            sb.Append("  BillingCycle: ").Append(BillingCycle).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  EnabledCurrencies: ").Append(EnabledCurrencies).Append("\n");
            sb.Append("  MinimalNumberOfPeriods: ").Append(MinimalNumberOfPeriods).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfNoticePeriods: ").Append(NumberOfNoticePeriods).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as SubscriptionProductVersionPending);
        }

        /// <summary>
        /// Returns true if SubscriptionProductVersionPending instances are equal
        /// </summary>
        /// <param name="other">Instance of SubscriptionProductVersionPending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductVersionPending other)
        {
            if (other == null)
            {
                return false;
            }

            return 
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
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.BillingCycle != null)
                    hash = hash * 59 + this.BillingCycle.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.DefaultCurrency != null)
                    hash = hash * 59 + this.DefaultCurrency.GetHashCode();
                if (this.EnabledCurrencies != null)
                    hash = hash * 59 + this.EnabledCurrencies.GetHashCode();
                if (this.MinimalNumberOfPeriods != null)
                    hash = hash * 59 + this.MinimalNumberOfPeriods.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NumberOfNoticePeriods != null)
                    hash = hash * 59 + this.NumberOfNoticePeriods.GetHashCode();
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                return hash;
            }
        }

    }

}
