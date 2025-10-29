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
    /// PaymentAppProcessor
    /// </summary>
    [DataContract(Name = "PaymentAppProcessor")]
    public partial class PaymentAppProcessor : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ConfiguredEnvironment
        /// </summary>
        [DataMember(Name = "configuredEnvironment", EmitDefaultValue = false)]
        public ChargeAttemptEnvironment? ConfiguredEnvironment { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public PaymentAppProcessorState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppProcessor" /> class.
        /// </summary>
        /// <param name="configuredEnvironment">configuredEnvironment.</param>
        /// <param name="processorConfiguration">processorConfiguration.</param>
        /// <param name="state">state.</param>
        public PaymentAppProcessor(ChargeAttemptEnvironment? configuredEnvironment = default(ChargeAttemptEnvironment?), PaymentProcessorConfiguration processorConfiguration = default(PaymentProcessorConfiguration), PaymentAppProcessorState? state = default(PaymentAppProcessorState?))
        {
            this.ConfiguredEnvironment = configuredEnvironment;
            this.ProcessorConfiguration = processorConfiguration;
            this.State = state;
        }

        /// <summary>
        /// A URL pointing to the documentation that explains how to configure and use the processor.
        /// </summary>
        /// <value>A URL pointing to the documentation that explains how to configure and use the processor.</value>
        [DataMember(Name = "documentationUrl", EmitDefaultValue = false)]
        public string DocumentationUrl { get; private set; }

        /// <summary>
        /// Returns false as DocumentationUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDocumentationUrl()
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
        /// An SVG icon representing the processor, displayed to the user in the interface.
        /// </summary>
        /// <value>An SVG icon representing the processor, displayed to the user in the interface.</value>
        [DataMember(Name = "svgIcon", EmitDefaultValue = false)]
        public string SvgIcon { get; private set; }

        /// <summary>
        /// Returns false as SvgIcon should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSvgIcon()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the processor was last updated.
        /// </summary>
        /// <value>The date and time when the processor was last updated.</value>
        [DataMember(Name = "updatedOn", EmitDefaultValue = false)]
        public DateTime UpdatedOn { get; private set; }

        /// <summary>
        /// Returns false as UpdatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedOn()
        {
            return false;
        }
        /// <summary>
        /// Whether the processor is fully prepared and available for handling transactions in a production environment.
        /// </summary>
        /// <value>Whether the processor is fully prepared and available for handling transactions in a production environment.</value>
        [DataMember(Name = "usableInProduction", EmitDefaultValue = true)]
        public bool UsableInProduction { get; private set; }

        /// <summary>
        /// Returns false as UsableInProduction should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUsableInProduction()
        {
            return false;
        }
        /// <summary>
        /// The date and time when the processor was created.
        /// </summary>
        /// <value>The date and time when the processor was created.</value>
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
        /// Gets or Sets ProcessorConfiguration
        /// </summary>
        [DataMember(Name = "processorConfiguration", EmitDefaultValue = false)]
        public PaymentProcessorConfiguration ProcessorConfiguration { get; set; }

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
        /// the date and time when the processor became fully usable and available for handling transactions in a production environment.
        /// </summary>
        /// <value>the date and time when the processor became fully usable and available for handling transactions in a production environment.</value>
        [DataMember(Name = "usableInProductionSince", EmitDefaultValue = false)]
        public DateTime UsableInProductionSince { get; private set; }

        /// <summary>
        /// Returns false as UsableInProductionSince should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUsableInProductionSince()
        {
            return false;
        }
        /// <summary>
        /// The name used to identify the processor.
        /// </summary>
        /// <value>The name used to identify the processor.</value>
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
        /// The installation ID identifies the Web App installation.
        /// </summary>
        /// <value>The installation ID identifies the Web App installation.</value>
        [DataMember(Name = "installationId", EmitDefaultValue = false)]
        public long InstallationId { get; private set; }

        /// <summary>
        /// Returns false as InstallationId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInstallationId()
        {
            return false;
        }
        /// <summary>
        /// A URL pointing to the site where merchants can set up production mode for the processor.
        /// </summary>
        /// <value>A URL pointing to the site where merchants can set up production mode for the processor.</value>
        [DataMember(Name = "productionModeUrl", EmitDefaultValue = false)]
        public string ProductionModeUrl { get; private set; }

        /// <summary>
        /// Returns false as ProductionModeUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProductionModeUrl()
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
            sb.Append("class PaymentAppProcessor {\n");
            sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
            sb.Append("  ConfiguredEnvironment: ").Append(ConfiguredEnvironment).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  SvgIcon: ").Append(SvgIcon).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  UsableInProduction: ").Append(UsableInProduction).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  ProcessorConfiguration: ").Append(ProcessorConfiguration).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  UsableInProductionSince: ").Append(UsableInProductionSince).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstallationId: ").Append(InstallationId).Append("\n");
            sb.Append("  ProductionModeUrl: ").Append(ProductionModeUrl).Append("\n");
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
            // ExternalId (string) maxLength
            if (this.ExternalId != null && this.ExternalId.Length > 40)
            {
                yield return new ValidationResult("Invalid value for ExternalId, length must be less than 40.", new [] { "ExternalId" });
            }

            // SvgIcon (string) maxLength
            if (this.SvgIcon != null && this.SvgIcon.Length > 10000)
            {
                yield return new ValidationResult("Invalid value for SvgIcon, length must be less than 10000.", new [] { "SvgIcon" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
