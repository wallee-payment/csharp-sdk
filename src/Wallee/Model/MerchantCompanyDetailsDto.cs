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
    /// MerchantCompanyDetailsDto
    /// </summary>
    [DataContract(Name = "MerchantCompanyDetailsDto")]
    public partial class MerchantCompanyDetailsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LegalForm
        /// </summary>
        [DataMember(Name = "legalForm", EmitDefaultValue = false)]
        public LegalForm? LegalForm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCompanyDetailsDto" /> class.
        /// </summary>
        /// <param name="businessSector">The business sector code or category of the merchant..</param>
        /// <param name="extract">The commercial register extract or reference..</param>
        /// <param name="incorporationYear">The year in which the merchant company was incorporated..</param>
        /// <param name="organizationName">The registered legal name of the merchant company..</param>
        /// <param name="businessDescription">A short description of the merchant&#39;s business activity..</param>
        /// <param name="salesTaxNumber">The sales tax or VAT number of the merchant company..</param>
        /// <param name="businessIdentificationNumber">The official business identification number of the merchant company..</param>
        /// <param name="incorporationAddress">incorporationAddress.</param>
        /// <param name="legalForm">legalForm.</param>
        public MerchantCompanyDetailsDto(string businessSector = default, string extract = default, string incorporationYear = default, string organizationName = default, string businessDescription = default, string salesTaxNumber = default, string businessIdentificationNumber = default, BasicAddress incorporationAddress = default, LegalForm? legalForm = default)
        {
            this.BusinessSector = businessSector;
            this.Extract = extract;
            this.IncorporationYear = incorporationYear;
            this.OrganizationName = organizationName;
            this.BusinessDescription = businessDescription;
            this.SalesTaxNumber = salesTaxNumber;
            this.BusinessIdentificationNumber = businessIdentificationNumber;
            this.IncorporationAddress = incorporationAddress;
            this.LegalForm = legalForm;
        }

        /// <summary>
        /// The business sector code or category of the merchant.
        /// </summary>
        /// <value>The business sector code or category of the merchant.</value>
        [DataMember(Name = "businessSector", EmitDefaultValue = false)]
        public string BusinessSector { get; set; }

        /// <summary>
        /// The commercial register extract or reference.
        /// </summary>
        /// <value>The commercial register extract or reference.</value>
        [DataMember(Name = "extract", EmitDefaultValue = false)]
        public string Extract { get; set; }

        /// <summary>
        /// The year in which the merchant company was incorporated.
        /// </summary>
        /// <value>The year in which the merchant company was incorporated.</value>
        [DataMember(Name = "incorporationYear", EmitDefaultValue = false)]
        public string IncorporationYear { get; set; }

        /// <summary>
        /// The registered legal name of the merchant company.
        /// </summary>
        /// <value>The registered legal name of the merchant company.</value>
        [DataMember(Name = "organizationName", EmitDefaultValue = false)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// A short description of the merchant&#39;s business activity.
        /// </summary>
        /// <value>A short description of the merchant&#39;s business activity.</value>
        [DataMember(Name = "businessDescription", EmitDefaultValue = false)]
        public string BusinessDescription { get; set; }

        /// <summary>
        /// The sales tax or VAT number of the merchant company.
        /// </summary>
        /// <value>The sales tax or VAT number of the merchant company.</value>
        [DataMember(Name = "salesTaxNumber", EmitDefaultValue = false)]
        public string SalesTaxNumber { get; set; }

        /// <summary>
        /// The official business identification number of the merchant company.
        /// </summary>
        /// <value>The official business identification number of the merchant company.</value>
        [DataMember(Name = "businessIdentificationNumber", EmitDefaultValue = false)]
        public string BusinessIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or Sets IncorporationAddress
        /// </summary>
        [DataMember(Name = "incorporationAddress", EmitDefaultValue = false)]
        public BasicAddress IncorporationAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantCompanyDetailsDto {\n");
            sb.Append("  BusinessSector: ").Append(BusinessSector).Append("\n");
            sb.Append("  Extract: ").Append(Extract).Append("\n");
            sb.Append("  IncorporationYear: ").Append(IncorporationYear).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  BusinessDescription: ").Append(BusinessDescription).Append("\n");
            sb.Append("  SalesTaxNumber: ").Append(SalesTaxNumber).Append("\n");
            sb.Append("  BusinessIdentificationNumber: ").Append(BusinessIdentificationNumber).Append("\n");
            sb.Append("  IncorporationAddress: ").Append(IncorporationAddress).Append("\n");
            sb.Append("  LegalForm: ").Append(LegalForm).Append("\n");
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
