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
    /// SubscriptionUpdate
    /// </summary>
    [DataContract(Name = "Subscription.Update")]
    public partial class SubscriptionUpdate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdate" /> class.
        /// </summary>
        /// <param name="description">A description used to identify the subscription..</param>
        /// <param name="plannedTerminationDate">The date and time when the subscription is planned to be terminated..</param>
        /// <param name="affiliate">The affiliate that led to the creation of the subscription..</param>
        /// <param name="varVersion">The version number indicates the version of the entity. The version is incremented whenever the entity is changed. (required).</param>
        public SubscriptionUpdate(string description = default, DateTime plannedTerminationDate = default, long affiliate = default, int varVersion = default)
        {
            this.VarVersion = varVersion;
            this.Description = description;
            this.PlannedTerminationDate = plannedTerminationDate;
            this.Affiliate = affiliate;
        }

        /// <summary>
        /// A description used to identify the subscription.
        /// </summary>
        /// <value>A description used to identify the subscription.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The date and time when the subscription is planned to be terminated.
        /// </summary>
        /// <value>The date and time when the subscription is planned to be terminated.</value>
        [DataMember(Name = "plannedTerminationDate", EmitDefaultValue = false)]
        public DateTime PlannedTerminationDate { get; set; }

        /// <summary>
        /// The affiliate that led to the creation of the subscription.
        /// </summary>
        /// <value>The affiliate that led to the creation of the subscription.</value>
        [DataMember(Name = "affiliate", EmitDefaultValue = false)]
        public long Affiliate { get; set; }

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
            sb.Append("class SubscriptionUpdate {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PlannedTerminationDate: ").Append(PlannedTerminationDate).Append("\n");
            sb.Append("  Affiliate: ").Append(Affiliate).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 200)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 200.", new [] { "Description" });
            }

            yield break;
        }
    }

}
