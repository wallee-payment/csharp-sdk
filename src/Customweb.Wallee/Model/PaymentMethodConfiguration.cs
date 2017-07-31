/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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
    /// The payment method configuration builds the base to connect with different payment method connectors.
    /// </summary>
    [DataContract]
    public partial class PaymentMethodConfiguration :  IEquatable<PaymentMethodConfiguration>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentMethodConfiguration()
        {
        }

        /// <summary>
        /// The data collection type determines who is collecting the payment information. This can be done either by the processor (offsite) or by our application (onsite).
        /// </summary>
        /// <value>The data collection type determines who is collecting the payment information. This can be done either by the processor (offsite) or by our application (onsite).</value>
        [DataMember(Name="dataCollectionType", EmitDefaultValue=false)]
        public DataCollectionType? DataCollectionType { get; private set; }

        /// <summary>
        /// The payment method configuration description can be used to show a text during the payment process. Choose an appropriate description as it will be displayed to your customer.
        /// </summary>
        /// <value>The payment method configuration description can be used to show a text during the payment process. Choose an appropriate description as it will be displayed to your customer.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DatabaseTranslatedString Description { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The image of the payment method configuration overrides the default image of the payment method.
        /// </summary>
        /// <value>The image of the payment method configuration overrides the default image of the payment method.</value>
        [DataMember(Name="imageResourcePath", EmitDefaultValue=false)]
        public ResourcePath ImageResourcePath { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The payment method configuration name is used internally to identify the payment method configuration. For example the name is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The payment method configuration name is used internally to identify the payment method configuration. For example the name is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// When the buyer is present on the payment page or within the iFrame the payment details can be stored automatically. The buyer will be able to use the stored payment details for subsequent transactions. When the transaction already contains a token one-click payments are disabled anyway
        /// </summary>
        /// <value>When the buyer is present on the payment page or within the iFrame the payment details can be stored automatically. The buyer will be able to use the stored payment details for subsequent transactions. When the transaction already contains a token one-click payments are disabled anyway</value>
        [DataMember(Name="oneClickPaymentMode", EmitDefaultValue=false)]
        public OneClickPaymentMode? OneClickPaymentMode { get; private set; }

        /// <summary>
        /// PaymentMethod
        /// </summary>
        /// <value>PaymentMethod</value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public long? PaymentMethod { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The resolved description uses the specified description or the default one when it is not overridden.
        /// </summary>
        /// <value>The resolved description uses the specified description or the default one when it is not overridden.</value>
        [DataMember(Name="resolvedDescription", EmitDefaultValue=false)]
        public Dictionary<string, string> ResolvedDescription { get; private set; }

        /// <summary>
        /// The resolved URL of the image to use with this payment method.
        /// </summary>
        /// <value>The resolved URL of the image to use with this payment method.</value>
        [DataMember(Name="resolvedImageUrl", EmitDefaultValue=false)]
        public string ResolvedImageUrl { get; private set; }

        /// <summary>
        /// The resolved title uses the specified title or the default one when it is not overridden.
        /// </summary>
        /// <value>The resolved title uses the specified title or the default one when it is not overridden.</value>
        [DataMember(Name="resolvedTitle", EmitDefaultValue=false)]
        public Dictionary<string, string> ResolvedTitle { get; private set; }

        /// <summary>
        /// The sort order of the payment method determines the ordering of the methods shown to the user during the payment process.
        /// </summary>
        /// <value>The sort order of the payment method determines the ordering of the methods shown to the user during the payment process.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// SpaceId
        /// </summary>
        /// <value>SpaceId</value>
        [DataMember(Name="spaceId", EmitDefaultValue=false)]
        public long? SpaceId { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

        /// <summary>
        /// The title of the payment method configuration is used within the payment process. The title is visible to the customer.
        /// </summary>
        /// <value>The title of the payment method configuration is used within the payment process. The title is visible to the customer.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public DatabaseTranslatedString Title { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
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
            return this.Equals(obj as PaymentMethodConfiguration);
        }

        /// <summary>
        /// Returns true if PaymentMethodConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentMethodConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodConfiguration other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.DataCollectionType == other.DataCollectionType ||
                    this.DataCollectionType != null &&
                    this.DataCollectionType.Equals(other.DataCollectionType)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ImageResourcePath == other.ImageResourcePath ||
                    this.ImageResourcePath != null &&
                    this.ImageResourcePath.Equals(other.ImageResourcePath)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OneClickPaymentMode == other.OneClickPaymentMode ||
                    this.OneClickPaymentMode != null &&
                    this.OneClickPaymentMode.Equals(other.OneClickPaymentMode)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.ResolvedDescription == other.ResolvedDescription ||
                    this.ResolvedDescription != null &&
                    this.ResolvedDescription.SequenceEqual(other.ResolvedDescription)
                ) && 
                (
                    this.ResolvedImageUrl == other.ResolvedImageUrl ||
                    this.ResolvedImageUrl != null &&
                    this.ResolvedImageUrl.Equals(other.ResolvedImageUrl)
                ) && 
                (
                    this.ResolvedTitle == other.ResolvedTitle ||
                    this.ResolvedTitle != null &&
                    this.ResolvedTitle.SequenceEqual(other.ResolvedTitle)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) && 
                (
                    this.SpaceId == other.SpaceId ||
                    this.SpaceId != null &&
                    this.SpaceId.Equals(other.SpaceId)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
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
                if (this.DataCollectionType != null)
                {
                    hash = hash * 59 + this.DataCollectionType.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.ImageResourcePath != null)
                {
                    hash = hash * 59 + this.ImageResourcePath.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.OneClickPaymentMode != null)
                {
                    hash = hash * 59 + this.OneClickPaymentMode.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.ResolvedDescription != null)
                {
                    hash = hash * 59 + this.ResolvedDescription.GetHashCode();
                }
                if (this.ResolvedImageUrl != null)
                {
                    hash = hash * 59 + this.ResolvedImageUrl.GetHashCode();
                }
                if (this.ResolvedTitle != null)
                {
                    hash = hash * 59 + this.ResolvedTitle.GetHashCode();
                }
                if (this.SortOrder != null)
                {
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                }
                if (this.SpaceId != null)
                {
                    hash = hash * 59 + this.SpaceId.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Title != null)
                {
                    hash = hash * 59 + this.Title.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
