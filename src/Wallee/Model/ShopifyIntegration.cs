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
    public partial class ShopifyIntegration :  IEquatable<ShopifyIntegration>
    {
        /// <summary>
        /// Gets or Sets PaymentAppVersion
        /// </summary>
        [DataMember(Name="paymentAppVersion", EmitDefaultValue=true)]
        public ShopifyIntegrationPaymentAppVersion? PaymentAppVersion { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Gets or Sets SubscriptionAppVersion
        /// </summary>
        [DataMember(Name="subscriptionAppVersion", EmitDefaultValue=true)]
        public ShopifyIntegrationSubscriptionAppVersion? SubscriptionAppVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifyIntegration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifyIntegration()
        {
        }

        /// <summary>
        /// Gets or Sets AdditionalLineItemData
        /// </summary>
        [DataMember(Name="additionalLineItemData", EmitDefaultValue=true)]
        public List<ShopifyAdditionalLineItemData> AdditionalLineItemData { get; private set; }

        /// <summary>
        /// Gets or Sets AllowInvoiceDownload
        /// </summary>
        [DataMember(Name="allowInvoiceDownload", EmitDefaultValue=true)]
        public bool? AllowInvoiceDownload { get; private set; }

        /// <summary>
        /// Gets or Sets AllowedPaymentMethodConfigurations
        /// </summary>
        [DataMember(Name="allowedPaymentMethodConfigurations", EmitDefaultValue=true)]
        public List<PaymentMethodConfiguration> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Enabling the integrated payment form will embed the payment form in the Shopify shop. The app needs to be installed for this to be possible.
        /// </summary>
        /// <value>Enabling the integrated payment form will embed the payment form in the Shopify shop. The app needs to be installed for this to be possible.</value>
        [DataMember(Name="integratedPaymentFormEnabled", EmitDefaultValue=true)]
        public bool? IntegratedPaymentFormEnabled { get; private set; }

        /// <summary>
        /// The checkout language forces a specific language in the checkout. Without a checkout language the browser setting of the buyer is used to determine the language.
        /// </summary>
        /// <value>The checkout language forces a specific language in the checkout. Without a checkout language the browser setting of the buyer is used to determine the language.</value>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; private set; }

        /// <summary>
        /// The login name is used to link a specific Shopify payment gateway to this integration.This login name is to be filled into the appropriate field in the shops payment gateway configuration.
        /// </summary>
        /// <value>The login name is used to link a specific Shopify payment gateway to this integration.This login name is to be filled into the appropriate field in the shops payment gateway configuration.</value>
        [DataMember(Name="loginName", EmitDefaultValue=true)]
        public string LoginName { get; private set; }

        /// <summary>
        /// The integration name is used internally to identify a specific integration.For example the name is used withinsearch fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The integration name is used internally to identify a specific integration.For example the name is used withinsearch fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }


        /// <summary>
        /// Gets or Sets PaymentInstalled
        /// </summary>
        [DataMember(Name="paymentInstalled", EmitDefaultValue=true)]
        public bool? PaymentInstalled { get; private set; }

        /// <summary>
        /// Define the path of the proxy URL. This only needs to be changed if the apps proxy URL is overwritten in the Shopify store.
        /// </summary>
        /// <value>Define the path of the proxy URL. This only needs to be changed if the apps proxy URL is overwritten in the Shopify store.</value>
        [DataMember(Name="paymentProxyPath", EmitDefaultValue=true)]
        public string PaymentProxyPath { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Gets or Sets ReplacePaymentMethodImage
        /// </summary>
        [DataMember(Name="replacePaymentMethodImage", EmitDefaultValue=true)]
        public bool? ReplacePaymentMethodImage { get; private set; }

        /// <summary>
        /// The store address is used to link a specific Shopify shop to this integration. This is the name used in the Shopifys admin URL: [storeAddress].myshopify.com
        /// </summary>
        /// <value>The store address is used to link a specific Shopify shop to this integration. This is the name used in the Shopifys admin URL: [storeAddress].myshopify.com</value>
        [DataMember(Name="shopName", EmitDefaultValue=true)]
        public string ShopName { get; private set; }

        /// <summary>
        /// Gets or Sets ShowPaymentInformation
        /// </summary>
        [DataMember(Name="showPaymentInformation", EmitDefaultValue=true)]
        public bool? ShowPaymentInformation { get; private set; }

        /// <summary>
        /// Gets or Sets ShowSubscriptionInformation
        /// </summary>
        [DataMember(Name="showSubscriptionInformation", EmitDefaultValue=true)]
        public bool? ShowSubscriptionInformation { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceId
        /// </summary>
        [DataMember(Name="spaceId", EmitDefaultValue=true)]
        public long? SpaceId { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceViewId
        /// </summary>
        [DataMember(Name="spaceViewId", EmitDefaultValue=true)]
        public long? SpaceViewId { get; private set; }



        /// <summary>
        /// Gets or Sets SubscriptionInstalled
        /// </summary>
        [DataMember(Name="subscriptionInstalled", EmitDefaultValue=true)]
        public bool? SubscriptionInstalled { get; private set; }

        /// <summary>
        /// Define the path of the proxy URL. This only needs to be changed if the apps proxy URL is overwritten in the Shopify store.
        /// </summary>
        /// <value>Define the path of the proxy URL. This only needs to be changed if the apps proxy URL is overwritten in the Shopify store.</value>
        [DataMember(Name="subscriptionProxyPath", EmitDefaultValue=true)]
        public string SubscriptionProxyPath { get; private set; }

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
            sb.Append("class ShopifyIntegration {\n");
            sb.Append("  AdditionalLineItemData: ").Append(AdditionalLineItemData).Append("\n");
            sb.Append("  AllowInvoiceDownload: ").Append(AllowInvoiceDownload).Append("\n");
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
            return this.Equals(input as ShopifyIntegration);
        }

        /// <summary>
        /// Returns true if ShopifyIntegration instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopifyIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopifyIntegration input)
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
