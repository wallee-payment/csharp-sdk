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
using SwaggerDateConverter = Wallee.Client.SwaggerDateConverter;

namespace Wallee.Model
{
    /// <summary>
    /// PaymentAppProcessor
    /// </summary>
    [DataContract]
    public partial class PaymentAppProcessor :  IEquatable<PaymentAppProcessor>
    {
        /// <summary>
        /// The environment (e.g., test or production) currently configured for the processor.
        /// </summary>
        /// <value>The environment (e.g., test or production) currently configured for the processor.</value>
        [DataMember(Name="configuredEnvironment", EmitDefaultValue=false)]
        public ChargeAttemptEnvironment? ConfiguredEnvironment { get; private set; }
        /// <summary>
        /// The object&#39;s current state.
        /// </summary>
        /// <value>The object&#39;s current state.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public PaymentAppProcessorState? State { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentAppProcessor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentAppProcessor()
        {
        }


        /// <summary>
        /// The date and time when the processor was created.
        /// </summary>
        /// <value>The date and time when the processor was created.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// A URL pointing to the documentation that explains how to configure and use the processor.
        /// </summary>
        /// <value>A URL pointing to the documentation that explains how to configure and use the processor.</value>
        [DataMember(Name="documentationUrl", EmitDefaultValue=false)]
        public string DocumentationUrl { get; private set; }

        /// <summary>
        /// A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.
        /// </summary>
        /// <value>A client-generated nonce which uniquely identifies some action to be executed. Subsequent requests with the same external ID do not execute the action again, but return the original result.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// A unique identifier for the object.
        /// </summary>
        /// <value>A unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The installation ID identifies the Web App installation.
        /// </summary>
        /// <value>The installation ID identifies the Web App installation.</value>
        [DataMember(Name="installationId", EmitDefaultValue=false)]
        public long? InstallationId { get; private set; }

        /// <summary>
        /// The ID of the space this object belongs to.
        /// </summary>
        /// <value>The ID of the space this object belongs to.</value>
        [DataMember(Name="linkedSpaceId", EmitDefaultValue=false)]
        public long? LinkedSpaceId { get; private set; }

        /// <summary>
        /// The name used to identify the processor.
        /// </summary>
        /// <value>The name used to identify the processor.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// The processor configuration created alongside the process within its designated space. This configuration is used in transactions created using this processor.
        /// </summary>
        /// <value>The processor configuration created alongside the process within its designated space. This configuration is used in transactions created using this processor.</value>
        [DataMember(Name="processorConfiguration", EmitDefaultValue=false)]
        public PaymentProcessorConfiguration ProcessorConfiguration { get; private set; }

        /// <summary>
        /// A URL pointing to the site where merchants can set up production mode for the processor.
        /// </summary>
        /// <value>A URL pointing to the site where merchants can set up production mode for the processor.</value>
        [DataMember(Name="productionModeUrl", EmitDefaultValue=false)]
        public string ProductionModeUrl { get; private set; }


        /// <summary>
        /// An SVG icon representing the processor, displayed to the user in the interface.
        /// </summary>
        /// <value>An SVG icon representing the processor, displayed to the user in the interface.</value>
        [DataMember(Name="svgIcon", EmitDefaultValue=false)]
        public string SvgIcon { get; private set; }

