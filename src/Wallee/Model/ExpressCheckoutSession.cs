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
        /// Gets or Sets AuthorizationEnvironment
        /// </summary>
        [DataMember(Name = "authorizationEnvironment", EmitDefaultValue = false)]
        public ChargeAttemptEnvironment? AuthorizationEnvironment { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public ExpressCheckoutSessionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressCheckoutSession" /> class.
        /// </summary>
        /// <param name="walletType">walletType.</param>
        /// <param name="authorizationEnvironment">authorizationEnvironment.</param>
        /// <param name="failureReason">failureReason.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="state">state.</param>
        /// <param name="transaction">transaction.</param>
        public ExpressCheckoutSession(ExpressCheckoutWalletType walletType = default, ChargeAttemptEnvironment? authorizationEnvironment = default, FailureReason failureReason = default, Address shippingAddress = default, Address billingAddress = default, ExpressCheckoutSessionState? state = default, Transaction transaction = default)
        {
            this.WalletType = walletType;
            this.AuthorizationEnvironment = authorizationEnvironment;
            this.FailureReason = failureReason;
            this.ShippingAddress = shippingAddress;
            this.BillingAddress = billingAddress;
            this.State = state;
            this.Transaction = transaction;
        }

        /// <summary>
        /// The URL to fetch the shipping options from.
        /// </summary>
        /// <value>The URL to fetch the shipping options from.</value>
        [DataMember(Name = "merchantShippingCallbackUrl", EmitDefaultValue = false)]
        public string MerchantShippingCallbackUrl { get; private set; }

        /// <summary>
        /// Returns false as MerchantShippingCallbackUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMerchantShippingCallbackUrl()
        {
            return false;
        }
        /// <summary>
        /// The total amount of the session.
        /// </summary>
        /// <value>The total amount of the session.</value>
        [DataMember(Name = "authorizationAmount", EmitDefaultValue = false)]
        public decimal AuthorizationAmount { get; private set; }

        /// <summary>
        /// Returns false as AuthorizationAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAuthorizationAmount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets WalletType
        /// </summary>
        [DataMember(Name = "walletType", EmitDefaultValue = false)]
        public ExpressCheckoutWalletType WalletType { get; set; }

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
        /// Customer time zone for presentation and cutoffs (same semantics as on Transaction).
        /// </summary>
        /// <value>Customer time zone for presentation and cutoffs (same semantics as on Transaction).</value>
        [DataMember(Name = "timeZone", EmitDefaultValue = false)]
        public string VarTimeZone { get; private set; }

        /// <summary>
        /// Returns false as VarTimeZone should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarTimeZone()
        {
            return false;
        }
        /// <summary>
        /// Preferred language for customer-facing content (same semantics as on Transaction).
        /// </summary>
        /// <value>Preferred language for customer-facing content (same semantics as on Transaction).</value>
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
        /// The date and time when the session was created.
        /// </summary>
        /// <value>The date and time when the session was created.</value>
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
        /// The base URL on the merchant shop used to create the order.
        /// </summary>
        /// <value>The base URL on the merchant shop used to create the order.</value>
        [DataMember(Name = "merchantRedirectUrl", EmitDefaultValue = false)]
        public string MerchantRedirectUrl { get; private set; }

        /// <summary>
        /// Returns false as MerchantRedirectUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMerchantRedirectUrl()
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
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name = "failureReason", EmitDefaultValue = false)]
        public FailureReason FailureReason { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        public Address ShippingAddress { get; set; }

        /// <summary>
        /// The currency of the session.
        /// </summary>
        /// <value>The currency of the session.</value>
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
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public Address BillingAddress { get; set; }

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
        /// The payment transaction this object is linked to.
        /// </summary>
        /// <value>The payment transaction this object is linked to.</value>
        [DataMember(Name = "linkedTransaction", EmitDefaultValue = false)]
        public long LinkedTransaction { get; private set; }

        /// <summary>
        /// Returns false as LinkedTransaction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinkedTransaction()
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
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpressCheckoutSession {\n");
            sb.Append("  MerchantShippingCallbackUrl: ").Append(MerchantShippingCallbackUrl).Append("\n");
            sb.Append("  AuthorizationAmount: ").Append(AuthorizationAmount).Append("\n");
            sb.Append("  WalletType: ").Append(WalletType).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  VarTimeZone: ").Append(VarTimeZone).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  MerchantRedirectUrl: ").Append(MerchantRedirectUrl).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  AuthorizationEnvironment: ").Append(AuthorizationEnvironment).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  ShippingOptions: ").Append(ShippingOptions).Append("\n");
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
