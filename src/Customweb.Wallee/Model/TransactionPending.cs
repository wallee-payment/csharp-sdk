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
    public partial class TransactionPending : AbstractTransactionPending,  IEquatable<TransactionPending>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPending" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionPending() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionPending" /> class.
        /// </summary>
        /// <param name="Id">The ID is the primary key of the entity. The ID identifies the entity uniquely. (required)</param>
        /// <param name="Version">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required)</param>
        public TransactionPending(List<long?> AllowedPaymentMethodConfigurations = default(List<long?>), string ShippingMethod = default(string), long? Version = default(long?), long? Id = default(long?), string CustomerEmailAddress = default(string), string Currency = default(string), long? Token = default(long?), AddressCreate BillingAddress = default(AddressCreate), AddressCreate ShippingAddress = default(AddressCreate), string SuccessUrl = default(string), string InvoiceMerchantReference = default(string), List<PaymentMethodBrand> AllowedPaymentMethodBrands = default(List<PaymentMethodBrand>), string Language = default(string), string MerchantReference = default(string), string CustomerId = default(string), Dictionary<string, string> MetaData = default(Dictionary<string, string>), List<LineItemCreate> LineItems = default(List<LineItemCreate>), string FailedUrl = default(string))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new ArgumentNullException("Id is a required property for TransactionPending and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new ArgumentNullException("Version is a required property for TransactionPending and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
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
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public long? Version { get; set; }

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
            return this.Equals(obj as TransactionPending);
        }

        /// <summary>
        /// Returns true if TransactionPending instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionPending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionPending other)
        {
            if (other == null)
            {
                return false;
            }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Id != null)
                {
                    hash = hash * 59 + this.Id.GetHashCode();
                }
                if (this.Version != null)
                {
                    hash = hash * 59 + this.Version.GetHashCode();
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

    }

}
