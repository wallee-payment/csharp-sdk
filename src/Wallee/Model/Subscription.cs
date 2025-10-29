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
    /// Subscription
    /// </summary>
    [DataContract(Name = "Subscription")]
    public partial class Subscription : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public SubscriptionState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="subscriber">subscriber.</param>
        /// <param name="token">token.</param>
        /// <param name="currentProductVersion">currentProductVersion.</param>
        /// <param name="state">state.</param>
        /// <param name="affiliate">affiliate.</param>
        public Subscription(Subscriber subscriber = default(Subscriber), Token token = default(Token), SubscriptionProductVersion currentProductVersion = default(SubscriptionProductVersion), SubscriptionState? state = default(SubscriptionState?), SubscriptionAffiliate affiliate = default(SubscriptionAffiliate))
        {
            this.Subscriber = subscriber;
            this.Token = token;
            this.CurrentProductVersion = currentProductVersion;
            this.State = state;
            this.Affiliate = affiliate;
        }

        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name = "subscriber", EmitDefaultValue = false)]
        public Subscriber Subscriber { get; set; }

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
        /// The ID of the user the subscription was terminated by.
        /// </summary>
        /// <value>The ID of the user the subscription was terminated by.</value>
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
        /// A description used to identify the subscription.
        /// </summary>
        /// <value>A description used to identify the subscription.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
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
        /// The date and time when the subscription was initialized.
        /// </summary>
        /// <value>The date and time when the subscription was initialized.</value>
        [DataMember(Name = "initializedOn", EmitDefaultValue = false)]
        public DateTime InitializedOn { get; private set; }

        /// <summary>
        /// Returns false as InitializedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInitializedOn()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the subscription was created.
        /// </summary>
        /// <value>The date and time when the subscription was created.</value>
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
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public Token Token { get; set; }

        /// <summary>
        /// The merchant&#39;s reference used to identify the subscription.
        /// </summary>
        /// <value>The merchant&#39;s reference used to identify the subscription.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; private set; }

        /// <summary>
        /// Returns false as Reference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeReference()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the subscription was terminated.
        /// </summary>
        /// <value>The date and time when the subscription was terminated.</value>
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
        /// The date and time when the subscription was activate.
        /// </summary>
        /// <value>The date and time when the subscription was activate.</value>
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
        /// The date and time when the termination of the subscription started.
        /// </summary>
        /// <value>The date and time when the termination of the subscription started.</value>
        [DataMember(Name = "terminatingOn", EmitDefaultValue = false)]
        public DateTime TerminatingOn { get; private set; }

        /// <summary>
        /// Returns false as TerminatingOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTerminatingOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CurrentProductVersion
        /// </summary>
        [DataMember(Name = "currentProductVersion", EmitDefaultValue = false)]
        public SubscriptionProductVersion CurrentProductVersion { get; set; }

        /// <summary>
        /// The date and time when the subscription is planned to be terminated.
        /// </summary>
        /// <value>The date and time when the subscription is planned to be terminated.</value>
        [DataMember(Name = "plannedTerminationDate", EmitDefaultValue = false)]
        public DateTime PlannedTerminationDate { get; private set; }

        /// <summary>
        /// Returns false as PlannedTerminationDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePlannedTerminationDate()
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
        /// Gets or Sets Affiliate
        /// </summary>
        [DataMember(Name = "affiliate", EmitDefaultValue = false)]
        public SubscriptionAffiliate Affiliate { get; set; }

        /// <summary>
        /// The date and time when the subscription was scheduled to be terminated.
        /// </summary>
        /// <value>The date and time when the subscription was scheduled to be terminated.</value>
        [DataMember(Name = "terminationScheduledOn", EmitDefaultValue = false)]
        public DateTime TerminationScheduledOn { get; private set; }

        /// <summary>
        /// Returns false as TerminationScheduledOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTerminationScheduledOn()
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
            sb.Append("class Subscription {\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  TerminatedBy: ").Append(TerminatedBy).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  InitializedOn: ").Append(InitializedOn).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  TerminatedOn: ").Append(TerminatedOn).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  TerminatingOn: ").Append(TerminatingOn).Append("\n");
            sb.Append("  CurrentProductVersion: ").Append(CurrentProductVersion).Append("\n");
            sb.Append("  PlannedTerminationDate: ").Append(PlannedTerminationDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Affiliate: ").Append(Affiliate).Append("\n");
            sb.Append("  TerminationScheduledOn: ").Append(TerminationScheduledOn).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 200)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 200.", new [] { "Description" });
            }

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

            yield break;
        }
    }

}
