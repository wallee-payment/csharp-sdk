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
    public partial class ProductSetupFee :  IEquatable<ProductSetupFee>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSetupFee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ProductSetupFee()
        {
        }

        /// <summary>
        /// Component
        /// </summary>
        /// <value>Component</value>
        [DataMember(Name="component", EmitDefaultValue=false)]
        public SubscriptionProductComponent Component { get; private set; }

        /// <summary>
        /// The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.
        /// </summary>
        /// <value>The description of a component fee describes the fee to the subscriber. The description may be shown in documents or on certain user interfaces.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public DatabaseTranslatedString Description { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name of the fee should describe for the subscriber in few words for what the fee is for.
        /// </summary>
        /// <value>The name of the fee should describe for the subscriber in few words for what the fee is for.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public DatabaseTranslatedString Name { get; private set; }

        /// <summary>
        /// When the subscription is changed and the change is considered as a downgrade the amount defined by this property will be credited to the subscriber.
        /// </summary>
        /// <value>When the subscription is changed and the change is considered as a downgrade the amount defined by this property will be credited to the subscriber.</value>
        [DataMember(Name="onDowngradeCreditedAmount", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmount> OnDowngradeCreditedAmount { get; private set; }

        /// <summary>
        /// When the subscription is changed and the change is considered as a upgrade the amount defined by this property will be credited to the subscriber.
        /// </summary>
        /// <value>When the subscription is changed and the change is considered as a upgrade the amount defined by this property will be credited to the subscriber.</value>
        [DataMember(Name="onUpgradeCreditedAmount", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmount> OnUpgradeCreditedAmount { get; private set; }

        /// <summary>
        /// The setup fee is charged when the subscriber subscribes to this component. The setup fee is debited with the first charge for the subscriptions.
        /// </summary>
        /// <value>The setup fee is charged when the subscriber subscribes to this component. The setup fee is debited with the first charge for the subscriptions.</value>
        [DataMember(Name="setupFee", EmitDefaultValue=false)]
        public List<PersistableCurrencyAmount> SetupFee { get; private set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public ProductFeeType? Type { get; private set; }

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
            return this.Equals(obj as ProductSetupFee);
        }

        /// <summary>
        /// Returns true if ProductSetupFee instances are equal
        /// </summary>
        /// <param name="other">Instance of ProductSetupFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductSetupFee other)
        {
            if (other == null)
            {
                return false;
            }

            return 
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
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Component != null)
                {
                    hash = hash * 59 + this.Component.GetHashCode();
                }
                if (this.Description != null)
                {
                    hash = hash * 59 + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
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
                if (this.Type != null)
                {
                    hash = hash * 59 + this.Type.GetHashCode();
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
