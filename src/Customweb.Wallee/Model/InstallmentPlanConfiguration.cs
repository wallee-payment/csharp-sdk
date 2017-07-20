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
    /// The installment plan allows to setup a template for an installment.
    /// </summary>
    [DataContract]
    public partial class InstallmentPlanConfiguration :  IEquatable<InstallmentPlanConfiguration>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="InstallmentPlanConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public InstallmentPlanConfiguration()
        {
        }

        /// <summary>
        /// The base currency in which the installment fee and minimal amount are defined.
        /// </summary>
        /// <value>The base currency in which the installment fee and minimal amount are defined.</value>
        [DataMember(Name="baseCurrency", EmitDefaultValue=false)]
        public string BaseCurrency { get; private set; }

        /// <summary>
        /// If a transaction meets all selected conditions the installment plan will be available to the customer to be selected.
        /// </summary>
        /// <value>If a transaction meets all selected conditions the installment plan will be available to the customer to be selected.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<long?> Conditions { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The installment fee is a fixed amount that is charged additionally when applying this installment plan.
        /// </summary>
        /// <value>The installment fee is a fixed amount that is charged additionally when applying this installment plan.</value>
        [DataMember(Name="installmentFee", EmitDefaultValue=false)]
        public decimal? InstallmentFee { get; private set; }

        /// <summary>
        /// The interest rate is a percentage of the total amount that is charged additionally when applying this installment plan.
        /// </summary>
        /// <value>The interest rate is a percentage of the total amount that is charged additionally when applying this installment plan.</value>
        [DataMember(Name="interestRate", EmitDefaultValue=false)]
        public decimal? InterestRate { get; private set; }

        /// <summary>
        /// The linked space id holds the ID of the space to which the entity belongs to.
        /// </summary>
        /// <value>The linked space id holds the ID of the space to which the entity belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The installment plan can only be applied if the orders total is at least the defined minimal amount.
        /// </summary>
        /// <value>The installment plan can only be applied if the orders total is at least the defined minimal amount.</value>
        [DataMember(Name="minimalAmount", EmitDefaultValue=false)]
        public decimal? MinimalAmount { get; private set; }

        /// <summary>
        /// The installment plan name is used internally to identify the plan in administrative interfaces.For example it is used within search fields and hence it should be distinct and descriptive.
        /// </summary>
        /// <value>The installment plan name is used internally to identify the plan in administrative interfaces.For example it is used within search fields and hence it should be distinct and descriptive.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// A installment plan can be enabled only for specific payment method configurations. Other payment methods will not be selectable by the buyer.
        /// </summary>
        /// <value>A installment plan can be enabled only for specific payment method configurations. Other payment methods will not be selectable by the buyer.</value>
        [DataMember(Name="paymentMethodConfigurations", EmitDefaultValue=false)]
        public List<long?> PaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.
        /// </summary>
        /// <value>The planned purge date indicates when the entity is permanently removed. When the date is null the entity is not planned to be removed.</value>
        [DataMember(Name="plannedPurgeDate", EmitDefaultValue=false)]
        public DateTime? PlannedPurgeDate { get; private set; }

        /// <summary>
        /// The sort order controls in which order the installation plans are listed. The sort order is used to order the plans in ascending order.
        /// </summary>
        /// <value>The sort order controls in which order the installation plans are listed. The sort order is used to order the plans in ascending order.</value>
        [DataMember(Name="sortOrder", EmitDefaultValue=false)]
        public int? SortOrder { get; private set; }

        /// <summary>
        /// SpaceReference
        /// </summary>
        /// <value>SpaceReference</value>
        [DataMember(Name="spaceReference", EmitDefaultValue=false)]
        public SpaceReference SpaceReference { get; private set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public CreationEntityState? State { get; private set; }

        /// <summary>
        /// The tax class determines the taxes which are applicable on all fees linked to the installment plan.
        /// </summary>
        /// <value>The tax class determines the taxes which are applicable on all fees linked to the installment plan.</value>
        [DataMember(Name="taxClass", EmitDefaultValue=false)]
        public TaxClass TaxClass { get; private set; }

        /// <summary>
        /// The terms and conditions will be displayed to the customer when he or she selects this installment plan.
        /// </summary>
        /// <value>The terms and conditions will be displayed to the customer when he or she selects this installment plan.</value>
        [DataMember(Name="termsAndConditions", EmitDefaultValue=false)]
        public ResourcePath TermsAndConditions { get; private set; }

        /// <summary>
        /// The title of the installment plan is used within the payment process. The title is visible to the buyer.
        /// </summary>
        /// <value>The title of the installment plan is used within the payment process. The title is visible to the buyer.</value>
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
            return this.Equals(obj as InstallmentPlanConfiguration);
        }

        /// <summary>
        /// Returns true if InstallmentPlanConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of InstallmentPlanConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstallmentPlanConfiguration other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.BaseCurrency == other.BaseCurrency ||
                    this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(other.BaseCurrency)
                ) && 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.SequenceEqual(other.Conditions)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InstallmentFee == other.InstallmentFee ||
                    this.InstallmentFee != null &&
                    this.InstallmentFee.Equals(other.InstallmentFee)
                ) && 
                (
                    this.InterestRate == other.InterestRate ||
                    this.InterestRate != null &&
                    this.InterestRate.Equals(other.InterestRate)
                ) && 
                (
                    this.LinkedSpaceId == other.LinkedSpaceId ||
                    this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(other.LinkedSpaceId)
                ) && 
                (
                    this.MinimalAmount == other.MinimalAmount ||
                    this.MinimalAmount != null &&
                    this.MinimalAmount.Equals(other.MinimalAmount)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PaymentMethodConfigurations == other.PaymentMethodConfigurations ||
                    this.PaymentMethodConfigurations != null &&
                    this.PaymentMethodConfigurations.SequenceEqual(other.PaymentMethodConfigurations)
                ) && 
                (
                    this.PlannedPurgeDate == other.PlannedPurgeDate ||
                    this.PlannedPurgeDate != null &&
                    this.PlannedPurgeDate.Equals(other.PlannedPurgeDate)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) && 
                (
                    this.SpaceReference == other.SpaceReference ||
                    this.SpaceReference != null &&
                    this.SpaceReference.Equals(other.SpaceReference)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TaxClass == other.TaxClass ||
                    this.TaxClass != null &&
                    this.TaxClass.Equals(other.TaxClass)
                ) && 
                (
                    this.TermsAndConditions == other.TermsAndConditions ||
                    this.TermsAndConditions != null &&
                    this.TermsAndConditions.Equals(other.TermsAndConditions)
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
                if (this.BaseCurrency != null)
                {
                    hash = hash * 59 + this.BaseCurrency.GetHashCode();
                }
                if (this.Conditions != null)
                {
                    hash = hash * 59 + this.Conditions.GetHashCode();
                }
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.InstallmentFee != null)
                {
                    hash = hash * 59 + this.InstallmentFee.GetHashCode();
                }
                if (this.InterestRate != null)
                {
                    hash = hash * 59 + this.InterestRate.GetHashCode();
                }
                if (this.LinkedSpaceId != null)
                {
                    hash = hash * 59 + this.LinkedSpaceId.GetHashCode();
                }
                if (this.MinimalAmount != null)
                {
                    hash = hash * 59 + this.MinimalAmount.GetHashCode();
                }
                if (this.Name != null)
                {
                    hash = hash * 59 + this.Name.GetHashCode();
                }
                if (this.PaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.PaymentMethodConfigurations.GetHashCode();
                }
                if (this.PlannedPurgeDate != null)
                {
                    hash = hash * 59 + this.PlannedPurgeDate.GetHashCode();
                }
                if (this.SortOrder != null)
                {
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                }
                if (this.SpaceReference != null)
                {
                    hash = hash * 59 + this.SpaceReference.GetHashCode();
                }
                if (this.State != null)
                {
                    hash = hash * 59 + this.State.GetHashCode();
                }
                if (this.TaxClass != null)
                {
                    hash = hash * 59 + this.TaxClass.GetHashCode();
                }
                if (this.TermsAndConditions != null)
                {
                    hash = hash * 59 + this.TermsAndConditions.GetHashCode();
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
