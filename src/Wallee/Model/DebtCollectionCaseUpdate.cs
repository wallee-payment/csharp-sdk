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
    /// The debt collection case represents a try to collect the money from the debtor.
    /// </summary>
    [DataContract(Name = "DebtCollectionCase.Update")]
    public partial class DebtCollectionCaseUpdate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public DebtCollectionEnvironment? VarEnvironment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DebtCollectionCaseUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtCollectionCaseUpdate" /> class.
        /// </summary>
        /// <param name="lineItems">The line items that are subject of this debt collection case..</param>
        /// <param name="contractDate">The date and time when the contract with the debtor was signed..</param>
        /// <param name="varEnvironment">varEnvironment.</param>
        /// <param name="dueDate">The date and time when the claim was due..</param>
        /// <param name="currency">The three-letter code (ISO 4217 format) of the case&#39;s currency..</param>
        /// <param name="language">The language that is linked to the object..</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="spaceViewId">The ID of the space view this object is linked to..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public DebtCollectionCaseUpdate(List<LineItemCreate> lineItems = default(List<LineItemCreate>), DateTime contractDate = default(DateTime), DebtCollectionEnvironment? varEnvironment = default(DebtCollectionEnvironment?), DateTime dueDate = default(DateTime), string currency = default(string), string language = default(string), AddressCreate billingAddress = default(AddressCreate), long spaceViewId = default(long), int varVersion = default(int))
        {
            this.VarVersion = varVersion;
            this.LineItems = lineItems;
            this.ContractDate = contractDate;
            this.VarEnvironment = varEnvironment;
            this.DueDate = dueDate;
            this.Currency = currency;
            this.Language = language;
            this.BillingAddress = billingAddress;
            this.SpaceViewId = spaceViewId;
        }

        /// <summary>
        /// The line items that are subject of this debt collection case.
        /// </summary>
        /// <value>The line items that are subject of this debt collection case.</value>
        [DataMember(Name = "lineItems", EmitDefaultValue = false)]
        public List<LineItemCreate> LineItems { get; set; }

        /// <summary>
        /// The date and time when the contract with the debtor was signed.
        /// </summary>
        /// <value>The date and time when the contract with the debtor was signed.</value>
        [DataMember(Name = "contractDate", EmitDefaultValue = false)]
        public DateTime ContractDate { get; set; }

        /// <summary>
        /// The date and time when the claim was due.
        /// </summary>
        /// <value>The date and time when the claim was due.</value>
        [DataMember(Name = "dueDate", EmitDefaultValue = false)]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) of the case&#39;s currency.
        /// </summary>
        /// <value>The three-letter code (ISO 4217 format) of the case&#39;s currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// The ID of the space view this object is linked to.
        /// </summary>
        /// <value>The ID of the space view this object is linked to.</value>
        [DataMember(Name = "spaceViewId", EmitDefaultValue = false)]
        public long SpaceViewId { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DebtCollectionCaseUpdate {\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ContractDate: ").Append(ContractDate).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  SpaceViewId: ").Append(SpaceViewId).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
