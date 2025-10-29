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
    /// TransactionLineItemVersionCreate
    /// </summary>
    [DataContract(Name = "TransactionLineItemVersion.Create")]
    public partial class TransactionLineItemVersionCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemVersionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionLineItemVersionCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionLineItemVersionCreate" /> class.
        /// </summary>
        /// <param name="lineItems">The line items that replace the original line items in the transaction. (required).</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="transaction">The transaction that the line item version belongs to. (required).</param>
        public TransactionLineItemVersionCreate(List<LineItemCreate> lineItems = default(List<LineItemCreate>), string externalId = default(string), long transaction = default(long))
        {
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new ArgumentNullException("lineItems is a required property for TransactionLineItemVersionCreate and cannot be null");
            }
            this.LineItems = lineItems;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for TransactionLineItemVersionCreate and cannot be null");
            }
            this.ExternalId = externalId;
            this.Transaction = transaction;
        }

        /// <summary>
        /// The line items that replace the original line items in the transaction.
        /// </summary>
        /// <value>The line items that replace the original line items in the transaction.</value>
        [DataMember(Name = "lineItems", IsRequired = true, EmitDefaultValue = true)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// The transaction that the line item version belongs to.
        /// </summary>
        /// <value>The transaction that the line item version belongs to.</value>
        [DataMember(Name = "transaction", IsRequired = true, EmitDefaultValue = true)]
        public long Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionLineItemVersionCreate {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
