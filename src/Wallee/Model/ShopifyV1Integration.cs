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
    /// A Shopify Integration allows to connect a Shopify shop.
    /// </summary>
    [DataContract]
    public partial class ShopifyV1Integration :  IEquatable<ShopifyV1Integration>
    {
        /// <summary>
        /// Gets or Sets PaymentAppVersion
        /// </summary>
        [DataMember(Name="paymentAppVersion", EmitDefaultValue=false)]
        public ShopifyIntegrationPaymentAppVersion? PaymentAppVersion { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
        /// <summary>
        /// Gets or Sets SubscriptionAppVersion
        /// </summary>
        [DataMember(Name="subscriptionAppVersion", EmitDefaultValue=false)]
        public ShopifyIntegrationSubscriptionAppVersion? SubscriptionAppVersion { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifyV1Integration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifyV1Integration()
        {
        }

        /// <summary>
        /// Gets or Sets AdditionalLineItemData
        /// </summary>
        [DataMember(Name="additionalLineItemData", EmitDefaultValue=false)]
        public List<ShopifyAdditionalLineItemData> AdditionalLineItemData { get; private set; }

        /// <summary>
        /// Gets or Sets AllowInvoiceDownload
        /// </summary>
        [DataMember(Name="allowInvoiceDownload", EmitDefaultValue=false)]
        public bool? AllowInvoiceDownload { get; private set; }

        /// <summary>
        /// If in the merchant Shopify store is used legacy tax service, rounding discrepancies in line item tax amounts may occur. When this check is enabled, such discrepancies are tolerated, allowing the payment to proceed without raising an exception.
        /// </summary>
        /// <value>If in the merchant Shopify store is used legacy tax service, rounding discrepancies in line item tax amounts may occur. When this check is enabled, such discrepancies are tolerated, allowing the payment to proceed without raising an exception.</value>
        [DataMember(Name="allowPaymentWithTaxDiscrepancy", EmitDefaultValue=false)]
        public bool? AllowPaymentWithTaxDiscrepancy { get; private set; }

        /// <summary>
        /// Gets or Sets AllowedPaymentMethodConfigurations
        /// </summary>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Enabling the integrated payment form will embed the payment form in the Shopify shop. The app needs to be installed for this to be possible.
        /// </summary>
        /// <value>Enabling the integrated payment form will embed the payment form in the Shopify shop. The app needs to be installed for this to be possible.</value>
        [DataMember(Name="integratedPaymentFormEnabled", EmitDefaultValue=false)]
        public bool? IntegratedPaymentFormEnabled { get; private set; }

        /// <summary>
        /// The checkout language forces a specific language in the checkout. Without a checkout language the browser setting of the buyer is used to determine the language.
        /// </summary>
        /// <value>The checkout language forces a specific language in the checkout. Without a checkout language the browser setting of the buyer is used to determine the language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The login name is used to link a specific Shopify payment gateway to this integration.This login name is to be filled into the appropriate field in the shop&#39;s payment gateway configuration.
        /// </summary>
        /// <value>The login name is used to link a specific Shopify payment gateway to this integration.This login name is to be filled into the appropriate field in the shop&#39;s payment gateway configuration.</value>
        [DataMember(Name="loginName", EmitDefaultValue=false)]
        public string LoginName { get; private set; }

        /// <summary>
        /// The integration name is used internally to identify a specific integration.For example the name is used withinsearch fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The integration name is used internally to identify a specific integration.For example the name is used withinsearch fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }


        /// <summary>
        /// Gets or Sets PaymentInstalled
        /// </summary>
        [DataMember(Name="paymentInstalled", EmitDefaultValue=false)]
        public bool? PaymentInstalled { get; private set; }

        /// <summary>
        /// Define the path of the proxy URL. This only needs to be changed if the app&#39;s proxy URL is overwritten in the Shopify store.
        /// </summary>
        /// <value>Define the path of the proxy URL. This only needs to be changed if the app&#39;s proxy URL is overwritten in the Shopify store.</value>
        [DataMember(Name="paymentProxyPath", EmitDefaultValue=false)]
        public string PaymentProxyPath { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets ReplacePaymentMethodImage
        /// </summary>
        [DataMember(Name="replacePaymentMethodImage", EmitDefaultValue=false)]
        public bool? ReplacePaymentMethodImage { get; private set; }

        /// <summary>
        /// The store address is used to link a specific Shopify shop to this integration. This is the name used in the Shopify&#39;s admin URL: [storeAddress].myshopify.com
        /// </summary>
        /// <value>The store address is used to link a specific Shopify shop to this integration. This is the name used in the Shopify&#39;s admin URL: [storeAddress].myshopify.com</value>
        [DataMember(Name="shopName", EmitDefaultValue=false)]
        public string ShopName { get; private set; }

        /// <summary>
        /// Gets or Sets ShowPaymentInformation
        /// </summary>
        [DataMember(Name="showPaymentInformation", EmitDefaultValue=false)]
        public bool? ShowPaymentInformation { get; private set; }

        /// <summary>
        /// Gets or Sets ShowSubscriptionInformation
        /// </summary>
        [DataMember(Name="showSubscriptionInformation", EmitDefaultValue=false)]
        public bool? ShowSubscriptionInformation { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceId
        /// </summary>
        [DataMember(Name="spaceId", EmitDefaultValue=false)]
        public long? SpaceId { get; private set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; private set; }



        /// <summary>
        /// Gets or Sets SubscriptionInstalled
        /// </summary>
        [DataMember(Name="subscriptionInstalled", EmitDefaultValue=false)]
        public bool? SubscriptionInstalled { get; private set; }

        /// <summary>
        /// Define the path of the proxy URL. This only needs to be changed if the app&#39;s proxy URL is overwritten in the Shopify store.
        /// </summary>
        /// <value>Define the path of the proxy URL. This only needs to be changed if the app&#39;s proxy URL is overwritten in the Shopify store.</value>
        [DataMember(Name="subscriptionProxyPath", EmitDefaultValue=false)]
        public string SubscriptionProxyPath { get; private set; }

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
            sb.Append("class ShopifyV1Integration {\n");
            sb.Append("  AdditionalLineItemData: ").Append(AdditionalLineItemData).Append("\n");
            sb.Append("  AllowInvoiceDownload: ").Append(AllowInvoiceDownload).Append("\n");
            sb.Append("  AllowPaymentWithTaxDiscrepancy: ").Append(AllowPaymentWithTaxDiscrepancy).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IntegratedPaymentFormEnabled: ").Append(IntegratedPaymentFormEnabled).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentAppVersion: ").Append(PaymentAppVersion).Append("\n");
            sb.Append("  PaymentInstalled: ").Append(PaymentInstalled).Append("\n");
            sb.Append("  PaymentProxyPath: ").Append(PaymentProxyPath).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ReplacePaymentMethodImage: ").Append(ReplacePaymentMethodImage).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShowPaymentInformation: ").Append(ShowPaymentInformation).Append("\n");
            sb.Append("  ShowSubscriptionInformation: ").Append(ShowSubscriptionInformation).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SubscriptionAppVersion: ").Append(SubscriptionAppVersion).Append("\n");
            sb.Append("  SubscriptionInstalled: ").Append(SubscriptionInstalled).Append("\n");
            sb.Append("  SubscriptionProxyPath: ").Append(SubscriptionProxyPath).Append("\n");
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
            return this.Equals(input as ShopifyV1Integration);
        }

        /// <summary>
        /// Returns true if ShopifyV1Integration instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifyV1Integration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifyV1Integration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalLineItemData == input.AdditionalLineItemData ||
                    this.AdditionalLineItemData != null &&
                    input.AdditionalLineItemData != null &&
                    this.AdditionalLineItemData.SequenceEqual(input.AdditionalLineItemData)
                ) && 
                (
                    this.AllowInvoiceDownload == input.AllowInvoiceDownload ||
                    (this.AllowInvoiceDownload != null &&
                    this.AllowInvoiceDownload.Equals(input.AllowInvoiceDownload))
                ) && 
                (
                    this.AllowPaymentWithTaxDiscrepancy == input.AllowPaymentWithTaxDiscrepancy ||
                    (this.AllowPaymentWithTaxDiscrepancy != null &&
                    this.AllowPaymentWithTaxDiscrepancy.Equals(input.AllowPaymentWithTaxDiscrepancy))
                ) && 
                (
                    this.AllowedPaymentMethodConfigurations == input.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    input.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(input.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IntegratedPaymentFormEnabled == input.IntegratedPaymentFormEnabled ||
                    (this.IntegratedPaymentFormEnabled != null &&
                    this.IntegratedPaymentFormEnabled.Equals(input.IntegratedPaymentFormEnabled))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.LoginName == input.LoginName ||
                    (this.LoginName != null &&
                    this.LoginName.Equals(input.LoginName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PaymentAppVersion == input.PaymentAppVersion ||
                    (this.PaymentAppVersion != null &&
                    this.PaymentAppVersion.Equals(input.PaymentAppVersion))
                ) && 
                (
                    this.PaymentInstalled == input.PaymentInstalled ||
                    (this.PaymentInstalled != null &&
                    this.PaymentInstalled.Equals(input.PaymentInstalled))
                ) && 
                (
                    this.PaymentProxyPath == input.PaymentProxyPath ||
                    (this.PaymentProxyPath != null &&
                    this.PaymentProxyPath.Equals(input.PaymentProxyPath))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.ReplacePaymentMethodImage == input.ReplacePaymentMethodImage ||
                    (this.ReplacePaymentMethodImage != null &&
                    this.ReplacePaymentMethodImage.Equals(input.ReplacePaymentMethodImage))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShowPaymentInformation == input.ShowPaymentInformation ||
                    (this.ShowPaymentInformation != null &&
                    this.ShowPaymentInformation.Equals(input.ShowPaymentInformation))
                ) && 
                (
                    this.ShowSubscriptionInformation == input.ShowSubscriptionInformation ||
                    (this.ShowSubscriptionInformation != null &&
                    this.ShowSubscriptionInformation.Equals(input.ShowSubscriptionInformation))
                ) && 
                (
                    this.SpaceId == input.SpaceId ||
                    (this.SpaceId != null &&
                    this.SpaceId.Equals(input.SpaceId))
                ) && 
                (
                    this.SpaceViewId == input.SpaceViewId ||
                    (this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(input.SpaceViewId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.SubscriptionAppVersion == input.SubscriptionAppVersion ||
                    (this.SubscriptionAppVersion != null &&
                    this.SubscriptionAppVersion.Equals(input.SubscriptionAppVersion))
                ) && 
                (
                    this.SubscriptionInstalled == input.SubscriptionInstalled ||
                    (this.SubscriptionInstalled != null &&
                    this.SubscriptionInstalled.Equals(input.SubscriptionInstalled))
                ) && 
                (
                    this.SubscriptionProxyPath == input.SubscriptionProxyPath ||
                    (this.SubscriptionProxyPath != null &&
                    this.SubscriptionProxyPath.Equals(input.SubscriptionProxyPath))
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
                if (this.AdditionalLineItemData != null)
                    hashCode = hashCode * 59 + this.AdditionalLineItemData.GetHashCode();
                if (this.AllowInvoiceDownload != null)
                    hashCode = hashCode * 59 + this.AllowInvoiceDownload.GetHashCode();
                if (this.AllowPaymentWithTaxDiscrepancy != null)
                    hashCode = hashCode * 59 + this.AllowPaymentWithTaxDiscrepancy.GetHashCode();
                if (this.AllowedPaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IntegratedPaymentFormEnabled != null)
                    hashCode = hashCode * 59 + this.IntegratedPaymentFormEnabled.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LoginName != null)
                    hashCode = hashCode * 59 + this.LoginName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PaymentAppVersion != null)
                    hashCode = hashCode * 59 + this.PaymentAppVersion.GetHashCode();
                if (this.PaymentInstalled != null)
                    hashCode = hashCode * 59 + this.PaymentInstalled.GetHashCode();
                if (this.PaymentProxyPath != null)
                    hashCode = hashCode * 59 + this.PaymentProxyPath.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ReplacePaymentMethodImage != null)
                    hashCode = hashCode * 59 + this.ReplacePaymentMethodImage.GetHashCode();
                if (this.ShopName != null)
                    hashCode = hashCode * 59 + this.ShopName.GetHashCode();
                if (this.ShowPaymentInformation != null)
                    hashCode = hashCode * 59 + this.ShowPaymentInformation.GetHashCode();
                if (this.ShowSubscriptionInformation != null)
                    hashCode = hashCode * 59 + this.ShowSubscriptionInformation.GetHashCode();
                if (this.SpaceId != null)
                    hashCode = hashCode * 59 + this.SpaceId.GetHashCode();
                if (this.SpaceViewId != null)
                    hashCode = hashCode * 59 + this.SpaceViewId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubscriptionAppVersion != null)
                    hashCode = hashCode * 59 + this.SubscriptionAppVersion.GetHashCode();
                if (this.SubscriptionInstalled != null)
                    hashCode = hashCode * 59 + this.SubscriptionInstalled.GetHashCode();
                if (this.SubscriptionProxyPath != null)
                    hashCode = hashCode * 59 + this.SubscriptionProxyPath.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
