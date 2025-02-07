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
    /// ShopifySubscriptionProduct
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionProduct :  IEquatable<ShopifySubscriptionProduct>
    {
        /// <summary>
        /// Define how frequently recurring orders should be created.
        /// </summary>
        /// <value>Define how frequently recurring orders should be created.</value>
        [DataMember(Name="billingIntervalUnit", EmitDefaultValue=false)]
        public ShopifySubscriptionBillingIntervalUnit? BillingIntervalUnit { get; private set; }
        /// <summary>
        /// Define the weekday on which the recurring orders should be created.
        /// </summary>
        /// <value>Define the weekday on which the recurring orders should be created.</value>
        [DataMember(Name="billingWeekday", EmitDefaultValue=false)]
        public ShopifySubscriptionWeekday? BillingWeekday { get; private set; }
        /// <summary>
        /// Gets or Sets PricingOption
        /// </summary>
        [DataMember(Name="pricingOption", EmitDefaultValue=false)]
        public ShopifySubscriptionProductPricingOption? PricingOption { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public ShopifySubscriptionProductState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionProduct" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifySubscriptionProduct()
        {
        }

        /// <summary>
        /// Gets or Sets AbsolutePriceAdjustment
        /// </summary>
        [DataMember(Name="absolutePriceAdjustment", EmitDefaultValue=false)]
        public decimal? AbsolutePriceAdjustment { get; private set; }

        /// <summary>
        /// Define the day of the month on which the recurring orders should be created.
        /// </summary>
        /// <value>Define the day of the month on which the recurring orders should be created.</value>
        [DataMember(Name="billingDayOfMonth", EmitDefaultValue=false)]
        public int? BillingDayOfMonth { get; private set; }

        /// <summary>
        /// Gets or Sets BillingIntervalAmount
        /// </summary>
        [DataMember(Name="billingIntervalAmount", EmitDefaultValue=false)]
        public int? BillingIntervalAmount { get; private set; }



        /// <summary>
        /// Gets or Sets FixedPrice
        /// </summary>
        [DataMember(Name="fixedPrice", EmitDefaultValue=false)]
        public decimal? FixedPrice { get; private set; }

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
        /// Define the maximum number of orders the subscription will run for.
        /// </summary>
        /// <value>Define the maximum number of orders the subscription will run for.</value>
        [DataMember(Name="maximalBillingCycles", EmitDefaultValue=false)]
        public int? MaximalBillingCycles { get; private set; }

        /// <summary>
        /// Define the maximum number of orders the subscription can be suspended for at a time.
        /// </summary>
        /// <value>Define the maximum number of orders the subscription can be suspended for at a time.</value>
        [DataMember(Name="maximalSuspendableCycles", EmitDefaultValue=false)]
        public int? MaximalSuspendableCycles { get; private set; }

        /// <summary>
        /// Define the minimal number of orders the subscription will run for.
        /// </summary>
        /// <value>Define the minimal number of orders the subscription will run for.</value>
        [DataMember(Name="minimalBillingCycles", EmitDefaultValue=false)]
        public int? MinimalBillingCycles { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }


        /// <summary>
        /// The ID of the Shopify product that is enabled to be ordered as subscription.
        /// </summary>
        /// <value>The ID of the Shopify product that is enabled to be ordered as subscription.</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; private set; }

        /// <summary>
        /// The legacy ID of the Shopify product that is enabled to be ordered as subscription.
        /// </summary>
        /// <value>The legacy ID of the Shopify product that is enabled to be ordered as subscription.</value>
        [DataMember(Name="productLegacyId", EmitDefaultValue=false)]
        public string ProductLegacyId { get; private set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; private set; }

        /// <summary>
        /// Gets or Sets ProductPrice
        /// </summary>
        [DataMember(Name="productPrice", EmitDefaultValue=false)]
        public decimal? ProductPrice { get; private set; }

        /// <summary>
        /// Gets or Sets ProductSku
        /// </summary>
        [DataMember(Name="productSku", EmitDefaultValue=false)]
        public string ProductSku { get; private set; }

        /// <summary>
        /// Gets or Sets ProductVariantId
        /// </summary>
        [DataMember(Name="productVariantId", EmitDefaultValue=false)]
        public string ProductVariantId { get; private set; }

        /// <summary>
        /// Gets or Sets ProductVariantLegacyId
        /// </summary>
        [DataMember(Name="productVariantLegacyId", EmitDefaultValue=false)]
        public string ProductVariantLegacyId { get; private set; }

        /// <summary>
        /// Gets or Sets ProductVariantName
        /// </summary>
        [DataMember(Name="productVariantName", EmitDefaultValue=false)]
        public string ProductVariantName { get; private set; }

        /// <summary>
        /// Gets or Sets RelativePriceAdjustment
        /// </summary>
        [DataMember(Name="relativePriceAdjustment", EmitDefaultValue=false)]
        public decimal? RelativePriceAdjustment { get; private set; }

        /// <summary>
        /// Gets or Sets ShippingRequired
        /// </summary>
        [DataMember(Name="shippingRequired", EmitDefaultValue=false)]
        public bool? ShippingRequired { get; private set; }

        /// <summary>
        /// Gets or Sets Shop
        /// </summary>
        [DataMember(Name="shop", EmitDefaultValue=false)]
        public long? Shop { get; private set; }


        /// <summary>
        /// Gets or Sets StockCheckRequired
        /// </summary>
        [DataMember(Name="stockCheckRequired", EmitDefaultValue=false)]
        public bool? StockCheckRequired { get; private set; }

        /// <summary>
        /// Define whether the order confirmation email of the Shopify shop is sent to the customer for recurring orders.
        /// </summary>
        /// <value>Define whether the order confirmation email of the Shopify shop is sent to the customer for recurring orders.</value>
        [DataMember(Name="storeOrderConfirmationEmailEnabled", EmitDefaultValue=false)]
        public bool? StoreOrderConfirmationEmailEnabled { get; private set; }

        /// <summary>
        /// Define whether the customer is allowed to suspend subscriptions.
        /// </summary>
        /// <value>Define whether the customer is allowed to suspend subscriptions.</value>
        [DataMember(Name="subscriberSuspensionAllowed", EmitDefaultValue=false)]
        public bool? SubscriberSuspensionAllowed { get; private set; }

        /// <summary>
        /// Define the number of orders the subscription will keep running for after its termination has been requested.
        /// </summary>
        /// <value>Define the number of orders the subscription will keep running for after its termination has been requested.</value>
        [DataMember(Name="terminationBillingCycles", EmitDefaultValue=false)]
        public int? TerminationBillingCycles { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; private set; }

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
            sb.Append("class ShopifySubscriptionProduct {\n");
            sb.Append("  AbsolutePriceAdjustment: ").Append(AbsolutePriceAdjustment).Append("\n");
            sb.Append("  BillingDayOfMonth: ").Append(BillingDayOfMonth).Append("\n");
            sb.Append("  BillingIntervalAmount: ").Append(BillingIntervalAmount).Append("\n");
            sb.Append("  BillingIntervalUnit: ").Append(BillingIntervalUnit).Append("\n");
            sb.Append("  BillingWeekday: ").Append(BillingWeekday).Append("\n");
            sb.Append("  FixedPrice: ").Append(FixedPrice).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MaximalBillingCycles: ").Append(MaximalBillingCycles).Append("\n");
            sb.Append("  MaximalSuspendableCycles: ").Append(MaximalSuspendableCycles).Append("\n");
            sb.Append("  MinimalBillingCycles: ").Append(MinimalBillingCycles).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  PricingOption: ").Append(PricingOption).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductLegacyId: ").Append(ProductLegacyId).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductPrice: ").Append(ProductPrice).Append("\n");
            sb.Append("  ProductSku: ").Append(ProductSku).Append("\n");
            sb.Append("  ProductVariantId: ").Append(ProductVariantId).Append("\n");
            sb.Append("  ProductVariantLegacyId: ").Append(ProductVariantLegacyId).Append("\n");
            sb.Append("  ProductVariantName: ").Append(ProductVariantName).Append("\n");
            sb.Append("  RelativePriceAdjustment: ").Append(RelativePriceAdjustment).Append("\n");
            sb.Append("  ShippingRequired: ").Append(ShippingRequired).Append("\n");
            sb.Append("  Shop: ").Append(Shop).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StockCheckRequired: ").Append(StockCheckRequired).Append("\n");
            sb.Append("  StoreOrderConfirmationEmailEnabled: ").Append(StoreOrderConfirmationEmailEnabled).Append("\n");
            sb.Append("  SubscriberSuspensionAllowed: ").Append(SubscriberSuspensionAllowed).Append("\n");
            sb.Append("  TerminationBillingCycles: ").Append(TerminationBillingCycles).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as ShopifySubscriptionProduct);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbsolutePriceAdjustment == input.AbsolutePriceAdjustment ||
                    (this.AbsolutePriceAdjustment != null &&
                    this.AbsolutePriceAdjustment.Equals(input.AbsolutePriceAdjustment))
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
                    this.BillingWeekday == input.BillingWeekday ||
                    (this.BillingWeekday != null &&
                    this.BillingWeekday.Equals(input.BillingWeekday))
                ) && 
                (
                    this.FixedPrice == input.FixedPrice ||
                    (this.FixedPrice != null &&
                    this.FixedPrice.Equals(input.FixedPrice))
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
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.PricingOption == input.PricingOption ||
                    (this.PricingOption != null &&
                    this.PricingOption.Equals(input.PricingOption))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ProductLegacyId == input.ProductLegacyId ||
                    (this.ProductLegacyId != null &&
                    this.ProductLegacyId.Equals(input.ProductLegacyId))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.ProductPrice == input.ProductPrice ||
                    (this.ProductPrice != null &&
                    this.ProductPrice.Equals(input.ProductPrice))
                ) && 
                (
                    this.ProductSku == input.ProductSku ||
                    (this.ProductSku != null &&
                    this.ProductSku.Equals(input.ProductSku))
                ) && 
                (
                    this.ProductVariantId == input.ProductVariantId ||
                    (this.ProductVariantId != null &&
                    this.ProductVariantId.Equals(input.ProductVariantId))
                ) && 
                (
                    this.ProductVariantLegacyId == input.ProductVariantLegacyId ||
                    (this.ProductVariantLegacyId != null &&
                    this.ProductVariantLegacyId.Equals(input.ProductVariantLegacyId))
                ) && 
                (
                    this.ProductVariantName == input.ProductVariantName ||
                    (this.ProductVariantName != null &&
                    this.ProductVariantName.Equals(input.ProductVariantName))
                ) && 
                (
                    this.RelativePriceAdjustment == input.RelativePriceAdjustment ||
                    (this.RelativePriceAdjustment != null &&
                    this.RelativePriceAdjustment.Equals(input.RelativePriceAdjustment))
                ) && 
                (
                    this.ShippingRequired == input.ShippingRequired ||
                    (this.ShippingRequired != null &&
                    this.ShippingRequired.Equals(input.ShippingRequired))
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
                    this.StockCheckRequired == input.StockCheckRequired ||
                    (this.StockCheckRequired != null &&
                    this.StockCheckRequired.Equals(input.StockCheckRequired))
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
                    this.TerminationBillingCycles == input.TerminationBillingCycles ||
                    (this.TerminationBillingCycles != null &&
                    this.TerminationBillingCycles.Equals(input.TerminationBillingCycles))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.AbsolutePriceAdjustment != null)
                    hashCode = hashCode * 59 + this.AbsolutePriceAdjustment.GetHashCode();
                if (this.BillingDayOfMonth != null)
                    hashCode = hashCode * 59 + this.BillingDayOfMonth.GetHashCode();
                if (this.BillingIntervalAmount != null)
                    hashCode = hashCode * 59 + this.BillingIntervalAmount.GetHashCode();
                if (this.BillingIntervalUnit != null)
                    hashCode = hashCode * 59 + this.BillingIntervalUnit.GetHashCode();
                if (this.BillingWeekday != null)
                    hashCode = hashCode * 59 + this.BillingWeekday.GetHashCode();
                if (this.FixedPrice != null)
                    hashCode = hashCode * 59 + this.FixedPrice.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.MaximalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MaximalBillingCycles.GetHashCode();
                if (this.MaximalSuspendableCycles != null)
                    hashCode = hashCode * 59 + this.MaximalSuspendableCycles.GetHashCode();
                if (this.MinimalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MinimalBillingCycles.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.PricingOption != null)
                    hashCode = hashCode * 59 + this.PricingOption.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductLegacyId != null)
                    hashCode = hashCode * 59 + this.ProductLegacyId.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ProductPrice != null)
                    hashCode = hashCode * 59 + this.ProductPrice.GetHashCode();
                if (this.ProductSku != null)
                    hashCode = hashCode * 59 + this.ProductSku.GetHashCode();
                if (this.ProductVariantId != null)
                    hashCode = hashCode * 59 + this.ProductVariantId.GetHashCode();
                if (this.ProductVariantLegacyId != null)
                    hashCode = hashCode * 59 + this.ProductVariantLegacyId.GetHashCode();
                if (this.ProductVariantName != null)
                    hashCode = hashCode * 59 + this.ProductVariantName.GetHashCode();
                if (this.RelativePriceAdjustment != null)
                    hashCode = hashCode * 59 + this.RelativePriceAdjustment.GetHashCode();
                if (this.ShippingRequired != null)
                    hashCode = hashCode * 59 + this.ShippingRequired.GetHashCode();
                if (this.Shop != null)
                    hashCode = hashCode * 59 + this.Shop.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StockCheckRequired != null)
                    hashCode = hashCode * 59 + this.StockCheckRequired.GetHashCode();
                if (this.StoreOrderConfirmationEmailEnabled != null)
                    hashCode = hashCode * 59 + this.StoreOrderConfirmationEmailEnabled.GetHashCode();
                if (this.SubscriberSuspensionAllowed != null)
                    hashCode = hashCode * 59 + this.SubscriberSuspensionAllowed.GetHashCode();
                if (this.TerminationBillingCycles != null)
                    hashCode = hashCode * 59 + this.TerminationBillingCycles.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
