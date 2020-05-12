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
        /// Gets or Sets AppVersion
        /// </summary>
        [DataMember(Name="appVersion", EmitDefaultValue=true)]
        public ShopifyIntegrationAppVersion? AppVersion { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopifyIntegration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ShopifyIntegration()
        {
        }

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
        /// Gets or Sets Installed
        /// </summary>
        [DataMember(Name="installed", EmitDefaultValue=true)]
        public bool? Installed { get; private set; }

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
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Define the path of the proxy URL. This only needs to be changed if the apps proxy URL is overwritten in the Shopify store.
        /// </summary>
        /// <value>Define the path of the proxy URL. This only needs to be changed if the apps proxy URL is overwritten in the Shopify store.</value>
        [DataMember(Name="proxyPath", EmitDefaultValue=true)]
        public string ProxyPath { get; private set; }

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
            sb.Append("  AllowInvoiceDownload: ").Append(AllowInvoiceDownload).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Installed: ").Append(Installed).Append("\n");
            sb.Append("  IntegratedPaymentFormEnabled: ").Append(IntegratedPaymentFormEnabled).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProxyPath: ").Append(ProxyPath).Append("\n");
            sb.Append("  ReplacePaymentMethodImage: ").Append(ReplacePaymentMethodImage).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShowPaymentInformation: ").Append(ShowPaymentInformation).Append("\n");
            sb.Append("  ShowSubscriptionInformation: ").Append(ShowSubscriptionInformation).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
                    this.AllowInvoiceDownload == input.AllowInvoiceDownload ||
                    (this.AllowInvoiceDownload != null &&
                    this.AllowInvoiceDownload.Equals(input.AllowInvoiceDownload))
                ) && 
                (
                    this.AllowedPaymentMethodConfigurations == input.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(input.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
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
                    this.Installed == input.Installed ||
                    (this.Installed != null &&
                    this.Installed.Equals(input.Installed))
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
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.ProxyPath == input.ProxyPath ||
                    (this.ProxyPath != null &&
                    this.ProxyPath.Equals(input.ProxyPath))
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
                if (this.AllowInvoiceDownload != null)
                    hashCode = hashCode * 59 + this.AllowInvoiceDownload.GetHashCode();
                if (this.AllowedPaymentMethodConfigurations != null)
                    hashCode = hashCode * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                if (this.AppVersion != null)
                    hashCode = hashCode * 59 + this.AppVersion.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Installed != null)
                    hashCode = hashCode * 59 + this.Installed.GetHashCode();
                if (this.IntegratedPaymentFormEnabled != null)
                    hashCode = hashCode * 59 + this.IntegratedPaymentFormEnabled.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.LoginName != null)
                    hashCode = hashCode * 59 + this.LoginName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ProxyPath != null)
                    hashCode = hashCode * 59 + this.ProxyPath.GetHashCode();
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
