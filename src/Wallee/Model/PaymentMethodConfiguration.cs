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
    /// The payment method configuration builds the base to connect with different payment method connectors.
    /// </summary>
    [DataContract]
    public partial class PaymentMethodConfiguration :  IEquatable<PaymentMethodConfiguration>
    {
        /// <summary>
        /// The data collection type determines who is collecting the payment information. This can be done either by the processor (offsite) or by our application (onsite).
        /// </summary>
        /// <value>The data collection type determines who is collecting the payment information. This can be done either by the processor (offsite) or by our application (onsite).</value>
        [DataMember(Name="dataCollectionType", EmitDefaultValue=true)]
        public DataCollectionType? DataCollectionType { get; set; }
        /// <summary>
        /// When the buyer is present on the payment page or within the iFrame the payment details can be stored automatically. The buyer will be able to use the stored payment details for subsequent transactions. When the transaction already contains a token one-click payments are disabled anyway
        /// </summary>
        /// <value>When the buyer is present on the payment page or within the iFrame the payment details can be stored automatically. The buyer will be able to use the stored payment details for subsequent transactions. When the transaction already contains a token one-click payments are disabled anyway</value>
        [DataMember(Name="oneClickPaymentMode", EmitDefaultValue=true)]
        public OneClickPaymentMode? OneClickPaymentMode { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=true)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentMethodConfiguration()
        {
        }


        /// <summary>
        /// The payment method configuration description can be used to show a text during the payment process. Choose an appropriate description as it will be displayed to your customer.
        /// </summary>
        /// <value>The payment method configuration description can be used to show a text during the payment process. Choose an appropriate description as it will be displayed to your customer.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public DatabaseTranslatedString Description { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// The image of the payment method configuration overrides the default image of the payment method.
        /// </summary>
        /// <value>The image of the payment method configuration overrides the default image of the payment method.</value>
        [DataMember(Name="imageResourcePath", EmitDefaultValue=true)]
        public ResourcePath ImageResourcePath { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=true)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The payment method configuration name is used internally to identify the payment method configuration. For example the name is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The payment method configuration name is used internally to identify the payment method configuration. For example the name is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; private set; }


        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=true)]
        public long? PaymentMethod { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=true)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The resolved description uses the specified description or the default one when it is not overridden.
        /// </summary>
        /// <value>The resolved description uses the specified description or the default one when it is not overridden.</value>
        [DataMember(Name="resolvedDescription", EmitDefaultValue=true)]
        public Dictionary<string, string> ResolvedDescription { get; private set; }

        /// <summary>
        /// The resolved URL of the image to use with this payment method.
        /// </summary>
        /// <value>The resolved URL of the image to use with this payment method.</value>
        [DataMember(Name="resolvedImageUrl", EmitDefaultValue=true)]
        public string ResolvedImageUrl { get; private set; }

        /// <summary>
        /// The resolved title uses the specified title or the default one when it is not overridden.
        /// </summary>
        /// <value>The resolved title uses the specified title or the default one when it is not overridden.</value>
        [DataMember(Name="resolvedTitle", EmitDefaultValue=true)]
        public Dictionary<string, string> ResolvedTitle { get; private set; }

        /// <summary>
        /// The sort order of the payment method determines the ordering of the methods shown to the user during the payment process.
        /// </summary>
        /// <value>The sort order of the payment method determines the ordering of the methods shown to the user during the payment process.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=true)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// Gets or Sets SpaceId
        /// </summary>
        [DataMember(Name="spaceId", EmitDefaultValue=true)]
        public long? SpaceId { get; private set; }


        /// <summary>
        /// The title of the payment method configuration is used within the payment process. The title is visible to the customer.
        /// </summary>
        /// <value>The title of the payment method configuration is used within the payment process. The title is visible to the customer.</value>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public DatabaseTranslatedString Title { get; private set; }

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
            sb.Append("class PaymentMethodConfiguration {\n");
            sb.Append("  DataCollectionType: ").Append(DataCollectionType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageResourcePath: ").Append(ImageResourcePath).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OneClickPaymentMode: ").Append(OneClickPaymentMode).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ResolvedDescription: ").Append(ResolvedDescription).Append("\n");
            sb.Append("  ResolvedImageUrl: ").Append(ResolvedImageUrl).Append("\n");
            sb.Append("  ResolvedTitle: ").Append(ResolvedTitle).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as PaymentMethodConfiguration);
        }

        /// <summary>
        /// Returns true if PaymentMethodConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataCollectionType == input.DataCollectionType ||
                    (this.DataCollectionType != null &&
                    this.DataCollectionType.Equals(input.DataCollectionType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImageResourcePath == input.ImageResourcePath ||
                    (this.ImageResourcePath != null &&
                    this.ImageResourcePath.Equals(input.ImageResourcePath))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OneClickPaymentMode == input.OneClickPaymentMode ||
                    (this.OneClickPaymentMode != null &&
                    this.OneClickPaymentMode.Equals(input.OneClickPaymentMode))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.PlannedPurgeDate == input.PlannedPurgeDate ||
                    (this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(input.PlannedPurgeDate))
                ) && 
                (
                    this.ResolvedDescription == input.ResolvedDescription ||
                    this.ResolvedDescription != null &&
                    this.ResolvedDescription.SequenceEqual(input.ResolvedDescription)
                ) && 
                (
                    this.ResolvedImageUrl == input.ResolvedImageUrl ||
                    (this.ResolvedImageUrl != null &&
                    this.ResolvedImageUrl.Equals(input.ResolvedImageUrl))
                ) && 
                (
                    this.ResolvedTitle == input.ResolvedTitle ||
                    this.ResolvedTitle != null &&
                    this.ResolvedTitle.SequenceEqual(input.ResolvedTitle)
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.SpaceId == input.SpaceId ||
                    (this.SpaceId != null &&
                    this.SpaceId.Equals(input.SpaceId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.DataCollectionType != null)
                    hashCode = hashCode * 59 + this.DataCollectionType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageResourcePath != null)
                    hashCode = hashCode * 59 + this.ImageResourcePath.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OneClickPaymentMode != null)
                    hashCode = hashCode * 59 + this.OneClickPaymentMode.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.PlannedPurgeDate != null)
                    hashCode = hashCode * 59 + this.PlannedPurgeDate.GetHashCode();
                if (this.ResolvedDescription != null)
                    hashCode = hashCode * 59 + this.ResolvedDescription.GetHashCode();
                if (this.ResolvedImageUrl != null)
                    hashCode = hashCode * 59 + this.ResolvedImageUrl.GetHashCode();
                if (this.ResolvedTitle != null)
                    hashCode = hashCode * 59 + this.ResolvedTitle.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.SpaceId != null)
                    hashCode = hashCode * 59 + this.SpaceId.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
