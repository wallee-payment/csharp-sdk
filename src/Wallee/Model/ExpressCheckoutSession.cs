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
    /// ExpressCheckoutSession
    /// </summary>
    [DataContract(Name = "ExpressCheckoutSession")]
    public partial class ExpressCheckoutSession : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public ExpressCheckoutSessionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutSession" /> class.
        /// </summary>
        /// <param name="walletType">walletType.</param>
        /// <param name="state">state.</param>
        public ExpressCheckoutSession(ExpressCheckoutWalletType walletType = default, ExpressCheckoutSessionState? state = default)
        {
            this.WalletType = walletType;
            this.State = state;
        }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItem> LineItems { get; private set; }

        /// <summary>
        /// Returns false as LineItems should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLineItems()
        {
            return false;
        }
        /// <summary>
        /// The spaceId linked to the entity.
        /// </summary>
        /// <value>The spaceId linked to the entity.</value>
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
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        public Dictionary<string, string> MetaData { get; private set; }

        /// <summary>
        /// Returns false as MetaData should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetaData()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets WalletType
        /// </summary>
        [DataMember(Name = "walletType", EmitDefaultValue = false)]
        public ExpressCheckoutWalletType WalletType { get; set; }

        /// <summary>
        /// Id of the entity.
        /// </summary>
        /// <value>Id of the entity.</value>
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
        /// Gets or Sets ShippingOptions
        /// </summary>
        [DataMember(Name = "shippingOptions", EmitDefaultValue = false)]
        public List<ExpressCheckoutShippingOption> ShippingOptions { get; private set; }

        /// <summary>
        /// Returns false as ShippingOptions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeShippingOptions()
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
            sb.Append("class ExpressCheckoutSession {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  WalletType: ").Append(WalletType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ShippingOptions: ").Append(ShippingOptions).Append("\n");
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
