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
        /// The data collection type specifies how the payment information is collected.
        /// </summary>
        /// <value>The data collection type specifies how the payment information is collected.</value>
        [DataMember(Name="dataCollectionType", EmitDefaultValue=false)]
        public DataCollectionType? DataCollectionType { get; private set; }
        /// <summary>
        /// The one-click payment mode determines whether the customer can save their payment details for later payments.
        /// </summary>
        /// <value>The one-click payment mode determines whether the customer can save their payment details for later payments.</value>
        [DataMember(Name="oneClickPaymentMode", EmitDefaultValue=false)]
        public OneClickPaymentMode? OneClickPaymentMode { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentMethodConfiguration()
        {
        }


        /// <summary>
        /// A custom description for the payment method which is displayed to the customer.
        /// </summary>
        /// <value>A custom description for the payment method which is displayed to the customer.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The resource path to a custom image for the payment method which is displayed to the customer.
        /// </summary>
        /// <value>The resource path to a custom image for the payment method which is displayed to the customer.</value>
        [DataMember(Name="imageResourcePath", EmitDefaultValue=false)]
        public ResourcePath ImageResourcePath { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name used to identify the payment method configuration.
        /// </summary>
        /// <value>The name used to identify the payment method configuration.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }


        /// <summary>
        /// The payment method that the configuration is for.
        /// </summary>
        /// <value>The payment method that the configuration is for.</value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public long? PaymentMethod { get; private set; }

        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The description for the payment method that is actually displayed to the customer. This is either the custom description, if defined, or otherwise the payment method&#39;s default one.
        /// </summary>
        /// <value>The description for the payment method that is actually displayed to the customer. This is either the custom description, if defined, or otherwise the payment method&#39;s default one.</value>
        [DataMember(Name="resolvedDescription", EmitDefaultValue=false)]
        public Dictionary<string, string> ResolvedDescription { get; private set; }

        /// <summary>
        /// The image URL for the payment method that is actually displayed to the customer. This is either the custom image, if defined, or otherwise the payment method&#39;s default one.
        /// </summary>
        /// <value>The image URL for the payment method that is actually displayed to the customer. This is either the custom image, if defined, or otherwise the payment method&#39;s default one.</value>
        [DataMember(Name="resolvedImageUrl", EmitDefaultValue=false)]
        public string ResolvedImageUrl { get; private set; }

        /// <summary>
        /// The title for the payment method that is actually displayed to the customer. This is either the custom title, if defined, or otherwise the payment method&#39;s default one.
        /// </summary>
        /// <value>The title for the payment method that is actually displayed to the customer. This is either the custom title, if defined, or otherwise the payment method&#39;s default one.</value>
        [DataMember(Name="resolvedTitle", EmitDefaultValue=false)]
        public Dictionary<string, string> ResolvedTitle { get; private set; }

        /// <summary>
        /// When listing payment methods, they can be sorted by this number.
        /// </summary>
        /// <value>When listing payment methods, they can be sorted by this number.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="spaceId", EmitDefaultValue=false)]
        public long? SpaceId { get; private set; }


        /// <summary>
        /// A custom title for the payment method which is displayed to the customer.
        /// </summary>
        /// <value>A custom title for the payment method which is displayed to the customer.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public Dictionary<string, string> Title { get; private set; }

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
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
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
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
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
                    input.ResolvedDescription != null &&
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
                    input.ResolvedTitle != null &&
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
                    this.Title != null &&
                    input.Title != null &&
                    this.Title.SequenceEqual(input.Title)
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
