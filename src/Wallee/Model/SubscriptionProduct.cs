/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Wallee.Client.OpenAPIDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// A subscription product represents a product to which a subscriber can subscribe to. A product defines how much the subscription costs and in what cycles the subscribe is charged.
    /// </summary>
    [DataContract(Name = "SubscriptionProduct")]
    public partial class SubscriptionProduct : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SubscriptionProductState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProduct" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        public SubscriptionProduct(SubscriptionProductState? state = default)
        {
            this.State = state;
        }

        /// <summary>
        /// The merchant&#39;s reference used to identify the product, e.g. the SKU.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the product, e.g. the SKU.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; private set; }

        /// <summary>
        /// Returns false as Reference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReference()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "linkedSpaceId", EmitDefaultValue = false)]
        public long LinkedSpaceId { get; private set; }

        /// <summary>
        /// Returns false as LinkedSpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedSpaceId()
        {
            return false;
        }
        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name = "spaceId", EmitDefaultValue = false)]
        public long SpaceId { get; private set; }

        /// <summary>
        /// Returns false as SpaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSpaceId()
        {
            return false;
        }
        /// <summary>
        /// When listing products, they can be sorted by this number.
        /// </summary>
        /// <value>When listing products, they can be sorted by this number.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public int SortOrder { get; private set; }

        /// <summary>
        /// Returns false as SortOrder should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSortOrder()
        {
            return false;
        }
        /// <summary>
        /// The name used to identify the product.
        /// </summary>
        /// <value>The name used to identify the product.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.
        /// </summary>
        /// <value>The date and time when the object is planned to be permanently removed. If the value is empty, the object will not be removed.</value>
        [DataMember(Name = "plannedPurgeDate", EmitDefaultValue = false)]
        public DateTime PlannedPurgeDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedPurgeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedPurgeDate()
        {
            return false;
        }
        /// <summary>
        /// Whether subscriptions can be switched to or from this product, or whether they are locked in.
        /// </summary>
        /// <value>Whether subscriptions can be switched to or from this product, or whether they are locked in.</value>
        [DataMember(Name = "productLocked", EmitDefaultValue = true)]
        public bool ProductLocked { get; private set; }

        /// <summary>
        /// Returns false as ProductLocked should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProductLocked()
        {
            return false;
        }
        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The period after which a subscription that has been suspended due to a failed payment is terminated.
        /// </summary>
        /// <value>The period after which a subscription that has been suspended due to a failed payment is terminated.</value>
        [DataMember(Name = "failedPaymentSuspensionPeriod", EmitDefaultValue = false)]
        public string FailedPaymentSuspensionPeriod { get; private set; }

        /// <summary>
        /// Returns false as FailedPaymentSuspensionPeriod should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailedPaymentSuspensionPeriod()
        {
            return false;
        }
        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; private set; }

        /// <summary>
        /// Returns false as VarVersion should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarVersion()
        {
            return false;
        }
        /// <summary>
        /// The payment methods that can be used to subscribe to this product. If none are selected, no restriction is applied.
        /// </summary>
        /// <value>The payment methods that can be used to subscribe to this product. If none are selected, no restriction is applied.</value>
        [DataMember(Name = "allowedPaymentMethodConfigurations", EmitDefaultValue = false)]
        public List<long> AllowedPaymentMethodConfigurations { get; private set; }

        /// <summary>
        /// Returns false as AllowedPaymentMethodConfigurations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAllowedPaymentMethodConfigurations()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionProduct {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  ProductLocked: ").Append(ProductLocked).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  FailedPaymentSuspensionPeriod: ").Append(FailedPaymentSuspensionPeriod).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  AllowedPaymentMethodConfigurations: ").Append(AllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Reference, length must be less than 100.", new [] { "Reference" });
            }

            if (this.Reference != null) {
                // Reference (string) pattern
                Regex regexReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexReference.Match(this.Reference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, must match a pattern of " + regexReference, new [] { "Reference" });
                }
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
