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
    /// A subscriber represents everyone who is subscribed to a product.
    /// </summary>
    [DataContract(Name = "Subscriber.Create")]
    public partial class SubscriberCreate : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public CreationEntityState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriberCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberCreate" /> class.
        /// </summary>
        /// <param name="reference">The merchant&#39;s reference used to identify the subscriber..</param>
        /// <param name="additionalAllowedPaymentMethodConfigurations">Allow the subscriber to use these payment methods even if subscription products do not accept them..</param>
        /// <param name="metaData">Allow to store additional information about the object..</param>
        /// <param name="emailAddress">The email address that is used to communicate with the subscriber. There can be only one subscriber per space with the same email address..</param>
        /// <param name="disallowedPaymentMethodConfigurations">Prevent the subscriber from using these payment methods even if subscription products do accept them..</param>
        /// <param name="description">The description used to identify the subscriber..</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="language">The language that is used when communicating with the subscriber via emails and documents..</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="externalId">A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result. (required).</param>
        /// <param name="state">state.</param>
        public SubscriberCreate(string reference = default(string), List<long> additionalAllowedPaymentMethodConfigurations = default(List<long>), Dictionary<string, string> metaData = default(Dictionary<string, string>), string emailAddress = default(string), List<long> disallowedPaymentMethodConfigurations = default(List<long>), string description = default(string), AddressCreate shippingAddress = default(AddressCreate), string language = default(string), AddressCreate billingAddress = default(AddressCreate), string externalId = default(string), CreationEntityState? state = default(CreationEntityState?))
        {
            // to ensure "externalId" is required (not null)
            if (externalId == null)
            {
                throw new ArgumentNullException("externalId is a required property for SubscriberCreate and cannot be null");
            }
            this.ExternalId = externalId;
            this.Reference = reference;
            this.AdditionalAllowedPaymentMethodConfigurations = additionalAllowedPaymentMethodConfigurations;
            this.MetaData = metaData;
            this.EmailAddress = emailAddress;
            this.DisallowedPaymentMethodConfigurations = disallowedPaymentMethodConfigurations;
            this.Description = description;
            this.ShippingAddress = shippingAddress;
            this.Language = language;
            this.BillingAddress = billingAddress;
            this.State = state;
        }

        /// <summary>
        /// The merchant&#39;s reference used to identify the subscriber.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the subscriber.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Allow the subscriber to use these payment methods even if subscription products do not accept them.
        /// </summary>
        /// <value>Allow the subscriber to use these payment methods even if subscription products do not accept them.</value>
        [DataMember(Name = "additionalAllowedPaymentMethodConfigurations", EmitDefaultValue = false)]
        public List<long> AdditionalAllowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// Allow to store additional information about the object.
        /// </summary>
        /// <value>Allow to store additional information about the object.</value>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// The email address that is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.
        /// </summary>
        /// <value>The email address that is used to communicate with the subscriber. There can be only one subscriber per space with the same email address.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Prevent the subscriber from using these payment methods even if subscription products do accept them.
        /// </summary>
        /// <value>Prevent the subscriber from using these payment methods even if subscription products do accept them.</value>
        [DataMember(Name = "disallowedPaymentMethodConfigurations", EmitDefaultValue = false)]
        public List<long> DisallowedPaymentMethodConfigurations { get; set; }

        /// <summary>
        /// The description used to identify the subscriber.
        /// </summary>
        /// <value>The description used to identify the subscriber.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        public AddressCreate ShippingAddress { get; set; }

        /// <summary>
        /// The language that is used when communicating with the subscriber via emails and documents.
        /// </summary>
        /// <value>The language that is used when communicating with the subscriber via emails and documents.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public AddressCreate BillingAddress { get; set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriberCreate {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  AdditionalAllowedPaymentMethodConfigurations: ").Append(AdditionalAllowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  DisallowedPaymentMethodConfigurations: ").Append(DisallowedPaymentMethodConfigurations).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Reference, length must be less than 100.", new [] { "Reference" });
            }

            if (this.Reference != null) {
                // Reference (string) pattern
                Regex regexReference = new Regex(@"[	\x20-\x7e]*", RegexOptions.CultureInvariant);
                if (!regexReference.Match(this.Reference).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, must match a pattern of " + regexReference, new [] { "Reference" });
                }
            }

            // EmailAddress (string) maxLength
            if (this.EmailAddress != null && this.EmailAddress.Length > 254)
            {
                yield return new ValidationResult("Invalid value for EmailAddress, length must be less than 254.", new [] { "EmailAddress" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 200)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 200.", new [] { "Description" });
            }

            yield break;
        }
    }

}
