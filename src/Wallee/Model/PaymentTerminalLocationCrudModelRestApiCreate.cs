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
    /// PaymentTerminalLocationCrudModelRestApiCreate
    /// </summary>
    [DataContract(Name = "PaymentTerminalLocationCrudModel.RestApiCreate")]
    public partial class PaymentTerminalLocationCrudModelRestApiCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalLocationCrudModelRestApiCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentTerminalLocationCrudModelRestApiCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentTerminalLocationCrudModelRestApiCreate" /> class.
        /// </summary>
        /// <param name="productionMerchantId">The production merchant identifier assigned to the location..</param>
        /// <param name="address">address (required).</param>
        /// <param name="name">The name used to identify the payment terminal location. (required).</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="contactAddress">contactAddress.</param>
        public PaymentTerminalLocationCrudModelRestApiCreate(string productionMerchantId = default, PaymentTerminalAddressCreate address = default, string name = default, string externalId = default, PaymentTerminalAddressCreate contactAddress = default)
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for PaymentTerminalLocationCrudModelRestApiCreate and cannot be null");
            }
            this.Address = address;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PaymentTerminalLocationCrudModelRestApiCreate and cannot be null");
            }
            this.Name = name;
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for PaymentTerminalLocationCrudModelRestApiCreate and cannot be null");
            }
            this.ExternalId = externalId;
            this.ProductionMerchantId = productionMerchantId;
            this.ContactAddress = contactAddress;
        }

        /// <summary>
        /// The production merchant identifier assigned to the location.
        /// </summary>
        /// <value>The production merchant identifier assigned to the location.</value>
        [DataMember(Name = "productionMerchantId", EmitDefaultValue = false)]
        public string ProductionMerchantId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public PaymentTerminalAddressCreate Address { get; set; }

        /// <summary>
        /// The name used to identify the payment terminal location.
        /// </summary>
        /// <value>The name used to identify the payment terminal location.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets ContactAddress
        /// </summary>
        [DataMember(Name = "contactAddress", EmitDefaultValue = false)]
        public PaymentTerminalAddressCreate ContactAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentTerminalLocationCrudModelRestApiCreate {\n");
            sb.Append("  ProductionMerchantId: ").Append(ProductionMerchantId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  ContactAddress: ").Append(ContactAddress).Append("\n");
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
            // ProductionMerchantId (string) maxLength
            if (this.ProductionMerchantId != null && this.ProductionMerchantId.Length > 15)
            {
                yield return new ValidationResult("Invalid value for ProductionMerchantId, length must be less than 15.", new [] { "ProductionMerchantId" });
            }

            // ProductionMerchantId (string) minLength
            if (this.ProductionMerchantId != null && this.ProductionMerchantId.Length < 15)
            {
                yield return new ValidationResult("Invalid value for ProductionMerchantId, length must be greater than 15.", new [] { "ProductionMerchantId" });
            }

            if (this.ProductionMerchantId != null) {
                // ProductionMerchantId (string) pattern
                Regex regexProductionMerchantId = new Regex(@"([0-9a-zA-Z])+", RegexOptions.CultureInvariant);
                if (!regexProductionMerchantId.Match(this.ProductionMerchantId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductionMerchantId, must match a pattern of " + regexProductionMerchantId, new [] { "ProductionMerchantId" });
                }
            }

            yield break;
        }
    }

}
