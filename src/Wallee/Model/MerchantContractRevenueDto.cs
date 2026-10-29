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
    /// MerchantContractRevenueDto
    /// </summary>
    [DataContract(Name = "MerchantContractRevenueDto")]
    public partial class MerchantContractRevenueDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantContractRevenueDto" /> class.
        /// </summary>
        /// <param name="businessWebsite">The merchant&#39;s public business website..</param>
        /// <param name="statementDescriptor">The statement descriptor shown to customers on payment records..</param>
        /// <param name="businessIndustry">The business industry code or category of the merchant..</param>
        /// <param name="productDescription">A description of the products or services sold by the merchant..</param>
        public MerchantContractRevenueDto(string businessWebsite = default, string statementDescriptor = default, string businessIndustry = default, string productDescription = default)
        {
            this.BusinessWebsite = businessWebsite;
            this.StatementDescriptor = statementDescriptor;
            this.BusinessIndustry = businessIndustry;
            this.ProductDescription = productDescription;
        }

        /// <summary>
        /// The merchant&#39;s public business website.
        /// </summary>
        /// <value>The merchant&#39;s public business website.</value>
        [DataMember(Name = "businessWebsite", EmitDefaultValue = false)]
        public string BusinessWebsite { get; set; }

        /// <summary>
        /// The statement descriptor shown to customers on payment records.
        /// </summary>
        /// <value>The statement descriptor shown to customers on payment records.</value>
        [DataMember(Name = "statementDescriptor", EmitDefaultValue = false)]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// The business industry code or category of the merchant.
        /// </summary>
        /// <value>The business industry code or category of the merchant.</value>
        [DataMember(Name = "businessIndustry", EmitDefaultValue = false)]
        public string BusinessIndustry { get; set; }

        /// <summary>
        /// A description of the products or services sold by the merchant.
        /// </summary>
        /// <value>A description of the products or services sold by the merchant.</value>
        [DataMember(Name = "productDescription", EmitDefaultValue = false)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantContractRevenueDto {\n");
            sb.Append("  BusinessWebsite: ").Append(BusinessWebsite).Append("\n");
            sb.Append("  StatementDescriptor: ").Append(StatementDescriptor).Append("\n");
            sb.Append("  BusinessIndustry: ").Append(BusinessIndustry).Append("\n");
            sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
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
