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
    /// TokenVersion
    /// </summary>
    [DataContract(Name = "TokenVersion")]
    public partial class TokenVersion : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public TokenVersionState? State { get; set; }

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public ChargeAttemptEnvironment? VarEnvironment { get; set; }

        /// <summary>
        /// Gets or Sets RetryStrategy
        /// </summary>
        [DataMember(Name = "retryStrategy", EmitDefaultValue = false)]
        public TokenVersionRetryStrategy? RetryStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenVersion" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="paymentConnectorConfiguration">paymentConnectorConfiguration.</param>
        /// <param name="state">state.</param>
        /// <param name="paymentMethodBrand">paymentMethodBrand.</param>
        /// <param name="token">token.</param>
        /// <param name="varEnvironment">varEnvironment.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="retryStrategy">retryStrategy.</param>
        public TokenVersion(TokenVersionType type = default, PaymentConnectorConfiguration paymentConnectorConfiguration = default, TokenVersionState? state = default, PaymentMethodBrand paymentMethodBrand = default, Token token = default, ChargeAttemptEnvironment? varEnvironment = default, PaymentMethod paymentMethod = default, Address shippingAddress = default, Address billingAddress = default, TokenVersionRetryStrategy? retryStrategy = default)
        {
            this.Type = type;
            this.PaymentConnectorConfiguration = paymentConnectorConfiguration;
            this.State = state;
            this.PaymentMethodBrand = paymentMethodBrand;
            this.Token = token;
            this.VarEnvironment = varEnvironment;
            this.PaymentMethod = paymentMethod;
            this.ShippingAddress = shippingAddress;
            this.BillingAddress = billingAddress;
            this.RetryStrategy = retryStrategy;
        }

        /// <summary>
        /// The hashed payment information that the token version represents.
        /// </summary>
        /// <value>The hashed payment information that the token version represents.</value>
        [DataMember(Name = "paymentInformationHashes", EmitDefaultValue = false)]
        public List<PaymentInformationHash> PaymentInformationHashes { get; private set; }

        /// <summary>
        /// Returns false as PaymentInformationHashes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentInformationHashes()
        {
            return false;
        }
        /// <summary>
        /// The language that is linked to the object.
        /// </summary>
        /// <value>The language that is linked to the object.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; private set; }

        /// <summary>
        /// Returns false as Language should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLanguage()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TokenVersionType Type { get; set; }

        /// <summary>
        /// The date and time when the object was created.
        /// </summary>
        /// <value>The date and time when the object was created.</value>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Returns false as CreatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedOn()
        {
            return false;
        }
        /// <summary>
        /// Retry interval when the strategy advises retrying later.
        /// </summary>
        /// <value>Retry interval when the strategy advises retrying later.</value>
        [DataMember(Name = "retryIn", EmitDefaultValue = false)]
        public string RetryIn { get; private set; }

        /// <summary>
        /// Returns false as RetryIn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRetryIn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentConnectorConfiguration
        /// </summary>
        [DataMember(Name = "paymentConnectorConfiguration", EmitDefaultValue = false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; set; }

        /// <summary>
        /// The date and time when the token version was marked obsolete.
        /// </summary>
        /// <value>The date and time when the token version was marked obsolete.</value>
        [DataMember(Name = "obsoletedOn", EmitDefaultValue = false)]
        public DateTime ObsoletedOn { get; private set; }

        /// <summary>
        /// Returns false as ObsoletedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeObsoletedOn()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the token version is set to expire, after which it will be marked as obsolete.
        /// </summary>
        /// <value>The date and time when the token version is set to expire, after which it will be marked as obsolete.</value>
        [DataMember(Name = "expiresOn", EmitDefaultValue = false)]
        public DateTime ExpiresOn { get; private set; }

        /// <summary>
        /// Returns false as ExpiresOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExpiresOn()
        {
            return false;
        }
        /// <summary>
        /// The URL to the token&#39;s icon displayed to the customer.
        /// </summary>
        /// <value>The URL to the token&#39;s icon displayed to the customer.</value>
        [DataMember(Name = "iconUrl", EmitDefaultValue = false)]
        public string IconUrl { get; private set; }

        /// <summary>
        /// Returns false as IconUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIconUrl()
        {
            return false;
        }
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
        /// The token name as specified by the processor.
        /// </summary>
        /// <value>The token name as specified by the processor.</value>
        [DataMember(Name = "processorToken", EmitDefaultValue = false)]
        public string ProcessorToken { get; private set; }

        /// <summary>
        /// Returns false as ProcessorToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessorToken()
        {
            return false;
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
        /// Gets or Sets PaymentMethodBrand
        /// </summary>
        [DataMember(Name = "paymentMethodBrand", EmitDefaultValue = false)]
        public PaymentMethodBrand PaymentMethodBrand { get; set; }

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
        /// The date and time when the system last attempted a retry for this token version.
        /// </summary>
        /// <value>The date and time when the system last attempted a retry for this token version.</value>
        [DataMember(Name = "lastRetriedOn", EmitDefaultValue = false)]
        public DateTime LastRetriedOn { get; private set; }

        /// <summary>
        /// Returns false as LastRetriedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastRetriedOn()
        {
            return false;
        }
        /// <summary>
        /// The labels providing additional information about the object.
        /// </summary>
        /// <value>The labels providing additional information about the object.</value>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<Label> Labels { get; private set; }

        /// <summary>
        /// Returns false as Labels should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLabels()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public Token Token { get; set; }

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
        /// The date and time when the token version was activated.
        /// </summary>
        /// <value>The date and time when the token version was activated.</value>
        [DataMember(Name = "activatedOn", EmitDefaultValue = false)]
        public DateTime ActivatedOn { get; private set; }

        /// <summary>
        /// Returns false as ActivatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeActivatedOn()
        {
            return false;
        }
        /// <summary>
        /// The name used to identify the token.
        /// </summary>
        /// <value>The name used to identify the token.</value>
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
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenVersion {\n");
            sb.Append("  PaymentInformationHashes: ").Append(PaymentInformationHashes).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  RetryIn: ").Append(RetryIn).Append("\n");
            sb.Append("  PaymentConnectorConfiguration: ").Append(PaymentConnectorConfiguration).Append("\n");
            sb.Append("  ObsoletedOn: ").Append(ObsoletedOn).Append("\n");
            sb.Append("  ExpiresOn: ").Append(ExpiresOn).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ProcessorToken: ").Append(ProcessorToken).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  PaymentMethodBrand: ").Append(PaymentMethodBrand).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  LastRetriedOn: ").Append(LastRetriedOn).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  RetryStrategy: ").Append(RetryStrategy).Append("\n");
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
            // ProcessorToken (string) maxLength
            if (this.ProcessorToken != null && this.ProcessorToken.Length > 150)
            {
                yield return new ValidationResult("Invalid value for ProcessorToken, length must be less than 150.", new [] { "ProcessorToken" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 150)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 150.", new [] { "Name" });
            }

            yield break;
        }
    }

}
