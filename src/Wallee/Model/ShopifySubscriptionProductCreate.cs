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
    /// ShopifySubscriptionProductCreate
    /// </summary>
    [DataContract]
    public partial class ShopifySubscriptionProductCreate : AbstractShopifySubscriptionProductUpdate,  IEquatable<ShopifySubscriptionProductCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionProductCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShopifySubscriptionProductCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifySubscriptionProductCreate" /> class.
        /// </summary>
        /// <param name="shop">shop (required).</param>
        /// <param name="productVariantId">productVariantId (required).</param>
        /// <param name="productId">The ID of the Shopify product that is enabled to be ordered as subscription. (required).</param>
        public ShopifySubscriptionProductCreate(long? shop, string productVariantId, string productId)
        {
            // to ensure "shop" is required (not null)
            if (shop == null)
            {
                throw new InvalidDataException("shop is a required property for ShopifySubscriptionProductCreate and cannot be null");
            }
            this.Shop = shop;
            // to ensure "productVariantId" is required (not null)
            if (productVariantId == null)
            {
                throw new InvalidDataException("productVariantId is a required property for ShopifySubscriptionProductCreate and cannot be null");
            }
            this.ProductVariantId = productVariantId;
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for ShopifySubscriptionProductCreate and cannot be null");
            }
            this.ProductId = productId;
        }















        /// <summary>
        /// The ID of the Shopify product that is enabled to be ordered as subscription.
        /// </summary>
        /// <value>The ID of the Shopify product that is enabled to be ordered as subscription.</value>
        [DataMember(Name="productId", EmitDefaultValue=true)]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or Sets ProductVariantId
        /// </summary>
        [DataMember(Name="productVariantId", EmitDefaultValue=true)]
        public string ProductVariantId { get; set; }

        /// <summary>
        /// Gets or Sets Shop
        /// </summary>
        [DataMember(Name="shop", EmitDefaultValue=true)]
        public long? Shop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShopifySubscriptionProductCreate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AbsolutePriceAdjustment: ").Append(AbsolutePriceAdjustment).Append("\n");
            sb.Append("  BillingDayOfMonth: ").Append(BillingDayOfMonth).Append("\n");
            sb.Append("  BillingIntervalAmount: ").Append(BillingIntervalAmount).Append("\n");
            sb.Append("  BillingIntervalUnit: ").Append(BillingIntervalUnit).Append("\n");
            sb.Append("  BillingWeekday: ").Append(BillingWeekday).Append("\n");
            sb.Append("  FixedPrice: ").Append(FixedPrice).Append("\n");
            sb.Append("  MaximalBillingCycles: ").Append(MaximalBillingCycles).Append("\n");
            sb.Append("  MaximalSuspendableCycles: ").Append(MaximalSuspendableCycles).Append("\n");
            sb.Append("  MinimalBillingCycles: ").Append(MinimalBillingCycles).Append("\n");
            sb.Append("  PricingOption: ").Append(PricingOption).Append("\n");
            sb.Append("  RelativePriceAdjustment: ").Append(RelativePriceAdjustment).Append("\n");
            sb.Append("  StoreOrderConfirmationEmailEnabled: ").Append(StoreOrderConfirmationEmailEnabled).Append("\n");
            sb.Append("  SubscriberSuspensionAllowed: ").Append(SubscriberSuspensionAllowed).Append("\n");
            sb.Append("  TerminationBillingCycles: ").Append(TerminationBillingCycles).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductVariantId: ").Append(ProductVariantId).Append("\n");
            sb.Append("  Shop: ").Append(Shop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ShopifySubscriptionProductCreate);
        }

        /// <summary>
        /// Returns true if ShopifySubscriptionProductCreate instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifySubscriptionProductCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifySubscriptionProductCreate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AbsolutePriceAdjustment == input.AbsolutePriceAdjustment ||
                    (this.AbsolutePriceAdjustment != null &&
                    this.AbsolutePriceAdjustment.Equals(input.AbsolutePriceAdjustment))
                ) && base.Equals(input) && 
                (
                    this.BillingDayOfMonth == input.BillingDayOfMonth ||
                    (this.BillingDayOfMonth != null &&
                    this.BillingDayOfMonth.Equals(input.BillingDayOfMonth))
                ) && base.Equals(input) && 
                (
                    this.BillingIntervalAmount == input.BillingIntervalAmount ||
                    (this.BillingIntervalAmount != null &&
                    this.BillingIntervalAmount.Equals(input.BillingIntervalAmount))
                ) && base.Equals(input) && 
                (
                    this.BillingIntervalUnit == input.BillingIntervalUnit ||
                    (this.BillingIntervalUnit != null &&
                    this.BillingIntervalUnit.Equals(input.BillingIntervalUnit))
                ) && base.Equals(input) && 
                (
                    this.BillingWeekday == input.BillingWeekday ||
                    (this.BillingWeekday != null &&
                    this.BillingWeekday.Equals(input.BillingWeekday))
                ) && base.Equals(input) && 
                (
                    this.FixedPrice == input.FixedPrice ||
                    (this.FixedPrice != null &&
                    this.FixedPrice.Equals(input.FixedPrice))
                ) && base.Equals(input) && 
                (
                    this.MaximalBillingCycles == input.MaximalBillingCycles ||
                    (this.MaximalBillingCycles != null &&
                    this.MaximalBillingCycles.Equals(input.MaximalBillingCycles))
                ) && base.Equals(input) && 
                (
                    this.MaximalSuspendableCycles == input.MaximalSuspendableCycles ||
                    (this.MaximalSuspendableCycles != null &&
                    this.MaximalSuspendableCycles.Equals(input.MaximalSuspendableCycles))
                ) && base.Equals(input) && 
                (
                    this.MinimalBillingCycles == input.MinimalBillingCycles ||
                    (this.MinimalBillingCycles != null &&
                    this.MinimalBillingCycles.Equals(input.MinimalBillingCycles))
                ) && base.Equals(input) && 
                (
                    this.PricingOption == input.PricingOption ||
                    (this.PricingOption != null &&
                    this.PricingOption.Equals(input.PricingOption))
                ) && base.Equals(input) && 
                (
                    this.RelativePriceAdjustment == input.RelativePriceAdjustment ||
                    (this.RelativePriceAdjustment != null &&
                    this.RelativePriceAdjustment.Equals(input.RelativePriceAdjustment))
                ) && base.Equals(input) && 
                (
                    this.StoreOrderConfirmationEmailEnabled == input.StoreOrderConfirmationEmailEnabled ||
                    (this.StoreOrderConfirmationEmailEnabled != null &&
                    this.StoreOrderConfirmationEmailEnabled.Equals(input.StoreOrderConfirmationEmailEnabled))
                ) && base.Equals(input) && 
                (
                    this.SubscriberSuspensionAllowed == input.SubscriberSuspensionAllowed ||
                    (this.SubscriberSuspensionAllowed != null &&
                    this.SubscriberSuspensionAllowed.Equals(input.SubscriberSuspensionAllowed))
                ) && base.Equals(input) && 
                (
                    this.TerminationBillingCycles == input.TerminationBillingCycles ||
                    (this.TerminationBillingCycles != null &&
                    this.TerminationBillingCycles.Equals(input.TerminationBillingCycles))
                ) && base.Equals(input) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && base.Equals(input) && 
                (
                    this.ProductVariantId == input.ProductVariantId ||
                    (this.ProductVariantId != null &&
                    this.ProductVariantId.Equals(input.ProductVariantId))
                ) && base.Equals(input) && 
                (
                    this.Shop == input.Shop ||
                    (this.Shop != null &&
                    this.Shop.Equals(input.Shop))
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
                int hashCode = base.GetHashCode();
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
                if (this.MaximalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MaximalBillingCycles.GetHashCode();
                if (this.MaximalSuspendableCycles != null)
                    hashCode = hashCode * 59 + this.MaximalSuspendableCycles.GetHashCode();
                if (this.MinimalBillingCycles != null)
                    hashCode = hashCode * 59 + this.MinimalBillingCycles.GetHashCode();
                if (this.PricingOption != null)
                    hashCode = hashCode * 59 + this.PricingOption.GetHashCode();
                if (this.RelativePriceAdjustment != null)
                    hashCode = hashCode * 59 + this.RelativePriceAdjustment.GetHashCode();
                if (this.StoreOrderConfirmationEmailEnabled != null)
                    hashCode = hashCode * 59 + this.StoreOrderConfirmationEmailEnabled.GetHashCode();
                if (this.SubscriberSuspensionAllowed != null)
                    hashCode = hashCode * 59 + this.SubscriberSuspensionAllowed.GetHashCode();
                if (this.TerminationBillingCycles != null)
                    hashCode = hashCode * 59 + this.TerminationBillingCycles.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductVariantId != null)
                    hashCode = hashCode * 59 + this.ProductVariantId.GetHashCode();
                if (this.Shop != null)
                    hashCode = hashCode * 59 + this.Shop.GetHashCode();
                return hashCode;
            }
        }

    }

}
