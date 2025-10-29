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
    /// TransactionInvoiceCommentCreate
    /// </summary>
    [DataContract(Name = "TransactionInvoiceComment.Create")]
    public partial class TransactionInvoiceCommentCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceCommentCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInvoiceCommentCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceCommentCreate" /> class.
        /// </summary>
        /// <param name="content">The comment&#39;s actual content..</param>
        /// <param name="transactionInvoice">The transaction invoice that the comment belongs to. (required).</param>
        public TransactionInvoiceCommentCreate(string content = default(string), long transactionInvoice = default(long))
        {
            this.TransactionInvoice = transactionInvoice;
            this.Content = content;
        }

        /// <summary>
        /// The comment&#39;s actual content.
        /// </summary>
        /// <value>The comment&#39;s actual content.</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// The transaction invoice that the comment belongs to.
        /// </summary>
        /// <value>The transaction invoice that the comment belongs to.</value>
        [DataMember(Name = "transactionInvoice", IsRequired = true, EmitDefaultValue = true)]
        public long TransactionInvoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionInvoiceCommentCreate {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  TransactionInvoice: ").Append(TransactionInvoice).Append("\n");
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
            // Content (string) maxLength
            if (this.Content != null && this.Content.Length > 262144)
            {
                yield return new ValidationResult("Invalid value for Content, length must be less than 262144.", new [] { "Content" });
            }

            yield break;
        }
    }

}
