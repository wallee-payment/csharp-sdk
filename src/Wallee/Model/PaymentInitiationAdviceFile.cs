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
    /// PaymentInitiationAdviceFile
    /// </summary>
    [DataContract(Name = "PaymentInitiationAdviceFile")]
    public partial class PaymentInitiationAdviceFile : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public PaymentInitiationAdviceFileState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInitiationAdviceFile" /> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="processor">processor.</param>
        public PaymentInitiationAdviceFile(PaymentInitiationAdviceFileState? state = default, PaymentProcessor processor = default)
        {
            this.State = state;
            this.Processor = processor;
        }

        /// <summary>
        /// The shipping date indicates the date on which the pain file was transferred to an external processing system.
        /// </summary>
        /// <value>The shipping date indicates the date on which the pain file was transferred to an external processing system.</value>
        [DataMember(Name = "forwardedOn", EmitDefaultValue = false)]
        public DateTime ForwardedOn { get; private set; }

        /// <summary>
        /// Returns false as ForwardedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeForwardedOn()
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
        /// Gets or Sets FileGeneratedOn
        /// </summary>
        [DataMember(Name = "fileGeneratedOn", EmitDefaultValue = false)]
        public DateTime FileGeneratedOn { get; private set; }

        /// <summary>
        /// Returns false as FileGeneratedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFileGeneratedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
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
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
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
        /// Gets or Sets FailureMessage
        /// </summary>
        [DataMember(Name = "failureMessage", EmitDefaultValue = false)]
        public string FailureMessage { get; private set; }

        /// <summary>
        /// Returns false as FailureMessage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFailureMessage()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Processor
        /// </summary>
        [DataMember(Name = "processor", EmitDefaultValue = false)]
        public PaymentProcessor Processor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentInitiationAdviceFile {\n");
            sb.Append("  ForwardedOn: ").Append(ForwardedOn).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  ProcessedOn: ").Append(ProcessedOn).Append("\n");
            sb.Append("  FileGeneratedOn: ").Append(FileGeneratedOn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  FailureMessage: ").Append(FailureMessage).Append("\n");
            sb.Append("  Processor: ").Append(Processor).Append("\n");
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
