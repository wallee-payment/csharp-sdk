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
    /// MerchantApplicationDataDto
    /// </summary>
    [DataContract(Name = "MerchantApplicationDataDto")]
    public partial class MerchantApplicationDataDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantApplicationDataDto" /> class.
        /// </summary>
        /// <param name="relatedPersons">relatedPersons.</param>
        /// <param name="bankDetails">bankDetails.</param>
        /// <param name="companyDetails">companyDetails.</param>
        /// <param name="paymentChannels">paymentChannels.</param>
        /// <param name="contractRevenue">contractRevenue.</param>
        /// <param name="ecommerceDetails">ecommerceDetails.</param>
        public MerchantApplicationDataDto(MerchantRelatedPersonsDto relatedPersons = default, MerchantBankDetailsDto bankDetails = default, MerchantCompanyDetailsDto companyDetails = default, MerchantPaymentChannelsDto paymentChannels = default, MerchantContractRevenueDto contractRevenue = default, MerchantEcommerceDetailsDto ecommerceDetails = default)
        {
            this.RelatedPersons = relatedPersons;
            this.BankDetails = bankDetails;
            this.CompanyDetails = companyDetails;
            this.PaymentChannels = paymentChannels;
            this.ContractRevenue = contractRevenue;
            this.EcommerceDetails = ecommerceDetails;
        }

        /// <summary>
        /// Gets or Sets RelatedPersons
        /// </summary>
        [DataMember(Name = "relatedPersons", EmitDefaultValue = false)]
        public MerchantRelatedPersonsDto RelatedPersons { get; set; }

        /// <summary>
        /// Gets or Sets BankDetails
        /// </summary>
        [DataMember(Name = "bankDetails", EmitDefaultValue = false)]
        public MerchantBankDetailsDto BankDetails { get; set; }

        /// <summary>
        /// Gets or Sets CompanyDetails
        /// </summary>
        [DataMember(Name = "companyDetails", EmitDefaultValue = false)]
        public MerchantCompanyDetailsDto CompanyDetails { get; set; }

        /// <summary>
        /// Gets or Sets PaymentChannels
        /// </summary>
        [DataMember(Name = "paymentChannels", EmitDefaultValue = false)]
        public MerchantPaymentChannelsDto PaymentChannels { get; set; }

        /// <summary>
        /// Gets or Sets ContractRevenue
        /// </summary>
        [DataMember(Name = "contractRevenue", EmitDefaultValue = false)]
        public MerchantContractRevenueDto ContractRevenue { get; set; }

        /// <summary>
        /// Gets or Sets EcommerceDetails
        /// </summary>
        [DataMember(Name = "ecommerceDetails", EmitDefaultValue = false)]
        public MerchantEcommerceDetailsDto EcommerceDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantApplicationDataDto {\n");
            sb.Append("  RelatedPersons: ").Append(RelatedPersons).Append("\n");
            sb.Append("  BankDetails: ").Append(BankDetails).Append("\n");
            sb.Append("  CompanyDetails: ").Append(CompanyDetails).Append("\n");
            sb.Append("  PaymentChannels: ").Append(PaymentChannels).Append("\n");
            sb.Append("  ContractRevenue: ").Append(ContractRevenue).Append("\n");
            sb.Append("  EcommerceDetails: ").Append(EcommerceDetails).Append("\n");
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
