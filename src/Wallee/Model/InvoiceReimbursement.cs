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
    /// InvoiceReimbursement
    /// </summary>
    [DataContract(Name = "InvoiceReimbursement")]
    public partial class InvoiceReimbursement : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public InvoiceProcessor? Source { get; set; }

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public ChargeAttemptEnvironment? VarEnvironment { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public InvoiceReimbursementState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceReimbursement" /> class.
        /// </summary>
        /// <param name="source">source.</param>
        /// <param name="varEnvironment">varEnvironment.</param>
        /// <param name="paymentConnectorConfiguration">paymentConnectorConfiguration.</param>
        /// <param name="state">state.</param>
        /// <param name="paymentInitiationAdviceFile">paymentInitiationAdviceFile.</param>
        public InvoiceReimbursement(InvoiceProcessor? source = default, ChargeAttemptEnvironment? varEnvironment = default, PaymentConnectorConfiguration paymentConnectorConfiguration = default, InvoiceReimbursementState? state = default, PaymentInitiationAdviceFile paymentInitiationAdviceFile = default)
        {
            this.Source = source;
            this.VarEnvironment = varEnvironment;
            this.PaymentConnectorConfiguration = paymentConnectorConfiguration;
            this.State = state;
            this.PaymentInitiationAdviceFile = paymentInitiationAdviceFile;
        }

        /// <summary>
        /// Gets or Sets DiscardedOn
        /// </summary>
        [DataMember(Name = "discardedOn", EmitDefaultValue = false)]
        public DateTime DiscardedOn { get; private set; }

        /// <summary>
        /// Returns false as DiscardedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscardedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; private set; }

        /// <summary>
        /// Returns false as Amount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RecipientGivenName
        /// </summary>
        [DataMember(Name = "recipientGivenName", EmitDefaultValue = false)]
        public string RecipientGivenName { get; private set; }

        /// <summary>
        /// Returns false as RecipientGivenName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientGivenName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RecipientIban
        /// </summary>
        [DataMember(Name = "recipientIban", EmitDefaultValue = false)]
        public string RecipientIban { get; private set; }

        /// <summary>
        /// Returns false as RecipientIban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientIban()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RecipientOrganizationName
        /// </summary>
        [DataMember(Name = "recipientOrganizationName", EmitDefaultValue = false)]
        public string RecipientOrganizationName { get; private set; }

        /// <summary>
        /// Returns false as RecipientOrganizationName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientOrganizationName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RecipientStreet
        /// </summary>
        [DataMember(Name = "recipientStreet", EmitDefaultValue = false)]
        public string RecipientStreet { get; private set; }

        /// <summary>
        /// Returns false as RecipientStreet should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientStreet()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DiscardedBy
        /// </summary>
        [DataMember(Name = "discardedBy", EmitDefaultValue = false)]
        public long DiscardedBy { get; private set; }

        /// <summary>
        /// Returns false as DiscardedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDiscardedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SenderIban
        /// </summary>
        [DataMember(Name = "senderIban", EmitDefaultValue = false)]
        public string SenderIban { get; private set; }

        /// <summary>
        /// Returns false as SenderIban should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSenderIban()
        {
            return false;
        }
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
        /// Gets or Sets RecipientFamilyName
        /// </summary>
        [DataMember(Name = "recipientFamilyName", EmitDefaultValue = false)]
        public string RecipientFamilyName { get; private set; }

        /// <summary>
        /// Returns false as RecipientFamilyName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientFamilyName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ProcessedOn
        /// </summary>
        [DataMember(Name = "processedOn", EmitDefaultValue = false)]
        public DateTime ProcessedOn { get; private set; }

        /// <summary>
        /// Returns false as ProcessedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentConnectorConfiguration
        /// </summary>
        [DataMember(Name = "paymentConnectorConfiguration", EmitDefaultValue = false)]
        public PaymentConnectorConfiguration PaymentConnectorConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets RecipientPostcode
        /// </summary>
        [DataMember(Name = "recipientPostcode", EmitDefaultValue = false)]
        public string RecipientPostcode { get; private set; }

        /// <summary>
        /// Returns false as RecipientPostcode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientPostcode()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
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
        /// Gets or Sets RecipientCountry
        /// </summary>
        [DataMember(Name = "recipientCountry", EmitDefaultValue = false)]
        public string RecipientCountry { get; private set; }

        /// <summary>
        /// Returns false as RecipientCountry should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientCountry()
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
        /// Gets or Sets ProcessedBy
        /// </summary>
        [DataMember(Name = "processedBy", EmitDefaultValue = false)]
        public long ProcessedBy { get; private set; }

        /// <summary>
        /// Returns false as ProcessedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProcessedBy()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RecipientCity
        /// </summary>
        [DataMember(Name = "recipientCity", EmitDefaultValue = false)]
        public string RecipientCity { get; private set; }

        /// <summary>
        /// Returns false as RecipientCity should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRecipientCity()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PaymentInitiationAdviceFile
        /// </summary>
        [DataMember(Name = "paymentInitiationAdviceFile", EmitDefaultValue = false)]
        public PaymentInitiationAdviceFile PaymentInitiationAdviceFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceReimbursement {\n");
            sb.Append("  DiscardedOn: ").Append(DiscardedOn).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RecipientGivenName: ").Append(RecipientGivenName).Append("\n");
            sb.Append("  RecipientIban: ").Append(RecipientIban).Append("\n");
            sb.Append("  RecipientOrganizationName: ").Append(RecipientOrganizationName).Append("\n");
            sb.Append("  RecipientStreet: ").Append(RecipientStreet).Append("\n");
            sb.Append("  DiscardedBy: ").Append(DiscardedBy).Append("\n");
            sb.Append("  SenderIban: ").Append(SenderIban).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  RecipientFamilyName: ").Append(RecipientFamilyName).Append("\n");
            sb.Append("  ProcessedOn: ").Append(ProcessedOn).Append("\n");
            sb.Append("  PaymentConnectorConfiguration: ").Append(PaymentConnectorConfiguration).Append("\n");
            sb.Append("  RecipientPostcode: ").Append(RecipientPostcode).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RecipientCountry: ").Append(RecipientCountry).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ProcessedBy: ").Append(ProcessedBy).Append("\n");
            sb.Append("  RecipientCity: ").Append(RecipientCity).Append("\n");
            sb.Append("  PaymentInitiationAdviceFile: ").Append(PaymentInitiationAdviceFile).Append("\n");
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
