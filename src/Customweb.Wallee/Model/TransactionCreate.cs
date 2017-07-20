/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Customweb.Wallee.Model
{
    /// <summary>
    /// Transaction
    /// </summary>
    [DataContract]
    public partial class TransactionCreate : AbstractTransactionPending,  IEquatable<TransactionCreate>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionCreate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionCreate" /> class.
        /// </summary>
        /// <param name="ChargeRetryEnabled">When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.</param>
        /// <param name="CustomersPresence">CustomersPresence (required)</param>
        /// <param name="SpaceViewId">SpaceViewId</param>
        public TransactionCreate(string InvoiceMerchantReference = default(string), string SuccessUrl = default(string), List<LineItemCreate> LineItems = default(List<LineItemCreate>), string Language = default(string), string Currency = default(string), string FailedUrl = default(string), bool? ChargeRetryEnabled = default(bool?), Dictionary<string, string> MetaData = default(Dictionary<string, string>), CustomersPresence? CustomersPresence = default(CustomersPresence?), string CustomerId = default(string), List<long?> AllowedPaymentMethodConfigurations = default(List<long?>), string MerchantReference = default(string), AddressCreate ShippingAddress = default(AddressCreate), long? SpaceViewId = default(long?), long? Token = default(long?), string ShippingMethod = default(string), AddressCreate BillingAddress = default(AddressCreate), List<PaymentMethodBrand> AllowedPaymentMethodBrands = default(List<PaymentMethodBrand>), string CustomerEmailAddress = default(string))
        {
            // to ensure "CustomersPresence" is required (not null)
            if (CustomersPresence == null)
            {
                throw new ArgumentNullException("CustomersPresence is a required property for TransactionCreate and cannot be null");
            }
            else
            {
                this.CustomersPresence = CustomersPresence;
            }
            this.ChargeRetryEnabled = ChargeRetryEnabled;
            this.SpaceViewId = SpaceViewId;
            this.AllowedPaymentMethodBrands = AllowedPaymentMethodBrands;
            this.AllowedPaymentMethodConfigurations = AllowedPaymentMethodConfigurations;
            this.BillingAddress = BillingAddress;
            this.Currency = Currency;
            this.CustomerEmailAddress = CustomerEmailAddress;
            this.CustomerId = CustomerId;
            this.FailedUrl = FailedUrl;
            this.InvoiceMerchantReference = InvoiceMerchantReference;
            this.Language = Language;
            this.LineItems = LineItems;
            this.MerchantReference = MerchantReference;
            this.MetaData = MetaData;
            this.ShippingAddress = ShippingAddress;
            this.ShippingMethod = ShippingMethod;
            this.SuccessUrl = SuccessUrl;
            this.Token = Token;
        }

        /// <summary>
        /// When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.
        /// </summary>
        /// <value>When the charging of the customer fails we can retry the charging. This implies that we redirect the user back to the payment page which allows the customer to retry. By default we will retry.</value>
        [DataMember(Name="chargeRetryEnabled", EmitDefaultValue=false)]
        public bool? ChargeRetryEnabled { get; set; }

        /// <summary>
        /// CustomersPresence
        /// </summary>
        /// <value>CustomersPresence</value>
        [DataMember(Name="customersPresence", EmitDefaultValue=false)]
        public CustomersPresence? CustomersPresence { get; set; }

        /// <summary>
        /// SpaceViewId
        /// </summary>
        /// <value>SpaceViewId</value>
        [DataMember(Name="spaceViewId", EmitDefaultValue=false)]
        public long? SpaceViewId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return this.ToJson();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj as TransactionCreate);
        }

        /// <summary>
        /// Returns true if TransactionCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionCreate other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.ChargeRetryEnabled == other.ChargeRetryEnabled ||
                    this.ChargeRetryEnabled != null &&
                    this.ChargeRetryEnabled.Equals(other.ChargeRetryEnabled)
                ) && 
                (
                    this.CustomersPresence == other.CustomersPresence ||
                    this.CustomersPresence != null &&
                    this.CustomersPresence.Equals(other.CustomersPresence)
                ) && 
                (
                    this.SpaceViewId == other.SpaceViewId ||
                    this.SpaceViewId != null &&
                    this.SpaceViewId.Equals(other.SpaceViewId)
                ) && 
                (
                    this.AllowedPaymentMethodBrands == other.AllowedPaymentMethodBrands ||
                    this.AllowedPaymentMethodBrands != null &&
                    this.AllowedPaymentMethodBrands.SequenceEqual(other.AllowedPaymentMethodBrands)
                ) && 
                (
                    this.AllowedPaymentMethodConfigurations == other.AllowedPaymentMethodConfigurations ||
                    this.AllowedPaymentMethodConfigurations != null &&
                    this.AllowedPaymentMethodConfigurations.SequenceEqual(other.AllowedPaymentMethodConfigurations)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.CustomerEmailAddress == other.CustomerEmailAddress ||
                    this.CustomerEmailAddress != null &&
                    this.CustomerEmailAddress.Equals(other.CustomerEmailAddress)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.FailedUrl == other.FailedUrl ||
                    this.FailedUrl != null &&
                    this.FailedUrl.Equals(other.FailedUrl)
                ) && 
                (
                    this.InvoiceMerchantReference == other.InvoiceMerchantReference ||
                    this.InvoiceMerchantReference != null &&
                    this.InvoiceMerchantReference.Equals(other.InvoiceMerchantReference)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.MerchantReference == other.MerchantReference ||
                    this.MerchantReference != null &&
                    this.MerchantReference.Equals(other.MerchantReference)
                ) && 
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.SequenceEqual(other.MetaData)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.ShippingMethod == other.ShippingMethod ||
                    this.ShippingMethod != null &&
                    this.ShippingMethod.Equals(other.ShippingMethod)
                ) && 
                (
                    this.SuccessUrl == other.SuccessUrl ||
                    this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(other.SuccessUrl)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                if (this.ChargeRetryEnabled != null)
                {
                    hash = hash * 59 + this.ChargeRetryEnabled.GetHashCode();
                }
                if (this.CustomersPresence != null)
                {
                    hash = hash * 59 + this.CustomersPresence.GetHashCode();
                }
                if (this.SpaceViewId != null)
                {
                    hash = hash * 59 + this.SpaceViewId.GetHashCode();
                }
                if (this.AllowedPaymentMethodBrands != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodBrands.GetHashCode();
                }
                if (this.AllowedPaymentMethodConfigurations != null)
                {
                    hash = hash * 59 + this.AllowedPaymentMethodConfigurations.GetHashCode();
                }
                if (this.BillingAddress != null)
                {
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hash = hash * 59 + this.Currency.GetHashCode();
                }
                if (this.CustomerEmailAddress != null)
                {
                    hash = hash * 59 + this.CustomerEmailAddress.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                }
                if (this.FailedUrl != null)
                {
                    hash = hash * 59 + this.FailedUrl.GetHashCode();
                }
                if (this.InvoiceMerchantReference != null)
                {
                    hash = hash * 59 + this.InvoiceMerchantReference.GetHashCode();
                }
                if (this.Language != null)
                {
                    hash = hash * 59 + this.Language.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hash = hash * 59 + this.LineItems.GetHashCode();
                }
                if (this.MerchantReference != null)
                {
                    hash = hash * 59 + this.MerchantReference.GetHashCode();
                }
                if (this.MetaData != null)
                {
                    hash = hash * 59 + this.MetaData.GetHashCode();
                }
                if (this.ShippingAddress != null)
                {
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                }
                if (this.ShippingMethod != null)
                {
                    hash = hash * 59 + this.ShippingMethod.GetHashCode();
                }
                if (this.SuccessUrl != null)
                {
                    hash = hash * 59 + this.SuccessUrl.GetHashCode();
                }
                if (this.Token != null)
                {
                    hash = hash * 59 + this.Token.GetHashCode();
                }
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
