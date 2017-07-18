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
    /// Product Setup Fee
    /// </summary>
    [DataContract]
    public partial class ProductSetupFeeUpdate :  IEquatable<ProductSetupFeeUpdate>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSetupFeeUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductSetupFeeUpdate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSetupFeeUpdate" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required)</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required)</param>
        /// <param name="Component">Component</param>
        /// <param name="Description">The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.</param>
        /// <param name="Name">The name of the fee should describe for the subscriber in few words for what the fee is for.</param>
        /// <param name="OnDowngradeCreditedAmount">When the subscription is changed and the change is considered as a downgrade the amount defined by this property will be credited to the subscriber.</param>
        /// <param name="OnUpgradeCreditedAmount">When the subscription is changed and the change is considered as a upgrade the amount defined by this property will be credited to the subscriber.</param>
        /// <param name="SetupFee">The setup fee is charged when the subscriber subscribes to this component. The setup fee is debited with the first charge for the subscriptions.</param>
        public ProductSetupFeeUpdate(List<PersistableCurrencyAmountUpdate> OnUpgradeCreditedAmount = default(List<PersistableCurrencyAmountUpdate>), DatabaseTranslatedStringCreate Name = default(DatabaseTranslatedStringCreate), long? Version = default(long?), List<PersistableCurrencyAmountUpdate> OnDowngradeCreditedAmount = default(List<PersistableCurrencyAmountUpdate>), long? Id = default(long?), List<PersistableCurrencyAmountUpdate> SetupFee = default(List<PersistableCurrencyAmountUpdate>), DatabaseTranslatedStringCreate Description = default(DatabaseTranslatedStringCreate), long? Component = default(long?))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new ArgumentNullException("Id is a required property for ProductSetupFeeUpdate and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new ArgumentNullException("Version is a required property for ProductSetupFeeUpdate and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.Component = Component;
            this.Description = Description;
            this.Name = Name;
            this.OnDowngradeCreditedAmount = OnDowngradeCreditedAmount;
            this.OnUpgradeCreditedAmount = OnUpgradeCreditedAmount;
            this.SetupFee = SetupFee;
        }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// Component
        /// </summary>
        /// <value>Component</value>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public long? Component { get; set; }

        /// <summary>
        /// The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.
        /// </summary>
        /// <value>The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DatabaseTranslatedStringCreate Description { get; set; }

        /// <summary>
        /// The name of the fee should describe for the subscriber in few words for what the fee is for.
        /// </summary>
        /// <value>The name of the fee should describe for the subscriber in few words for what the fee is for.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedStringCreate Name { get; set; }

        /// <summary>
        /// When the subscription is changed and the change is considered as a downgrade the amount defined by this property will be credited to the subscriber.
        /// </summary>
        /// <value>When the subscription is changed and the change is considered as a downgrade the amount defined by this property will be credited to the subscriber.</value>
        [DataMember(Name="onDowngradeCreditedAmount", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> OnDowngradeCreditedAmount { get; set; }

        /// <summary>
        /// When the subscription is changed and the change is considered as a upgrade the amount defined by this property will be credited to the subscriber.
        /// </summary>
        /// <value>When the subscription is changed and the change is considered as a upgrade the amount defined by this property will be credited to the subscriber.</value>
        [DataMember(Name="onUpgradeCreditedAmount", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> OnUpgradeCreditedAmount { get; set; }

        /// <summary>
        /// The setup fee is charged when the subscriber subscribes to this component. The setup fee is debited with the first charge for the subscriptions.
        /// </summary>
        /// <value>The setup fee is charged when the subscriber subscribes to this component. The setup fee is debited with the first charge for the subscriptions.</value>
        [DataMember(Name="setupFee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmountUpdate> SetupFee { get; set; }

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
            return this.Equals(obj as ProductSetupFeeUpdate);
        }

        /// <summary>
        /// Returns true if ProductSetupFeeUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductSetupFeeUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductSetupFeeUpdate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Component == other.Component ||
                    this.Component != null &&
                    this.Component.Equals(other.Component)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OnDowngradeCreditedAmount == other.OnDowngradeCreditedAmount ||
                    this.OnDowngradeCreditedAmount != null &&
                    this.OnDowngradeCreditedAmount.SequenceEqual(other.OnDowngradeCreditedAmount)
                ) && 
                (
                    this.OnUpgradeCreditedAmount == other.OnUpgradeCreditedAmount ||
                    this.OnUpgradeCreditedAmount != null &&
                    this.OnUpgradeCreditedAmount.SequenceEqual(other.OnUpgradeCreditedAmount)
                ) && 
                (
                    this.SetupFee == other.SetupFee ||
                    this.SetupFee != null &&
                    this.SetupFee.SequenceEqual(other.SetupFee)
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
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
                }
                if (this.Component != null)
                {
                    hash = hash * 59 + this.Component.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.OnDowngradeCreditedAmount != null)
                {
                    hash = hash * 59 + this.OnDowngradeCreditedAmount.GetHashCode();
                }
                if (this.OnUpgradeCreditedAmount != null)
                {
                    hash = hash * 59 + this.OnUpgradeCreditedAmount.GetHashCode();
                }
                if (this.SetupFee != null)
                {
                    hash = hash * 59 + this.SetupFee.GetHashCode();
                }
                return hash;
            }
        }

    }

}
