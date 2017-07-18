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
    /// A subscriber represents everyone who is subscribed to a product.
    /// </summary>
    [DataContract]
    public partial class Subscriber :  IEquatable<Subscriber>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscriber" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Subscriber()
        {
        }

        /// <summary>
        /// Those payment methods which are allowed additionally will be available even when the product does not allow those methods.
        /// </summary>
        /// <value>Those payment methods which are allowed additionally will be available even when the product does not allow those methods.</value>
        [DataMember(Name="additionalAllowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> AdditionalAllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// BillingAddress
        /// </summary>
        /// <value>BillingAddress</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; private set; }

        /// <summary>
        /// The subscriber description can be used to add a description to the subscriber. This is used in the back office to identify the subscriber.
        /// </summary>
        /// <value>The subscriber description can be used to add a description to the subscriber. This is used in the back office to identify the subscriber.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Those payment methods which are disallowed will not be available to the subscriber even if the product allows those methods.
        /// </summary>
        /// <value>Those payment methods which are disallowed will not be available to the subscriber even if the product allows those methods.</value>
        [DataMember(Name="disallowedPaymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> DisallowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// The email address is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.
        /// </summary>
        /// <value>The email address is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.
        /// </summary>
        /// <value>The external id helps to identify the entity and a subsequent creation of an entity with the same ID will not create a new entity.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The subscriber language determines the language which is used to communicate with the subscriber in emails and documents (e.g. invoices).
        /// </summary>
        /// <value>The subscriber language determines the language which is used to communicate with the subscriber in emails and documents (e.g. invoices).</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The subscriber reference identifies the subscriber in administrative interfaces (e.g. customer id).
        /// </summary>
        /// <value>The subscriber reference identifies the subscriber in administrative interfaces (e.g. customer id).</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; private set; }

        /// <summary>
        /// ShippingAddress
        /// </summary>
        /// <value>ShippingAddress</value>
        [DataMember(Name="shippingAddress", EmitDefaultValue=false)]
        public Address ShippingAddress { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

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
            return this.Equals(obj as Subscriber);
        }

        /// <summary>
        /// Returns true if Subscriber instances are equal
        /// </summary>
        /// <param name="other">Instance of Subscriber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscriber other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.AdditionalAllowedPaymentMethodConfigurations == other.AdditionalAllowedPaymentMethodConfigurations ||
                    this.AdditionalAllowedPaymentMethodConfigurations != null &&
                    this.AdditionalAllowedPaymentMethodConfigurations.SequenceEqual(other.AdditionalAllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DisallowedPaymentMethodConfigurations == other.DisallowedPaymentMethodConfigurations ||
                    this.DisallowedPaymentMethodConfigurations != null &&
                    this.DisallowedPaymentMethodConfigurations.SequenceEqual(other.DisallowedPaymentMethodConfigurations)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.Reference == other.Reference ||
                    this.Reference != null &&
                    this.Reference.Equals(other.Reference)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.AdditionalAllowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.AdditionalAllowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.DisallowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.DisallowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                }
                if (this.ExternalId != null)
                {
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hash = hash * 59 + this.Reference.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                return hash;
            }
        }

    }

}
