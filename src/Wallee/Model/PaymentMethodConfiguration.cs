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
    /// PaymentMethodConfiguration
    /// </summary>
    [DataContract(Name = "PaymentMethodConfiguration")]
    public partial class PaymentMethodConfiguration : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DataCollectionType
        /// </summary>
        [DataMember(Name = "dataCollectionType", EmitDefaultValue = false)]
        public DataCollectionType? DataCollectionType { get; set; }

        /// <summary>
        /// Gets or Sets OneClickPaymentMode
        /// </summary>
        [DataMember(Name = "oneClickPaymentMode", EmitDefaultValue = false)]
        public OneClickPaymentMode? OneClickPaymentMode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodConfiguration" /> class.
        /// </summary>
        /// <param name="dataCollectionType">dataCollectionType.</param>
        /// <param name="oneClickPaymentMode">oneClickPaymentMode.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="state">state.</param>
        public PaymentMethodConfiguration(DataCollectionType? dataCollectionType = default(DataCollectionType?), OneClickPaymentMode? oneClickPaymentMode = default(OneClickPaymentMode?), PaymentMethod paymentMethod = default(PaymentMethod), CreationEntityState? state = default(CreationEntityState?))
        {
            this.DataCollectionType = dataCollectionType;
            this.OneClickPaymentMode = oneClickPaymentMode;
            this.PaymentMethod = paymentMethod;
            this.State = state;
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
        /// A customer-facing custom description for the payment method.
        /// </summary>
        /// <value>A customer-facing custom description for the payment method.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return false;
        }
        /// <summary>
        /// The URL to the image of the payment method displayed to the customer. If a custom image is defined, it will be used; otherwise, the default image of the payment method will be shown.
        /// </summary>
        /// <value>The URL to the image of the payment method displayed to the customer. If a custom image is defined, it will be used; otherwise, the default image of the payment method will be shown.</value>
        [DataMember(Name = "resolvedImageUrl", EmitDefaultValue = false)]
        public string ResolvedImageUrl { get; private set; }

        /// <summary>
        /// Returns false as ResolvedImageUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResolvedImageUrl()
        {
            return false;
        }
        /// <summary>
        /// A customer-facing custom title for the payment method.
        /// </summary>
        /// <value>A customer-facing custom title for the payment method.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public Dictionary<string, string> Title { get; private set; }

        /// <summary>
        /// Returns false as Title should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTitle()
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
        /// The resource path to a custom image for the payment method, displayed to the customer for visual identification.
        /// </summary>
        /// <value>The resource path to a custom image for the payment method, displayed to the customer for visual identification.</value>
        [DataMember(Name = "imageResourcePath", EmitDefaultValue = false)]
        public string ImageResourcePath { get; private set; }

        /// <summary>
        /// Returns false as ImageResourcePath should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeImageResourcePath()
        {
            return false;
        }
        /// <summary>
        /// When listing payment methods, they can be sorted by this number.
        /// </summary>
        /// <value>When listing payment methods, they can be sorted by this number.</value>
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
        /// The name used to identify the payment method configuration.
        /// </summary>
        /// <value>The name used to identify the payment method configuration.</value>
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
        /// The description of the payment method displayed to the customer. If a custom description is defined, it will be used; otherwise, the default description of the payment method will be shown.
        /// </summary>
        /// <value>The description of the payment method displayed to the customer. If a custom description is defined, it will be used; otherwise, the default description of the payment method will be shown.</value>
        [DataMember(Name = "resolvedDescription", EmitDefaultValue = false)]
        public Dictionary<string, string> ResolvedDescription { get; private set; }

        /// <summary>
        /// Returns false as ResolvedDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResolvedDescription()
        {
            return false;
        }
        /// <summary>
        /// The title of the payment method displayed to the customer. If a custom title is defined, it will be used; otherwise, the default title of the payment method will be shown.
        /// </summary>
        /// <value>The title of the payment method displayed to the customer. If a custom title is defined, it will be used; otherwise, the default title of the payment method will be shown.</value>
        [DataMember(Name = "resolvedTitle", EmitDefaultValue = false)]
        public Dictionary<string, string> ResolvedTitle { get; private set; }

        /// <summary>
        /// Returns false as ResolvedTitle should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResolvedTitle()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public PaymentMethod PaymentMethod { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodConfiguration {\n");
            sb.Append("  DataCollectionType: ").Append(DataCollectionType).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ResolvedImageUrl: ").Append(ResolvedImageUrl).Append("\n");
            sb.Append("  OneClickPaymentMode: ").Append(OneClickPaymentMode).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  ImageResourcePath: ").Append(ImageResourcePath).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResolvedDescription: ").Append(ResolvedDescription).Append("\n");
            sb.Append("  ResolvedTitle: ").Append(ResolvedTitle).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            // SpaceId (long) minimum
            if (this.SpaceId < (long)1)
            {
                yield return new ValidationResult("Invalid value for SpaceId, must be a value greater than or equal to 1.", new [] { "SpaceId" });
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
