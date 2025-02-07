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
    /// SubscriptionProductVersionPending
    /// </summary>
    [DataContract]
    public partial class SubscriptionProductVersionPending :  IEquatable<SubscriptionProductVersionPending>
    {
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public SubscriptionProductVersionState? State { get; set; }
        /// <summary>
        /// The way taxes are calculated for fees.
        /// </summary>
        /// <value>The way taxes are calculated for fees.</value>
        [DataMember(Name="taxCalculation", EmitDefaultValue=false)]
        public TaxCalculation? TaxCalculation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionPending" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionProductVersionPending() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductVersionPending" /> class.
        /// </summary>
        /// <param name="id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required).</param>
        /// <param name="version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public SubscriptionProductVersionPending(long? id, long? version)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SubscriptionProductVersionPending and cannot be null");
            }
            this.Id = id;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for SubscriptionProductVersionPending and cannot be null");
            }
            this.Version = version;
        }

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
        /// The recurring period of time, typically monthly or annually, for which a subscriber is charged.
        /// </summary>
        /// <value>The recurring period of time, typically monthly or annually, for which a subscriber is charged.</value>
        [DataMember(Name="billingCycle", EmitDefaultValue=false)]
        public string BillingCycle { get; set; }

        /// <summary>
        /// A comment that describes the product version and why it was created. It is not disclosed to the subscriber.
        /// </summary>
        /// <value>A comment that describes the product version and why it was created. It is not disclosed to the subscriber.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the product version&#39;s default currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the product version&#39;s default currency.</value>
        [DataMember(Name="defaultCurrency", EmitDefaultValue=false)]
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// The three-letter codes (ISO 4217 format) of the currencies that the product version supports.
        /// </summary>
        /// <value>The three-letter codes (ISO 4217 format) of the currencies that the product version supports.</value>
        [DataMember(Name="enabledCurrencies", EmitDefaultValue=false)]
        public List<string> EnabledCurrencies { get; set; }

        /// <summary>
        /// The minimum number of periods the subscription will run before it can be terminated.
        /// </summary>
        /// <value>The minimum number of periods the subscription will run before it can be terminated.</value>
        [DataMember(Name="minimalNumberOfPeriods", EmitDefaultValue=false)]
        public int? MinimalNumberOfPeriods { get; set; }

        /// <summary>
        /// The localized name of the product that is displayed to the customer.
        /// </summary>
        /// <value>The localized name of the product that is displayed to the customer.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// The number of periods the subscription will keep running after its termination was requested.
        /// </summary>
        /// <value>The number of periods the subscription will keep running after its termination was requested.</value>
        [DataMember(Name="numberOfNoticePeriods", EmitDefaultValue=false)]
        public int? NumberOfNoticePeriods { get; set; }

        /// <summary>
        /// The product that the version belongs to.
        /// </summary>
        /// <value>The product that the version belongs to.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public long? Product { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionProductVersionPending {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  BillingCycle: ").Append(BillingCycle).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  EnabledCurrencies: ").Append(EnabledCurrencies).Append("\n");
            sb.Append("  MinimalNumberOfPeriods: ").Append(MinimalNumberOfPeriods).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfNoticePeriods: ").Append(NumberOfNoticePeriods).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TaxCalculation: ").Append(TaxCalculation).Append("\n");
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
            return this.Equals(input as SubscriptionProductVersionPending);
        }

        /// <summary>
        /// Returns true if SubscriptionProductVersionPending instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionProductVersionPending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionProductVersionPending input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                    this.MinimalNumberOfPeriods == input.MinimalNumberOfPeriods ||
                    (this.MinimalNumberOfPeriods != null &&
                    this.MinimalNumberOfPeriods.Equals(input.MinimalNumberOfPeriods))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.NumberOfNoticePeriods == input.NumberOfNoticePeriods ||
                    (this.NumberOfNoticePeriods != null &&
                    this.NumberOfNoticePeriods.Equals(input.NumberOfNoticePeriods))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.BillingCycle != null)
                    hashCode = hashCode * 59 + this.BillingCycle.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.DefaultCurrency != null)
                    hashCode = hashCode * 59 + this.DefaultCurrency.GetHashCode();
                if (this.EnabledCurrencies != null)
                    hashCode = hashCode * 59 + this.EnabledCurrencies.GetHashCode();
                if (this.MinimalNumberOfPeriods != null)
                    hashCode = hashCode * 59 + this.MinimalNumberOfPeriods.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumberOfNoticePeriods != null)
                    hashCode = hashCode * 59 + this.NumberOfNoticePeriods.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TaxCalculation != null)
                    hashCode = hashCode * 59 + this.TaxCalculation.GetHashCode();
                return hashCode;
            }
        }

    }

}
