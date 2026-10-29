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
    /// DunningCaseLevel
    /// </summary>
    [DataContract(Name = "DunningCaseLevel")]
    public partial class DunningCaseLevel : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets VarEnvironment
        /// </summary>
        [DataMember(Name = "environment", EmitDefaultValue = false)]
        public ModelEnvironment? VarEnvironment { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public DunningCaseLevelState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DunningCaseLevel" /> class.
        /// </summary>
        /// <param name="varEnvironment">varEnvironment.</param>
        /// <param name="state">state.</param>
        /// <param name="dunningCase">dunningCase.</param>
        public DunningCaseLevel(ModelEnvironment? varEnvironment = default, DunningCaseLevelState? state = default, DunningCase dunningCase = default)
        {
            this.VarEnvironment = varEnvironment;
            this.State = state;
            this.DunningCase = dunningCase;
        }

        /// <summary>
        /// Gets or Sets CanceledOn
        /// </summary>
        [DataMember(Name = "canceledOn", EmitDefaultValue = false)]
        public DateTime CanceledOn { get; private set; }

        /// <summary>
        /// Returns false as CanceledOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCanceledOn()
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
        /// Gets or Sets FlowLevel
        /// </summary>
        [DataMember(Name = "flowLevel", EmitDefaultValue = false)]
        public long FlowLevel { get; private set; }

        /// <summary>
        /// Returns false as FlowLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFlowLevel()
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
        /// Gets or Sets TimeoutOn
        /// </summary>
        [DataMember(Name = "timeoutOn", EmitDefaultValue = false)]
        public DateTime TimeoutOn { get; private set; }

        /// <summary>
        /// Returns false as TimeoutOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTimeoutOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets SucceededOn
        /// </summary>
        [DataMember(Name = "succeededOn", EmitDefaultValue = false)]
        public DateTime SucceededOn { get; private set; }

        /// <summary>
        /// Returns false as SucceededOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSucceededOn()
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
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name = "invoice", EmitDefaultValue = false)]
        public long Invoice { get; private set; }

        /// <summary>
        /// Returns false as Invoice should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInvoice()
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
        /// Gets or Sets FailedOn
        /// </summary>
        [DataMember(Name = "failedOn", EmitDefaultValue = false)]
        public DateTime FailedOn { get; private set; }

        /// <summary>
        /// Returns false as FailedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets MostRecentLevel
        /// </summary>
        [DataMember(Name = "mostRecentLevel", EmitDefaultValue = true)]
        public bool MostRecentLevel { get; private set; }

        /// <summary>
        /// Returns false as MostRecentLevel should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMostRecentLevel()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DunningCase
        /// </summary>
        [DataMember(Name = "dunningCase", EmitDefaultValue = false)]
        public DunningCase DunningCase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DunningCaseLevel {\n");
            sb.Append("  CanceledOn: ").Append(CanceledOn).Append("\n");
            sb.Append("  PlannedPurgeDate: ").Append(PlannedPurgeDate).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  FlowLevel: ").Append(FlowLevel).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  TimeoutOn: ").Append(TimeoutOn).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  SucceededOn: ").Append(SucceededOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LinkedTransaction: ").Append(LinkedTransaction).Append("\n");
            sb.Append("  FailedOn: ").Append(FailedOn).Append("\n");
            sb.Append("  MostRecentLevel: ").Append(MostRecentLevel).Append("\n");
            sb.Append("  DunningCase: ").Append(DunningCase).Append("\n");
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
