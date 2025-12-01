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
    /// PaymentContract
    /// </summary>
    [DataContract(Name = "PaymentContract")]
    public partial class PaymentContract : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public PaymentContractState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentContract" /> class.
        /// </summary>
        /// <param name="contractType">contractType.</param>
        /// <param name="state">state.</param>
        /// <param name="rejectionReason">rejectionReason.</param>
        public PaymentContract(PaymentContractType contractType = default, PaymentContractState? state = default, FailureReason rejectionReason = default)
        {
            this.ContractType = contractType;
            this.State = state;
            this.RejectionReason = rejectionReason;
        }

        /// <summary>
        /// Gets or Sets ContractType
        /// </summary>
        [DataMember(Name = "contractType", EmitDefaultValue = false)]
        public PaymentContractType ContractType { get; set; }

        /// <summary>
        /// The ID of the user the contract was terminated by.
        /// </summary>
        /// <value>The ID of the user the contract was terminated by.</value>
        [DataMember(Name = "terminatedBy", EmitDefaultValue = false)]
        public long TerminatedBy { get; private set; }

        /// <summary>
        /// Returns false as TerminatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTerminatedBy()
        {
            return false;
        }
        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// Returns false as ExternalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeExternalId()
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
        /// The date and time when the contract was terminated.
        /// </summary>
        /// <value>The date and time when the contract was terminated.</value>
        [DataMember(Name = "terminatedOn", EmitDefaultValue = false)]
        public DateTime TerminatedOn { get; private set; }

        /// <summary>
        /// Returns false as TerminatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTerminatedOn()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the contract was activated.
        /// </summary>
        /// <value>The date and time when the contract was activated.</value>
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
        /// The date and time when the termination process of the contract was started.
        /// </summary>
        /// <value>The date and time when the termination process of the contract was started.</value>
        [DataMember(Name = "startTerminatingOn", EmitDefaultValue = false)]
        public DateTime StartTerminatingOn { get; private set; }

        /// <summary>
        /// Returns false as StartTerminatingOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStartTerminatingOn()
        {
            return false;
        }
        /// <summary>
        /// The ID of the user the contract was created by.
        /// </summary>
        /// <value>The ID of the user the contract was created by.</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public long CreatedBy { get; private set; }

        /// <summary>
        /// Returns false as CreatedBy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedBy()
        {
            return false;
        }
        /// <summary>
        /// The identifier of the contract.
        /// </summary>
        /// <value>The identifier of the contract.</value>
        [DataMember(Name = "contractIdentifier", EmitDefaultValue = false)]
        public string ContractIdentifier { get; private set; }

        /// <summary>
        /// Returns false as ContractIdentifier should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContractIdentifier()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the contract was rejected.
        /// </summary>
        /// <value>The date and time when the contract was rejected.</value>
        [DataMember(Name = "rejectedOn", EmitDefaultValue = false)]
        public DateTime RejectedOn { get; private set; }

        /// <summary>
        /// Returns false as RejectedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRejectedOn()
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
        /// Gets or Sets RejectionReason
        /// </summary>
        [DataMember(Name = "rejectionReason", EmitDefaultValue = false)]
        public FailureReason RejectionReason { get; set; }

        /// <summary>
        /// This account that the contract belongs to.
        /// </summary>
        /// <value>This account that the contract belongs to.</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public long Account { get; private set; }

        /// <summary>
        /// Returns false as Account should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccount()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentContract {\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  TerminatedBy: ").Append(TerminatedBy).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  TerminatedOn: ").Append(TerminatedOn).Append("\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  StartTerminatingOn: ").Append(StartTerminatingOn).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ContractIdentifier: ").Append(ContractIdentifier).Append("\n");
            sb.Append("  RejectedOn: ").Append(RejectedOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  RejectionReason: ").Append(RejectionReason).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
