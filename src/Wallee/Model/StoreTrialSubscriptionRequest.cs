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
    /// Model used to store a Trial Subscription, assigning it to an Account
    /// </summary>
    [DataContract(Name = "StoreTrialSubscriptionRequest")]
    public partial class StoreTrialSubscriptionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreTrialSubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public StoreTrialSubscriptionRequest()
        {
        }

        /// <summary>
        /// Gets or Sets CouponCodes
        /// </summary>
        [DataMember(Name = "couponCodes", EmitDefaultValue = false)]
        public List<string> CouponCodes { get; private set; }

        /// <summary>
        /// Returns false as CouponCodes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCouponCodes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ComponentConfigurations
        /// </summary>
        [DataMember(Name = "componentConfigurations", EmitDefaultValue = false)]
        public List<SubscriptionComponentGroupConfigurationRequestSetter> ComponentConfigurations { get; private set; }

        /// <summary>
        /// Returns false as ComponentConfigurations should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeComponentConfigurations()
        {
            return false;
        }
        /// <summary>
        /// ID of the product that will be used for the Trial Subscription assigned to the Account.
        /// </summary>
        /// <value>ID of the product that will be used for the Trial Subscription assigned to the Account.</value>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public long ProductId { get; private set; }

        /// <summary>
        /// Returns false as ProductId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProductId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; private set; }

        /// <summary>
        /// Returns false as Currency should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrency()
        {
            return false;
        }
        /// <summary>
        /// ID of the affiliate to be added in the subscription assignment.
        /// </summary>
        /// <value>ID of the affiliate to be added in the subscription assignment.</value>
        [DataMember(Name = "affiliateId", EmitDefaultValue = false)]
        public long AffiliateId { get; private set; }

        /// <summary>
        /// Returns false as AffiliateId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAffiliateId()
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
            sb.Append("class StoreTrialSubscriptionRequest {\n");
            sb.Append("  CouponCodes: ").Append(CouponCodes).Append("\n");
            sb.Append("  ComponentConfigurations: ").Append(ComponentConfigurations).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AffiliateId: ").Append(AffiliateId).Append("\n");
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
            yield break;
        }
    }

}
