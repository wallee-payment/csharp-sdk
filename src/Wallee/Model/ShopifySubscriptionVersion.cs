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
    /// ShopifySubscriptionVersion
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionVersion :  IEquatable<ShopifySubscriptionVersion>
    {
        /// <summary>
        /// Gets or Sets BillingIntervalUnit
        /// </summary>
        [DataMember(Name="billingIntervalUnit", EmitDefaultValue=true)]
        public ShopifySubscriptionBillingIntervalUnit? BillingIntervalUnit { get; set; }
        /// <summary>
        /// Gets or Sets BillingWeekday
        /// </summary>
        [DataMember(Name="billingWeekday", EmitDefaultValue=true)]
        public ShopifySubscriptionWeekday? BillingWeekday { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public ShopifySubscriptionVersionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifySubscriptionVersion()
        {
        }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name="billingAddress", EmitDefaultValue=true)]
        public ShopifySubscriptionAddress BillingAddress { get; private set; }

        /// <summary>
        /// Gets or Sets BillingDayOfMonth
        /// </summary>
        [DataMember(Name="billingDayOfMonth", EmitDefaultValue=true)]
        public int? BillingDayOfMonth { get; private set; }

        /// <summary>
        /// Gets or Sets BillingIntervalAmount
        /// </summary>
        [DataMember(Name="billingIntervalAmount", EmitDefaultValue=true)]
        public int? BillingIntervalAmount { get; private set; }


        /// <summary>
        /// Gets or Sets BillingReferenceDate
        /// </summary>
        [DataMember(Name="billingReferenceDate", EmitDefaultValue=true)]
        public DateTime? BillingReferenceDate { get; private set; }


        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=true)]
        public long? CreatedBy { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="createdOn", EmitDefaultValue=true)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; private set; }

        /// <summary>
        /// Gets or Sets DischargedBy
        /// </summary>
        [DataMember(Name="dischargedBy", EmitDefaultValue=true)]
        public long? DischargedBy { get; private set; }

        /// <summary>
        /// Gets or Sets DischargedOn
        /// </summary>
        [DataMember(Name="dischargedOn", EmitDefaultValue=true)]
        public DateTime? DischargedOn { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<ShopifySubscriptionVersionItem> Items { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets MaximalBillingCycles
        /// </summary>
        [DataMember(Name="maximalBillingCycles", EmitDefaultValue=true)]
        public int? MaximalBillingCycles { get; private set; }

        /// <summary>
        /// Gets or Sets MaximalSuspendableCycles
        /// </summary>
        [DataMember(Name="maximalSuspendableCycles", EmitDefaultValue=true)]
        public int? MaximalSuspendableCycles { get; private set; }

        /// <summary>
        /// Gets or Sets MinimalBillingCycles
        /// </summary>
        [DataMember(Name="minimalBillingCycles", EmitDefaultValue=true)]
        public int? MinimalBillingCycles { get; private set; }

        /// <summary>
        /// Gets or Sets PaymentGateway
        /// </summary>
        [DataMember(Name="paymentGateway", EmitDefaultValue=true)]
        public string PaymentGateway { get; private set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name="shippingAddress", EmitDefaultValue=true)]
        public ShopifySubscriptionAddress ShippingAddress { get; private set; }

        /// <summary>
        /// Gets or Sets ShippingRate
        /// </summary>
        [DataMember(Name="shippingRate", EmitDefaultValue=true)]
        public string ShippingRate { get; private set; }

        /// <summary>
        /// Gets or Sets Shop
        /// </summary>
        [DataMember(Name="shop", EmitDefaultValue=true)]
        public long? Shop { get; private set; }


        /// <summary>
        /// Gets or Sets StoreOrderConfirmationEmailEnabled
        /// </summary>
        [DataMember(Name="storeOrderConfirmationEmailEnabled", EmitDefaultValue=true)]
        public bool? StoreOrderConfirmationEmailEnabled { get; private set; }

        /// <summary>
        /// Gets or Sets SubscriberSuspensionAllowed
        /// </summary>
        [DataMember(Name="subscriberSuspensionAllowed", EmitDefaultValue=true)]
        public bool? SubscriberSuspensionAllowed { get; private set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name="subscription", EmitDefaultValue=true)]
        public ShopifySubscription Subscription { get; private set; }

        /// <summary>
        /// Gets or Sets TerminationBillingCycles
        /// </summary>
        [DataMember(Name="terminationBillingCycles", EmitDefaultValue=true)]
        public int? TerminationBillingCycles { get; private set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=true)]
        public long? Token { get; private set; }

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
            sb.Append("class ShopifySubscriptionVersion {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  BillingDayOfMonth: ").Append(BillingDayOfMonth).Append("\n");
            sb.Append("  BillingIntervalAmount: ").Append(BillingIntervalAmount).Append("\n");
            sb.Append("  BillingIntervalUnit: ").Append(BillingIntervalUnit).Append("\n");
            sb.Append("  BillingReferenceDate: ").Append(BillingReferenceDate).Append("\n");
            sb.Append("  BillingWeekday: ").Append(BillingWeekday).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DischargedBy: ").Append(DischargedBy).Append("\n");
            sb.Append("  DischargedOn: ").Append(DischargedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MaximalBillingCycles: ").Append(MaximalBillingCycles).Append("\n");
            sb.Append("  MaximalSuspendableCycles: ").Append(MaximalSuspendableCycles).Append("\n");
            sb.Append("  MinimalBillingCycles: ").Append(MinimalBillingCycles).Append("\n");
            sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  ShippingRate: ").Append(ShippingRate).Append("\n");
            sb.Append("  Shop: ").Append(Shop).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StoreOrderConfirmationEmailEnabled: ").Append(StoreOrderConfirmationEmailEnabled).Append("\n");
            sb.Append("  SubscriberSuspensionAllowed: ").Append(SubscriberSuspensionAllowed).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  TerminationBillingCycles: ").Append(TerminationBillingCycles).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as ShopifySubscriptionVersion);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.BillingDayOfMonth == input.BillingDayOfMonth ||
                    (this.BillingDayOfMonth != null &&
                    this.BillingDayOfMonth.Equals(input.BillingDayOfMonth))
                ) && 
                (
                    this.BillingIntervalAmount == input.BillingIntervalAmount ||
                    (this.BillingIntervalAmount != null &&
                    this.BillingIntervalAmount.Equals(input.BillingIntervalAmount))
                ) && 
                (
                    this.BillingIntervalUnit == input.BillingIntervalUnit ||
                    (this.BillingIntervalUnit != null &&
                    this.BillingIntervalUnit.Equals(input.BillingIntervalUnit))
                ) && 
                (
                    this.BillingReferenceDate == input.BillingReferenceDate ||
                    (this.BillingReferenceDate != null &&
                    this.BillingReferenceDate.Equals(input.BillingReferenceDate))
                ) && 
                (
                    this.BillingWeekday == input.BillingWeekday ||
                    (this.BillingWeekday != null &&
                    this.BillingWeekday.Equals(input.BillingWeekday))
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
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.DischargedBy == input.DischargedBy ||
                    (this.DischargedBy != null &&
                    this.DischargedBy.Equals(input.DischargedBy))
                ) && 
                (
                    this.DischargedOn == input.DischargedOn ||
                    (this.DischargedOn != null &&
                    this.DischargedOn.Equals(input.DischargedOn))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.MaximalBillingCycles == input.MaximalBillingCycles ||
                    (this.MaximalBillingCycles != null &&
                    this.MaximalBillingCycles.Equals(input.MaximalBillingCycles))
                ) && 
                (
                    this.MaximalSuspendableCycles == input.MaximalSuspendableCycles ||
                    (this.MaximalSuspendableCycles != null &&
                    this.MaximalSuspendableCycles.Equals(input.MaximalSuspendableCycles))
                ) && 
                (
                    this.MinimalBillingCycles == input.MinimalBillingCycles ||
                    (this.MinimalBillingCycles != null &&
                    this.MinimalBillingCycles.Equals(input.MinimalBillingCycles))
                ) && 
                (
                    this.PaymentGateway == input.PaymentGateway ||
                    (this.PaymentGateway != null &&
                    this.PaymentGateway.Equals(input.PaymentGateway))
                ) && 
                (
                    this.ShippingAddress == input.ShippingAddress ||
                    (this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(input.ShippingAddress))
                ) && 
                (
                    this.ShippingRate == input.ShippingRate ||
                    (this.ShippingRate != null &&
                    this.ShippingRate.Equals(input.ShippingRate))
                ) && 
                (
                    this.Shop == input.Shop ||
                    (this.Shop != null &&
                    this.Shop.Equals(input.Shop))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StoreOrderConfirmationEmailEnabled == input.StoreOrderConfirmationEmailEnabled ||
                    (this.StoreOrderConfirmationEmailEnabled != null &&
                    this.StoreOrderConfirmationEmailEnabled.Equals(input.StoreOrderConfirmationEmailEnabled))
                ) && 
                (
                    this.SubscriberSuspensionAllowed == input.SubscriberSuspensionAllowed ||
                    (this.SubscriberSuspensionAllowed != null &&
                    this.SubscriberSuspensionAllowed.Equals(input.SubscriberSuspensionAllowed))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.TerminationBillingCycles == input.TerminationBillingCycles ||
                    (this.TerminationBillingCycles != null &&
                    this.TerminationBillingCycles.Equals(input.TerminationBillingCycles))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.BillingDayOfMonth != null)
                    hashCode = hashCode * 59 + this.BillingDayOfMonth.GetHashCode();
                if (this.BillingIntervalAmount != null)
                    hashCode = hashCode * 59 + this.BillingIntervalAmount.GetHashCode();
                if (this.BillingIntervalUnit != null)
                    hashCode = hashCode * 59 + this.BillingIntervalUnit.GetHashCode();
                if (this.BillingReferenceDate != null)
                    hashCode = hashCode * 59 + this.BillingReferenceDate.GetHashCode();
                if (this.BillingWeekday != null)
                    hashCode = hashCode * 59 + this.BillingWeekday.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.DischargedBy != null)
                    hashCode = hashCode * 59 + this.DischargedBy.GetHashCode();
                if (this.DischargedOn != null)
                    hashCode = hashCode * 59 + this.DischargedOn.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MaximalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MaximalBillingCycles.GetHashCode();
                if (this.MaximalSuspendableCycles != null)
                    hashCode = hashCode * 59 + this.MaximalSuspendableCycles.GetHashCode();
                if (this.MinimalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MinimalBillingCycles.GetHashCode();
                if (this.PaymentGateway != null)
                    hashCode = hashCode * 59 + this.PaymentGateway.GetHashCode();
                if (this.ShippingAddress != null)
                    hashCode = hashCode * 59 + this.ShippingAddress.GetHashCode();
                if (this.ShippingRate != null)
                    hashCode = hashCode * 59 + this.ShippingRate.GetHashCode();
                if (this.Shop != null)
                    hashCode = hashCode * 59 + this.Shop.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StoreOrderConfirmationEmailEnabled != null)
                    hashCode = hashCode * 59 + this.StoreOrderConfirmationEmailEnabled.GetHashCode();
                if (this.SubscriberSuspensionAllowed != null)
                    hashCode = hashCode * 59 + this.SubscriberSuspensionAllowed.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                if (this.TerminationBillingCycles != null)
                    hashCode = hashCode * 59 + this.TerminationBillingCycles.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