        /// <summary>
        /// The date and time when the processor was last updated.
        /// </summary>
        /// <value>The date and time when the processor was last updated.</value>
        [DataMember(Name="updatedOn", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; private set; }

        /// <summary>
        /// Whether the processor is fully prepared and available for handling transactions in a production environment.
        /// </summary>
        /// <value>Whether the processor is fully prepared and available for handling transactions in a production environment.</value>
        [DataMember(Name="usableInProduction", EmitDefaultValue=false)]
        public bool? UsableInProduction { get; private set; }

        /// <summary>
        /// the date and time when the processor became fully usable and available for handling transactions in a production environment.
        /// </summary>
        /// <value>the date and time when the processor became fully usable and available for handling transactions in a production environment.</value>
        [DataMember(Name="usableInProductionSince", EmitDefaultValue=false)]
        public DateTime? UsableInProductionSince { get; private set; }

        /// <summary>
        /// The version is used for optimistic locking and incremented whenever the object is updated.
        /// </summary>
        /// <value>The version is used for optimistic locking and incremented whenever the object is updated.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentAppProcessor {\n");
            sb.Append("  ConfiguredEnvironment: ").Append(ConfiguredEnvironment).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  DocumentationUrl: ").Append(DocumentationUrl).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstallationId: ").Append(InstallationId).Append("\n");
            sb.Append("  LinkedSpaceId: ").Append(LinkedSpaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProcessorConfiguration: ").Append(ProcessorConfiguration).Append("\n");
            sb.Append("  ProductionModeUrl: ").Append(ProductionModeUrl).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SvgIcon: ").Append(SvgIcon).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  UsableInProduction: ").Append(UsableInProduction).Append("\n");
            sb.Append("  UsableInProductionSince: ").Append(UsableInProductionSince).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentAppProcessor);
        }

        /// <summary>
        /// Returns true if PaymentAppProcessor instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentAppProcessor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentAppProcessor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfiguredEnvironment == input.ConfiguredEnvironment ||
                    (this.ConfiguredEnvironment != null &&
                    this.ConfiguredEnvironment.Equals(input.ConfiguredEnvironment))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.DocumentationUrl == input.DocumentationUrl ||
                    (this.DocumentationUrl != null &&
                    this.DocumentationUrl.Equals(input.DocumentationUrl))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InstallationId == input.InstallationId ||
                    (this.InstallationId != null &&
                    this.InstallationId.Equals(input.InstallationId))
                ) && 
                (
                    this.LinkedSpaceId == input.LinkedSpaceId ||
                    (this.LinkedSpaceId != null &&
                    this.LinkedSpaceId.Equals(input.LinkedSpaceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProcessorConfiguration == input.ProcessorConfiguration ||
                    (this.ProcessorConfiguration != null &&
                    this.ProcessorConfiguration.Equals(input.ProcessorConfiguration))
                ) && 
                (
                    this.ProductionModeUrl == input.ProductionModeUrl ||
                    (this.ProductionModeUrl != null &&
                    this.ProductionModeUrl.Equals(input.ProductionModeUrl))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.SvgIcon == input.SvgIcon ||
                    (this.SvgIcon != null &&
                    this.SvgIcon.Equals(input.SvgIcon))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.UsableInProduction == input.UsableInProduction ||
                    (this.UsableInProduction != null &&
                    this.UsableInProduction.Equals(input.UsableInProduction))
                ) && 
                (
                    this.UsableInProductionSince == input.UsableInProductionSince ||
                    (this.UsableInProductionSince != null &&
                    this.UsableInProductionSince.Equals(input.UsableInProductionSince))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                int hashCode = 41;
                if (this.ConfiguredEnvironment != null)
                    hashCode = hashCode * 59 + this.ConfiguredEnvironment.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.DocumentationUrl != null)
                    hashCode = hashCode * 59 + this.DocumentationUrl.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstallationId != null)
                    hashCode = hashCode * 59 + this.InstallationId.GetHashCode();
                if (this.LinkedSpaceId != null)
                    hashCode = hashCode * 59 + this.LinkedSpaceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProcessorConfiguration != null)
                    hashCode = hashCode * 59 + this.ProcessorConfiguration.GetHashCode();
                if (this.ProductionModeUrl != null)
                    hashCode = hashCode * 59 + this.ProductionModeUrl.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SvgIcon != null)
                    hashCode = hashCode * 59 + this.SvgIcon.GetHashCode();
                if (this.UpdatedOn != null)
                    hashCode = hashCode * 59 + this.UpdatedOn.GetHashCode();
                if (this.UsableInProduction != null)
                    hashCode = hashCode * 59 + this.UsableInProduction.GetHashCode();
                if (this.UsableInProductionSince != null)
                    hashCode = hashCode * 59 + this.UsableInProductionSince.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
